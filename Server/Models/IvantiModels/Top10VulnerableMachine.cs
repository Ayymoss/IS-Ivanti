using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Top10VulnerableMachine
{
    public string MachineName { get; set; } = null!;

    public int MissingPatches { get; set; }

    public int MissingServicePacks { get; set; }
}
