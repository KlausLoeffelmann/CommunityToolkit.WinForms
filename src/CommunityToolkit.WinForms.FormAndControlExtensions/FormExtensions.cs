using CommunityToolkit.DesktopGeneric.Mvvm;
using System.ComponentModel;
using WinFormsDialogResult = System.Windows.Forms.DialogResult;
using DialogResult = CommunityToolkit.DesktopGeneric.Mvvm.DialogResult;
using CommunityToolkit.WinForms.ComponentModel;
using System.Globalization;

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
    public async static Task<IModalDialogResult<T>> ShowDialogAsync<T>(this Form form, T? dialogDataContext)
        where T : class, INotifyPropertyChanged
    {
        if (dialogDataContext is not null)
        {
            form.DataContext = dialogDataContext;
        }

        var winFormsDialogResult = await form.ShowDialogAsync();
        dialogDataContext = (T?)form.DataContext;

        DialogResult dialogResult = winFormsDialogResult switch
        {
            WinFormsDialogResult.OK => DialogResult.First,
            WinFormsDialogResult.Cancel => DialogResult.Second,
            WinFormsDialogResult.Yes => DialogResult.First,
            WinFormsDialogResult.No => DialogResult.Second,
            WinFormsDialogResult.Abort => DialogResult.First,
            WinFormsDialogResult.Retry => DialogResult.Second,
            WinFormsDialogResult.Ignore => DialogResult.Third,
            _ => DialogResult.None
        };

        return new ModalDialogResult<T>(dialogDataContext, dialogResult);
    }

    public static Binding AddBindingConverter(this IBindableComponent bindableComponent, string propertyName, IValueConverter valueConverter)
    {
        ArgumentNullException.ThrowIfNull(propertyName, nameof(propertyName));
        ArgumentNullException.ThrowIfNull(valueConverter, nameof(valueConverter));

        if (bindableComponent.DataBindings[propertyName] is not Binding binding)
        {
            throw new InvalidOperationException($"No binding found for property '{propertyName}'.");
        }

        binding.Parse += Binding_Parse;
        binding.Format += Binding_Format;
        
        var managerBase = binding.BindingManagerBase;

        bindableComponent.Disposed += Control_Disposed;
        return binding;

        void Binding_Format(object? sender, ConvertEventArgs e)
        {
            e.Value = valueConverter.Convert(e.Value, e.DesiredType!, null, CultureInfo.CurrentCulture);
        }

        void Binding_Parse(object? sender, ConvertEventArgs e)
        {
            e.Value = valueConverter.ConvertBack(e.Value, e.DesiredType!, null, CultureInfo.CurrentCulture);
        }

        void Control_Disposed(object? sender, EventArgs e)
        {
            binding.Parse -= Binding_Parse;
            binding.Format -= Binding_Format;
        }
    }

    public static IEnumerable<Control> GetControlsRecursive(this Control control)
    {
        foreach (Control childControl in control.Controls)
        {
            yield return childControl;

            foreach (Control grandChildControl in childControl.GetControlsRecursive())
            {
                yield return grandChildControl;
            }
        }
    }
}
