using Domain.Entities.Generic;

namespace Domain.Entities;
public class MovementType : BaseEntity{
    public string Description { get; set; }

    //Esta relación es nueva, pues no estaba en el ejercicio
    public ICollection<MedicineMovement> MedicineMovements { get; set; }
}