namespace lab3.Models;
using System.ComponentModel.DataAnnotations;

public class ContactModel {

    // [HiddenInput]
    public int Id { get; set; }
    [Required(ErrorMessage = "Musisz podać imię")]
    [MaxLength(length: 20, ErrorMessage = "Zbyt długie imię")]
    [MinLength(length: 2, ErrorMessage = "Zbyt krótkie imię")]
    [Display(Name = "Imie")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Musisz podać nazwisko")]
    [MaxLength(length: 20, ErrorMessage = "Zbyt długie nazwisko")]
    [MinLength(length: 2, ErrorMessage = "Zbyt krótkie nazwisko")]
    [Display(Name = "Nazwisko")]
    public string LastName { get; set; }

    // [EmailAddress]
    public string Email { get; set; }

    // [Phone]
    // [RegularExpression("\\d{3} \\d{3} \\d{3}", ErrorMessage="Wpisz numer według wzoru: xxx xxx xxx")]
    public string PhoneNumber { get; set; }

    // [DataType(DataType.Date)]
    public DateOnly BirthDay { get; set; }

    public Category Category { get; set; }

}