using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PropertyCollection
{
    public Guid GroupId { get; set; }

    public Guid CollectionId { get; set; }

    public string Name { get; set; } = null!;

    public object Value { get; set; } = null!;
}
