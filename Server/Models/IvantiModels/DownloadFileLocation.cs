using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class DownloadFileLocation
{
    public int DflId { get; set; }

    public int DflLocationEnum { get; set; }

    public string? DflCustomLocation { get; set; }

    public int? DflDistServerId { get; set; }

    public int DflFileType { get; set; }

    public byte[] Version { get; set; } = null!;
}
