using RestEase;

namespace ISIvanti.Server.Interfaces.Ivanti;

public interface IIvantiApi
{
    [Get("/configuration/version")]
    Task<HttpResponseMessage> GetVersionAsync();

    [Post("/agenttasks/{AgentId}/tasks/{TaskId}")]
    Task<HttpResponseMessage> PostExecutePolicyAsync([Path("AgentId")] string agentId, [Path("TaskId")] string taskId);

    [Post("/agenttasks/{AgentId}/checkin")]
    Task<HttpResponseMessage> PostExecuteCheckInAsync([Path("AgentId")] string agentId);
}
