<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        _menuStrip = New MenuStrip()
        _fileMenuItem = New ToolStripMenuItem()
        _logList = New ListBox()
        _menuStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' _menuStrip
        ' 
        _menuStrip.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _menuStrip.ImageScalingSize = New Size(20, 20)
        _menuStrip.Items.AddRange(New ToolStripItem() {_fileMenuItem})
        _menuStrip.Location = New Point(0, 0)
        _menuStrip.Name = "_menuStrip"
        _menuStrip.Padding = New Padding(10, 2, 0, 2)
        _menuStrip.Size = New Size(1182, 38)
        _menuStrip.TabIndex = 0
        _menuStrip.Text = "MenuStrip1"
        ' 
        ' _fileMenuItem
        ' 
        _fileMenuItem.Name = "_fileMenuItem"
        _fileMenuItem.Size = New Size(62, 34)
        _fileMenuItem.Text = "&File"
        ' 
        ' _logList
        ' 
        _logList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        _logList.FormattingEnabled = True
        _logList.IntegralHeight = False
        _logList.Location = New Point(14, 43)
        _logList.Margin = New Padding(4)
        _logList.Name = "_logList"
        _logList.Size = New Size(1152, 577)
        _logList.TabIndex = 1
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1182, 633)
        Controls.Add(_logList)
        Controls.Add(_menuStrip)
        Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = _menuStrip
        Margin = New Padding(5)
        Name = "MainForm"
        Text = "MainForm"
        _menuStrip.ResumeLayout(False)
        _menuStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents _menuStrip As MenuStrip
    Friend WithEvents _fileMenuItem As ToolStripMenuItem
    Friend WithEvents _logList As ListBox
End Class
