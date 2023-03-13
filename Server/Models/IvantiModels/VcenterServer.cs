using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class VcenterServer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Port { get; set; }

    public byte[] Version { get; set; } = null!;

    public byte[]? CertificateThumbprint { get; set; }

    public virtual ICollection<Hypervisor> Hypervisors { get; } = new List<Hypervisor>();
}
