using ASPnet_2_lab.Abstract;
using ASPnet_2_lab.Models;
using ASPnet_2_lab.Repositories;
using System;
using System.Globalization;
using System.Xml.Linq;

namespace ASPnet_2_lab.Services
{
    public class BookService : IBookService
    {
        public readonly IBookRepository _repository;

        public BookService()
        {
            _repository = new BookRepository();
        }
        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public void AddBook(Book book) => _repository.AddBook(book);

        public List<Book> GetAllBooks() => _repository.GetBooks();

        public Book GetBookByTitle(string title) => _repository.GetBooks().FirstOrDefault(b => b.Title == title);

        private string ReadUntil(StreamReader sr ,string separator)
        {
            string output = "";
            while (sr.Peek() >= 0)
            {
                string nextSymbol = ((char)sr.Read()).ToString();
                if (nextSymbol == separator)
                {
                    break;
                }
                output += nextSymbol;
            }
            return output;
        }

        public List<Book> ReadBooksFromFile(string file, int size, string separator = "/")
        {
            var listOBooks = new List<Book>();
            using (StreamReader sr = new StreamReader(file))
            {
                for (int i = 0; i < size; i++)
                {
                    string title = ReadUntil(sr, separator);

                    string author = ReadUntil(sr, separator);
                    string genre = ReadUntil(sr, separator);
                    string year = ReadUntil(sr, separator);
                    string country = ReadUntil(sr, separator);
                    listOBooks.Add(new Book(title, author, genre, int.Parse(year), country));
                }
            }
            return listOBooks;
        }

        public void RemoveBook(Book book) => _repository.RemoveBook(book);

        public void WriteAllBooksToFile(string file)
        {
            
            using (StreamWriter sw = new StreamWriter(file))
            {
                foreach (Book book in _repository.GetBooks())
                {
                    sw.WriteLine(book);
                }
            }
        }

        public void WriteBookToFile(Book book, string file)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(book);
            }
        }
    }
}
