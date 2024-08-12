using System.Text.Json;
using System.Text.Json.Serialization;

namespace Bookshelf.Domains.Books
{
    public class Book
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("genre")]
        public string Genre { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        private string _readAt = "N/A";
        [JsonPropertyName("readAt")]
        [JsonConverter(typeof(LongToStringConverter))]
        public string ReadAt
        {
            get
            {
                return _readAt;
            }
            set
            {
                if (value != null)
                {
                    long.TryParse(value, out long num);
                    _readAt = DateTimeOffset.FromUnixTimeMilliseconds(num).UtcDateTime.ToString("yyyy-MM-dd");
                }
            }
        }
    }

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
