﻿using System.Net;
using System.Text.Json;

namespace ISIvanti.Shared.Utilities;

public static class ExtensionMethods
{
    public static async Task<T?> DeserializeHttpResponseContentAsync<T>(this HttpResponseMessage response) where T : class
    {
        var jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        
        if (!response.IsSuccessStatusCode) return null;
        var json = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(json, jsonSerializerOptions);
    }

    public static string StatusCodeToString(this HttpStatusCode statusCode)
    {
        return statusCode switch
        {
            HttpStatusCode.InternalServerError => "Error",
            _ => "Unknown"
        };
    }
}