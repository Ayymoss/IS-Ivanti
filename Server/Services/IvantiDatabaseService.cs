using ISIvanti.Server.Context;
using ISIvanti.Server.Dtos;
using ISIvanti.Server.Interfaces;
using Microsoft.EntityFrameworkCore;
using MudBlazor;

namespace ISIvanti.Server.Services;

public class IvantiDatabaseService : IIvantiDatabaseService
{
    private readonly IvantiDataContext _ivantiContext;

    public IvantiDatabaseService(IvantiDataContext ivantiContext)
    {
        _ivantiContext = ivantiContext;
    }

    public async Task<int> AgentsCount() => await _ivantiContext.ManagedMachines.CountAsync();

    public async Task<List<AgentNewDto>> PaginationAsync(PaginationDto pagination)
    {
        var query = _ivantiContext.ManagedMachines.AsQueryable();

        if (!string.IsNullOrWhiteSpace(pagination.SearchString))
        {
            query = query.Where(search =>
                EF.Functions.Like(search.Name, $"%{pagination.SearchString}%") ||
                EF.Functions.Like(search.AssignedGroup ?? "unknown", $"%{pagination.SearchString}%"));
        }

        query = pagination.SortLabel switch
        {
            "Id" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.MmKey),
            "Name" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.Name),
            "AssignedGroup" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.AssignedGroup),
            "LastUpdated" => query.OrderByDirection((SortDirection)pagination.SortDirection!, entity => entity.LastUpdated),
            _ => query
        };

        var machineData = await query
            .Skip(pagination.Page!.Value * pagination.PageSize!.Value)
            .Take(pagination.PageSize.Value)
            .Select(profile => new AgentNewDto
            {
                MachineId = profile.MmKey,
                MachineName = profile.Name,
                AssignedGroup = profile.AssignedGroup,
                LastUpdated = profile.LastUpdated
            }).ToListAsync();

        var machineIds = machineData.Select(comp => comp.MachineId).ToList();

        var pageData = await _ivantiContext.XtrCurrentPatchCounts
            .Where(patch => machineIds.Contains(patch.Machineid.Value))
            .ToListAsync();

        foreach (var machine in machineData)
        {
            foreach (var patch in pageData.Where(patch => machine.MachineId == patch.Machineid))
            {
                if (patch.Installedcnt.HasValue)
                {
                    machine.PatchesInstalled += patch.Installedcnt.Value;
                }

                if (patch.Notinstalledcnt.HasValue)
                {
                    machine.PatchesMissing += patch.Notinstalledcnt.Value;
                }
            }

            if (machine.PatchesMissing == 0)
            {
                machine.PatchesInstalledPercentage = 100;
            }
            else
            {
                machine.PatchesInstalledPercentage =
                    (float)machine.PatchesInstalled / (machine.PatchesInstalled + machine.PatchesMissing) * 100;
            }
        }

        return machineData;
    }
}
