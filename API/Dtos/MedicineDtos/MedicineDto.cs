using System.ComponentModel.DataAnnotations;

namespace API.Dtos;
public class MedicineDto{
    [Required]
    public string Name { get; set; }
    [Required]
    public int Stock { get; set; }
    [Required]
    public double Price { get; set; }
}