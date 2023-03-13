using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class TaskPolicyPart
{
    public Guid PartId { get; set; }

    public Guid TaskId { get; set; }

    public int? StepType { get; set; }

    public byte PolicyPartType { get; set; }

    public virtual Task Task { get; set; } = null!;
}
