using System.ComponentModel.DataAnnotations;

namespace API.Dtos;
public class MedicalTreatmentDto{
    [Required]
    public string Dose { get; set; }
    [Required]
    public DateTime AdminDate { get; set; }
    [Required]
    public string Observation { get; set; }
}