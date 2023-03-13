using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Policy
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public byte[] Version { get; set; } = null!;

    public bool UseDelegatePolicyUri { get; set; }

    public long CredentialSerialNumber { get; set; }

    public short LoggingLevel { get; set; }

    public int MaxLogSize { get; set; }

    public bool AllowManualScanning { get; set; }

    public bool AllowManualStop { get; set; }

    public short EngineDownloadChoice { get; set; }

    public int? EngineDistributionServerId { get; set; }

    public short CheckinChoice { get; set; }

    public int? CheckinMinutes { get; set; }

    public int? CheckinDays { get; set; }

    public DateTime? CheckinTime { get; set; }

    public int? CheckinRandomMinutes { get; set; }

    public int? ListeningPort { get; set; }

    public bool UseVendorAsBackup { get; set; }

    public Guid? AcConfigurationId { get; set; }

    public int? AcConfigurationVersionId { get; set; }

    public int? PreviousAcconfigurationVersionId { get; set; }

    public Guid ServerAgentRebootOptionsId { get; set; }

    public Guid WorkstationAgentRebootOptionsId { get; set; }

    public bool IsAgentUienabled { get; set; }

    public virtual ICollection<Agent> AgentAssignedPolicies { get; } = new List<Agent>();

    public virtual ICollection<AgentPushInstall> AgentPushInstalls { get; } = new List<AgentPushInstall>();

    public virtual ICollection<Agent> AgentReportedPolicies { get; } = new List<Agent>();

    public virtual RelayServer? EngineDistributionServer { get; set; }

    public virtual RebootOptionsPart ServerAgentRebootOptions { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; } = new List<Task>();

    public virtual RebootOptionsPart WorkstationAgentRebootOptions { get; set; } = null!;
}
