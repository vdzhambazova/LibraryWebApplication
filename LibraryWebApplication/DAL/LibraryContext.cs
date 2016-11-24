using LibraryWebApplication.Models;

namespace LibraryWebApplication
{
    using System;
    using System.Data.Entity;
    using System.Linq;

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