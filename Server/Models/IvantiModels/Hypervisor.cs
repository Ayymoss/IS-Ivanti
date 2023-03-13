using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Hypervisor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Port { get; set; }

    public int? VCenterServerId { get; set; }

    public byte[]? IpAddress { get; set; }

    public int? CpuCount { get; set; }

    public int? MemoryMb { get; set; }

    public long? TotalDiskSpace { get; set; }

    public string? HypervisorVersion { get; set; }

    public int? ProcessorSpeed { get; set; }

    public string HostSystemName { get; set; } = null!;

    public bool IsInMaintenanceMode { get; set; }

    public byte[] Version { get; set; } = null!;

    public byte[]? CertificateThumbprint { get; set; }

    public virtual ICollection<BulletinDeployment> BulletinDeployments { get; } = new List<BulletinDeployment>();

    public virtual ICollection<HypervisorResult> HypervisorResults { get; } = new List<HypervisorResult>();

    public virtual VcenterServer? VCenterServer { get; set; }

    public virtual ICollection<VirtualImage> VirtualImages { get; } = new List<VirtualImage>();
}
