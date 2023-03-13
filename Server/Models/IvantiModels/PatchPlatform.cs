using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchPlatform
{
    public int Id { get; set; }

    public Guid PatchId { get; set; }

    public Guid PlatformId { get; set; }

    public virtual Patch1 Patch { get; set; } = null!;

    public virtual Platform1 Platform { get; set; } = null!;
}
