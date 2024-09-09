namespace ModernTabControl;

public class RichTextEditor : UserControl
{
    private readonly ToolStrip _toolStrip;
    private readonly ToolStripButton _btnBold;
    private readonly ToolStripButton _btnItalic;
    private readonly ToolStripButton _btnUnderline;
    private readonly ToolStripButton _btnBullet;
    private readonly RichTextBox _richTextBox;

    public RichTextEditor()
    {
        _toolStrip = new ToolStrip();
        _btnBold = new ToolStripButton("Bold");
        _btnItalic = new ToolStripButton("Italic");
        _btnUnderline = new ToolStripButton("Underline");
        _btnBullet = new ToolStripButton("Bullet");
        _richTextBox = new RichTextBox();

        InitializeComponents();
    }

    private void InitializeComponents()
    {
        // Setup ToolStrip
        _toolStrip.Items.AddRange(new ToolStripItem[] { _btnBold, _btnItalic, _btnUnderline, _btnBullet });
        _toolStrip.Dock = DockStyle.Top;

        // Setup RichTextBox
        _richTextBox.Dock = DockStyle.Fill;
        _richTextBox.SelectionChanged += RichTextBox_SelectionChanged;

        // Setup Buttons
        _btnBold.Click += (sender, e) => ToggleBold();
        _btnItalic.Click += (sender, e) => ToggleItalic();
        _btnUnderline.Click += (sender, e) => ToggleUnderline();
        _btnBullet.Click += (sender, e) => ToggleBullet();

        // Add controls to UserControl
        Controls.Add(_richTextBox);
        Controls.Add(_toolStrip);
    }

    private void RichTextBox_SelectionChanged(object? sender, EventArgs e)
    {
        var selectionFont = _richTextBox.SelectionFont;
        if (selectionFont != null)
        {
            _btnBold.Checked = selectionFont.Bold;
            _btnItalic.Checked = selectionFont.Italic;
            _btnUnderline.Checked = selectionFont.Underline;
        }
        else
        {
            _btnBold.Checked = false;
            _btnItalic.Checked = false;
            _btnUnderline.Checked = false;
        }

        _btnBullet.Checked = _richTextBox.SelectionBullet;
    }

    private void ToggleBold()
    {
        if (_richTextBox.SelectionFont is null)
            return;

        var currentFont = _richTextBox.SelectionFont;
        var newFontStyle = currentFont.Bold ? FontStyle.Regular : FontStyle.Bold;
        SetSelectionFontStyle(newFontStyle);
    }

    private void ToggleItalic()
    {
        if (_richTextBox.SelectionFont is null)
            return;

        var currentFont = _richTextBox.SelectionFont;
        var newFontStyle = currentFont.Italic ? FontStyle.Regular : FontStyle.Italic;
        SetSelectionFontStyle(newFontStyle);
    }

    private void ToggleUnderline()
    {
        if (_richTextBox.SelectionFont is null)
            return;

        var currentFont = _richTextBox.SelectionFont;
        var newFontStyle = currentFont.Underline ? FontStyle.Regular : FontStyle.Underline;
        SetSelectionFontStyle(newFontStyle);
    }

    private void ToggleBullet()
    {
        _richTextBox.SelectionBullet = !_richTextBox.SelectionBullet;
    }

    private void SetSelectionFontStyle(FontStyle fontStyle)
    {
        if (_richTextBox.SelectionFont is null)
            return;

        var currentFont = _richTextBox.SelectionFont;
        var newFont = new Font(currentFont.FontFamily, currentFont.Size, fontStyle);
        _richTextBox.SelectionFont = newFont;
    }
}
