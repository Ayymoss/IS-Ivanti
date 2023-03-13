using ISIvanti.Shared.Enums;

namespace ISIvanti.Server.Models;

public class EFJob
{
    public required Guid Guid { get; set; }
    public required string Action { get; set; }
    public required State State { get; set; }
}
