using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class ConsoleIdentity
{
    public int ConsoleId { get; set; }

    public Guid ConsoleUid { get; set; }

    public string ConsoleName { get; set; } = null!;

    public string? ConsoleDesc { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual ICollection<Agent> Agents { get; } = new List<Agent>();

    public virtual ConsoleConfiguration? ConsoleConfiguration { get; set; }

    public virtual ICollection<PatchDeployment1> PatchDeployment1s { get; } = new List<PatchDeployment1>();

    public virtual ICollection<PatchDeployment> PatchDeployments { get; } = new List<PatchDeployment>();

    public virtual ICollection<Scan> Scans { get; } = new List<Scan>();
}
