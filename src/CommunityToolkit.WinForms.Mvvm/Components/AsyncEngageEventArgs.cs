namespace DemoToolkit.Mvvm.WinForms.Components;

/// <summary>
///  Provides data for the engage event of the <see cref="AsyncTimerComponent"/>.
/// </summary>
public class AsyncEngageEventArgs : EventArgs
{
    /// <summary>
    ///  Initializes a new instance of the <see cref="AsyncEngageEventArgs"/> class.
    /// </summary>
    /// <param name="timer">The periodic timer associated with the engage event.</param>
    public AsyncEngageEventArgs(CancellationToken cancellationToken)
    {
        CancellationToken = cancellationToken;
    }

    public CancellationToken CancellationToken { get; }
}
