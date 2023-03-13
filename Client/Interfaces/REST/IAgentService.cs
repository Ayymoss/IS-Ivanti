using ISIvanti.Shared.Dtos;
using RestEase;

namespace ISIvanti.Client.Interfaces.REST;

public interface IAgentService
{
    [Get("/Agent")]
    Task<HttpResponseMessage> GetAgentCountAsync();
    
    [Get("/Agent")]
    Task<HttpResponseMessage> GetPoliciesAsync([Query("machineId")] int machineId);

    [Post("/Agent")]
    Task<HttpResponseMessage> GetAgentPaginationAsync([Body] PaginationDto pagination);

    [Post("/Agent/ExecutePolicy")]
    Task<HttpResponseMessage> PostExecutePolicyAsync([Body] ActionDto action);
    
    [Post("/Agent/CheckIn")]
    Task<HttpResponseMessage> PostExecuteCheckInAsync([Body] ActionDto action);
}
