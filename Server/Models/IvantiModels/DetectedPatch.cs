using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class DetectedPatch
{
    public long Id { get; set; }

    public byte InstallState { get; set; }

    public int? Language { get; set; }

    public Guid PatchId { get; set; }

    public int ScanMachineId { get; set; }

    public virtual ICollection<PatchDeploymentDetectedPatch> PatchDeploymentDetectedPatches { get; } = new List<PatchDeploymentDetectedPatch>();

    public virtual ICollection<PatchTrace1> PatchTrace1s { get; } = new List<PatchTrace1>();

    public virtual ScanMachine ScanMachine { get; set; } = null!;
}
