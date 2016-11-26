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

        HashSet<Book> GetByNameLike(string name);
    }
}
