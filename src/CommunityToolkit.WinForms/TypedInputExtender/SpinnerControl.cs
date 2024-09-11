using System.ComponentModel;
using System.Drawing.Text;

namespace CommunityToolkit.WinForms.TypedInputExtenders;

public class SpinnerControl : Label
{
    public event EventHandler? IsSpinningChanged;

    private const string BootFontPath = "Boot\\Fonts_EX";
    private const string FontFileName = "segoe_slboot_EX.ttf";

    // Just to know, how this works: This...
    private char[] _simpleCharArray = CharSequence(65..96);
    // ...would produce the following string:
    // "ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz{|}~"

    // Well - there is a special Font in the Windows Folder, that - if we
    // use a certain range of characters - will be doing something really cool!
    // Keep that in mind, when you're trying this!
    private char[] _charParts = CharSequence(0xE052..0xE0CB);

    private PrivateFontCollection _fontCollection;
    private bool _isSpinning;
    private CancellationTokenSource? _cancellationTokenSource;

    public SpinnerControl()
    {
        DoubleBuffered = true;
        _fontCollection = new PrivateFontCollection();
        _isSpinning = false;
        Text = "X";

        LoadBootFontFromBootFolder();
    }

    // Using the "new" PeriodicTimer from .NET 6 and
    // our new WinForms API: Control.InvokeAsync
    public async Task SpinAsync(CancellationToken cancellationToken)
    {
        var timer = new PeriodicTimer(TimeSpan.FromMilliseconds(20));

        try
        {
            int partCount = 0;

            while (await timer.WaitForNextTickAsync(cancellationToken))
            {
                if (cancellationToken.IsCancellationRequested)
                    break;

                // New in .NET 9: Control.InvokeAsync
                await InvokeAsync(
                    callback: async () => await DrawSpinnerPartAsync(
                        partCount: partCount++,
                        cancellationToken: cancellationToken),
                    cancellationToken: cancellationToken);

                partCount %= _charParts.Length;
            }
        }
        catch (OperationCanceledException)
        {
        }
        finally
        {
            timer?.Dispose();
            Text = string.Empty;
        }
    }

    private async ValueTask DrawSpinnerPartAsync(int partCount, CancellationToken cancellationToken)
    {
        Text = _charParts[partCount].ToString();

        try
        {
            await Task.Delay(60, cancellationToken);
        }
        catch (OperationCanceledException)
        {
        }
    }

    private static char[] CharSequence(Range range)
        => Enumerable
            .Range(
                start: range.Start.Value,
                count: range.End.Value - range.Start.Value + 1)
            .Select(i => (char)i)
            .ToArray();

    private void LoadBootFontFromBootFolder()
    {
        string windowsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
        string bootFolderPath = Path.Combine(windowsFolderPath, BootFontPath);
        _fontCollection.AddFontFile(Path.Combine(bootFolderPath, FontFileName));
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
            Text = " ";

            return;
        }

        _cancellationTokenSource = new CancellationTokenSource();
        await SpinAsync(_cancellationTokenSource.Token);
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        Text = " ";

        if (IsAncestorSiteInDesignMode)
        {
            return;
        }

        Font = new Font(_fontCollection.Families[0], Font.Size + 2);
        ForeColor = SystemColors.ControlText;
    }

    protected override void Dispose(bool disposing)
    {
        IsSpinning = false;
        base.Dispose(disposing);
    }

}
