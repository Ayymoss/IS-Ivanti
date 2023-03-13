using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class XtrEntityProcessErrorLog
{
    public int Entityprocesserrorlogid { get; set; }

    public int? Batchid { get; set; }

    public DateTime? Logdate { get; set; }

    public string? Entityname { get; set; }

    public int? Errornumber { get; set; }

    public int? Errorseverity { get; set; }

    public int? Errorstate { get; set; }

    public string? Errorprocedure { get; set; }

    public int? Errorline { get; set; }

    public string? Errormessage { get; set; }
}
