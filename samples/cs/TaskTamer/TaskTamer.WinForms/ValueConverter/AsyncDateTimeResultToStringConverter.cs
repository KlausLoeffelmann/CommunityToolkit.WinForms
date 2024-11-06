using System.Globalization;

namespace TaskTamer9.WinForms.ValueConverter;

internal class NonUiThreadDateTimeResultToStringConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is DateTime dateTime)
        {
            return dateTime.ToString("g");
        }

        return string.Empty;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is string dateTimeString)
        {
            if (DateTime.TryParse(dateTimeString, out DateTime dateTime))
            {
                return dateTime;
            }
        }
        return DateTime.MinValue;
    }
}
