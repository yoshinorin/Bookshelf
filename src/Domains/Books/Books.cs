using System.Text.Json.Serialization;
using bookshelf.Utils.Json;

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

}
