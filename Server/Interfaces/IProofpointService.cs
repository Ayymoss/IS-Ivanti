using ISIvanti.Shared.Dtos.Proofpoint;

namespace ISIvanti.Server.Interfaces;

public interface IProofpointService
{
    Task<List<ProofpointContextDto>?> GetProofpointIsolatedUrlsAsync();
}
