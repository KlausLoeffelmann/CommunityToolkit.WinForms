using System.Diagnostics.CodeAnalysis;

namespace WinFormsAsync;

public partial class FrmMain : Form
{
    private SevenSegmentTimer _sevenSegmentTimer;

    public FrmMain()
    {
        InitializeComponent();
        SetupTimerDisplay();
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
            Task UpdateUI()
                => InvokeAsync(async () =>
                {
                    await _sevenSegmentTimer.UpdateTimeAsync(
                        TimeOnly.FromDateTime(DateTime.Now));

                    await Task.Delay(100);
                });

            Task FadeInFadeOutAsync() 
                => InvokeAsync(async () =>
                    {
                        await _sevenSegmentTimer.FadeSeparatorsInAsync();
                        await _sevenSegmentTimer.FadeSeparatorsOutAsync();
                    });

            await Task.WhenAll(UpdateUI());
        }
    }
}
