using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PowerShellModule
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Version { get; set; } = null!;

    public long Size { get; set; }

    public string DownloadUrl { get; set; } = null!;

    public DateTime Updated { get; set; }
}
