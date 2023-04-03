using System.Net;
using ISIvanti.Shared.Enums;

namespace ISIvanti.Shared.Dtos;

public record JobContextDto
{
    public int Count { get; set; }
    public List<JobDto>? Jobs { get; set; }
}

public record JobDto
{
    public string? UserName { get; set; }
    public Guid Guid { get; set; }
    public string? TaskName { get; set; }
    public State? State { get; set; }
    public HttpStatusCode StateResult { get; set; }
    public string? AgentName { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? Completed { get; set; }
}
