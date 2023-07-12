using System.Security.Claims;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Account;
using Microsoft.AspNetCore.Components.Authorization;

namespace ISIvanti.Client.Providers;

public class CustomAuthStateProvider : AuthenticationStateProvider
{
    private ClaimsPrincipal _claimsPrincipal = new(new ClaimsIdentity());

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        return new AuthenticationState(_claimsPrincipal);
    }

    public void SetAuthInfo(UserDto userProfile)
    {
        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.Name, userProfile.UserName),
            new Claim(ClaimTypes.Role, userProfile.Role),
            new Claim(ClaimTypes.NameIdentifier, userProfile.Identity.ToString())
        }, "AuthCookie");

        _claimsPrincipal = new ClaimsPrincipal(identity);
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }

    public void ClearAuthInfo()
    {
        _claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity());
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }
}
