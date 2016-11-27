using System.Linq;
using LibraryWebApplication.Models;

namespace LibraryWebApplication.Contracts
{
    public interface IBookService
    {
        //Services work with dtos

        //service transfer entity to dto vice versa

        void CreateBook(Book book);

        IQueryable<Book> SearchForBook(string name);
    }
}