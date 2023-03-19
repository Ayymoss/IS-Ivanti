using ISIvanti.Shared.Enums;

namespace ISIvanti.Shared.Dtos;

public class JobContextDto
{
    public int Count { get; set; }
    public List<JobDto>? Jobs { get; set; }
}

public class JobDto
{
    public string? UserName { get; set; }
    public Guid Guid { get; set; }
    public string? TaskName { get; set; }
    public State? State { get; set; }
    public string? AgentName { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? Completed { get; set; }
}
