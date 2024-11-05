using CommunityToolkit.WinForms.ComponentModel;
using System.Globalization;

namespace TaskTamer9.WinForms.ValueConverter;

internal class PriorityToStringConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        => value is int priority
            ? priority switch
            {
                0 => "---",
                > 0 and < 6 => $"{priority:0}",
                _ => throw new ArgumentOutOfRangeException(nameof(value), priority, "Percent Done must be between 0 and 100.")
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
                && percentDone >= 0 && percentDone <= 5)
            {
                return percentDone;
            }
        }

        throw new ArgumentException("Value must be a string representing an integer between 0 and 100.", nameof(value));
    }
}

public class AsyncBinding(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode dataSourceUpdateMode, object nullValue) : Binding(propertyName, dataSource, dataMember, formattingEnabled, dataSourceUpdateMode, nullValue)
{
    protected override void OnFormat(ConvertEventArgs cevent)
    {
        base.OnFormat(cevent);
    }
}