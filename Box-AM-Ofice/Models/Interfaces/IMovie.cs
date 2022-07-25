using Box_AM_Ofice.ViewModels;
using boxAmOffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Box_AM_Ofice.Models.Interfaces
{
    public interface IMovie
    {
        Task<Movie> CreateMovie(Movie movie);
        Task<Movie> GetMovie(int Id);
        Task<List<Movie>> GetMovies();
        Task<Movie> UpdateMovie(int Id, Movie movie);
        Task DeleteMovie(int Id);
        Task<MovieDropdownsVM> GetNewMovieDropdownsValues();

        Task<List<Movie>> GetMoviesByCinemaId(int cinemaId);

    }
}
