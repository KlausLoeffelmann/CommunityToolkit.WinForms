using SemanticKernelDemo.Controls;
using static WinFormsSkPlayGround.Properties.Resources;

namespace WinFormsSkPlayGround.Views;

[ToolboxBitmap(typeof(AIPlayGroundView), "MvvmView.bmp")]
public partial class AIPlayGroundView : UserControl
{
    public AIPlayGroundView()
    {
        InitializeComponent();
    }

    internal void RequestBrowserTools() =>
        _conversationView.WebView.CoreWebView2.OpenDevToolsWindow();

    private async Task PromptControl_AsyncSendPrompt(object sender, EventArgs e)
    {
        _semanticKernelConversation.ApiKeyGetter =
            () => Environment.GetEnvironmentVariable(ApiKeyEnvironmentVarLookup)
                ?? throw new NullReferenceException("Could not retrieve Open AI ApiKey.");

        string textToSend = _promptControl.Text;
        _promptControl.Clear();

        _conversationView.AddConversationItem(textToSend, isResponse: false);

        var responses = _conversationView.UpdateCurrentResponseAsync(
            _semanticKernelConversation.RequestPromptResponseStreamAsync(textToSend, true));

        await foreach (var response in responses)
        {
            if (response is null)
            {
                continue;
            }
        }
    }

    private async void PromptControl_NewPromptSuggestionRequest(object sender, EventArgs e)
    {
        string funnyRandomPrompt = FunnyPromptsProvider.GetRandomPrompt();
        _promptControl.Text = funnyRandomPrompt;

        // We use a side-affect of InvokeAsync to schedule this,
        // so that the text is set _before_ we select it.
        await _promptControl.InvokeAsync(() => _promptControl.SelectAll());
    }
}
