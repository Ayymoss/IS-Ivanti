using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class SmartFilterGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool ReadOnly { get; set; }

    public int MatchType { get; set; }

    public int FilterGroupType { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual ICollection<SmartFilterRule> SmartFilterRules { get; } = new List<SmartFilterRule>();
}
