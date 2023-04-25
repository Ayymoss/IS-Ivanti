using ISIvanti.Shared.Dtos;
using RestEase;

namespace ISIvanti.Client.Interfaces;

public interface IAgentService
{
    [Get("/Agent")]
    Task<HttpResponseMessage> GetAgentCountAsync();

    [Get("/Agent/Policies")]
    Task<HttpResponseMessage> GetPoliciesAsync([Query("machineId")] int machineId);

    [Post("/Agent")]
    Task<HttpResponseMessage> PostAgentPaginationAsync([Body] PaginationDto pagination);

    [Post("/Agent/ExecuteJob")]
    Task<HttpResponseMessage> PostExecuteJobAsync([Body] ActionDto action);

    [Post("/Agent/Jobs")]
    Task<HttpResponseMessage> PostJobPaginationAsync([Body] PaginationDto pagination);

    [Post("/Agent/ExecuteJobs")]
    Task<HttpResponseMessage> PostExecuteJobsAsync([Body] List<ActionDto> actions);

    [Get("/Agent/PolicyGroups")]
    Task<HttpResponseMessage> GetAgentGroups();

    [Get("/Agent/Statistics")]
    Task<HttpResponseMessage> GetStatistics();
}
