using CIS174_TestCoreApp.Models;
using CIS174_TestCoreApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CIS174_TestCoreApp.Controllers
{
    public class Assignment6_1Controller : Controller
    {
        public IActionResult Assignment6_1(int accessLevel)
        {
            if (accessLevel < 1 || accessLevel > 10)
            {
                return BadRequest("Access level must be between 1 and 10.");
            }

            var students = new List<Student>
            {
                new Student { FirstName = "John", LastName = "Smith", Grade = "F" },
                new Student { FirstName = "Bob", LastName = "Saget", Grade = "C" },
                new Student { FirstName = "Cale", LastName = "Holst", Grade = "A" },
            };

            var viewModel = new Assignment6_1ViewModel
            {
                Students = students,
                AccessLevel = accessLevel
            };

            return View("/Views/Assignment/Assignment6_1.cshtml", viewModel);
        }
    }
}