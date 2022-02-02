using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission4Jan24.Models;

namespace Mission4Jan24.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext blahContext { get; set; }
        

        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = blahContext.Categories.ToList();
            

            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                blahContext.Add(ar);
                blahContext.SaveChanges();
                return RedirectToAction("Movies");
            }
            else
            {
                ViewBag.Categories = blahContext.Categories.ToList();
                return View(ar);
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Movies()
        {
            
            var movies = blahContext.Movies
                .Include(x => x.Category)
                .ToList();

            return View(movies);
        }
        [HttpGet]
        public IActionResult Edit(int applicationid)
        {
            ViewBag.Categories = blahContext.Categories.ToList();
            var movie = blahContext.Movies.Single(x => x.ApplicationId == applicationid);
            return View("MovieForm", movie);

        }
        [HttpPost]
        public IActionResult Edit(ApplicationResponse blah)
        {
            blahContext.Update(blah);
            blahContext.SaveChanges();
            return RedirectToAction("Movies");
        }
        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var movie = blahContext.Movies.Single(x => x.ApplicationId == applicationid);

            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            blahContext.Movies.Remove(ar);
            blahContext.SaveChanges();
            return RedirectToAction("Movies");
        }

    }
}
