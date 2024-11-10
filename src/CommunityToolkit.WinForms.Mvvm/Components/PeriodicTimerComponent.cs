using System.ComponentModel;
using System.Windows.Input;

namespace DemoToolkit.Mvvm.WinForms.Components;

public delegate Task AsyncEventHandler<TEventArgs>(object sender, TEventArgs e);

/// <summary>
///  Represents a component that provides asynchronous periodic timer functionality.
/// </summary>
public class PeriodicTimerComponent : BindableComponent
{
    private PeriodicTimer? _timer;
    private CancellationTokenSource? _cancellationTokenSource;
    private SynchronizationContext _syncContext = SynchronizationContext.Current!;

    private ICommand? _elapsedCommand;

    /// <summary>
    ///  Occurs when the timer engages.
    /// </summary>
    public event AsyncEventHandler<AsyncEngageEventArgs>? AsyncEngage;
    public event EventHandler? ElapsedCommandChanged;

    /// <summary>
    ///  Initializes a new instance of the <see cref="AsyncTimerComponent"/> class.
    /// </summary>
    public PeriodicTimerComponent()
    {
    }

    /// <summary>
    ///  Gets or sets the interval in milliseconds between timer ticks.
    /// </summary>
    [DefaultValue(500)]
    public int IntervalMs { get; set; } = 200;

    [Browsable(false)]
    [Bindable(true)]
    public bool IsRunning
    {
        get => _timer != null;
        set
        {
            if (value == IsRunning)
            {
                return;
            }

            if (!value)
            {
                SignalCancellation();
            }
            else
            {
                _ = StartAsync();
            }
        }
    }

    /// <summary>
    ///  Starts the timer asynchronously.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token to stop the timer.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task StartAsync(CancellationToken cancellationToken = default)
    {
        if (cancellationToken == default)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = _cancellationTokenSource.Token;
        }

        if (_timer != null)
        {
            _timer.Dispose();
        }

        _timer = new PeriodicTimer(TimeSpan.FromMilliseconds(IntervalMs));

        try
        {
            while (await _timer.WaitForNextTickAsync(cancellationToken).ConfigureAwait(false))
            {
                if (AsyncEngage != null)
                {
                    await AsyncEngage(this, new AsyncEngageEventArgs(cancellationToken));
                }

                // Execute the command on the main thread:
                if (_elapsedCommand is not null
                    && _elapsedCommand.CanExecute(ElapsedCommandParameter))
                {
                    _syncContext?.Post(
                        d: _ => _elapsedCommand.Execute(ElapsedCommandParameter),
                        state: null);
                }
            }
        }
        catch(OperationCanceledException)
        {
        }
        catch(Exception ex)
        {
            Application.OnThreadException(ex);
        }
        finally
        {
            if (_timer != null)
            {
                _timer.Dispose();
                _timer = null;
            }
        }
    }

    public void SignalCancellation()
    {
        if (_cancellationTokenSource != null)
        {
            _cancellationTokenSource.Cancel();
            return;
        }

        throw new InvalidOperationException("No implicit cancellation token source available.");
    }

    [Bindable(true)]
    [Browsable(false)]
    [Category("Behavior")]
    [Description("Gets or sets the command to execute when the timer elapses.")]
    [DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden)]

    public ICommand? ElapsedCommand
    {
        get => _elapsedCommand;
        set
        {
            if (_elapsedCommand == value)
            {
                return;
            }

            _elapsedCommand = value;
            OnElapsedCommandChanged();
        }
    }

    [Bindable(true)]
    [Browsable(false)]
    [Category("Behavior")]
    [Description("Gets or sets the command to execute when the timer elapses.")]
    [DefaultValue(null)]

    public object? ElapsedCommandParameter { get; set; }

    protected virtual void OnElapsedCommandChanged()
        => ElapsedCommandChanged?.Invoke(this, EventArgs.Empty);
}
