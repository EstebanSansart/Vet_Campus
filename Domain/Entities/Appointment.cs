using Domain.Entities.Generic;

namespace Domain.Entities;
public class Appointment : BaseEntity{
    public DateTime Date { get; set; }
    public DateTime Hour { get; set; }
    public string Reason { get; set; }

    public int IdPet { get; set; }
    public Pet Pet { get; set; }
    public int IdVet { get; set; }
    public Vet Vet { get; set; }

    public ICollection<MedicalTreatment> MedicalTreatments { get; set; }
}