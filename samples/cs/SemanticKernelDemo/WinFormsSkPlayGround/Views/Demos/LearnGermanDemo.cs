using System.Speech.Synthesis;
using static WinFormsSkPlayGround.Properties.Resources;
using System.ComponentModel;

namespace WinFormsSkPlayGround.Views;

public partial class LearnGermanDemo : UserControl
{
    private CancellationTokenSource _cts = new CancellationTokenSource();
    private const string TestMethod = nameof(InvokeAsyncDemo);

    // The Oktoberfest support prompt!
    private const string systemPrompt =
        """
        Translate the following German text into English, using phonetic spelling 
        so that the English words sound as close as possible to the original German 
        words when spoken aloud. Use creative English spellings to match the 
        pronunciation of the German phrase.
        """;

    public LearnGermanDemo()
    {
        InitializeComponent();

        _skPhoneticEnglish.ApiKey = Environment
            .GetEnvironmentVariable(ApiKeyEnvironmentVarLookup);
    }

    private async Task BtnAsyncPhoneticTranslate_AsyncClick(object sender, EventArgs e)
    {
        var response = await _skPhoneticEnglish.GetResponseAsync(_germanTextPrompt.Text);
        await InvokeAsync(() => _txtPhoneticEnglish.Text = response);
    }

    private Task BtnAsyncReadPhoneticEnglishOutLoud_AsyncClick(object sender, EventArgs e)
    {
        PromptBuilder builder = new PromptBuilder();
        builder.AppendText(_txtPhoneticEnglish.Text);
        builder.Culture = new System.Globalization.CultureInfo("en-EN");

        var prompt = new Prompt(_txtPhoneticEnglish.Text);

        var voices = new SpeechSynthesizer().GetInstalledVoices();

        using (SpeechSynthesizer synthesizer = new())
        {
            // Configure the audio output.
            synthesizer.SelectVoice(voices[1].VoiceInfo.Name);
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Speak(builder);
        }

        return Task.CompletedTask;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int TestProperty { get; set; }

    private async Task InvokeAsyncDemo()
    {
        var someTaskAsync = async () =>
        {
            await Task.Delay(1000);
            MessageBox.Show("Hello from the UI thread!");
        };

        // If you want to have this func to be awaited,
        // return ValueTask and expect a cancellation token!
        Func<CancellationToken, ValueTask> correctTaskAsync = async (token) =>
        {
            await Task.Delay(1000);
            MessageBox.Show("Hello from the UI thread!");
        };

        await _txtPhoneticEnglish.InvokeAsync(correctTaskAsync);
    }
}
