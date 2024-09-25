namespace CommunityToolkit.WinForms.Extensions;

public class DialogResult<T>(T? result, DialogResult formDialogResult)
{
    public T? Result { get; } = result;

    public DialogResult FormDialogResult { get; } = formDialogResult;
}
