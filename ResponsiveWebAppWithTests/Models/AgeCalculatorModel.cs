using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ResponsiveWebAppWithTests.Models
{
    public class AgeCalculatorModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [RegularExpression(@"^[a-zA-Z\s\-,\'\""]+$", ErrorMessage = "The name can only contain letters, spaces, hyphens, commas, apostrophes, and double quotes.")] // I think this covers all names? 
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter your birth year.")]
        // I couldnt figure out how to use DateTime for the range
        // I figured 1900 is a fine minimum and i wanted to have the current year as the max but I couldnt figure out how to update so this would only work for this year. 
        [Range(1900, 2024, ErrorMessage = "Please enter a number between 1900 and 2024.")]
        public int? BirthYear { get; set; }


        public string AgeThisYear()
        {
            int CurrentYear = DateTime.Now.Year;
            int birthYear = BirthYear.Value;
            int age = CurrentYear - birthYear;
            string ageString = age.ToString();
            return ageString;
        }
        // there was probanly a better way to do this but this was the easiest I could think of. 
        public string NameViewBag()
        {
            string name = Name;
            return name + ",";

        }
    }

}
