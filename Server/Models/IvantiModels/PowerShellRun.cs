using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PowerShellRun
{
    public int Id { get; set; }

    public Guid ScriptUid { get; set; }

    public string ScriptName { get; set; } = null!;

    public DateTime Ended { get; set; }

    public string? TemplateName { get; set; }

    public string? ResultFolder { get; set; }

    public string? DisplayResult { get; set; }

    public int ExecutionType { get; set; }

    public int Concurrency { get; set; }

    public string? Parameters { get; set; }

    public bool Deleted { get; set; }

    public virtual Scan IdNavigation { get; set; } = null!;

    public virtual ICollection<PowerShellResult> PowerShellResults { get; } = new List<PowerShellResult>();
}
