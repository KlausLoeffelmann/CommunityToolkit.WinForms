using System.ComponentModel;
using System.Globalization;

namespace CommunityToolkit.WinForms.TypedInputExtenders;

public partial class IntelDateFormatterComponent
{
    private static readonly DateTimeFormatInfo s_dateFormats;
    private static readonly string[] s_dateTimeFormatStrings;

    static IntelDateFormatterComponent()
    {
        s_dateFormats = CultureInfo.CurrentCulture.DateTimeFormat;
        s_dateTimeFormatStrings =
        [
            s_dateFormats.ShortDatePattern,
            s_dateFormats.LongDatePattern,
            s_dateFormats.ShortDatePattern,
            s_dateFormats.LongDatePattern,
            s_dateFormats.SortableDateTimePattern,
            s_dateFormats.UniversalSortableDateTimePattern,
            s_dateFormats.RFC1123Pattern,
            s_dateFormats.ShortDatePattern + " " +
            s_dateFormats.ShortTimePattern
        ];
    }

    public class DateFormatter : TypedFormatter<DateTime>
    {
        [DefaultValue(DateTimeFormats.ShortDate)]
        public DateTimeFormats DateTimeFormat { get; set; } = DateTimeFormats.ShortDate;

        public override Task<string?> ConvertToDisplayAsync(DateTime value)
        { 
            string? returnValue = value.ToString(GetFormatString());
            return Task.FromResult<string?>(returnValue);
        }

        public override Task<DateTime> ConvertToValueAsync(string? stringValue) 
            => Task.FromResult(
                string.IsNullOrEmpty(stringValue)
                    ? DateTime.Now
                    : DateTime.Parse(stringValue));

        public override Task<string?> InitializeEditedValueAsync(DateTime value) 
            => Task.FromResult<string?>(value.ToString());

        public string GetFormatString() 
            => s_dateTimeFormatStrings[(int)DateTimeFormat];
    }
}
