using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class UserCredential
{
    public int Id { get; set; }

    public Guid Uid { get; set; }

    public Guid? ParentUid { get; set; }

    public string Name { get; set; } = null!;

    public byte[] UserName { get; set; } = null!;

    public byte[] Password { get; set; } = null!;

    public byte[] OwnerSid { get; set; } = null!;

    public byte[] OwnerMachineSid { get; set; } = null!;

    public virtual ICollection<UserCredential> InverseParentU { get; } = new List<UserCredential>();

    public virtual UserCredential? ParentU { get; set; }

    public virtual ICollection<UserCredentialUsage> UserCredentialUsages { get; } = new List<UserCredentialUsage>();
}
