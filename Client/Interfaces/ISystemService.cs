using RestEase;

namespace ISIvanti.Client.Interfaces;

public interface ISystemService
{
    [Get("/System")]
    Task<HttpResponseMessage> GetSystemMessage();
}
