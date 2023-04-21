using ISIvanti.Server.Interfaces.Sentinel;
using ISIvanti.Server.Utilities;
using ISIvanti.Shared.Dtos.Sentinel;
using ISIvanti.Shared.Utilities;
using RestEase;

namespace ISIvanti.Server.Services.Sentinel;

public class SentinelApi
{
    private readonly ILogger<SentinelApi> _logger;
    private readonly ISentinelApi _api;

    public SentinelApi(Configuration config, ILogger<SentinelApi> logger)
    {
        _logger = logger;
        _api = RestClient.For<ISentinelApi>(config.SentinelApiHost);
        _api.Authorization = $"ApiToken {config.SentinelApi}";
    }

    public async Task<SentinelDto> GetActionRequiredComputers(int limit, int skip, string sortBy, string sortOrder, string query,
        string userActionNeeded)
    {
        SentinelDto? data = null;
        try
        {
            var result = await _api.GetActionRequiredComputers(limit, skip, sortBy, sortOrder, query, userActionNeeded);
            data = await result.DeserializeHttpResponseContentAsync<SentinelDto>();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "GetActionRequiredComputers failed");
        }

        return data;
    }
}
