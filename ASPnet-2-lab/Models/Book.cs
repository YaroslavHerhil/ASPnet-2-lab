using System.Security.Cryptography.X509Certificates;

namespace ASPnet_2_lab.Models
{
    public class Book
    {
        public string Title { get; set; }

        public string AuthorFullName { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }

        public string CountryOfOrigin { get; set; }

        public Book() { }

        public Book(string title, string authorFullName, string genre, int releaseYear, string countryOfOrigin)
        {
            Title = title;
            AuthorFullName = authorFullName;
            Genre = genre;
            ReleaseYear = releaseYear;
            CountryOfOrigin = countryOfOrigin;
        }

        public override string ToString()
        {
            return $"{Title}/{AuthorFullName}/{Genre}/{ReleaseYear}/{CountryOfOrigin}/";
        }
    }
}
