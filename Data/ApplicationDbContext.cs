using ASP.NET_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
