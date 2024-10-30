Public Class MainForm

    Public Class AwaitableToolStripMenuItem
        Inherits ToolStripMenuItem

        Private _clickCompletion As New TaskCompletionSource

        Protected Overrides Sub OnClick(e As EventArgs)
            MyBase.OnClick(e)
            _clickCompletion.SetResult()
            _clickCompletion = New TaskCompletionSource
        End Sub

        Public Function ToTask() As Task
            Return _clickCompletion.Task
        End Function

    End Class

    Private _newDocMenuItem As New AwaitableToolStripMenuItem
    Private _quitMenuItem As New AwaitableToolStripMenuItem
    Private _docCounter As Integer = 1

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        _newDocMenuItem.Text = "New Document"
        _quitMenuItem.Text = "Quit"

        _fileMenuItem.DropDownItems.AddRange(
            _newDocMenuItem,
            New ToolStripSeparator,
            _quitMenuItem)

    End Sub

    Protected Overrides Async Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        Dim formTasks As New Dictionary(Of Task, DocumentForm)
        Dim documentForm As DocumentForm

        Do
            Dim awaitedTask = Await Task.WhenAny(
                Combine(
                    formTasks.Keys,
                    _newDocMenuItem.ToTask,
                    _quitMenuItem.ToTask))

            If awaitedTask Is _newDocMenuItem.ToTask Then
                documentForm = New DocumentForm($"Document {_docCounter}")
                formTasks.Add(documentForm.ShowAsync, documentForm)
                _docCounter += 1

                Await InvokeAsync(
                    Sub() _logList.Items.Add($"Creating new document {documentForm.Text}..."))

            ElseIf awaitedTask Is _quitMenuItem.ToTask Then
                Exit Do

            Else
                documentForm = formTasks(awaitedTask)

                Await InvokeAsync(
                    Sub() _logList.Items.Add($"{documentForm.Text} is closing..."))

                formTasks.Remove(awaitedTask)
            End If
        Loop

        Close()
    End Sub

    Private Shared Function Combine(list As IEnumerable(Of Task), ParamArray additionalItems As Task()) As IEnumerable(Of Task)
        Return list.Concat(additionalItems)
    End Function

End Class
