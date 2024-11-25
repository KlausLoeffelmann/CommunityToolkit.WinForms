using CommunityToolkit.WinForms.Extensions;
using System.ComponentModel;
using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace WinFormsAsync;

public class SevenSegmentTimer : Control
{
    private static readonly PrivateFontCollection s_fontCollection;

    static SevenSegmentTimer()
    {
        // Load the Segment7Standard font from the embedded resources
        // and install it in the private fonts
        var assembly = Assembly.GetExecutingAssembly();
        string resourceName = "WinFormsAsync.Resources.Segment7Standard.otf";

        using var stream = assembly.GetManifestResourceStream(resourceName) ?? throw new InvalidOperationException("Font resource not found.");
        byte[] fontData = new byte[stream.Length];
        stream.ReadExactly(fontData);

        var fontBuffer = Marshal.AllocCoTaskMem(fontData.Length);
        Marshal.Copy(fontData, 0, fontBuffer, fontData.Length);

        s_fontCollection = new PrivateFontCollection();
        s_fontCollection.AddMemoryFont(fontBuffer, fontData.Length);

        Marshal.FreeCoTaskMem(fontBuffer);
    }

    public SevenSegmentTimer()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        SuspendLayout();

        Font font = new(
            family: s_fontCollection.Families[0],
            emSize: 72,
            style: FontStyle.Regular,
            unit: GraphicsUnit.Point);

        Font = font;

        // Create a TableLayoutPanel to hold Hour, :, Minute, : , Second, :, Millisecond
        var innerTableLayout = new TableLayoutPanel
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

            innerTableLayout.Controls.Add(
                control: new Label
                {
                    Text = i % 2 == 0 ? "00" : "-",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = font,
                    AutoSize = true
                },
                column: i,
                row: 0);
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

    public async Task UpdateTimeAsync(TimeOnly time)
    {
        // Update the relevant labels with the time:
        // Hour, :, Minute, : , Second, :, Millisecond
        int count = -1;

        foreach (Label label in this.DescendantControls<Label>())
        {
            label.Text = count++ switch
            {
                0 => time.Hour.ToString("00"),
                2 => time.Minute.ToString("00"),
                4 => time.Second.ToString("00"),
                6 => time.Millisecond.ToString("000"),
                _ => label.Text,
            };
        }

        await Task.Yield();
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
}
