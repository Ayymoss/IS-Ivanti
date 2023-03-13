using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class ManagedMachine
{
    public int MmKey { get; set; }

    public string? MmName { get; set; }

    public int? MmOsid { get; set; }

    public int? MmSchedulerPort { get; set; }

    public string? MmDeploymentDrive { get; set; }

    public string? MmCustomer { get; set; }

    public string? MmLocation { get; set; }

    public string? MmDescription { get; set; }

    public string? MmAssetTags { get; set; }

    public short? MmCriticality { get; set; }

    public string? MmCustom1 { get; set; }

    public string? MmCustom2 { get; set; }

    public string? MmCustom3 { get; set; }

    public string Name { get; set; } = null!;

    public string? Domain { get; set; }

    public string? DnsName { get; set; }

    public int? LastPatchScanId { get; set; }

    public int? LastAssetInventoryScanId { get; set; }

    public DateTime Created { get; set; }

    public DateTime LastUpdated { get; set; }

    public int? RdpPort { get; set; }

    public byte[]? LastKnownIpaddress { get; set; }

    public int? Language { get; set; }

    public int? VirtualMachineId { get; set; }

    public int PlatformId { get; set; }

    public Guid? NixOsid { get; set; }

    public string? AssignedGroup { get; set; }

    public byte ConnectionMethod { get; set; }

    public byte SshAuthenticationMethod { get; set; }

    public virtual ICollection<Acevent> Acevents { get; } = new List<Acevent>();

    public virtual ICollection<AgentPushInstall> AgentPushInstalls { get; } = new List<AgentPushInstall>();

    public virtual ICollection<Agent> Agents { get; } = new List<Agent>();

    public virtual Scan? LastAssetInventoryScan { get; set; }

    public virtual Scan? LastPatchScan { get; set; }

    public virtual ICollection<LinkEmailRecMachineAnnotation> LinkEmailRecMachineAnnotations { get; } = new List<LinkEmailRecMachineAnnotation>();

    public virtual ICollection<LinkEmailRecManagedMachine> LinkEmailRecManagedMachines { get; } = new List<LinkEmailRecManagedMachine>();

    public virtual MachineMeasure? MachineMeasure { get; set; }

    public virtual LinkSpproduct? MmOs { get; set; }

    public virtual ICollection<NetworkInterface> NetworkInterfaces { get; } = new List<NetworkInterface>();

    public virtual ICollection<PatchDeployAudit> PatchDeployAudits { get; } = new List<PatchDeployAudit>();

    public virtual Platform Platform { get; set; } = null!;

    public virtual ICollection<PowerShellResult> PowerShellResults { get; } = new List<PowerShellResult>();

    public virtual ICollection<ScanMachine> ScanMachines { get; } = new List<ScanMachine>();

    public virtual VirtualMachine? VirtualMachine { get; set; }
}
