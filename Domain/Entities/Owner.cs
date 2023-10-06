using Domain.Entities.Generic;

namespace Domain.Entities;
public class Owner : BaseEntity{
    public string Name { get; set; }
    public string Email { get; set; }
    public int PhoneNumber { get; set; }

    public ICollection<Pet> Pets { get; set; }
}