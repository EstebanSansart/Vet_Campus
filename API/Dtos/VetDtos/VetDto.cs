using System.ComponentModel.DataAnnotations;

namespace API.Dtos;
public class VetDto{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required]
    public string Specialty { get; set; }
}