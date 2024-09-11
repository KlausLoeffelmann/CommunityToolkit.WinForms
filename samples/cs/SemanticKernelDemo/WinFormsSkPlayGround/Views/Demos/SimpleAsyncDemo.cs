namespace WinFormsSkPlayGround.Views;

public partial class SimpleAsyncDemo : UserControl
{
    public SimpleAsyncDemo()
    {
        InitializeComponent();
    }

    private void Spinner_ClickHandler(object sender, EventArgs e)
    {
        _spinner.IsSpinning = !_spinner.IsSpinning;
    }
}
