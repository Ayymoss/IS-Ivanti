using ISIvanti.Shared.Dtos;

namespace ISIvanti.Client.Interfaces;

public interface IApiService
{
    Task<string> LoginAsync(LoginRequestDto login);
    Task<(string, UserDto?)> UserProfileAsync();
    Task<string> LogoutAsync();
}
