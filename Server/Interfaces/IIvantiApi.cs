using RestEase;

namespace ISIvanti.Server.Interfaces;

public interface IIvantiApi
{
    [Get("/configuration/version")]
    Task<HttpResponseMessage> GetVersionAsync();

    [Get("/machines")]
    Task<HttpResponseMessage> GetMachinesAsync([Query("count")] int count, [Query("start")] int page, [Query("name")] string nameSearch);

    [Get("/agents")]
    Task<HttpResponseMessage> GetAgentsAsync([Query("count")] int count, [Query("start")] int page, [Query("name")] string nameSearch);

    [Get("/agenttasks/{AgentId}/tasks")]
    Task<HttpResponseMessage> GetPoliciesAsync([Path("AgentId")] string agentId);

    [Post("/agenttasks/{AgentId}/tasks/{TaskId}")]
    Task<HttpResponseMessage> PostExecutePolicyAsync([Path("AgentId")] string agentId, [Path("TaskId")] string taskId);

    [Post("/agenttasks/{AgentId}/checkin")]
    Task<HttpResponseMessage> PostExecuteCheckInAsync([Path("AgentId")] string agentId);
}
