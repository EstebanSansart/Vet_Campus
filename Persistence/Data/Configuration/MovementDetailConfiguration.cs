using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class MovementDetailConfiguration : IEntityTypeConfiguration<MovementDetail>
    {
        public void Configure(EntityTypeBuilder<MovementDetail> builder)
        {
            builder.ToTable("movement_detail");

            builder.HasKey(r => r.Id);

            // Properties
            builder.Property(r => r.Id)
            .IsRequired()
            .HasColumnName("IdMovementDetail");

            builder.Property(r => r.Quantity)
            .IsRequired()
            .HasMaxLength(10)
            .HasColumnName("MovementDetailQuantity");

            builder.Property(r => r.Price)
            .IsRequired()
            .HasMaxLength(20)
            .HasColumnName("MovementDetailPrice");

            //Relationships
            builder.HasOne(x => x.Medicine)
            .WithMany(x => x.MovementDetails)
            .HasForeignKey(x => x.IdMedicine);

            builder.HasOne(x => x.MedicineMovement)
            .WithMany(x => x.MovementDetails)
            .HasForeignKey(x => x.IdMedicineMovement);
        }
    }
}