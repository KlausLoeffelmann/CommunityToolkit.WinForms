using System.ComponentModel;

namespace WinFormsSkPlayGround.Views;

public partial class SimpleAsyncDemo : UserControl
{
    private CancellationTokenSource? _cancellationTokenSource;
    private CancellationTokenSource? _colorTokenSource;

    public SimpleAsyncDemo(Form mainForm)
    {
        InitializeComponent();
        MainForm = mainForm;
    }

    private async void Spinner_ClickHandler(object sender, EventArgs e)
    {
        await ToggleSpinningAsync();
    }

    private async void Spinner_DoubleClick(object sender, EventArgs e)
    {
        await ColorBlender();
    }

    private async Task ToggleSpinningAsync()
    {
        if (_cancellationTokenSource is not null)
        {
            _cancellationTokenSource.Cancel();
            _cancellationTokenSource.Dispose();
            _cancellationTokenSource = null;
            return;
        }

        _cancellationTokenSource = new();
        await _spinner.SpinAsync(_cancellationTokenSource!.Token);
    }

    private async Task ColorBlender()
    {
        if (_colorTokenSource is not null)
        {
            _colorTokenSource.Cancel();
            _colorTokenSource.Dispose();
            _colorTokenSource = null;
            return;
        }

        _colorTokenSource = new();

        for (; ; )
        {
            if (_colorTokenSource is null 
                || _colorTokenSource.IsCancellationRequested)
            {
                break;
            }

#pragma warning disable WFO5001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
            await InvokeAsync(() => MainForm.FormCaptionBackColor = ColorAnimator.Default.Trigger());
#pragma warning restore WFO5001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

            await Task.Delay(20);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Form MainForm { get; set; }
}
