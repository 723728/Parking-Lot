using Microsoft.EntityFrameworkCore;
using ParkingLot.Models;

namespace ParkingLot.DB
{
    
    public class AppPruebaContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CYBERCUP-PC;Database=ParkingLot;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // coddigo tabla tabla
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
