using CommunityToolkit.WinForms.FluentUI;
using CommunityToolkit.WinForms.FluentUI.Imaging;
using System.Diagnostics;

namespace PictureViewer;

public partial class ImageItem : GridViewItemTemplate
{
    private const int FieldPadding = 10;
    private const int BaseFontSize = 9;

    private static Font _taskNameFont = new("Segoe UI", BaseFontSize + 5, FontStyle.Bold);
    private static Font _prioritySymbolFont = new("Segoe UI", BaseFontSize + 7, FontStyle.Bold);
    private static readonly Font _taskDescriptionFont = new("Segoe UI", BaseFontSize + 3, FontStyle.Regular);
    private static readonly Font _taskDetailsFont = new("Segoe UI", BaseFontSize, FontStyle.Regular);

    private readonly int _leadingOffset = 60;

    public ImageItem()
    {
        Debug.Print("ImageItem constructor called.");
    }

    protected override Size GetPreferredSize(Size restrictedSize, object? value, int rowIndex)
    {
        // For simplicity, we just return a fixed size for the height.
        // But we can as well calculate the height based on the content.
        return new(restrictedSize.Width, 300);
    }

    protected override async void OnPaintContent(object content, PaintEventArgs e, Rectangle clipBounds, bool isMouseOver)
    {
        // We can only render TaskViews.
        if (content is not AsyncPictureComponent pictureComponent)
        {
            return;
        }

        // Do we have a vertical scrollbar?
        var hasVerticalScrollbar = e.ClipRectangle.Width < clipBounds.Width;

        // Here we're painting the context of the TaskViewItem:
        DrawBackground(e.Graphics, clipBounds, isMouseOver);
        DrawExifData(pictureComponent, e, clipBounds, hasVerticalScrollbar);
        await DrawImageOrPlaceholder(pictureComponent, e, clipBounds, hasVerticalScrollbar);
    }

    private void DrawExifData(AsyncPictureComponent pictureComponent, PaintEventArgs e, Rectangle clipBounds, bool hasVerticalScrollbar)
    {
        throw new NotImplementedException();
    }

    private async Task DrawImageOrPlaceholder(AsyncPictureComponent pictureComponent, PaintEventArgs e, Rectangle clipBounds, bool hasVerticalScrollbar)
    {
        if (pictureComponent.Bitmap is null)
        {
            // Draw a placeholder image.
            DrawPlaceholder(e.Graphics, clipBounds, hasVerticalScrollbar);
            await pictureComponent.LoadImageAsync();
            DrawImage(e.Graphics);
        }
        else
        {
            e.Graphics.DrawImage(pictureComponent.Bitmap, clipBounds.Location);
        }
    }

    private void DrawPlaceholder(Graphics graphics, Rectangle clipBounds, bool hasVerticalScrollbar)
    {
        var placeholderText = "Loading image...";
        var placeholderTextSize = graphics.MeasureString(placeholderText, _taskNameFont);
        var x = clipBounds.X + (clipBounds.Width - (int)placeholderTextSize.Width) / 2;
        var y = clipBounds.Y + (clipBounds.Height - (int)placeholderTextSize.Height) / 2;
        graphics.DrawString(placeholderText, _taskNameFont, Brushes.Black, x, y);
    }

    private void DrawBackground(Graphics graphics, Rectangle clipBounds, bool isMouseOver)
    {
        var backgroundColorBrush = isMouseOver
            ? base.HighlightedBackgroundColorBrush
            : base.ItemBackgroundColorBrush;

        graphics.FillRoundedRectangle(
            backgroundColorBrush,
            clipBounds,
            new(10, 10));
    }
}
