using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchCve
{
    public int Id { get; set; }

    public Guid PatchUid { get; set; }

    public int CveId { get; set; }

    public virtual Cve Cve { get; set; } = null!;
}
