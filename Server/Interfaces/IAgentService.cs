using ISIvanti.Server.Dtos;
using ISIvanti.Server.Models.IvantiModels;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Ivanti;

namespace ISIvanti.Server.Interfaces;

public interface IAgentService
{
    Task<int> AgentsCountAsync();
    Task<AgentContextDto> PaginationAsync(PaginationDto pagination);
    Task<List<AgentPolicyDto>?> GetPoliciesAsync(int machineId);
    Task<Agent> GetAgentIdAsync(int MachineId);
}
