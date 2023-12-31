using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("supplier");

            builder.HasKey(r => r.Id);

            // Properties
            builder.Property(r => r.Id)
            .IsRequired()
            .HasColumnName("IdSupplier");

            builder.Property(r => r.Name)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("SupplierName");

            builder.Property(r => r.Address)
            .IsRequired()
            .HasMaxLength(200)
            .HasColumnName("SupplierAddress");
            
            builder.Property(r => r.PhoneNumber)
            .IsRequired()
            .HasMaxLength(20)
            .HasColumnName("SupplierPhoneNumber");

            // Default Data

            builder.HasData(
                new{
                    Id = 1,
                    Name = "Supplier1",
                    Address = "supplier1@example.com",
                    PhoneNumber = "3166651214",
                },
                new{
                    Id = 2,
                    Name = "Supplier2",
                    Address = "supplier2@example.com",
                    PhoneNumber = "3002654121",
                }
            );
        }
    }
}