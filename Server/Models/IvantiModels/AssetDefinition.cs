using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class AssetDefinition
{
    public int Id { get; set; }

    public string Class { get; set; } = null!;

    public string Name { get; set; } = null!;

    public byte Type { get; set; }

    public short OrderIndex { get; set; }

    public virtual ICollection<AssetValue> AssetValues { get; } = new List<AssetValue>();
}
