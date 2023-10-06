using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class OwnerConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.ToTable("owner");

            builder.HasKey(r => r.Id);

            // Properties
            builder.Property(r => r.Id)
            .IsRequired()
            .HasColumnName("IdOwner");

            builder.Property(r => r.Name)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("OwnerName");

            builder.Property(r => r.Email)
            .IsRequired()
            .HasMaxLength(150)
            .HasColumnName("OwnerEmail");
            
            builder.Property(r => r.PhoneNumber)
            .IsRequired()
            .HasMaxLength(20)
            .HasColumnName("OwnerPhoneNumber");
        }
    }
}