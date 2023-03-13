using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Machine
{
    public int Id { get; set; }

    public string? DnsName { get; set; }

    public string? Domain { get; set; }

    public int? Language { get; set; }

    public string Name { get; set; } = null!;

    public int? ProductId { get; set; }

    public string? LastKnownIp { get; set; }

    public DateTime? LastPatchAssessedOn { get; set; }

    public int? LastAssessedMachineStateId { get; set; }

    public string? LastPatchMachineGroupName { get; set; }
}
