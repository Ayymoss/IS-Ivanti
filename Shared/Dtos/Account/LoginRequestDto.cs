namespace ISIvanti.Shared.Dtos.Account;

public record LoginRequestDto
{
    public string? UserName { get; set; }
    public string? Password { get; set; }
}
