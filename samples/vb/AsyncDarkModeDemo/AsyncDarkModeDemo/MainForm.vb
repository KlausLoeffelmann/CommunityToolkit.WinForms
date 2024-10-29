Imports System.Collections.Concurrent
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks.Sources

Public Class MainForm

    Public Class AwaitableToolStripMenuItem
        Inherits ToolStripMenuItem

        Private _clickCompletion As New TaskCompletionSource

        Public Function GetAwaiter() As TaskAwaiter
            Return _clickCompletion.Task.GetAwaiter()
        End Function

        Protected Overrides Sub OnClick(e As EventArgs)
            MyBase.OnClick(e)
            _clickCompletion.SetResult()
            _clickCompletion = New TaskCompletionSource
        End Sub
    End Class

    Private _newDocMenuItem As New AwaitableToolStripMenuItem
    Private _quitMenuItem As New AwaitableToolStripMenuItem

    Private _con As New ConcurrentStack(Of Task)

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

        Dim formTasks As New List(Of Task)

        Do
            Dim awaitedTask = Await ValueTask.(Combine(formTasks, _newDocMenuItem, _quitMenuItem))

            If awaitedTask Is _newDocMenuItem Then
                Dim documentForm As New DocumentForm
                formTasks.Add(documentForm.ShowAsync(Me))
            ElseIf formTasks.Contains(awaitedTask) Then
                formTasks.Remove(awaitedTask)
            Else
                Exit Do
            End If
        Loop
    End Sub

    Public Shared Function Combine(list As List(Of Task), ParamArray additionalItems As IAsyncResult) As IEnumerable(Of Task)
        Return list.Concat(additionalItems).Select(Function(item) DirectCast(item, Task))
    End Function

End Class
