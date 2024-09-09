<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TreeViewListView
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        _mainSplitContainer = New SplitContainer()
        _tvwMenu = New TreeView()
        _lvwElements = New ListView()
        CType(_mainSplitContainer, ComponentModel.ISupportInitialize).BeginInit()
        _mainSplitContainer.Panel1.SuspendLayout()
        _mainSplitContainer.Panel2.SuspendLayout()
        _mainSplitContainer.SuspendLayout()
        SuspendLayout()
        ' 
        ' _mainSplitContainer
        ' 
        _mainSplitContainer.Dock = DockStyle.Fill
        _mainSplitContainer.Location = New Point(0, 0)
        _mainSplitContainer.Name = "_mainSplitContainer"
        ' 
        ' _mainSplitContainer.Panel1
        ' 
        _mainSplitContainer.Panel1.Controls.Add(_tvwMenu)
        ' 
        ' _mainSplitContainer.Panel2
        ' 
        _mainSplitContainer.Panel2.Controls.Add(_lvwElements)
        _mainSplitContainer.Size = New Size(979, 726)
        _mainSplitContainer.SplitterDistance = 326
        _mainSplitContainer.TabIndex = 0
        ' 
        ' _tvwMenu
        ' 
        _tvwMenu.Dock = DockStyle.Fill
        _tvwMenu.Location = New Point(0, 0)
        _tvwMenu.Name = "_tvwMenu"
        _tvwMenu.Size = New Size(326, 726)
        _tvwMenu.TabIndex = 0
        ' 
        ' _lvwElements
        ' 
        _lvwElements.Dock = DockStyle.Fill
        _lvwElements.Location = New Point(0, 0)
        _lvwElements.Name = "_lvwElements"
        _lvwElements.Size = New Size(649, 726)
        _lvwElements.TabIndex = 0
        _lvwElements.UseCompatibleStateImageBehavior = False
        ' 
        ' TreeViewListView
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(_mainSplitContainer)
        Name = "TreeViewListView"
        Size = New Size(979, 726)
        _mainSplitContainer.Panel1.ResumeLayout(False)
        _mainSplitContainer.Panel2.ResumeLayout(False)
        CType(_mainSplitContainer, ComponentModel.ISupportInitialize).EndInit()
        _mainSplitContainer.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents _mainSplitContainer As SplitContainer
    Friend WithEvents _tvwMenu As TreeView
    Friend WithEvents _lvwElements As ListView

End Class
