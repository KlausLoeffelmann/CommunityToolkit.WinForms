using CommunityToolkit.WinForms.ComponentModel;
using System.Globalization;
using TaskTamer.ViewModels;

namespace TaskTamer9.WinForms.ValueConverter;

internal class ProjectVMToStringConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        => value is ProjectViewModel project
            ? $"Project: {project.Name}"
            : "Project: - - -";

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException("ConvertBack for PriorityToStringConverter should not be called.");
    }
}
