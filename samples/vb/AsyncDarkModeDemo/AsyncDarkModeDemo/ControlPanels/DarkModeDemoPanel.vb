Imports System.Threading

Public Class DarkModeDemoPanel
    Inherits ContainerControl

    Private _cancellationTokenSource As New CancellationTokenSource

    Sub New()
        Me.DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.Invalidate()
    End Sub

    Protected Overrides Async Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        Await ClockLoopAsync()
    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        _cancellationTokenSource.Cancel()
        MyBase.Dispose(disposing)
    End Sub

    Private Async Function ClockLoopAsync() As Task
        Dim token As CancellationToken = _cancellationTokenSource.Token

        Do
            Me.Invalidate()
            Await Task.Delay(100, token)
            If (_cancellationTokenSource.IsCancellationRequested) Then
                Exit Do
            End If
        Loop
    End Function

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim centerX As Integer = Me.Width \ 2
        Dim centerY As Integer = Me.Height \ 2
        Dim radius As Integer = Math.Min(centerX, centerY) - 10

        ' Draw clock circle
        g.DrawEllipse(SystemPens.ControlText, centerX - radius, centerY - radius, radius * 2, radius * 2)

        ' Draw hour marks
        For i As Integer = 0 To 11
            Dim angle As Double = i * (2 * Math.PI / 12)
            Dim markX As Integer = CInt(centerX + (radius - 20) * Math.Sin(angle))
            Dim markY As Integer = CInt(centerY - (radius - 20) * Math.Cos(angle))
            g.FillEllipse(SystemBrushes.ControlText, markX - 2, markY - 2, 4, 4)

            ' Draw binary representation of hour letters
            Dim binaryHour As String = Convert.ToString(i, 2).PadLeft(4, "0"c)
            Dim font As New Font("Comic Sans", 14)
            Dim textSize As SizeF = g.MeasureString(binaryHour, font)
            textSize += New SizeF(10, 10)

            ' Calculate inner ellipse radii
            Dim innerRadiusX As Integer = radius - CInt(textSize.Width)
            Dim innerRadiusY As Integer = radius - CInt(textSize.Height * 2)

            ' Calculate text position on inner ellipse
            Dim textX As Integer = CInt(centerX + innerRadiusX * Math.Sin(angle) - textSize.Width / 2)
            Dim textY As Integer = CInt(centerY - innerRadiusY * Math.Cos(angle) - textSize.Height / 2)

            g.DrawString(binaryHour, font, SystemBrushes.ControlText, textX, textY)
        Next

        ' Get current time
        Dim currentTime As DateTime = DateTime.Now
        Dim hour As Integer = currentTime.Hour Mod 12
        Dim minute As Integer = currentTime.Minute
        Dim milliSeconds As Integer = currentTime.Second * 1000 + currentTime.Millisecond

        ' Draw hour hand
        Dim hourAngle As Double = (hour + minute / 60 + milliSeconds / 3600000) * (2 * Math.PI / 12)
        Dim hourHandLength As Integer = CInt(radius * 0.5)
        Dim hourHandX As Integer = CInt(centerX + hourHandLength * Math.Sin(hourAngle))
        Dim hourHandY As Integer = CInt(centerY - hourHandLength * Math.Cos(hourAngle))
        g.DrawLine(SystemPens.ControlText, centerX, centerY, hourHandX, hourHandY)

        ' Draw minute hand
        Dim minuteAngle As Double = (minute + milliSeconds / 60000) * (2 * Math.PI / 60)
        Dim minuteHandLength As Integer = CInt(radius * 0.7)
        Dim minuteHandX As Integer = CInt(centerX + minuteHandLength * Math.Sin(minuteAngle))
        Dim minuteHandY As Integer = CInt(centerY - minuteHandLength * Math.Cos(minuteAngle))
        g.DrawLine(SystemPens.ControlText, centerX, centerY, minuteHandX, minuteHandY)

        ' Draw second hand
        Dim secondAngle As Double = milliSeconds * (2 * Math.PI / 60000)
        Dim secondHandLength As Integer = CInt(radius * 0.9)
        Dim secondHandX As Integer = CInt(centerX + secondHandLength * Math.Sin(secondAngle))
        Dim secondHandY As Integer = CInt(centerY - secondHandLength * Math.Cos(secondAngle))
        g.DrawLine(SystemPens.HotTrack, centerX, centerY, secondHandX, secondHandY)
    End Sub

End Class
