using System.Data.Entity;
using LibraryWebApplication.Models;

namespace LibraryWebApplication.DAL
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("name=LibraryContext")
        {
        }

        public IDbSet<Book> Books { get; set; }

        public IDbSet<User> Users { get; set; }
    }
}