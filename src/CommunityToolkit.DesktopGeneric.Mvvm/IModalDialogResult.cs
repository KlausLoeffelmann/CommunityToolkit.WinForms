using System.ComponentModel;

namespace CommunityToolkit.WinForms.DesktopGeneric.Mvvm;

public interface IModalDialogResult<TViewModel>
    where TViewModel : class, INotifyPropertyChanged
{
    TViewModel? ReturnValue { get; }

    DialogResult DialogResult { get; }
}
