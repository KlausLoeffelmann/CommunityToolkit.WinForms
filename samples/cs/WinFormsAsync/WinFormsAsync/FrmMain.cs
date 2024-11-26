using System.Diagnostics.CodeAnalysis;

namespace WinFormsAsync;

public partial class FrmMain : Form
{
    private SevenSegmentTimer _sevenSegmentTimer;
    private readonly CancellationTokenSource _formCloseCancellation = new();

    public FrmMain()
    {
        InitializeComponent();
        SetupTimerDisplay();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);
        _formCloseCancellation.Cancel();
    }

    [MemberNotNull(nameof(_sevenSegmentTimer))]
    private void SetupTimerDisplay()
    {
        _sevenSegmentTimer = new SevenSegmentTimer
        {
            Dock = DockStyle.Fill
        };

        Controls.Add(_sevenSegmentTimer);
    }

    override async protected void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        await RunDisplayLoopAsync();
    }

    private async Task RunDisplayLoopAsync()
    {
        Task? uiUpdateTask = null;
        Task? separatorFadingTask = null;

        while (true)
        {
            async Task UpdateUI(CancellationToken cancellation)
            {
                _sevenSegmentTimer.UpdateTime(
                    TimeOnly.FromDateTime(DateTime.Now));

                await Task.Delay(100, cancellation);
            }

            async Task FadeInFadeOutAsync(CancellationToken cancellation)
            {
                await _sevenSegmentTimer.FadeSeparatorsInAsync(cancellation).ConfigureAwait(false);
                await _sevenSegmentTimer.FadeSeparatorsOutAsync(cancellation).ConfigureAwait(false);
            }

            uiUpdateTask ??= UpdateUI(_formCloseCancellation.Token);
            separatorFadingTask ??= FadeInFadeOutAsync(_formCloseCancellation.Token);
            Task completedTask = await Task.WhenAny(separatorFadingTask, uiUpdateTask);

            if (completedTask == uiUpdateTask)
            {
                uiUpdateTask = null;
            }
            else
            {
                separatorFadingTask = null;
            }
        }
    }
}
