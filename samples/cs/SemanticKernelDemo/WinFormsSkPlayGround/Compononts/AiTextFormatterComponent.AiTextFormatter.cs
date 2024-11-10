using CommunityToolkit.WinForms.TypedInputExtenders;

namespace WinFormsSkPlayGround.Components;

public partial class AiTextFormatterComponent
{
    public class AiTextFormatter : TypedFormatter<string?>
    {
        public override Task<string?> ConvertToDisplayAsync(string? value, CancellationToken token) 
            => Task.FromResult<string?>(value);

        public override Task<string?> ConvertToValueAsync(string? stringValue, CancellationToken token)
            => Task.FromResult(stringValue);

        public override Task<string?> InitializeEditedValueAsync(string? value, CancellationToken token) 
            => Task.FromResult<string?>(value);

        public string GetFormatString() 
            => string.Empty;
    }
}
