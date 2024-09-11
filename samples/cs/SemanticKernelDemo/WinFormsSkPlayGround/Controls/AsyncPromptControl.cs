using System.ComponentModel;
using System.Runtime.InteropServices;

namespace SemanticKernelDemo.Controls;

[DefaultEvent(nameof(AsyncSendPrompt))]
public partial class AsyncPromptControl : TextBox
{
    private readonly static Padding s_defaultPadding = new(5, 5, 50, 5);
    private bool _isMouseOver;
    private bool _isMouseDown;
    private Rectangle _sendButtonBounds;

    // WM for non-client hit test:
    private const int WM_NCHITTEST = 0x0084;

    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr GetWindowDC(IntPtr hWnd);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);

    // Event to be raised when the user presses Enter without Ctrl
    public event AsyncEventHandler? AsyncSendPrompt;
    public event EventHandler? NewPromptSuggestionRequest;
    public event EventHandler? PreviousPromptRequest;
    public event EventHandler? PromptCompleteSuggestionRequest;

    public AsyncPromptControl()
    {
        VisualStylesMode = VisualStylesMode.Latest;
        Multiline = true;
        Padding = s_defaultPadding;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new Padding Padding
    {
        get => base.Padding;
        set => base.Padding = value;
    }

    protected override void OnNonClientPaint(PaintEventArgs paintEventArgs)
    {
#pragma warning disable WFO5000
        base.OnNonClientPaint(paintEventArgs);
#pragma warning restore WFO5000

        // Define the font and character for the icon
        Font iconFont = new("Segoe Fluent Icons", 12);
        char sendIcon = '\uE724';
        char filledSendIcon = '\uE725';

        // Draw the appropriate icon based on the mouse state
        if (_isMouseDown)
        {
            RenderSendIcon(true, SystemColors.WindowText);
            return;
        }

        if (_isMouseOver)
        {
            RenderSendIcon(false, Color.Red);
            return;
        }

        RenderSendIcon(false, SystemColors.GrayText);

        void RenderSendIcon(bool isFilled, Color color)
        {
            TextRenderer.DrawText(
                paintEventArgs.Graphics,
                (isFilled ? filledSendIcon : sendIcon).ToString(),
                iconFont,
                new Point(
                    paintEventArgs.ClipRectangle.Right - 40,
                    paintEventArgs.ClipRectangle.Top - 11 + paintEventArgs.ClipRectangle.Height / 2),
                color);
        }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        _sendButtonBounds = new Rectangle(
            Bounds.Width - 40,
            -11 + Bounds.Height / 2,
            48,
            36);

        bool isMouseOver = _sendButtonBounds.Contains(e.Location);
        if (isMouseOver != _isMouseOver)
        {
            _isMouseOver = isMouseOver;
            InvalidateNonClientArea();
        }

        base.OnMouseMove(e);
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        bool isTextEmptyOrCompletelySelected = string.IsNullOrEmpty(Text) || SelectionLength == Text.Length;

        if (e.KeyCode == Keys.Enter && !e.Control && !e.Alt && !e.Shift)
        {
            e.SuppressKeyPress = true; // Prevent the Enter key from being input as text
            OnSendPrompt(EventArgs.Empty); // Raise the SendPrompt event
        }
        else if (e.KeyCode == Keys.Down && isTextEmptyOrCompletelySelected)
        {
            OnNewPromptSuggestionRequest(EventArgs.Empty);
        }
        else if (e.KeyCode == Keys.Up && isTextEmptyOrCompletelySelected)
        {
            OnPreviousPromptRequest(EventArgs.Empty);
        }
        else if (e.KeyCode == Keys.Right && SelectionStart == Text.Length)
        {
            OnPromptCompleteSuggestionRequest(EventArgs.Empty);
        }

        base.OnKeyDown(e);
    }

    protected async virtual void OnSendPrompt(EventArgs e)
    {
        bool previousEnabled = Enabled;

        if (AsyncSendPrompt is null)
            return;

        if (AutoDisableWhenBusy)
        {
            previousEnabled = Enabled;
            Enabled = false;
        }

        if (ParallelInvoke)
        {
            // Invoke each handler in parallel
            await Task.WhenAll(AsyncSendPrompt.GetInvocationList().Cast<AsyncEventHandler>().Select(handler => handler.Invoke(this, e))).ConfigureAwait(false);
        }
        else
        {
            // Invoke each handler safely
            foreach (AsyncEventHandler handler in AsyncSendPrompt.GetInvocationList().Cast<AsyncEventHandler>())
            {
                try
                {
                    await handler.Invoke(this, e).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    Application.OnThreadException(ex);
                }
            }
        }

        if (AutoDisableWhenBusy && !previousEnabled)
        {
            Enabled = previousEnabled;
        }
    }

    protected virtual void OnNewPromptSuggestionRequest(EventArgs e) 
        => NewPromptSuggestionRequest?.Invoke(this, e);

    protected virtual void OnPreviousPromptRequest(EventArgs e) 
        => PreviousPromptRequest?.Invoke(this, e);

    protected virtual void OnPromptCompleteSuggestionRequest(EventArgs e) 
        => PromptCompleteSuggestionRequest?.Invoke(this, e);

    public void InvalidateNonClientArea()
    {
        IntPtr windowDC = GetWindowDC(Handle);
        if (windowDC != IntPtr.Zero)
        {
            InvalidateRect(Handle, IntPtr.Zero, true);
            ReleaseDC(Handle, windowDC);
        }
    }

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);

        if (m.Msg == WM_NCHITTEST)
        {
            int x = (int)m.LParam & 0x0000FFFF;
            int y = (int)m.LParam >> 16;
            Point clientPoint = PointToClient(new Point(x, y));
            OnMouseMove(new MouseEventArgs(MouseButtons.None, 0, clientPoint.X, clientPoint.Y, 0));
        }
    }

    /// <summary>
    ///  Gets or sets a value indicating whether the <see cref="AsyncButton"/> control should invoke async handler in parallel.
    /// </summary>
    [DefaultValue(false)]
    public bool ParallelInvoke { get; set; }

    /// <summary>
    ///  Gets or sets a value indicating whether the <see cref="AsyncButton"/> control should be automatically disabled when busy.
    /// </summary>
    [DefaultValue(false)]
    public bool AutoDisableWhenBusy { get; set; }
}
