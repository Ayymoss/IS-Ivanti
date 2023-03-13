using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class AssetScanTemplateCategory
{
    public int Id { get; set; }

    public int AssetScanTemplateId { get; set; }

    public int AssetCategoryId { get; set; }

    public virtual AssetScanTemplate AssetScanTemplate { get; set; } = null!;
}
