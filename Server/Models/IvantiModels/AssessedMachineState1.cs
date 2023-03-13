using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class AssessedMachineState1
{
    public int Id { get; set; }

    public int? MachineId { get; set; }

    public int? PatchScanId { get; set; }

    public string? Ipaddress { get; set; }

    public DateTime? AssessedOn { get; set; }
}
