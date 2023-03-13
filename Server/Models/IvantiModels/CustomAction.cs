using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class CustomAction
{
    public int CaActionId { get; set; }

    public int CaDeployTemplateId { get; set; }

    public string? CaSfn { get; set; }

    public int CaActionType { get; set; }

    public string CaCommand { get; set; } = null!;

    public byte[] Version { get; set; } = null!;

    public virtual DeployTemplate CaDeployTemplate { get; set; } = null!;
}
