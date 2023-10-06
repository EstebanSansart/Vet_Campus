using System.ComponentModel.DataAnnotations;

namespace API.Dtos;
public class SpeciesDto{
    [Required]
    public string Name { get; set; }
}