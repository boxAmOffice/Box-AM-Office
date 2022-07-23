using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using boxAmOffice.Models;
using Box_AM_Ofice.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using NToastNotify;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace Box_AM_Ofice.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovie _movies;
        private readonly IToastNotification _toastNotification;
        private readonly IConfiguration _Configuration;


        public MoviesController(IMovie movies, IToastNotification toastNotification, IConfiguration config)
        {
            _movies = movies;
            _toastNotification = toastNotification;
            _Configuration = config;

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

        public async Task<IActionResult> Create()

        {
            var movieDropdownsData = await _movies.GetNewMovieDropdownsValues();

            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");
            return View();
        }

        // POST: Movies/Create
        [Authorize(Roles = "Administrator")]

        [HttpPost]
        public async Task<IActionResult> Create(Movie movie, IFormFile file)
        {
            BlobContainerClient container = new BlobContainerClient(_Configuration.GetConnectionString("AzureBlob"), "attac");
            await container.CreateIfNotExistsAsync();
            BlobClient blob = container.GetBlobClient(file.FileName);
            using var stream = file.OpenReadStream();

            BlobUploadOptions options = new BlobUploadOptions()
            {
                HttpHeaders = new BlobHttpHeaders() { ContentType = file.ContentType }
            };


            if (!blob.Exists())
            {
                await blob.UploadAsync(stream, options);
            }

            movie.ImageURL = blob.Uri.ToString();
            var movieDropdownsData = await _movies.GetNewMovieDropdownsValues();

            if (ModelState.IsValid)
            {
                await _movies.CreateMovie(movie);
                ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
                ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");
                _toastNotification.AddSuccessToastMessage("Movie created successfully");
                return RedirectToAction("Index");
            }
            stream.Close();
            return View(movie);
        }

        // GET: Movies/Edit/5
        [Authorize(Roles = "Administrator")]

        public async Task<IActionResult> Edit(int id)
        {
            var movieDropdownsData = await _movies.GetNewMovieDropdownsValues();

            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");
            Movie movie = await _movies.GetMovie(id);
            return View(movie);
        }

        // POST: Movies/Edit/5
        [Authorize(Roles = "Administrator")]

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Movie movie, IFormFile file)
        {
            var movieDropdownsData = await _movies.GetNewMovieDropdownsValues();

            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");


            BlobContainerClient container = new BlobContainerClient(_Configuration.GetConnectionString("AzureBlob"), "attac");
            await container.CreateIfNotExistsAsync();
            BlobClient blob = container.GetBlobClient(file.FileName);
            using var stream = file.OpenReadStream();

            BlobUploadOptions options = new BlobUploadOptions()
            {
                HttpHeaders = new BlobHttpHeaders() { ContentType = file.ContentType }
            };


            if (!blob.Exists())
            {
                await blob.UploadAsync(stream, options);
            }

            movie.ImageURL = blob.Uri.ToString();

            await _movies.UpdateMovie(id, movie);
            _toastNotification.AddSuccessToastMessage("Movie Edited successfully");
            stream.Close();

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
