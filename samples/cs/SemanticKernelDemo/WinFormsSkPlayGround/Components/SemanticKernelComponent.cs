using CommunityToolkit.WinForms.TypedInputExtenders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace SemanticKernelDemo.SemanticKernel;

#pragma warning disable SKEXP0010
public partial class SemanticKernelComponent : BindableComponent
{
    private Kernel? _kernel;
    private ChatHistory? _chatHistory;

    private double? _frequencyPenalty = default;
    private double? _presentsPenalty = default;
    private long? _seed = null;
    private double? _temperatur = 1.0;
    double? _topP = 1.0;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public string? ApiKey { get; set; }

    [Bindable(true)]
    [Browsable(true)]
    [DefaultValue(null)]
    [Category("AI")]
    [Description("Gets or sets the general instructions how to process requests.")]
    public string? AssistantInstructions { get; set; }

    /// <summary>
    /// Gets or sets the frequency penalty to apply during chat completion.
    /// </summary>
    /// <remarks>
    /// The frequency penalty is a value between 0 and 1 that penalizes the model for repeating the same response.
    /// A higher value will make the model less likely to repeat responses.
    /// </remarks>
    [DefaultValue(null)]
    public double? FrequencyPenalty
    {
        get => _frequencyPenalty;
        set => _frequencyPenalty = value;
    }

    /// <summary>
    /// Gets or sets the presence penalty to apply during chat completion.
    /// </summary>
    /// <remarks>
    /// The presence penalty is a value between 0 and 1 that penalizes the model for generating responses that are too long.
    /// A higher value will make the model more likely to generate shorter responses.
    /// </remarks>
    [DefaultValue(null)]
    public double? PresentsPenalty
    {
        get => _presentsPenalty;
        set => _presentsPenalty = value;
    }

    /// <summary>
    /// Gets or sets the seed value for random number generation during chat completion.
    /// </summary>
    /// <remarks>
    /// The seed value is used to initialize the random number generator used by the model.
    /// Setting a specific seed value will make the model generate the same responses for the same inputs.
    /// </remarks>
    [DefaultValue(null)]
    public long? Seed
    {
        get => _seed;
        set => _seed = value;
    }

    /// <summary>
    /// Gets or sets the temperature value for chat completion.
    /// </summary>
    /// <remarks>
    /// The temperature value controls the randomness of the model's responses.
    /// A higher value will make the responses more random, while a lower value 
    /// will make them more deterministic.
    /// </remarks>
    [DefaultValue(null)]
    public double? Temperature
    {
        get => _temperatur;
        set => _temperatur = value;
    }

    /// <summary>
    /// Gets or sets the top-p value for chat completion.
    /// </summary>
    /// <remarks>
    /// The top-p value is a value between 0 and 1 that controls the diversity 
    /// of the model's responses.
    /// A higher value will make the responses more diverse, while a lower value 
    /// will make them more focused.
    /// </remarks>
    [DefaultValue(1)]
    public double? TopP
    {
        get => _topP;
        set => _topP = value;
    }

    [DefaultValue(null)]
    public ITypedFormatterComponent? Formatter { get; set; }

    [MemberNotNull(nameof(_kernel), nameof(_chatHistory))]
    private void Initialize()
    {
        var apiKey = ApiKey
            ?? throw new InvalidOperationException("The AI:OpenAI:ApiKey environment variable is not set.");

        // We're using the GPT-4o model from OpenAI directory for our Semantic Kernel scenario.
        var kernelBuilder = Kernel.CreateBuilder().AddOpenAIChatCompletion("gpt-4o", apiKey);

        // Register the kernel as a service so we can query the service later.
        kernelBuilder.Services.AddTransient((serviceProvider) => new Kernel(serviceProvider));

        // Build the kernel:
        _kernel = kernelBuilder.Build();

        // Let's build the system prompt.
        string systemPrompt = $"Today is {DateTime.Now:G}";
        systemPrompt += AssistantInstructions is null
            ? "\nYou are a personal assistant to the user."
            : $"\n{AssistantInstructions}";

        // This is where we keep the chat history.
        _chatHistory = new ChatHistory(systemPrompt);
    }

