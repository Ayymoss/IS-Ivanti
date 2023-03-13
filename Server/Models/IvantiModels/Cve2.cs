using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Cve2
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal? Cvssv2 { get; set; }

    public decimal? Cvssv3 { get; set; }
}
