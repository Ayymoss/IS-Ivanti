using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class ScanItem
{
    public long ItemId { get; set; }

    public int ItempspplId { get; set; }

    public byte? ItemType { get; set; }

    public int ItemMachineId { get; set; }

    public string? StatusMessage { get; set; }

    public short? StatusMessageId { get; set; }

    public string? ItemInstanceName { get; set; }

    public int? ItemspplId { get; set; }

    public string? ExpectedTrace { get; set; }

    public string? ActualTrace { get; set; }

    public int? PatchTraceId { get; set; }

    public int? Language { get; set; }

    public DateTime? InstalledOn { get; set; }

    public string? InstalledBy { get; set; }

    public short? EvidenceRule { get; set; }

    public short? InstallState { get; set; }

    public virtual ScanMachine ItemMachine { get; set; } = null!;

    public virtual LinkPatchProduct Itempsppl { get; set; } = null!;

    public virtual LinkSpproduct? Itemsppl { get; set; }

    public virtual ICollection<LinkDeploymentScanItem> LinkDeploymentScanItems { get; } = new List<LinkDeploymentScanItem>();

    public virtual PatchTrace? PatchTrace { get; set; }
}
