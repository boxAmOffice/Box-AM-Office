using boxAmOffice.Models;
using Box_AM_Ofice.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using NToastNotify;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinema _service;
        private readonly IMovie _movies;
        private readonly IToastNotification _toastNotification;

        public CinemasController(ICinema service, IMovie movies, IToastNotification toastNotification)
        {
            _service = service;
            _movies = movies;
            _toastNotification = toastNotification;

        }
        public async Task<IActionResult> Index()
        {
            var alldata = await _service.GetAll();
            return View(alldata);
        }

        public async Task<IActionResult> AllMovies()
        {
            List<Movie> allmovies = await _movies.GetMovies();
            return View(allmovies);
        }
        // Get: Cinemas/Create
        [Authorize(Roles = "Administrator")]

        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> Create(Cinema cinema)

        {
            if (!ModelState.IsValid) // check validations like Required annotation
            {
                return View(cinema);
            }
            await _service.AddCinema(cinema);
            _toastNotification.AddSuccessToastMessage("Cinema created successfully");
            return RedirectToAction(nameof(Index));
        }
        // Get: Cinemas/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var CinemaDetails = await _service.GetById(id);
            if (CinemaDetails == null) return NotFound();
            return View(CinemaDetails);
        }
        // Get: Cinemas/Edit
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int id)
        {
            var CinemaDetails = await _service.GetById(id);
            if (CinemaDetails == null) return NotFound();
            return View(CinemaDetails);
        }
        [Authorize(Roles = "Administrator")]

        [HttpPost]
        public async Task<IActionResult> Edit(int id,Cinema cinema)

        {
            if (!ModelState.IsValid) // check validations like Required annotation
            {
                return View(cinema);
            }
            await _service.Update(id, cinema);
            _toastNotification.AddSuccessToastMessage("Cinema edited successfully");
            return RedirectToAction(nameof(Index));
        }
        // Get: Cinema/Delete/1
        [Authorize(Roles = "Administrator")]

        public async Task<IActionResult> Delete(int id)
        {
            var CinemaDetails = await _service.GetById(id);
            if (CinemaDetails == null) return NotFound();
            return View(CinemaDetails);
        }
        [Authorize(Roles = "Administrator")]

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)

        {
            var CinemaDetails = await _service.GetById(id);
            if (CinemaDetails == null) return NotFound();
            await _service.RemoveCinema(id);
            _toastNotification.AddSuccessToastMessage("Cinema removed successfully");
            return RedirectToAction(nameof(Index));
        }
    }
}
