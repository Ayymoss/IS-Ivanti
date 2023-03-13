using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Attachment
{
    public int Id { get; set; }

    public Guid Uid { get; set; }

    public int Type { get; set; }

    public byte[] AttachmentBlob { get; set; } = null!;

    public DateTime Created { get; set; }

    public virtual ICollection<AgentAttachment> AgentAttachments { get; } = new List<AgentAttachment>();
}
