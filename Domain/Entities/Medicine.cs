using Domain.Entities.Generic;

namespace Domain.Entities;
public class Medicine : BaseEntity{
    public string Name { get; set; }
    public int Stock { get; set; }
    public double Price { get; set; }

    public int IdLab { get; set; }
    public Lab Lab { get; set; }

    public ICollection<Supplier> Suppliers { get; set; } = new HashSet<Supplier>();
    public ICollection<SupplierMedicine> SupplierMedicines { get; set; }
    public ICollection<MedicalTreatment> MedicalTreatments { get; set; }
    public ICollection<MedicineMovement> MedicineMovements { get; set; }
    public ICollection<MovementDetail> MovementDetails { get; set; }
}