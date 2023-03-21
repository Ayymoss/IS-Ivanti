using System.Collections.Concurrent;
using ISIvanti.Server.Interfaces;

namespace ISIvanti.Server.Services;

public class BackgroundTaskQueue : IBackgroundTaskQueue
{
    private ConcurrentQueue<Func<CancellationToken, ValueTask>> _workItems = new();
    private SemaphoreSlim _signal = new(0);

    public void QueueBackgroundWorkItem(Func<CancellationToken, ValueTask> workItem)
    {
        if (workItem == null)
            throw new ArgumentNullException(nameof(workItem));

        _workItems.Enqueue(workItem);
        _signal.Release();
    }

    public async Task<Func<CancellationToken, ValueTask>> DequeueAsync(CancellationToken cancellationToken)
    {
        await _signal.WaitAsync(cancellationToken);
        cancellationToken.ThrowIfCancellationRequested();

        _workItems.TryDequeue(out var workItem);

        return workItem;
    }
}
