using System.ComponentModel.DataAnnotations;

namespace ISIvanti.Server.Models.LocalModels;

public class EFStatistic
{
    [Key] public int Id { get; set; }
    public required DateTimeOffset Submitted { get; set; }
    public required string Type { get; set; }
    public int Count { get; set; }
}
