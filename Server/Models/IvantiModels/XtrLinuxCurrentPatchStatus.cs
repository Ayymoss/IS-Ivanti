using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class XtrLinuxCurrentPatchStatus
{
    public int Id { get; set; }

    public int? Machineid { get; set; }

    public string? Patch { get; set; }

    public int? Patchid { get; set; }

    public int? Assessedmachinestateid { get; set; }

    public DateTime? Scandate { get; set; }

    public int? Installstateid { get; set; }

    public int? Osid { get; set; }
}
