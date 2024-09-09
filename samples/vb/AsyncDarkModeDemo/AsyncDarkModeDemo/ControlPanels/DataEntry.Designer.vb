<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataEntry
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
        _tlpEntryFieldContainer = New TableLayoutPanel()
        _chkA11YConform = New CheckBox()
        Label5 = New Label()
        TextBox5 = New TextBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        _lblCustomerID = New Label()
        _lblLastname = New Label()
        _txtCustomerId = New TextBox()
        RichTextEditor1 = New ModernTabControl.RichTextEditor()
        Button1 = New Button()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        _optConform = New RadioButton()
        _optClassic = New RadioButton()
        _tlpEntryFieldContainer.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' _tlpEntryFieldContainer
        ' 
        _tlpEntryFieldContainer.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        _tlpEntryFieldContainer.AutoSize = True
        _tlpEntryFieldContainer.ColumnCount = 2
        _tlpEntryFieldContainer.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        _tlpEntryFieldContainer.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        _tlpEntryFieldContainer.Controls.Add(_chkA11YConform, 1, 6)
        _tlpEntryFieldContainer.Controls.Add(Label5, 0, 6)
        _tlpEntryFieldContainer.Controls.Add(TextBox5, 1, 5)
        _tlpEntryFieldContainer.Controls.Add(Label4, 0, 5)
        _tlpEntryFieldContainer.Controls.Add(TextBox4, 1, 4)
        _tlpEntryFieldContainer.Controls.Add(Label3, 0, 4)
        _tlpEntryFieldContainer.Controls.Add(TextBox3, 1, 3)
        _tlpEntryFieldContainer.Controls.Add(Label2, 0, 3)
        _tlpEntryFieldContainer.Controls.Add(TextBox2, 1, 2)
        _tlpEntryFieldContainer.Controls.Add(Label1, 0, 2)
        _tlpEntryFieldContainer.Controls.Add(TextBox1, 1, 1)
        _tlpEntryFieldContainer.Controls.Add(_lblCustomerID, 0, 0)
        _tlpEntryFieldContainer.Controls.Add(_lblLastname, 0, 1)
        _tlpEntryFieldContainer.Controls.Add(_txtCustomerId, 1, 0)
        _tlpEntryFieldContainer.Controls.Add(RichTextEditor1, 0, 7)
        _tlpEntryFieldContainer.Location = New Point(14, 17)
        _tlpEntryFieldContainer.Name = "_tlpEntryFieldContainer"
        _tlpEntryFieldContainer.RowCount = 8
        _tlpEntryFieldContainer.RowStyles.Add(New RowStyle())
        _tlpEntryFieldContainer.RowStyles.Add(New RowStyle())
        _tlpEntryFieldContainer.RowStyles.Add(New RowStyle())
        _tlpEntryFieldContainer.RowStyles.Add(New RowStyle())
        _tlpEntryFieldContainer.RowStyles.Add(New RowStyle())
        _tlpEntryFieldContainer.RowStyles.Add(New RowStyle())
        _tlpEntryFieldContainer.RowStyles.Add(New RowStyle())
        _tlpEntryFieldContainer.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        _tlpEntryFieldContainer.Size = New Size(746, 643)
        _tlpEntryFieldContainer.TabIndex = 0
        ' 
        ' _chkA11YConform
        ' 
        _chkA11YConform.Anchor = AnchorStyles.None
        _chkA11YConform.AutoSize = True
        _chkA11YConform.Location = New Point(473, 314)
        _chkA11YConform.Name = "_chkA11YConform"
        _chkA11YConform.Size = New Size(173, 29)
        _chkA11YConform.TabIndex = 3
        _chkA11YConform.Text = "Read-Only Notes"
        _chkA11YConform.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Location = New Point(3, 306)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(0, 20, 0, 0)
        Label5.Size = New Size(63, 45)
        Label5.TabIndex = 13
        Label5.Text = "Notes:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TextBox5.Location = New Point(376, 265)
        TextBox5.Margin = New Padding(3, 10, 3, 10)
        TextBox5.Name = "TextBox5"
        TextBox5.Padding = New Padding(10)
        TextBox5.Size = New Size(367, 31)
        TextBox5.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Location = New Point(3, 268)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 25)
        Label4.TabIndex = 11
        Label4.Text = "Customer since:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TextBox4.Location = New Point(376, 214)
        TextBox4.Margin = New Padding(3, 10, 3, 10)
        TextBox4.Name = "TextBox4"
        TextBox4.Padding = New Padding(10)
        TextBox4.Size = New Size(367, 31)
        TextBox4.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New Point(3, 217)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 25)
        Label3.TabIndex = 9
        Label3.Text = "Date of Birth:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TextBox3.Location = New Point(376, 163)
        TextBox3.Margin = New Padding(3, 10, 3, 10)
        TextBox3.Name = "TextBox3"
        TextBox3.Padding = New Padding(10)
        TextBox3.Size = New Size(367, 31)
        TextBox3.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(3, 166)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 25)
        Label2.TabIndex = 7
        Label2.Text = "Middle name:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.Location = New Point(376, 112)
        TextBox2.Margin = New Padding(3, 10, 3, 10)
        TextBox2.Name = "TextBox2"
        TextBox2.Padding = New Padding(10)
        TextBox2.Size = New Size(367, 31)
        TextBox2.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(3, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 25)
        Label1.TabIndex = 5
        Label1.Text = "First name:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Location = New Point(376, 61)
        TextBox1.Margin = New Padding(3, 10, 3, 10)
        TextBox1.Name = "TextBox1"
        TextBox1.Padding = New Padding(10)
        TextBox1.Size = New Size(367, 31)
        TextBox1.TabIndex = 4
        ' 
        ' _lblCustomerID
        ' 
        _lblCustomerID.Anchor = AnchorStyles.Left
        _lblCustomerID.AutoSize = True
        _lblCustomerID.Location = New Point(3, 13)
        _lblCustomerID.Name = "_lblCustomerID"
        _lblCustomerID.Size = New Size(118, 25)
        _lblCustomerID.TabIndex = 1
        _lblCustomerID.Text = "Customer-ID:"
        ' 
        ' _lblLastname
        ' 
        _lblLastname.Anchor = AnchorStyles.Left
        _lblLastname.AutoSize = True
        _lblLastname.Location = New Point(3, 64)
        _lblLastname.Name = "_lblLastname"
        _lblLastname.Size = New Size(96, 25)
        _lblLastname.TabIndex = 2
        _lblLastname.Text = "Last name:"
        ' 
        ' _txtCustomerId
        ' 
        _txtCustomerId.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        _txtCustomerId.Location = New Point(376, 10)
        _txtCustomerId.Margin = New Padding(3, 10, 3, 10)
        _txtCustomerId.Name = "_txtCustomerId"
        _txtCustomerId.Padding = New Padding(10)
        _txtCustomerId.Size = New Size(367, 31)
        _txtCustomerId.TabIndex = 3
        ' 
        ' RichTextEditor1
        ' 
        RichTextEditor1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        _tlpEntryFieldContainer.SetColumnSpan(RichTextEditor1, 2)
        RichTextEditor1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextEditor1.Location = New Point(3, 354)
        RichTextEditor1.Name = "RichTextEditor1"
        RichTextEditor1.Padding = New Padding(10)
        RichTextEditor1.Size = New Size(740, 286)
        RichTextEditor1.TabIndex = 15
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.Location = New Point(800, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(172, 45)
        Button1.TabIndex = 1
        Button1.Text = "OK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.Location = New Point(800, 72)
        Button2.Name = "Button2"
        Button2.Size = New Size(172, 45)
        Button2.TabIndex = 2
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox1.Controls.Add(_optConform)
        GroupBox1.Controls.Add(_optClassic)
        GroupBox1.Location = New Point(800, 151)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(169, 136)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "A11Y-Setting:"
        ' 
        ' _optConform
        ' 
        _optConform.AutoSize = True
        _optConform.Location = New Point(18, 77)
        _optConform.Name = "_optConform"
        _optConform.Size = New Size(108, 29)
        _optConform.TabIndex = 1
        _optConform.TabStop = True
        _optConform.Text = "Conform"
        _optConform.UseVisualStyleBackColor = True
        ' 
        ' _optClassic
        ' 
        _optClassic.AutoSize = True
        _optClassic.Checked = True
        _optClassic.Location = New Point(18, 42)
        _optClassic.Name = "_optClassic"
        _optClassic.Size = New Size(89, 29)
        _optClassic.TabIndex = 0
        _optClassic.TabStop = True
        _optClassic.Text = "Classic"
        _optClassic.UseVisualStyleBackColor = True
        ' 
        ' DataEntry
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        Controls.Add(GroupBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(_tlpEntryFieldContainer)
        Name = "DataEntry"
        Size = New Size(996, 677)
        _tlpEntryFieldContainer.ResumeLayout(False)
        _tlpEntryFieldContainer.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents _tlpEntryFieldContainer As TableLayoutPanel
    Friend WithEvents _lblCustomerID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents _lblLastname As Label
    Friend WithEvents _txtCustomerId As TextBox
    Friend WithEvents RichTextEditor1 As ModernTabControl.RichTextEditor
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents _chkA11YConform As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents _optConform As RadioButton
    Friend WithEvents _optClassic As RadioButton

End Class
