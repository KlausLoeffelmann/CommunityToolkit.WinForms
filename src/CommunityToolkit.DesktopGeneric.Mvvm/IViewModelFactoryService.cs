using System.ComponentModel;

namespace CommunityToolkit.WinForms.DesktopGeneric.Mvvm;

public interface IViewModelFactoryService
{
    TViewModel CreateViewModel<TViewModel>() 
        where TViewModel : class, INotifyPropertyChanged;
}
