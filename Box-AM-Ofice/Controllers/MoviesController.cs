using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using boxAmOffice.Models;
using Box_AM_Ofice.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace Box_AM_Ofice.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovie _movies;

        public MoviesController(IMovie movies)
        {
            _movies = movies;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            List<Movie> movies = await _movies.GetMovies();
            return View(movies);
        }

        // GET: Movies
      


        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int id)
        {
            Movie movie = await _movies.GetMovie(id);
            return View(movie);
        }

        // GET: Movies/Create
        [Authorize(Roles = "Administrator")]

        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [Authorize(Roles = "Administrator")]

        [HttpPost]
        public async Task<IActionResult> Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                await _movies.CreateMovie(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        // GET: Movies/Edit/5
        [Authorize(Roles = "Administrator")]

        public async Task<IActionResult> Edit(int id)
        {
            Movie movie = await _movies.GetMovie(id);
            return View(movie);
        }

        // POST: Movies/Edit/5
        [Authorize(Roles = "Administrator")]

        [HttpPost]
        public async Task<IActionResult> Edit(int id,Movie movie)
        {
            await _movies.UpdateMovie(id ,movie);
            return RedirectToAction("Index");
        }

        // GET: Movies/Delete/5
        [Authorize(Roles = "Administrator")]

        public async Task<IActionResult> Delete(int id)
        {
            await _movies.GetMovie(id);
            return View();
        }

        // POST: Movies/Delete/5
        [Authorize(Roles = "Administrator")]

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _movies.DeleteMovie(id);
            return RedirectToAction("Index");
        }

    }
}
