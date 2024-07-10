using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sicotyc.Server.Migrations
{
    /// <inheritdoc />
    public partial class Changestructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AlterColumn<DateTime>(
                name: "LicenseExpiration",
                schema: "SCT",
                table: "DRIVER_LICENSE",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DriverLicenseId",
                schema: "SCT",
                table: "DRIVER_LICENSE",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {            
            migrationBuilder.DropColumn(
                name: "DriverLicenseId",
                schema: "SCT",
                table: "DRIVER_LICENSE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LicenseExpiration",
                schema: "SCT",
                table: "DRIVER_LICENSE",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");            
        }
    }
}
