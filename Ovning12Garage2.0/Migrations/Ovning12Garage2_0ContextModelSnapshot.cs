﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ovning12Garage2._0.Data;

#nullable disable

namespace Ovning12Garage2._0.Migrations
{
    [DbContext(typeof(Ovning12Garage2_0Context))]
    partial class Ovning12Garage2_0ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ovning12Garage2._0.Models.ParkedVehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Brand")
                        .HasColumnType("int");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfWheels")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeOfArrival")
                        .HasColumnType("datetime2");

                    b.Property<int>("VehicleType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ParkedVehicle");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = 0,
                            Color = 5,
                            LicenseNumber = "ABC123",
                            NumberOfWheels = 4,
                            TimeOfArrival = new DateTime(2022, 7, 3, 17, 12, 0, 0, DateTimeKind.Unspecified),
                            VehicleType = 0
                        },
                        new
                        {
                            Id = 2,
                            Brand = 1,
                            Color = 0,
                            LicenseNumber = "CBA123",
                            NumberOfWheels = 2,
                            TimeOfArrival = new DateTime(2022, 7, 5, 8, 42, 0, 0, DateTimeKind.Unspecified),
                            VehicleType = 1
                        },
                        new
                        {
                            Id = 3,
                            Brand = 2,
                            Color = 6,
                            LicenseNumber = "PRY199",
                            NumberOfWheels = 4,
                            TimeOfArrival = new DateTime(2022, 7, 5, 11, 53, 0, 0, DateTimeKind.Unspecified),
                            VehicleType = 0
                        },
                        new
                        {
                            Id = 4,
                            Brand = 4,
                            Color = 0,
                            LicenseNumber = "EZD230",
                            NumberOfWheels = 4,
                            TimeOfArrival = new DateTime(2022, 7, 5, 8, 42, 0, 0, DateTimeKind.Unspecified),
                            VehicleType = 0
                        },
                        new
                        {
                            Id = 5,
                            Brand = 7,
                            Color = 1,
                            LicenseNumber = "HES321",
                            NumberOfWheels = 2,
                            TimeOfArrival = new DateTime(2022, 7, 5, 11, 53, 0, 0, DateTimeKind.Unspecified),
                            VehicleType = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
