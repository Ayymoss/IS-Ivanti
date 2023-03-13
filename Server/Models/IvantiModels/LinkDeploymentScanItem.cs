using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinkDeploymentScanItem
{
    public long DsilId { get; set; }

    public long DsilitemId { get; set; }

    public int DsilpdId { get; set; }

    public string? DsilTargetPath { get; set; }

    public short DsilDeployStatus { get; set; }

    public DateTime? DsilScheduledTime { get; set; }

    public DateTime? DsilStatusTime { get; set; }

    public int? DsilSpdeployed { get; set; }

    public DateTime? InstallStart { get; set; }

    public DateTime? InstallEnd { get; set; }

    public int? NativeCode { get; set; }

    public byte OverallState { get; set; }

    public short Sequence { get; set; }

    public virtual LinkPatchProduct? DsilSpdeployedNavigation { get; set; }

    public virtual ScanItem Dsilitem { get; set; } = null!;

    public virtual PatchDeployment Dsilpd { get; set; } = null!;
}
