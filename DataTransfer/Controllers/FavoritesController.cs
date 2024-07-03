using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class FavoritesController : Controller
{
    private OlympicContext context;

    public FavoritesController(OlympicContext ctx)
    {
        context = ctx;
    }

    public IActionResult Index()
    {
        var favoriteIds = HttpContext.Session.Get<List<string>>("Favorites") ?? new List<string>();
        var favoriteCountries = context.Countries
            .Where(c => favoriteIds.Contains(c.CountryID))
            .ToList();
        return View(favoriteCountries);
    }

    [HttpPost]
    public IActionResult Clear()
    {
        HttpContext.Session.Remove("Favorites");
        return RedirectToAction("Index");
    }
}