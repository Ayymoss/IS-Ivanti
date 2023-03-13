using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinuxNotification
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Posted { get; set; }

    public DateTime? Revised { get; set; }

    public string? Title { get; set; }
}
