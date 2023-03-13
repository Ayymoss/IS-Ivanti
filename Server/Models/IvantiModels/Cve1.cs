using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Cve1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ExploitabilityIndex { get; set; }
}
