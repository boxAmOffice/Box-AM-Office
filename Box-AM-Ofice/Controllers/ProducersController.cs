using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using boxAmOffice.Models;
using Box_AM_Ofice.Models.Interfaces;

namespace Box_AM_Ofice.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducer _producer;

        public ProducersController(IProducer producer)
        {
            _producer = producer;
        }

        // GET: Producers
        public async Task<IActionResult> Index()
        {
            return View(await _producer.GetProducers());
        }

        // GET: Producers/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var producer = await _producer.GetProducer(id);

            if (producer == null)
            {
                return NotFound();
            }

            return View(producer);
        }

        // GET: Producers/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Producer producer)
        {
            if (ModelState.IsValid)
            {
                await _producer.CreateProducer(producer);
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
        }

        // GET: Producers/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var producer = await _producer.GetProducer(id);

            if (producer == null)
            {
                return NotFound();
            }
            return View(producer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Producer producer)
        {
            if (id != producer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _producer.UpdateProducer(id, producer);

                return RedirectToAction(nameof(Index));
            }

            return View(producer);
        }

        // GET: Producers/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var producer = await _producer.GetProducer(id);

            if (producer == null)
            {
                return NotFound();
            }

            return View(producer);
        }

        // POST: Actors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _producer.DeleteProducer(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
