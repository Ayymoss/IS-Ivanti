using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class ServicePackGroupProduct
{
    public int Id { get; set; }

    public int ServicePackGroupId { get; set; }

    public Guid CatalogProductUid { get; set; }

    public byte? SelectedServicePackOrdinal { get; set; }

    public string SelectedServicePackName { get; set; } = null!;

    public bool UseLatest { get; set; }

    public virtual ServicePackGroup ServicePackGroup { get; set; } = null!;
}
