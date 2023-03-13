using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Scan
{
    public int ScanId { get; set; }

    public DateTime ScanDate { get; set; }

    public string? ScanXmlversion { get; set; }

    public DateTime? ScanXmldate { get; set; }

    public string? ScanUser { get; set; }

    public string? ScanScannerVersion { get; set; }

    public string? ScanName { get; set; }

    public int? ScanfavKey { get; set; }

    public int? ScanTemplateId { get; set; }

    public byte ScanType { get; set; }

    public int ScanConsoleId { get; set; }

    public Guid ScanGuid { get; set; }

    public int? AssetScanTemplateId { get; set; }

    public int ReceivedResultCount { get; set; }

    public int? ExpectedResultTotal { get; set; }

    public int ReceivedResolutionResultCount { get; set; }

    public int? ExpectedResolutionResultTotal { get; set; }

    public byte[]? UserSid { get; set; }

    public byte SourceType { get; set; }

    public DateTime Started { get; set; }

    public virtual ICollection<ManagedMachine> ManagedMachineLastAssetInventoryScans { get; } = new List<ManagedMachine>();

    public virtual ICollection<ManagedMachine> ManagedMachineLastPatchScans { get; } = new List<ManagedMachine>();

    public virtual PowerShellRun? PowerShellRun { get; set; }

    public virtual ICollection<ResolutionResult> ResolutionResults { get; } = new List<ResolutionResult>();

    public virtual ConsoleIdentity ScanConsole { get; set; } = null!;

    public virtual ICollection<ScanMachine> ScanMachines { get; } = new List<ScanMachine>();

    public virtual ScanTemplate? ScanTemplate { get; set; }

    public virtual Favorite? ScanfavKeyNavigation { get; set; }
}
