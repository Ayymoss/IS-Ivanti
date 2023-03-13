using System;
using System.Collections.Generic;

namespace ISIvanti.Server.Models.IvantiModels;

public partial class RoleUser
{
    public int Id { get; set; }

    public string Domain { get; set; } = null!;

    public string Username { get; set; } = null!;

    public int Type { get; set; }
}
