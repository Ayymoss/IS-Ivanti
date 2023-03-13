using ISIvanti.Server.Models.IvantiModels;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Acconfiguration
{
    public int Id { get; set; }

    public Guid Uid { get; set; }

    public string Name { get; set; } = null!;

    public byte[] Version { get; set; } = null!;

    public virtual ICollection<AcconfigurationVersion> AcconfigurationVersions { get; } = new List<AcconfigurationVersion>();
}
