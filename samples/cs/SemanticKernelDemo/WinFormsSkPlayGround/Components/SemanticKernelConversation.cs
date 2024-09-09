using Microsoft.Extensions.DependencyInjection;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Design;

namespace SemanticKernelDemo.SemanticKernel;

#pragma warning disable SKEXP0010 
public class SemanticKernelConversation : BindableComponent
{
    private Kernel? _kernel;
    private ChatHistory? _chatHistory;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public string? ApiKey { get; set; }

    [Bindable(true), Browsable(true), DefaultValue(null), Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
    [Category("AI"), Description("Gets or sets the general instructions how to process requests.")]
    public string? AssistantInstructions { get; set; }

    [MemberNotNull(nameof(_kernel)), MemberNotNull(nameof(_chatHistory))]
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
        systemPrompt+= AssistantInstructions is null
            ? "\nYou are a personal assistant to the user."
            : $"\n{AssistantInstructions}";

        // This is where we keep the chat history.
        _chatHistory = new ChatHistory(systemPrompt);
    }

    public async IAsyncEnumerable<string> ProcessPromptAsync(string prompt)
    {
        if (_kernel is null || _chatHistory is null)
        {
            Initialize();
        }

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
}
#pragma warning restore SKEXP0010
