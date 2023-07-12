using RestEase;

namespace ISIvanti.Server.Interfaces.Proofpoint;

public interface IProofpointApi
{
    [Get("/api/v2/reporting/usage-data")]
    Task<HttpResponseMessage> GetProofpointIsolatedUrlsAsync([Query("key")] string apiKey, [Query("from")] string from, [Query("to")] string to);
}
