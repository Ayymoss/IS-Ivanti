using ISIvanti.Server.Dtos;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Account;

namespace ISIvanti.Server.Services;

public class UserManager
{
    private readonly List<UserManagerDto> _users = new();

    public UserManagerDto? GetUserCredentials(Guid identity)
    {
        var result = _users.FirstOrDefault(x => x.Identity == identity);
        return result;
    }

    public void AddUser(UserManagerDto userDto)
    {
        foreach (var user in _users.Where(users => users.Created + TimeSpan.FromDays(2) < DateTimeOffset.UtcNow))
        {
            _users.Remove(user);
        }

        if (_users.All(x => x.Identity != userDto.Identity)) _users.Add(userDto);
    }

    public void RemoveUser(UserDto user)
    {
        var existingUser = _users.FirstOrDefault(x => x.Identity == user.Identity);
        if (existingUser is null) return;
        _users.Remove(existingUser);
    }

    public bool UserExists(Guid identity) => _users.Any(x => x.Identity == identity);
    public bool IsUserInGroup(Guid identity, WebRole role) => _users.Any(x => x.Identity == identity && x.Role == role);
}
