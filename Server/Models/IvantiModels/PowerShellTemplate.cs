using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PowerShellTemplate
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public byte[] OwnerSid { get; set; } = null!;

    public string? Description { get; set; }

    public int ScriptId { get; set; }

    public int ExecutionType { get; set; }

    public int Concurrency { get; set; }

    public string? Parameters { get; set; }

    public byte[] Version { get; set; } = null!;

    public bool UseSsl { get; set; }

    public int Port { get; set; }

    public virtual PowerShellScript Script { get; set; } = null!;
}
