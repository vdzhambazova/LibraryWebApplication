using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryWebApplication.Contracts;
using LibraryWebApplication.Dtos;
using LibraryWebApplication.Models;
using LibraryWebApplication.Parser;
using LibraryWebApplication.Services;

namespace LibraryWebApplication.Controllers
{
    public class BookListController : Controller
    {
        private IBookService bookService;

        public BookListController()
        {
            this.bookService = new BookService();
        }

        [HttpPost]
        public ActionResult SubmitBook(BookDto bookDto, HttpPostedFileBase file)
        {

            Book book = new Book();
            //book = DTOParser.Parse(bookDto, book);
            book.CoverPicture = bookDto.CoverPicture;
            book.Genre = bookDto.Genre;
            book.Name = bookDto.Name;
            book.Author = bookDto.Author;
            book.PageCount = bookDto.PageCount;
            this.bookService.CreateBook(book);

            return View("BookList");
        }

    }
}