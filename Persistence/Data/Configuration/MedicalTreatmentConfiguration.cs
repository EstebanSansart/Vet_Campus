using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class MedicalTreatmentConfiguration : IEntityTypeConfiguration<MedicalTreatment>
    {
        public void Configure(EntityTypeBuilder<MedicalTreatment> builder)
        {
            builder.ToTable("medical_treatment");

            builder.HasKey(r => r.Id);

            // Properties
            builder.Property(r => r.Id)
            .IsRequired()
            .HasColumnName("IdMedicalTreatment");

            builder.Property(r => r.Dose)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("MedicalTreatmentDose");

            builder.Property(r => r.AdminDate)
            .IsRequired()
            .HasColumnType("DateTime")
            .HasColumnName("MedicalTreatmentAdminDate");

            builder.Property(r => r.Observation)
            .IsRequired()
            .HasMaxLength(200)
            .HasColumnName("MedicalTreatmentObservation");

            //Relationships
            builder.HasOne(x => x.Appointment)
            .WithMany(x => x.MedicalTreatments)
            .HasForeignKey(x => x.IdAppointment);

            builder.HasOne(x => x.Medicine)
            .WithMany(x => x.MedicalTreatments)
            .HasForeignKey(x => x.IdMedicine);
        }
    }
}