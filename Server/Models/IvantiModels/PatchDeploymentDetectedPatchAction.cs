using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchDeploymentDetectedPatchAction
{
    public long Id { get; set; }

    public string? CurrentRelease { get; set; }

    public string? CurrentVersion { get; set; }

    public string FullName { get; set; } = null!;

    public DateTime? InstalledOn { get; set; }

    public bool IsDependency { get; set; }

    public string Name { get; set; } = null!;

    public long PatchDeploymentDetectedPatchId { get; set; }

    public string? PreviousRelease { get; set; }

    public string? PreviousVersion { get; set; }

    public byte State { get; set; }

    public virtual PatchDeploymentDetectedPatch PatchDeploymentDetectedPatch { get; set; } = null!;
}
