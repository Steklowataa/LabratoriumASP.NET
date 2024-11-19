using System.ComponentModel.DataAnnotations;

namespace lab3.Models;

public enum Category
{
    [Display(Name = "Friend contact", Order = 1)]
    Friends = 1,
    
    [Display(Name = "Family contact", Order = 2)]
    Family = 2,
    
    [Display(Name = "Business contact", Order = 3)]
    Business = 3
}