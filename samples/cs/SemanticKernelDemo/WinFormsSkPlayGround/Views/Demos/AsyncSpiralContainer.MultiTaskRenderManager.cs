namespace WinFormsSkPlayGround.Views;

public partial class AsyncSpiralContainer
{
    private class MultiTaskRenderManager : IDisposable
    {
        private readonly Task[] _tasks;
        private CancellationTokenSource? _cts;
        private readonly int _taskCount;
        private bool disposedValue;

        public static MultiTaskRenderManager GetInstance(int taskCount) => new(taskCount);

        private MultiTaskRenderManager(int taskCount)
        {
            if (taskCount < 2)
            {
                throw new InvalidOperationException($"{nameof(taskCount)} cannot be smaller than 2!");
            }

            _taskCount = taskCount;
            _tasks = new Task[taskCount];
        }

        public int TaskCount => _tasks.Length;

        public Task WaitAllFinishedAsync() => Task.WhenAll(_tasks);

        public void CreateTaskForEach(Func<CancellationToken, Task> taskAction)
        {
            CancelAndClearTasks();

            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            for (int i = 0; i < _taskCount; i++)
            {
                var actionTask = taskAction.Invoke(token);

                if (actionTask is null || actionTask.Status == TaskStatus.Created)
                {
                    throw new InvalidOperationException("Requested Task needs to be running!");
                }

                _tasks[i] = actionTask;
            }
        }

        private void CancelAndClearTasks()
        {
            _cts?.Cancel();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    CancelAndClearTasks();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
