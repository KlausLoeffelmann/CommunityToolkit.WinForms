using CommunityToolkit.WinForms.Extensions;
using TaskTamer9.WinForms.ValueConverter;

namespace TaskTamer.WinForms;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();

        // TypeDescriptor.AddProvider(new AsyncTypeDescriptionProvider(_lblDateTime), _lblDateTime);
        _lblPercentDoneValue.AddBindingConverter(nameof(_lblPercentDoneValue.Text), ValueConverters.TaskPercentDoneToString);
        _lblPriority.AddBindingConverter(nameof(_lblPriority.Text), ValueConverters.PriorityToString);
    }

    // This is where we are setting up the Binding for this view.
    // We just assign the DataContext to the DataSource of the BindingSource.
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        _mainVmSource.DataSource = DataContext;
    }
}
