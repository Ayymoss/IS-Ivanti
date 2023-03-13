using System.Security.Claims;
using ISIvanti.Server.Enums;
using ISIvanti.Shared.Dtos;
using Microsoft.AspNetCore.Authentication;

namespace ISIvanti.Server.Interfaces;

public interface IAuthService
{
    Task<(ControllerEnums.ReturnState, ClaimsIdentity, AuthenticationProperties)> LoginAsync(LoginRequestDto loginRequest);
    UserDto? UserProfileAsync(string identity);
}
