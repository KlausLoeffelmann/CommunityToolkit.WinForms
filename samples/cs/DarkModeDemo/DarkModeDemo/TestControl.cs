using System.ComponentModel;

namespace DarkModeDemo;

public class TestControl : Panel
{
    private readonly static Color s_defaultBackColor = SystemColors.ControlDark;
    private readonly static Color s_defaultSurfaceColor = SystemColors.Control;
    private readonly static Color s_defaultForeColor = SystemColors.WindowText;
    private readonly static Color s_defaultBorderColor = SystemColors.ActiveBorder;

    public TestControl()
    {
        this.BackColor = s_defaultBackColor;
        this.ForeColor = s_defaultForeColor;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color SurfaceColor { get; set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Color BorderColor { get; set; } = s_defaultBorderColor;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Draw the background in the size of the client rectangle:
        using (var brush = new SolidBrush(this.SurfaceColor))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        // Draw the surface half the size of the client rectangle:
        using (var brush = new SolidBrush(this.BackColor))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle.X, this.ClientRectangle.Y, this.ClientRectangle.Width / 2, this.ClientRectangle.Height / 2);
        }

        // Draw the "Lorem ipsum" text in the middle of the control in the control's fonts in several lines:
        using (var brush = new SolidBrush(this.ForeColor))
        {
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Sed non risus. Suspendisse lectus tortor, dignissim sit amet, adipiscing nec, ultricies sed, dolor.";

            var font = this.Font;
            var format = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            e.Graphics.DrawString(text, font, brush, this.ClientRectangle, format);
        }

        using (var pen = new Pen(this.BorderColor))
        {
            e.Graphics.DrawRectangle(pen, this.ClientRectangle.X, this.ClientRectangle.Y, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);
        }
    }
}

