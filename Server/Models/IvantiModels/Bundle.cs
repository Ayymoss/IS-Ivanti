using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Bundle
{
    public int Id { get; set; }

    public string BundleId { get; set; } = null!;

    public string BundleVersion { get; set; } = null!;

    public bool HostDaemonRestart { get; set; }

    public bool MaintenanceMode { get; set; }

    public string Name { get; set; } = null!;

    public string? Platform { get; set; }

    public bool RebootRequired { get; set; }

    public string? Url { get; set; }

    public long Size { get; set; }

    public string? Vendor { get; set; }

    public virtual ICollection<DetectedBundle> DetectedBundleInstalledBundles { get; } = new List<DetectedBundle>();

    public virtual ICollection<DetectedBundle> DetectedBundleNewestBundles { get; } = new List<DetectedBundle>();

    public virtual ICollection<DetectedBundle> DetectedBundleRequiredBundles { get; } = new List<DetectedBundle>();
}
