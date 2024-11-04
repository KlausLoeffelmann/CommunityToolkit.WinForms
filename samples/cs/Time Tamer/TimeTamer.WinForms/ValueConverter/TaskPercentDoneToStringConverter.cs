using CommunityToolkit.WinForms.ComponentModel;
using System.Globalization;

namespace TaskTamer9.WinForms.ValueConverter;

internal class TaskPercentDoneToStringConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture) 
        => value is int percentDone
            ? percentDone switch
                {
                    0 => "---",
                    > 0 and < 101 => $"{percentDone:000}",
                    _ => throw new ArgumentOutOfRangeException(nameof(value), percentDone, "Percent Done must be between 0 and 100.")
                }
            : throw new ArgumentException("Value must be an integer.", nameof(value));

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is string percentDoneString)
        {
            if (percentDoneString == "---")
            {
                return 0;
            }

            if (int.TryParse(percentDoneString, out int percentDone) 
                && percentDone >= 0 && percentDone <= 100)
            {
                return percentDone;
            }
        }

        throw new ArgumentException("Value must be a string representing an integer between 0 and 100.", nameof(value));
    }
}
