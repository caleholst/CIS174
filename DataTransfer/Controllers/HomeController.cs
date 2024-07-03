using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class HomeController : Controller
{
    private OlympicContext context;

    public HomeController(OlympicContext ctx)
    {
        context = ctx;
    }

    public ViewResult Index(CountriesViewModel model)
    {
        model.Games = context.Games.ToList();
        model.Categories = context.Categories.ToList();

        IQueryable<Country> query = context.Countries.OrderBy(c => c.Name);
        if (model.ActiveGame != "all")
            query = query.Where(c => c.Game.GameID.ToLower() == model.ActiveGame.ToLower());

        if (model.ActiveCategory != "all")
            query = query.Where(c => c.Category.CategoryID.ToLower() == model.ActiveCategory.ToLower());

        model.Countries = query.ToList();
        return View(model);
    }

    public IActionResult Details(string id)
    {
        var country = context.Countries.FirstOrDefault(c => c.CountryID == id);
        if (country == null)
        {
            return NotFound();
        }
        return View(country);
    }

    [HttpPost]
    public IActionResult AddToFavorites(string id)
    {
        var country = context.Countries.FirstOrDefault(c => c.CountryID == id);
        if (country == null)
        {
            return NotFound();
        }

        var favorites = HttpContext.Session.Get<List<string>>("Favorites") ?? new List<string>();
        if (!favorites.Contains(id))
        {
            favorites.Add(id);
            HttpContext.Session.Set("Favorites", favorites);
        }

        return RedirectToAction("Index");
    }
}