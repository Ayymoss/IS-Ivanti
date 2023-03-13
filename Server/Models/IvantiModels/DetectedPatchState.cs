using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class DetectedPatchState
{
    public long Id { get; set; }

    public int AssessedMachineStateId { get; set; }

    public int PatchId { get; set; }

    public int ProductId { get; set; }

    public DateTime? InstalledOn { get; set; }

    public short? InstallStateId { get; set; }
}
