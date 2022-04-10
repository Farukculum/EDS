using EDS.Core.Entities;
using System.Data.Entity;

namespace EDS.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("Server = localhost; Database=EDSDB;Trusted_Connection=True;")
        {

        }
        public DbSet<User> Users { get; set; }

    }
}
