using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ISIvanti.Shared.Dtos.Proofpoint;

public class DateTimeConverter : JsonConverter<DateTime>
{
    private const string Format = "yyyy-MM-dd'T'HH:mm:ss.fffzzz";

    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var str = reader.GetString();
        return DateTime.ParseExact(str, Format, CultureInfo.InvariantCulture);
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(Format, CultureInfo.InvariantCulture));
    }
}
