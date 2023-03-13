using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class Favorite
{
    public int FavKey { get; set; }

    public string FavName { get; set; } = null!;

    public string? FavDescription { get; set; }

    public DateTime FavCreateDate { get; set; }

    public DateTime FavUpdateDate { get; set; }

    public string? FavCreatorName { get; set; }

    public bool FavTemp { get; set; }

    public int FavType { get; set; }

    public int TemplateId { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual ICollection<LinkFavoriteGroup> LinkFavoriteGroups { get; } = new List<LinkFavoriteGroup>();

    public virtual ICollection<Scan> Scans { get; } = new List<Scan>();
}
