using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class VirtualOwnership
{
    public int EntityId { get; set; }

    public byte UsageType { get; set; }

    public byte[] OwnerSid { get; set; } = null!;
}
