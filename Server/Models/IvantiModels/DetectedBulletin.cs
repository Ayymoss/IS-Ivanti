using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class DetectedBulletin
{
    public int Id { get; set; }

    public int HypervisorResultId { get; set; }

    public int BulletinId { get; set; }

    public bool IsInstalled { get; set; }

    public bool IsReplaced { get; set; }

    public virtual Bulletin Bulletin { get; set; } = null!;

    public virtual ICollection<DetectedBundle> DetectedBundles { get; } = new List<DetectedBundle>();

    public virtual HypervisorResult HypervisorResult { get; set; } = null!;
}
