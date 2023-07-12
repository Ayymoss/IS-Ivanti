using ISIvanti.Server.Interfaces.Proofpoint;
using ISIvanti.Server.Utilities;
using ISIvanti.Shared.Dtos.Proofpoint;
using ISIvanti.Shared.Utilities;
using RestEase;

namespace ISIvanti.Server.Services.Proofpoint;


public class ProofpointApi
{
    private readonly Configuration _config;
    private readonly ILogger<ProofpointApi> _logger;
    private readonly IProofpointApi _api;

    public ProofpointApi(Configuration config, ILogger<ProofpointApi> logger)
    {
        _config = config;
        _logger = logger;
        _api = RestClient.For<IProofpointApi>(config.ProofpointApiHost);
    }

    public async Task<ProofpointDto?> GetProofpointIsolatedUrlsAsync()
    {
        ProofpointDto? data = null;
        try
        {
            var apiKey = _config.ProofpointApi;
            var from = DateTime.Now.AddMonths(-2).ToString("yyyy-MM-dd");
            var to = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
            var result = await _api.GetProofpointIsolatedUrlsAsync(apiKey, from, to);
            if (!result.IsSuccessStatusCode) return null;
            data = await result.DeserializeHttpResponseContentAsync<ProofpointDto>();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "GetActionRequiredComputers failed");
        }

        return data;
    }
}
