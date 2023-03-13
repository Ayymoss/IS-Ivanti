using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinkTemplatePatchGroup
{
    public int TpId { get; set; }

    public int TppgrpId { get; set; }

    public int TpscantId { get; set; }

    public virtual PatchGroup Tppgrp { get; set; } = null!;

    public virtual ScanTemplate Tpscant { get; set; } = null!;
}
