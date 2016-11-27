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
            this.libraryContext.Books.Add(entity);
            this.libraryContext.SaveChanges();
        }

        public IQueryable<Book> GetByNameLike(string name)
        {
            var bookResultSet = libraryContext.Books.Where(b => b.Name == name);

            return bookResultSet;
        }
    }
}