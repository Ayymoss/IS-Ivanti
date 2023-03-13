using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Product
{
    public int ProdId { get; set; }

    public string ProdName { get; set; } = null!;

    public bool ProdIsCustom { get; set; }

    public int? VendorId { get; set; }

    public DateTime? EndOfLife { get; set; }

    public string? EndOfLifeUrl { get; set; }

    public Guid? Uid { get; set; }

    public DateTime? LastRevisedOn { get; set; }

    public virtual ICollection<LinkSpproduct> LinkSpproducts { get; } = new List<LinkSpproduct>();
}
