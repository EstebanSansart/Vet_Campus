using Domain.Entities.Generic;

namespace Domain.Entities;
public class MedicalTreatment : BaseEntity{
    public string Dose { get; set; }
    public DateTime AdminDate { get; set; }
    public string Observation { get; set; }

    public int IdAppointment { get; set; }
    public Appointment Appointment { get; set; }
    public int IdMedicine { get; set; }
    public Medicine Medicine { get; set; }
}