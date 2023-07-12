using ISIvanti.Client.Interfaces;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Proofpoint;
using ISIvanti.Shared.Utilities;
using RestEase;

namespace ISIvanti.Client.Services;

public class ProofpointService
{
#if DEBUG
    private const string ApiHost = "https://localhost:8123/api";
#else
    private const string ApiHost = "https://isipatch.idealstandard.com:8123/api";
#endif

    private readonly IProofpointService _api;

    public ProofpointService()
    {
        _api = RestClient.For<IProofpointService>(ApiHost);
    }

    public async Task<List<ProofpointContextDto>?> GetProofpointIsolatedUrlsAsync()
    {
        try
        {
            var response = await _api.GetProofpointIsolatedUrlsAsync();
            if (!response.IsSuccessStatusCode) return null;
            return await response.DeserializeHttpResponseContentAsync<List<ProofpointContextDto>>();
        }
        catch (ApiException e)
        {
            Console.WriteLine($"API->Failed to get statistics: {e.Message}");
        }

        return null;
    }
}
