using Trybe.Tryitter.Models;
using Microsoft.EntityFrameworkCore;

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

        public User? GetUserById(int id)
        {
            var current = _context.Users.First(c => c.Id == id);
            if (current == null)
            {
                return null;
            }
            return current;
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
           

        }

        public void UpdateUser(User user)
        {
            _context.Users.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public bool DeleteUser(int postId)
        {
            var current = _context.Users.Find(postId);
            if (current == null) 
            {
                return false;
            }
            _context.Users.Remove(current);
            _context.SaveChanges();
            return true;
        }

        public User? GetUserAuth(User user)
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
