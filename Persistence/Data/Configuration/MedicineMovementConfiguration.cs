using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class MedicineMovementConfiguration : IEntityTypeConfiguration<MedicineMovement>
    {
        public void Configure(EntityTypeBuilder<MedicineMovement> builder)
        {
            builder.ToTable("medicine_movement");

            builder.HasKey(r => r.Id);

            // Properties
            builder.Property(r => r.Id)
            .IsRequired()
            .HasColumnName("IdMedicineMovement");

            builder.Property(r => r.Quantity)
            .IsRequired()
            .HasMaxLength(10)
            .HasColumnName("MedicineMovementQuantity");

            builder.Property(r => r.Date)
            .IsRequired()
            .HasColumnType("DateTime")
            .HasColumnName("MedicineMovementDate");

            //Relationships
            builder.HasOne(x => x.Medicine)
            .WithMany(x => x.MedicineMovements)
            .HasForeignKey(x => x.IdMedicine);

            builder.HasOne(x => x.MovementType)
            .WithMany(x => x.MedicineMovements)
            .HasForeignKey(x => x.IdMovementType);
        }
    }
}