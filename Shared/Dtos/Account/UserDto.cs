namespace ISIvanti.Shared.Dtos.Account;

public record UserDto
{
    public Guid Identity { get; set; }
    public string UserName { get; set; } = null!;
}
