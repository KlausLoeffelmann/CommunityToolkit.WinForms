Imports System.ComponentModel

Public Class ConsoleControl
    Inherits TextBox

    Private ReadOnly _newLine As String = Environment.NewLine
    Private ReadOnly _writeLineAction = New Action(Of String)(
        Sub(text)
            AppendText(text)
            ScrollToBottom()
        End Sub)
    Private _firstWrite As Boolean

    Public Sub New()
        MyBase.New()

        Multiline = True
        ScrollBars = ScrollBars.Vertical
        Me.ReadOnly = True
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()

        ' We have no native theming for the read-only mode of the TextBox.
        ' But: This is what we can do to make it look right in Dark Mode:
        If (Not Me.IsAncestorSiteInDesignMode) AndAlso
            Application.IsDarkModeEnabled Then

            BackColor = SystemColors.ControlDark
            ForeColor = SystemColors.ControlText

        End If
    End Sub

    ' Synchronized method for writing text
    Public Sub Write(text As String)

        If (Not _firstWrite) Then
            _firstWrite = True
            text = $"[{Date.Now:mm:ss:ffff}] {text}"
        End If

        If (text.EndsWith(_newLine)) Then
            _firstWrite = False
            text = text.
                Substring(0, text.Length - _newLine.Length - 1).
                Replace(_newLine, $"{_newLine}[{Date.Now:mm:ss:ffff}] ") + _newLine
        Else
            text = text.Replace(_newLine, $"{_newLine}[{Date.Now:mm:ss:ffff}] ")
        End If

        AppendText(text)
        ScrollToCaret()
    End Sub

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        Invalidate(True)
    End Sub

    ' Synchronous method for writing a line of text
    Public Sub WriteLine(text As String)
        Write(text & Environment.NewLine)
    End Sub

    ' Asynchronous method for writing text using InvokeAsync
    Public Async Function WriteAsync(text As String) As Task
        Await InvokeAsync(Sub() Write(text))
    End Function

    ' Asynchronous method for writing a line of text using InvokeAsync
    Public Async Function WriteLineAsync(text As String) As Task
        Await WriteAsync(text & Environment.NewLine)
    End Function

    ' Method to scroll to the bottom of the TextBox
    Private Sub ScrollToBottom()
        Me.SelectionStart = Me.TextLength
        Me.ScrollToCaret()
    End Sub

    Public Property PromptInfo As String

    ' <DefaultValue("")>

    Private Function ShouldSerializePromptInfo() As Boolean
        Return Not String.IsNullOrEmpty(PromptInfo)
    End Function

End Class
