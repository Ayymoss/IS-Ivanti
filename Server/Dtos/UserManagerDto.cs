namespace ISIvanti.Server.Dtos;

public class UserManagerDto
{
    public required Guid Identity { get; set; }
    public required string UserName { get; set; }
    public required string Password { get; set; }
    public required WebRole Role { get; set; }
    public required DateTimeOffset Created { get; set; }
}

public enum WebRole
{
    Administrator,
    User
}
