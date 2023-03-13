using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinkSpproduct
{
    public int SpplId { get; set; }

    public int SpplprodId { get; set; }

    public int SpplspId { get; set; }

    public int? SpplOrdinal { get; set; }

    public Guid? Uid { get; set; }

    public DateTime? LastRevisedOn { get; set; }

    public DateTime? EndOfLife { get; set; }

    public virtual ICollection<LinkPatchProduct> LinkPatchProducts { get; } = new List<LinkPatchProduct>();

    public virtual ICollection<ManagedMachine> ManagedMachines { get; } = new List<ManagedMachine>();

    public virtual ICollection<ScanItem> ScanItems { get; } = new List<ScanItem>();

    public virtual ICollection<ScanMachine> ScanMachines { get; } = new List<ScanMachine>();

    public virtual Product Spplprod { get; set; } = null!;

    public virtual ServicePack Spplsp { get; set; } = null!;
}
