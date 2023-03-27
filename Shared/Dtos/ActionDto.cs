using ISIvanti.Shared.Enums;

namespace ISIvanti.Shared.Dtos;

public record ActionDto
{
    public string? AgentId { get; set; }
    public int MachineId { get; set; }
    public string? AgentName { get; set; }
    public string? TaskId { get; set; }
    public string? TaskName { get; set; }
    public TaskType TaskType { get; set; }
}
