using boxAmOffice.Models;
using Box_AM_Ofice.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Box_AM_Ofice.Models.Services
{
    public class CinemaService : ICinema
    {
        private readonly AppDbContext _context;
        public CinemaService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddCinema (Cinema cinema)
        {
            _context.Cinemas.Add(cinema);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Cinema>> GetAll()
        {
            var result = await _context.Cinemas.ToListAsync();
            return result;
        }

        public async Task<Cinema> GetById(int id)
        {
            var result = await _context.Cinemas.FirstOrDefaultAsync(n => n.Id == id);
            return result;

        }

        public async  Task RemoveCinema (int id)
        {
            var result = await _context.Cinemas.FirstOrDefaultAsync(n => n.Id == id);
            _context.Cinemas.Remove(result);
            await _context.SaveChangesAsync();
        }

        public  async Task<Cinema> Update(int id, Cinema newCinema)
        {
            _context.Update(newCinema);
            await _context.SaveChangesAsync();
            return newCinema;
        }
    }
}
