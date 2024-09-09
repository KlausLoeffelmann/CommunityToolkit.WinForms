namespace WinFormsSkPlayGround;

public partial class frmRetro : Form
{
    public frmRetro()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _retroWebView.AllowExternalDrop = true;
        _retroWebView.Source = new Uri("https://klausloeffelmann.github.io/pcjs/");
    }
}
