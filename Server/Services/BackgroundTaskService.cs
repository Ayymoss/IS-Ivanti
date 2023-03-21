using ISIvanti.Server.Interfaces;

namespace ISIvanti.Server.Services;

public class BackgroundTaskService : BackgroundService
{
    private readonly IBackgroundTaskQueue _taskQueue;
    private readonly IServiceScopeFactory _serviceScopeFactory;

    public BackgroundTaskService(IBackgroundTaskQueue taskQueue, IServiceScopeFactory serviceScopeFactory)
    {
        _taskQueue = taskQueue;
        _serviceScopeFactory = serviceScopeFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var workItem = await _taskQueue.DequeueAsync(stoppingToken);

            try
            {
                await workItem(stoppingToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred executing background task: {0}", ex);
            }

            await Task.Delay(100, stoppingToken);
        }
    }
}
