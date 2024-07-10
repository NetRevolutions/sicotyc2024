using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sicotyc.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddchangesinSicotyDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "FirstName",
            //    schema: "SCT",
            //    table: "DRIVER",
            //    newName: "Ruc");

            //migrationBuilder.AddColumn<string>(
            //    name: "FirstName",
            //    schema: "SCT",
            //    table: "DRIVER",
            //    type: "nvarchar(max)",
            //    nullable: true);            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "FirstName",
            //    schema: "SCT",
            //    table: "DRIVER");

            //migrationBuilder.RenameColumn(
            //    name: "Ruc",
            //    schema: "SCT",
            //    table: "DRIVER",
            //    newName: "FirstName");


        }
    }
}
