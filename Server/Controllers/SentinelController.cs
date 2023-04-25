using ISIvanti.Server.Interfaces;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Sentinel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ISIvanti.Server.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class SentinelController : ControllerBase
{
    private readonly ISentinelService _sentinelService;

    public SentinelController(ISentinelService sentinelService)
    {
        _sentinelService = sentinelService;
    }

    [HttpPost]
    public async Task<ActionResult<SentinelDto>> PostPaginationAsync([FromBody] PaginationDto pagination)
    {
        return Accepted(await _sentinelService.PaginationAsync(pagination));
    }

    [HttpGet("Statistics")]
    public async Task<ActionResult<IvantiStatisticsDto>> GetStatistics()
    {
        return Accepted(await _sentinelService.GetStatistics());
    }
}
