using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Osdistribution
{
    public int? Occurrences { get; set; }

    public string Name { get; set; } = null!;

    public string? ProductLevel { get; set; }
}
