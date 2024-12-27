using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sicotyc.Server.Migrations
{
    /// <inheritdoc />
    public partial class AlterUnitTransportTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "AdditinalNotes",
            //    schema: "SCT",
            //    table: "UNIT_TRANSPORT",
            //    newName: "AdditionalNotes");

            //migrationBuilder.RenameColumn(
            //    name: "AntecedentePolicialesExpiration",
            //    schema: "SCT",
            //    table: "DRIVER",
            //    newName: "AntecedentesPolicialesExpiration");

            migrationBuilder.AlterColumn<string>(
                name: "ModelYear",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FabricationYear",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ruc",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "nvarchar(max)",
                nullable: true);            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {   
            //migrationBuilder.DropColumn(
            //    name: "AdditionalNotes",
            //    schema: "SCT",
            //    table: "UNIT_TRANSPORT");

            migrationBuilder.RenameColumn(
                name: "AdditinalNotes",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                newName: "AdditionalNotes");

            migrationBuilder.RenameColumn(
                name: "AntecedentesPolicialesExpiration",
                schema: "SCT",
                table: "DRIVER",
                newName: "AntecedentePolicialesExpiration");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModelYear",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FabricationYear",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);            
        }
    }
}
