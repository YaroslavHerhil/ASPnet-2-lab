using ASPnet_2_lab.Models;

namespace ASPnet_2_lab.Abstract
{
    public interface IBookService
    {
        public void WriteBookToFile(Book book, string file);
        public List<Book> ReadBooksFromFile(string file, int size, string separator = "/");

        public Book GetBookByTitle(string title);
        public List<Book> GetAllBooks();
        public void AddBook(Book book);
        public void RemoveBook(Book book);
        public void WriteAllBooksToFile(string file);
    }
}
