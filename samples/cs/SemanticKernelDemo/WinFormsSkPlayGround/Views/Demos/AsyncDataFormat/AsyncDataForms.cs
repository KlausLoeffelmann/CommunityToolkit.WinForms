
namespace WinFormsSkPlayGround.Views.Demos;

public partial class AsyncDataForms : UserControl
{
    public AsyncDataForms()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _mainViewModelSource.DataSource = DataContext;
    }
}
