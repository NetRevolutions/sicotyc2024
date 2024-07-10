using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sicotyc.Server.Migrations
{
    /// <inheritdoc />
    public partial class AlterCompanyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {            

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {   
            //migrationBuilder.DropTable(
            //    name: "COMPANY",
            //    schema: "SCT");
        }
    }
}
