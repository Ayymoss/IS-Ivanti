using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class ScanTemplate
{
    public int ScantId { get; set; }

    public string ScantName { get; set; } = null!;

    public string? ScantDescription { get; set; }

    public string ScantCreatorName { get; set; } = null!;

    public string? ScantFqfile { get; set; }

    public byte ScantHistoryType { get; set; }

    public bool ScantSystem { get; set; }

    public bool ScantTemp { get; set; }

    public int? ScantPatchesFilter { get; set; }

    public short? ScantPatchTypes { get; set; }

    public short? ScantPatchTypesFilter { get; set; }

    public string? ScantSystemCode { get; set; }

    public Guid PartId { get; set; }

    public byte[] Version { get; set; } = null!;

    public bool SoftwareDistribution { get; set; }

    public short SecurityPatchesMask { get; set; }

    public short NonSecurityPatchesMask { get; set; }

    public string? Path { get; set; }

    public int? MaxThreadCount { get; set; }

    public virtual ICollection<LinkEmailRecScanTemplate> LinkEmailRecScanTemplates { get; } = new List<LinkEmailRecScanTemplate>();

    public virtual ICollection<LinkTemplatePatchGroup> LinkTemplatePatchGroups { get; } = new List<LinkTemplatePatchGroup>();

    public virtual ICollection<PatchProductFilter> PatchProductFilters { get; } = new List<PatchProductFilter>();

    public virtual ICollection<Scan> Scans { get; } = new List<Scan>();
}
