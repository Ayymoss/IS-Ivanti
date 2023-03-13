using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class LinkFavoriteGroup
{
    public int LfgId { get; set; }

    public int LfgfavKey { get; set; }

    public int LfggrpKey { get; set; }

    public virtual Favorite LfgfavKeyNavigation { get; set; } = null!;

    public virtual ManagedGroup LfggrpKeyNavigation { get; set; } = null!;
}
