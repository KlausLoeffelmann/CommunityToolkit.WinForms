Imports System.ComponentModel
Imports System.Threading

Public Class DocumentForm
    Private _dateTimeCreated As DateTime = DateTime.Now
    Private _renderFont As Font
    Private _formClosingCancellation As CancellationTokenSource
    Private _foreColorBrush As Brush
    Private _documentName As String

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
        Me.DocumentName = documentName
    End Sub

    ''' <summary>
    '''  The name of the document.
    ''' </summary>
    <DefaultValue(CStr(Nothing))>
    Public Property DocumentName As String
        Get
            Return _documentName
        End Get
        Private Set(value As String)
            Text = value
            _documentName = value
        End Set
    End Property

    Protected Overrides Async Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        _foreColorBrush = New SolidBrush(ForeColor)

        Await Task.Run(Async Function() 
                           Await RenderContentAsync()
                       End Function)
    End Sub

    Private Async Function RenderContentAsync() As Task

        Dim periodicTimer As New PeriodicTimer(TimeSpan.FromMilliseconds(25))
        Dim surface As New Bitmap(ClientSize.Width, ClientSize.Height)
        Dim bufferGraphics As Graphics = Nothing
        Dim formGraphics As Graphics = Nothing

        Do
            Await periodicTimer.
                    WaitForNextTickAsync().
                    ConfigureAwait(False)

            ' Let's test, if the doc window has been resized:
            If surface.Size <> ClientSize Then

                ' Yes, we need a bitmap in the new size for double buffering.
                surface.Dispose()

                ' Let's make sure, the Bitmap is never smaller than 10 x 10.
                surface = New Bitmap(
                    width:=Math.Max(ClientSize.Width, 10),
                    height:=Math.Max(ClientSize.Height, 10))

                bufferGraphics?.Dispose() : bufferGraphics = Nothing
                formGraphics?.Dispose() : formGraphics = Nothing
            End If

            ' Should the graphics object be recreated?
            bufferGraphics = If(bufferGraphics, Graphics.FromImage(surface))

            ' Let's clear the background:
            bufferGraphics.Clear(BackColor)

            If (_formClosingCancellation.IsCancellationRequested) Then
                Exit Do
            End If

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

            text = $"Document created ({DateTime.Now - _dateTimeCreated:mm\:ss\:fff} ago)"

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
                Await InvokeAsync(Function() Graphics.FromHwnd(Handle)).ConfigureAwait(False))

            ' Now, we can draw the bitmap on the form.
            ' And note: That does NOT need to happen on the UI thread,
            ' which makes the whole rendering process much faster!
            formGraphics.DrawImageUnscaled(surface, 0, 0)
        Loop

        formGraphics.Dispose()
        bufferGraphics.Dispose()
        surface.Dispose()

    End Function

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)

        _formClosingCancellation.Cancel()
    End Sub

End Class
