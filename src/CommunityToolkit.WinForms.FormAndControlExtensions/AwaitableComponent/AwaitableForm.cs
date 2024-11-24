using System.Runtime.CompilerServices;

namespace CommunityToolkit.WinForms.Extensions.Async;

/// <summary>
///  Represents a form that can be awaited asynchronously.
/// </summary>
public class AwaitableForm(Form form) : IAwaitableComponent
{
    // TaskCompletionSource to signal the completion of the form's task
    private readonly TaskCompletionSource<IAwaitableComponent> _completion = new();

    /// <summary>
    ///  Gets the awaiter for the form, allowing it to be awaited.
    /// </summary>
    /// <returns>An object that implements the <see cref="INotifyCompletion"/> interface.</returns>
    INotifyCompletion IAwaitableComponent.GetAwaiter()
    {
        // Show the form asynchronously
        Task formTask = Form.ShowAsync();

        // Continue with the task to set the result, exception, or cancellation
        _ = formTask.ContinueWith((task) =>
        {
            _ = task switch
            {
                // If the task is completed successfully, set the result
                { IsCompleted: true } => _completion.TrySetResult(this),

                // If the task is faulted, set the exception
                { IsFaulted: true } => _completion.TrySetException(task.Exception!),

                // If the task is canceled, set the cancellation
                { IsCanceled: true } => _completion.TrySetCanceled(),

                // Throw an exception for any unexpected task state
                _ => throw new InvalidOperationException("Unexpected task state")
            };

        });

        // Return the awaiter for the completion task
        return _completion.Task.GetAwaiter();
    }

    /// <summary>
    ///  Gets the underlying form.
    /// </summary>
    public Form Form => form;
}
