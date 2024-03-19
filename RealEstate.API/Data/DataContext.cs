using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RealEstateModel>().HasData(
                new RealEstateModel { Id = 1, Address = "Główna 12", Area = 100, Rating = 4, PricePerMetre = 1000, Price = 100000},
                new RealEstateModel { Id = 2, Address = "Dębowa 12", Area = 200, Rating = 5, PricePerMetre = 1500, Price = 300000},
                new RealEstateModel { Id = 3, Address = "Brzozowa 3", Area = 350, Rating = 7, PricePerMetre = 1500, Price = 525000},
                new RealEstateModel { Id = 4, Address = "Grunwaldzka 23/a", Area = 380, Rating = 4, PricePerMetre = 1250, Price = 225000},
                new RealEstateModel { Id = 5, Address = "Cedarowa 2", Area = 1200, Rating = 7, PricePerMetre = 80, Price = 960000},
                new RealEstateModel { Id = 6, Address = "Przedmiejska 32", Area = 1000, Rating = 6, PricePerMetre = 600, Price = 600000});

            modelBuilder.Entity<RealEstateModel>()
                .HasKey(r => r.Id);

        }
    }
}
