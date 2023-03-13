using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinkPatchProduct
{
    public int PspplId { get; set; }

    public int PspplspplId { get; set; }

    public int PspplpatchId { get; set; }

    public string? PspplAnnotation { get; set; }

    public byte? PspplMsseverity { get; set; }

    public string? PspplShavlikComment { get; set; }

    public byte[]? CatalogPatchId { get; set; }

    public Guid? PatchUid { get; set; }

    public DateTime? LastRevisedOn { get; set; }

    public virtual ICollection<LinkDeploymentScanItem> LinkDeploymentScanItems { get; } = new List<LinkDeploymentScanItem>();

    public virtual Patch Pspplpatch { get; set; } = null!;

    public virtual LinkSpproduct Pspplsppl { get; set; } = null!;

    public virtual ICollection<ScanItem> ScanItems { get; } = new List<ScanItem>();
}
