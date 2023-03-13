using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class AgentAttachment
{
    public int Id { get; set; }

    public int AgentId { get; set; }

    public Guid AttachmentUid { get; set; }

    public bool Acknowledged { get; set; }

    public virtual Agent Agent { get; set; } = null!;

    public virtual Attachment AttachmentU { get; set; } = null!;
}
