using ASPnet_2_lab.Models;

namespace ASPnet_2_lab.Abstract
{
    public interface IBookRepository
    {
        public List<Book> GetBooks();
        public void AddBook(Book book);
        public void RemoveBook(Book book);
    }
}
