using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class ResultImportExport
{
    public Guid DocumentId { get; set; }

    public byte DocumentType { get; set; }

    public int EntityId1 { get; set; }

    public int? EntityId2 { get; set; }

    public DateTime ImportDate { get; set; }

    public DateTime? ExportDate { get; set; }
}
