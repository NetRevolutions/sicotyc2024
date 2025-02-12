﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sicotyc.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFieldTypeInCompanyTableDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CompanyState",
                schema: "SCT",
                table: "COMPANY",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyCondition",
                schema: "SCT",
                table: "COMPANY",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CompanyState",
                schema: "SCT",
                table: "COMPANY",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyCondition",
                schema: "SCT",
                table: "COMPANY",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);            
        }
    }
}
