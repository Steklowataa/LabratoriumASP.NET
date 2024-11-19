using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab3.Models;

[Table("contacts")]
public class ContactEntity
{
    public int Id { get; set; }
    [MaxLength(50)]
    [Required]
    public string FirstName { get; set; }
    [MaxLength(50)]
    [Required]

    public string LastName { get; set; }
    public string Email { get; set; }
    [MaxLength(12)]
    [MinLength(9)]
    public string PhoneNumber {  get; set; }
    [Column("birth_date")]
    public DateTime BirthDate { get; set; }

    public Category Category { get; set; }

    // public int OrganizationEntityId { get; set; }

    // public OrganizationEntity? { get; set; }
}
