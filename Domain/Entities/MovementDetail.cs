using Domain.Entities.Generic;

namespace Domain.Entities;
public class MovementDetail : BaseEntity{
    public int Quantity { get; set; }
    public double Price { get; set; }

    public int IdMedicine { get; set; }
    public Medicine Medicine { get; set; }
    public int IdMedicineMovement { get; set; }
    public MedicineMovement MedicineMovement { get; set; }
}