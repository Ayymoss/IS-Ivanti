using ISIvanti.Server.Models.LocalModels;
using ISIvanti.Server.Services;
using ISIvanti.Server.Services.Ivanti;
using ISIvanti.Shared.Dtos;

namespace ISIvanti.Server.Models;

public class BackgroundJob
{
    public EFJob Job { get; set; } = null!;
    public ActionDto Action { get; set; } = null!;
    public IvantiApi Api { get; set; } = null!;
}
