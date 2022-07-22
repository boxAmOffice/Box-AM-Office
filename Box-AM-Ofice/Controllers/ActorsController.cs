using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using boxAmOffice.Models;
using Box_AM_Ofice.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using NToastNotify;

namespace Box_AM_Ofice.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActor _actor;
        private readonly IToastNotification _toastNotification;

        public ActorsController(IActor actor, IToastNotification toastNotification)
        {
            _actor = actor;
            _toastNotification = toastNotification;
        }

        // GET: Actors
        public async Task<IActionResult> Index()
        {
            return View(await _actor.GetActors());
        }

        // GET: Actors/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var actor = await _actor.GetActor(id);

            if (actor == null)
            {
                return NotFound();
            }

            return View(actor);
        }

        // GET: Actors/Create
        [Authorize(Roles = "Administrator")]

        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Administrator")]

        [HttpPost]
        public async Task<IActionResult> Create(Actor actor)
        {
            if (ModelState.IsValid)
            {
                await _actor.CreateActor(actor);
                _toastNotification.AddSuccessToastMessage("Actor created successfully");
                return RedirectToAction(nameof(Index));
            }
            return View(actor);
        }

        // GET: Actors/Edit/5
        [Authorize(Roles = "Administrator")]

        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var actor = await _actor.GetActor(id);

            if (actor == null)
            {
                return NotFound();
            }
            return View(actor);
        }
        [Authorize(Roles = "Administrator")]

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Actor actor)
        {
            if (id != actor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _actor.UpdateActor(id, actor);
                _toastNotification.AddSuccessToastMessage("Actor edited successfully");
                return RedirectToAction(nameof(Index));
            }

            return View(actor);
        }

        // GET: Actors/Delete/5
        [Authorize(Roles = "Administrator")]

        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var actor = await _actor.GetActor(id);

            if (actor == null)
            {
                return NotFound();
            }

            return View(actor);
        }

        // POST: Actors/Delete/5
        [Authorize(Roles = "Administrator")]

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _actor.DeleteActor(id);
            _toastNotification.AddSuccessToastMessage("Actor deleted successfully");
            return RedirectToAction(nameof(Index));
        }
    }
}
