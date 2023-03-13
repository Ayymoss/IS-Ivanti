using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchDeployment
{
    public int PdId { get; set; }

    public DateTime PdDateTime { get; set; }

    public int? PdInstallType { get; set; }

    public DateTime? PdInstallDate { get; set; }

    public string? PdStatus { get; set; }

    public string? PdUserName { get; set; }

    public int? PdDeployTemplateId { get; set; }

    public string? PdName { get; set; }

    public bool PdShutdownSql { get; set; }

    public bool PdShutdownIis { get; set; }

    public bool PdRemoveTempFiles { get; set; }

    public bool PdShowDialog { get; set; }

    public string? PdDialogTitle { get; set; }

    public string? PdDialogDescription { get; set; }

    public bool PdShutdownExchange { get; set; }

    public short? PdRebootBeforeWhen { get; set; }

    public short? PdRebootBeforeSafeOptions { get; set; }

    public DateTime? PdRebootBeforeLatestTime { get; set; }

    public short? PdRebootBeforeInitialMinutes { get; set; }

    public short? PdRebootBeforeExtendMinutes { get; set; }

    public short? PdRebootBeforeMaxMinutes { get; set; }

    public short? PdRebootBeforeDlgSeconds { get; set; }

    public short? PdRebootAfterWhen { get; set; }

    public short? PdRebootAfterSafeOptions { get; set; }

    public DateTime? PdRebootAfterEarliestTime { get; set; }

    public DateTime? PdRebootAfterLatestTime { get; set; }

    public short? PdRebootAfterInitialMinutes { get; set; }

    public short? PdRebootAfterExtendMinutes { get; set; }

    public short? PdRebootAfterMaxMinutes { get; set; }

    public short? PdRebootAfterDlgSeconds { get; set; }

    public bool PdPptmessages { get; set; }

    public bool PdReportsEmailed { get; set; }

    public int PdConsoleId { get; set; }

    public Guid Id { get; set; }

    public bool IsUninstall { get; set; }

    public byte StageType { get; set; }

    public DateTime? StageDate { get; set; }

    public byte SourceType { get; set; }

    public string? DeployTemplateName { get; set; }

    public virtual ICollection<LinkDeploymentScanItem> LinkDeploymentScanItems { get; } = new List<LinkDeploymentScanItem>();

    public virtual ICollection<MachineDeployment> MachineDeployments { get; } = new List<MachineDeployment>();

    public virtual ConsoleIdentity PdConsole { get; set; } = null!;

    public virtual DeployTemplate? PdDeployTemplate { get; set; }
}
