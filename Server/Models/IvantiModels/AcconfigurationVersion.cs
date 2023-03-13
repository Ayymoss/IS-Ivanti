using System;
using System.Collections.Generic;
using ISIvanti.Server.Models.IvantiModels;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class AcconfigurationVersion
{
    public int Id { get; set; }

    public byte[] Blob { get; set; } = null!;

    public int ConfigurationVersion { get; set; }

    public string? Comment { get; set; }

    public string? Description { get; set; }

    public bool IsEventCollectionEnabled { get; set; }

    public DateTime LastModifiedTime { get; set; }

    public string LastModifiedUser { get; set; } = null!;

    public string SchemaVersion { get; set; } = null!;

    public Guid AcconfigurationId { get; set; }

    public byte[] RowVersion { get; set; } = null!;

    public virtual Acconfiguration Acconfiguration { get; set; } = null!;
}
