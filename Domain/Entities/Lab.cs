using Domain.Entities.Generic;

namespace Domain.Entities;
public class Lab : BaseEntity{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    public ICollection<Medicine> Medicines { get; set; }
}