using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class SoftwareTitle
{
    public int Id { get; set; }

    public string ProductCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string DisplayVersion { get; set; } = null!;

    public string? Publisher { get; set; }

    public int? MsiVersionNumber { get; set; }

    public virtual ICollection<DetectedSoftwareAsset> DetectedSoftwareAssets { get; } = new List<DetectedSoftwareAsset>();
}
