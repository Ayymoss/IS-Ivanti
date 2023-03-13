namespace ISIvanti.Server.Dtos;

public class AgentPolicyValueDto
{
    public List<AgentPolicyDto>? Value { get; set; }
}
public class AgentPolicyDto
{
    public string? TaskId { get; set; }
    public string? TaskName { get; set; }
    public string? TaskType { get; set; }
}
