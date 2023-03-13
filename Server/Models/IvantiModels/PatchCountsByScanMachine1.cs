using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchCountsByScanMachine1
{
    public int? PatchFoundOrInstalled { get; set; }

    public int? PatchMissing { get; set; }

    public int? ProductLevelMissing { get; set; }

    public int AssessedMachineStateId { get; set; }
}
