using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using boxAmOffice.Models;
using Box_AM_Ofice.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using NToastNotify;

namespace Box_AM_Ofice.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovie _movies;
        private readonly IToastNotification _toastNotification;

        public MoviesController(IMovie movies, IToastNotification toastNotification)
        {
            _movies = movies;
            _toastNotification = toastNotification;
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
                _toastNotification.AddSuccessToastMessage("Movie created successfully");
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
            _toastNotification.AddSuccessToastMessage("Movie Edited successfully");
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
            _toastNotification.AddSuccessToastMessage("Movie deleted successfully");
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Search(string searchString)
        {
            var allMovies = await _movies.GetMovies();

            if (!string.IsNullOrEmpty(searchString))
            {
                //var filteredResult = allMovies.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) || n.Description.ToLower().Contains(searchString.ToLower())).ToList();

                var filteredResultNew = allMovies.Where(n => string.Equals(n.Name, searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.Description, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

                return View("Index", filteredResultNew);
            }

            return View("Index", allMovies);
        }
    }
}
