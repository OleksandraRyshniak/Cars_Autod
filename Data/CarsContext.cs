using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cars.Data
{
    public class CarsContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<CarService> CarServices { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=Cars_DB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarService>()
                .HasKey(cs => new { cs.CarId, cs.ServiceId, cs.DateOfService });

            // Связь Car → CarService
            modelBuilder.Entity<CarService>()
                .HasOne(cs => cs.Car)
                .WithMany(c => c.CarServices)
                .HasForeignKey(cs => cs.CarId);

            // Связь Service → CarService
            modelBuilder.Entity<CarService>()
                .HasOne(cs => cs.Service)
                .WithMany(s => s.CarServices)
                .HasForeignKey(cs => cs.ServiceId);

            modelBuilder.Entity<CarService>()
            .HasOne(cs => cs.Mechanic)
            .WithMany(m => m.CarServices)
            .HasForeignKey(cs => cs.MechanicId);
        }
        public void EnsureCreated()
        {
            Database.EnsureCreated();
        }
    }
}
