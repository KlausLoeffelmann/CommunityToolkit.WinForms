namespace TaskTamer.WinForms;

public partial class FrmTaskTamerMain : Form
{
    public FrmTaskTamerMain()
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
}
