using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Machine1
{
    public int Id { get; set; }

    public string? DnsName { get; set; }

    public string? Domain { get; set; }

    public int? Language { get; set; }

    public string Name { get; set; } = null!;

    public byte OperatingSystemFamilyId { get; set; }

    public byte ArchitectureId { get; set; }

    public string? Distribution { get; set; }

    public int? LinuxPlatformId { get; set; }

    public int? ProductId { get; set; }

    public string? LastKnownIp { get; set; }

    public DateTime? LastPatchAssessedOn { get; set; }

    public int? LastAssessedMachineStateId { get; set; }

    public string? LastPatchMachineGroupName { get; set; }

    public string? AssignedGroup { get; set; }

    public string? VirtualInventoryPath { get; set; }

    public string? VirtualServerName { get; set; }
}
