using Microsoft.EntityFrameworkCore;
using Parking_Lot.DB.Configurations;
using Parking_Lot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking_Lot.DB
{
    public class AppPruebaContext : DbContext
    {
        public DbSet<User>     Users     { get; set; }
        public DbSet<Tarjeta>  Tarjetas  { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CYBERCUP-PC;Database=ParkingLot;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // coddigo tabla tabla
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new TarjetaConfiguration());
            modelBuilder.ApplyConfiguration(new VehiculoConfiguration());
        }

    }
}
