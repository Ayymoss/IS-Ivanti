using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Acevent
{
    public long Id { get; set; }

    public int? MachineId { get; set; }

    public DateTime RaisedOn { get; set; }

    public string UserName { get; set; } = null!;

    public short EventId { get; set; }

    public string? MachineName { get; set; }

    public int ProcessId { get; set; }

    public string? CommonPath { get; set; }

    public string? ResolvedBasePath { get; set; }

    public string? ParentProcess { get; set; }

    public string? WindowsInstallerFile { get; set; }

    public string? WindowsInstallerVendor { get; set; }

    public string? ClientName { get; set; }

    public int SessionId { get; set; }

    public string? RuleName { get; set; }

    public bool AuditOnly { get; set; }

    public string? FileOwner { get; set; }

    public string? EnvironmentVariableBasePath { get; set; }

    public string? ActionTaken { get; set; }

    public string? Information { get; set; }

    public int? Line { get; set; }

    public int? Position { get; set; }

    public string? ProhibitedResource { get; set; }

    public string? RedirectedResource { get; set; }

    public string? ServiceName { get; set; }

    public string? Source { get; set; }

    public int? TimeoutPeriod { get; set; }

    public string? PrivilegeUserName { get; set; }

    public long? FileId { get; set; }

    public virtual AceventFile? File { get; set; }

    public virtual ManagedMachine? Machine { get; set; }
}
