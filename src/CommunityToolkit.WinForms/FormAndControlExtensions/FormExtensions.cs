namespace CommunityToolkit.WinForms.Extensions;

public static class FormExtensions
{
    /// <summary>
    ///  Centers the form on the specified screen or the screen containing the form.
    /// </summary>
    /// <param name="form">The form to be centered.</param>
    /// <param name="screen">The screen on which to center the form. If null, the screen containing the form is used.</param>
    /// <param name="horizontalFillGrade">The percentage of the horizontal space to fill. Default is 50%.</param>
    /// <param name="verticalFillGrade">The percentage of the vertical space to fill. Default is 50%.</param>
    /// <returns>A <see cref="Rectangle"/> representing the bounds of the centered form.</returns>
    public static Rectangle CenterOnScreen(this Form form, Screen? screen = null, int horizontalFillGrade = 50, int verticalFillGrade = 50)
    {
        Rectangle screenBounds = (screen ?? Screen.FromControl(form)).Bounds;

        // Calculate the x and y coordinates of the form and its size to center it on the screen,
        // and take the fill grades of the form with respect to the screen real estate into account.
        // First, calculate the Form's size and take the fill grades into account:
        // 1. Calculate the width and height of the form that would be required to fill the screen
        //    horizontally and vertically.
        int width = screenBounds.Width * horizontalFillGrade / 100;
        int height = screenBounds.Height * verticalFillGrade / 100;

        // 2. Calculate the x and y coordinates of the form that would be required to center it on the screen.
        int x = screenBounds.X + (screenBounds.Width - width) / 2;
        int y = screenBounds.Y + (screenBounds.Height - height) / 2;

        return new Rectangle(x, y, width, height);
    }

    /// <summary>
    ///  Gets the bounds of the form that can be restored to.
    /// </summary>
    /// <param name="form">The form whose restorable bounds are to be retrieved.</param>
    /// <returns>A <see cref="Rectangle"/> representing the restorable bounds of the form.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the form is in an unknown window state.</exception>
    public static Rectangle GetRestorableBounds(this Form form)
        => form.WindowState switch
        {
            FormWindowState.Normal => form.Bounds,
            FormWindowState.Maximized => form.RestoreBounds,
            FormWindowState.Minimized => form.RestoreBounds,
            _ => throw new InvalidOperationException("Unknown window state.")
        };

    /// <summary>
    ///  Shows the form as a modal dialog box with a data context.
    /// </summary>
    /// <typeparam name="T">The type of the data context.</typeparam>
    /// <param name="form">The form to be shown as a dialog.</param>
    /// <param name="dialogDataContext">
    ///  The data context to be passed to the form. This parameter is passed by 
    ///  reference and will be updated with the form's data context after the dialog is closed.</param>
    /// <returns>
    ///  A <see cref="DialogResult{T}"/> containing the result of the dialog and
    ///  the updated data context.
    /// </returns>
    public static DialogResult<T> ShowDialog<T>(this Form form, ref T? dialogDataContext)
    {
        if (dialogDataContext is not null)
        {
            form.DataContext = dialogDataContext;
        }

        var dialogResult = form.ShowDialog();
        dialogDataContext = (T?)form.DataContext;
        var result = new DialogResult<T>(dialogDataContext, dialogResult);

        return result;
    }
}
