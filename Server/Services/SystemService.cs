using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using ISIvanti.Server.Interfaces;
using ISIvanti.Shared.Dtos;

namespace ISIvanti.Server.Services;

public class SystemService : ISystemService
{
    public async Task<SystemMessageDto?> GetSystemMessage()
    {
        var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var filePath = Path.Join(directory, "Configuration", "_SystemMessage.json");
        if (!File.Exists(filePath)) return null;
        var file = await File.ReadAllTextAsync(filePath);
        var options = new JsonSerializerOptions
        {
            Converters = {new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)}
        };
        var message = JsonSerializer.Deserialize<SystemMessageDto>(file, options);
        return message;
    }
}
