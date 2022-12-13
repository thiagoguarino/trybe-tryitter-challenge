using Trybe.Tryitter.Models;

namespace Trybe.Tryitter.Repository
{
    public interface IUserRepository
    {
        bool AddUser (User user);
        User GetUser (User user);
    }
}
