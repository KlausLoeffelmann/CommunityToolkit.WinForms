using CommunityToolkit.DesktopGeneric.Mvvm;
using System.ComponentModel;

namespace CommunityToolkit.DesktopGeneric.Mvvm.Services;

public class ViewModelFactory(IServiceProvider serviceProvider) : IViewModelFactoryService
{
    public TViewModel CreateViewModel<TViewModel>() where TViewModel 
        : class, INotifyPropertyChanged
    {
        return serviceProvider.GetRequiredService<TViewModel>();
    }
}
