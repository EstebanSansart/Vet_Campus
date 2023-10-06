using Domain.Entities.Generic;

namespace Domain.Entities;
public class Pet : BaseEntity{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }

    public int IdOwner { get; set; }
    public Owner Owner { get; set; }
    public int IdSpecies { get; set; }
    public Species Species { get; set; }
    public int IdBreed { get; set; }
    public Breed Breed { get; set; }

    public ICollection<Appointment> Appointments { get; set; }
}