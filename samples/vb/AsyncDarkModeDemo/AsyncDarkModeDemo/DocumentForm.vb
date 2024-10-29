Imports System.Threading

Public Class DocumentForm

    Private _dateTimeCreated As DateTime = DateTime.Now
    Private _renderFont As Font
    Private _formClosingCancellation As CancellationTokenSource

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' We want the render Font double the size of the default font:
        _renderFont = New Font(Font.FontFamily, Font.Size * 2, FontStyle.Regular)
        _formClosingCancellation = New CancellationTokenSource
    End Sub

    Protected Overrides Async Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        Await RenderContentAsync()
    End Sub

    Private Async Function RenderContentAsync() As Task

        ' Let's render when the document has been created and then we're
        ' running a periodic timer, which updates the age of the document.
        Using g = Graphics.FromHwnd(Handle)

            ' Let's write the document creation date centered on the top of the form:
            Dim text = $"Document created on {_dateTimeCreated}"
            Dim textSize = g.MeasureString(text, _renderFont)
            Dim textLocation = New Point((ClientSize.Width - textSize.Width) \ 2, 10)
            g.DrawString(text, _renderFont, Brushes.Black, textLocation)

            ' And now let's use a PeriodicTimer to update the age of the document:
            Dim periodicTimer As New PeriodicTimer(TimeSpan.FromMilliseconds(25))

            Do
                Try
                    Await periodicTimer.
                        WaitForNextTickAsync(_formClosingCancellation.Token).
                        ConfigureAwait(False)

                Catch ex As OperationCanceledException
                    Exit Do
                End Try

                text = $"Document created on {_dateTimeCreated} ({DateTime.Now - _dateTimeCreated} ago)"

                Await InvokeAsync(
                    Sub()
                        ' center the text below the previous text:
                        textSize = g.MeasureString(text, _renderFont)
                        textLocation = New Point((ClientSize.Width - textSize.Width) \ 2, 10 + textSize.Height)
                        g.DrawString(text, _renderFont, Brushes.Black, textLocation)
                    End Sub)
            Loop
        End Using

    End Function

    Overloads Sub OnFormClosing(e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        _formClosingCancellation.Cancel()
    End Sub

End Class
