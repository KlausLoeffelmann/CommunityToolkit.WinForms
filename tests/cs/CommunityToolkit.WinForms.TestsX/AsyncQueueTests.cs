using CommunityToolkit.WinForms.AsyncSupport;
using System.Diagnostics;

namespace CommunityToolkit.WinForms.TestsX;

public class AsyncQueueTests
{
    [Fact]
    public void SimpleSyncCommandQueueTestAsync()
    {
        var queue = new AsyncTaskQueue();
        queue.Enqueue(task);
        queue.Dispose();

        // Simplest local Func<Task> to enqueue.
        static Task task() => Task.CompletedTask;
    }

    [Fact]
    public void MultipleSimpleSyncCommandQueueTest()
    {
        int count = 0;

        var queue = new AsyncTaskQueue(1000);
        for (int i = 0; i < 1000; i++)
        {
            queue.Enqueue(task);
        }

        // Simplest local Func<Task> to enqueue.
        Task task()
        {
            count++;
            return Task.CompletedTask;
        }
    }
}
