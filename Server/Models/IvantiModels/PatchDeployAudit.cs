using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchDeployAudit
{
    public long Id { get; set; }

    public int MachineId { get; set; }

    public Guid PatchId { get; set; }

    public DateTime InstalledOn { get; set; }

    public virtual ManagedMachine Machine { get; set; } = null!;
}
