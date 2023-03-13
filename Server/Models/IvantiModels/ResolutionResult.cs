using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class ResolutionResult
{
    public int Id { get; set; }

    public Guid Uid { get; set; }

    public int Code { get; set; }

    public DateTime Created { get; set; }

    public string DiscoveryFilterName { get; set; } = null!;

    public int DiscoveryFilterType { get; set; }

    public string? MachineGroupName { get; set; }

    public string? Message { get; set; }

    public int? NativeCode { get; set; }

    public int ScanId { get; set; }

    public virtual Scan Scan { get; set; } = null!;
}
