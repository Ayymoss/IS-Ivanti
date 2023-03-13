using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchType2
{
    public byte Id { get; set; }

    public string Value { get; set; } = null!;

    public string? Description { get; set; }
}
