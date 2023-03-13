using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchDeployment1
{
    public int Id { get; set; }

    public int ConsoleId { get; set; }

    public DateTime EndedOn { get; set; }

    public bool IsRebootRequested { get; set; }

    public bool IsRebootScheduled { get; set; }

    public DateTime StartedOn { get; set; }

    public Guid Uid { get; set; }

    public string? UserName { get; set; }

    public virtual ConsoleIdentity Console { get; set; } = null!;

    public virtual ICollection<PatchDeploymentDetectedPatch> PatchDeploymentDetectedPatches { get; } = new List<PatchDeploymentDetectedPatch>();
}
