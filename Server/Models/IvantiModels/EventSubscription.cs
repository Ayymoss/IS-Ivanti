using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class EventSubscription
{
    public int Id { get; set; }

    public byte Type { get; set; }

    public int RecipientId { get; set; }

    public object EntityId { get; set; } = null!;

    public object ResponseId { get; set; } = null!;

    public virtual EmailRecipient Recipient { get; set; } = null!;
}
