using System.ComponentModel;

namespace CommunityToolkit.WinForms.EntryFormatter;

public interface IDataEntryFormatterComponent : IComponent, ISupportInitialize
{
    event EventHandler NotifyEndInit;

    Task<bool> TryConvertToValueAsync(TextBox textBox, string? stringValue);

    Task<string?> ConvertToDisplayAsync(TextBox textBox);

    Task<string?> InitializeEditedValueAsync(TextBox textBox);

    object? GetValue(TextBox textBox);

    void SetValue(TextBox textBox, object? value);

    object? GetDefaultValue();
}
