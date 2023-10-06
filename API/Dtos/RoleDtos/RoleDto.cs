using System.ComponentModel.DataAnnotations;

namespace API.Dtos;
public class RoleDto{
    [Required]
    public string Name { get; set; }
}