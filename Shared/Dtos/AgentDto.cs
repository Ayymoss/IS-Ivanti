namespace ISIvanti.Shared.Dtos;

public record AgentContextDto
{
    public int Count { get; set; }
    public List<AgentDto>? Agents { get; set; }
}

public record AgentDto
{
    public int MachineId { get; set; }
    public string? MachineName { get; set; }
    public string? AssignedGroup { get; set; }
    public int PatchesInstalled { get; set; }
    public int PatchesMissing { get; set; }
    public float PatchesInstalledPercentage { get; set; }
    public DateTime LastUpdated { get; set; }
    public string? ProductName { get; set; }
    public string? ProductVersion { get; set; }
}
