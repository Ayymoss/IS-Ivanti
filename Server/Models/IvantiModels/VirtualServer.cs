using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class VirtualServer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Port { get; set; }

    public virtual ICollection<VirtualMachine> VirtualMachines { get; } = new List<VirtualMachine>();
}
