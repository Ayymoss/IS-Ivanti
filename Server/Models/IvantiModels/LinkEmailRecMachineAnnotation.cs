using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinkEmailRecMachineAnnotation
{
    public int ErecMaid { get; set; }

    public int ErecMaemailrecId { get; set; }

    public int ErecMammachId { get; set; }

    public bool EmoMaowner { get; set; }

    public bool EmoMaadministrator { get; set; }

    public virtual EmailRecipient ErecMaemailrec { get; set; } = null!;

    public virtual ManagedMachine ErecMammach { get; set; } = null!;
}
