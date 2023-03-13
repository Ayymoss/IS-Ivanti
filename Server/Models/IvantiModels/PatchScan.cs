using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchScan
{
    public int Id { get; set; }

    public string ConsoleName { get; set; } = null!;

    public DateTime? DefinitionDate { get; set; }

    public string? DefinitionVersion { get; set; }

    public DateTime EndedOn { get; set; }

    public int IsScanCompleted { get; set; }

    public string? Name { get; set; }

    public DateTime StartedOn { get; set; }

    public string? ScanTemplateName { get; set; }

    public string? User { get; set; }

    public byte SourceType { get; set; }
}
