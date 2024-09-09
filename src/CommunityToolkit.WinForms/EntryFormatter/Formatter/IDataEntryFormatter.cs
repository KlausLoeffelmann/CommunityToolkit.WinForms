using System.ComponentModel;

namespace CommunityToolkit.WinForms.EntryFormatter;

[TypeConverter(typeof(DataEntryFormatterTypeConverter))]
public interface IDataEntryFormatter<T>
    : INotifyPropertyChanged
{
    Task<T?> ConvertToValueAsync(string? stringValue);

    Task<string?> ConvertToDisplayAsync(T? value);

    Task<string?> InitializeEditedValueAsync(T? value);
}
