using Microsoft.EntityFrameworkCore;
using Trybe.Tryitter.Models;

namespace Trybe.Tryitter.Repository
{
    public interface IMyContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public int SaveChanges();
    }
}
