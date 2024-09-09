'Imports System.Threading

'Public Class EventAwaiter
'    Private ReadOnly _eventHandlers As New List(Of Func(Of Control, EventArgs, Task))
'    Private ReadOnly _cancellationTokenSource As New CancellationTokenSource()

'    Public Sub New()
'    End Sub

'    Public Function [AddHandler](Of TControl As Control, TEventArgs As EventArgs)(
'        control As TControl,
'        eventHandler As Func(Of TControl, TEventArgs, Task)) As EventHandler

'        Dim handler As EventHandler =
'            Async Sub(sender, e)
'                Await eventHandler(control, e)
'            End Sub

'        _eventHandlers.Add(Function(c, e) eventHandler(DirectCast(c, TControl), DirectCast(e, TEventArgs)))
'        Return handler
'    End Function

'    Public Async Function WaitAnyAsync() As Task
'        Dim tcs = New TaskCompletionSource(Of Boolean)()
'        Dim cancellationToken = _cancellationTokenSource.Token

'        Dim handlers = _eventHandlers.ConvertAll(
'            Function(handler)
'                Return Task.Run(Async Function()
'                                    While Not cancellationToken.IsCancellationRequested
'                                        Await handler(Nothing, EventArgs.Empty)
'                                        tcs.TrySetResult(True)
'                                    End While
'                                End Function)
'            End Function)

'        handlers.Add(Task.Run(Async Function()
'                                  Await Task.Delay(-1, cancellationToken)
'                                  tcs.TrySetCanceled()
'                              End Function))

'        Await tcs.Task
'    End Function

'    Public Sub Cancel()
'        _cancellationTokenSource.Cancel()
'    End Sub
'End Class

'' Usage Example
'Public Class MyForm
'    Inherits Form

'    Private ReadOnly _button1 As Button
'    Private ReadOnly _button2 As Button

'    Public Sub New()
'        _button1 = New Button() With {.Text = "Click me 1"}
'        _button2 = New Button() With {.Text = "Click me 2"}
'        Controls.Add(_button1)
'        Controls.Add(_button2)

'        Dim awaiter = New EventAwaiter()

'        AddHandler _button1.Click, awaiter.AddHandler(Of Button, EventArgs)(_button1, AddressOf HandleClickAsync)
'        AddHandler Me.FormClosing, awaiter.AddHandler(Of Form, FormClosingEventArgs)(Me, AddressOf HandleFormClosingAsync)

'        Dim task = WaitForEventOrCancelAsync(awaiter)
'    End Sub

'    Private Async Function HandleClickAsync(button As Button, e As EventArgs) As Task
'        Await Task.Delay(1000) ' Simulate async work
'        MessageBox.Show($"{button.Text} clicked!")
'    End Function

'    Private Async Function HandleFormClosingAsync(button As Form, e As FormClosingEventArgs) As Task
'        Await Task.Delay(1000) ' Simulate async work
'        MessageBox.Show($"{button.Text} clicked!")
'    End Function

'    Private Async Function WaitForEventOrCancelAsync(awaiter As EventAwaiter) As Task
'        Try
'            Await awaiter.WaitAnyAsync()
'            MessageBox.Show("An event was triggered or the operation was cancelled!")
'        Catch ex As TaskCanceledException
'            MessageBox.Show("Operation was cancelled.")
'        End Try
'    End Function
'End Class
