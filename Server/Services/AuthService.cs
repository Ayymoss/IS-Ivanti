using System.Security.Claims;
using ISIvanti.Server.Dtos;
using ISIvanti.Server.Enums;
using ISIvanti.Server.Interfaces;
using ISIvanti.Server.Utilities;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ISIvanti.Server.Services;

public class AuthService : IAuthService
{
    private readonly UserManager _userManager;
    private readonly ApiClient _apiClient;
    private readonly Configuration _config;

    public AuthService(UserManager userManager, ApiClient apiClient, Configuration config)
    {
        _userManager = userManager;
        _apiClient = apiClient;
        _config = config;
    }

    public async Task<(ControllerEnums.ReturnState, ClaimsIdentity, AuthenticationProperties)> LoginAsync(LoginRequestDto loginRequest)
    {
        var userRole = _config.Administrators.Contains(loginRequest.UserName.ToLower()) ? WebRole.Administrator : WebRole.User;
        var user = new UserManagerDto
        {
            Identity = Guid.NewGuid(),
            UserName = loginRequest.UserName,
            Password = loginRequest.Password,
            Role = userRole,
            Created = DateTimeOffset.UtcNow
        };
        _userManager.AddUser(user); // The memory of this object can be abused. But, since it's internal I don't think it matters.

        //if (!Shared.Utilities.Utilities.IsDebugMode())
        {
            var apiClient = _apiClient.GetIvantiApiAsync(user.Identity);
            if (apiClient is null) return (ControllerEnums.ReturnState.Unauthorized, null, null)!;
            var result = await apiClient.GetVersionAsync();
            if (result is null) return (ControllerEnums.ReturnState.Unauthorized, null, null)!;
        }

        var claims = new List<Claim>
        {
            new(ClaimTypes.Name, user.UserName),
            new(ClaimTypes.Role, user.Role.ToString()),
            new(ClaimTypes.NameIdentifier, user.Identity.ToString()),
        };
        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var authProperties = new AuthenticationProperties();

        return (ControllerEnums.ReturnState.Ok, claimsIdentity, authProperties);
    }

    public UserDto? UserProfileAsync(string identity)
    {
        var user = _userManager.GetUserCredentials(Guid.Parse(identity));
        if (user is null) return null;
        return new UserDto
        {
            Identity = user.Identity,
            UserName = user.UserName,
            Role = user.Role.ToString()
        };
    }
}
