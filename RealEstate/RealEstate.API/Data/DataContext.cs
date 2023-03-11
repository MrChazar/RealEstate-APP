using Microsoft.EntityFrameworkCore;
using RealEstate.API.Model;
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
                new RealEstateModel
                {
                    Id = 4,
                    Address = "Szkolna 3",
                    Area = 100,
                    Rating = 10,
                    PricePerMetre = 100,
                    Price = 100000
                }
            );
        }

    }
}
