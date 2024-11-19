using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace lab3.Models;

public class ContactModel
{
    [HiddenInput]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "First name is required")]
    [MaxLength(100, ErrorMessage = "First name cannot exceed 100 characters")]
    [MinLength(2, ErrorMessage = "First name must have at least 2 characters")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Last name is required")]
    [MaxLength(100, ErrorMessage = "Last name cannot exceed 100 characters")]
    [MinLength(2, ErrorMessage = "Last name must have at least 2 characters")]
    [Display(Name = "Last Name", Order = 1)]
    public string LastName { get; set; }

    [EmailAddress]
    [Display(Name = "Email", Order = 2)]
    public string Email { get; set; }

    // [Phone]
    // [RegularExpression("\\d{3} \\d{3} \\d{3}", ErrorMessage = "Wrong phone number format (should be xxx-xxx-xxx)")]
    // [Display(Name = "Phone Number", Order = 3)]
    public string PhoneNumber { get; set; }
    
    [DataType(DataType.Date)]
    [Display(Name = "Birthday", Order = 4)]
    public DateTime BirthDate { get; set; }
    
    // [Required(ErrorMessage = "Category is required")]
    // [Display(Name = "Category", Order = 5)]
    public Category Category { get; set; }
}