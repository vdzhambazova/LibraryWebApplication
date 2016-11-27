using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryWebApplication.Models;

namespace LibraryWebApplication.Contracts
{
    interface IBookRepository
    {
        void Add(Book entity);

        IQueryable<Book> GetByNameLike(string name);
    }
}
