using CommunityToolkit.WinForms.ComponentModel;

namespace TaskTamer9.WinForms.ValueConverter;

internal static class ValueConverters
{
    public static IValueConverter TaskPercentDoneToString { get; } = new TaskPercentDoneToStringConverter();
    public static IValueConverter PriorityToString { get; } = new PriorityToStringConverter();
}

