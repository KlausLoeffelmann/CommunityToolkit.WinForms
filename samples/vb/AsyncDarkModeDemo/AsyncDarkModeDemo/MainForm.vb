Public Class MainForm

    ''' <summary>
    '''  A ToolStripMenuItem whose click-event can be awaited.
    ''' </summary>
    Public Class AwaitableToolStripMenuItem
        Inherits ToolStripMenuItem

        ' TaskCompletionSource, which provides a task that completes when the ToolStripMenuItem is clicked.
        Private _clickCompletion As New TaskCompletionSource

        Protected Overrides Sub OnClick(e As EventArgs)
            MyBase.OnClick(e)

            ' Set the result of the TaskCompletionSource to indicate that the ToolStripMenuItem was clicked.
            _clickCompletion.SetResult()

            ' Create a new TaskCompletionSource for the next click event.
            _clickCompletion = New TaskCompletionSource
        End Sub

        ''' <summary>
        '''  Returns a Task that completes when the ToolStripMenuItem is clicked.
        ''' </summary>
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

        ' This is a lookup-table for the DocumentForms and their corresponding Tasks.
        Dim formTasks As New Dictionary(Of Task, DocumentForm)

        ' This is the respective next DocumentForm to be created.
        Dim documentForm As DocumentForm

        ' We're in a loop until the Quit-MenuItem is clicked.
        Do

            ' This waits for any of the passed Tasks to complete.
            ' Now. We pass the Tasks of all DocumentForms, the Task of the New Document MenuItem
            ' and the Task of the Quit MenuItem. The first one to complete is awaited, and it is
            ' returned once it completes.
            Dim awaitedTask = Await Task.WhenAny(
                Combine(
                    formTasks.Keys,
                    _newDocMenuItem.ToTask,
                    _quitMenuItem.ToTask))

            ' If that task was the Task of the New Document MenuItem, we create a new DocumentForm.
            If awaitedTask Is _newDocMenuItem.ToTask Then
                documentForm = New DocumentForm($"Document {_docCounter}")
                formTasks.Add(documentForm.ShowAsync, documentForm)
                _docCounter += 1

                Await InvokeAsync(
                    Sub() _logList.Items.Add($"Creating new document {documentForm.Text}..."))

                ' If that task was the Task of the Quit MenuItem, we exit the loop.
            ElseIf awaitedTask Is _quitMenuItem.ToTask Then
                Exit Do

                ' And if it was the Task of a DocumentForm, we remove that DocumentForm from the lookup-table.
                ' because this tasks completes, when the Form is closing.
            Else
                documentForm = formTasks(awaitedTask)

                Await InvokeAsync(
                    Sub() _logList.Items.Add($"{documentForm.DocumentName} is closing..."))

                formTasks.Remove(awaitedTask)
            End If
        Loop

        ' We close the main form and with it all still open DocumentForms.
        Close()
    End Sub

    ' Helper function to combine multiple Tasks into one IEnumerable(Of Task), so we can pass them to Task.WhenAny.
    Private Shared Function Combine(list As IEnumerable(Of Task), ParamArray additionalItems As Task()) As IEnumerable(Of Task)
        Return list.Concat(additionalItems)
    End Function

End Class
