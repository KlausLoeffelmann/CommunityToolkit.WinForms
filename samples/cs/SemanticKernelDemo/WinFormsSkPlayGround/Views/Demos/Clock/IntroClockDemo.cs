using System.ComponentModel;

namespace WinFormsSkPlayGround.Views;

[ToolboxBitmap(typeof(IntroClockDemo), "MvvmView.bmp")]
public partial class IntroClockDemo : ContainerControl
{
    private readonly CancellationTokenSource _cancellationTokenSource = new();
    private readonly ClockRenderer _clockRenderer;

    [DefaultValue(HourMarksStyle.BinaryNumerals)]
    public HourMarksStyle MarksStyle { get; set; } = HourMarksStyle.BinaryNumerals;

    public IntroClockDemo()
    {
        DoubleBuffered = true;
        _clockRenderer = new ClockRenderer(MarksStyle);
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Invalidate();
    }

    protected override async void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        await ClockLoopAsync();
    }

    protected override void Dispose(bool disposing)
    {
        _cancellationTokenSource.Cancel();
        base.Dispose(disposing);
    }

    private async Task ClockLoopAsync()
    {
        CancellationToken token = _cancellationTokenSource.Token;

        while (true)
        {
            Invalidate();
            try
            {
                await Task.Delay(100, token);
            }
            catch (TaskCanceledException)
            {
                break;
            }

            if (_cancellationTokenSource.IsCancellationRequested)
                break;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        _clockRenderer.HourMarksStyle = MarksStyle;
        _clockRenderer.DrawClock(e.Graphics, Width, Height);
    }
}
