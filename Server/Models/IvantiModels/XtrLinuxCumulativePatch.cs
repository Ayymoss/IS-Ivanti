﻿using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class XtrLinuxCumulativePatch
{
    public int Id { get; set; }

    public string? Patchcode { get; set; }

    public int? Active { get; set; }
}
