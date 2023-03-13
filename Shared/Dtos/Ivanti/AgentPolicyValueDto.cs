using ISIvanti.Shared.Enums;

namespace ISIvanti.Shared.Dtos.Ivanti;

public class AgentPolicyValueDto
{
    public List<AgentPolicyDto>? Value { get; set; }
}
public class AgentPolicyDto
{
    public Guid TaskId { get; set; }
    public string? TaskName { get; set; }
    public TaskType TaskType { get; set; }
}
