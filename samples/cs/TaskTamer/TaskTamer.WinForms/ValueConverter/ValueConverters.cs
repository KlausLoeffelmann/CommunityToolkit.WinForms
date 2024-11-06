using CommunityToolkit.WinForms.ComponentModel;

namespace TaskTamer9.WinForms.ValueConverter;

// List with static converters we need for UI-Updates.
internal static class ValueConverters
{
    public static IValueConverter TaskPercentDoneToString { get; } = new TaskPercentDoneToStringConverter();
    public static IValueConverter PriorityToString { get; } = new PriorityToStringConverter();
    public static IValueConverter DateModifiedToString { get; } = new DateModifiedToStringConverter();
    public static IValueConverter ProjectVMToString { get; } = new ProjectVMToStringConverter();
}
