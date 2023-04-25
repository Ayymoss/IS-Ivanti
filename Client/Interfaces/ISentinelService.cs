using ISIvanti.Shared.Dtos;
using RestEase;

namespace ISIvanti.Client.Interfaces;

public interface ISentinelService
{
    [Post("/Sentinel")]
    Task<HttpResponseMessage> PostPaginationAsync([Body] PaginationDto paginationDto);

    [Get("/Sentinel/Statistics")]
    Task<HttpResponseMessage> GetStatistics();
}
