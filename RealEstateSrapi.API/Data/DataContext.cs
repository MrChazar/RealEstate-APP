using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using RealEstate.API.DTO;
using RealEstate.API.Model;
using System.Reflection.Metadata;
using System.Xml;

namespace RealEstate.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<RealEstateModel> RealEstates { get; set; }

        public DbSet<RealEstateTypeModel> RealEstateTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<RealEstateTypeModel>().HasData(
                new { Id = 1, Name = "Apartment", Description = "For living " },
                new { Id = 2, Name = "Plot", Description = "Plot of land " },
                new { Id = 3, Name = "Office", Description = "Work place " },
                new { Id = 4, Name = "Factory", Description = "Industrial work place" });
            
            modelBuilder.Entity<RealEstateModel>().HasData(
                new RealEstateModel { Id = 1, Address = "Główna 12", Area = 100, Rating = 4, PricePerMetre = 1000, Price = 100000, RealEstateTypeId = 1 },
                new RealEstateModel { Id = 2, Address = "Dębowa 12", Area = 200, Rating = 5, PricePerMetre = 1500, Price = 300000, RealEstateTypeId = 1 },
                new RealEstateModel { Id = 3, Address = "Brzozowa 3", Area = 350, Rating = 7, PricePerMetre = 1500, Price = 525000, RealEstateTypeId = 3 },
                new RealEstateModel { Id = 4, Address = "Grunwaldzka 23/a", Area = 380, Rating = 4, PricePerMetre = 1250, Price = 225000, RealEstateTypeId = 2 },
                new RealEstateModel { Id = 5, Address = "Cedarowa 2", Area = 1200, Rating = 7, PricePerMetre = 80, Price = 960000, RealEstateTypeId = 4 },
                new RealEstateModel { Id = 6, Address = "Przedmiejska 32", Area = 1000, Rating = 6, PricePerMetre = 600, Price = 600000, RealEstateTypeId = 4 });

            modelBuilder.Entity<RealEstateModel>()
                .HasOne(r => r.RealEstateType)
                .WithMany(t => t.RealEstates)
                .HasForeignKey(r => r.RealEstateTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RealEstateTypeModel>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<RealEstateModel>()
                .HasKey(r => r.Id);

        }
    }
}
