using boxAmOffice.Models;
using Box_AM_Ofice.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinema _service;
        public CinemasController(ICinema service)
        {
            _service = service;

        }
        public async Task<IActionResult> Index()
        {
            var alldata = await _service.GetAll();
            return View(alldata);
        }
        // Get: Cinemas/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Cinema cinema)

        {
            if (!ModelState.IsValid) // check validations like Required annotation
            {
                return View(cinema);
            }
            await _service.AddCinema(cinema);
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
        public async Task<IActionResult> Edit(int id)
        {
            var CinemaDetails = await _service.GetById(id);
            if (CinemaDetails == null) return NotFound();
            return View(CinemaDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Cinema cinema)

        {
            if (!ModelState.IsValid) // check validations like Required annotation
            {
                return View(cinema);
            }
            await _service.Update(id, cinema);
            return RedirectToAction(nameof(Index));
        }
        // Get: Cinema/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var CinemaDetails = await _service.GetById(id);
            if (CinemaDetails == null) return NotFound();
            return View(CinemaDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)

        {
            var CinemaDetails = await _service.GetById(id);
            if (CinemaDetails == null) return NotFound();
            await _service.RemoveCinema(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
