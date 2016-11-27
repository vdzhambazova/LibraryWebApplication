using LibraryWebApplication.Models;

namespace LibraryWebApplication.Dtos
{
    public class BookDto
    { 
        public string Name { get; set; }

        public string Author { get; set; }

        public byte[] CoverPicture { get; set; }

        public Genre Genre { get; set; }
    }
}