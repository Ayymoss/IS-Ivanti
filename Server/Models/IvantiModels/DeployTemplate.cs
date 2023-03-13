using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class DeployTemplate
{
    public int DeploytId { get; set; }

    public string DeploytName { get; set; } = null!;

    public string? DeploytDescription { get; set; }

    public bool DeploytShutdownSql { get; set; }

    public bool DeploytShutdownIis { get; set; }

    public bool DeploytRemoveTempFiles { get; set; }

    public bool DeploytSystem { get; set; }

    public string? DeploytCreatorName { get; set; }

    public bool DeploytShowDialog { get; set; }

    public string? DeploytDialogTitle { get; set; }

    public string? DeploytDialogDescription { get; set; }

    public bool DeploytShutdownExchange { get; set; }

    public short? DeploytRebootBeforeWhen { get; set; }

    public short? DeploytRebootBeforeSafeOptions { get; set; }

    public DateTime? DeploytRebootBeforeLatestTime { get; set; }

    public short? DeploytRebootBeforeInitialMinutes { get; set; }

    public short? DeploytRebootBeforeExtendMinutes { get; set; }

    public short? DeploytRebootBeforeMaxMinutes { get; set; }

    public short? DeploytRebootBeforeDlgSeconds { get; set; }

    public short? DeploytRebootAfterWhen { get; set; }

    public short? DeploytRebootAfterSafeOptions { get; set; }

    public DateTime? DeploytRebootAfterEarliestTime { get; set; }

    public DateTime? DeploytRebootAfterLatestTime { get; set; }

    public short? DeploytRebootAfterInitialMinutes { get; set; }

    public short? DeploytRebootAfterExtendMinutes { get; set; }

    public short? DeploytRebootAfterMaxMinutes { get; set; }

    public short? DeploytRebootAfterDlgSeconds { get; set; }

    public bool DeploytPptmessages { get; set; }

    public bool DeploytUseRelayServers { get; set; }

    public bool DeploytUseDefaultRs { get; set; }

    public int? DeploytDefaultRelayId { get; set; }

    public bool DeploytUseVendorSite { get; set; }

    public int? DeploytRelayErrorRetry { get; set; }

    public bool DeploytRsstaggerStarts { get; set; }

    public int? DeploytRssstartupMinutes { get; set; }

    public int? DeploytTimeTillEmailNotify { get; set; }

    public Guid PartId { get; set; }

    public short TargetPowerState { get; set; }

    public bool TakePreDeploymentSnapshot { get; set; }

    public bool TakePostDeploymentSnapshot { get; set; }

    public byte? MaxSnapshotCount { get; set; }

    public byte? OldestSnapshotInDays { get; set; }

    public byte[] Version { get; set; } = null!;

    public bool UseDistributionServerByIprange { get; set; }

    public string? Path { get; set; }

    public virtual ICollection<CustomAction> CustomActions { get; } = new List<CustomAction>();

    public virtual RelayServer? DeploytDefaultRelay { get; set; }

    public virtual ICollection<LinkEmailRecDeploymentTemplate> LinkEmailRecDeploymentTemplates { get; } = new List<LinkEmailRecDeploymentTemplate>();

    public virtual ICollection<PatchDeployment> PatchDeployments { get; } = new List<PatchDeployment>();
}
