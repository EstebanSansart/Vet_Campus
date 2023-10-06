using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("pet");

            builder.HasKey(r => r.Id);

            // Properties
            builder.Property(r => r.Id)
            .IsRequired()
            .HasColumnName("IdPet");

            builder.Property(r => r.Name)
            .IsRequired()
            .HasMaxLength(10)
            .HasColumnName("PetName");

            builder.Property(r => r.BirthDate)
            .IsRequired()
            .HasColumnType("DateTime")
            .HasColumnName("PetBirthDate");

            //Relationships
            builder.HasOne(x => x.Owner)
            .WithMany(x => x.Pets)
            .HasForeignKey(x => x.IdOwner);

            builder.HasOne(x => x.Species)
            .WithMany(x => x.Pets)
            .HasForeignKey(x => x.IdSpecies);

            builder.HasOne(x => x.Breed)
            .WithMany(x => x.Pets)
            .HasForeignKey(x => x.IdBreed);
        }
    }
}