using System.Security.Claims;
using ISIvanti.Server.Dtos;
using ISIvanti.Server.Interfaces;
using ISIvanti.Server.Services;
using ISIvanti.Shared.Dtos.Proofpoint;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ISIvanti.Server.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class ProofpointController : ControllerBase
{
    private readonly IProofpointService _proofpointService;
    private readonly UserManager _userManager;

    public ProofpointController(IProofpointService proofpointService, UserManager userManager)
    {
        _proofpointService = proofpointService;
        _userManager = userManager;
    }

    [HttpGet]
    public async Task<ActionResult<List<ProofpointContextDto>>> PostPaginationAsync()
    {
        var userId = HttpContext.User.Claims
            .Where(x => x.Type == ClaimTypes.NameIdentifier)
            .Select(f => f.Value)
            .FirstOrDefault();
        
        _ = Guid.TryParse(userId, out var userGuid);
        if (!_userManager.IsUserInGroup(userGuid, WebRole.Administrator)) return Unauthorized();

        var result = await _proofpointService.GetProofpointIsolatedUrlsAsync();
        if (result is null) return BadRequest();
        return Ok(result);
    }
}
