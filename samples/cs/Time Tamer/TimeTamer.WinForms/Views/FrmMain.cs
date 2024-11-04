using CommunityToolkit.WinForms.Extensions;
using System.Diagnostics;
using TaskTamer9.WinForms.ValueConverter;

namespace TaskTamer.WinForms;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();

        _lblPercentDoneValue.AddBindingConverter(nameof(_lblPercentDoneValue.Text), new TaskPercentDoneToStringConverter());
    }

    // This is where we are setting up the Binding for this view.
    // We just assign the DataContext to the DataSource of the BindingSource.
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        _mainVmSource.DataSource = DataContext;
    }

    private void _lblPercentDoneValue_TextChanged(object sender, EventArgs e)
    {
        Debug.Print($"_lblPercentDoneValue_TextChanged: {((Label)sender).Text}");
    }
}
