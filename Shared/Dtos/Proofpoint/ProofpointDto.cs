using System.Text.Json.Serialization;

namespace ISIvanti.Shared.Dtos.Proofpoint;

public class ProofpointContextDto
{
    [JsonPropertyName("categories")]
    public List<string> Categories { get; set; }

    [JsonPropertyName("classification")]
    public string Classification { get; set; }

    [JsonPropertyName("date"), JsonConverter(typeof(DateTimeConverter))]
    public DateTime Date { get; set; }

    [JsonPropertyName("disposition")]
    public string Disposition { get; set; }

    [JsonPropertyName("region")]
    public string Region { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("userName")]
    public string UserName { get; set; }
}

public class ProofpointDto
{
    [JsonPropertyName("data")]
    public List<ProofpointContextDto> Data { get; set; }
}
