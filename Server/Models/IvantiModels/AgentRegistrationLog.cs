using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class AgentRegistrationLog
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public Guid SelectedPolicyId { get; set; }

    public string? SelectedPolicyName { get; set; }

    public DateTime DateTime { get; set; }

    public byte[] AgentId { get; set; } = null!;

    public byte[]? IpAddress { get; set; }
}
