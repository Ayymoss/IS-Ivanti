using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Sentinel;

namespace ISIvanti.Server.Interfaces;

public interface ISentinelService
{
    Task<SentinelDto> PaginationAsync(PaginationDto pagination);
    Task<SentinelStatisticsDto> GetStatistics();
}
