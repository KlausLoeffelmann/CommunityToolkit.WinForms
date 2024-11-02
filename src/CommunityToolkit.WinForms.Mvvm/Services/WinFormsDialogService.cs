using CommunityToolkit.DesktopGeneric.Mvvm;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using CommunityToolkit.WinForms.Extensions;
using System.Windows.Forms;

namespace CommunityToolkit.WinForms.Mvvm;

internal partial class WinFormsDialogService : IMvvmDialogService
{
    private IViewLocatorService<ContainerControl> _viewLocator = default!;
    private readonly IServiceProvider _serviceProvider;

    public WinFormsDialogService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    private IViewLocatorService<ContainerControl> ViewLocator
        => _viewLocator ??= _serviceProvider.GetRequiredService<IViewLocatorService<ContainerControl>>();

    public async Task ShowMessageAsync(string message, string title)
    {
        var page = new TaskDialogPage()
        {
            Heading = title,
            Text = message,
            Buttons = [new TaskDialogButton("OK", true)],
        };

        await TaskDialog.ShowDialogAsync(page);
    }

    public async Task<bool> ShowConfirmationAsync(string message, string title)
    {
        var page = new TaskDialogPage()
        {
            Heading = title,
            Text = message,
            Buttons = [new TaskDialogButton("OK", true)],
        };

        var result = await TaskDialog.ShowDialogAsync(page);
        return result == TaskDialogButton.Yes;
    }

    public async Task ShowWarningAsync(string message, string title)
    {
        var page = new TaskDialogPage()
        {
            Heading = title,
            Text = message,
            Buttons = [new TaskDialogButton("OK", true)],
            Icon = TaskDialogIcon.Warning
        };

        await TaskDialog.ShowDialogAsync(page);
    }

    public async Task ShowErrorAsync(string message, string title)
    {
        var page = new TaskDialogPage()
        {
            Heading = title,
            Text = message,
            Buttons = [new TaskDialogButton("OK", true)],
            Icon = TaskDialogIcon.Error
        };

        await TaskDialog.ShowDialogAsync(page);
    }

    public Task<string> RequestInputAsync(string message, string title, string defaultValue = "")
    {
        throw new NotImplementedException();
    }

    public Task<T> SelectFromAsync<T>(string message, string title, IEnumerable<T> options, T? defaultOption = default)
    {
        SelectionForm<T> selectionForm = new(message, title, options, defaultOption);

        // Show the form asynchronously
        return selectionForm.ShowDialogAsync();
    }

    public async Task<IModalDialogResult<TViewModel>> ShowDialogAsync<TViewModel, UIStack>(TViewModel viewModel)
        where TViewModel : class, INotifyPropertyChanged
        where UIStack : struct, Enum
    {
        if (ViewLocator.CreateView(viewModel) is not Form formView)
        {
            throw new InvalidOperationException("The view could not be created.");
        }
        return await formView.ShowDialogAsync<TViewModel>(viewModel);
    }
}
