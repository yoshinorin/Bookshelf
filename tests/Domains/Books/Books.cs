using System.Text.Json;

namespace Tests.Dominas.Books
{
    public class Books
    {
        [Fact]
        public void JsonCanDeserializeToBooks()
        {
            var assetPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestResources", "books.json");
            var books = JsonSerializer.Deserialize<List<Bookshelf.Domains.Books.Book>>(File.ReadAllText(assetPath));

            Assert.True(books.Count == 2);
            var book1 = books.First();

            Assert.Equal(book1.Title, "Book Title 1");
            Assert.Equal(book1.Genre, "Art");
            Assert.Equal(book1.ReadAt, "2024-08-06");
            Assert.Equal(book1.Url, "https://example.com/4908686149");
            Assert.Equal(book1.ImageUrl, "https://example.com/image/4908686149");            
        }
    }
}
