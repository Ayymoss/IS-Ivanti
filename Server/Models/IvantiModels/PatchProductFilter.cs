using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchProductFilter
{
    public int Id { get; set; }

    public int ScanTemplateId { get; set; }

    public int CatalogId { get; set; }

    public byte Type { get; set; }

    public bool IsIncluded { get; set; }

    public virtual ScanTemplate ScanTemplate { get; set; } = null!;
}
