using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchGroupItem
{
    public int Id { get; set; }

    public int PatchGroupId { get; set; }

    public Guid PatchId { get; set; }

    public virtual PatchGroup1 PatchGroup { get; set; } = null!;
}
