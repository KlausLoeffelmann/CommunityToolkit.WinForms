using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.Ollama;
using System.Text;

namespace LocalLLms;

#pragma warning disable SKEXP0070 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
public partial class FrmMain : Form
{
    private const string OllamaModel = "phi3";
    private const string OllamaUri = "http://localhost:50000";

    public FrmMain()
    {
        InitializeComponent();
    }

    private async void BtnConnectLocal_Click(object sender, EventArgs e)
    {
        var chatService = new OllamaChatCompletionService(
             modelId: OllamaModel, 
             new Uri(OllamaUri));

        var chatHistory = new ChatHistory("You are a C# and VB teacher. You are training your students by giving the code snippets in both languages, in which they need to find the bugs which you placed.");
        chatHistory.AddUserMessage("Can you give me an easy exercise for VB?");

        var reply = await chatService.GetChatMessageContentAsync(chatHistory);
        chatHistory.AddAssistantMessage(GetTextFromReplyItems(reply.Items));
        _txtOutput.AppendText(reply + Environment.NewLine);
    }

    private static string GetTextFromReplyItems(ChatMessageContentItemCollection items)
    {
        var sb = new StringBuilder();
        foreach (var item in items)
        {
            sb.AppendLine(item.ToString());
        }

        return sb.ToString();
    }
}

#pragma warning restore SKEXP0070 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
