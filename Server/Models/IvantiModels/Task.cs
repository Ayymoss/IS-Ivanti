using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Task
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid Version { get; set; }

    public Guid PolicyId { get; set; }

    public int Type { get; set; }

    public int IntervalType { get; set; }

    public long? InitialStartTime { get; set; }

    public int? Interval { get; set; }

    public long? TimeOfDay { get; set; }

    public short? WeekdayMask { get; set; }

    public short? MonthDay { get; set; }

    public short? RelativeDayOffset { get; set; }

    public bool AtStartUp { get; set; }

    public int? StartupOffsetMinutes { get; set; }

    public int? RandomizeOffsetMinutes { get; set; }

    public int? RelativeDayAdditionalDays { get; set; }

    public virtual Policy Policy { get; set; } = null!;

    public virtual ICollection<TaskParameter> TaskParameters { get; } = new List<TaskParameter>();

    public virtual ICollection<TaskPolicyPart> TaskPolicyParts { get; } = new List<TaskPolicyPart>();
}
