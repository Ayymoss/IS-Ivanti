using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class XtrEntityProcessLog
{
    public int Entityprocesslogid { get; set; }

    public int? Batchid { get; set; }

    public DateTime? Logdate { get; set; }

    public string? Procedurename { get; set; }

    public string? Description { get; set; }
}
