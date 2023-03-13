using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class ServicePack
{
    public int SpId { get; set; }

    public string SpName { get; set; } = null!;

    public virtual ICollection<LinkSpproduct> LinkSpproducts { get; } = new List<LinkSpproduct>();
}
