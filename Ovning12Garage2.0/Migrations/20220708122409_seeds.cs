using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ovning12Garage2._0.Migrations
{
    public partial class seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "ParkedVehicle");

            migrationBuilder.AlterColumn<int>(
                name: "Brand",
                table: "ParkedVehicle",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
            migrationBuilder.DeleteData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "ParkedVehicle",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "ParkedVehicle",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
