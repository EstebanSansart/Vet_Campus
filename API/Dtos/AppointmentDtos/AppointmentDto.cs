using System.ComponentModel.DataAnnotations;

namespace API.Dtos;
public class AppointmentDto{
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public DateTime Hour { get; set; }
    [Required]
    public string Reason { get; set; }
}