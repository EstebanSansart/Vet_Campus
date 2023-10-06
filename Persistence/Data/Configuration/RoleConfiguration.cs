using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("role");

            builder.HasKey(r => r.Id);

            // Properties
            builder.Property(r => r.Id)
            .IsRequired()
            .HasColumnName("IdRole");

            builder.Property(r => r.Name)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("RoleName");

            // User - Role
            builder
            .HasMany(r => r.Users)
            .WithMany(p => p.Roles)
            .UsingEntity<UserRole>(

                j => j
                .HasOne(pt => pt.User)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(ut => ut.IdUser),

                j => j
                .HasOne(et => et.Role)
                .WithMany(e => e.UserRoles)
                .HasForeignKey(te => te.IdRole),

                j =>
                {
                    j.ToTable("user_role");
                    j.HasKey(t => new{t.IdRole, t.IdUser});
                }
            );
        }
    }
}