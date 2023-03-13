using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class DetectedSoftwareAsset
{
    public int Id { get; set; }

    public DateTime? InstallDate { get; set; }

    public int ScanMachineId { get; set; }

    public long? EstimatedSize { get; set; }

    public int SoftwareTitleId { get; set; }

    public int? LanguageId { get; set; }

    public virtual ScanMachine ScanMachine { get; set; } = null!;

    public virtual SoftwareTitle SoftwareTitle { get; set; } = null!;
}
