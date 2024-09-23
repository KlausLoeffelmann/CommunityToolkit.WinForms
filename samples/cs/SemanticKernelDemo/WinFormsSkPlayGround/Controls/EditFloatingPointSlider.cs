using System.ComponentModel;

namespace WinFormsSkPlayGround.Controls;

internal class EditFloatingPointSlider : ContainerControl
{
    private TextBox _innerTextBox;
    private FloatingPointTrackBar _innerSlider;

    public EditFloatingPointSlider()
    {
        // Setup a FloatingPointSlider and a TextBox as the inner controls:
        _innerTextBox = new TextBox()
        {
            Size = new Size(80, 20),
            Text = "0.0",
            Dock = DockStyle.Right,
        };

        _innerSlider = new FloatingPointTrackBar()
        {
            Size = new Size(120, 20),
            Dock = DockStyle.Fill,
        };

        Controls.Add(_innerSlider);
        Controls.Add(_innerTextBox);

        _innerSlider.ValueChanged += _innerSlider_ValueChanged;
    }

    private void _innerSlider_ValueChanged(object? sender, EventArgs e)
    {
        try
        {
            _innerTextBox.Text = _innerSlider.Value.ToString("#.###");
        }
        catch (Exception)
        {
        }
    }

    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    [DefaultValue(0.0f)]
    [Description("The minimum value of the track bar.")]
    [Category("Behavior")]
    public float Minimum
    {
        get => _innerSlider.Minimum;
        set
        {
            _innerSlider.Minimum = value;
        }
    }

    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    [DefaultValue(1.0f)]
    [Description("The maximum value of the track bar.")]
    [Category("Behavior")]
    public float Maximum
    {
        get => _innerSlider.Maximum;
        set
        {
            _innerSlider.Maximum = value;
        }
    }

    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    [DefaultValue(0.0f)]
    [Description("The current value of the track bar.")]
    [Category("Behavior")]
    public float Value
    {
        get => _innerSlider.Value;
        set
        {
            _innerSlider.Value = value;
            _innerTextBox.Text = value.ToString("#.###");
        }
    }

    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    [DefaultValue(0.1f)]
    [Description("The small change value of the track bar.")]
    [Category("Appearance")]
    public float SmallChange
    {
        get => _innerSlider.SmallChange;
        set => _innerSlider.SmallChange = value;
    }

    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    [DefaultValue(0.25f)]
    [Description("The large change value of the track bar.")]
    [Category("Appearance")]
    public float LargeChange
    {
        get => _innerSlider.LargeChange;
        set => _innerSlider.LargeChange = value;
    }

    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    [DefaultValue(0.1f)]
    [Description("The tick frequency value of the track bar.")]
    [Category("Appearance")]
    public float TickFrequency
    {
        get => _innerSlider.TickFrequency;
        set => _innerSlider.TickFrequency = value;
    }
}
