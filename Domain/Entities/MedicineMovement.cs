using Domain.Entities.Generic;

namespace Domain.Entities;
public class MedicineMovement : BaseEntity{
    public int Quantity { get; set; }
    public DateTime Date { get; set; }

    public int IdMedicine { get; set; }
    public Medicine Medicine { get; set; }
    
    //Esta relación es nueva, pues no estaba en el ejercicio
    public int IdMovementType { get; set; }
    public MovementType MovementType { get; set; }

    public ICollection<MovementDetail> MovementDetails { get; set; }
}