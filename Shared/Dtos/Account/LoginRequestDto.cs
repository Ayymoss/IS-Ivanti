namespace ISIvanti.Shared.Dtos.Account;

public record LoginRequestDto
{
    public required string UserName { get; set; }
    public required string Password { get; set; }
}
