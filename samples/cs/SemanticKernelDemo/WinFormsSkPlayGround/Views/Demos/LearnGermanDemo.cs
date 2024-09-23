using System.Speech.Synthesis;
using static WinFormsSkPlayGround.Properties.Resources;

namespace WinFormsSkPlayGround.Views;

public partial class LearnGermanDemo : UserControl
{
    public LearnGermanDemo()
    {
        InitializeComponent();
        _skPhoneticEnglish.ApiKey = Environment
            .GetEnvironmentVariable(ApiKeyEnvironmentVarLookup);
    }

    private async Task _btnAsyncPhoneticTranslate_AsyncClick(object sender, EventArgs e)
    {
        _txtPhoneticEnglish.Text = await _skPhoneticEnglish.GetResponseAsync(
            _germanTextPrompt.Text);
    }

    private void BtnAsyncReadOutLoud_Click(object sender, EventArgs e)
    {
        PromptBuilder builder = new PromptBuilder();
        builder.AppendText(_txtPhoneticEnglish.Text);
        builder.Culture = new System.Globalization.CultureInfo("de-DE");

        try
        {
        }
        finally
        {
        }
    }
}
