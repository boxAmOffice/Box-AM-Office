using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using boxAmOffice.Models;
using Box_AM_Ofice.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using NToastNotify;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;


namespace Box_AM_Ofice.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActor _actor;
        private readonly IToastNotification _toastNotification;
        private readonly IConfiguration _Configuration;


        public ActorsController(IActor actor, IToastNotification toastNotification, IConfiguration config)
        {
            _actor = actor;
            _toastNotification = toastNotification;
            _Configuration = config;

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
        public async Task<IActionResult> Create(Actor actor, IFormFile file)
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

            actor.ProfilePictureURL = blob.Uri.ToString();
            await _actor.CreateActor(actor);
            _toastNotification.AddSuccessToastMessage("Actor Added successfully");

            stream.Close();
            return RedirectToAction("Index");
        }

        // GET: Actors/Edit/5
        [Authorize(Roles = "Administrator")]

        public async Task<IActionResult> Edit(int id)
        {
            Actor actor = await _actor.GetActor(id);
            return View(actor);
        }
        [Authorize(Roles = "Administrator")]

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Actor actor, IFormFile file)
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

            actor.ProfilePictureURL = blob.Uri.ToString();

            await _actor.UpdateActor(id, actor);
            _toastNotification.AddSuccessToastMessage("Actor Edited successfully");
            stream.Close();

            return RedirectToAction("Index");
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
