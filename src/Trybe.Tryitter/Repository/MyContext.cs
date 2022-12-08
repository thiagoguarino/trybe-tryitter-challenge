using Microsoft.EntityFrameworkCore;
using Trybe.Tryitter.Models;

namespace Trybe.Tryitter.Repository
{
    public class MyContext : DbContext
    {
         public DbSet<Users> Users { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //var connectionString = Environment.GetEnvironmentVariable("DOTNET_CONNECTION_STRING");

                optionsBuilder.UseSqlServer(@"
                Server=localhost;
                Database=master;
                ");
            }
        }
    }
}
