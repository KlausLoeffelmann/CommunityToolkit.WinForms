using System.ComponentModel;
using System.Globalization;

namespace CommunityToolkit.WinForms.TypedInputExtenders;

public partial class IntelStringFormatterComponent
{
    public class IntelStringFormatter : TypedFormatter<string?>
    {
        public override Task<string?> ConvertToDisplayAsync(string? value) 
            => Task.FromResult<string?>(value);

        public override Task<string?> ConvertToValueAsync(string? stringValue)
            => Task.FromResult(stringValue);

        public override Task<string?> InitializeEditedValueAsync(string? value) 
            => Task.FromResult<string?>(value);

        public string GetFormatString() 
            => string.Empty;
    }
}
