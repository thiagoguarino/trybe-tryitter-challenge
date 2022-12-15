using Trybe.Tryitter.Models;

namespace Trybe.Tryitter.Repository
{
    public interface IUserRepository
    {
        bool AddUser (User user);
        User GetUserAuth (User user);
        public User? GetUserById(int id);
        IEnumerable<User> GetUsers();
        public void UpdateUser(User user);
        public bool DeleteUser(int id);
    }
}
