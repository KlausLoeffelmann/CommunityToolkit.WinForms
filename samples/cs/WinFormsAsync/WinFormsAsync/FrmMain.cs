using System.Diagnostics.CodeAnalysis;

namespace WinFormsAsync;

public partial class FrmMain : Form
{
    private SevenSegmentTimer _sevenSegmentTimer;
    private CancellationTokenSource _formCloseCancellation = new();

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

        //while (true)
        //{
        //    await _sevenSegmentTimer.UpdateTimeAsync(
        //        TimeOnly.FromDateTime(DateTime.Now));

        //    await Task.Delay(100);
        //}

        while (true)
        {
            async Task UpdateUI(CancellationToken cancellation)
            {
                await _sevenSegmentTimer.UpdateTimeAsync(
                    TimeOnly.FromDateTime(DateTime.Now));

                await Task.Delay(100, cancellation);
            }

            async Task FadeInFadeOutAsync(CancellationToken cancellation)
            {
                await _sevenSegmentTimer.FadeSeparatorsInAsync(cancellation).ConfigureAwait(false);
                await _sevenSegmentTimer.FadeSeparatorsOutAsync(cancellation).ConfigureAwait(false);
            }

            await UpdateUI(_formCloseCancellation.Token);
            await FadeInFadeOutAsync(_formCloseCancellation.Token);
        }
    }
}
