using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class RebootOptionsPart
{
    public Guid PartId { get; set; }

    public short ActionType { get; set; }

    public short ScheduleType { get; set; }

    public DateTime? InteractiveCutoffDateTime { get; set; }

    public DateTime? ScheduledDateTime { get; set; }

    public short InteractionType { get; set; }

    public int? TimeoutMinutes { get; set; }

    public int? CountDownMinutes { get; set; }

    public bool IsExtendAllowed { get; set; }

    public int? ExtendIncrementMinutes { get; set; }

    public bool IsCancelTimeoutAllowed { get; set; }

    public bool IsCancelRebootAllowed { get; set; }

    public int ShutdownDialogSeconds { get; set; }

    public bool IsTemp { get; set; }

    public bool IsSystem { get; set; }

    public string? CreatorName { get; set; }

    public short TargetPowerState { get; set; }

    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual ICollection<Policy> PolicyServerAgentRebootOptions { get; } = new List<Policy>();

    public virtual ICollection<Policy> PolicyWorkstationAgentRebootOptions { get; } = new List<Policy>();
}
