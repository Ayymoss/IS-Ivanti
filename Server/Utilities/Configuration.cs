using ISIvanti.Server.Dtos;

namespace ISIvanti.Server.Utilities;

public class Configuration
{
    public required string ApiReferenceDomain { get; set; }
    public required string ApiHostAndPort { get; set; }
    public required string IvantiDatabaseConnectionString { get; set; }
    public required string LocalDatabaseLocation { get; set; }
    public string? CertificatePath { get; set; }
    public string? CertificatePassword { get; set; }
    public int IvantiQueryInDays { get; set; } = 45;
    public required string LogLevel { get; set; } = "Warning";
    public required string SentinelApi { get; set; }
    public required string SentinelApiHost { get; set; }
    public required List<string> Administrators { get; set; } = new();
    public required string ProofpointApi { get; set; }
    public required string ProofpointApiHost { get; set; }
}
