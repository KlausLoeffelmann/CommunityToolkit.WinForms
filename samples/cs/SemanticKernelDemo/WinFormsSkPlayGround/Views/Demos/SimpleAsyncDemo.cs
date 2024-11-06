using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace WinFormsSkPlayGround.Views;

public partial class SimpleAsyncDemo : UserControl
{
    private CancellationTokenSource? _spinnerTokenSource;
    private CancellationTokenSource? _colorTokenSource;

    [AllowNull]
    private readonly StatusStrip _statusStrip;

    public SimpleAsyncDemo(Form mainForm)
    {
        InitializeComponent();
        MainForm = mainForm;
        _statusStrip=MainForm
            .Controls
            .OfType<Control>()
            .Where(c => c is StatusStrip)
            .FirstOrDefault() as StatusStrip;
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
        if (_spinnerTokenSource is not null)
        {
            _spinnerTokenSource.Cancel();
            _spinnerTokenSource.Dispose();
            _spinnerTokenSource = null;
            return;
        }

        _spinnerTokenSource = new();
        await _spinner.SpinAsync(_spinnerTokenSource!.Token);
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

            await InvokeAsync(() => MainForm.FormCaptionBackColor = ColorAnimator.Default.Trigger());
            await Task.Delay(20);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Form MainForm { get; set; }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        Disposed += (_, _) =>
        {
            _spinnerTokenSource?.Cancel();
            _colorTokenSource?.Cancel();

            _spinnerTokenSource?.Dispose();
            _colorTokenSource?.Dispose();
        };
    }

    private ToolStripLabel GetNextInfoPanel()
    {
        var infoPanel = new ToolStripLabel();
        _statusStrip.Items.Add(infoPanel);

        return infoPanel;
    }

    private void ReturnInfoPanel(ToolStripLabel infoPanel)
    {
        _statusStrip.Items.Remove(infoPanel);
        infoPanel.Dispose();
    }

    private void BlockingTextBox_LostFocus(object sender, EventArgs e)
    {
        if (_txtBlockingTextBoxFocus.Text.Length == 0) return;

        // This takes 50 deci-seconds = 10 seconds.
        LongOperation(100, GetNextInfoPanel());
    }

    private void LongOperation(int deciSeconds, ToolStripLabel infoPanel)
    {
        int threadId = Environment.CurrentManagedThreadId;

        for (int i = 0; i < deciSeconds; i++)
        {
            infoPanel.Text = $"T-ID {threadId:00}:Count {i:00}";
            _statusStrip.Update();
            Thread.Sleep(100);
        }

        ReturnInfoPanel(infoPanel);
    }

    private async void NonBlockingTextBox_LostFocus(object sender, EventArgs e)
    {
        if (_txtNonBlockingTextBox.Text.Length == 0) return;

        try
        {
            // This also takes 50 deci-seconds = 10 seconds, but it's non-blocking!
            await LongOperationAsync(100, GetNextInfoPanel());
        }
        catch (Exception ex) when (ex is not StackOverflowException or OutOfMemoryException)
        {
        }
    }

    private async Task LongOperationAsync(int deciSeconds, ToolStripLabel infoPanel)
    {
        for (int i = 0; i < deciSeconds; i++)
        {
            int threadId = Environment.CurrentManagedThreadId;

            await InvokeAsync(() => infoPanel.Text = $"T-ID {threadId:00}:Count {i:00}");
            await Task.Delay(100).ConfigureAwait(false);
        }

        await InvokeAsync(() => ReturnInfoPanel(infoPanel));
    }
}
