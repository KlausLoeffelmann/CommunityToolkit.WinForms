using CommunityToolkit.WinForms.Extensions;
using CommunityToolkit.WinForms.ModernTabControl;
using TaskTamer.ViewModels;
using WinFormsSkPlayGround;
using WinFormsSkPlayGround.Views;
using WinFormsSkPlayGround.Views.Demos;

namespace SemanticKernelDemo;

public partial class FrmMain : Form
{
    private readonly WinFormsUserSettingsService _settingsService;
    private readonly IServiceProvider? _serviceProvider;
    private AIPlayGroundView? _aiPlayGroundView;

    public FrmMain()
    {
        InitializeComponent();
        _settingsService = new();
        _settingsService.Load();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        var bounds = _settingsService.GetInstance(
            "bounds",
            this.CenterOnScreen(
                horizontalFillGrade: 80,
                verticalFillGrade: 80));

        Bounds = bounds;

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

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        _settingsService.SetInstance("bounds", this.GetRestorableBounds());
        _settingsService.Save();
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
