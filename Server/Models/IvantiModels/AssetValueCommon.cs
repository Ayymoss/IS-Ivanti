using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class AssetValueCommon
{
    public int Id { get; set; }

    public byte[] ValueHash { get; set; } = null!;

    public string Value { get; set; } = null!;

    public virtual ICollection<AssetValue> AssetValues { get; } = new List<AssetValue>();
}
