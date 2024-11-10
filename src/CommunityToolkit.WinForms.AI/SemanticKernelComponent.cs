using DemoToolkit.Mvvm.WinForms.Components;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using System.ComponentModel;
using System.Text;

namespace CommunityToolkit.WinForms.AI;

#pragma warning disable SKEXP0010 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
public class SemanticKernelComponent : BindableComponent
{
    public event AsyncEventHandler<AsyncRequestAssistantInstructionsEventArgs>? AsyncRequestAssistanceInstructions;
    public event AsyncEventHandler<AsyncRequestExecutionSettingsEventArgs>? AsyncRequestExecutionSettings;

    // The chat history. If you are using ChatGPT for example directly in the WebBrowser,
    // this equals the chat history, so, the things you've said and the responses you've received.
    private ChatHistory? _chatHistory;

    // The kernel for the Semantic Kernel scenario. It bundles the connectors and services.
    private Kernel? _kernel;

    // The parentForm, which we might need to invoke the UI thread.
    private Form? _parentForm;
    private double? _topP;
    private double? _temperature;
    private long? _seed;
    private double? _presencePenalty;
    private double? _frequencyPenalty;

    [Browsable(false)]
    [DefaultValue(null)]
    public string? PromptDataValue { get; set; }

    public async Task<string?> RequestTextPromptResponseAsync(
        string valueToProcess)
    {
        if (string.IsNullOrWhiteSpace(valueToProcess))
            throw new InvalidOperationException("You requested to process a prompt, but did not provide any content to process.");

        if (ChatHistory is null)
            throw new InvalidOperationException("You requested to process a prompt, but the ChatHistory is not set.");

        var (chatService, executionSettings) = await GetOrCreateChatServiceAsync();

        var responses = await chatService.GetChatMessageContentsAsync(
            ChatHistory,
            kernel: _kernel,
            executionSettings: executionSettings);

        StringBuilder responseStringBuilder = new();

        // We can have several responses, so we'll append them all to the text box.
        // But we need to also add them to the chat history!
        foreach (ChatMessageContent response in responses)
        {
            ChatHistory.AddMessage(response.Role, response.ToString());
            responseStringBuilder.Append(response);
        }

        return responseStringBuilder.ToString();
    }

    public async IAsyncEnumerable<string> RequestPromptResponseStreamAsync(string valueToProcess)
    {
        if (string.IsNullOrWhiteSpace(valueToProcess))
            throw new InvalidOperationException("You requested to process a prompt, but did not provide any content to process.");

        if (ChatHistory is null)
            throw new InvalidOperationException("You requested to process a prompt, but the ChatHistory is not set.");

        var (chatService, executionSettings) = await GetOrCreateChatServiceAsync();

        var responses = chatService.GetStreamingChatMessageContentsAsync(
            ChatHistory,
            executionSettings: executionSettings,
            kernel: _kernel);

        responses = ChatHistory.AddStreamingMessageAsync(
            (IAsyncEnumerable<OpenAIStreamingChatMessageContent>)responses);

        await foreach (var response in responses)
        {
            if (response.Content is null)
            {
                continue;
            }

            yield return response.Content;
        }
    }

    private async Task<(OpenAIChatCompletionService chatService, OpenAIPromptExecutionSettings executionSettings)> GetOrCreateChatServiceAsync()
    {
        if (ApiKeyGetter is null)
            throw new InvalidOperationException("You have tried to request a prompt, but did not provide Func delegate to get the api key.");

        AsyncRequestAssistantInstructionsEventArgs eArgs = new(GetAssistantInstructions());
        await OnRequestAssistantInstructionsAsync(eArgs);

        OpenAIPromptExecutionSettings executionSettings = new();
        executionSettings
            .WithSystemPrompt(eArgs.AssistantInstructions)
                    .WithDefaultModelParameters(
                        MaxTokens: 8000,
                        temperature: Temperature,
                        topP: TopP,
                        frequencyPenalty: _frequencyPenalty,
                        presencePenalty: _presencePenalty);

        AsyncRequestExecutionSettingsEventArgs settingsEventArgs = new(executionSettings);
        await OnRequestExecutionSettingsAsync(settingsEventArgs);

        if (string.IsNullOrWhiteSpace(eArgs.AssistantInstructions))
            throw new InvalidOperationException("You have tried to request a prompt, but did not provide general description, what the Assistant is suppose to do.");

        string apiKey = Environment.GetEnvironmentVariable(ApiKeyGetter.Invoke())
            ?? throw new InvalidOperationException("The AI:OpenAI:ApiKey environment variable is not set.");

        // We're using the GPT-4o model from OpenAI directory for our Semantic Kernel scenario.
        var kernelBuilder = Kernel
            .CreateBuilder()
            .AddOpenAIChatCompletion(ModelName, apiKey);

        _kernel = kernelBuilder.Build();

        _chatHistory ??= [];

        var chatService = (OpenAIChatCompletionService)_kernel.GetRequiredService<IChatCompletionService>();

        return (chatService, settingsEventArgs.ExecutionSettings);
    }

