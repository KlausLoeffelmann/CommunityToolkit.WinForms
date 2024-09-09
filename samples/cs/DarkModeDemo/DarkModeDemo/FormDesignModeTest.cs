using DarkModeDemo.SettingsProvider;

namespace DarkModeDemo;

public partial class FormDesignModeTest : Form
{
    public FormDesignModeTest()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        this.LoadBounds();
        Application.DoEvents();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);
        this.SaveBounds();
    }
}
