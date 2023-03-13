using System.Security.Claims;
using ISIvanti.Server.Enums;
using ISIvanti.Server.Interfaces;
using ISIvanti.Shared.Dtos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ISIvanti.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("Login")]
    public async Task<IActionResult> LoginAsync([FromBody] LoginRequestDto loginRequest)
    {
        var result = await _authService.LoginAsync(loginRequest);
        switch (result.Item1)
        {
            case ControllerEnums.ReturnState.Ok:
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(result.Item2), result.Item3);
                return Ok("Success");
        }
        return Unauthorized("Invalid or unprivileged access.");
    }

    [HttpGet("Profile"), Authorize]
    public ActionResult<UserDto> UserProfileAsync()
    {
        var userId = HttpContext.User.Claims
            .Where(x => x.Type == ClaimTypes.NameIdentifier)
            .Select(f => f.Value)
            .First();

        var result = _authService.UserProfileAsync(userId);
        if (result is null) return BadRequest("User is invalid.");
        return Ok(result);
    }

    [HttpPost("Logout"), Authorize]
    public async Task<IActionResult> LogoutAsync()
    {
        await HttpContext.SignOutAsync();
        return Ok("Success");
    }
}
