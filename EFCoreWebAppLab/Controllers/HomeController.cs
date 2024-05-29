using Microsoft.AspNetCore.Mvc;
using EFCoreWebAppLab.Models;
using EFCoreWebAppLab.Migrations;
using Microsoft.EntityFrameworkCore;

namespace EFCoreWebAppLab.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }

        public HomeController(MovieContext ctx) => context = ctx;

        public IActionResult Index()
        {
            var movies = context.Movies.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            return View(movies);
        }
    }
}