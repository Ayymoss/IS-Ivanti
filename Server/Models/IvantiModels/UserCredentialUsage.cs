using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class UserCredentialUsage
{
    public int UserCredentialId { get; set; }

    public object EntityId { get; set; } = null!;

    public byte UsageType { get; set; }

    public virtual UserCredential UserCredential { get; set; } = null!;
}
