using System.ComponentModel.DataAnnotations;
using API.Dtos;

namespace ApiJakPharmacy.Dtos;
public class AppointmentFullDto : AppointmentDto{
    
    [Required]
    public int Id { get; set; }
}