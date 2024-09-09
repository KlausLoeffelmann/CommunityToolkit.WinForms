using SemanticKernelDemo.Controls;
using WinFormsSkPlayGround;

namespace SemanticKernelDemo;

public partial class FrmMain : Form
{
    private readonly IServiceProvider? _serviceProvider;

    public FrmMain()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
    }

    public FrmMain(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        InitializeComponent();
    }

    private async void PromptControl_SendPrompt(object sender, EventArgs e)
    {
        _semanticKernelConversation.ApiKey = Environment.GetEnvironmentVariable("AI:OpenAi:ApiKey");
        string textToSend = _promptControl.Text;
        _promptControl.Clear();

        _conversationView.AddConversationItem(textToSend, isResponse: false);
        var responses = _conversationView.UpdateCurrentResponseAsync(_semanticKernelConversation.ProcessPromptAsync(textToSend));

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

    private void BrowserDeveloperToolsToolStripMenuItem_Click(object sender, EventArgs e)
        => _conversationView.WebView.CoreWebView2.OpenDevToolsWindow();

    private void _toolTip_Popup(object sender, PopupEventArgs e)
    {
        e.ToolTipSize = new Size(300, 200);
    }

    private void _toolTip_Draw(object sender, DrawToolTipEventArgs e)
    {

    }

    private void Solon_LetsCallBackThe80sToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var retroForm = new frmRetro();
        retroForm.Show();
    }
}
