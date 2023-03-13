using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinuxPatchDeployment
{
    public int DeployId { get; set; }

    public long LinuxDetectedPatchStateId { get; set; }

    public DateTime InstallEndedOn { get; set; }

    public DateTime InstallStartedOn { get; set; }

    public short LinuxCompletionCodeId { get; set; }

    public int? ErrorCode { get; set; }

    public byte? LinuxErrorStepId { get; set; }
}