    protected virtual string GetAssistantInstructions() 
        => "You are an Assistant for helping Developers with questions around .NET, C# and Visual Basic.";

    protected virtual Task OnRequestAssistantInstructionsAsync(AsyncRequestAssistantInstructionsEventArgs eArgs) 
        => AsyncRequestAssistanceInstructions?.Invoke(this, eArgs)
            ?? Task.CompletedTask;


    protected virtual Task OnRequestExecutionSettingsAsync(AsyncRequestExecutionSettingsEventArgs eArgs) 
        => AsyncRequestExecutionSettings?.Invoke(this, eArgs)
            ?? Task.CompletedTask;

    /// <summary>
    ///  Gets or sets a Func that returns the API key to use for the OpenAI API. 
    ///  Don't ever store the key in the source code! Rather put it for example in a environment variable, or even better,
    ///  get it from a secure storage like Azure Key Vault.
    /// </summary>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Func<string>? ApiKeyGetter { get; set; }

    [Bindable(true)]
    [Browsable(true)]
    [DefaultValue("string")]
    [Category("AI")]
    [Description("Gets or sets the .NET type name, the LLM should generate parsable string results for.")]
    public string? JsonSchema { get; set; } = null;

    /// <summary>
    ///  Gets or sets the resource string source for the Assistant Instructions.
    /// </summary>
    [DefaultValue(null)]
    public string? ResourceStreamSource { get; set; }

    /// <summary>
    ///  Gets or sets the chat history for the Semantic Kernel scenario.
    /// </summary>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ChatHistory? ChatHistory => _chatHistory;

    /// <summary>
    ///  Gets or sets the model name to use for chat completion.
    /// </summary>
    [DefaultValue("gpt-4o")]
    public string ModelName { get; set; } = "gpt-4o";

    /// <summary>
    ///  Gets or sets the frequency penalty to apply during chat completion.
    /// </summary>
    /// <remarks>
    ///  The frequency penalty is a value between 0 and 1 that penalizes the model for repeating the same response.
    ///  A higher value will make the model less likely to repeat responses.
    /// </remarks>
    [DefaultValue(null)]
    public double? FrequencyPenalty
    {
        get => _frequencyPenalty;
        set => _frequencyPenalty = value;
    }

    /// <summary>
    ///  Gets or sets the presence penalty to apply during chat completion.
    /// </summary>
    /// <remarks>
    ///  The presence penalty is a value between 0 and 1 that penalizes the model for generating responses that are too long.
    ///  A higher value will make the model more likely to generate shorter responses.
    /// </remarks>
    [DefaultValue(null)]
    public double? PresencePenalty
    {
        get => _presencePenalty;
        set => _presencePenalty = value;
    }

    /// <summary>
    ///  Gets or sets the temperature value for chat completion.
    /// </summary>
    /// <remarks>
    ///  The temperature value controls the randomness of the model's responses.
    ///  A higher value will make the responses more random, while a lower value 
    ///  will make them more deterministic.
    /// </remarks>
    [DefaultValue(null)]
    public double? Temperature
    {
        get => _temperature;
        set => _temperature = value;
    }

    /// <summary>
    ///  Gets or sets the top-p value for chat completion.
    /// </summary>
    /// <remarks>
    ///  The top-p value is a value between 0 and 1 that controls the diversity 
    ///  of the model's responses.
    ///  A higher value will make the responses more diverse, while a lower value 
    ///  will make them more focused.
    /// </remarks>
    [DefaultValue(1)]
    public double? TopP
    {
        get => _topP;
        set => _topP = value;
    }
}
#pragma warning restore SKEXP0010 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
