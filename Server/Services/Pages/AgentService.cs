using ISIvanti.Server.Context;
using ISIvanti.Server.Interfaces;
using ISIvanti.Server.Models.IvantiModels;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Ivanti;
using ISIvanti.Shared.Enums;
using Microsoft.EntityFrameworkCore;
using MudBlazor;

namespace ISIvanti.Server.Services.Pages;

public class AgentService : IAgentService
{
    private readonly IvantiDataContext _ivantiContext;

    public AgentService(IvantiDataContext ivantiContext)
    {
        _ivantiContext = ivantiContext;
    }

    public async Task<int> AgentsCountAsync() => await _ivantiContext.ManagedMachines.CountAsync();

    public async Task<List<AgentDto>> PaginationAsync(PaginationDto pagination)
    {
        var query = _ivantiContext.ManagedMachines.GroupJoin(_ivantiContext.XtrCurrentPatchCounts,
            machine => machine.MmKey,
            patch => patch.Machineid,
            (machine, patches) => new AgentDto
            {
                MachineId = machine.MmKey,
                MachineName = machine.Name,
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
                EF.Functions.Like(search.MachineName, $"%{pagination.SearchString}%") ||
                EF.Functions.Like(search.AssignedGroup ?? "unknown", $"%{pagination.SearchString}%"));
        }

        query = pagination.SortLabel switch
        {
            "Id" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.MachineId),
            "Name" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.MachineName),
            "Group" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.AssignedGroup),
            "LastUpdated" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.LastUpdated),
            "Percentage" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.PatchesInstalledPercentage),
            _ => query
        };

        var machineData = await query
            .Skip(pagination.Page!.Value * pagination.PageSize!.Value)
            .Take(pagination.PageSize.Value)
            .ToListAsync();

        return machineData;
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
}
