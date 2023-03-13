using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinkEmailRecManagedMachine
{
    public int ErecmmId { get; set; }

    public int? ErecmmemailrecId { get; set; }

    public int? ErecmmMmachId { get; set; }

    public int? ErecmmReport { get; set; }

    public virtual ManagedMachine? ErecmmMmach { get; set; }

    public virtual EmailRecipient? Erecmmemailrec { get; set; }
}
