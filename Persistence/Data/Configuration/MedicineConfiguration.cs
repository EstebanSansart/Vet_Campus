using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class MedicineConfiguration : IEntityTypeConfiguration<Medicine>
    {
        public void Configure(EntityTypeBuilder<Medicine> builder)
        {
            builder.ToTable("medicine");

            builder.HasKey(r => r.Id);

            // Properties
            builder.Property(r => r.Id)
            .IsRequired()
            .HasColumnName("IdMedicine");

            builder.Property(r => r.Name)
            .IsRequired()
            .HasMaxLength(200)
            .HasColumnName("MedicineName");

            builder.Property(r => r.Stock)
            .IsRequired()
            .HasMaxLength(10)
            .HasColumnName("MedicineStock");

            builder.Property(r => r.Price)
            .IsRequired()
            .HasMaxLength(200)
            .HasColumnName("MedicinePrice");

            // Relationships
            builder.HasOne(x => x.Lab)
            .WithMany(x => x.Medicines)
            .HasForeignKey(x => x.IdLab);

            // Supplier - Medicine
            builder
            .HasMany(r => r.Suppliers)
            .WithMany(p => p.Medicines)
            .UsingEntity<SupplierMedicine>(

                j => j
                .HasOne(pt => pt.Supplier)
                .WithMany(t => t.SupplierMedicines)
                .HasForeignKey(ut => ut.IdSupplier),

                j => j
                .HasOne(et => et.Medicine)
                .WithMany(e => e.SupplierMedicines)
                .HasForeignKey(te => te.IdMedicine),

                j =>
                {
                    j.ToTable("supplier_medicine");
                    j.HasKey(t => new{t.IdMedicine, t.IdSupplier});
                }
            );

            // Default Data

            builder.HasData(
                new{
                    Id = 1,
                    Name = "NexGard",
                    Stock = 745,
                    Price = 20000.00,
                    IdLab = 1
                },
                new{
                    Id = 2,
                    Name = "Drontal",
                    Stock = 489,
                    Price = 18000.00,
                    IdLab = 2
                }
            );
        }
    }
}