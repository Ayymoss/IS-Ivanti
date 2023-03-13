using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class ScanMachine
{
    public int SmachId { get; set; }

    public string SmachName { get; set; } = null!;

    public int SmachScanId { get; set; }

    public string? SmachDomainName { get; set; }

    public byte[]? IpAddress { get; set; }

    public int? SmachServerType { get; set; }

    public int? SmachOsid { get; set; }

    public string? SmachNotFoundReason { get; set; }

    public short SmachNotFoundReasonErrorNum { get; set; }

    public int? SmachmmKey { get; set; }

    public bool IsAgent { get; set; }

    public DateTime SmachScanDate { get; set; }

    public int SmachMachineType { get; set; }

    public string? GroupName { get; set; }

    public int? ManagedListId { get; set; }

    public int? VirtualMachineId { get; set; }

    public byte PowerState { get; set; }

    public int PlatformId { get; set; }

    public Guid? NixOsid { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual ICollection<AssetValue> AssetValues { get; } = new List<AssetValue>();

    public virtual ICollection<DetectedPatch> DetectedPatches { get; } = new List<DetectedPatch>();

    public virtual ICollection<DetectedSoftwareAsset> DetectedSoftwareAssets { get; } = new List<DetectedSoftwareAsset>();

    public virtual ICollection<MachineDeployment> MachineDeployments { get; } = new List<MachineDeployment>();

    public virtual Platform Platform { get; set; } = null!;

    public virtual ICollection<ScanItem> ScanItems { get; } = new List<ScanItem>();

    public virtual LinkSpproduct? SmachOs { get; set; }

    public virtual Scan SmachScan { get; set; } = null!;

    public virtual ManagedMachine? SmachmmKeyNavigation { get; set; }

    public virtual VirtualMachine? VirtualMachine { get; set; }
}
