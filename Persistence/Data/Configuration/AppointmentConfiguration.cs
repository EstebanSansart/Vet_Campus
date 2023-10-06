using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.ToTable("appointment");

            builder.HasKey(r => r.Id);

            // Properties
            builder.Property(r => r.Id)
            .IsRequired()
            .HasColumnName("IdAppointment");

            builder.Property(r => r.Date)
            .IsRequired()
            .HasColumnType("OnlyDate")
            .HasColumnName("AppointmentDate");

            builder.Property(r => r.Hour)
            .IsRequired()
            .HasColumnType("OnlyTime")
            .HasColumnName("AppointmentHour");

            builder.Property(r => r.Reason)
            .IsRequired()
            .HasMaxLength(200)
            .HasColumnName("AppointmentReason");

            //Relationships
            builder.HasOne(x => x.Pet)
            .WithMany(x => x.Appointments)
            .HasForeignKey(x => x.IdPet);

            builder.HasOne(x => x.Vet)
            .WithMany(x => x.Appointments)
            .HasForeignKey(x => x.IdVet);
        }
    }
}