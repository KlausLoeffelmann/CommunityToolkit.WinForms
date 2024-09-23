using CommunityToolkit.WinForms.ModernTabControl;
using TaskTamer.ViewModels;
using WinFormsSkPlayGround;
using WinFormsSkPlayGround.Views;
using WinFormsSkPlayGround.Views.Demos;

namespace SemanticKernelDemo;

public partial class FrmMain : Form
{
    private readonly IServiceProvider? _serviceProvider;
    private AIPlayGroundView? _aiPlayGroundView;

    public FrmMain()
    {
        InitializeComponent();
        PositionForm();
    }

    private void PositionForm()
    {
        // Size the Form up to 80% of the Screen, and center it:
        Screen screen = Screen.FromControl(this);
        int width = (int)(screen.WorkingArea.Width * 0.90);
        int height = (int)(screen.WorkingArea.Height * 0.90);
        int x = (screen.WorkingArea.Width - width) / 2;
        int y = (screen.WorkingArea.Height - height) / 2;

        Bounds = new Rectangle(x, y, width, height);
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
        var toolWindowTasks = new Dictionary<Task, ToolStripMenuItem>();

        var mainViewModel = new MainViewModel(null!);
        DataContext = mainViewModel;

        _mainTabControl.AddTab("Main Page", new IntroClockDemo());
        _mainTabControl.AddTab("Simple Async", new SimpleAsyncDemo(this));
        _mainTabControl.AddTab("Async Data Forms", new AsyncDataForms());
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

    private void colorMeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.FormCaptionTextColor = Color.Yellow;
        this.FormBorderColor = Color.Green;
        this.FormCaptionBackColor = Color.Blue;
        this.FormCornerPreference = FormCornerPreference.Round;
    }
}
