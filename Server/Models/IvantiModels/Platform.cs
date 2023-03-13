using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Platform
{
    public int Id { get; set; }

    public byte Ostype { get; set; }

    public byte Architecture { get; set; }

    public string? Distribution { get; set; }

    public string? PlatformVersion { get; set; }

    public virtual ICollection<ManagedMachine> ManagedMachines { get; } = new List<ManagedMachine>();

    public virtual ICollection<ScanMachine> ScanMachines { get; } = new List<ScanMachine>();
}
