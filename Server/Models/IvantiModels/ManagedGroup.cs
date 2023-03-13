using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class ManagedGroup
{
    public int GrpId { get; set; }

    public string GrpName { get; set; } = null!;

    public string? GrpDescription { get; set; }

    public bool GrpSystem { get; set; }

    public string? GrpCreatorName { get; set; }

    public DateTime? GrpCreateDate { get; set; }

    public DateTime? GrpUpdateDate { get; set; }

    public bool GrpTemp { get; set; }

    public short? GrpSystemGrpOrder { get; set; }

    public int GrpServerFilter { get; set; }

    public byte[] Version { get; set; } = null!;

    public string? Path { get; set; }

    public byte ConnectionMethod { get; set; }

    public virtual ICollection<DiscoveryFilter> DiscoveryFilterChildDiscoveryGroups { get; } = new List<DiscoveryFilter>();

    public virtual ICollection<DiscoveryFilter> DiscoveryFilterDiscoveryGroups { get; } = new List<DiscoveryFilter>();

    public virtual ICollection<LinkEmailRecManagedGroup> LinkEmailRecManagedGroups { get; } = new List<LinkEmailRecManagedGroup>();

    public virtual ICollection<LinkFavoriteGroup> LinkFavoriteGroups { get; } = new List<LinkFavoriteGroup>();
}
