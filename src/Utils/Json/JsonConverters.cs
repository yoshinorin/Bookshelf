using System.Text.Json.Serialization;
using System.Text.Json;

namespace bookshelf.Utils.Json
{
    public class LongToStringConverter : JsonConverter<string>
    {
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.TokenType == JsonTokenType.Number ? reader.GetInt64().ToString() : reader.GetString();
        }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            if (long.TryParse(value, out long num))
            {
                writer.WriteNumberValue(num);
            }
            else
            {
                writer.WriteStringValue(value);
            }
        }
    }
}
