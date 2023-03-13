using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchGroup
{
    public int PgrpKey { get; set; }

    public string PgrpName { get; set; } = null!;

    public DateTime? PgrpCreateDate { get; set; }

    public DateTime? PgrpUpdateDate { get; set; }

    public string PgrpCreatorName { get; set; } = null!;

    public byte[] Version { get; set; } = null!;

    public string? Path { get; set; }

    public virtual ICollection<ApprovedPatchPart> ApprovedPatchParts { get; } = new List<ApprovedPatchPart>();

    public virtual ICollection<LinkTemplatePatchGroup> LinkTemplatePatchGroups { get; } = new List<LinkTemplatePatchGroup>();

    public virtual ICollection<Patch> Patches { get; } = new List<Patch>();
}
