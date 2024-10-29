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
        _newDocMenuItem = New ToolStripMenuItem()
        _menuStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        _menuStrip.ImageScalingSize = New Size(20, 20)
        _menuStrip.Items.AddRange(New ToolStripItem() {_fileMenuItem})
        _menuStrip.Location = New Point(0, 0)
        _menuStrip.Name = "MenuStrip1"
        _menuStrip.Size = New Size(800, 28)
        _menuStrip.TabIndex = 0
        _menuStrip.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        _fileMenuItem.Name = "FileToolStripMenuItem"
        _fileMenuItem.Size = New Size(46, 24)
        _fileMenuItem.Text = "&File"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(_menuStrip)
        MainMenuStrip = _menuStrip
        Name = "MainForm"
        Text = "MainForm"
        _menuStrip.ResumeLayout(False)
        _menuStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents _menuStrip As MenuStrip
    Friend WithEvents _fileMenuItem As ToolStripMenuItem
End Class
