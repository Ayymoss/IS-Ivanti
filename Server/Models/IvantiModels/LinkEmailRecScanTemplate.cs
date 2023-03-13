using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinkEmailRecScanTemplate
{
    public int ErecStId { get; set; }

    public int? ErecStscantId { get; set; }

    public int? ErecStemailrecId { get; set; }

    public int? ErecStReport { get; set; }

    public virtual EmailRecipient? ErecStemailrec { get; set; }

    public virtual ScanTemplate? ErecStscant { get; set; }
}
