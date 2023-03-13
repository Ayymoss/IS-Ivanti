using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinuxDetectedPatchState
{
    public long Id { get; set; }

    public int AssessedMachineStateId { get; set; }

    public int? LinuxPatchId { get; set; }

    public byte LinuxInstallStateId { get; set; }

    public DateTime? InstalledOn { get; set; }
}
