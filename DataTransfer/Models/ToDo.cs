using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace DataTransfer.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a status.")]
        [RegularExpression("^(Open|Closed|Completed)$", ErrorMessage = "Status must be 'Open', 'Closed', or 'Completed'.")]
        public string Status { get; set; } = "Open"; 

        public DateTime DueDate { get; set; }
    }


public class Status
    {
        public string StatusId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }

}

