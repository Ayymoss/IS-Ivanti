using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchTrace
{
    public int Id { get; set; }

    public bool IsFile { get; set; }

    public string? Name { get; set; }

    public string Path { get; set; } = null!;

    public virtual ICollection<ScanItem> ScanItems { get; } = new List<ScanItem>();
}
