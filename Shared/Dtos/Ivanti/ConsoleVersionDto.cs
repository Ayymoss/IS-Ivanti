namespace ISIvanti.Shared.Dtos.Ivanti;

public record ConsoleVersionDto
{
    public string? LatestApiVersion { get; set; }
    public string? ProductName { get; set; }
    public string? ProductVersion { get; set; }
}
