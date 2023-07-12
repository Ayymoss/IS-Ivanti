namespace ISIvanti.Shared.Dtos.Account;

public record UserDto
{
    public required Guid Identity { get; set; }
    public required string UserName { get; set; }
    public required string Role { get; set; }
}
