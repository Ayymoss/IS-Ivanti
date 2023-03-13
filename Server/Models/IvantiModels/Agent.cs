using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Agent
{
    public int Id { get; set; }

    public Guid? ReportedPolicyId { get; set; }

    public long? ReportedPolicyVersion { get; set; }

    public string? ReportedPolicyName { get; set; }

    public int? MachineId { get; set; }

    public byte[] Certificate { get; set; } = null!;

    public int? ListeningPort { get; set; }

    public bool Listening { get; set; }

    public short Status { get; set; }

    public DateTime? LastCheckIn { get; set; }

    public Guid? AssignedPolicyId { get; set; }

    public DateTime LastModified { get; set; }

    public string? FrameworkVersion { get; set; }

    public string? PatchDefinitionVersion { get; set; }

    public byte[] AgentId { get; set; } = null!;

    public long PolicyAssignmentSerialNumber { get; set; }

    public DateTime? DeletedOn { get; set; }

    public Guid ConsoleUid { get; set; }

    public DateTime? PatchDefinitionDate { get; set; }

    public string? OsName { get; set; }

    public string? OsServicePack { get; set; }

    public virtual ICollection<AgentAttachment> AgentAttachments { get; } = new List<AgentAttachment>();

    public virtual Policy? AssignedPolicy { get; set; }

    public virtual ConsoleIdentity ConsoleU { get; set; } = null!;

    public virtual ManagedMachine? Machine { get; set; }

    public virtual Policy? ReportedPolicy { get; set; }
}
