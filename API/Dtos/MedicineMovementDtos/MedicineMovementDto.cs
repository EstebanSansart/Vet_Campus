using System.ComponentModel.DataAnnotations;

namespace API.Dtos;
public class MedicineMovementDto{
    [Required]
    public int Quantity { get; set; }
    [Required]
    public DateTime Date { get; set; }
}