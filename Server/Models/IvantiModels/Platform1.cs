using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Platform1
{
    public int Id { get; set; }

    public Guid PlatformId { get; set; }

    public string Name { get; set; } = null!;

    public byte Distribution { get; set; }

    public byte Architecture { get; set; }

    public string Edition { get; set; } = null!;

    public DateTime Updated { get; set; }

    public virtual ICollection<PatchPlatform> PatchPlatforms { get; } = new List<PatchPlatform>();
}
