using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace WinFormsSkPlayGround.Views;

public partial class AsyncSpiralContainer : ContainerControl
{
    private bool _started = false;
    private readonly MultiTaskRenderManager _multiTaskRenderManager;

    public AsyncSpiralContainer() : base()
    {
        _multiTaskRenderManager = MultiTaskRenderManager.GetInstance(32);
    }

    public void KickOff()
    {
        _started = true;
        Invalidate();
    }

    protected override async void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        if (IsAncestorSiteInDesignMode || !_started)
        {
            return;
        }

        var random = new Random();
        var clientSize = ClientSize;
        var handle = Handle;
        int count = 0;

        List<Rectangle> areas = DivideScreen(
            clientSize: clientSize,
            areasCount: _multiTaskRenderManager.TaskCount,
            margin: new Padding(5));

        _multiTaskRenderManager.CreateTaskForEach((token) =>
        {
            return Task.Run(async () =>
            {
                var areaItem = areas[count++];

                Graphics taskGraphics = Graphics.FromHwnd(handle);

                // Set the clipping region to the current area and also the origin to the top-left corner of the area.
                taskGraphics.SetClip(areaItem);
                taskGraphics.TranslateTransform(areaItem.X, areaItem.Y);

                var backgroundColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                var foregroundColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                // Draws our spiral.
                await DrawSpiralAsync(
                    taskGraphics,
                    backgroundColor,
                    foregroundColor,
                    20,
                    token).ConfigureAwait(false);

            }, token);
        });

        await _multiTaskRenderManager.WaitAllFinishedAsync();
    }

    public static async Task DrawSpiralAsync(
        Graphics graphics,
        Color backgroundColor,
        Color foregroundColor,
        int delayMilliseconds,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(graphics);

        if (delayMilliseconds < 20)
            throw new ArgumentOutOfRangeException(nameof(delayMilliseconds), "Delay must be >=20");


        // Set the background
        graphics.Clear(backgroundColor);

        // Set up the pen with the foreground color
        using Pen pen = new(foregroundColor, 2);
        graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Define the spiral parameters
        float centerX = graphics.VisibleClipBounds.Width / 2;
        float centerY = graphics.VisibleClipBounds.Height / 2;
        float radius = Math.Min(centerX, centerY) * 0.9f; // 90% of half the smallest dimension
        int revolutions = 5;
        int pointsPerRevolution = 100;

        // Calculate the spiral points
        PointF[] points = new PointF[revolutions * pointsPerRevolution];

        try
        {
            for (int i = 0; i < points.Length; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();

                double angle = Math.PI * 2 * i / pointsPerRevolution;
                float curRadius = radius * i / points.Length;
                points[i] = new PointF(
                    centerX + curRadius * (float)Math.Cos(angle),
                    centerY + curRadius * (float)Math.Sin(angle)
                );
            }

            // Draw the spiral with throttling
            for (int i = 1; i < points.Length; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();

                graphics.DrawLine(pen, points[i - 1], points[i]);
                if (delayMilliseconds > 0)
                {
                    await Task.Delay(delayMilliseconds, cancellationToken)
                        .ConfigureAwait(false);
                }
            }
        }
        catch (Exception)
        {
            Debug.Print($"-- AsyncSpiralDrawing terminated Task ID: {Task.CurrentId}");
        }
        finally
        {
            graphics.Dispose();
        }
    }

    public static List<Rectangle> DivideScreen(Size clientSize, int areasCount, Padding margin)
    {
        if (areasCount <= 0)
        {
            throw new ArgumentException("Areas count must be positive.", nameof(areasCount));
        }

        var rectangles = new List<Rectangle>();
        if (areasCount == 1)
        {
            rectangles.Add(
                new Rectangle(
                    x: margin.Left,
                    y: margin.Top,
                    width: clientSize.Width - (margin.Left + margin.Right),
                    height: clientSize.Height - (margin.Top + margin.Bottom)));

            return rectangles;
        }

        int rows = (int)Math.Sqrt(areasCount);
        int cols = (int)Math.Ceiling((double)areasCount / rows);
        int lastRowCols = areasCount % cols == 0 ? cols : areasCount % cols;

        int width = (clientSize.Width - margin.Left - margin.Right - (margin.Horizontal * (cols - 1))) / cols;
        int height = (clientSize.Height - margin.Top - margin.Bottom - (margin.Vertical * (rows - 1))) / rows;

        for (int row = 0; row < rows; row++)
        {
            int colsInRow = row == rows - 1 ? lastRowCols : cols;
            for (int col = 0; col < colsInRow; col++)
            {
                int x = margin.Left + col * (width + margin.Horizontal);
                int y = margin.Top + row * (height + margin.Vertical);

                int rectWidth = width;
                int rectHeight = height;

                // Adjust the width for rectangles in the last row if the areasCount isn't evenly divisible
                if (row == rows - 1 && areasCount % cols != 0)
                {
                    int remainingWidth = clientSize.Width - margin.Left - margin.Right - x;
                    if (col == colsInRow - 1) // Last rectangle in the last row
                    {
                        rectWidth = remainingWidth;
                    }
                }

                rectangles.Add(new Rectangle(x, y, rectWidth, rectHeight));
            }
        }

        return rectangles;
    }
}
