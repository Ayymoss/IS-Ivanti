using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class NetworkInterface
{
    public int ManagedMachineId { get; set; }

    public byte Id { get; set; }

    public int? Ipv4Address { get; set; }

    public int? Ipv4SubnetMask { get; set; }

    public byte[]? Ipv6Address { get; set; }

    public byte[]? MacAddress { get; set; }

    public virtual ManagedMachine ManagedMachine { get; set; } = null!;
}
