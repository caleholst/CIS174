using Microsoft.AspNetCore.Mvc;

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
}