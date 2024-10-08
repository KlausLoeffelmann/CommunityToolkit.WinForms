﻿namespace DemoToolkit.Mvvm.WinForms.Components;

/// <summary>
///  Provides data for the engage event of the <see cref="AsyncTimerComponent"/>.
/// </summary>
public class EngageEventArgs : EventArgs
{
    /// <summary>
    ///  Initializes a new instance of the <see cref="EngageEventArgs"/> class.
    /// </summary>
    /// <param name="timer">The periodic timer associated with the engage event.</param>
    public EngageEventArgs(CancellationToken cancellationToken)
    {
        CancellationToken = cancellationToken;
    }

    public CancellationToken CancellationToken { get; }
}
