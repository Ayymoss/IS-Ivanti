using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Product2
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string ProductLevelName { get; set; } = null!;

    public int? ProductLevelOrder { get; set; }

    public DateTime? EndOfLifeOn { get; set; }
}
