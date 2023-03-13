using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchCountsByScanMachine
{
    public int? PatchFoundOrInstalled { get; set; }

    public int? PatchMissing { get; set; }

    public int? ServicePackMissing { get; set; }

    public int MachineId { get; set; }

    public int AssessedMachineStateId { get; set; }
}
