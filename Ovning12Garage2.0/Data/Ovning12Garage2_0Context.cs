using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ovning12Garage2._0.Models;

namespace Ovning12Garage2._0.Data
{
    public class Ovning12Garage2_0Context : DbContext
    {
        public Ovning12Garage2_0Context (DbContextOptions<Ovning12Garage2_0Context> options)
            : base(options)
        {
        }

        public DbSet<Ovning12Garage2._0.Models.ParkedVehicle>? ParkedVehicle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ParkedVehicle>().HasData(
                new ParkedVehicle { Id = 1, LicenseNumber = "ABC123", VehicleType = Models.Entites.VehicleType.Car, Brand = Models.Entites.VehicleModel.Volvo, Color = Models.Entites.Color.Green, NumberOfWheels = 4, TimeOfArrival = DateTime.Parse("2022-07-03 17:12") },
                new ParkedVehicle { Id = 2, LicenseNumber = "CBA123", VehicleType = Models.Entites.VehicleType.Motorcycle, Brand = Models.Entites.VehicleModel.SAAB, Color = Models.Entites.Color.Black, NumberOfWheels = 2, TimeOfArrival = DateTime.Parse("2022-07-05 08:42") },
                new ParkedVehicle { Id = 3, LicenseNumber = "PRY199", VehicleType = Models.Entites.VehicleType.Car, Brand = Models.Entites.VehicleModel.BMW, Color = Models.Entites.Color.Blue, NumberOfWheels = 4, TimeOfArrival = DateTime.Parse("2022-07-05 11:53") },
                new ParkedVehicle { Id = 4, LicenseNumber = "EZD230", VehicleType = Models.Entites.VehicleType.Car, Brand = Models.Entites.VehicleModel.Mercedes, Color = Models.Entites.Color.Black, NumberOfWheels = 4, TimeOfArrival = DateTime.Parse("2022-07-05 08:42") },
                new ParkedVehicle { Id = 5, LicenseNumber = "HES321", VehicleType = Models.Entites.VehicleType.Motorcycle, Brand = Models.Entites.VehicleModel.Fiat, Color = Models.Entites.Color.Black,  NumberOfWheels = 2, TimeOfArrival = DateTime.Parse("2022-07-05 11:53") }
                );
        }
    }
}
