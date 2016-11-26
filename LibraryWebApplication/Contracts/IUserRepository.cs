using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LibraryWebApplication.Models;

namespace LibraryWebApplication.Contracts
{
    public interface IUserRepository
    {
        void Add(User entity);

        User GetByName(string name);
    }
}

