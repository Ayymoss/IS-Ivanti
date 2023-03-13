using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class PowerShellScript
{
    public int Id { get; set; }

    public Guid Uid { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayVersion { get; set; } = null!;

    public string SchemaVersion { get; set; } = null!;

    public DateTime Updated { get; set; }

    public string Author { get; set; } = null!;

    public int LicenseLevel { get; set; }

    public string Category { get; set; } = null!;

    public string Purpose { get; set; } = null!;

    public string Inputs { get; set; } = null!;

    public string Outputs { get; set; } = null!;

    public int ExecutionType { get; set; }

    public bool IsInteractive { get; set; }

    public bool IsUserScript { get; set; }

    public bool IsApproved { get; set; }

    public bool IsDeleted { get; set; }

    public int UsageCount { get; set; }

    public byte[] RawScript { get; set; } = null!;

    public DateTime Created { get; set; }

    public byte[]? CreatorSid { get; set; }

    public bool ModifiesTarget { get; set; }

    public string MinEngineVersion { get; set; } = null!;

    public virtual ICollection<PowerShellTemplate> PowerShellTemplates { get; } = new List<PowerShellTemplate>();
}
