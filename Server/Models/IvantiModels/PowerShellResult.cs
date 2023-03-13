using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PowerShellResult
{
    public int Id { get; set; }

    public int PowerShellRunId { get; set; }

    public int MachineId { get; set; }

    public string? MachineGroupName { get; set; }

    public string? ResultFolder { get; set; }

    public DateTime Ended { get; set; }

    public string DisplayResult { get; set; } = null!;

    public virtual ManagedMachine Machine { get; set; } = null!;

    public virtual PowerShellRun PowerShellRun { get; set; } = null!;
}
