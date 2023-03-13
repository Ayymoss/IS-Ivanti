using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class VirtualImage
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string InventoryPath { get; set; } = null!;

    public int HypervisorId { get; set; }

    public string Uuid { get; set; } = null!;

    public string VmxPath { get; set; } = null!;

    public int? NumberOfCpus { get; set; }

    public int? MemoryMb { get; set; }

    public long? TotalDiskSpace { get; set; }

    public string? OsName { get; set; }

    public string? Hostname { get; set; }

    public byte LastKnownPowerState { get; set; }

    public bool IsTemplate { get; set; }

    public byte[]? IpAddress { get; set; }

    public int? ToolsVersion { get; set; }

    public byte? ToolsVersionStatus { get; set; }

    public byte? ToolsStatus { get; set; }

    public virtual Hypervisor Hypervisor { get; set; } = null!;
}
