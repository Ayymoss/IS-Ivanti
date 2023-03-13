using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Patch2
{
    public int Id { get; set; }

    public string Bulletin { get; set; } = null!;

    public string Qnumber { get; set; } = null!;

    public string? BulletinTitle { get; set; }

    public byte? VendorSeverityId { get; set; }

    public bool IsCustomPatch { get; set; }

    public int? PatchTypeId { get; set; }

    public DateTime? ReleasedOn { get; set; }

    public string? IavaId { get; set; }
}
