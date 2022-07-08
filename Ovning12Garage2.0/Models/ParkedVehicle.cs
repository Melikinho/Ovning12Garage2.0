using Ovning12Garage2._0.Models.Entites;
using System.ComponentModel.DataAnnotations;

namespace Ovning12Garage2._0.Models
{
    public class ParkedVehicle
    {
        public int Id { get; set; }
        public VehicleType VehicleType { get; set; }
        public Color Color { get; set; }

        [Required]
        public string LicenseNumber { get; set; } = "";
        public int NumberOfWheels { get; set; }

        public DateTime TimeOfArrival { get; set; }

        [Required]
        public string Brand { get; set; } = "";
        public string Model { get; set; } = "";

    }
}
