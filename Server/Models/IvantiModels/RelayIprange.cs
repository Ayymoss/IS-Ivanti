using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class RelayIprange
{
    public int RirId { get; set; }

    public string RirIplow { get; set; } = null!;

    public string RirIphigh { get; set; } = null!;

    public int PrimaryServerId { get; set; }

    public int? BackupServerId { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual RelayServer? BackupServer { get; set; }

    public virtual RelayServer PrimaryServer { get; set; } = null!;
}
