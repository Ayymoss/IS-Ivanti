using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class ConsoleConfiguration
{
    public Guid Id { get; set; }

    public string DbVersion { get; set; } = null!;

    public string XmlVersion { get; set; } = null!;

    public bool CreateAdminShare { get; set; }

    public byte[]? DeploymentValidationKey { get; set; }

    public int SchedulerPort { get; set; }

    public byte SchedulerType { get; set; }

    public byte SchedulerLifetime { get; set; }

    public byte[] Version { get; set; } = null!;

    public string RedHatXmlVersion { get; set; } = null!;

    public string CentOsxmlVersion { get; set; } = null!;

    public byte[]? LicenseThumbprint { get; set; }

    public virtual ConsoleIdentity IdNavigation { get; set; } = null!;
}
