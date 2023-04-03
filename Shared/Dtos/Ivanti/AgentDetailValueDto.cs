namespace ISIvanti.Shared.Dtos.Ivanti;

public record AgentDetailValueDto
{
    public List<AgentDetailDto>? Value { get; set; }
}

public record AgentDetailDto
{
    public string? AgentId { get; set; }
    public DateTimeOffset LastCheckIn { get; set; }
    public string? FrameworkVersion { get; set; }
    public string? MachineName { get; set; }
    public bool IsListening { get; set; }
    public string? AssignedPolicyId { get; set; }
    public string? Status { get; set; }
}
