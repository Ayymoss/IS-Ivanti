using System.ComponentModel.DataAnnotations;
using ISIvanti.Shared.Enums;

namespace ISIvanti.Server.Models.LocalModels;

public class EFJob
{
    [Key] public int Id { get; set; }
    public required string UserName { get; set; }
    public required Guid Guid { get; set; }
    public required string TaskName { get; set; }
    public required State State { get; set; }
    public required string AgentName { get; set; }
    public required DateTime Created { get; set; }
    public DateTime? Completed { get; set; }
}
