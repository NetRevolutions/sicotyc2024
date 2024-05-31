using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sicotyc.Server.Migrations
{
    /// <inheritdoc />
    public partial class NewChangesSicotycDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyComercialName",
                schema: "SCT",
                table: "COMPANY",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {           
            migrationBuilder.DropColumn(
                name: "CompanyComercialName",
                schema: "SCT",
                table: "COMPANY");
        }
    }
}
