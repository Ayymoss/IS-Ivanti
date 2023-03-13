using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class OperationLogStep
{
    public int Id { get; set; }

    public int OperationLogId { get; set; }

    public int? ParentId { get; set; }

    public short Sequence { get; set; }

    public string Name { get; set; } = null!;

    public byte Status { get; set; }

    public DateTime Started { get; set; }

    public DateTime? Ended { get; set; }

    public string? Summary { get; set; }

    public virtual ICollection<OperationLogStep> InverseParent { get; } = new List<OperationLogStep>();

    public virtual OperationLog OperationLog { get; set; } = null!;

    public virtual OperationLogStep? Parent { get; set; }
}
