using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class ServicePackGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Owner { get; set; } = null!;

    public byte[] Version { get; set; } = null!;

    public virtual ICollection<ApprovedServicePackPart> ApprovedServicePackParts { get; } = new List<ApprovedServicePackPart>();

    public virtual ICollection<ServicePackGroupProduct> ServicePackGroupProducts { get; } = new List<ServicePackGroupProduct>();
}
