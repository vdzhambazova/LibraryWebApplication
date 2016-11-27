using System;
using System.Linq;
using LibraryWebApplication.Contracts;
using LibraryWebApplication.DAL;
using LibraryWebApplication.Models;

namespace LibraryWebApplication.Repository
{
    public class UserRepository : IUserRepository
    {
        private LibraryContext libraryContext;

        public UserRepository()
        {
            this.libraryContext = new LibraryContext();
        }

        public void Add(User entity)
        {
            this.libraryContext.Users.Add(entity);
            this.libraryContext.SaveChanges();
        }

        public User GetByName(string name)
        {
            User user = this.libraryContext.Users
                .First(u => u.Username == name);

            return user;
        }
    }
}
