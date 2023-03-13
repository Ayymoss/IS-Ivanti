using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class DiscoveryFilter
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int Type { get; set; }

    public int DiscoveryGroupId { get; set; }

    public int? ChildDiscoveryGroupId { get; set; }

    public int? WebServicesPort { get; set; }

    public bool IncludeChildOu { get; set; }

    public bool IsExcluded { get; set; }

    public byte[] Version { get; set; } = null!;

    public string? Note { get; set; }

    public byte SshAuthenticationMethod { get; set; }

    public virtual ManagedGroup? ChildDiscoveryGroup { get; set; }

    public virtual ManagedGroup DiscoveryGroup { get; set; } = null!;

    public virtual ICollection<HostedVirtualSystem> HostedVirtualSystems { get; } = new List<HostedVirtualSystem>();
}
