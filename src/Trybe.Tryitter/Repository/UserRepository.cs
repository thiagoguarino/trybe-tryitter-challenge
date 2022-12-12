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


        
    }
}
