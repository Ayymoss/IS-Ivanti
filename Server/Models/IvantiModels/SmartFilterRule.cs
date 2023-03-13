using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class SmartFilterRule
{
    public int Id { get; set; }

    public string Field { get; set; } = null!;

    public string SearchText { get; set; } = null!;

    public int SearchOperator { get; set; }

    public int SmartFilterId { get; set; }

    public virtual SmartFilterGroup SmartFilter { get; set; } = null!;
}
