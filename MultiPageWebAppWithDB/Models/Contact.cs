using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MultiPageWebAppWithDB.Models;

public class Contact
{
    public int ContactId { get; set; }

    [Required (ErrorMessage = "Please enter a name.")]
    public string Name { get; set; }

    [Required (ErrorMessage = "Please enter a phone number")]
    public string PhoneNumber { get; set; }

    [Required (ErrorMessage = "Please enter a address")]
    public string Address { get; set; }

    [Required (ErrorMessage = "Please enter a note")]
    public string Note { get; set; }

    public string Slug => Name?.Replace(' ', '-').ToLower() + '-' + PhoneNumber?.ToString();
}
