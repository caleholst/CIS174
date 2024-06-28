public class CountriesViewModel
{
    public string ActiveGame { get; set; } = "all";
    public string ActiveCategory { get; set; } = "all";

    public List<Country> Countries { get; set; } = new List<Country>();
    public List<Game> Games { get; set; } = new List<Game>();
    public List<Category> Categories { get; set; } = new List<Category>();

    public string CheckActiveGame(string g) => g.ToLower() == ActiveGame.ToLower() ? "active" : "";
    public string CheckActiveCategory(string c) => c.ToLower() == ActiveCategory.ToLower() ? "active" : "";
}