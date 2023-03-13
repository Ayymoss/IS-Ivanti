using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class EmailGroup
{
    public int EmailgrpId { get; set; }

    public int EmailgrpEmailrecGrpId { get; set; }

    public int EmailgrpEmailrecId { get; set; }

    public virtual EmailRecipient EmailgrpEmailrec { get; set; } = null!;

    public virtual EmailRecipient EmailgrpEmailrecGrp { get; set; } = null!;
}
