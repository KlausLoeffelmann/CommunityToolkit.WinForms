using CommunityToolkit.WinForms.Extensions;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace WinFormsAsync;

public class SevenSegmentTimer : Control
{
    private static PrivateFontCollection? s_fontCollection;
    private int _fontSize = 128;
    private Font _segmentFont;
    private Font _standardFont;
    private Label[]? _separatorLabels;

    public SevenSegmentTimer()
    {
        InitializeComponent();
    }

    [MemberNotNull(nameof(_segmentFont), nameof(_standardFont))]
    private void InitializeComponent()
    {
        SuspendLayout();

        if (s_fontCollection is null)
        {
            SetupFont();
            if (s_fontCollection is null)
            {
                throw new InvalidOperationException("Font not loaded.");
            }
        }

        _segmentFont = new(
            family: s_fontCollection.Families[0],
            emSize: FontSize,
            style: FontStyle.Regular,
            unit: GraphicsUnit.Pixel);

        _standardFont = new(
            family: Font.FontFamily,
            emSize: FontSize,
            style: FontStyle.Regular,
            unit: GraphicsUnit.Pixel);

        // Create a TableLayoutPanel to hold Hour, :, Minute, : , Second, :, Millisecond
        TableLayoutPanel innerTableLayout = new()
        {
            Anchor = AnchorStyles.None,
            ColumnCount = 7,
            RowCount = 1,
            Padding = new Padding(0),
            Margin = new Padding(0),
            AutoSize = true
        };

        for (int i = 0; i < 7; i++)
        {
            innerTableLayout.ColumnStyles.Add(
                new ColumnStyle(
                    sizeType: SizeType.AutoSize));

            Label label = new()
            {
                TextAlign = ContentAlignment.BottomCenter,
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill,
                AutoSize = true
            };

            (label.Text, label.Font) = i switch
            {
                0 => ("00", _segmentFont),
                1 => (":", _standardFont),
                2 => ("00", _segmentFont),
                3 => (":", _standardFont),
                4 => ("00", _segmentFont),
                5 => (":", _standardFont),
                6 => ("0", _segmentFont),
                _ => (label.Text, label.Font),
            };

            innerTableLayout.Controls.Add(label, i, 0);
        }

        TableLayoutPanel outerTableLayout = new()
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(0),
            Margin = new Padding(0),
        };

        outerTableLayout.Controls.Add(innerTableLayout);
        Controls.Add(outerTableLayout);
        ResumeLayout();
    }

    // Hide Font property to prevent changing the font
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new Font Font
    {
        get => base.Font;
        set => base.Font = value;
    }

    public async Task UpdateTimeAsync(TimeOnly time)
    {
        int count = 0;

        foreach (Label label in this.DescendantControls<Label>())
        {
            label.Text = count++ switch
            {
                0 => time.Hour.ToString("00"),
                2 => time.Minute.ToString("00"),
                4 => time.Second.ToString("00"),
                6 => (time.Millisecond/100).ToString("0"),
                _ => label.Text,
            };
        }

        await Task.Yield();
    }

    public Label[] SeparatorLabels()
        => _separatorLabels ??= 
        [.. this.DescendantControls<Label>().Where(label => label.Text == ":")];

    public async Task FadeSeparatorsOutAsync()
    {
        // Fade the separators out
        Color[] colors = GetColorSteps(BackColor, ForeColor);

        foreach (Label label in this.DescendantControls<Label>())
        {
            for (int i = 0; i < 100; i++)
            {
                label.ForeColor = colors[i];
                await Task.Delay(1);
            }
        }
    }

    public async Task FadeSeparatorsInAsync()
    {
        // Fade the separators in
        Color[] colors = GetColorSteps(BackColor, ForeColor);

        foreach (Label label in this.DescendantControls<Label>())
        {
            for (int i = 99; i >= 0; i--)
            {
                label.ForeColor = colors[i];
                await Task.Delay(1);
            }
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int FontSize
    {
        get => _fontSize;
        set => Font = new Font(Font.FontFamily, value, Font.Style, Font.Unit);
    }

    private static Color[] GetColorSteps(Color backColor, Color ForeColor)
    {
        // We need to define the color-blends from the Front-Color to the Back-Color in 100 steps:
        Color[] colors = new Color[100];

        for (int i = 0; i < 100; i++)
        {
            colors[i] = Color.FromArgb(
                red: ForeColor.R + (int)((backColor.R - ForeColor.R) * i / 100f),
                green: ForeColor.G + (int)((backColor.G - ForeColor.G) * i / 100f),
                blue: ForeColor.B + (int)((backColor.B - ForeColor.B) * i / 100f));
        }

        return colors;
    }

    private static void SetupFont()
    {
        // Load the Segment7Standard font from the embedded resources
        // and install it in the private fonts
        var assembly = Assembly.GetExecutingAssembly();
        string resourceName = "WinFormsAsync.Resources.Segment7Standard.otf";

        using var stream = assembly.GetManifestResourceStream(resourceName)
            ?? throw new InvalidOperationException("Font resource not found.");

        int dataLength = (int)stream.Length;

        byte[] fontData = new byte[stream.Length];
        stream.ReadExactly(fontData);

        IntPtr fontPtr = Marshal.AllocCoTaskMem(dataLength);
        Marshal.Copy(fontData, 0, fontPtr, dataLength);

        uint cFonts = 0;
        AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref cFonts);

        s_fontCollection = new PrivateFontCollection();
        s_fontCollection.AddMemoryFont(fontPtr, fontData.Length);
    }

    [DllImport("gdi32.dll", EntryPoint = "AddFontMemResourceEx")]
    private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, ref uint pcFonts);
}
