using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchAppliesTo
{
    public int PatchId { get; set; }

    public int ProductId { get; set; }

    public int? CveId { get; set; }
}
