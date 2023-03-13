using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinkEmailRecDeploymentTemplate
{
    public int ErecDtId { get; set; }

    public int? ErecDtemailrecId { get; set; }

    public int? ErecDtDeploytId { get; set; }

    public int? ErecDtReport { get; set; }

    public virtual DeployTemplate? ErecDtDeployt { get; set; }

    public virtual EmailRecipient? ErecDtemailrec { get; set; }
}
