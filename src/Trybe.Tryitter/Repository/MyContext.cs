using Microsoft.EntityFrameworkCore;
using Trybe.Tryitter.Models;

namespace Trybe.Tryitter.Repository
{
    public class MyContext : DbContext, IMyContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base (options) { }
        public MyContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=trybe_tryitter;User=SA;Password=Password12!");
            }
        }
    }
}
