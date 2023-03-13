using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Credential
{
    public Guid Uid { get; set; }

    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public byte[] EncryptedPassword { get; set; } = null!;

    public byte[] OwnerSid { get; set; } = null!;

    public byte[] OwnerMachineSid { get; set; } = null!;

    public virtual ICollection<CredentialAccess> CredentialAccesses { get; } = new List<CredentialAccess>();
}
