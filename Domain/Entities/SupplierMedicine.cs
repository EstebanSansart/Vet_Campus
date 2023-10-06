namespace Domain.Entities;
public class SupplierMedicine{
    public int IdMedicine { get; set; }
    public Medicine Medicine { get; set; }
    public int IdSupplier { get; set; }
    public Supplier Supplier { get; set; }
}