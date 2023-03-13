using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class AceventFile
{
    public long Id { get; set; }

    public byte[] FileHash { get; set; } = null!;

    public long? Size { get; set; }

    public string? ProductVersion { get; set; }

    public string? FileVersion { get; set; }

    public string? ProductName { get; set; }

    public string? CompanyName { get; set; }

    public string? Vendor { get; set; }

    public string? FileDescription { get; set; }

    public virtual ICollection<Acevent> Acevents { get; } = new List<Acevent>();
}
