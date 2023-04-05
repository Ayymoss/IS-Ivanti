using MudBlazor;

namespace ISIvanti.Shared.Dtos;

public record SystemMessageDto
{
    public Severity Severity { get; set; }
    public string? Message { get; set; }
};
