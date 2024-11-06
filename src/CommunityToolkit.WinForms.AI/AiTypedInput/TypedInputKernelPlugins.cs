using Microsoft.Extensions.Logging.Console;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using System.ComponentModel;

#pragma warning disable SKEXP0001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
#pragma warning disable SKEXP0010 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
public sealed partial class TypedInputKernelPlugin
{
    private const string ParameterAssistantInstructions = "assistantInstructions";

    /// <summary>
    /// Shows different ways to load a <see cref="KernelPlugin"/> instances.
    /// </summary>
    public async Task<string?> RunAsync()
    {
        var loggerOptions = new ConsoleLoggerOptions();

        // Create the ConsoleLoggerProvider directly
        using var loggerProvider = new ConsoleLoggerProvider(
            new SimpleOptionsMonitor<ConsoleLoggerOptions>(loggerOptions));
        
        var apiKey = Environment.GetEnvironmentVariable("AI:OpenAI:ApiKey")
            ?? throw new InvalidOperationException("Please set the 'AI:OpenAI:ApiKey' environment variable.");

        var kernelBuilder = Kernel.CreateBuilder()
                .AddOpenAIChatCompletion("gpt-4o", apiKey);

        // kernelBuilder.Plugins.AddFromType<TimeInformation>();
        var plugins = kernelBuilder.Plugins.AddFromType<TextSpellAndGrammarChecker>();

        Kernel kernel = kernelBuilder.Build();
        kernel.LoggerFactory.AddProvider(loggerProvider);

        var function = kernel.Plugins.GetFunction(nameof(TextSpellAndGrammarChecker), nameof(TextSpellAndGrammarChecker.ProcessString));

        var returnValue = await kernel.InvokeAsync(function,
            new KernelArguments()
            {
                ["TextToProcess"] = @"tis is A text i Am wrting witch i neet too bring in a good Form, so, it become usble."
            });

        IChatCompletionService chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();

        // To enable manual function invocation, set the `autoInvoke` parameter to `false`.
        OpenAIPromptExecutionSettings settings = new() 
        { 
            FunctionChoiceBehavior = FunctionChoiceBehavior.Required()
        };

        ChatHistory chatHistory = [];
        chatHistory.AddUserMessage("tis is A text i Am wrting witch i neet too bring in a good Form, so, it become usble.");

        ChatMessageContent result = await chatCompletionService.GetChatMessageContentAsync(chatHistory, settings, kernel);
        if (result.Content is not null)
        {
            Console.Write(result.Content);
            // Expected output: "The color of the sky in Boston is likely to be gray due to the rainy weather."
        }

        IEnumerable<FunctionCallContent> functionCalls = FunctionCallContent.GetFunctionCalls(result);
        if (functionCalls.Any())
        {
            chatHistory.Add(result);
            foreach (FunctionCallContent functionCall in functionCalls)
            {
                FunctionResultContent resultContent = await functionCall.InvokeAsync(kernel);

                // Adding the function result to the chat history
                chatHistory.Add(resultContent.ToChatMessage());
                Console.Write(resultContent.ToString());
            }
        }

        return "42";
    }

    /// <summary>
    /// A plugin that returns the current time.
    /// </summary>
    public class TimeInformation
    {
        [KernelFunction]
        [Description("Retrieves the current time in UTC.")]
        public string GetCurrentUtcTime() => DateTime.UtcNow.ToString("R");
    }

    /// <summary>
    /// A plugin that creates widgets.
    /// </summary>
    public class TextSpellAndGrammarChecker
    {
        [KernelFunction]
        [Description("Creates a new CheckedAndTranslateText instance, which checks the input for grammar and correct spelling and then translates it into the respective languages.")]
        public CheckedAndTranslatedPrompt ProcessString(
            [Description("The string corrected for grammar and spellchecking")] string correctedText,
            [Description("The string translated to German")] string germanTranslation,
            [Description("The string translated to Italian")] string italianTranslation)
        {
            return new CheckedAndTranslatedPrompt
            {
                CorrectedString = correctedText,
                GermanTranslatedString = germanTranslation,
                ItalianTranslatedString = italianTranslation
            };
        }
    }

    public class CheckedAndTranslatedPrompt
    {
        public string? CorrectedString { get; init; }
        public string? GermanTranslatedString { get; init; }
        public string? ItalianTranslatedString { get; init; }
    }
}
#pragma warning restore SKEXP0001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
#pragma warning restore SKEXP0010 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
