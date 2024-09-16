namespace CommunityToolkit.WinForms.Controls;

/// <summary>
/// Represents a custom control that provides a console-like interface.
/// </summary>
public class ConsoleControl : RichTextBox
{
    private Color _currentTextColor;
    private CustomFontStyle _currentFontStyle;
    private FontSize _currentFontSize;

    /// <summary>
    /// Initializes a new instance of the <see cref="ConsoleControl"/> class.
    /// </summary>
    public ConsoleControl()
    {
        _currentTextColor = this.ForeColor;
        _currentFontStyle = CustomFontStyle.Normal;
        _currentFontSize = FontSize.Normal;
    }

    /// <summary>
    /// Writes the specified text asynchronously to the console control.
    /// </summary>
    /// <param name="text">The text to write.</param>
    /// <param name="textColor">The color of the text. (Optional)</param>
    /// <param name="style">The font style of the text. (Optional)</param>
    /// <param name="size">The font size of the text. (Optional)</param>
    /// <param name="keepStyles">Indicates whether to keep the current text styles. (Optional)</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task WriteAsync(
        string text,
        Color? textColor = null,
        CustomFontStyle? style = null,
        FontSize? size = null,
        bool keepStyles = false)
    {
        await Task.Run(() =>
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() => ApplyText(text, textColor, style, size, keepStyles)));
            }
            else
            {
                ApplyText(text, textColor, style, size, keepStyles);
            }
        });
    }

    /// <summary>
    /// Writes the specified text followed by a new line asynchronously to the console control.
    /// </summary>
    /// <param name="text">The text to write. (Optional)</param>
    /// <param name="textColor">The color of the text. (Optional)</param>
    /// <param name="style">The font style of the text. (Optional)</param>
    /// <param name="size">The font size of the text. (Optional)</param>
    /// <param name="keepStyles">Indicates whether to keep the current text styles. (Optional)</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task WriteLineAsync(
        string? text = null,
        Color? textColor = null,
        CustomFontStyle? style = null,
        FontSize? size = null,
        bool keepStyles = false)
    {
        await WriteAsync((text ?? string.Empty) + Environment.NewLine, textColor, style, size, keepStyles);
    }

    /// <summary>
    /// Clears the console control.
    /// </summary>
    /// <param name="resetStyles">Indicates whether to reset the text styles. (Optional)</param>
    public void Clear(bool resetStyles = false)
    {
        if (this.InvokeRequired)
        {
            this.Invoke((MethodInvoker)(() => ClearControl(resetStyles)));
        }
        else
        {
            ClearControl(resetStyles);
        }
    }

    /// <summary>
    /// Sets the text styles for the console control.
    /// </summary>
    /// <param name="textColor">The color of the text. (Optional)</param>
    /// <param name="style">The font style of the text. (Optional)</param>
    /// <param name="size">The font size of the text. (Optional)</param>
    /// <param name="keepSetting">Indicates whether to keep the current text styles. (Optional)</param>
    public void SetStyle(
        Color? textColor = null,
        CustomFontStyle? style = null,
        FontSize? size = null,
        bool keepSetting = false)
    {
        if (this.InvokeRequired)
        {
            this.Invoke((MethodInvoker)(() => ApplyStyles(textColor, style, size, keepSetting)));
        }
        else
        {
            ApplyStyles(textColor, style, size, keepSetting);
        }
    }

    private void ApplyText(
        string text,
        Color? textColor,
        CustomFontStyle? style,
        FontSize? size,
        bool keepStyles)
    {
        ApplyStyles(textColor, style, size, keepStyles);
        this.AppendText(text);
        if (!keepStyles)
        {
            ResetStyles();
        }
    }

    private void ClearControl(bool resetStyles)
    {
        base.Clear();
        if (resetStyles)
        {
            ResetStyles();
        }
    }

    private void ApplyStyles(
        Color? textColor,
        CustomFontStyle? style,
        FontSize? size,
        bool keepStyles)
    {
        if (textColor.HasValue)
        {
            this.SelectionColor = textColor.Value;
            if (keepStyles)
            {
                _currentTextColor = textColor.Value;
            }
        }
        else
        {
            this.SelectionColor = _currentTextColor;
        }

        var fontStyle = ConvertToDrawingFontStyle(style ?? _currentFontStyle);
        var fontSize = ConvertToFontSize(size ?? _currentFontSize);

        this.SelectionFont = new Font(this.Font.FontFamily, fontSize, fontStyle);

        if (keepStyles)
        {
            _currentFontStyle = style ?? _currentFontStyle;
            _currentFontSize = size ?? _currentFontSize;
        }
    }

    private void ResetStyles()
    {
        _currentTextColor = this.ForeColor;
        _currentFontStyle = CustomFontStyle.Normal;
        _currentFontSize = FontSize.Normal;
        this.SelectionColor = _currentTextColor;
        this.SelectionFont = this.Font;
    }

    private System.Drawing.FontStyle ConvertToDrawingFontStyle(CustomFontStyle style)
    {
        var fontStyle = System.Drawing.FontStyle.Regular;

        if (style.HasFlag(CustomFontStyle.Bold))
            fontStyle |= System.Drawing.FontStyle.Bold;
        if (style.HasFlag(CustomFontStyle.Italic))
            fontStyle |= System.Drawing.FontStyle.Italic;
        if (style.HasFlag(CustomFontStyle.Underline))
            fontStyle |= System.Drawing.FontStyle.Underline;
        if (style.HasFlag(CustomFontStyle.StrikeThrough))
            fontStyle |= System.Drawing.FontStyle.Strikeout;

        return fontStyle;
    }

    private float ConvertToFontSize(FontSize size)
    {
        var baseSize = this.Font.Size;

        switch (size)
        {
            case FontSize.Smaller:
                return baseSize - 2f;
            case FontSize.Small:
                return baseSize - 1f;
            case FontSize.Larger:
                return baseSize + 1f;
            case FontSize.Large:
                return baseSize + 2f;
            default:
                return baseSize;
        }
    }
}
