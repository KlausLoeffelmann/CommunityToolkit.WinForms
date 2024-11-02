using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace CommunityToolkit.WinForms.Controls;

public class FilePathPicker : ContainerControl
{
    private TextBox _textBox;
    private Button _button;
    private FilePathType _filePathType;
    private string? _placeholder;

    public event EventHandler? FilePathChanged;

    public FilePathPicker()
    {
        InitializeComponents();
    }

    [MemberNotNull(nameof(_textBox), nameof(_button))]
    private void InitializeComponents()
    {
        _textBox = new TextBox();
        _button = new Button();

        // Set up the TextBox
        _textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _textBox.Location = new Point(0, 0);
        _textBox.Width = Width - _button.Width;
        _textBox.AutoSize = true;

        // Set up the Button
        _button.Text = "...";
        _button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        _button.Click += Button_Click;

        // Add controls to the container
        Controls.Add(_textBox);
        Controls.Add(_button);
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        LayoutControls();
    }

    private void LayoutControls()
    {
        int buttonWidth = TextRenderer.MeasureText(_button.Text, _button.Font).Width + 10;
        _button.Size = new Size(buttonWidth, _textBox.Height);

        _textBox.Width = Width - buttonWidth - Padding.Horizontal;
        _button.Location = new Point(_textBox.Width + Padding.Left, Padding.Top);

        Height = Math.Max(_textBox.Height, _button.Height) + Padding.Vertical;
    }

    protected override void OnPaddingChanged(EventArgs e)
    {
        base.OnPaddingChanged(e);
        LayoutControls();
    }

    private void Button_Click(object? sender, EventArgs e)
    {
        if (_filePathType == FilePathType.File)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.FileName = FilePath;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog.FileName;
            }
        }
        else
        {
            using FolderBrowserDialog folderBrowserDialog = new();
            folderBrowserDialog.SelectedPath = FilePath;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = folderBrowserDialog.SelectedPath;
            }
        }
    }

    [DefaultValue(null)]
    public string? FilePath
    {
        get => _textBox.Text;
        set
        {
            if (_textBox.Text != value)
            {
                _textBox.Text = value;
                OnFilePathChanged(EventArgs.Empty);
            }
        }
    }

    protected virtual void OnFilePathChanged(EventArgs e) 
        => FilePathChanged?.Invoke(this, e);

    [DefaultValue(null)]
    public string? PlaceHolder
    {
        get => _placeholder;
        set
        {
            if (_placeholder != value)
            {
                _placeholder = value;
                _textBox.PlaceholderText = value;
            }
        }
    }

    [DefaultValue(FilePathType.File)]
    public FilePathType FilePathType
    {
        get => _filePathType;
        set => _filePathType = value;
    }
}
