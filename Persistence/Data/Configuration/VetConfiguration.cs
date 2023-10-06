using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class VetConfiguration : IEntityTypeConfiguration<Vet>
    {
        public void Configure(EntityTypeBuilder<Vet> builder)
        {
            builder.ToTable("vet");

            builder.HasKey(r => r.Id);

            // Properties
            builder.Property(r => r.Id)
            .IsRequired()
            .HasColumnName("IdVet");

            builder.Property(r => r.Name)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("VetName");

            builder.Property(r => r.Email)
            .IsRequired()
            .HasMaxLength(200)
            .HasColumnName("VetEmail");
            
            builder.Property(r => r.PhoneNumber)
            .IsRequired()
            .HasMaxLength(20)
            .HasColumnName("SupplierPhoneNumber");

            builder.Property(r => r.Specialty)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnName("VetSpecialty");
        }
    }
}