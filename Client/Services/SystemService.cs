using ISIvanti.Client.Interfaces;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Utilities;
using RestEase;

namespace ISIvanti.Client.Services;

public class SystemService
{
#if DEBUG
    private const string ApiHost = "https://localhost:8123/api";
#else
    private const string ApiHost = "https://isipatch.idealstandard.com:8123/api";
#endif

    private readonly ISystemService _api;

    public SystemService()
    {
        _api = RestClient.For<ISystemService>(ApiHost);
    }
    
    public async Task<SystemMessageDto?> GetSystemMessage()
    {
        try
        {
            var response = await _api.GetSystemMessage();
            if (!response.IsSuccessStatusCode) return null; 
            return await response.DeserializeHttpResponseContentAsync<SystemMessageDto>();
        }
        catch (ApiException e)
        {
            Console.WriteLine($"API->Failed to get system message: {e.Message}");
        }

        return null;
    }
}
