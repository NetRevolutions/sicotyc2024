using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sicotyc.Server.Migrations
{
    /// <inheritdoc />
    public partial class ReestructureCompanyTypeDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_COMPANY_TYPE",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.DropIndex(
                name: "IX_COMPANY_TYPE_Ruc",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.DropColumn(
                name: "CompanyTypeId",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.DropColumn(
                name: "CompanyTypeName",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.DropColumn(
                name: "LastUpdatedOn",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.AddColumn<string>(
                name: "TypeOfCompany",
                schema: "SCT",
                table: "COMPANY_TYPE",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_LOOKUP_CODE_LookupCodeValue",
                schema: "SCT",
                table: "LOOKUP_CODE",
                column: "LookupCodeValue");

            migrationBuilder.AddPrimaryKey(
                name: "PK_COMPANY_TYPE",
                schema: "SCT",
                table: "COMPANY_TYPE",
                columns: new[] { "Ruc", "TypeOfCompany" });            

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_TYPE_TypeOfCompany",
                schema: "SCT",
                table: "COMPANY_TYPE",
                column: "TypeOfCompany");

            migrationBuilder.AddForeignKey(
                name: "FK_COMPANY_TYPE_LOOKUP_CODE_TypeOfCompany",
                schema: "SCT",
                table: "COMPANY_TYPE",
                column: "TypeOfCompany",
                principalSchema: "SCT",
                principalTable: "LOOKUP_CODE",
                principalColumn: "LookupCodeValue",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_COMPANY_TYPE_LOOKUP_CODE_TypeOfCompany",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_LOOKUP_CODE_LookupCodeValue",
                schema: "SCT",
                table: "LOOKUP_CODE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_COMPANY_TYPE",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.DropIndex(
                name: "IX_COMPANY_TYPE_TypeOfCompany",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.DropColumn(
                name: "TypeOfCompany",
                schema: "SCT",
                table: "COMPANY_TYPE");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyTypeId",
                schema: "SCT",
                table: "COMPANY_TYPE",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "CompanyTypeName",
                schema: "SCT",
                table: "COMPANY_TYPE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "SCT",
                table: "COMPANY_TYPE",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "SCT",
                table: "COMPANY_TYPE",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                schema: "SCT",
                table: "COMPANY_TYPE",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedOn",
                schema: "SCT",
                table: "COMPANY_TYPE",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                schema: "SCT",
                table: "COMPANY_TYPE",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_COMPANY_TYPE",
                schema: "SCT",
                table: "COMPANY_TYPE",
                column: "CompanyTypeId");            

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_TYPE_Ruc",
                schema: "SCT",
                table: "COMPANY_TYPE",
                column: "Ruc");
        }
    }
}
