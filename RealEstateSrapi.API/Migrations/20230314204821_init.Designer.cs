﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealEstate.API.Data;

#nullable disable

namespace RealEstate.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230314204821_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RealEstate.API.Model.RealEstateModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Area")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PricePerMetre")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("RealEstateTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RealEstateTypeId");

                    b.ToTable("RealEstates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Główna 12",
                            Area = 100m,
                            Price = 100000m,
                            PricePerMetre = 1000m,
                            Rating = 4,
                            RealEstateTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = "Dębowa 12",
                            Area = 200m,
                            Price = 300000m,
                            PricePerMetre = 1500m,
                            Rating = 5,
                            RealEstateTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            Address = "Brzozowa 3",
                            Area = 350m,
                            Price = 525000m,
                            PricePerMetre = 1500m,
                            Rating = 7,
                            RealEstateTypeId = 3
                        },
                        new
                        {
                            Id = 4,
                            Address = "Grunwaldzka 23/a",
                            Area = 380m,
                            Price = 225000m,
                            PricePerMetre = 1250m,
                            Rating = 4,
                            RealEstateTypeId = 2
                        },
                        new
                        {
                            Id = 5,
                            Address = "Cedarowa 2",
                            Area = 1200m,
                            Price = 960000m,
                            PricePerMetre = 80m,
                            Rating = 7,
                            RealEstateTypeId = 4
                        },
                        new
                        {
                            Id = 6,
                            Address = "Przedmiejska 32",
                            Area = 1000m,
                            Price = 600000m,
                            PricePerMetre = 600m,
                            Rating = 6,
                            RealEstateTypeId = 4
                        });
                });

            modelBuilder.Entity("RealEstate.API.Model.RealEstateTypeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RealEstateTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "For living ",
                            Name = "Apartment"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Plot of land ",
                            Name = "Plot"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Work place ",
                            Name = "Office"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Industrial work place",
                            Name = "Factory"
                        });
                });

            modelBuilder.Entity("RealEstate.API.Model.RealEstateModel", b =>
                {
                    b.HasOne("RealEstate.API.Model.RealEstateTypeModel", "RealEstateType")
                        .WithMany("RealEstates")
                        .HasForeignKey("RealEstateTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("RealEstateType");
                });

            modelBuilder.Entity("RealEstate.API.Model.RealEstateTypeModel", b =>
                {
                    b.Navigation("RealEstates");
                });
#pragma warning restore 612, 618
        }
    }
}
