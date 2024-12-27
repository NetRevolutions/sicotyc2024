using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sicotyc.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTablesUnitTransportandDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_COMPLEMENT_TRANSPORT_TRANSPORT_DETAIL_TransportDetailId",
                schema: "SCT",
                table: "COMPLEMENT_TRANSPORT");

            migrationBuilder.DropForeignKey(
                name: "FK_UNIT_TRANSPORT_TRANSPORT_DETAIL_TransportDetailId",
                schema: "SCT",
                table: "UNIT_TRANSPORT");

            migrationBuilder.DropTable(
                name: "TRANSPORT_DETAIL",
                schema: "SCT");

            //migrationBuilder.DropIndex(
            //    name: "IX_UNIT_TRANSPORT_TransportDetailId",
            //    schema: "SCT",
            //    table: "UNIT_TRANSPORT");           

            migrationBuilder.DropColumn(
                name: "TransportDetailId",
                schema: "SCT",
                table: "UNIT_TRANSPORT");

            migrationBuilder.AlterColumn<string>(
                name: "Ruc",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Plate",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModelYear",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FabricationYear",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "UNIT_TRANSPORT_DETAIL",
                schema: "SCT",
                columns: table => new
                {
                    UnitTransportDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngineNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BodyWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Large = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Axles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitTransportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UNIT_TRANSPORT_DETAIL", x => x.UnitTransportDetailId);
                    table.ForeignKey(
                        name: "FK_UNIT_TRANSPORT_DETAIL_UNIT_TRANSPORT_UnitTransportId",
                        column: x => x.UnitTransportId,
                        principalSchema: "SCT",
                        principalTable: "UNIT_TRANSPORT",
                        principalColumn: "UnitTransportId",
                        onDelete: ReferentialAction.Cascade);
                });
            
            migrationBuilder.CreateIndex(
                name: "IX_UNIT_TRANSPORT_DETAIL_UnitTransportId",
                schema: "SCT",
                table: "UNIT_TRANSPORT_DETAIL",
                column: "UnitTransportId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_COMPLEMENT_TRANSPORT_UNIT_TRANSPORT_DETAIL_TransportDetailId",
                schema: "SCT",
                table: "COMPLEMENT_TRANSPORT",
                column: "TransportDetailId",
                principalSchema: "SCT",
                principalTable: "UNIT_TRANSPORT_DETAIL",
                principalColumn: "UnitTransportDetailId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_COMPLEMENT_TRANSPORT_UNIT_TRANSPORT_DETAIL_TransportDetailId",
                schema: "SCT",
                table: "COMPLEMENT_TRANSPORT");

            migrationBuilder.DropTable(
                name: "UNIT_TRANSPORT_DETAIL",
                schema: "SCT");
            
            migrationBuilder.AlterColumn<string>(
                name: "Ruc",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Plate",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ModelYear",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FabricationYear",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "TransportDetailId",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "TRANSPORT_DETAIL",
                schema: "SCT",
                columns: table => new
                {
                    TransportDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Axles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BodyWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngineNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Large = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSPORT_DETAIL", x => x.TransportDetailId);
                });
            
            migrationBuilder.CreateIndex(
                name: "IX_UNIT_TRANSPORT_TransportDetailId",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                column: "TransportDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_COMPLEMENT_TRANSPORT_TRANSPORT_DETAIL_TransportDetailId",
                schema: "SCT",
                table: "COMPLEMENT_TRANSPORT",
                column: "TransportDetailId",
                principalSchema: "SCT",
                principalTable: "TRANSPORT_DETAIL",
                principalColumn: "TransportDetailId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UNIT_TRANSPORT_TRANSPORT_DETAIL_TransportDetailId",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                column: "TransportDetailId",
                principalSchema: "SCT",
                principalTable: "TRANSPORT_DETAIL",
                principalColumn: "TransportDetailId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
