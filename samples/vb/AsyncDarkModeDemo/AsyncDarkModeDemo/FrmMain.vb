Option Explicit On
Option Strict On

Imports System.Threading

Public Class FrmMain

    Private _toolWindows As Dictionary(Of String, FrmToolWindow) = New Dictionary(Of String, FrmToolWindow)

    Private _ctsToolWindows As CancellationTokenSource = New CancellationTokenSource
    Private _ctsAsyncWriteLines As CancellationTokenSource

    Private _staticCount As Integer = 0
    Private _taskCount As Integer = 0

    Private Async Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim toolWindowTasks As New Dictionary(Of Task, ToolStripMenuItem)

        ModernTabControl1.AddTab("Main Page", New DarkModeDemoPanel)
        ModernTabControl1.AddTab("Data Entry", New DataEntry)
        ModernTabControl1.AddTab("TreeView/ListView", New TreeViewListView)
        ModernTabControl1.AddTab("Dark Button/FlowLayoutPanel issues", New ContainerLayoutTests)

        Await HandleToolWindowsAsync()
    End Sub

    Private Async Sub AsyncWriteLinesAsyncToolStripMenuItem_Click() _
        Handles AsyncAsyncWriteLinesToolStripMenuItem.Click

        _taskCount += 1
        Dim taskId = _taskCount

        ' Define a Periodic Timer and write lines to the ConsoleControl asynchronously:
        Dim periodicTimer As New PeriodicTimer(TimeSpan.FromMilliseconds(200))
        Dim count As Integer = 0

        _ctsAsyncWriteLines = New CancellationTokenSource
        Dim cancellationToken As CancellationToken = _ctsAsyncWriteLines.Token

        Dim occurredException As Exception = Nothing

        Do
            Await periodicTimer.WaitForNextTickAsync().ConfigureAwait(False)
            count += 1

            Try
                Await InvokeAsync(
    callback:=Function(innerCToken) WriteLineDelayedAsync(
                text:=$"Line {count} written asynchronously. (T-ID:{taskId})",
                delay:=300,
                cancellationToken:=cancellationToken),
    cancellationToken:=cancellationToken)

            Catch ex As Exception
                ' VB can't await inside of catch blocks, so we trick.
                occurredException = ex
            End Try

            If (occurredException IsNot Nothing) Then
                Await _console.WriteLineAsync($"Exception occurred: {occurredException.Message}")
                occurredException = Nothing
            End If

            Await InvokeAsync(Sub() _tslInfo.Text = $"Count is {count}")
        Loop Until count = 100

    End Sub

    Private Function WriteLineDelayedAsync(
        text As String,
        delay As Integer,
        cancellationToken As CancellationToken) As ValueTask

        Dim theTask = Task.Run(
            Async Function() As Task

                If (_staticCount > 30) Then
                    _staticCount = 0
                    Throw New Exception("Test Exception.")
                End If

                _staticCount += 1

                Await _console.WriteAsync($"{text}")
                Await Task.Delay(delay)
                Await _console.WriteLineAsync($"...done.")
            End Function, cancellationToken)

        Return New ValueTask(theTask)
    End Function

    Private Async Sub AsyncSyncWriteLinesSyncToolStripMenuItem_Click() _
        Handles AsyncSyncWriteLinesToolStripMenuItem.Click

        _taskCount += 1
        Dim taskId = _taskCount

        ' Define a Periodic Timer and write lines to the ConsoleControl asynchronously:
        Dim periodicTimer As New PeriodicTimer(TimeSpan.FromMilliseconds(200))
        Dim count As Integer = 0

        Do
            Await periodicTimer.WaitForNextTickAsync().ConfigureAwait(False)

            count += 1
            Await _console.WriteLineAsync($"Line {count} written asynchronously. (T-ID:{taskId}")

            Await InvokeAsync(Sub() _tslInfo.Text = $"Count is {count}")

        Loop Until count = 100
    End Sub

    Private Async Sub TaskDialogShowAsyncMenuItem_Click() Handles TaskDialogShowAsyncMenuItem.Click

        Dim tdPage = TaskDialogPageFactory()
        Dim returnButton = Await TaskDialog.ShowDialogAsync(Me.Handle, tdPage, TaskDialogStartupLocation.CenterOwner)
        Await _console.WriteLineAsync($"TaskDialog result: {returnButton.Text}")

    End Sub

    Private Function TaskDialogPageFactory() As TaskDialogPage
        Dim tdOkButton As New TaskDialogButton With
            {
                .Text = "OK",
                .AllowCloseDialog = True
            }

        Dim tdCancelButton As New TaskDialogButton With
            {
                .Text = "Cancel",
                .AllowCloseDialog = True
            }

        Return New TaskDialogPage With
            {
                .Buttons = New TaskDialogButtonCollection() From {tdOkButton, tdCancelButton},
                .Caption = "TaskDialog ShowAsync",
                .Text = "This is a TaskDialog ShowAsync test.",
                .Icon = TaskDialogIcon.Information,
                .AllowCancel = True
            }
    End Function

    Private Async Function HandleToolWindowsAsync() As Task

        Dim toolWindowTasks As New Dictionary(Of Task, ToolStripMenuItem)
        Dim menuItem As ToolStripMenuItem = Nothing

        For Each menuItem In _tsmView.DropDownItems
            ' Name of the ToolWindow is the same as the Text of the MenuItem:
            Dim menuTcs = New TaskCompletionSource()
            menuItem.Tag = menuTcs
            toolWindowTasks.Add(menuTcs.Task, menuItem)

            Dim toolWindow As New FrmToolWindow With
                {
                    .Text = menuItem.Text,
                    .Name = menuItem.Text,
                    .Tag = menuItem
                }

            Dim task = toolWindow.ShowAsync(Me)
            toolWindowTasks.Add(task, menuItem)

            AddHandler menuItem.Click,
                Sub(sender, e)
                    ' On each mouse click...
                    Dim eventMenuItem = DirectCast(sender, ToolStripMenuItem)
                    Dim newMenuTcs = New TaskCompletionSource()
                    Dim newToolWindow = New FrmToolWindow()

                    ' we add two tasks  to the dictionary. One completes, when the tool window closes...
                    toolWindowTasks.Add(newToolWindow.ShowAsync(Me), menuItem)

                    ' and one completes, when the menu item is clicked again.
                    toolWindowTasks.Add(newMenuTcs.Task, menuItem)

                    ' Now. There is already a task, which waits for completion.
                    ' And since the user now clicked this item, we complete the task.
                    DirectCast(eventMenuItem.Tag, TaskCompletionSource).SetResult()

                    ' And of course, this needs to be available the next time, so we
                    ' add a new Task Completion Source to the tag.
                    eventMenuItem.Tag = newMenuTcs
                End Sub
        Next

        ' So. This endless loop now runs. But of course it doesn't block
        ' anything, since the tasks are all awaited.
        Do
            ' In here, are all our ToolWindow-close-tasks and all our menu-click-tasks.
            ' We are waiting for one of them to complete.
            Dim doneTask = Await Task.WhenAny(toolWindowTasks.Keys.ToList)

            If (toolWindowTasks.TryGetValue(doneTask, menuItem)) Then
                ' And if that happens, we remove that task(s) from the dictionary.
                Await _console.WriteLineAsync($"Tool window {menuItem.Text}")
                toolWindowTasks.Remove(doneTask)
            End If
        Loop

    End Function
End Class
