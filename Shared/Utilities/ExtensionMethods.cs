using System.Net;
using System.Text.Json;
using Humanizer;
using Serilog.Events;

namespace ISIvanti.Shared.Utilities;

public static class ExtensionMethods
{
    public static async Task<TResponse?> DeserializeHttpResponseContentAsync<TResponse>(this HttpResponseMessage response) where TResponse : class
    {
        var jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        if (!response.IsSuccessStatusCode) return null;
        var json = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"{typeof(TResponse)}: {response.Headers.Server} {response.StatusCode} {response.ReasonPhrase} {json}");
        return string.IsNullOrEmpty(json) ? null : JsonSerializer.Deserialize<TResponse>(json, jsonSerializerOptions);
    }

    public static string StatusCodeToString(this HttpStatusCode statusCode)
    {
        return statusCode switch
        {
            HttpStatusCode.OK => "Success",
            HttpStatusCode.InternalServerError => "Unreachable", // Unreachable reply for Agent Task
            HttpStatusCode.BadRequest => "Unreachable", // Unreachable reply for Check-in Task
            HttpStatusCode.PartialContent => string.Empty, // Placeholder
            _ => statusCode.Humanize()
        };
    }

    public static LogEventLevel StringToLogLevel(this string logLevel)
    {
        return logLevel switch
        {
            "Debug" => LogEventLevel.Debug,
            "Warning" => LogEventLevel.Warning,
            "Information" => LogEventLevel.Information,
            _ => LogEventLevel.Information
        };
    }
}
