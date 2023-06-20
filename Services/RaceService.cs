using ASP.NET_MVC.Data;
using ASP.NET_MVC.Interfaces;
using ASP.NET_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_MVC.Repository
{
    public class RaceService : IRaceService
    {
        private readonly ApplicationDbContext context;

        public RaceService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Add(Race club)
        {
            context.Add(club);
            return Save();
        }

        public bool Delete(Race club)
        {
            context.Remove(club);
            return Save();
        }

        public async Task<IEnumerable<Race>> GetAllAsync()
        {
            return await context.Races.ToListAsync();
        }

        public async Task<Race> GetByIdAsync(int id)
        {
            return await context.Races.Include(r => r.Address).FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<IEnumerable<Race>> GetAllRacesByCityAsync(string city)
        {
            return await context.Races.Where(r => r.Address.City.Contains(city)).ToListAsync();
        }

        public bool Save()
        {
            var saved = context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Race race)
        {
            context.Update(race);
            return Save();
        }
    }
}
