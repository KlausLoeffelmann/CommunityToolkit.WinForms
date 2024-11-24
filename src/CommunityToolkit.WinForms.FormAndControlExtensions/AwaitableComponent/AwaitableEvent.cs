using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CommunityToolkit.WinForms.Extensions.Async;

/// <summary>
/// Represents an awaitable event that can be used with the await keyword.
/// </summary>
/// <typeparam name="T">The type of the event arguments.</typeparam>
public class AwaitableEvent<T> : IAwaitableComponent
    where T : EventArgs?
{
    // TaskCompletionSource, providing a task that completes when the ToolStripMenuItem is clicked.
    private TaskCompletionSource<(IComponent sender, T eArgs)>? _eventCompletion;
    private readonly Action<object?, T> _eventAction;

    /// <summary>
    /// Initializes a new instance of the <see cref="AwaitableEvent{T}"/> class.
    /// </summary>
    public AwaitableEvent()
    {
        _eventAction = (object? sender, T eArgs) =>
        {
            EventCompletion.TrySetResult(((IComponent)sender!, eArgs));
        };
    }

    /// <summary>
    /// Gets the task completion source for the event.
    /// </summary>
    private TaskCompletionSource<(IComponent sender, T eArgs)> EventCompletion
        => _eventCompletion ??= new TaskCompletionSource<(IComponent, T)>();

    /// <summary>
    /// Gets the action to be executed when the event is raised.
    /// </summary>
    public Action<object?, T> EventAction => _eventAction;

    /// <summary>
    /// Gets the sender of the event.
    /// </summary>
    public IComponent Sender => EventCompletion.Task.Result.sender;

    /// <summary>
    /// Gets the event arguments.
    /// </summary>
    public T EArgs => EventCompletion.Task.Result.eArgs;

    /// <summary>
    /// Gets the awaiter for the component.
    /// </summary>
    /// <returns>An object that implements the <see cref="INotifyCompletion"/> interface.</returns>
    INotifyCompletion IAwaitableComponent.GetAwaiter()
    {
        _eventCompletion = new TaskCompletionSource<(IComponent sender, T eArgs)>();
        return EventCompletion.Task.GetAwaiter();
    }
}
