using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class EventViewerView
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? CustomTimeBegin { get; set; }

    public DateTime? CustomTimeEnd { get; set; }

    public string EventTypeIds { get; set; } = null!;

    public byte Category { get; set; }

    public bool SummaryOnly { get; set; }

    public byte FixedTimePeriod { get; set; }

    public string? MachineName { get; set; }

    public string? UserName { get; set; }

    public byte[]? GridLayoutDataBlob { get; set; }

    public byte[] Version { get; set; } = null!;
}
