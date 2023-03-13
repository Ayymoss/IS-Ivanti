namespace ISIvanti.Server.Utilities;

public class Configuration
{ 
    public required string Domain { get; set; }
    public required string EncryptionPassword { get; set; }
    public string? CertificatePath { get; set; }
    public string? CertificatePassword { get; set; }
    public required string HostAndPort { get; set; }
}
