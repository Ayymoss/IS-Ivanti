using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Cve
{
    public int Id { get; set; }

    public int? ExploitabilityIndexId { get; set; }

    public string CveId { get; set; } = null!;

    public DateTime? LastRevisedOn { get; set; }

    public decimal? CvssV2 { get; set; }

    public decimal? CvssV3 { get; set; }

    public virtual ICollection<PatchCve> PatchCves { get; } = new List<PatchCve>();
}
