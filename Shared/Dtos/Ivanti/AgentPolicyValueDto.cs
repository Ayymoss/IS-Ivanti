using ISIvanti.Shared.Enums;

namespace ISIvanti.Shared.Dtos.Ivanti;

public record AgentPolicyValueDto
{
    public List<AgentPolicyDto>? Value { get; set; }
}
public record AgentPolicyDto
{
    public Guid TaskId { get; set; }
    public string? TaskName { get; set; }
    public TaskType TaskType { get; set; }
}
