using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchDeploymentConfiguration
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? Path { get; set; }

    public bool IsSystem { get; set; }

    public Guid PartId { get; set; }

    public bool DeployOnlyExplicitVersion { get; set; }

    public bool PostDeployReboot { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual ICollection<PatchGroup1> PatchGroups { get; } = new List<PatchGroup1>();
}
