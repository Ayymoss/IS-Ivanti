using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class MachineDeploymentStatus
{
    public int Id { get; set; }

    public int MachineDeploymentId { get; set; }

    public int Code { get; set; }

    public DateTime Created { get; set; }

    public string? Message { get; set; }

    public int? NativeCode { get; set; }

    public byte OverallState { get; set; }

    public short Sequence { get; set; }

    public virtual MachineDeployment MachineDeployment { get; set; } = null!;
}
