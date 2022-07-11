using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ovning12Garage2._0.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkedVehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleType = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<int>(type: "int", nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfWheels = table.Column<int>(type: "int", nullable: false),
                    TimeOfArrival = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkedVehicle", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ParkedVehicle",
                columns: new[] { "Id", "Brand", "Color", "LicenseNumber", "NumberOfWheels", "TimeOfArrival", "VehicleType" },
                values: new object[,]
                {
                    { 1, 0, 5, "ABC123", 4, new DateTime(2022, 7, 3, 17, 12, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 1, 0, "CBA123", 2, new DateTime(2022, 7, 5, 8, 42, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 2, 6, "PRY199", 4, new DateTime(2022, 7, 5, 11, 53, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, 4, 0, "EZD230", 4, new DateTime(2022, 7, 5, 8, 42, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, 7, 1, "HES321", 2, new DateTime(2022, 7, 5, 11, 53, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkedVehicle");
        }
    }
}
