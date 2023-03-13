using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class MachineDeployment
{
    public int Id { get; set; }

    public int DeploymentId { get; set; }

    public int MachineId { get; set; }

    public string? AdminUsername { get; set; }

    public byte[]? AdminPassword { get; set; }

    public string? ViUsername { get; set; }

    public byte[]? ViPassword { get; set; }

    public virtual PatchDeployment Deployment { get; set; } = null!;

    public virtual ScanMachine Machine { get; set; } = null!;

    public virtual ICollection<MachineDeploymentStatus> MachineDeploymentStatuses { get; } = new List<MachineDeploymentStatus>();
}
