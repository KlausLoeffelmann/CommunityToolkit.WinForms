using CommunityToolkit.WinForms.GridView;
using Microsoft.VisualBasic;
using System.ComponentModel;
using TaskTamer.DataLayer.Models;
using TaskTamer.DTOs;
using TaskTamer.ViewModels;

namespace TaskTamer9.WinForms.Views;

public partial class TaskViewItem : GridViewItemTemplate
{
    private const int FieldPadding = 10;

    private Font _taskNameFont = new("Segoe UI", 16, FontStyle.Bold);
    private Font _taskDescriptionFont = new("Segoe UI", 14, FontStyle.Regular);
    private Font _taskDetailsFont = new("Segoe UI", 11, FontStyle.Regular);

    private int _leadingOffset = 60;

    [Bindable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Browsable(true)]
    public Font NameFont
    {
        get => _taskNameFont;
        set
        {
            if (_taskNameFont == value)
                return;

            _taskNameFont = value;
        }
    }

    [Bindable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Browsable(true)]
    public Font DescriptionFont
    {
        get => _taskNameFont;
        set
        {
            if (_taskNameFont == value)
                return;

            _taskNameFont = value;
        }
    }

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

        var dueDateWidth = DrawFieldValue($"Due: {taskView.DueDate}", e.Graphics, clipBounds, FieldPadding);
        var categoryWidth = DrawFieldValue($"Cat: {taskView.Category}", e.Graphics, clipBounds, dueDateWidth);
        var projectWidth = DrawFieldValue($"Prj: {taskView.Project}", e.Graphics, clipBounds, categoryWidth);
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
        // We need to draw it ellipsed if it's too long:
        var taskNameSize = TextRenderer.MeasureText(taskView.Explanation, _taskNameFont);

        RectangleF taskNameBounds = new(
            x: clipBounds.Left + _leadingOffset,
            y: clipBounds.Top + ContentPadding.Top,
            width: clipBounds.Width - _leadingOffset,
            height: taskNameSize.Height);

        if (taskNameSize.Width > taskNameBounds.Width)
        {
            TextRenderer.DrawText(
                graphics,
                taskView.Explanation,
                _taskNameFont,
                Rectangle.Round(taskNameBounds),
                HighlightFontColor,
                TextFormatFlags.EndEllipsis);
        }
        else
        {
            var brush = new SolidBrush(HighlightFontColor);
            graphics.DrawString(taskView.Explanation, _taskNameFont, brush, taskNameBounds);
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
