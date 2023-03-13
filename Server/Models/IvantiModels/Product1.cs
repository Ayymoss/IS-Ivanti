using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Product1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string ServicePackName { get; set; } = null!;

    public int? ServicePackOrder { get; set; }

    public DateTime? EndOfLifeOn { get; set; }
}
