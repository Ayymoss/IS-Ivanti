using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class EmailRecipient
{
    public int EmailrecId { get; set; }

    public string EmailrecName { get; set; } = null!;

    public bool EmailrecIsGroup { get; set; }

    public bool EmailrecIsHfadmin { get; set; }

    public string? EmailrecAddress { get; set; }

    public int EmailrecReserved { get; set; }

    public virtual ICollection<EmailGroup> EmailGroupEmailgrpEmailrecGrps { get; } = new List<EmailGroup>();

    public virtual ICollection<EmailGroup> EmailGroupEmailgrpEmailrecs { get; } = new List<EmailGroup>();

    public virtual ICollection<EventSubscription> EventSubscriptions { get; } = new List<EventSubscription>();

    public virtual ICollection<LinkEmailRecDeploymentTemplate> LinkEmailRecDeploymentTemplates { get; } = new List<LinkEmailRecDeploymentTemplate>();

    public virtual ICollection<LinkEmailRecMachineAnnotation> LinkEmailRecMachineAnnotations { get; } = new List<LinkEmailRecMachineAnnotation>();

    public virtual ICollection<LinkEmailRecManagedGroup> LinkEmailRecManagedGroups { get; } = new List<LinkEmailRecManagedGroup>();

    public virtual ICollection<LinkEmailRecManagedMachine> LinkEmailRecManagedMachines { get; } = new List<LinkEmailRecManagedMachine>();

    public virtual ICollection<LinkEmailRecScanTemplate> LinkEmailRecScanTemplates { get; } = new List<LinkEmailRecScanTemplate>();
}
