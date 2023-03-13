using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinkEmailRecManagedGroup
{
    public int ErecMgid { get; set; }

    public int? ErecMgemailrecId { get; set; }

    public int? ErecMgmgId { get; set; }

    public int? ErecMgreport { get; set; }

    public virtual EmailRecipient? ErecMgemailrec { get; set; }

    public virtual ManagedGroup? ErecMgmg { get; set; }
}
