using ISIvanti.Server.Dtos;

namespace ISIvanti.Server.Interfaces;

public interface IIvantiDatabaseService
{
    Task<int> AgentsCount();
    Task<List<AgentNewDto>> PaginationAsync(PaginationDto pagination);
}
