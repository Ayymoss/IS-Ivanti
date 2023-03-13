using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class HostedVirtualSystem
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string InventoryPath { get; set; } = null!;

    public int? ManagedListId { get; set; }

    public string ServerName { get; set; } = null!;

    public string Uuid { get; set; } = null!;

    public string? VmxPath { get; set; }

    public bool IsTemplate { get; set; }

    public string? Note { get; set; }

    public virtual DiscoveryFilter? ManagedList { get; set; }
}
