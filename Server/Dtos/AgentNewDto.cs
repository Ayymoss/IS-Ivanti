namespace ISIvanti.Server.Dtos;

public class AgentNewDto
{
    public int MachineId { get; set; }
    public string? MachineName { get; set; }
    public string? AssignedGroup { get; set; }
    public int PatchesInstalled { get; set; }
    public int PatchesMissing { get; set; }
    public float PatchesInstalledPercentage { get; set; }
    public DateTime LastUpdated { get; set; }
}
