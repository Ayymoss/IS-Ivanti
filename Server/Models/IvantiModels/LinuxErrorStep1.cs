﻿using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinuxErrorStep1
{
    public short Id { get; set; }

    public string Value { get; set; } = null!;

    public string Description { get; set; } = null!;
}
