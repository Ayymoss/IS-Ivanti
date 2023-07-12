using ISIvanti.Server.Interfaces;
using ISIvanti.Server.Services.Proofpoint;
using ISIvanti.Shared.Dtos.Proofpoint;

namespace ISIvanti.Server.Services;

public class ProofpointService : IProofpointService
{
    private readonly ProofpointApi _proofpointApi;

    public ProofpointService(ProofpointApi proofpointApi)
    {
        _proofpointApi = proofpointApi;
    }

    public async Task<List<ProofpointContextDto>?> GetProofpointIsolatedUrlsAsync()
    {
        var result = await _proofpointApi.GetProofpointIsolatedUrlsAsync();
        return result?.Data.OrderByDescending(x => x.Date).ToList();
    }
}
