using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sicotyc.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixRelationLookupCodeGroupAndLookupCode_InsertDataDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ae717f3-428e-46cb-808c-30f0a05a457e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34c33b0d-47fb-4f64-92a2-0521f6538528");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b576e31-4467-46cc-bd79-3e184eb39fa0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7af8519-8057-4c45-b912-bf6bb38370b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0c085eb-da78-458d-8717-08da4654f432");

            migrationBuilder.AlterColumn<string>(
                name: "LookupCodeValue",
                schema: "SCT",
                table: "LOOKUP_CODE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LookupCodeName",
                schema: "SCT",
                table: "LOOKUP_CODE",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ecda6cd-df51-4a1a-aace-27f8177727a7", null, "Forwarder-Coordinator", "FORWARDER-COORDINATOR" },
                    { "2850725c-fb45-44b2-bdb2-f7ae80b6014a", null, "Forwarder-Biller", "FORWARDER-BILLER" },
                    { "5f4694c1-ac2f-4a31-b126-8d34cfbb77b1", null, "Forwarder", "FORWARDER" },
                    { "90d9315e-11a4-4b9b-8cbf-bf73088eba09", null, "Agency", "AGENCY" },
                    { "d314f417-ef68-43ff-9e4c-1a19a87ed51c", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1a011e51-2471-4ccd-174c-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2113));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1aec098a-859a-4586-80b6-b6f4beb848fb"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("23078793-cd0a-4718-2aa4-08da71da4714"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2114));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("2d253e01-afa1-4a59-bc6a-26526f0d8498"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("37a294bb-d8e2-4655-80a8-a2fe719766d4"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2015));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("47b84a27-c75a-44d3-174d-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("50bd3490-2377-4945-9229-f018f6b07bf8"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2022));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("58250d62-975a-4883-81f7-946c91cf2dec"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("5f38d3fd-f34e-45eb-aebf-512f5ebd94ee"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2121));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("6963984f-c5e0-4ed9-9647-46ac7054e344"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2118));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("6b1b516f-9073-4657-8a4c-9cb7ebe8ea25"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("752ce625-da67-4842-b19d-18c5572dbbce"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("792f255c-2b8b-42e6-9968-2855373e5c86"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("7e603067-a1ed-4b52-174b-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2111));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("867c1549-7132-4e8e-174a-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8bd83659-b611-488d-aaac-e5d418bac06c"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8dc0180a-2ffc-4807-803a-37aab6ecaab2"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8e009c6d-5920-4135-8a26-49ec04c6e7d5"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2026));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b2a7d680-b5dc-41d1-9792-695602fc2954"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2082));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("de0cc597-ad66-4497-acab-33617eb077bd"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2078));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e129c250-de59-45d3-8794-58e073ff8064"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2017));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e5c70df3-cf54-477f-881d-7d142f0b51aa"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2124));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e83581fc-e05c-4c80-b5c2-e381fd7765d7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2119));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("eaf628ee-9413-472e-a5b7-3c9d45f10cf0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("f7ab3cf1-afe9-4b2b-977f-953d9f3b9275"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2024));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fdc11a23-1dc7-4160-bb9d-019579c56e46"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fe8b2536-5a20-4680-8dfe-526000df87e1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("71b0316a-9831-499a-b9bb-08da70ae70ed"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1821));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("86d227dc-e0ca-4a78-85f4-83a6eb30cbc7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1817));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("c6ed82d5-4a24-464b-bebd-f33c0b7f7d80"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1823));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("cda56e87-1b44-4625-9f19-ac7eb282a9b7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1811));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("e4d10bc8-a160-4a9d-bc87-c94cf849e14c"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.InsertData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                columns: new[] { "LookupCodeGroupId", "CreatedOn", "CreatedBy", "DeletedOn", "LookupCodeGroupName", "LastUpdatedOn", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1824), "SYSTEM", null, "TIPO DE UNIDAD DE TRANSPORTE", null, null },
                    { new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1793), "SYSTEM", null, "CATEGORIA VEHICULOS", null, null },
                    { new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1820), "SYSTEM", null, "TIPO DE LICENCIA DE CONDUCIR", null, null },
                    { new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1814), "SYSTEM", null, "ESTADO EMPRESA", null, null },
                    { new Guid("d86c0ad0-1f0f-4d1d-b2c1-232874477770"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1813), "SYSTEM", null, "CONDICION EMPRESA", null, null },
                    { new Guid("f6112698-650a-4567-8a85-b73755ae39c0"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1816), "SYSTEM", null, "TIPO DE COMBUSTIBLE", null, null }
                });

            migrationBuilder.InsertData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                columns: new[] { "LookupCodeId", "CreatedOn", "CreatedBy", "DeletedOn", "LookupCodeGroupId", "LookupCodeName", "LookupCodeOrder", "LookupCodeValue", "LastUpdatedOn", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0304a87a-e49f-4811-a2a7-e68faf0f6930"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2064), "SYSTEM", null, new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"), "Obligado a emitir comprobantes electronicos", 6, "OBLIGADO_EMITIR_COMPROBANTE_ELECTRONICO", null, null },
                    { new Guid("0a66a417-0aaa-4aec-9cc6-e93a29598191"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2142), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "CAMA BAJA 40 PIES", 10, "CB40", null, null },
                    { new Guid("11e436c6-929e-41d2-bb40-ef58b0a6c54a"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2089), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "A-I", 1, "A1", null, null },
                    { new Guid("14b7d51d-1584-4224-8c9b-fd3da3de7b23"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2000), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "O4 - Remolques de PBV mayor a 10 TN", 15, "O4", null, null },
                    { new Guid("14e4dfed-e5ae-4a07-886a-f8a685e1bb03"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2107), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "A-IV o Especial", 11, "A4", null, null },
                    { new Guid("15db719f-1d18-406d-bc4b-144df7dce134"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2034), "SYSTEM", null, new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"), "Baja Temporal", 3, "BAJA_TEMPORAL", null, null },
                    { new Guid("15fb0388-449a-493e-8b25-b5c9d48724de"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1980), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "L4 - Tres Ruedas Asimetricas al Eje Longitudinal", 4, "L4", null, null },
                    { new Guid("16ff9b37-0c2b-425a-b13b-d7e4113a56f1"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2095), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "A-IIIb", 5, "A3B", null, null },
                    { new Guid("1c8b7baf-7a76-4469-94b1-b6b79b87d3bc"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2137), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "CONTAINERA DE 20 PIES (2 EJES)", 7, "CONT20S2", null, null },
                    { new Guid("1d6bfbaf-130a-48d3-b87a-16bc27544b17"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2036), "SYSTEM", null, new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"), "Baja Definitiva", 4, "BAJA_DEFINITIVA", null, null },
                    { new Guid("1e083ea3-4b61-4576-94fb-2cb0691f56bb"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2073), "SYSTEM", null, new Guid("f6112698-650a-4567-8a85-b73755ae39c0"), "GNV (Gas Natural Vehicular)", 4, "GNV", null, null },
                    { new Guid("1f0c7bcb-2f90-4ec4-89fa-87c7ec50a96a"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2062), "SYSTEM", null, new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"), "Omiso", 5, "OMISO", null, null },
                    { new Guid("2807add9-17f6-4d7d-afb4-5a66de3feab0"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2070), "SYSTEM", null, new Guid("f6112698-650a-4567-8a85-b73755ae39c0"), "GLP (Gas Licuado de Petroleo)", 3, "GLP", null, null },
                    { new Guid("2ea5c93e-b7e5-41d9-8db1-dce45c0975da"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2131), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "PLATAFORMA DE  40 PIES (3 EJES)", 3, "PLAT40S3", null, null },
                    { new Guid("335af8da-4070-4382-9948-78f5d7c608ad"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2094), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "A-IIIa", 4, "A3A", null, null },
                    { new Guid("43d3b835-0099-4c90-97e8-a90e46263981"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1975), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "L2 - Tres Ruedas - Hasta 50 cm3 - Vel. Max. 50 km/h", 2, "L2", null, null },
                    { new Guid("47aa2631-2500-49b9-bb9a-b52dce33c3d4"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2146), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "CAMA CUNA 40 PIES", 12, "CC40", null, null },
                    { new Guid("4a12b60a-033e-495e-98a8-7899a952a4d2"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2100), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "B-IIa", 8, "B2A", null, null },
                    { new Guid("4cfe7678-6e98-4ce9-a031-9a9e6d205996"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2001), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "SA - Casas Rodantes", 16, "SA", null, null },
                    { new Guid("53b2d295-6628-4f70-bacd-887a7fe4c34f"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2068), "SYSTEM", null, new Guid("f6112698-650a-4567-8a85-b73755ae39c0"), "Gasolina", 2, "GAS", null, null },
                    { new Guid("5c2d783a-8d86-40db-a682-abff1ebe1325"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1971), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "L1 - Dos Ruedas - Hasta 50 cm3 - Vel. Max. 50 km/h", 1, "L1", null, null },
                    { new Guid("603ecb5e-9e89-462c-89b6-eedd06337574"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2012), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "SG - Porta Tropas", 22, "SG", null, null },
                    { new Guid("69522111-2411-4920-ad1c-7a60b8d15a2f"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1998), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "O3 - Remolques de PBV mayor a 3.5 TN hasta 10 TN", 14, "O3", null, null },
                    { new Guid("69b2e6e4-3652-43f5-bbe7-46319d143f1e"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1983), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "M1 - Hasta 9 Asientos (Inc. conductor)", 6, "M1", null, null },
                    { new Guid("6b440bd4-1fc3-4ff0-a657-d2da4cd7667c"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1978), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "L3 - Dos Ruedas - Mas de 50 cm3 - Vel. Mayor 50 km/h", 3, "L3", null, null },
                    { new Guid("7568f431-f970-42f2-860b-52b3d56e89f7"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1993), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "N3 - De PBV mayor a 12 TN", 11, "N3", null, null },
                    { new Guid("78d4d89c-efc4-4672-9b41-bfb5bf6ce748"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2027), "SYSTEM", null, new Guid("d86c0ad0-1f0f-4d1d-b2c1-232874477770"), "Habido", 1, "HABIDO", null, null },
                    { new Guid("798912f4-7813-4126-9c99-c9921f85da6b"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2066), "SYSTEM", null, new Guid("f6112698-650a-4567-8a85-b73755ae39c0"), "DIESEL", 1, "DSL", null, null },
                    { new Guid("7a989cd1-be51-44c7-9e5b-a506942a0836"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2003), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "SB - Vehiculos Blindados para el transporte de Valores", 17, "SB", null, null },
                    { new Guid("80779654-c53e-4502-b230-39476d0b5a31"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2136), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "CONTAINERA DE 40 PIES (3 EJES)", 6, "CONT40S3", null, null },
                    { new Guid("8185bf65-4cb0-45ad-85e2-5782302ec1fe"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2006), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "SD - Vehiculos Funerarios", 19, "SD", null, null },
                    { new Guid("852e1cdc-8ba1-4615-acee-fc1692dc2d44"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2009), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "SE - Bomberos", 20, "SE", null, null },
                    { new Guid("8b22ce5a-1d4c-436a-92dc-bff4c9af8565"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2127), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "REMOLCADOR", 1, "REM", null, null },
                    { new Guid("8fff4f82-3314-4f5b-a255-661d5b5b2a6e"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2099), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "B-I", 7, "B1", null, null },
                    { new Guid("99da2463-52a3-4e35-978b-99c3c7a8c7fc"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2129), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "PLATAFORMA DE  40 PIES (2 EJES)", 2, "PLAT40S2", null, null },
                    { new Guid("a15fb960-6ed5-4562-8a91-76f069380bdc"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2141), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "FURGON ALAS DE GAVIOTA", 9, "FURGALGAV", null, null },
                    { new Guid("a2305318-91ce-4da7-aa32-dc00dc3a129b"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2032), "SYSTEM", null, new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"), "Obligado a llevar Contabilidad", 2, "OBLIGADO_LLEVAR_CONTABILIDAD", null, null },
                    { new Guid("aac495f0-cf83-40c2-90bc-b6edab8d02d5"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2139), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "FURGON CERRADO", 8, "FURGCER", null, null },
                    { new Guid("acad96fe-fcc8-428b-b597-33e75dd3a5ea"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1991), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "N2 - De PBV mayor a 3.5 TN hasta 12 TN", 10, "N2", null, null },
                    { new Guid("b18cc534-6c71-43e7-b3a7-c0ff2d8f7cd6"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2132), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "PLATAFORMA DE  20 PIES (2 EJES)", 4, "PLAT20S2", null, null },
                    { new Guid("b65d8f64-a4a7-4a67-9554-8bbe686f1918"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2097), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "A-IIIc", 6, "A3C", null, null },
                    { new Guid("b95c8dbf-b7bc-4a4c-82cf-2ec93d976934"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1995), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "O1 - Remolques de PBV de 0.75 TN o menos", 12, "O1", null, null },
                    { new Guid("b997a2d6-aa12-46e8-b074-2222c388fcc1"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1988), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "M3 - Mas de 9 asientos - PBV Mayor 5 TN", 8, "M3", null, null },
                    { new Guid("bdaac09a-fb61-4c12-8756-08cf07bb8cdd"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2092), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "A-IIb", 3, "A2B", null, null },
                    { new Guid("c4a84b0a-bd4a-44b5-854e-6895ee11c347"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1996), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "O2 - Remolques de PBV mayor a 0.75 TN hasta 3.5 TN", 13, "O2", null, null },
                    { new Guid("ce065324-c0f1-401d-a3b4-b4284204ab8b"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2144), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "CAMA BAJA 20 PIES", 11, "CB20", null, null },
                    { new Guid("d49052cc-b76c-41ed-97a2-0586745a44bc"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2102), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "B-IIb", 9, "B2B", null, null },
                    { new Guid("d8d6121d-f8dd-4042-a45f-d3f4d9304d1d"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2090), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "A-IIa", 2, "A2A", null, null },
                    { new Guid("da120915-15f5-46fc-af15-fee8d5939f86"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2005), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "SC - Ambulancias", 18, "SC", null, null },
                    { new Guid("e0a65440-da87-454d-aafc-cd59a53a92d1"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2031), "SYSTEM", null, new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"), "Activo", 1, "ACTIVO", null, null },
                    { new Guid("e109ec6d-3b84-4978-b725-e00cbe152819"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2029), "SYSTEM", null, new Guid("d86c0ad0-1f0f-4d1d-b2c1-232874477770"), "No Habido", 2, "NO_HABIDO", null, null },
                    { new Guid("e3023e84-144e-4c66-b508-1d6c03c8e452"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1981), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "L5 - Tres Ruedas Simetricas al Eje Longitudinal, Peso menor a 1 TN", 5, "L5", null, null },
                    { new Guid("e50c94ee-a2fc-4817-be47-fc24a2e762fd"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1989), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "N1 - De PBV de 3.5 TN o menos", 9, "N1", null, null },
                    { new Guid("ef6bfaf8-6b4b-40fd-a13a-6bdc27d8bec0"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2010), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "SF - Vehiculos Celulares", 21, "SF", null, null },
                    { new Guid("f9775a11-583d-435b-a9c9-1b30d6b08e65"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2134), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "CONTAINERA DE 40 PIES (2 EJES)", 5, "CONT40S2", null, null },
                    { new Guid("fc61f0ae-1fac-4f04-a87a-7fe542e4398e"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1986), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "M2 - Mas de 9 asientos - PBV Maximo 5 TN", 7, "M2", null, null },
                    { new Guid("fdc88de9-5c83-43f7-a689-6aed7fe375c2"), new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2104), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "B-IIc", 10, "B2C", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ecda6cd-df51-4a1a-aace-27f8177727a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2850725c-fb45-44b2-bdb2-f7ae80b6014a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f4694c1-ac2f-4a31-b126-8d34cfbb77b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90d9315e-11a4-4b9b-8cbf-bf73088eba09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d314f417-ef68-43ff-9e4c-1a19a87ed51c");

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("0304a87a-e49f-4811-a2a7-e68faf0f6930"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("0a66a417-0aaa-4aec-9cc6-e93a29598191"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("11e436c6-929e-41d2-bb40-ef58b0a6c54a"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("14b7d51d-1584-4224-8c9b-fd3da3de7b23"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("14e4dfed-e5ae-4a07-886a-f8a685e1bb03"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("15db719f-1d18-406d-bc4b-144df7dce134"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("15fb0388-449a-493e-8b25-b5c9d48724de"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("16ff9b37-0c2b-425a-b13b-d7e4113a56f1"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1c8b7baf-7a76-4469-94b1-b6b79b87d3bc"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1d6bfbaf-130a-48d3-b87a-16bc27544b17"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1e083ea3-4b61-4576-94fb-2cb0691f56bb"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1f0c7bcb-2f90-4ec4-89fa-87c7ec50a96a"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("2807add9-17f6-4d7d-afb4-5a66de3feab0"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("2ea5c93e-b7e5-41d9-8db1-dce45c0975da"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("335af8da-4070-4382-9948-78f5d7c608ad"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("43d3b835-0099-4c90-97e8-a90e46263981"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("47aa2631-2500-49b9-bb9a-b52dce33c3d4"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("4a12b60a-033e-495e-98a8-7899a952a4d2"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("4cfe7678-6e98-4ce9-a031-9a9e6d205996"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("53b2d295-6628-4f70-bacd-887a7fe4c34f"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("5c2d783a-8d86-40db-a682-abff1ebe1325"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("603ecb5e-9e89-462c-89b6-eedd06337574"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("69522111-2411-4920-ad1c-7a60b8d15a2f"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("69b2e6e4-3652-43f5-bbe7-46319d143f1e"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("6b440bd4-1fc3-4ff0-a657-d2da4cd7667c"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("7568f431-f970-42f2-860b-52b3d56e89f7"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("78d4d89c-efc4-4672-9b41-bfb5bf6ce748"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("798912f4-7813-4126-9c99-c9921f85da6b"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("7a989cd1-be51-44c7-9e5b-a506942a0836"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("80779654-c53e-4502-b230-39476d0b5a31"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8185bf65-4cb0-45ad-85e2-5782302ec1fe"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("852e1cdc-8ba1-4615-acee-fc1692dc2d44"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8b22ce5a-1d4c-436a-92dc-bff4c9af8565"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8fff4f82-3314-4f5b-a255-661d5b5b2a6e"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("99da2463-52a3-4e35-978b-99c3c7a8c7fc"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("a15fb960-6ed5-4562-8a91-76f069380bdc"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("a2305318-91ce-4da7-aa32-dc00dc3a129b"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("aac495f0-cf83-40c2-90bc-b6edab8d02d5"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("acad96fe-fcc8-428b-b597-33e75dd3a5ea"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b18cc534-6c71-43e7-b3a7-c0ff2d8f7cd6"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b65d8f64-a4a7-4a67-9554-8bbe686f1918"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b95c8dbf-b7bc-4a4c-82cf-2ec93d976934"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b997a2d6-aa12-46e8-b074-2222c388fcc1"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("bdaac09a-fb61-4c12-8756-08cf07bb8cdd"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("c4a84b0a-bd4a-44b5-854e-6895ee11c347"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("ce065324-c0f1-401d-a3b4-b4284204ab8b"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("d49052cc-b76c-41ed-97a2-0586745a44bc"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("d8d6121d-f8dd-4042-a45f-d3f4d9304d1d"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("da120915-15f5-46fc-af15-fee8d5939f86"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e0a65440-da87-454d-aafc-cd59a53a92d1"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e109ec6d-3b84-4978-b725-e00cbe152819"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e3023e84-144e-4c66-b508-1d6c03c8e452"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e50c94ee-a2fc-4817-be47-fc24a2e762fd"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("ef6bfaf8-6b4b-40fd-a13a-6bdc27d8bec0"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("f9775a11-583d-435b-a9c9-1b30d6b08e65"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fc61f0ae-1fac-4f04-a87a-7fe542e4398e"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fdc88de9-5c83-43f7-a689-6aed7fe375c2"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("d86c0ad0-1f0f-4d1d-b2c1-232874477770"));

            migrationBuilder.DeleteData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("f6112698-650a-4567-8a85-b73755ae39c0"));

            migrationBuilder.AlterColumn<string>(
                name: "LookupCodeValue",
                schema: "SCT",
                table: "LOOKUP_CODE",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LookupCodeName",
                schema: "SCT",
                table: "LOOKUP_CODE",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ae717f3-428e-46cb-808c-30f0a05a457e", null, "Forwarder-Biller", "FORWARDER-BILLER" },
                    { "34c33b0d-47fb-4f64-92a2-0521f6538528", null, "Agency", "AGENCY" },
                    { "7b576e31-4467-46cc-bd79-3e184eb39fa0", null, "Forwarder-Coordinator", "FORWARDER-COORDINATOR" },
                    { "a7af8519-8057-4c45-b912-bf6bb38370b8", null, "Forwarder", "FORWARDER" },
                    { "d0c085eb-da78-458d-8717-08da4654f432", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1a011e51-2471-4ccd-174c-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1aec098a-859a-4586-80b6-b6f4beb848fb"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("23078793-cd0a-4718-2aa4-08da71da4714"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("2d253e01-afa1-4a59-bc6a-26526f0d8498"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("37a294bb-d8e2-4655-80a8-a2fe719766d4"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("47b84a27-c75a-44d3-174d-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("50bd3490-2377-4945-9229-f018f6b07bf8"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("58250d62-975a-4883-81f7-946c91cf2dec"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7012));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("5f38d3fd-f34e-45eb-aebf-512f5ebd94ee"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("6963984f-c5e0-4ed9-9647-46ac7054e344"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("6b1b516f-9073-4657-8a4c-9cb7ebe8ea25"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("752ce625-da67-4842-b19d-18c5572dbbce"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("792f255c-2b8b-42e6-9968-2855373e5c86"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("7e603067-a1ed-4b52-174b-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(6989));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("867c1549-7132-4e8e-174a-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8bd83659-b611-488d-aaac-e5d418bac06c"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7022));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8dc0180a-2ffc-4807-803a-37aab6ecaab2"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8e009c6d-5920-4135-8a26-49ec04c6e7d5"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b2a7d680-b5dc-41d1-9792-695602fc2954"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("de0cc597-ad66-4497-acab-33617eb077bd"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e129c250-de59-45d3-8794-58e073ff8064"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7027));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e5c70df3-cf54-477f-881d-7d142f0b51aa"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7021));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e83581fc-e05c-4c80-b5c2-e381fd7765d7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("eaf628ee-9413-472e-a5b7-3c9d45f10cf0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("f7ab3cf1-afe9-4b2b-977f-953d9f3b9275"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fdc11a23-1dc7-4160-bb9d-019579c56e46"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fe8b2536-5a20-4680-8dfe-526000df87e1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("71b0316a-9831-499a-b9bb-08da70ae70ed"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("86d227dc-e0ca-4a78-85f4-83a6eb30cbc7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("c6ed82d5-4a24-464b-bebd-f33c0b7f7d80"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("cda56e87-1b44-4625-9f19-ac7eb282a9b7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(6821));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("e4d10bc8-a160-4a9d-bc87-c94cf849e14c"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 7, 13, 34, 478, DateTimeKind.Utc).AddTicks(6818));
        }
    }
}
