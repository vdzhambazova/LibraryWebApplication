using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryWebApplication.Contracts;
using LibraryWebApplication.DAL;
using LibraryWebApplication.Models;

namespace LibraryWebApplication.Repository
{
    public class BookRepository : IBookRepository
    {
        private LibraryContext libraryContext;

        public BookRepository()
        {
            this.libraryContext = new LibraryContext();
        }

        public void Add(Book entity)
        {
            throw new NotImplementedException();
        }

        public HashSet<Book> GetByNameLike(string name)
        {
            throw new NotImplementedException();
        }
    }
}