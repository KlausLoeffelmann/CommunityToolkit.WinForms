using CommunityToolkit.WinForms.FluentUI;
using CommunityToolkit.WinForms.FluentUI.Imaging;
using System.Diagnostics;

namespace PictureViewer;

public partial class ImageItem : GridViewItemTemplate
{
    private const int FieldPadding = 10;
    private const int BaseFontSize = 11;

    private static Font s_placeholderImageFont = new("Segoe UI", BaseFontSize + 4, FontStyle.Regular);
    private static Font s_exifStandardFont = new("Segoe UI", BaseFontSize, FontStyle.Regular);
    private static Font s_exifBoldFont = new("Segoe UI", BaseFontSize, FontStyle.Bold);

    private static Color ARatherBrightColor = Color.FromArgb(255, 230, 230, 230);
    private static Color ARatherDarkColor = Color.FromArgb(255, 20, 20, 20);


    private static SolidBrush s_placeHolderBrush;    // Placeholder color for the image
    private static SolidBrush s_exifDataColor;       // Color for the EXIF data
    private bool _hasVerticalScrollbar;

    private readonly Padding _imagePadding = new(10);
    private readonly int _leadingOffset = 20;
    private readonly GridView _parentGridView;

    static ImageItem()
    {
        // Should be "Trabant-Blue":
        s_placeHolderBrush = new SolidBrush(Color.FromArgb(255, 0, 120, 215));

        // BOOKMARK 01: We define the Color of the placeholder image and the exif data:
        s_exifDataColor = new SolidBrush(ARatherDarkColor);
    }

    public ImageItem(GridView parentGridView)
    {
        _parentGridView = parentGridView;
    }

    protected override Size GetPreferredSize(Size restrictedSize, object? value, int rowIndex)
    {
        // For simplicity, we just return a fixed size for the height.
        // But we can as well calculate the height based on the content.
        return new(restrictedSize.Width, 300);
    }

    protected override async void OnPaintContent(object content, DataGridViewCell gridViewCell, PaintEventArgs e, Rectangle clipBounds, bool isMouseOver)
    {
        // We divide the clipboards in 2 parts: Image and exifData, so we have 2 clipping areas.
        Rectangle imageClipBounds = new(
            clipBounds.X,
            clipBounds.Y,
            clipBounds.Width / 2,
            clipBounds.Height);

        Rectangle exifClipBounds = new(
            clipBounds.X + clipBounds.Width / 2,
            clipBounds.Y,
            clipBounds.Width / 2,
            clipBounds.Height);

        try
        {
            // We can only render our AsyncPictureComponents.
            if (content is not AsyncPictureComponent pictureComponent)
            {
                return;
            }

            // Do we have a vertical scrollbar?
            _hasVerticalScrollbar = e.ClipRectangle.Width < clipBounds.Width;

            DrawBackground(e.Graphics, clipBounds, isMouseOver);
            await DrawImageOrPlaceholder(pictureComponent, gridViewCell, e.Graphics, imageClipBounds, exifClipBounds);
        }
        catch (Exception ex) when (ex is not StackOverflowException or InsufficientMemoryException)
        {
            Debug.WriteLine(ex.Message);
        }
    }

    private async Task DrawImageOrPlaceholder(
        AsyncPictureComponent pictureComponent,
        DataGridViewCell gridViewCell,
        Graphics g,
        Rectangle imageClipBounds,
        Rectangle exifClipBounds)
    {
        // We need to proportional size the image though, so it fits into the cell.

        // Here we're painting the context of the TaskViewItem:

        // Draw a placeholder image.
        if (pictureComponent.Bitmap is null)
        {
            DrawPlaceholder(pictureComponent.ImageFileInfo!.Name, g, imageClipBounds);
        }

        DrawExifData(pictureComponent, g, exifClipBounds);

        if (pictureComponent.Bitmap is not null)
        {
            // Calculate the proportional size of the image, taking padding into account
            Size imageSize = pictureComponent.Bitmap.Size;
            Size cellSize = new(
                imageClipBounds.Width - _imagePadding.Horizontal,
                imageClipBounds.Height - _imagePadding.Vertical);

            float widthRatio = cellSize.Width / (float)imageSize.Width;
            float heightRatio = cellSize.Height / (float)imageSize.Height;
            float scale = Math.Min(widthRatio, heightRatio);

            Size scaledSize = new(
                (int)(imageSize.Width * scale),
                (int)(imageSize.Height * scale));

            // Set the position to center the image horizontally within the padded area
            int x = imageClipBounds.X + _imagePadding.Left + (cellSize.Width - scaledSize.Width) / 2;
            int y = imageClipBounds.Y + _imagePadding.Top;

            // Draw the image with padding-adjusted positioning, scaling, and horizontal centering
            g.DrawImage(pictureComponent.Bitmap, x, y, scaledSize.Width, scaledSize.Height);
        }
        else
        {
            // BOOKMARK 02 : Pitfalls when using Async/Await in Paint events!

            // Important: NEVER use a Graphics-object provided by an OnPaint-like event
            // in or after an await. By the time, the callbacks come in from the async's
            // generated state-machine, the Graphics object will be long gone.

            // This is fine, because nothing comes after, and we are also not using the
            // the graphics object inside of the async methods.
            await pictureComponent.LoadImageAsync();

            await _parentGridView.InvokeAsync(() =>
            {
                if (gridViewCell.Displayed)
                {
                    _parentGridView.InvalidateCell(gridViewCell);
                }
            });
        }
    }

