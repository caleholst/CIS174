using ResponsiveWebAppWithTests.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ResponsiveWebAppWithTests.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Age = string.Empty;
            ViewBag.Name = string.Empty;
            return View();
        }
        [HttpPost]
        public IActionResult Index(AgeCalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = model.NameViewBag();
                ViewBag.Age = model.AgeThisYear();

            }
            else
            {
                ViewBag.Age = string.Empty;
                ViewBag.Name = string.Empty;

            }
            return View(model);
        }
    }
}
