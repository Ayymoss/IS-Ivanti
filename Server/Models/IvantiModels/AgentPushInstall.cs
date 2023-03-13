using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class AgentPushInstall
{
    public int Id { get; set; }

    public Guid? AssignedPolicyId { get; set; }

    public Guid Cookie { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public DateTime LastModified { get; set; }

    public int? MachineId { get; set; }

    public short Status { get; set; }

    public DateTime Created { get; set; }

    public string MachineName { get; set; } = null!;

    public string? AdditionalProperties { get; set; }

    public virtual Policy? AssignedPolicy { get; set; }

    public virtual ManagedMachine? Machine { get; set; }
}
