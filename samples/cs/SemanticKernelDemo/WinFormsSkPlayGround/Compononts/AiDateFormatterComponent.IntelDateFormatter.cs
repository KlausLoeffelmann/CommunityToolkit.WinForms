﻿using CommunityToolkit.WinForms.TypedInputExtenders;
using System.ComponentModel;
using System.Globalization;

namespace WinFormsSkPlayGround.Components;

public partial class AiDateFormatterComponent
{
    private static readonly DateTimeFormatInfo s_dateFormats;
    private static readonly string[] s_dateTimeFormatStrings;

    static AiDateFormatterComponent()
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

        public override Task<string?> ConvertToDisplayAsync(DateTime value, CancellationToken token)
        { 
            string? returnValue = value.ToString(GetFormatString());
            return Task.FromResult<string?>(returnValue);
        }

        public override Task<DateTime> ConvertToValueAsync(string? stringValue, CancellationToken token) 
            => Task.FromResult(
                string.IsNullOrEmpty(stringValue)
                    ? DateTime.Now
                    : DateTime.Parse(stringValue));

        public override Task<string?> InitializeEditedValueAsync(DateTime value, CancellationToken token) 
            => Task.FromResult<string?>(value.ToString());

        public string GetFormatString() 
            => s_dateTimeFormatStrings[(int)DateTimeFormat];
    }
}