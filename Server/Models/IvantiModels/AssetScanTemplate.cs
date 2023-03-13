using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class AssetScanTemplate
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string CreatorName { get; set; } = null!;

    public bool SoftwareScan { get; set; }

    public bool HardwareScan { get; set; }

    public bool ScanAllHardware { get; set; }

    public Guid PartId { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual ICollection<AssetScanTemplateCategory> AssetScanTemplateCategories { get; } = new List<AssetScanTemplateCategory>();
}
