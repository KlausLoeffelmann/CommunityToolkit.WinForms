using CommunityToolkit.WinForms.FluentUI;

namespace WinFormsSkPlayGround;

partial class FrmMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        _menuStrip = new MenuStrip();
        _tsmFile = new ToolStripMenuItem();
        _tsmQuit = new ToolStripMenuItem();
        _tsmView = new ToolStripMenuItem();
        toolStripMenuItem1 = new ToolStripSeparator();
        _tsmFairyTailGenerator = new ToolStripMenuItem();
        _tsmLearnGermanIn2Minutes = new ToolStripMenuItem();
        _tsmSolonLetsCallBackThe80s = new ToolStripMenuItem();
        _tsmTools = new ToolStripMenuItem();
        _tsmWinFormsAIPlayGround = new ToolStripMenuItem();
        toolStripMenuItem3 = new ToolStripSeparator();
        _tsmBrowserDeveloperTools = new ToolStripMenuItem();
        toolStripMenuItem4 = new ToolStripSeparator();
        _tsmTestForm = new ToolStripMenuItem();
        _tsmAsyncDemos = new ToolStripMenuItem();
        _tsmAsyncTimerDemo = new ToolStripMenuItem();
        asyncToolStripMenuItem1 = new ToolStripMenuItem();
        asyncDataEntryToolStripMenuItem = new ToolStripMenuItem();
        colorMeToolStripMenuItem = new ToolStripMenuItem();
        _mainFormStatusStrip = new StatusStrip();
        _mainTabControl = new FluentTabControl();
        _menuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // _menuStrip
        // 
        _menuStrip.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _menuStrip.ImageScalingSize = new Size(24, 24);
        _menuStrip.Items.AddRange(new ToolStripItem[] { _tsmFile, _tsmView, _tsmTools, _tsmAsyncDemos, colorMeToolStripMenuItem });
        _menuStrip.Location = new Point(0, 0);
        _menuStrip.Name = "_menuStrip";
        _menuStrip.Size = new Size(841, 33);
        _menuStrip.TabIndex = 2;
        _menuStrip.Text = "menuStrip1";
        // 
        // _tsmFile
        // 
        _tsmFile.DropDownItems.AddRange(new ToolStripItem[] { _tsmQuit });
        _tsmFile.Name = "_tsmFile";
        _tsmFile.Size = new Size(60, 29);
        _tsmFile.Text = " &File";
        // 
        // _tsmQuit
        // 
        _tsmQuit.Name = "_tsmQuit";
        _tsmQuit.Size = new Size(134, 30);
        _tsmQuit.Text = "Quit";
        // 
        // _tsmView
        // 
        _tsmView.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, _tsmFairyTailGenerator, _tsmLearnGermanIn2Minutes, _tsmSolonLetsCallBackThe80s });
        _tsmView.Name = "_tsmView";
        _tsmView.Size = new Size(67, 29);
        _tsmView.Text = "View";
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(375, 6);
        // 
        // _tsmFairyTailGenerator
        // 
        _tsmFairyTailGenerator.Name = "_tsmFairyTailGenerator";
        _tsmFairyTailGenerator.Size = new Size(378, 30);
        _tsmFairyTailGenerator.Text = "The Fairy Tail Generator...";
        // 
        // _tsmLearnGermanIn2Minutes
        // 
        _tsmLearnGermanIn2Minutes.Name = "_tsmLearnGermanIn2Minutes";
        _tsmLearnGermanIn2Minutes.Size = new Size(378, 30);
        _tsmLearnGermanIn2Minutes.Text = "Learn German in 2 Minutes...";
        // 
        // _tsmSolonLetsCallBackThe80s
        // 
        _tsmSolonLetsCallBackThe80s.Name = "_tsmSolonLetsCallBackThe80s";
        _tsmSolonLetsCallBackThe80s.Size = new Size(378, 30);
        _tsmSolonLetsCallBackThe80s.Text = "SOLON - Let's call back the 80s! ...";
        _tsmSolonLetsCallBackThe80s.Click += Solon_LetsCallBackThe80s_Click;
        // 
        // _tsmTools
        // 
        _tsmTools.DropDownItems.AddRange(new ToolStripItem[] { _tsmWinFormsAIPlayGround, toolStripMenuItem3, _tsmBrowserDeveloperTools, toolStripMenuItem4, _tsmTestForm });
        _tsmTools.Name = "_tsmTools";
        _tsmTools.Size = new Size(69, 29);
        _tsmTools.Text = "Tools";
        // 
        // _tsmWinFormsAIPlayGround
        // 
        _tsmWinFormsAIPlayGround.Name = "_tsmWinFormsAIPlayGround";
        _tsmWinFormsAIPlayGround.Size = new Size(307, 30);
        _tsmWinFormsAIPlayGround.Text = "WinForms AI Playground";
        // 
        // toolStripMenuItem3
        // 
        toolStripMenuItem3.Name = "toolStripMenuItem3";
        toolStripMenuItem3.Size = new Size(304, 6);
        // 
        // _tsmBrowserDeveloperTools
        // 
        _tsmBrowserDeveloperTools.Name = "_tsmBrowserDeveloperTools";
        _tsmBrowserDeveloperTools.Size = new Size(307, 30);
        _tsmBrowserDeveloperTools.Text = "Browser Developer Tools";
        // 
        // toolStripMenuItem4
        // 
        toolStripMenuItem4.Name = "toolStripMenuItem4";
        toolStripMenuItem4.Size = new Size(304, 6);
        // 
        // _tsmTestForm
        // 
        _tsmTestForm.Name = "_tsmTestForm";
        _tsmTestForm.Size = new Size(307, 30);
        _tsmTestForm.Text = "Test Form";
        _tsmTestForm.Click += TestForm_Click;
        // 
        // _tsmAsyncDemos
        // 
        _tsmAsyncDemos.DropDownItems.AddRange(new ToolStripItem[] { _tsmAsyncTimerDemo, asyncToolStripMenuItem1, asyncDataEntryToolStripMenuItem });
        _tsmAsyncDemos.Name = "_tsmAsyncDemos";
        _tsmAsyncDemos.Size = new Size(75, 29);
        _tsmAsyncDemos.Text = "Async";
        // 
        // _tsmAsyncTimerDemo
        // 
        _tsmAsyncTimerDemo.Name = "_tsmAsyncTimerDemo";
        _tsmAsyncTimerDemo.Size = new Size(281, 30);
        _tsmAsyncTimerDemo.Text = "Async Timer Demo";
        // 
        // asyncToolStripMenuItem1
        // 
        asyncToolStripMenuItem1.Name = "asyncToolStripMenuItem1";
        asyncToolStripMenuItem1.Size = new Size(281, 30);
        asyncToolStripMenuItem1.Text = "Async Graphics Demo";
        // 
        // asyncDataEntryToolStripMenuItem
        // 
        asyncDataEntryToolStripMenuItem.Name = "asyncDataEntryToolStripMenuItem";
        asyncDataEntryToolStripMenuItem.Size = new Size(281, 30);
        asyncDataEntryToolStripMenuItem.Text = "Async Data Entry";
        // 
        // colorMeToolStripMenuItem
        // 
        colorMeToolStripMenuItem.Name = "colorMeToolStripMenuItem";
        colorMeToolStripMenuItem.Size = new Size(109, 29);
        colorMeToolStripMenuItem.Text = "Color Me!";
        colorMeToolStripMenuItem.Click += ColorMeToolStripMenuItem_Click;
        // 
        // _mainFormStatusStrip
        // 
        _mainFormStatusStrip.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _mainFormStatusStrip.ImageScalingSize = new Size(24, 24);
        _mainFormStatusStrip.Location = new Point(0, 429);
        _mainFormStatusStrip.Name = "_mainFormStatusStrip";
        _mainFormStatusStrip.Size = new Size(841, 24);
        _mainFormStatusStrip.TabIndex = 3;
        _mainFormStatusStrip.Text = "statusStrip2";
        // 
        // _mainTabControl
        // 
        _mainTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _mainTabControl.Location = new Point(12, 51);
        _mainTabControl.Name = "_mainTabControl";
        _mainTabControl.Size = new Size(817, 363);
        _mainTabControl.TabIndex = 4;
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new SizeF(11F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(841, 453);
        Controls.Add(_mainTabControl);
        Controls.Add(_menuStrip);
        Controls.Add(_mainFormStatusStrip);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        MainMenuStrip = _menuStrip;
        Margin = new Padding(4);
        Name = "FrmMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "WinForms AI Playground";
        _menuStrip.ResumeLayout(false);
        _menuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private MenuStrip _menuStrip;
    private ToolStripMenuItem _tsmFile;
    private ToolStripMenuItem _tsmQuit;
    private ToolStripMenuItem _tsmView;
    private ToolStripSeparator toolStripMenuItem1;
    private ToolStripMenuItem _tsmLearnGermanIn2Minutes;
    private ToolStripMenuItem _tsmTools;
    private ToolStripMenuItem _tsmAsyncDemos;
    private ToolStripMenuItem _tsmFairyTailGenerator;
    private ToolStripMenuItem _tsmSolonLetsCallBackThe80s;
    private ToolStripMenuItem _tsmWinFormsAIPlayGround;
    private ToolStripSeparator toolStripMenuItem3;
    private ToolStripMenuItem _tsmBrowserDeveloperTools;
    private ToolStripSeparator toolStripMenuItem4;
    private ToolStripMenuItem _tsmTestForm;
    private ToolStripMenuItem _tsmAsyncTimerDemo;
    private ToolStripMenuItem asyncToolStripMenuItem1;
    private ToolStripMenuItem asyncDataEntryToolStripMenuItem;
    private FluentTabControl _mainTabControl;
    private ToolStripMenuItem colorMeToolStripMenuItem;
    private StatusStrip _mainFormStatusStrip;
}
