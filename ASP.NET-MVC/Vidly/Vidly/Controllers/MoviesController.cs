using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Data;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

                // Create New Movie Form
        // -------------------------------------------------------------
        public IActionResult New()
        {
            var genre = _context.Genre.ToList();
            var viewModel = new MovieViewModel
            {
                Genres = genre
            };
            return View(viewModel);
        }

        // Create Edit Movie Form
        // -------------------------------------------------------------
        public IActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return BadRequest();
            }

            var viewModel = new MovieViewModel
            {
                Movie = movie,
                Genres = _context.Genre.ToList()
            };
            return View("Edit", viewModel);
        }

        // Save Action Setup
        // -------------------------------------------------------------
        [HttpPost]
        public IActionResult Save(Movie movie)
        {
            _context.Movies.Add(movie);

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ViewResult Index()
        {
            var movies = _context.Movies.Include(x => x.Genre).ToList();

            return View(movies);    
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(x => x.Genre).SingleOrDefault(c => c.Id == id);

            return View(movie);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}