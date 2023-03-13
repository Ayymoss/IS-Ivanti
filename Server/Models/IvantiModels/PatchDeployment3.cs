using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchDeployment3
{
    public int DeployId { get; set; }

    public long DetectedPatchStateId { get; set; }

    public DateTime? DeployScheduledOn { get; set; }

    public DateTime? DeployStartedOn { get; set; }

    public DateTime? DeployEndOn { get; set; }

    public short DeployStateId { get; set; }

    public int? ResultCode { get; set; }
}
