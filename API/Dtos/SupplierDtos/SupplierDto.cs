using System.ComponentModel.DataAnnotations;

namespace API.Dtos;
public class SupplierDto{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Address { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
}