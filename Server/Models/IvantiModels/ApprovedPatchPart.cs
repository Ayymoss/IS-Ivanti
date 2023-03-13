using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class ApprovedPatchPart
{
    public Guid PartId { get; set; }

    public int? PatchGroupId { get; set; }

    public int Type { get; set; }

    public int DownloadWindowMinutes { get; set; }

    public string Name { get; set; } = null!;

    public Guid Version { get; set; }

    public virtual PatchGroup? PatchGroup { get; set; }
}