    /// <summary>
    /// Processes a prompt asynchronously and returns a stream of chat responses.
    /// </summary>
    /// <param name="prompt">The prompt to process.</param>
    /// <returns>A stream of chat responses.</returns>
    public async IAsyncEnumerable<string> RequestResponseStreamAsync(string prompt)
    {
        if (_kernel is null || _chatHistory is null)
        {
            Initialize();
        }

        PromptExecutionSettings executionSettings = new OpenAIPromptExecutionSettings()
        {
            FrequencyPenalty = FrequencyPenalty,
            PresencePenalty = PresentsPenalty,
            Seed = Seed,
            Temperature = Temperature,
            TopP = TopP
        };

        var chatCompletionService = _kernel.GetRequiredService<IChatCompletionService>();
        _chatHistory.AddUserMessage(prompt);

        var responses = chatCompletionService.GetStreamingChatMessageContentsAsync(_chatHistory, kernel: _kernel);
        responses = _chatHistory.AddStreamingMessageAsync((IAsyncEnumerable<OpenAIStreamingChatMessageContent>)responses);

        await foreach (var response in responses)
        {
            if (response.Content is null)
            {
                continue;
            }

            yield return response.Content;
        }
    }

    public async Task<ResponseValueResult<T>> TryGetValueFromJsonAsync<T>(string prompt)
    {
        ArgumentNullException.ThrowIfNullOrWhiteSpace(prompt);
        ArgumentNullException.ThrowIfNull(Formatter);

        try
        {
            (bool succeeded, string jsonResultString) = CheckAndRemoveCodeTags(prompt);

            using JsonDocument doc = JsonDocument.Parse(jsonResultString);
            JsonElement root = doc.RootElement;

            if (root.TryGetProperty("returnValue", out JsonElement returnValueElement))
            {
                string rawValue = returnValueElement.GetString()!;

                T? parsedValue = (T?) await Formatter.TryGetValueAsync(rawValue);

                return new ResponseValueResult<T>("OK", parsedValue);
            }
            else if (root.TryGetProperty("errorMessage", out JsonElement errorMessageElement))
            {
                string errorMessage = errorMessageElement.GetString()!;

                return new(errorMessage, default);
            }
            else
            {
                string errorMessage = $"We got an issue processing the results:\nThe returned data was unclear.";
                return new(errorMessage, default!);
            }
        }
        catch (JsonException jEx)
        {
            string errorMessage = $"We got an issue processing the results:\n{jEx.Message}";
            return new(errorMessage, default!);
        }
        catch (Exception ex)
        {
            string errorMessage = $"We got an issue processing the results:\n{ex.Message}";
            return new(errorMessage, default!);
        }
    }

    // Method to check for and remove code tags from a string.
    public static (bool, string) CheckAndRemoveCodeTags(string input)
    {
        // Regex pattern to match code blocks with optional language specifier
        var regex = new Regex(@"^```[a-zA-Z]*\s*\n?([\s\S]*?)\n?```$");
        var match = regex.Match(input);

        if (match.Success)
        {
            // Remove the code tags and trim any excess whitespace/newlines
            return (true, match.Groups[1].Value.Trim());
        }
        return (false, input);
    }

    public async Task<string> GetResponseAsync(string prompt, TextBoxBase? textBox = default)
    {
        try
        {
            if (_kernel is null || _chatHistory is null)
            {
                Initialize();
            }

            var responses = RequestResponseStreamAsync(prompt);
            StringBuilder responseStringBuilder = new();

            await foreach (var response in responses)
            {
                responseStringBuilder.Append(response);

                if (textBox is null)
                {
                    continue;
                }

                await textBox.InvokeAsync(() =>
                {
                    textBox.AppendText(response);
                    textBox.ScrollToCaret();
                });
            }

            return responseStringBuilder.ToString();
        }
        catch (Exception ex)
        {
            // Handle or log the exception as needed
            throw new InvalidOperationException("An error occurred while processing the response.", ex);
        }
    }
}
#pragma warning restore SKEXP0010
