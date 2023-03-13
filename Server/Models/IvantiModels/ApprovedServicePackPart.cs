using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class ApprovedServicePackPart
{
    public Guid PartId { get; set; }

    public int? ServicePackGroupId { get; set; }

    public short Flags { get; set; }

    public byte MaxServicePacksPerDay { get; set; }

    public int DownloadWindowMinutes { get; set; }

    public string Name { get; set; } = null!;

    public Guid Version { get; set; }

    public virtual ServicePackGroup? ServicePackGroup { get; set; }
}
