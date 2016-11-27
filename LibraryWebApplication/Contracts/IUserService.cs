using LibraryWebApplication.Models;

namespace LibraryWebApplication.Contracts
{
    public interface IUserService
    {
        void Add(User entity);

        User GetByName(string name);
    }
}