using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Agent2
{
    public int? MachineId { get; set; }

    public string? AssignedPolicyName { get; set; }

    public DateTime? LastCheckIn { get; set; }

    public string? PatchDataVersion { get; set; }
}
