using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class CredentialUsage
{
    public int CredentialId { get; set; }

    public byte[] SubjectKeyIdentifier { get; set; } = null!;

    public byte UsageType { get; set; }

    public object EntityId { get; set; } = null!;

    public virtual CredentialAccess CredentialAccess { get; set; } = null!;
}
