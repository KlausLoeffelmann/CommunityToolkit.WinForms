Imports System.Threading
Imports System.Drawing

Public Class FrmToolWindow

    Private _textColor As Color = SystemColors.WindowText
    Private _backgroundColor As Color = SystemColors.Highlight
    Private _shadowColor As Color = SystemColors.ControlLight

    Private _selectedFunnyText As String

    Private Shared s_instanceCounter As Integer
    Private _instance As Integer

    Public Sub New()
        InitializeComponent()
        DoubleBuffered = True
        ResizeRedraw = True

        ' Increment the instance counter
        s_instanceCounter += 1
        _instance = s_instanceCounter

    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        ' Define the funny tool window text
        Dim funnyTexts() As String =
        {
            "I'm a tool window, but I'm not very handy.",
            "I'm a tool window, here to assist you with my limited functionality.",
            "I'm a tool window, trying my best to be useful.",
            "I'm a tool window, but I'm more like a toy window.",
            "I'm a tool window, providing you with a glimpse of my mediocre abilities."
        }

        ' Select a random funny text
        Dim random As New Random()
        _selectedFunnyText = funnyTexts(random.Next(0, funnyTexts.Length))

        ' Calculate the position of the tool window
        Dim mainForm As FrmMain = CType(Me.Owner, FrmMain)
        Dim mainFormLocation As Point = mainForm.Location
        Dim mainFormSize As Size = mainForm.Size
        Dim screenBounds As Rectangle = Screen.FromControl(mainForm).WorkingArea

        Dim toolWindowSize As Size = Me.Size
        Dim toolWindowLocation As Point

        Select Case _instance Mod 4
            Case 0
                ' Upper left
                toolWindowLocation = New Point(mainFormLocation.X - toolWindowSize.Width, mainFormLocation.Y)
            Case 1
                ' Lower left
                toolWindowLocation = New Point(mainFormLocation.X - toolWindowSize.Width, mainFormLocation.Y + mainFormSize.Height - toolWindowSize.Height)
            Case 2
                ' Upper right
                toolWindowLocation = New Point(mainFormLocation.X + mainFormSize.Width, mainFormLocation.Y)
            Case 3
                ' Lower right
                toolWindowLocation = New Point(mainFormLocation.X + mainFormSize.Width, mainFormLocation.Y + mainFormSize.Height - toolWindowSize.Height)
        End Select

        ' Ensure the tool window is within the screen bounds
        If toolWindowLocation.X < screenBounds.Left Then
            toolWindowLocation.X = screenBounds.Left
        ElseIf toolWindowLocation.X + toolWindowSize.Width > screenBounds.Right Then
            toolWindowLocation.X = screenBounds.Right - toolWindowSize.Width
        End If

        If toolWindowLocation.Y < screenBounds.Top Then
            toolWindowLocation.Y = screenBounds.Top
        ElseIf toolWindowLocation.Y + toolWindowSize.Height > screenBounds.Bottom Then
            toolWindowLocation.Y = screenBounds.Bottom - toolWindowSize.Height
        End If

        Me.Location = toolWindowLocation
        Me.Location = toolWindowLocation
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g As Graphics = e.Graphics
        Dim rect As New Rectangle(10, 10, Me.Width - 50, Me.Height - 70)

        ' Draw the background rectangle
        Using brush As New SolidBrush(_backgroundColor)
            g.FillRectangle(brush, rect)
        End Using

        ' Draw the shadow
        Using shadowBrush As New SolidBrush(_shadowColor)
            Dim shadowRect As New Rectangle(rect.X + 5, rect.Y + 5, rect.Width, rect.Height)
            g.FillRectangle(shadowBrush, shadowRect)
        End Using

        ' Define the font and format for the text
        Dim font As New Font("Arial", 12, FontStyle.Bold)
        Dim format As New StringFormat()
        format.Alignment = StringAlignment.Center
        format.LineAlignment = StringAlignment.Center
        format.Trimming = StringTrimming.Word

        ' Draw the text inside the rectangle
        Using textBrush As New SolidBrush(_textColor)
            g.DrawString(_selectedFunnyText, font, textBrush, rect, format)
        End Using

    End Sub

    Protected Overrides Sub OnClosed(e As EventArgs)
        MyBase.OnClosed(e)
    End Sub

End Class