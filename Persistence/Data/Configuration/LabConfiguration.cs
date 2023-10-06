using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class LabConfiguration : IEntityTypeConfiguration<Lab>
    {
        public void Configure(EntityTypeBuilder<Lab> builder)
        {
            builder.ToTable("lab");

            builder.HasKey(r => r.Id);

            // Properties
            builder.Property(r => r.Id)
            .IsRequired()
            .HasColumnName("IdLab");

            builder.Property(r => r.Name)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnName("LabName");

            builder.Property(r => r.Address)
            .IsRequired()
            .HasMaxLength(200)
            .HasColumnName("LabAddress");

            builder.Property(r => r.PhoneNumber)
            .IsRequired()
            .HasMaxLength(20)
            .HasColumnName("LabPhoneNumber");

            // Default Data

            builder.HasData(
                new{
                    Id = 1,
                    Name = "Lab1",
                    Address = "calle 27A #12-13",
                    PhoneNumber = "3165872525"
                },
                new{
                    Id = 2,
                    Name = "Lab2",
                    Address = "auser1@example.com",
                    PhoneNumber = "3046518974"
                }
            );
        }
    }
}