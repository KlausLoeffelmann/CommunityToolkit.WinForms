using CommunityToolkit.WinForms.ModernTabControl;
using SemanticKernelDemo.Controls;
using WinFormsSkPlayGround;
using WinFormsSkPlayGround.Views;

namespace SemanticKernelDemo;

public partial class FrmMain : Form
{
    private readonly IServiceProvider? _serviceProvider;
    private AIPlayGroundView? _aiPlayGroundView;

    public FrmMain()
    {
        InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
        var toolWindowTasks = new Dictionary<Task, ToolStripMenuItem>();

        _mainTabControl.AddTab("Main Page", new IntroClockDemo());
        _mainTabControl.AddTab("Simple Async", new SimpleAsyncDemo());
        _mainTabControl.AddTab("Async Rendering", new AsyncSpiralContainer());
        _mainTabControl.AddTab("Learn German!", new LearnGermanDemo());
        _mainTabControl.AddTab("WinForms Playground", _aiPlayGroundView = new AIPlayGroundView());

        _mainTabControl.TabChanged += _mainTabControl_TabChanged;
    }

    private void _mainTabControl_TabChanged(object? sender, EventArgs e)
    {
        if (sender is ModernTabControl tabControl 
            && tabControl.CurrentTab is AsyncSpiralContainer spiralDemo)
        {
            spiralDemo.KickOff();
        }
    }

    private void BrowserDeveloperTools_Click(object sender, EventArgs e)
        => _aiPlayGroundView?.RequestBrowserTools();

    private void Solon_LetsCallBackThe80s_Click(object sender, EventArgs e)
    {
        var retroForm = new frmRetro();
        retroForm.Show();
    }

    private void TestForm_Click(object sender, EventArgs e)
    {
        var testForm = new FrmTestForm();
        testForm.Show();
    }
}
