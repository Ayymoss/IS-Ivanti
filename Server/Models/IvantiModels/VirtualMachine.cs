using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class VirtualMachine
{
    public int Id { get; set; }

    public string Path { get; set; } = null!;

    public int? VirtualServerId { get; set; }

    public virtual ICollection<ManagedMachine> ManagedMachines { get; } = new List<ManagedMachine>();

    public virtual ICollection<ScanMachine> ScanMachines { get; } = new List<ScanMachine>();

    public virtual VirtualServer? VirtualServer { get; set; }
}
