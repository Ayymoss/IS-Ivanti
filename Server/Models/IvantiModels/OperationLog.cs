using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class OperationLog
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public byte Type { get; set; }

    public byte Status { get; set; }

    public byte[] OwnerSid { get; set; } = null!;

    public DateTime Started { get; set; }

    public DateTime? Ended { get; set; }

    public string? Summary { get; set; }

    public bool Acknowledged { get; set; }

    public virtual ICollection<OperationLogStep> OperationLogSteps { get; } = new List<OperationLogStep>();
}
