using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class AssetValueList
{
    public long AssetValueId { get; set; }

    public int Ordinal { get; set; }

    public object Value { get; set; } = null!;

    public virtual AssetValue AssetValue { get; set; } = null!;
}
