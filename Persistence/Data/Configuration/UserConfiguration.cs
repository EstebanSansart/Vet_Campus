using System.IO.Compression;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder){

        // Table name and define principal key

        builder.ToTable("user");
        builder.HasKey(x => x.Id);

        // Properties
        
        builder.Property(x => x.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("UserId");
        
        builder.Property(x => x.Username)
            .IsRequired()
            .HasColumnName("Username")
            .HasMaxLength(20);

        builder.Property(x => x.Email)
            .IsRequired()
            .HasColumnName("Email")
            .HasMaxLength(100);
        
        builder.Property(x => x.Password)
            .IsRequired()
            .HasColumnName("Password")
            .HasMaxLength(20);

        // Default Data

        builder.HasData(
            new{
                Id = 1,
                Username = "Admin",
                Email = "admin@example.com",
                Password = "123",
            },
            new{
                Id = 2,
                Username = "User1",
                Email = "auser1@example.com",
                Password = "123456",
            }
        );
    }
}