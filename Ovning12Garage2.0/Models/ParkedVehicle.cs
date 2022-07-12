using Ovning12Garage2._0.Models.Entites;
using System.ComponentModel.DataAnnotations;

namespace Ovning12Garage2._0.Models
{
    public class ParkedVehicle
    {
        public int Id { get; set; }
        [Required]
        public VehicleType VehicleType { get; set; }
        [Required]
        public Color Color { get; set; }
        [Required]
        public VehicleModel Brand { get; set; }
        [Required]
        [StringLength(6, ErrorMessage = "Error. Length must have 6 characters. ", MinimumLength = 6)]
        public string LicenseNumber { get; set; } = "";
        [Required]
        [Range(2, 4)]
        public int NumberOfWheels { get; set; }

        public DateTime TimeOfArrival { get; set; }

    }
}
