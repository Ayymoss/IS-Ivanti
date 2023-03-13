using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class HypervisorResult
{
    public int Id { get; set; }

    public int HypervisorId { get; set; }

    public DateTime? MetadataDate { get; set; }

    public int ResultStatus { get; set; }

    public DateTime ScanDate { get; set; }

    public string? ErrorMessage { get; set; }

    public virtual ICollection<DetectedBulletin> DetectedBulletins { get; } = new List<DetectedBulletin>();

    public virtual Hypervisor Hypervisor { get; set; } = null!;
}
