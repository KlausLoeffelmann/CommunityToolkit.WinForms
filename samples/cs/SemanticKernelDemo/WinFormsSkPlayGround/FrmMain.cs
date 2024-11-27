using CommunityToolkit.WinForms.ComponentModel;
using CommunityToolkit.WinForms.Extensions;
using CommunityToolkit.WinForms.FluentUI;
using WinFormsSkPlayGround.Views;

namespace WinFormsSkPlayGround;

public partial class FrmMain : Form
{
    private readonly IUserSettingsService _settingsService;
    private AIPlayGroundView? _aiPlayGroundView;

    public FrmMain()
    {
        InitializeComponent();
        _settingsService = WinFormsUserSettingsService.CreateAndLoad();
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

        _mainTabControl.AddTab("Main Page", new IntroClockDemo());
        _mainTabControl.AddTab("Simple Async", new SimpleAsyncDemo(this));
        _mainTabControl.AddTab("Async Rendering", new AsyncSpiralContainer());
        _mainTabControl.AddTab("Learn German!", new LearnGermanDemo(this));
        _mainTabControl.AddTab("I.A.E.F (Demo)", new IntelligentAsyncDemoDesigner(this));
        _mainTabControl.AddTab("I.A.E.F", new IntelligentAsyncEntryFormsView(this));
        _mainTabControl.AddTab("WinForms Playground", _aiPlayGroundView = new AIPlayGroundView());
        //_mainTabControl.AddTab("Debug Console", new LogContainer(this));

        _mainTabControl.TabChanged += MainTabControl_TabChanged;
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        _settingsService.SetInstance("bounds", this.GetRestorableBounds());
        _settingsService.Save();
    }

    private void MainTabControl_TabChanged(object? sender, EventArgs e)
    {
        if (sender is FluentTabControl tabControl
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

    private void ColorMeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.FormCaptionTextColor = Color.Yellow;
        this.FormBorderColor = Color.Green;
        this.FormCaptionBackColor = Color.Blue;
        this.FormCornerPreference = FormCornerPreference.Round;
    }

    private void ViewNumerals_Click(object sender, EventArgs e)
    {
        // Do we have a clock on the demo surface?
        if (this.FirstDescendantOrDefault<IntroClockDemo>() is IntroClockDemo introDemoClock)
        {
            // Let's change the style of the clock's hour marks.
            introDemoClock.MarksStyle = sender switch
            {
                ToolStripMenuItem { Name: nameof(_tsmArabicNumerals) } => HourMarksStyle.ArabicNumerals,
                ToolStripMenuItem { Name: nameof(_tsmRomanNumerals) } => HourMarksStyle.RomanNumerals,
                ToolStripMenuItem { Name: nameof(_tsmBinaryNumerals) } => HourMarksStyle.BinaryNumerals,
                ToolStripMenuItem { Name: nameof(_tsmTurningClockFace) } => HourMarksStyle.TurningClockFace,
                _ => throw new NotImplementedException()
            };
        }
    }
}
