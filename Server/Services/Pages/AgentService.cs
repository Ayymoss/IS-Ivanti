using ISIvanti.Server.Context;
using ISIvanti.Server.Interfaces;
using ISIvanti.Server.Models;
using ISIvanti.Server.Models.IvantiModels;
using ISIvanti.Server.Models.LocalModels;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Ivanti;
using ISIvanti.Shared.Enums;
using ISIvanti.Shared.Utilities;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
using Task = System.Threading.Tasks.Task;

namespace ISIvanti.Server.Services.Pages;

public class AgentService : IAgentService
{
    private readonly IvantiDataContext _ivantiContext;
    private readonly LocalDataContext _localContext;
    private readonly IBackgroundTaskQueue _taskQueue;
    private readonly IServiceScopeFactory _serviceScopeFactory;

    public AgentService(IvantiDataContext ivantiContext, LocalDataContext localContext, IBackgroundTaskQueue taskQueue, IServiceScopeFactory serviceScopeFactory)
    {
        _ivantiContext = ivantiContext;
        _localContext = localContext;
        _taskQueue = taskQueue;
        _serviceScopeFactory = serviceScopeFactory;
    }

    public async Task<AgentContextDto> AgentPaginationAsync(PaginationDto pagination)
    {
        var query = _ivantiContext.ManagedMachines
            .GroupJoin(_ivantiContext.XtrCurrentPatchCounts,
                machine => machine.MmKey,
                patch => patch.Machineid,
                (machine, patches) => new AgentDto
                {
                    MachineId = machine.MmKey,
                    MachineName = machine.Name,
                    ProductName = machine.MmOs.Spplprod.ProdName,
                    ProductVersion = machine.MmOs.Spplsp.SpName,
                    AssignedGroup = machine.AssignedGroup,
                    LastUpdated = machine.LastUpdated,
                    PatchesInstalled = patches.Sum(patch => patch.Installedcnt ?? 0),
                    PatchesMissing = patches.Sum(patch => patch.Notinstalledcnt ?? 0),
                    PatchesInstalledPercentage = patches.Any(patch => patch.Notinstalledcnt.HasValue && patch.Notinstalledcnt.Value > 0)
                        ? patches.Sum(patch => patch.Installedcnt ?? 0) / (float)(patches.Sum(patch => patch.Installedcnt ?? 0) +
                                                                                  patches.Sum(patch => patch.Notinstalledcnt ?? 0)) * 100
                        : 100
                });

        if (!string.IsNullOrWhiteSpace(pagination.SearchString))
        {
            query = query.Where(search =>
                EF.Functions.Like(search.MachineName ?? string.Empty, $"%{pagination.SearchString}%") ||
                EF.Functions.Like(search.ProductName ?? string.Empty, $"%{pagination.SearchString}%") ||
                EF.Functions.Like(search.ProductVersion ?? string.Empty, $"%{pagination.SearchString}%") ||
                EF.Functions.Like(search.AssignedGroup ?? string.Empty, $"%{pagination.SearchString}%"));
        }

        query = pagination.SortLabel switch
        {
            "Id" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.MachineId),
            "Name" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.MachineName),
            "Group" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.AssignedGroup),
            "LastUpdated" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.LastUpdated),
            "ProductName" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.ProductName),
            "ProductVersion" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.ProductVersion),
            "MissingPatches" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.PatchesMissing),
            "Percentage" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.PatchesInstalledPercentage),
            _ => query
        };

        var dataSize = await query.CountAsync();

        var machineData = await query
            .Skip(pagination.Page!.Value * pagination.PageSize!.Value)
            .Take(pagination.PageSize.Value)
            .ToListAsync();

        return new AgentContextDto
        {
            Count = dataSize,
            Agents = machineData
        };
    }

    public async Task<List<AgentPolicyDto>?> GetPoliciesAsync(int machineId)
    {
        var agent = await GetAgentIdAsync(machineId);
        if (agent is null) return null;

        var agentPolicy = await _ivantiContext.Policies
            .Where(x => x.Id == agent.AssignedPolicyId)
            .FirstOrDefaultAsync();
        if (agentPolicy is null) return null;

        var agentTasks = await _ivantiContext.Tasks
            .Where(x => x.PolicyId == agentPolicy.Id)
            .Select(x => new AgentPolicyDto
            {
                TaskId = x.Id,
                TaskName = x.Name,
                TaskType = (TaskType)x.Type
            }).ToListAsync();

        return agentTasks;
    }

    public async Task<Agent?> GetAgentIdAsync(int machineId)
    {
        var agent = await _ivantiContext.Agents
            .Where(x => x.MachineId == machineId)
            .FirstOrDefaultAsync();
        return agent;
    }

    public async Task<Guid?> SetupExecuteJob(ActionDto action, IvantiApi api, string adminName)
    {
        Guid? guid = null;
        try
        {
            var job = new EFJob
            {
                UserName = adminName,
                Guid = Guid.NewGuid(),
                TaskName = action.TaskName,
                State = State.Running,
                AgentName = action.AgentName,
                Created = DateTime.UtcNow,
            };
            _localContext.Jobs.Add(job);
            await _localContext.SaveChangesAsync();
            guid = job.Guid;
            
            var jobParam = new BackgroundJob
            {
                Job = job,
                Action = action,
                Api = api
            };
            _taskQueue.QueueBackgroundWorkItem(async cancellationToken =>
            {
                using var scope = _serviceScopeFactory.CreateScope();
                var jobBackgroundTask = scope.ServiceProvider.GetRequiredService<JobBackgroundTask>();
                await jobBackgroundTask.ExecuteAsync(jobParam);
            });
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return guid;
    }

    public async Task<JobContextDto> JobPaginationAsync(PaginationDto pagination)
    {
        var query = _localContext.Jobs.AsQueryable();

        if (!string.IsNullOrWhiteSpace(pagination.SearchString))
        {
            query = query.Where(search =>
                EF.Functions.Like(search.AgentName, $"%{pagination.SearchString}%") ||
                EF.Functions.Like(search.TaskName, $"%{pagination.SearchString}%") ||
                EF.Functions.Like(search.UserName, $"%{pagination.SearchString}%") ||
                EF.Functions.Like(search.Guid.ToString(), $"%{pagination.SearchString}%"));
        }

        query = pagination.SortLabel switch
        {
            "Id" => query.OrderByDirection((SortDirection)pagination.SortDirection!, key => key.Guid),
            "UserName" => query.OrderByDirection((SortDirection)pagination.SortDirection!, key => key.UserName),
            "Action" => query.OrderByDirection((SortDirection)pagination.SortDirection!, key => key.TaskName),
            "Target" => query.OrderByDirection((SortDirection)pagination.SortDirection!, key => key.AgentName),
            "Created" => query.OrderByDirection((SortDirection)pagination.SortDirection!, key => key.Created),
            "Completed" => query.OrderByDirection((SortDirection)pagination.SortDirection!, key => key.Completed),
            "State" => query.OrderByDirection((SortDirection)pagination.SortDirection!, key => key.State),
            _ => query
        };

        var dataSize = await query.CountAsync();

        var pagedData = await query
            .Skip(pagination.Page!.Value * pagination.PageSize!.Value)
            .Take(pagination.PageSize.Value)
            .Select(job => new JobDto
            {
                UserName = job.UserName,
                Guid = job.Guid,
                TaskName = job.TaskName,
                State = job.State,
                AgentName = job.AgentName,
                Created = job.Created,
                Completed = job.Completed
            }).ToListAsync();

        var context = new JobContextDto
        {
            Count = dataSize,
            Jobs = pagedData
        };

        return context;
    }
}
