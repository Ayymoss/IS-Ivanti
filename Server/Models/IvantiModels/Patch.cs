using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Patch
{
    public int PatchId { get; set; }

    public string PatchQnumbers { get; set; } = null!;

    public string PatchBulletinId { get; set; } = null!;

    public string? PatchBulletinTitle { get; set; }

    public string? PatchBulletinUrl { get; set; }

    public string? PatchDescription { get; set; }

    public int? PatchType { get; set; }

    public bool PatchLevel { get; set; }

    public bool PatchIsCustom { get; set; }

    public DateTime? PatchBulletinDate { get; set; }

    public string? IavaId { get; set; }

    public virtual ICollection<LinkPatchProduct> LinkPatchProducts { get; } = new List<LinkPatchProduct>();

    public virtual ICollection<PatchGroup> PatchGroups { get; } = new List<PatchGroup>();
}
