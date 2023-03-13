using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinuxPatch
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public byte LinuxPatchTypeId { get; set; }

    public byte VendorSeverityId { get; set; }
}
