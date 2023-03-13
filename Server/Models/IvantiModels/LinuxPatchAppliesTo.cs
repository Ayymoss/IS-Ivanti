using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinuxPatchAppliesTo
{
    public int LinuxPatchId { get; set; }

    public int LinuxNotificationId { get; set; }

    public int? CveId { get; set; }

    public int LinuxPlatformId { get; set; }
}
