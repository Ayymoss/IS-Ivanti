using ISIvanti.Server.Interfaces;
using ISIvanti.Server.Services.Sentinel;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Sentinel;
using MudBlazor;

namespace ISIvanti.Server.Services;

public class SentinelService : ISentinelService
{
    private readonly SentinelApi _sentinelApi;

    public SentinelService(SentinelApi sentinelApi)
    {
        _sentinelApi = sentinelApi;
    }

    public async Task<SentinelDto> PaginationAsync(PaginationDto pagination)
    {
        var limit = pagination.PageSize ?? 0;
        var skip = pagination.PageSize * pagination.Page ?? 0;
        var sortBy = pagination.SortLabel ?? "computerName";
        var sortOrder = (SortDirection)pagination.SortDirection is SortDirection.Ascending ? "asc" : "desc";
        var query = pagination.SearchString;
        const string userActionsNeeded =
            "reboot_needed,agent_suppressed_category,extended_exclusions_partially_accepted,incompatible_os,incompatible_os_category," +
            "missing_permissions_category,reboot_category,rebootless_without_dynamic_detection,unprotected,unprotected_category," +
            "upgrade_needed,user_action_needed,user_action_needed_bluetooth_per,user_action_needed_fda,user_action_needed_network," +
            "user_action_needed_rs_fda";

        var result = await _sentinelApi.GetActionRequiredComputers(limit, skip, sortBy, sortOrder, query, userActionsNeeded);
        return result;
    }

    public async Task<SentinelStatisticsDto> GetStatistics()
    {
        var pagination = new PaginationDto
        {
            Page = 0,
            PageSize = 1,
            SortLabel = "computerName",
            SortDirection = (int)SortDirection.Descending,
            SearchString = string.Empty
        };
        var result = await PaginationAsync(pagination);
        var statistics = new SentinelStatisticsDto
        {
            ActionRequiredCount = result.Pagination?.TotalItems ?? 0
        };

        return statistics;
    }
}
