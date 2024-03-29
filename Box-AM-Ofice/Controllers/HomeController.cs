﻿using Box_AM_Ofice.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Box_AM_Ofice.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovie _movies;

        public HomeController(IMovie movies)
        {
            _movies = movies;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _movies.GetMovies());
        }
        public async Task<IActionResult> contactus()
        {
            return View(await _movies.GetMovies());
        }

        public IActionResult AboutUs()
        {
            return View();
        }
      
    }
}
