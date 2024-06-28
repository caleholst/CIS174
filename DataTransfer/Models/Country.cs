using DataTransfer.Models;

public class Country
{
    public string CountryID { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string FlagImage { get; set; } = string.Empty;
    public string CategoryID { get; set; }
    public string GameID { get; set; }
    public Game Game { get; set; } = null!;
    public Category Category { get; set; } = null!;
}