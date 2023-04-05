using ISIvanti.Server.Interfaces;
using ISIvanti.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ISIvanti.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SystemController : ControllerBase
{
    private readonly ISystemService _systemService;

    public SystemController(ISystemService systemService)
    {
        _systemService = systemService;
    }

    [HttpGet]
    public async Task<ActionResult<SystemMessageDto?>> GetSystemMessage()
    {
        return Ok(await _systemService.GetSystemMessage());
    }
}
