using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sicotyc.Server.Migrations
{
    /// <inheritdoc />
    public partial class ActualizacionRelacionesParte1DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UNIT_TRANSPORT_DETAIL_UNIT_TRANSPORT_UnitTransportId",
                schema: "SCT",
                table: "UNIT_TRANSPORT_DETAIL");

            migrationBuilder.DropForeignKey(
                name: "FK_USER_DETAIL_AspNetUsers_Id",
                schema: "SCT",
                table: "USER_DETAIL");

            migrationBuilder.DropTable(
                name: "USER_COMPANY",
                schema: "SCT");

            migrationBuilder.DropIndex(
                name: "IX_UNIT_TRANSPORT_DETAIL_UnitTransportId",
                schema: "SCT",
                table: "UNIT_TRANSPORT_DETAIL");            

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "SCT",
                table: "USER_DETAIL");

            migrationBuilder.DropColumn(
                name: "UnitTransportId",
                schema: "SCT",
                table: "UNIT_TRANSPORT_DETAIL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                schema: "SCT",
                table: "USER_DETAIL",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UnitTransportDetailId",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                schema: "SCT",
                table: "COMPANY",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyComercialName",
                schema: "SCT",
                table: "COMPANY",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserDetailId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);           

            migrationBuilder.CreateIndex(
                name: "IX_UNIT_TRANSPORT_UnitTransportDetailId",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                column: "UnitTransportDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                unique: true,
                filter: "[CompanyId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserDetailId",
                table: "AspNetUsers",
                column: "UserDetailId",
                unique: true,
                filter: "[UserDetailId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_COMPANY_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalSchema: "SCT",
                principalTable: "COMPANY",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_USER_DETAIL_UserDetailId",
                table: "AspNetUsers",
                column: "UserDetailId",
                principalSchema: "SCT",
                principalTable: "USER_DETAIL",
                principalColumn: "UserDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_UNIT_TRANSPORT_UNIT_TRANSPORT_DETAIL_UnitTransportDetailId",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                column: "UnitTransportDetailId",
                principalSchema: "SCT",
                principalTable: "UNIT_TRANSPORT_DETAIL",
                principalColumn: "UnitTransportDetailId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_COMPANY_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_USER_DETAIL_UserDetailId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_UNIT_TRANSPORT_UNIT_TRANSPORT_DETAIL_UnitTransportDetailId",
                schema: "SCT",
                table: "UNIT_TRANSPORT");

            migrationBuilder.DropIndex(
                name: "IX_UNIT_TRANSPORT_UnitTransportDetailId",
                schema: "SCT",
                table: "UNIT_TRANSPORT");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserDetailId",
                table: "AspNetUsers");            

            migrationBuilder.DropColumn(
                name: "UnitTransportDetailId",
                schema: "SCT",
                table: "UNIT_TRANSPORT");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserDetailId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                schema: "SCT",
                table: "USER_DETAIL",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                schema: "SCT",
                table: "USER_DETAIL",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UnitTransportId",
                schema: "SCT",
                table: "UNIT_TRANSPORT_DETAIL",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                schema: "SCT",
                table: "COMPANY",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyComercialName",
                schema: "SCT",
                table: "COMPANY",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.CreateTable(
                name: "USER_COMPANY",
                schema: "SCT",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_COMPANY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_USER_COMPANY_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USER_COMPANY_COMPANY_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "SCT",
                        principalTable: "COMPANY",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });
            
            migrationBuilder.CreateIndex(
                name: "IX_USER_DETAIL_Id",
                schema: "SCT",
                table: "USER_DETAIL",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UNIT_TRANSPORT_DETAIL_UnitTransportId",
                schema: "SCT",
                table: "UNIT_TRANSPORT_DETAIL",
                column: "UnitTransportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_USER_COMPANY_CompanyId",
                schema: "SCT",
                table: "USER_COMPANY",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_UNIT_TRANSPORT_DETAIL_UNIT_TRANSPORT_UnitTransportId",
                schema: "SCT",
                table: "UNIT_TRANSPORT_DETAIL",
                column: "UnitTransportId",
                principalSchema: "SCT",
                principalTable: "UNIT_TRANSPORT",
                principalColumn: "UnitTransportId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_USER_DETAIL_AspNetUsers_Id",
                schema: "SCT",
                table: "USER_DETAIL",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
