using ISIvanti.Client.Interfaces;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Sentinel;
using ISIvanti.Shared.Utilities;
using RestEase;

namespace ISIvanti.Client.Services;

public class SentinelService
{
#if DEBUG
    private const string ApiHost = "https://localhost:8123/api";
#else
    private const string ApiHost = "https://isipatch.idealstandard.com:8123/api";
#endif

    private readonly ISentinelService _api;

    public SentinelService()
    {
        _api = RestClient.For<ISentinelService>(ApiHost);
    }
    
    public async Task<SentinelDto> PostPagination(PaginationDto pagination)
    {
        try
        {
            var response = await _api.PostPaginationAsync(pagination);
            var result = await response.DeserializeHttpResponseContentAsync<SentinelDto>();
            return result ?? new SentinelDto();
        }
        catch (ApiException e)
        {
            Console.WriteLine($"API->Failed to get job pagination: {e.Message}");
        }

        return new SentinelDto();
    }

    public async Task<SentinelStatisticsDto?> GetStatistics()
    {
        try
        {
            var response = await _api.GetStatistics();
            if (!response.IsSuccessStatusCode) return null;
            return await response.DeserializeHttpResponseContentAsync<SentinelStatisticsDto>();
        }
        catch (ApiException e)
        {
            Console.WriteLine($"API->Failed to get statistics: {e.Message}");
        }

        return null;
    }
}
