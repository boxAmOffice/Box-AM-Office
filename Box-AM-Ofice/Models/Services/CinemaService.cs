using Box_AM_Ofice.Models.Interfaces;
using boxAmOffice.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
		public async Task AddCinema(Cinema cinema)
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

		public async Task<List<Movie>> GetMovies(int cinemaId)
		{
			var moives = await _context.Cinemas.FindAsync(cinemaId);
			return moives.Movies;


			//return await _context.Cinemas.Select(C => new Movie
			//{

			//    Name = C.Name,
			//    Description=C.Description,

			//    Cinema = C.Movies.Select(p => new cinemaId

			//    {
			//        Id = p.Id,
			//        Name = p.Name,
			//        Description=p.Description




			//    }).ToList()

			//}).FirstOrDefaultAsync(x => x.Id == cinemaId);
		}

		public async Task RemoveCinema(int id)
		{
			var result = await _context.Cinemas.FirstOrDefaultAsync(n => n.Id == id);
			_context.Cinemas.Remove(result);
			await _context.SaveChangesAsync();
		}

		public async Task<Cinema> Update(int id, Cinema newCinema)
		{
			_context.Update(newCinema);
			await _context.SaveChangesAsync();
			return newCinema;
		}
	}
}
