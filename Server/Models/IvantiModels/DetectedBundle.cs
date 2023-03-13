using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class DetectedBundle
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DetectedBulletinId { get; set; }

    public int? InstalledBundleId { get; set; }

    public int NewestBundleId { get; set; }

    public byte RequiredBundleState { get; set; }

    public int RequiredBundleId { get; set; }

    public virtual DetectedBulletin DetectedBulletin { get; set; } = null!;

    public virtual Bundle? InstalledBundle { get; set; }

    public virtual Bundle NewestBundle { get; set; } = null!;

    public virtual Bundle RequiredBundle { get; set; } = null!;
}
