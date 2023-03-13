using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchTrace1
{
    public long Id { get; set; }

    public byte ConclusionCode { get; set; }

    public long DetectedPatchId { get; set; }

    public string Name { get; set; } = null!;

    public string? VersionExpected { get; set; }

    public string? VersionFound { get; set; }

    public string? ReleaseExpected { get; set; }

    public string? ReleaseFound { get; set; }

    public virtual DetectedPatch DetectedPatch { get; set; } = null!;
}
