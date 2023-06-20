using ASP.NET_MVC.Data;
using ASP.NET_MVC.Interfaces;
using ASP.NET_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_MVC.Repository
{
    public class ClubService : IClubService
    {
        private readonly ApplicationDbContext context;

        public ClubService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Add(Club club)
        {
            context.Add(club);
            return Save();
        }

        public bool Delete(Club club)
        {
            context.Remove(club);
            return Save();
        }

        public async Task<IEnumerable<Club>> GetAllAsync()
        {
            return await context.Clubs.ToListAsync();
        }

        public async Task<Club> GetByIdAsync(int id)
        {
            return await context.Clubs.Include(c => c.Address).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Club>> GetClubByCityAsync(string city)
        {
            return await context.Clubs.Where(c => c.Address.City.Contains(city)).ToListAsync();
        }

        public bool Save()
        {
            var saved = context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Club club)
        {
            context.Update(club);
            return Save();
        }
    }
}
