using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sicotyc.Server.Migrations
{
    /// <inheritdoc />
    public partial class ActualizacionNombreRolesDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("091249cd-a7b3-467d-8938-2aa534324e21"),
                column: "Name",
                value: "Administrator");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("34872081-8ad9-4a28-bd76-29be97039208"),
                column: "Name",
                value: "Agency");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("45825849-2dc8-4631-beac-aaf53f844c6e"),
                column: "Name",
                value: "Forwarder-Biller");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a784ae9-f240-48e9-a98d-57f8b557d922"),
                column: "Name",
                value: "Forwarder");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e9accb7a-dfd4-43d8-9038-ea8bf23b270d"),
                column: "Name",
                value: "Forwarder-Coordinator");            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("091249cd-a7b3-467d-8938-2aa534324e21"),
                column: "Name",
                value: "Administrador");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("34872081-8ad9-4a28-bd76-29be97039208"),
                column: "Name",
                value: "Agencia de Aduana");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("45825849-2dc8-4631-beac-aaf53f844c6e"),
                column: "Name",
                value: "Facturador de Transporte");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a784ae9-f240-48e9-a98d-57f8b557d922"),
                column: "Name",
                value: "Transportista");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e9accb7a-dfd4-43d8-9038-ea8bf23b270d"),
                column: "Name",
                value: "Coordinador de Transporte");
            
        }
    }
}
