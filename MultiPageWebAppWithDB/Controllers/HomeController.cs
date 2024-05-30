using Microsoft.AspNetCore.Mvc;
using MultiPageWebAppWithDB.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace MultiPageWebAppWithDB.Controllers;

public class HomeController : Controller
{
    private ContactContext context { get; set; }

    public HomeController(ContactContext ctx) => context = ctx;

    public IActionResult Index()
    {
        var contacts = context.Contacts.ToList();
        return View(contacts);
    }

}