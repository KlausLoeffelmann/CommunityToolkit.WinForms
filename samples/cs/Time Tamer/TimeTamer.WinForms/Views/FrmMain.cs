using System.Diagnostics;

namespace TaskTamer.WinForms;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
    }

    // This is where we are setting up the Binding for this view.
    // We just assign the DataContext to the DataSource of the BindingSource.
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        _mainVmSource.DataSource = DataContext;
    }

    private void _selectedTaskVmSource_CurrentItemChanged(object sender, EventArgs e)
    {
        Debug.Print($"Selected Task changed to {_selectedTaskVmSource.Current}");
    }
}
