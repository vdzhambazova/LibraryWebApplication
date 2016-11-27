using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryWebApplication.Contracts;
using LibraryWebApplication.Models;
using LibraryWebApplication.Repository;

namespace LibraryWebApplication.Services
{
    public class UserService: IUserService
    {

        private IUserRepository userRepository;

        public UserService()
        {
            this.userRepository = new UserRepository();
        }

        public void Add(User entity)
        {
            this.userRepository.Add(entity);
        }

        public User GetByName(string name)
        {
            return this.userRepository.GetByName(name);
        }
    }
}