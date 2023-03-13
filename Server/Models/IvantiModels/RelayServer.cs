using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class RelayServer
{
    public int RelayId { get; set; }

    public string RelayName { get; set; } = null!;

    public string? RelayConsolePath { get; set; }

    public byte RelayClientType { get; set; }

    public string? RelayClientPath { get; set; }

    public bool RelayClientSsl { get; set; }

    public int? RelayClientHttpPort { get; set; }

    public byte[] Version { get; set; } = null!;

    public bool AutoSync { get; set; }

    public virtual ICollection<DeployTemplate> DeployTemplates { get; } = new List<DeployTemplate>();

    public virtual ICollection<Policy> Policies { get; } = new List<Policy>();

    public virtual ICollection<RelayIprange> RelayIprangeBackupServers { get; } = new List<RelayIprange>();

    public virtual ICollection<RelayIprange> RelayIprangePrimaryServers { get; } = new List<RelayIprange>();
}
