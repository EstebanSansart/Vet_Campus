using System.ComponentModel.DataAnnotations;

namespace API.Dtos;
public class MovementDetailDto{
    [Required]
    public int Quantity { get; set; }
    [Required]
    public double Price { get; set; }
}