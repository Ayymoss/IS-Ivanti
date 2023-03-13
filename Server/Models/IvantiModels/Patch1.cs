using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Patch1
{
    public int Id { get; set; }

    public Guid PatchId { get; set; }

    public string Name { get; set; } = null!;

    public byte Severity { get; set; }

    public byte Type { get; set; }

    public DateTime Updated { get; set; }

    public virtual ICollection<PatchNotification> PatchNotifications { get; } = new List<PatchNotification>();

    public virtual ICollection<PatchPlatform> PatchPlatforms { get; } = new List<PatchPlatform>();
}
