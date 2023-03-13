using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class CredentialAccess
{
    public int CredentialId { get; set; }

    public byte[] SubjectKeyIdentifier { get; set; } = null!;

    public virtual Credential Credential { get; set; } = null!;

    public virtual ICollection<CredentialUsage> CredentialUsages { get; } = new List<CredentialUsage>();
}
