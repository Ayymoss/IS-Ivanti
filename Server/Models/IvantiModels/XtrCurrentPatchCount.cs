using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class XtrCurrentPatchCount
{
    public int? Machineid { get; set; }

    public string? Severity { get; set; }

    public string? Patchgroup { get; set; }

    public int? Installedcnt { get; set; }

    public int? Notinstalledcnt { get; set; }

    public int? Missingspcnt { get; set; }

    public int? Informationalcnt { get; set; }
}