    private void DrawExifData(
        AsyncPictureComponent pictureComponent,
        Graphics g, Rectangle
        clipBounds)
    {
        ArgumentNullException.ThrowIfNull(pictureComponent);

        // We need to make sure, that neither the pictureComponent nor the ImageFileInfo is null.
        ArgumentNullException.ThrowIfNull(pictureComponent?.ImageFileInfo);

        // Define a font for the EXIF data display
        float lineHeight = s_exifBoldFont.GetHeight(g) + 4;

        // We want to start the text in right 3rd of the image, and need an offset:
        float xPosition = clipBounds.Left + _leadingOffset;
        float yPosition = clipBounds.Top + 10;

        // Adjust xPosition if there's a scrollbar
        if (_hasVerticalScrollbar)
        {
            xPosition += SystemInformation.VerticalScrollBarWidth;
        }

        // Retrieve EXIF data (assuming properties in AsyncPictureComponent or similar)
        DrawLabelAndValue("Name - Image type:", $"{pictureComponent.ImageFileInfo.Name} - {pictureComponent.ImageFileInfo.Extension}");
        DrawLabelAndValue("Path:", $"{pictureComponent.ImageFileInfo.DirectoryName}");
        DrawLabelAndValue("Date taken:", $"{pictureComponent.ImageFileInfo.DateTaken:dddd, mmmm dd, yyyy  HH:mm}");
        DrawLabelAndValue("Size:", $"{pictureComponent.ImageFileInfo.HorizontalSize} / {pictureComponent.ImageFileInfo.VerticalSize}");
        DrawLabelAndValue("Resolution:", $"{pictureComponent.ImageFileInfo.HorizontalResolution} / {pictureComponent.ImageFileInfo.VerticalResolution}");
        DrawLabelAndValue("F-Stop:", $"{pictureComponent.ImageFileInfo.FocalLength}");
        DrawLabelAndValue("Camera-Model:", $"{pictureComponent.ImageFileInfo.CameraManufacturer} - {pictureComponent.ImageFileInfo.CameraModel}");
        DrawLabelAndValue("Exposure-Time:", pictureComponent.ImageFileInfo.ExposureIndex);
        DrawLabelAndValue("ISO:", $"{pictureComponent.ImageFileInfo.ISOSpeed}");
        DrawLabelAndValue("Focal-Length:", $"{pictureComponent.ImageFileInfo.FocalLength}");

        // Helper function to draw bold label and value text
        void DrawLabelAndValue(string label, string? value)
        {
            // Draw the label in bold
            g.DrawString(label, s_exifBoldFont, Brushes.Black, xPosition, yPosition);

            float labelWidth = g.MeasureString(label, s_exifBoldFont).Width;

            // Draw the value right after the label, ensuring alignment
            g.DrawString(value ?? "N/A", s_exifStandardFont, Brushes.Black, xPosition + labelWidth + 10, yPosition);

            // Move to the next line
            yPosition += lineHeight;
        }
    }

    private void DrawPlaceholder(string imageName, Graphics g, Rectangle clipBounds)
    {
        string placeholderText = $"Loading {imageName}...";

        SizeF placeholderTextSize = g.MeasureString(placeholderText, s_placeholderImageFont);

        int x = clipBounds.X + (clipBounds.Width - (int)placeholderTextSize.Width) / 2;
        int y = clipBounds.Y + (clipBounds.Height - (int)placeholderTextSize.Height) / 2;

        g.DrawString(placeholderText, s_placeholderImageFont, s_placeHolderBrush, x, y);
    }

    private void DrawBackground(Graphics graphics, Rectangle clipBounds, bool isMouseOver)
    {
        Brush backgroundColorBrush = isMouseOver
            ? base.HighlightedBackgroundColorBrush
            : base.ItemBackgroundColorBrush;

        graphics.FillRoundedRectangle(
            backgroundColorBrush,
            clipBounds,
            new(10, 10));
    }
}
