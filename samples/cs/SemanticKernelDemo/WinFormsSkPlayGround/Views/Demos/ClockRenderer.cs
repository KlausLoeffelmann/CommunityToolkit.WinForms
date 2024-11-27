using System.Drawing.Drawing2D;

namespace WinFormsSkPlayGround.Views;

public class ClockRenderer(HourMarksStyle hourMarksStyle)
{
    public HourMarksStyle HourMarksStyle { get; set; } = hourMarksStyle;

    public void DrawClock(Graphics g, int width, int height)
    {
        g.SmoothingMode = SmoothingMode.AntiAlias;

        int centerX = width / 2;
        int centerY = height / 2;
        int radius = Math.Min(centerX, centerY) - 10;

        if (HourMarksStyle == HourMarksStyle.TurningClockFace)
        {
            DrawTurningClockFace(g, centerX, centerY, radius);
        }
        else
        {
            DrawClockCircle(g, centerX, centerY, radius);
            DrawHourMarks(g, centerX, centerY, radius);
            DrawClockHands(g, centerX, centerY, radius);
        }
    }

    private void DrawTurningClockFace(Graphics g, int centerX, int centerY, int radius)
    {
        DateTime currentTime = DateTime.Now;
        int second = currentTime.Second;
        double rotationAngle = -second * (2 * Math.PI / 60);

        g.TranslateTransform(centerX, centerY);
        g.RotateTransform((float)(rotationAngle * 180 / Math.PI));
        g.TranslateTransform(-centerX, -centerY);

        DrawClockCircle(g, centerX, centerY, radius);
        DrawHourMarks(g, centerX, centerY, radius);
        DrawHourHand(g, centerX, centerY, radius, currentTime.Hour % 12, currentTime.Minute, currentTime.Second * 1000 + currentTime.Millisecond);
        DrawMinuteHand(g, centerX, centerY, radius, currentTime.Minute, currentTime.Second * 1000 + currentTime.Millisecond);
        DrawSecondHand(g, centerX, centerY, radius, currentTime.Second * 1000 + currentTime.Millisecond);

        g.ResetTransform();
    }

    private void DrawClockCircle(Graphics g, int centerX, int centerY, int radius)
    {
        g.DrawEllipse(SystemPens.ControlText, centerX - radius, centerY - radius, radius * 2, radius * 2);
    }

    private void DrawHourMarks(Graphics g, int centerX, int centerY, int radius)
    {
        for (int i = 0; i < 12; i++)
        {
            double angle = i * (2 * Math.PI / 12);
            int markX = (int)(centerX + (radius - 20) * Math.Sin(angle));
            int markY = (int)(centerY - (radius - 20) * Math.Cos(angle));
            g.FillEllipse(SystemBrushes.ControlText, markX - 2, markY - 2, 4, 4);

            string hourText = HourMarksStyle switch
            {
                var style when (style & HourMarksStyle.ArabicNumerals) == HourMarksStyle.ArabicNumerals 
                    => (i == 0 ? 12 : i).ToString(),

                var style when (style & HourMarksStyle.RomanNumerals) == HourMarksStyle.RomanNumerals 
                    => ToRoman(i == 0 ? 12 : i),

                var style when (style & HourMarksStyle.BinaryNumerals) == HourMarksStyle.BinaryNumerals 
                    => Convert.ToString(i, 2).PadLeft(4, '0'),

                // Default arabic.
                _ => (i == 0 ? 12 : i).ToString()
            };

            using var font = new Font("Comic Sans", 14);
            SizeF textSize = g.MeasureString(hourText, font);
            textSize += new SizeF(10, 10);

            int innerRadiusX = radius - (int)textSize.Width;
            int innerRadiusY = radius - (int)(textSize.Height * 2);

            int textX = (int)(centerX + innerRadiusX * Math.Sin(angle) - textSize.Width / 2);
            int textY = (int)(centerY - innerRadiusY * Math.Cos(angle) - textSize.Height / 2);

            g.DrawString(hourText, font, SystemBrushes.ControlText, textX, textY);
        }
    }

    private static string ToRoman(int number)
    {
        if (number < 1 || number > 12) throw new ArgumentOutOfRangeException(nameof(number));
        string[] romanNumerals = ["I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII"];
        return romanNumerals[number - 1];
    }

    private void DrawClockHands(Graphics g, int centerX, int centerY, int radius)
    {
        DateTime currentTime = DateTime.Now;
        int hour = currentTime.Hour % 12;
        int minute = currentTime.Minute;
        int milliSeconds = currentTime.Second * 1000 + currentTime.Millisecond;

        DrawHourHand(g, centerX, centerY, radius, hour, minute, milliSeconds);
        DrawMinuteHand(g, centerX, centerY, radius, minute, milliSeconds);
        DrawSecondHand(g, centerX, centerY, radius, milliSeconds);
    }

    private void DrawHourHand(Graphics g, int centerX, int centerY, int radius, int hour, int minute, int milliSeconds)
    {
        double hourAngle = (hour + minute / 60.0 + milliSeconds / 3600000.0) * (2 * Math.PI / 12);
        int hourHandLength = (int)(radius * 0.5);
        int hourHandX = (int)(centerX + hourHandLength * Math.Sin(hourAngle));
        int hourHandY = (int)(centerY - hourHandLength * Math.Cos(hourAngle));
        g.DrawLine(SystemPens.ControlText, centerX, centerY, hourHandX, hourHandY);
    }

    private void DrawMinuteHand(Graphics g, int centerX, int centerY, int radius, int minute, int milliSeconds)
    {
        double minuteAngle = (minute + milliSeconds / 60000.0) * (2 * Math.PI / 60);
        int minuteHandLength = (int)(radius * 0.7);
        int minuteHandX = (int)(centerX + minuteHandLength * Math.Sin(minuteAngle));
        int minuteHandY = (int)(centerY - minuteHandLength * Math.Cos(minuteAngle));
        g.DrawLine(SystemPens.ControlText, centerX, centerY, minuteHandX, minuteHandY);
    }

    private void DrawSecondHand(Graphics g, int centerX, int centerY, int radius, int milliSeconds)
    {
        double secondAngle = milliSeconds * (2 * Math.PI / 60000);
        int secondHandLength = (int)(radius * 0.9);
        int secondHandX = (int)(centerX + secondHandLength * Math.Sin(secondAngle));
        int secondHandY = (int)(centerY - secondHandLength * Math.Cos(secondAngle));
        g.DrawLine(SystemPens.HotTrack, centerX, centerY, secondHandX, secondHandY);
    }
}
