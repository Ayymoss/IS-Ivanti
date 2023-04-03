namespace ISIvanti.Server.Utilities;

public class Configuration
{ 
    public required string ApiReferenceDomain { get; set; }
    public required string ApiHostAndPort { get; set; }
    public required string IvantiDatabaseConnectionString { get; set; }
    public required string LocalDatabaseLocation { get; set; }
    public string? CertificatePath { get; set; }
    public string? CertificatePassword { get; set; }
    public required string LogLevel { get; set; } = "Warning";
}
