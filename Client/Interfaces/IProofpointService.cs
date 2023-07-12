using RestEase;

namespace ISIvanti.Client.Interfaces;

public interface IProofpointService
{
    [Get("/Proofpoint")]
    Task<HttpResponseMessage> GetProofpointIsolatedUrlsAsync();
}
