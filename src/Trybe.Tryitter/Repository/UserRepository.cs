using Trybe.Tryitter.Models;

namespace Trybe.Tryitter.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly IMyContext _context;

        public UserRepository(IMyContext context)
        {
            _context = context;
        }
        public bool AddUser(User user) 
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }

        public User? GetUser(User user)
        {
            var current = _context.Users.First(c => c.Name == user.Name && c.Password == user.Password);
            if (current == null)
            {
                return null;
            }
            return current;
        }


        
    }
}
