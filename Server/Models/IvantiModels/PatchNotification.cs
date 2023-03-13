using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PatchNotification
{
    public int Id { get; set; }

    public Guid NotificationId { get; set; }

    public Guid PatchId { get; set; }

    public virtual Notification Notification { get; set; } = null!;

    public virtual Patch1 Patch { get; set; } = null!;
}
