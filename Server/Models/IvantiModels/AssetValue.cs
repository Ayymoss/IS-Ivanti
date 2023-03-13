using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class AssetValue
{
    public long Id { get; set; }

    public int ScanMachineId { get; set; }

    public int AssetDefinitionId { get; set; }

    public short Instance { get; set; }

    public object? Value { get; set; }

    public int? AssetValueCommonId { get; set; }

    public virtual AssetDefinition AssetDefinition { get; set; } = null!;

    public virtual AssetValueCommon? AssetValueCommon { get; set; }

    public virtual ICollection<AssetValueList> AssetValueLists { get; } = new List<AssetValueList>();

    public virtual ScanMachine ScanMachine { get; set; } = null!;
}
