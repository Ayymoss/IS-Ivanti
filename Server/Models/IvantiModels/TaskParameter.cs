using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class TaskParameter
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public string Type { get; set; } = null!;

    public Guid TaskId { get; set; }

    public virtual Task Task { get; set; } = null!;
}
