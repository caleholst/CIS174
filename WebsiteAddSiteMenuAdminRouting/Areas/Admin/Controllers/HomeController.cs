using Microsoft.AspNetCore.Mvc;

namespace WebsiteAddSiteMenuAdminRouting.Areas.Admin.Controllers;

[Area("Admin")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Attribute(string id = "All")
    {
        return View("Attribute", "Custom Attribute = " + id);
    }
}
