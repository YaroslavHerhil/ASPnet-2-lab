using ASPnet_2_lab.Abstract;
using ASPnet_2_lab.Models;

namespace ASPnet_2_lab.Repositories
{
    public class BookRepository : IBookRepository
    {
        private List<Book> _books;
        public BookRepository()
        {
            _books = new List<Book>() {
                new Book("World of Wonders", "Karl Ferdinand Jr.", "Fantasy", 1998, "Germany"),
                new Book("The Perfect Trap", "Marie 'Magnifico' Michele", "Romance", 1974, "Great Britian"),
                new Book("Tear of the Broken Hammer", "Marco Gratili", "Detective novel", 2012, "Italy")
            };
        }
        public void AddBook(Book book) => _books.Add(book);
        public List<Book> GetBooks() => _books;
        public void RemoveBook(Book book) => _books.Remove(book);
        
    }
}
