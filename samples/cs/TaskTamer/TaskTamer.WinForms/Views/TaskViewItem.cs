using CommunityToolkit.WinForms.GridView;
using System.Globalization;
using TaskTamer.DTOs;
using TaskTamer.ViewModels;
using TaskTamer9.WinForms.ValueConverter;

namespace TaskTamer9.WinForms.Views;

public partial class TaskViewItem : GridViewItemTemplate
{
    private const int FieldPadding = 10;
    private const int BaseFontSize = 11;

    private static Font _taskNameFont = new("Segoe UI", BaseFontSize+5, FontStyle.Bold);
    private static Font _prioritySymbolFont = new("Segoe UI", BaseFontSize + 7, FontStyle.Bold);
    private static readonly Font _taskDescriptionFont = new("Segoe UI", BaseFontSize + 3, FontStyle.Regular);
    private static readonly Font _taskDetailsFont = new("Segoe UI", BaseFontSize, FontStyle.Regular);

    private readonly int _leadingOffset = 60;

    protected override Size GetPreferredSize(Size restrictedSize)
    {
        // For simplicity, we just return a fixed size for the height.
        // But we can as well calculate the height based on the content.
        return new(restrictedSize.Width, 140);
    }

    protected override void OnPaintContent(object content, PaintEventArgs e, Rectangle clipBounds, bool isMouseOver)
    {
        // We can only render TaskViews.
        if (content is not TaskViewModel taskView)
        {
            return;
        }

        // Do we have a vertical scrollbar?
        var hasVerticalScrollbar = e.ClipRectangle.Width < clipBounds.Width;

        // Here we're painting the context of the TaskViewItem:
        DrawBackground(e.Graphics, clipBounds, isMouseOver);
        DrawTaskCheckedRadioButton(taskView, e.Graphics, clipBounds);

        int taskNameHeight = DrawTaskName(taskView, e.Graphics, clipBounds);
        DrawEllipsedTaskDescription(taskView, e.Graphics, clipBounds, taskNameHeight);

        string priorityString = (string)ValueConverters.PriorityToString.Convert(taskView.Priority, typeof(string), null, CultureInfo.CurrentCulture);
        string percentDoneString = (string)ValueConverters.TaskPercentDoneToString.Convert(taskView.PercentDone, typeof(string), null, CultureInfo.CurrentCulture);

        _ = DrawFieldValue($"Due: {taskView.DueDate:MM/dd/yy hh:mm}", e.Graphics, clipBounds, FieldPadding);
        _ = DrawFieldValue($"Start: {taskView.StartDate:MM/dd/yy hh:mm}", e.Graphics, clipBounds, 330);
        _ = DrawFieldValue($"{taskView.Category}", e.Graphics, clipBounds, 650);
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

    private void DrawTaskCheckedRadioButton(TaskViewModel taskView, Graphics graphics, Rectangle clipBounds)
    {
        // Should be painted on the left side of the TaskViewItem.

        // Let's get the ButtonState based on the TaskStatus:
        var buttonState = (IsDarkMode ? ButtonState.Flat : ButtonState.Normal)
            | taskView.Status switch
            {
                TaskItemStatus.Completed => ButtonState.Checked,
                TaskItemStatus.Canceled => ButtonState.Inactive,
                TaskItemStatus.NotStarted => ButtonState.Normal,
                TaskItemStatus.InProgress => ButtonState.Pushed,
                TaskItemStatus.Undefined => ButtonState.Inactive,
                _ => ButtonState.Normal
            };

        Rectangle taskRadioButtonBounds = new(
            x: clipBounds.Left + 10,
            y: clipBounds.Top + 30,
            width: 30,
            height: 30);

        ControlPaint.DrawRadioButton(
            graphics,
            taskRadioButtonBounds,
            buttonState);
    }

    private int DrawTaskName(TaskViewModel taskView, Graphics graphics, Rectangle clipBounds)
    {
        string prioritySymbol = (string)ValueConverters.PriorityToString.Convert(
            value: taskView.Priority,
            targetType: typeof(string),
            parameter: false,
            culture: CultureInfo.CurrentCulture);

        // Determine the color based on priority
        Color priorityColor = taskView.Priority switch
        {
            0 => Color.Green,
            1 => Color.Red,
            2 => Color.FromArgb(255, 255, 128, 128),
            3 => Color.FromArgb(255, 128, 255, 128),
            4 => Color.FromArgb(255, 64, 255, 128),
            _ => Color.Black
        };

        // Measure the size of the priority symbol and task name
        var prioritySymbolSize = TextRenderer.MeasureText(prioritySymbol, _prioritySymbolFont);
        var taskNameSize = TextRenderer.MeasureText(taskView.Description, _taskNameFont);

        // Calculate the bounds for the priority symbol and task name
        RectangleF prioritySymbolBounds = new(
            x: clipBounds.Left + _leadingOffset,
            y: clipBounds.Top + ContentPadding.Top,
            width: prioritySymbolSize.Width,
            height: prioritySymbolSize.Height);

        RectangleF taskNameBounds = new(
            x: clipBounds.Left + _leadingOffset + prioritySymbolSize.Width,
            y: clipBounds.Top + ContentPadding.Top,
            width: clipBounds.Width - _leadingOffset - prioritySymbolSize.Width,
            height: taskNameSize.Height);

        // Draw the priority symbol
        var priorityBrush = new SolidBrush(priorityColor);
        graphics.DrawString(prioritySymbol, _prioritySymbolFont, priorityBrush, prioritySymbolBounds);

        // Draw the task name, ellipsed if too long
        if (taskNameSize.Width > taskNameBounds.Width)
        {
            TextRenderer.DrawText(
                graphics,
                taskView.Description,
                _taskNameFont,
                Rectangle.Round(taskNameBounds),
                HighlightFontColor,
                TextFormatFlags.EndEllipsis);
        }
        else
        {
            var brush = new SolidBrush(HighlightFontColor);
            graphics.DrawString(taskView.Description, _taskNameFont, brush, taskNameBounds);
        }

        return taskNameSize.Height;
    }

    private void DrawEllipsedTaskDescription(TaskViewModel taskView, Graphics graphics, Rectangle clipBounds, int taskNameHeight)
    {
        Rectangle taskDescriptionBounds = new(
            x: clipBounds.Left + 60,
            y: clipBounds.Top + taskNameHeight + ContentPadding.Top + LineSpacing,
            width: clipBounds.Width - 300,
            height: (int)(_taskDescriptionFont.GetHeight() * 2) + 20);

        // Now, we're measuring the multi-line height:
        TextRenderer.DrawText(
            graphics,
            taskView.Notes,
            _taskDescriptionFont,
            taskDescriptionBounds,
            StandardFontColor,
            TextFormatFlags.WordEllipsis | TextFormatFlags.WordBreak);
    }

    private int DrawFieldValue(string value, Graphics graphics, Rectangle clipBounds, int offset)
    {
        // We need to draw it ellipsed if it's too long:
        var valueSize = TextRenderer.MeasureText(value, _taskDetailsFont);
        offset += FieldPadding;

        RectangleF dueDateBounds = new(
            x: clipBounds.Right - (offset + ContentPadding.Right + Padding.Right + Padding.Left + valueSize.Width + clipBounds.X),
            y: clipBounds.Top + ContentPadding.Top,
            width: valueSize.Width,
            height: valueSize.Height);

        var brush = new SolidBrush(StandardFontColor);

        graphics.DrawString(
            value,
            _taskDetailsFont,
            brush,
            dueDateBounds);

        return valueSize.Width + offset;
    }
}
