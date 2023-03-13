using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchDeploymentDetectedPatch
{
    public long Id { get; set; }

    public short CompletionCode { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorNote { get; set; }

    public byte? ErrorStep { get; set; }

    public long DetectedPatchId { get; set; }

    public DateTime InstallEndedOn { get; set; }

    public DateTime InstallStartedOn { get; set; }

    public int PatchDeploymentId { get; set; }

    public virtual DetectedPatch DetectedPatch { get; set; } = null!;

    public virtual PatchDeployment1 PatchDeployment { get; set; } = null!;

    public virtual ICollection<PatchDeploymentDetectedPatchAction> PatchDeploymentDetectedPatchActions { get; } = new List<PatchDeploymentDetectedPatchAction>();
}
