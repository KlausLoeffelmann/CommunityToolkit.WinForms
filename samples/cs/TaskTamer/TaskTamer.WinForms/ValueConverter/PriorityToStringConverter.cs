using CommunityToolkit.WinForms.ComponentModel;
using System.Globalization;

namespace TaskTamer9.WinForms.ValueConverter;

internal class PriorityToStringConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        => value is int priority
            ? priority switch
            {
                0 => "↓",
                1 => "!",
                2 => "↖",
                3 => "←",
                4 => "↙",
                _ => throw new ArgumentOutOfRangeException(nameof(value), priority, "Priority must be between 0 and 4.")
            } + (parameter is bool showPriority && !showPriority ? "" : $" ({priority})")
            : throw new ArgumentException("Value must be an integer.", nameof(value));

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException("ConvertBack for PriorityToStringConverter should not be called.");
    }
}

public class AsyncBinding(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode dataSourceUpdateMode, object nullValue) : Binding(propertyName, dataSource, dataMember, formattingEnabled, dataSourceUpdateMode, nullValue)
{
    protected override void OnFormat(ConvertEventArgs cevent) 
        => base.OnFormat(cevent);
}
