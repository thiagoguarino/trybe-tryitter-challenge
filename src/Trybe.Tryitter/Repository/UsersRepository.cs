using Trybe.Tryitter.Models;

namespace Trybe.Tryitter.Repository
{
    public class UsersRepository
    {

        private readonly MyContext _context;

        public UsersRepository(MyContext context)
        {
            _context = context;
        }

        public void GetUser(int id)
        {
            _context.Users.Find(id);
            _context.SaveChanges();
        }

        public void AddUser (Users user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
