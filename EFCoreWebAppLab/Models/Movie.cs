using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace EFCoreWebAppLab.Models;

public class Movie
{
    public int MovieId { get; set; }

    [Required(ErrorMessage = "Please enter a name.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter a year.")]
    [Range(1889, 2999, ErrorMessage = "Year Must Be After 1889.")]
    public int? Year { get; set; }

    [Required(ErrorMessage = "Please enter a rating.")]
    [Range(1,5, ErrorMessage ="Rating must be between 1 and 5.")]
    public int? Rating { get; set; }

    [Required(ErrorMessage = "Please enter a genre")]
    public string GenreId { get; set; } = string.Empty;

    [ValidateNever]
    public Genre Genre { get; set; } = null!;

    public string Slug => Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();

}
