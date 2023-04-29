using ISIvanti.Server.Context;
using ISIvanti.Server.Models.LocalModels;
using Microsoft.EntityFrameworkCore;

namespace ISIvanti.Server.Services;

public class StatisticsGatheringService : IHostedService
{
    private readonly IServiceScopeFactory _scopeFactory;
    private Timer? _timer;

    public StatisticsGatheringService(IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _timer = new Timer(ExecuteQuery, null, TimeSpan.Zero, TimeSpan.FromHours(1));
        return Task.CompletedTask;
    }

    private async void ExecuteQuery(object? state)
    {
        using var scope = _scopeFactory.CreateScope();
        var localContext = scope.ServiceProvider.GetRequiredService<LocalDataContext>();
        var ivantiContext = scope.ServiceProvider.GetRequiredService<IvantiDataContext>();
        try
        {
            var healthy = await ivantiContext.ManagedMachines
                .Where(machine => (machine.MachineMeasure.MissingPatches ?? 0) +
                                  (machine.MachineMeasure.MissingServicePacks ?? 0) + (machine.MachineMeasure.InstalledPatches ?? 0) == 0 ||
                                  (float)(machine.MachineMeasure.InstalledPatches ?? 0) * 100 /
                                  ((machine.MachineMeasure.MissingPatches ?? 0) + (machine.MachineMeasure.MissingServicePacks ?? 0) +
                                   (machine.MachineMeasure.InstalledPatches ?? 0)) >= 98)
                .CountAsync();

            var statistic = new EFStatistic
            {
                Submitted = DateTimeOffset.UtcNow,
                Type = "MachineHealth",
                Count = healthy
            };

            localContext.Statistics.Add(statistic);
            await localContext.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error during statistics gather: {e}");
        }
    }

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}
