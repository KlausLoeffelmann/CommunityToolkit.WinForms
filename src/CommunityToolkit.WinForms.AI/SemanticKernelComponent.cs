using System.ComponentModel.Design;
using System.ComponentModel;
using System.Drawing.Design;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using System.Globalization;
using System.Reflection;

namespace CommunityToolkit.WinForms.AI;

public class SemanticKernelComponent<T> : BindableComponent
{
    private Kernel? _kernel;
    private KernelFunction? _kernelDataParserFunction;

    private const string ParameterAssistantInstructions = "assistantInstructions";
    private const string ParameterPromptCulture = "promptCulture";
    private const string ParameterPromptCurrentTime = "promptCurrentTime";
    private const string ParameterPromptValue = "promptValue";
    private const string ParameterPromptDataType = "promptDataType";

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public string? ApiKey { get; set; }

    [Bindable(true)]
    [Browsable(true)]
    [DefaultValue("string")]
    [Category("AI")]
    [Description("Gets or sets the .NET type name, the LLM should generate parsable string results for.")]
    public string? PromptTypeName { get; set; } = "string";

    [Bindable(true)]
    [Browsable(true)]
    [DefaultValue(null)]
    [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
    [Category("AI")]
    [Description("Gets or sets the value which the LLM should process based on the Assistant Instructions.")]
    public string? PromptDataValue { get; set; }

    [Bindable(true)]
    [Browsable(true)]
    [DefaultValue(null)]
    [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
    [Category("AI")]
    [Description("Gets or sets the general instructions how to process requests, which are provided via the PromptTypeName and the PromptDataValue properties.")]
    protected virtual string GetAssistantInstructions()
    {
        // The Assistant-Instructions are in an MD file and setup to be compiled as an embedded resource.
        // We need to get the resource stream and read the content:
        Assembly assembly = typeof(SemanticKernelComponent<T>).Assembly;
        using Stream stream = assembly.GetManifestResourceStream("SemanticKernelComponent.AssistantInstructions.md")!;
        using StreamReader reader = new(stream);

        return reader.ReadToEnd();
    }

    public async Task<string?> RequestPromptProcessingAsync(
        string promptTypeName,
        string promptContent)
    {
        if (ApiKey is null)
        {
            throw new InvalidOperationException("You have tried to request a prompt, but did not provide a key.");
        }

        if (string.IsNullOrWhiteSpace(GetAssistantInstructions()))
        {
            throw new InvalidOperationException("You have tried to request a prompt, but did not provide general description, what the Assistant is suppose to do.");
        }

        if (promptContent is null)
        {
            throw new InvalidOperationException("You have tried to request a prompt, but did not provide one.");
        }

        Initialize();

        if (_kernel == null)
        {
            throw new InvalidOperationException("Semantic Kernel could not been initialized");
        }

        return await GetResponseAsync(promptContent, promptTypeName);
    }

    private void Initialize()
    {
        var apiKey = ApiKey
            ?? throw new InvalidOperationException("The AI:OpenAI:ApiKey environment variable is not set.");

        _kernel = Kernel.CreateBuilder()
                .AddOpenAIChatCompletion("gpt-4-turbo", apiKey)
                .Build();

        _kernelDataParserFunction = _kernel.CreateFunctionFromPrompt(
            new PromptTemplateConfig()
            {
                Name = "AiComponentRequest",
                Description = "Request assistance which prompt parameters configured by a WinForms Component.",
                Template = GetAssistantInstructions(),
                TemplateFormat = "semantic-kernel",
                InputVariables =
                [
                    new() { Name = ParameterAssistantInstructions, Description = "The general instructions for the role which the LLM should incorporate.", IsRequired = true },
                    new() { Name = ParameterPromptValue, Description = "The Parameters in the context of the Prompt.", IsRequired = true },
                    new() { Name = ParameterPromptDataType, Description = "The DataType of the Prompt.", IsRequired = true },
                    new() { Name = ParameterPromptCulture, Description = "The Culture of the Prompt.", IsRequired = true },
                    new() { Name = ParameterPromptCurrentTime, Description = "The Current Time of the Prompt.", IsRequired = true }
                ],

                ExecutionSettings =
                {
                    {
                        "gpt-3.5-turbo",
                            new OpenAIPromptExecutionSettings()
                            {
                                ModelId = "gpt-3.5-turbo",
                                MaxTokens = 4000,
                                Temperature = 0.2
                            }
                    },
                    {
                        "gpt-4-turbo",
                            new OpenAIPromptExecutionSettings()
                            {
                                ModelId = "gpt-4-turbo",
                                MaxTokens = 4000,
                                Temperature = 0.2,
                                Seed = 10,
                            }
                    }
                }
            });
    }

    public async Task<string?> GetResponseAsync(
        string parameterPromptValue,
        string parameterPromptDataType)
    {
        if (_kernel is null || _kernelDataParserFunction is null)
        {
            throw new InvalidOperationException("The Semantic Kernel has not been initialized.");
        }

        var completion = await _kernelDataParserFunction.InvokeAsync<ChatMessageContent>(
            kernel: _kernel,
            arguments: new()
            {
                { ParameterAssistantInstructions, GetAssistantInstructions() },
                { ParameterPromptValue, parameterPromptValue },
                { ParameterPromptDataType, parameterPromptDataType },
                { ParameterPromptCulture, CultureInfo.CurrentCulture.ThreeLetterISOLanguageName },
                { ParameterPromptCurrentTime, DateTimeOffset.Now.ToString("yyyy-MM-ddTHH:mm:ssZ") }
            });

        var result = completion?.Content;
        return result;
    }

    public async IAsyncEnumerable<string> GetStreamingResponseAsync(
        string parameterPromptValue,
        string parameterPromptDataType)
    {
        if (_kernel is null || _kernelDataParserFunction is null)
        {
            throw new InvalidOperationException("The Semantic Kernel has not been initialized.");
        }

        var streamingCompletion = _kernelDataParserFunction.InvokeStreamingAsync<StreamingChatMessageContent>(
            kernel: _kernel,
            arguments: new()
            {
                { ParameterAssistantInstructions, GetAssistantInstructions() },
                { ParameterPromptValue, parameterPromptValue },
                { ParameterPromptDataType, parameterPromptDataType },
                { ParameterPromptCulture, CultureInfo.CurrentCulture.ThreeLetterISOLanguageName },
                { ParameterPromptCurrentTime, DateTimeOffset.Now.ToString("yyyy-MM-ddTHH:mm:ssZ") }
            });

        await foreach (var part in streamingCompletion)
        {
            if (part.Content is null)
            {
                continue;
            }

            yield return part.Content;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Kernel Kernel => _kernel
        ?? throw new InvalidOperationException($"Kernel is not initialized.");

}
#pragma warning restore SKEXP0010 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
