using CommunityToolkit.WinForms.ComponentModel;
using System.Globalization;

namespace TaskTamer9.WinForms.ValueConverter;

internal class DateModifiedToStringConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        => value is DateTimeOffset dateTimeOffset
            ? $"Modified: {dateTimeOffset:yy-MM-dd HH:mm (K)}"
            : "Modified: no info.";

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException("ConvertBack for PriorityToStringConverter should not be called.");
    }
}
