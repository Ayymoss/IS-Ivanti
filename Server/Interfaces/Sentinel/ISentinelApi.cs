using RestEase;

namespace ISIvanti.Server.Interfaces.Sentinel;

public interface ISentinelApi
{
    [Header("Authorization")] string Authorization { get; set; }

    [Get("/web/api/v2.1/agents")]
    Task<HttpResponseMessage> GetActionRequiredComputers([Query("limit")] int limit, [Query("skip")] int skip,
        [Query("sortBy")] string sortBy, [Query("sortOrder")] string sortOrder, [Query("query")] string query,
        [Query("userActionsNeeded")] string userActionsNeeded);
}
