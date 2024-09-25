using System.Collections.Concurrent;

namespace CommunityToolkit.WinForms.Controls;

internal class AsyncTaskQueue : IDisposable
{
    private readonly ConcurrentQueue<Func<Task>> _taskQueue = new();
    private readonly SemaphoreSlim _signal = new(0);
    private readonly CancellationTokenSource _cts = new();
    private readonly Task _processingTask;

    public AsyncTaskQueue()
    {
        _processingTask = Task.Run(ProcessQueueAsync);
    }

    private async Task ProcessQueueAsync()
    {
        while (!_cts.Token.IsCancellationRequested)
        {
            await _signal.WaitAsync(_cts.Token);

            if (_cts.Token.IsCancellationRequested)
                break;

            while (_taskQueue.TryDequeue(out var workItem))
            {
                try
                {
                    await workItem();
                }
                catch (Exception ex)
                {
                    // Handle exceptions as needed
                    Console.WriteLine($"Task error: {ex.Message}");
                }
            }
        }
    }

    public void Enqueue(Func<Task> asyncMethod)
    {
        _taskQueue.Enqueue(asyncMethod);
        _signal.Release();
    }

    public Task EnqueueAsync(Func<Task> asyncMethod)
    {
        _taskQueue.Enqueue(asyncMethod);
        _signal.Release();

        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _cts.Cancel();
        _signal.Release();
        _processingTask.Wait();
        _cts.Dispose();
        _signal.Dispose();
    }
}
