using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Text;

namespace CommunityToolkit.WinForms.TypedInputExtenders;

public class SpinnerControl : Label
{
    public event EventHandler? IsSpinningChanged;

    private const string BootFontPath = "Boot\\Fonts_EX";
    private const string FontFileName = "segoe_slboot_EX.ttf";

    // There is a special Font in the Windows Folder, that - if we
    // use a certain range of characters - will be doing something really cool!
    // You've seen it before - lots of times!
    private static readonly char[] s_charParts = CharSequence(0xE052..0xE0CB);
    private static readonly string s_pausingCharPart = $"{s_charParts[24]}";

    private static PrivateFontCollection s_fontCollection = new();

    private bool _isSpinning;
    private CancellationTokenSource? _cancellationTokenSource;
    private TaskCompletionSource _initializedCompletion = new();

    public SpinnerControl()
    {
        DoubleBuffered = true;
        _isSpinning = false;

        LoadBootFontFromBootFolder();
    }

    // Using the "new" PeriodicTimer from .NET 6 and
    // our new WinForms API: Control.InvokeAsync
    public async Task SpinAsync(CancellationToken cancellationToken)
    {
        try
        {
            await _initializedCompletion.Task;
            int partCount = 0;

            for (; ; )
            {
                if (cancellationToken.IsCancellationRequested)
                    break;

                // New in .NET 9: Control.InvokeAsync
                await InvokeAsync(() => Text = $"{s_charParts[partCount++]}");
                await Task.Delay(20, cancellationToken);

                partCount %= s_charParts.Length;
            }
        }
        catch (OperationCanceledException)
        {
        }
        finally
        {
            Text = s_pausingCharPart;
        }
    }

    private static char[] CharSequence(Range range)
        => Enumerable
            .Range(
                start: range.Start.Value,
                count: range.End.Value - range.Start.Value + 1)
            .Select(i => (char)i)
            .ToArray();

    private static void LoadBootFontFromBootFolder()
    {
        string windowsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
        string bootFolderPath = Path.Combine(windowsFolderPath, BootFontPath);
        s_fontCollection.AddFontFile(Path.Combine(bootFolderPath, FontFileName));
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Bindable(true)]
    [Browsable(true)]
    public bool IsSpinning
    {
        get => _isSpinning;
        set
        {
            if (_isSpinning == value)
            {
                return;
            }

            _isSpinning = value;
            OnIsSpinningChanged(EventArgs.Empty);
        }
    }

    protected async virtual void OnIsSpinningChanged(EventArgs e)
    {
        IsSpinningChanged?.Invoke(this, e);

        if (_cancellationTokenSource is not null)
        {
            _cancellationTokenSource.Cancel();
            _cancellationTokenSource.Dispose();
            _cancellationTokenSource = null;
            Text = s_pausingCharPart;

            return;
        }

        _cancellationTokenSource = new();
        await SpinAsync(_cancellationTokenSource.Token);
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Bindable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [AllowNull]
    public override string Text
    {
        get => base.Text;
        set => base.Text = value;
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        Font = new Font(s_fontCollection.Families[0], Font.Size + 2);
        ForeColor = SystemColors.ControlText;
        Text = s_pausingCharPart;
        AutoSize = true;
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        _initializedCompletion.SetResult();
    }

    protected override void Dispose(bool disposing)
    {
        IsSpinning = false;
        base.Dispose(disposing);
    }
}
