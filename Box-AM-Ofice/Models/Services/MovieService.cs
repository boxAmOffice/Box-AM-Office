﻿using Box_AM_Ofice.Models.Interfaces;
using boxAmOffice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Box_AM_Ofice.Models.Services
{
    public class MovieService : IMovie
    {
        private AppDbContext _context;
        public MovieService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Movie> CreateMovie(Movie movie)
        {

            Movie NewMovie = new Movie
            {
                Id = movie.Id,
                Name = movie.Name,
                Actors_Movies = movie.Actors_Movies,
                Description = movie.Description,
                Price = movie.Price,
                StartDate = movie.StartDate,
                EndDate = movie.EndDate,
                ImageURL = movie.ImageURL,
                MovieCategory = movie.MovieCategory,
                ProducerId = movie.ProducerId,
                CinemaId = movie.CinemaId
            };
            _context.Entry(movie).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return NewMovie;
        }

        public async Task DeleteMovie(int Id)
        {
            Movie movie = await _context.Movies.FindAsync(Id);
            _context.Entry(movie).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<Movie> GetMovie(int Id)
        {
            return await _context.Movies.Select(movie => new Movie
            {
                Id = movie.Id,
                Name = movie.Name,
                Actors_Movies = movie.Actors_Movies,
                Description = movie.Description,
                Price = movie.Price,
                StartDate = movie.StartDate,
                EndDate = movie.EndDate,
                ImageURL = movie.ImageURL,
                MovieCategory = movie.MovieCategory,
                ProducerId = movie.ProducerId,
                CinemaId = movie.CinemaId

            }).FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<List<Movie>> GetMovies()
        {
            return await _context.Movies.Select(movie => new Movie
            {
                Id = movie.Id,
                Name = movie.Name,
                Actors_Movies = movie.Actors_Movies,
                Description = movie.Description,
                Price = movie.Price,
                StartDate = movie.StartDate,
                EndDate = movie.EndDate,
                ImageURL = movie.ImageURL,
                MovieCategory = movie.MovieCategory,
                ProducerId = movie.ProducerId,
                CinemaId = movie.CinemaId

            }).ToListAsync();        }

        public async Task<Movie> UpdateMovie(int Id, Movie movie)
        {
            Movie UpdateMovie = new Movie
            {
                Id = movie.Id,
                Name = movie.Name,
                Actors_Movies = movie.Actors_Movies,
                Description = movie.Description,
                Price = movie.Price,
                StartDate = movie.StartDate,
                EndDate = movie.EndDate,
                ImageURL = movie.ImageURL,
                MovieCategory = movie.MovieCategory,
                ProducerId = movie.ProducerId,
                CinemaId = movie.CinemaId
            };
            _context.Entry(movie).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return UpdateMovie;
        }
    }
}