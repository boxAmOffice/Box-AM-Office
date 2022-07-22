using boxAmOffice.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Box_AM_Ofice.Models.Interfaces
{
    public interface ICinema
    {
        Task<List<Cinema>> GetAll();
        Task<Cinema> GetById(int id);
        Task AddCinema (Cinema cinema);
        Task<Cinema> Update(int id, Cinema newCinema);
        Task RemoveCinema (int id);
        Task<List<Movie>> GetMovies(int cinemaId);
    }
}
