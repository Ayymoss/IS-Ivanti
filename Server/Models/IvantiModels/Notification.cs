using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Notification
{
    public int Id { get; set; }

    public Guid NotificationId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Posted { get; set; }

    public DateTime? Revised { get; set; }

    public string? Title { get; set; }

    public DateTime Updated { get; set; }

    public virtual ICollection<PatchNotification> PatchNotifications { get; } = new List<PatchNotification>();
}
