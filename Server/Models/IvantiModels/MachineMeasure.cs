using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class MachineMeasure
{
    public int MachineId { get; set; }

    public int? InstalledPatches { get; set; }

    public int? MissingPatches { get; set; }

    public int? MissingServicePacks { get; set; }

    public string? LastMachineGroupName { get; set; }

    public int? EndOfLifeProducts { get; set; }

    public DateTime? AcEventsLastUploaded { get; set; }

    public virtual ManagedMachine Machine { get; set; } = null!;
}
