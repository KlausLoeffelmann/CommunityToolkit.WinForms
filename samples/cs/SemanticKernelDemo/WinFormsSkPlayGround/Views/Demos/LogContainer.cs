namespace WinFormsSkPlayGround.Views.Demos;

public partial class LogContainer : UserControl
{
    private readonly Form _mainForm;

    public LogContainer(Form mainForm)
    {
        InitializeComponent();
        _mainForm = mainForm;
    }
}
