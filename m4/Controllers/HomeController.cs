using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using m4.Models;

namespace m4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieApplicationContext movieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieApplicationContext someName)
        {
            _logger = logger;
            movieContext = someName;

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
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(FormResponse fr)
        {
            //connect db later
            movieContext.Add(fr);
            movieContext.SaveChanges();

            return View("Confirmation", fr);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
