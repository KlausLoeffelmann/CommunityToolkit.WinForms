<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        AsyncSyncWriteLinesToolStripMenuItem = New ToolStripMenuItem()
        AsyncAsyncWriteLinesToolStripMenuItem = New ToolStripMenuItem()
        TaskDialogShowAsyncMenuItem = New ToolStripMenuItem()
        _tsmView = New ToolStripMenuItem()
        SuperToolWindowToolStripMenuItem = New ToolStripMenuItem()
        SemisuperToolWindowToolStripMenuItem = New ToolStripMenuItem()
        ToolWindowToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolsToolStripMenuItem = New ToolStripMenuItem()
        CustomizeToolStripMenuItem = New ToolStripMenuItem()
        OptionsToolStripMenuItem = New ToolStripMenuItem()
        SplitContainer1 = New SplitContainer()
        ModernTabControl1 = New ModernTabControl.ModernTabControl()
        _console = New ConsoleControl()
        StatusStrip1 = New StatusStrip()
        _tslInfo = New ToolStripStatusLabel()
        ToolStrip1 = New ToolStrip()
        NewToolStripButton = New ToolStripButton()
        OpenToolStripButton = New ToolStripButton()
        SaveToolStripButton = New ToolStripButton()
        PrintToolStripButton = New ToolStripButton()
        toolStripSeparator = New ToolStripSeparator()
        CutToolStripButton = New ToolStripButton()
        CopyToolStripButton = New ToolStripButton()
        PasteToolStripButton = New ToolStripButton()
        toolStripSeparator1 = New ToolStripSeparator()
        HelpToolStripButton = New ToolStripButton()
        MenuStrip1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.AutoSize = False
        MenuStrip1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, _tsmView, ToolsToolStripMenuItem})
        MenuStrip1.Location = New Point(5, 5)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(1192, 50)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(44, 46)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(102, 24)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AsyncSyncWriteLinesToolStripMenuItem, AsyncAsyncWriteLinesToolStripMenuItem, TaskDialogShowAsyncMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(95, 46)
        EditToolStripMenuItem.Text = "Async Tests"
        ' 
        ' AsyncSyncWriteLinesToolStripMenuItem
        ' 
        AsyncSyncWriteLinesToolStripMenuItem.Name = "AsyncSyncWriteLinesToolStripMenuItem"
        AsyncSyncWriteLinesToolStripMenuItem.Size = New Size(279, 24)
        AsyncSyncWriteLinesToolStripMenuItem.Text = "Async Sync WriteLines"
        ' 
        ' AsyncAsyncWriteLinesToolStripMenuItem
        ' 
        AsyncAsyncWriteLinesToolStripMenuItem.Name = "AsyncAsyncWriteLinesToolStripMenuItem"
        AsyncAsyncWriteLinesToolStripMenuItem.Size = New Size(279, 24)
        AsyncAsyncWriteLinesToolStripMenuItem.Text = "Async Async WriteLines"
        ' 
        ' TaskDialogShowAsyncMenuItem
        ' 
        TaskDialogShowAsyncMenuItem.Name = "TaskDialogShowAsyncMenuItem"
        TaskDialogShowAsyncMenuItem.ShortcutKeys = Keys.Control Or Keys.Z
        TaskDialogShowAsyncMenuItem.Size = New Size(279, 24)
        TaskDialogShowAsyncMenuItem.Text = "TaskDialog ShowAsync"
        ' 
        ' _tsmView
        ' 
        _tsmView.DropDownItems.AddRange(New ToolStripItem() {SuperToolWindowToolStripMenuItem, SemisuperToolWindowToolStripMenuItem, ToolWindowToolStripMenuItem, ToolStripMenuItem2})
        _tsmView.Name = "_tsmView"
        _tsmView.Size = New Size(178, 46)
        _tsmView.Text = "&View (Form.ShowAsync)"
        ' 
        ' SuperToolWindowToolStripMenuItem
        ' 
        SuperToolWindowToolStripMenuItem.Name = "SuperToolWindowToolStripMenuItem"
        SuperToolWindowToolStripMenuItem.Size = New Size(258, 24)
        SuperToolWindowToolStripMenuItem.Text = "Super Tool Window"
        ' 
        ' SemisuperToolWindowToolStripMenuItem
        ' 
        SemisuperToolWindowToolStripMenuItem.Name = "SemisuperToolWindowToolStripMenuItem"
        SemisuperToolWindowToolStripMenuItem.Size = New Size(258, 24)
        SemisuperToolWindowToolStripMenuItem.Text = "Semi-super Tool Window"
        ' 
        ' ToolWindowToolStripMenuItem
        ' 
        ToolWindowToolStripMenuItem.Name = "ToolWindowToolStripMenuItem"
        ToolWindowToolStripMenuItem.Size = New Size(258, 24)
        ToolWindowToolStripMenuItem.Text = "Tool Window"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(258, 24)
        ToolStripMenuItem2.Text = "Extraordinary Tool Window"
        ' 
        ' ToolsToolStripMenuItem
        ' 
        ToolsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CustomizeToolStripMenuItem, OptionsToolStripMenuItem})
        ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        ToolsToolStripMenuItem.Size = New Size(56, 46)
        ToolsToolStripMenuItem.Text = "&Tools"
        ' 
        ' CustomizeToolStripMenuItem
        ' 
        CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        CustomizeToolStripMenuItem.Size = New Size(180, 24)
        CustomizeToolStripMenuItem.Text = "&Customize"
        ' 
        ' OptionsToolStripMenuItem
        ' 
        OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        OptionsToolStripMenuItem.Size = New Size(180, 24)
        OptionsToolStripMenuItem.Text = "&Options"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(5, 86)
        SplitContainer1.Margin = New Padding(4)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(ModernTabControl1)
        SplitContainer1.Panel1.Padding = New Padding(10)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(_console)
        SplitContainer1.Panel2.Padding = New Padding(10)
        SplitContainer1.Size = New Size(1192, 748)
        SplitContainer1.SplitterDistance = 566
        SplitContainer1.SplitterWidth = 5
        SplitContainer1.TabIndex = 2
        ' 
        ' ModernTabControl1
        ' 
        ModernTabControl1.Dock = DockStyle.Fill
        ModernTabControl1.Location = New Point(10, 10)
        ModernTabControl1.Name = "ModernTabControl1"
        ModernTabControl1.Size = New Size(1172, 546)
        ModernTabControl1.TabIndex = 1
        ' 
        ' _console
        ' 
        _console.Dock = DockStyle.Fill
        _console.Location = New Point(10, 10)
        _console.Multiline = True
        _console.Name = "_console"
        _console.Padding = New Padding(10)
        _console.ReadOnly = True
        _console.ScrollBars = ScrollBars.Vertical
        _console.Size = New Size(1172, 157)
        _console.TabIndex = 0
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {_tslInfo})
        StatusStrip1.Location = New Point(5, 834)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 17, 0)
        StatusStrip1.Size = New Size(1192, 31)
        StatusStrip1.TabIndex = 3
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' _tslInfo
        ' 
        _tslInfo.Name = "_tslInfo"
        _tslInfo.Padding = New Padding(3)
        _tslInfo.Size = New Size(1174, 26)
        _tslInfo.Spring = True
        _tslInfo.Text = "#info#"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(24, 24)
        ToolStrip1.Items.AddRange(New ToolStripItem() {NewToolStripButton, OpenToolStripButton, SaveToolStripButton, PrintToolStripButton, toolStripSeparator, CutToolStripButton, CopyToolStripButton, PasteToolStripButton, toolStripSeparator1, HelpToolStripButton})
        ToolStrip1.Location = New Point(5, 55)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1192, 31)
        ToolStrip1.TabIndex = 4
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' NewToolStripButton
        ' 
        NewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), Image)
        NewToolStripButton.ImageTransparentColor = Color.Magenta
        NewToolStripButton.Name = "NewToolStripButton"
        NewToolStripButton.Size = New Size(28, 28)
        NewToolStripButton.Text = "&New"
        ' 
        ' OpenToolStripButton
        ' 
        OpenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), Image)
        OpenToolStripButton.ImageTransparentColor = Color.Magenta
        OpenToolStripButton.Name = "OpenToolStripButton"
        OpenToolStripButton.Size = New Size(28, 28)
        OpenToolStripButton.Text = "&Open"
        ' 
        ' SaveToolStripButton
        ' 
        SaveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), Image)
        SaveToolStripButton.ImageTransparentColor = Color.Magenta
        SaveToolStripButton.Name = "SaveToolStripButton"
        SaveToolStripButton.Size = New Size(28, 28)
        SaveToolStripButton.Text = "&Save"
        ' 
        ' PrintToolStripButton
        ' 
        PrintToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), Image)
        PrintToolStripButton.ImageTransparentColor = Color.Magenta
        PrintToolStripButton.Name = "PrintToolStripButton"
        PrintToolStripButton.Size = New Size(28, 28)
        PrintToolStripButton.Text = "&Print"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(6, 31)
        ' 
        ' CutToolStripButton
        ' 
        CutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), Image)
        CutToolStripButton.ImageTransparentColor = Color.Magenta
        CutToolStripButton.Name = "CutToolStripButton"
        CutToolStripButton.Size = New Size(28, 28)
        CutToolStripButton.Text = "C&ut"
        ' 
        ' CopyToolStripButton
        ' 
        CopyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), Image)
        CopyToolStripButton.ImageTransparentColor = Color.Magenta
        CopyToolStripButton.Name = "CopyToolStripButton"
        CopyToolStripButton.Size = New Size(28, 28)
        CopyToolStripButton.Text = "&Copy"
        ' 
        ' PasteToolStripButton
        ' 
        PasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), Image)
        PasteToolStripButton.ImageTransparentColor = Color.Magenta
        PasteToolStripButton.Name = "PasteToolStripButton"
        PasteToolStripButton.Size = New Size(28, 28)
        PasteToolStripButton.Text = "&Paste"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 31)
        ' 
        ' HelpToolStripButton
        ' 
        HelpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), Image)
        HelpToolStripButton.ImageTransparentColor = Color.Magenta
        HelpToolStripButton.Name = "HelpToolStripButton"
        HelpToolStripButton.Size = New Size(28, 28)
        HelpToolStripButton.Text = "He&lp"
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1202, 870)
        Controls.Add(SplitContainer1)
        Controls.Add(StatusStrip1)
        Controls.Add(ToolStrip1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4)
        Name = "FrmMain"
        Padding = New Padding(5)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Form"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaskDialogShowAsyncMenuItem As ToolStripMenuItem
    Friend WithEvents _tsmView As ToolStripMenuItem
    Friend WithEvents SuperToolWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SemisuperToolWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents _tslInfo As ToolStripStatusLabel
    Friend WithEvents _console As ConsoleControl
    Friend WithEvents AsyncAsyncWriteLinesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsyncSyncWriteLinesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents PasteToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents ModernTabControl1 As ModernTabControl.ModernTabControl

End Class
