using System.ComponentModel;

namespace CommunityToolkit.WinForms.TypedInputExtenders;

[TypeConverter(typeof(TypedFormatterTypeConverter))]
public interface ITypedFormatter<T>
    : INotifyPropertyChanged
{
    Task<T?> ConvertToValueAsync(string? stringValue);

    Task<string?> ConvertToDisplayAsync(T? value);

    Task<string?> InitializeEditedValueAsync(T? value);
}
