using System.Runtime.CompilerServices;

namespace CommunityToolkit.WinForms.Extensions.Async;

/// <summary>
/// Represents a form that can be awaited asynchronously.
/// </summary>
public class AwaitableForm(Form form) : IAwaitableComponent
{
    /// <summary>
    /// Gets the awaiter for the form, allowing it to be awaited.
    /// </summary>
    /// <returns>An object that implements the <see cref="INotifyCompletion"/> interface.</returns>
    INotifyCompletion IAwaitableComponent.GetAwaiter()
        => form.ShowAsync().GetAwaiter();

    /// <summary>
    /// Gets the underlying form.
    /// </summary>
    public Form Form => form;
}
