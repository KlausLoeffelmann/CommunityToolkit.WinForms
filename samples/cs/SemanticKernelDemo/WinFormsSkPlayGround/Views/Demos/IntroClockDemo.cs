using System.Drawing.Drawing2D;

namespace WinFormsSkPlayGround.Views;

public class IntroClockDemo : ContainerControl
{
    private readonly CancellationTokenSource _cancellationTokenSource = new();

    public IntroClockDemo()
    {
        DoubleBuffered = true;
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Invalidate();
    }

    protected override async void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        await ClockLoopAsync();
    }

    protected override void Dispose(bool disposing)
    {
        _cancellationTokenSource.Cancel();
        base.Dispose(disposing);
    }

    private async Task ClockLoopAsync()
    {
        CancellationToken token = _cancellationTokenSource.Token;

        while (true)
        {
            Invalidate();
            try
            {
                await Task.Delay(100, token);
            }
            catch (TaskCanceledException)
            {
                break;
            }

            if (_cancellationTokenSource.IsCancellationRequested)
                break;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        int centerX = Width / 2;
        int centerY = Height / 2;
        int radius = Math.Min(centerX, centerY) - 10;

        // Draw clock circle
        g.DrawEllipse(SystemPens.ControlText, centerX - radius, centerY - radius, radius * 2, radius * 2);

        // Draw hour marks
        for (int i = 0; i < 12; i++)
        {
            double angle = i * (2 * Math.PI / 12);
            int markX = (int)(centerX + (radius - 20) * Math.Sin(angle));
            int markY = (int)(centerY - (radius - 20) * Math.Cos(angle));
            g.FillEllipse(SystemBrushes.ControlText, markX - 2, markY - 2, 4, 4);

            // Draw binary representation of hour letters
            string binaryHour = Convert.ToString(i, 2).PadLeft(4, '0');
            using var font = new Font("Comic Sans", 14);
            SizeF textSize = g.MeasureString(binaryHour, font);
            textSize += new SizeF(10, 10);

            // Calculate inner ellipse radii
            int innerRadiusX = radius - (int)textSize.Width;
            int innerRadiusY = radius - (int)(textSize.Height * 2);

            // Calculate text position on inner ellipse
            int textX = (int)(centerX + innerRadiusX * Math.Sin(angle) - textSize.Width / 2);
            int textY = (int)(centerY - innerRadiusY * Math.Cos(angle) - textSize.Height / 2);

            g.DrawString(binaryHour, font, SystemBrushes.ControlText, textX, textY);
        }

        // Get current time
        DateTime currentTime = DateTime.Now;
        int hour = currentTime.Hour % 12;
        int minute = currentTime.Minute;
        int milliSeconds = currentTime.Second * 1000 + currentTime.Millisecond;

        // Draw hour hand
        double hourAngle = (hour + minute / 60.0 + milliSeconds / 3600000.0) * (2 * Math.PI / 12);
        int hourHandLength = (int)(radius * 0.5);
        int hourHandX = (int)(centerX + hourHandLength * Math.Sin(hourAngle));
        int hourHandY = (int)(centerY - hourHandLength * Math.Cos(hourAngle));
        g.DrawLine(SystemPens.ControlText, centerX, centerY, hourHandX, hourHandY);

        // Draw minute hand
        double minuteAngle = (minute + milliSeconds / 60000.0) * (2 * Math.PI / 60);
        int minuteHandLength = (int)(radius * 0.7);
        int minuteHandX = (int)(centerX + minuteHandLength * Math.Sin(minuteAngle));
        int minuteHandY = (int)(centerY - minuteHandLength * Math.Cos(minuteAngle));
        g.DrawLine(SystemPens.ControlText, centerX, centerY, minuteHandX, minuteHandY);

        // Draw second hand
        double secondAngle = milliSeconds * (2 * Math.PI / 60000);
        int secondHandLength = (int)(radius * 0.9);
        int secondHandX = (int)(centerX + secondHandLength * Math.Sin(secondAngle));
        int secondHandY = (int)(centerY - secondHandLength * Math.Cos(secondAngle));
        g.DrawLine(SystemPens.HotTrack, centerX, centerY, secondHandX, secondHandY);
    }
}
