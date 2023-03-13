using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class DeploymentSeat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Type { get; set; }

    public DateTime Date { get; set; }

    public byte[] ValidationKey { get; set; } = null!;

    public byte[] LicenseThumbprint { get; set; } = null!;
}
