Imports System.Threading

Public Class DocumentForm

    Private _dateTimeCreated As DateTime = DateTime.Now
    Private _renderFont As Font
    Private _formClosingCancellation As CancellationTokenSource
    Private _foreColorBrush As Brush

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' We want the render Font double the size of the default font:
        _renderFont = New Font(Font.FontFamily, Font.Size * 2, FontStyle.Regular)
        _formClosingCancellation = New CancellationTokenSource
    End Sub

    Sub New(documentName As String)
        Me.New()
        Text = documentName
    End Sub

    Protected Overrides Async Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        _foreColorBrush = New SolidBrush(ForeColor)

        Await RenderContentAsync()
    End Sub

    Private Async Function RenderContentAsync() As Task

        Dim periodicTimer As New PeriodicTimer(TimeSpan.FromMilliseconds(25))
        Dim surface As New Bitmap(ClientSize.Width, ClientSize.Height)
        Dim bufferGraphics As Graphics = Nothing
        Dim formGraphics As Graphics = Nothing

        Do
            Try
                Await periodicTimer.
                        WaitForNextTickAsync(_formClosingCancellation.Token).
                        ConfigureAwait(False)

            Catch ex As OperationCanceledException
                Exit Do
            End Try

            ' Let's test, if the doc window has been resized:
            If surface.Size <> ClientSize Then

                ' Yes, we need a bitmap in the new size for double buffering.
                surface.Dispose()
                surface = New Bitmap(ClientSize.Width, ClientSize.Height)

                bufferGraphics?.Dispose() : bufferGraphics = Nothing
                formGraphics?.Dispose() : formGraphics = Nothing
            End If

            ' Should the graphics object be recreated?
            bufferGraphics = If(bufferGraphics, Graphics.FromImage(surface))

            ' Let's clear the background:
            bufferGraphics.Clear(BackColor)

            ' Let's write the document creation date centered on the top of the form:
            Dim text = $"Document {Me.Text} created on {_dateTimeCreated}"
            Dim textSize = bufferGraphics.MeasureString(text, _renderFont)

            Dim textLocation = New Point(
                    x:=CInt(ClientSize.Width - textSize.Width) \ 2,
                    y:=10)

            bufferGraphics.DrawString(
                text,
                _renderFont,
                _foreColorBrush,
                textLocation)

            text = $"Document created ({DateTime.Now - _dateTimeCreated:mm\:ss} ago)"

            textSize = bufferGraphics.MeasureString(text, _renderFont)

            textLocation = New Point(
                        x:=CInt(ClientSize.Width - textSize.Width) \ 2,
                        y:=CInt(10 + textSize.Height))

            bufferGraphics.DrawString(
                text,
                _renderFont,
                _foreColorBrush,
                textLocation)

            ' Should the graphics object be recreated?
            ' If yes, we need to make sure, we create the Graphics-object
            ' on the thread that owns the Form (the UI thread):
            formGraphics = If(
                formGraphics,
                Await InvokeAsync(Function() Graphics.FromHwnd(Handle)))

            ' Now, we can draw the bitmap on the form.
            ' And note: That does NOT need to happen on the UI thread,
            ' which makes the whole rendering process much faster!
            formGraphics.DrawImageUnscaled(surface, 0, 0)
        Loop

        formGraphics.Dispose()
        bufferGraphics.Dispose()
        surface.Dispose()

    End Function

    Overloads Sub OnFormClosing(e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        _formClosingCancellation.Cancel()
    End Sub

End Class
