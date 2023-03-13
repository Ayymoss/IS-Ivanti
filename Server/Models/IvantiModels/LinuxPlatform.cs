using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinuxPlatform
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public byte LinuxDistributionId { get; set; }

    public byte ArchitectureId { get; set; }

    public string Edition { get; set; } = null!;
}
