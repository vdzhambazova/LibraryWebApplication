using System;
using System.Collections.Generic;
using System.Linq;
using LibraryWebApplication.Contracts;
using LibraryWebApplication.Models;
using LibraryWebApplication.Repository;

namespace LibraryWebApplication.Services
{
    public class BookService: IBookService
    {
        private BookRepository bookRepository;

        public BookService()
        {
            this.bookRepository = new BookRepository();
        }

        public void CreateBook(Book book)
        {
            bookRepository.Add(book);
        }

        public IQueryable<Book> SearchForBook(string name)
        { 
            return bookRepository.GetByNameLike(name);
        }
    }
}