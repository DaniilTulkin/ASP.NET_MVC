using ASP.NET_MVC.Models;

namespace ASP.NET_MVC.Interfaces
{
    public interface IClubService
    {
        Task<IEnumerable<Club>> GetAllAsync();
        Task<Club> GetByIdAsync(int id);
        Task<IEnumerable<Club>> GetClubByCityAsync(string city);
        bool Add(Club club);
        bool Update(Club club);
        bool Delete(Club club);
        bool Save();
    }
}
