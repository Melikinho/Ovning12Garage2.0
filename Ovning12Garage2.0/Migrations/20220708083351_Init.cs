﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ovning12Garage2._0.Migrations
{
    public partial class Init : Migration
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
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfWheels = table.Column<int>(type: "int", nullable: false),
                    TimeOfArrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkedVehicle", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkedVehicle");
        }
    }
}
