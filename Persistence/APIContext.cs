using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> conf):base(conf){}

        //DbSets
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Lab> Labs { get; set; }
        public DbSet<MedicalTreatment> MedicalTreatments { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<MedicineMovement> MedicineMovements { get; set; }
        public DbSet<MovementDetail> MovementDetails { get; set; }
        public DbSet<MovementType> MovementTypes { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<RefreshTokenRecord> RefreshTokenRecords { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Species> Speciess { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vet> Vets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}