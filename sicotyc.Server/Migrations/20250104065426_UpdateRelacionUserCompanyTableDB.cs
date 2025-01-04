using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sicotyc.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelacionUserCompanyTableDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_COMPANY_TYPE_COMPANY_CompanyId",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.DropForeignKey(
                name: "FK_USER_COMPANY_COMPANY_CompanyId",
                schema: "SCT",
                table: "USER_COMPANY");

            migrationBuilder.DropForeignKey(
                name: "FK_WHAREHOUSE_COMPANY_CompanyId",
                schema: "SCT",
                table: "WHAREHOUSE");

            migrationBuilder.DropIndex(
                name: "IX_WHAREHOUSE_CompanyId",
                schema: "SCT",
                table: "WHAREHOUSE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_USER_COMPANY",
                schema: "SCT",
                table: "USER_COMPANY");

            migrationBuilder.DropIndex(
                name: "IX_USER_COMPANY_CompanyId",
                schema: "SCT",
                table: "USER_COMPANY");

            migrationBuilder.DropIndex(
                name: "IX_COMPANY_TYPE_CompanyId",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_COMPANY",
                schema: "SCT",
                table: "COMPANY");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                schema: "SCT",
                table: "WHAREHOUSE");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                schema: "SCT",
                table: "USER_COMPANY");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.AddColumn<string>(
                name: "Ruc",
                schema: "SCT",
                table: "WHAREHOUSE",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ruc",
                schema: "SCT",
                table: "USER_COMPANY",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ruc",
                schema: "SCT",
                table: "COMPANY_TYPE",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Ruc",
                schema: "SCT",
                table: "COMPANY",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_USER_COMPANY",
                schema: "SCT",
                table: "USER_COMPANY",
                columns: new[] { "Id", "Ruc" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_COMPANY",
                schema: "SCT",
                table: "COMPANY",
                column: "Ruc");            

            migrationBuilder.CreateIndex(
                name: "IX_WHAREHOUSE_Ruc",
                schema: "SCT",
                table: "WHAREHOUSE",
                column: "Ruc");

            migrationBuilder.CreateIndex(
                name: "IX_USER_COMPANY_Ruc",
                schema: "SCT",
                table: "USER_COMPANY",
                column: "Ruc");

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_TYPE_Ruc",
                schema: "SCT",
                table: "COMPANY_TYPE",
                column: "Ruc");

            migrationBuilder.AddForeignKey(
                name: "FK_COMPANY_TYPE_COMPANY_Ruc",
                schema: "SCT",
                table: "COMPANY_TYPE",
                column: "Ruc",
                principalSchema: "SCT",
                principalTable: "COMPANY",
                principalColumn: "Ruc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_USER_COMPANY_COMPANY_Ruc",
                schema: "SCT",
                table: "USER_COMPANY",
                column: "Ruc",
                principalSchema: "SCT",
                principalTable: "COMPANY",
                principalColumn: "Ruc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WHAREHOUSE_COMPANY_Ruc",
                schema: "SCT",
                table: "WHAREHOUSE",
                column: "Ruc",
                principalSchema: "SCT",
                principalTable: "COMPANY",
                principalColumn: "Ruc",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_COMPANY_TYPE_COMPANY_Ruc",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.DropForeignKey(
                name: "FK_USER_COMPANY_COMPANY_Ruc",
                schema: "SCT",
                table: "USER_COMPANY");

            migrationBuilder.DropForeignKey(
                name: "FK_WHAREHOUSE_COMPANY_Ruc",
                schema: "SCT",
                table: "WHAREHOUSE");

            migrationBuilder.DropIndex(
                name: "IX_WHAREHOUSE_Ruc",
                schema: "SCT",
                table: "WHAREHOUSE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_USER_COMPANY",
                schema: "SCT",
                table: "USER_COMPANY");

            migrationBuilder.DropIndex(
                name: "IX_USER_COMPANY_Ruc",
                schema: "SCT",
                table: "USER_COMPANY");

            migrationBuilder.DropIndex(
                name: "IX_COMPANY_TYPE_Ruc",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_COMPANY",
                schema: "SCT",
                table: "COMPANY");

            migrationBuilder.DropColumn(
                name: "Ruc",
                schema: "SCT",
                table: "WHAREHOUSE");

            migrationBuilder.DropColumn(
                name: "Ruc",
                schema: "SCT",
                table: "USER_COMPANY");

            migrationBuilder.DropColumn(
                name: "Ruc",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                schema: "SCT",
                table: "WHAREHOUSE",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                schema: "SCT",
                table: "USER_COMPANY",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                schema: "SCT",
                table: "COMPANY_TYPE",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Ruc",
                schema: "SCT",
                table: "COMPANY",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_USER_COMPANY",
                schema: "SCT",
                table: "USER_COMPANY",
                columns: new[] { "Id", "CompanyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_COMPANY",
                schema: "SCT",
                table: "COMPANY",
                column: "CompanyId");            

            migrationBuilder.CreateIndex(
                name: "IX_WHAREHOUSE_CompanyId",
                schema: "SCT",
                table: "WHAREHOUSE",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_USER_COMPANY_CompanyId",
                schema: "SCT",
                table: "USER_COMPANY",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_TYPE_CompanyId",
                schema: "SCT",
                table: "COMPANY_TYPE",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_COMPANY_TYPE_COMPANY_CompanyId",
                schema: "SCT",
                table: "COMPANY_TYPE",
                column: "CompanyId",
                principalSchema: "SCT",
                principalTable: "COMPANY",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_USER_COMPANY_COMPANY_CompanyId",
                schema: "SCT",
                table: "USER_COMPANY",
                column: "CompanyId",
                principalSchema: "SCT",
                principalTable: "COMPANY",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WHAREHOUSE_COMPANY_CompanyId",
                schema: "SCT",
                table: "WHAREHOUSE",
                column: "CompanyId",
                principalSchema: "SCT",
                principalTable: "COMPANY",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
