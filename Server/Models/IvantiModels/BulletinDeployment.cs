using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class BulletinDeployment
{
    public int BulletinId { get; set; }

    public int HypervisorId { get; set; }

    public DateTime InstallDate { get; set; }

    public string UserName { get; set; } = null!;

    public virtual Bulletin Bulletin { get; set; } = null!;

    public virtual Hypervisor Hypervisor { get; set; } = null!;
}
