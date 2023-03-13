using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Bulletin
{
    public int Id { get; set; }

    public byte Category { get; set; }

    public string? Description { get; set; }

    public string BulletinId { get; set; } = null!;

    public string KbUrl { get; set; } = null!;

    public DateTime ReleaseDate { get; set; }

    public byte ReleaseType { get; set; }

    public string? ReplacedBy { get; set; }

    public byte Severity { get; set; }

    public string? Summary { get; set; }

    public byte Urgency { get; set; }

    public string Vendor { get; set; } = null!;

    public virtual ICollection<BulletinDeployment> BulletinDeployments { get; } = new List<BulletinDeployment>();

    public virtual ICollection<DetectedBulletin> DetectedBulletins { get; } = new List<DetectedBulletin>();
}
