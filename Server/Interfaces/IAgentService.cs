using ISIvanti.Server.Models.IvantiModels;
using ISIvanti.Server.Services.Ivanti;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Ivanti;

namespace ISIvanti.Server.Interfaces;

public interface IAgentService
{
    Task<AgentContextDto> AgentPaginationAsync(PaginationDto pagination);
    Task<List<AgentPolicyDto>?> GetPoliciesAsync(int machineId);
    Task<Guid?> SetupExecuteJob(ActionDto action, IvantiApi api, string adminName);
    Task<JobContextDto> JobPaginationAsync(PaginationDto pagination);
    Task<Agent?> GetAgentIdAsync(int machineId);
    Task<List<string?>> GetAgentGroups();
    Task<IvantiStatisticsDto?> GetStatistics(string userName);
}
