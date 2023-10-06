using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class SpeciesConfiguration : IEntityTypeConfiguration<Species>
    {
        public void Configure(EntityTypeBuilder<Species> builder)
        {
            builder.ToTable("species");

            builder.HasKey(r => r.Id);

            // Properties
            builder.Property(r => r.Id)
            .IsRequired()
            .HasColumnName("IdSpecies");

            builder.Property(r => r.Name)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("SpeciesName");

            // Default Data

            builder.HasData(
                new{
                    Id = 1,
                    Name = "Felino",
                },
                new{
                    Id = 2,
                    Name = "Canino",
                },
                new{
                    Id = 3,
                    Name = "Ave",
                },
                new{
                    Id = 4,
                    Name = "Pez",
                }
            );
        }
    }
}