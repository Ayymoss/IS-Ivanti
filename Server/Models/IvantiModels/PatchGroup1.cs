using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchGroup1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public string? Path { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual ICollection<PatchGroupItem> PatchGroupItems { get; } = new List<PatchGroupItem>();

    public virtual ICollection<PatchDeploymentConfiguration> PatchDeploymentConfigurations { get; } = new List<PatchDeploymentConfiguration>();

    public virtual ICollection<PatchScanConfiguration> PatchScanConfigurations { get; } = new List<PatchScanConfiguration>();
}
