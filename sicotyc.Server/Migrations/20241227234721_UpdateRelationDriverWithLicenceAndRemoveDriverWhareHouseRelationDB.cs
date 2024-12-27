using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sicotyc.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationDriverWithLicenceAndRemoveDriverWhareHouseRelationDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DRIVER_WHAREHOUSE",
                schema: "SCT");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03cd2485-b66c-4e43-a219-4720c56469dc", null, "Agency", "AGENCY" },
                    { "187a6673-b53c-4f5c-9522-d97e59786321", null, "Forwarder", "FORWARDER" },
                    { "5f2333e8-3dad-4501-bc02-d551c36c36f9", null, "Administrator", "ADMINISTRATOR" },
                    { "775bf3af-5f53-480c-9aff-6f3fa69ffc91", null, "Forwarder-Coordinator", "FORWARDER-COORDINATOR" },
                    { "8cc8e2ea-5892-4b0d-b5f4-387ce88b3621", null, "Forwarder-Biller", "FORWARDER-BILLER" }
                });

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("0304a87a-e49f-4811-a2a7-e68faf0f6930"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9565));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("0a66a417-0aaa-4aec-9cc6-e93a29598191"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("11e436c6-929e-41d2-bb40-ef58b0a6c54a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("14b7d51d-1584-4224-8c9b-fd3da3de7b23"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("14e4dfed-e5ae-4a07-886a-f8a685e1bb03"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("15db719f-1d18-406d-bc4b-144df7dce134"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9559));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("15fb0388-449a-493e-8b25-b5c9d48724de"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("16ff9b37-0c2b-425a-b13b-d7e4113a56f1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1a011e51-2471-4ccd-174c-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1aec098a-859a-4586-80b6-b6f4beb848fb"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9542));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1c8b7baf-7a76-4469-94b1-b6b79b87d3bc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1d6bfbaf-130a-48d3-b87a-16bc27544b17"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1e083ea3-4b61-4576-94fb-2cb0691f56bb"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9594));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1f0c7bcb-2f90-4ec4-89fa-87c7ec50a96a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9563));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("23078793-cd0a-4718-2aa4-08da71da4714"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("2807add9-17f6-4d7d-afb4-5a66de3feab0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("2d253e01-afa1-4a59-bc6a-26526f0d8498"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("2ea5c93e-b7e5-41d9-8db1-dce45c0975da"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9654));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("335af8da-4070-4382-9948-78f5d7c608ad"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("37a294bb-d8e2-4655-80a8-a2fe719766d4"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("43d3b835-0099-4c90-97e8-a90e46263981"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("47aa2631-2500-49b9-bb9a-b52dce33c3d4"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9669));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("47b84a27-c75a-44d3-174d-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("4a12b60a-033e-495e-98a8-7899a952a4d2"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("4cfe7678-6e98-4ce9-a031-9a9e6d205996"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("50bd3490-2377-4945-9229-f018f6b07bf8"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9544));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("53b2d295-6628-4f70-bacd-887a7fe4c34f"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("58250d62-975a-4883-81f7-946c91cf2dec"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("5c2d783a-8d86-40db-a682-abff1ebe1325"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("5f38d3fd-f34e-45eb-aebf-512f5ebd94ee"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("603ecb5e-9e89-462c-89b6-eedd06337574"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("69522111-2411-4920-ad1c-7a60b8d15a2f"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("6963984f-c5e0-4ed9-9647-46ac7054e344"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("69b2e6e4-3652-43f5-bbe7-46319d143f1e"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9503));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("6b1b516f-9073-4657-8a4c-9cb7ebe8ea25"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("6b440bd4-1fc3-4ff0-a657-d2da4cd7667c"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("752ce625-da67-4842-b19d-18c5572dbbce"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("7568f431-f970-42f2-860b-52b3d56e89f7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("78d4d89c-efc4-4672-9b41-bfb5bf6ce748"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9549));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("792f255c-2b8b-42e6-9968-2855373e5c86"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("798912f4-7813-4126-9c99-c9921f85da6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("7a989cd1-be51-44c7-9e5b-a506942a0836"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("7e603067-a1ed-4b52-174b-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9631));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("80779654-c53e-4502-b230-39476d0b5a31"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9659));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8185bf65-4cb0-45ad-85e2-5782302ec1fe"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("852e1cdc-8ba1-4615-acee-fc1692dc2d44"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("867c1549-7132-4e8e-174a-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8b22ce5a-1d4c-436a-92dc-bff4c9af8565"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9651));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8bd83659-b611-488d-aaac-e5d418bac06c"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8dc0180a-2ffc-4807-803a-37aab6ecaab2"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8e009c6d-5920-4135-8a26-49ec04c6e7d5"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8fff4f82-3314-4f5b-a255-661d5b5b2a6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9621));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("99da2463-52a3-4e35-978b-99c3c7a8c7fc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9653));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("a15fb960-6ed5-4562-8a91-76f069380bdc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("a2305318-91ce-4da7-aa32-dc00dc3a129b"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("aac495f0-cf83-40c2-90bc-b6edab8d02d5"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("acad96fe-fcc8-428b-b597-33e75dd3a5ea"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b18cc534-6c71-43e7-b3a7-c0ff2d8f7cd6"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9656));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b2a7d680-b5dc-41d1-9792-695602fc2954"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b65d8f64-a4a7-4a67-9554-8bbe686f1918"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b95c8dbf-b7bc-4a4c-82cf-2ec93d976934"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b997a2d6-aa12-46e8-b074-2222c388fcc1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("bdaac09a-fb61-4c12-8756-08cf07bb8cdd"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("c4a84b0a-bd4a-44b5-854e-6895ee11c347"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("ce065324-c0f1-401d-a3b4-b4284204ab8b"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("d49052cc-b76c-41ed-97a2-0586745a44bc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("d8d6121d-f8dd-4042-a45f-d3f4d9304d1d"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("da120915-15f5-46fc-af15-fee8d5939f86"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("de0cc597-ad66-4497-acab-33617eb077bd"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9599));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e0a65440-da87-454d-aafc-cd59a53a92d1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e109ec6d-3b84-4978-b725-e00cbe152819"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e129c250-de59-45d3-8794-58e073ff8064"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e3023e84-144e-4c66-b508-1d6c03c8e452"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9501));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e50c94ee-a2fc-4817-be47-fc24a2e762fd"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e5c70df3-cf54-477f-881d-7d142f0b51aa"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e83581fc-e05c-4c80-b5c2-e381fd7765d7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("eaf628ee-9413-472e-a5b7-3c9d45f10cf0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("ef6bfaf8-6b4b-40fd-a13a-6bdc27d8bec0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9530));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("f7ab3cf1-afe9-4b2b-977f-953d9f3b9275"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9546));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("f9775a11-583d-435b-a9c9-1b30d6b08e65"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fc61f0ae-1fac-4f04-a87a-7fe542e4398e"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9506));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fdc11a23-1dc7-4160-bb9d-019579c56e46"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fdc88de9-5c83-43f7-a689-6aed7fe375c2"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9626));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fe8b2536-5a20-4680-8dfe-526000df87e1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("71b0316a-9831-499a-b9bb-08da70ae70ed"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9217));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9219));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("86d227dc-e0ca-4a78-85f4-83a6eb30cbc7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9198));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9215));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("c6ed82d5-4a24-464b-bebd-f33c0b7f7d80"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9218));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("cda56e87-1b44-4625-9f19-ac7eb282a9b7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9207));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("d86c0ad0-1f0f-4d1d-b2c1-232874477770"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("e4d10bc8-a160-4a9d-bc87-c94cf849e14c"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("f6112698-650a-4567-8a85-b73755ae39c0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 23, 47, 20, 920, DateTimeKind.Utc).AddTicks(9212));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03cd2485-b66c-4e43-a219-4720c56469dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "187a6673-b53c-4f5c-9522-d97e59786321");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f2333e8-3dad-4501-bc02-d551c36c36f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "775bf3af-5f53-480c-9aff-6f3fa69ffc91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cc8e2ea-5892-4b0d-b5f4-387ce88b3621");

            migrationBuilder.CreateTable(
                name: "DRIVER_WHAREHOUSE",
                schema: "SCT",
                columns: table => new
                {
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WhareHouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DRIVER_WHAREHOUSE", x => new { x.DriverId, x.WhareHouseId });
                    table.ForeignKey(
                        name: "FK_DRIVER_WHAREHOUSE_DRIVER_DriverId",
                        column: x => x.DriverId,
                        principalSchema: "SCT",
                        principalTable: "DRIVER",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DRIVER_WHAREHOUSE_WHAREHOUSE_WhareHouseId",
                        column: x => x.WhareHouseId,
                        principalSchema: "SCT",
                        principalTable: "WHAREHOUSE",
                        principalColumn: "WhareHouseId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                keyValue: new Guid("0304a87a-e49f-4811-a2a7-e68faf0f6930"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2064));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("0a66a417-0aaa-4aec-9cc6-e93a29598191"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("11e436c6-929e-41d2-bb40-ef58b0a6c54a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("14b7d51d-1584-4224-8c9b-fd3da3de7b23"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2000));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("14e4dfed-e5ae-4a07-886a-f8a685e1bb03"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("15db719f-1d18-406d-bc4b-144df7dce134"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2034));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("15fb0388-449a-493e-8b25-b5c9d48724de"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1980));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("16ff9b37-0c2b-425a-b13b-d7e4113a56f1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2095));

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
                keyValue: new Guid("1c8b7baf-7a76-4469-94b1-b6b79b87d3bc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2137));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1d6bfbaf-130a-48d3-b87a-16bc27544b17"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1e083ea3-4b61-4576-94fb-2cb0691f56bb"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1f0c7bcb-2f90-4ec4-89fa-87c7ec50a96a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2062));

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
                keyValue: new Guid("2807add9-17f6-4d7d-afb4-5a66de3feab0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2070));

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
                keyValue: new Guid("2ea5c93e-b7e5-41d9-8db1-dce45c0975da"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("335af8da-4070-4382-9948-78f5d7c608ad"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2094));

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
                keyValue: new Guid("43d3b835-0099-4c90-97e8-a90e46263981"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("47aa2631-2500-49b9-bb9a-b52dce33c3d4"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2146));

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
                keyValue: new Guid("4a12b60a-033e-495e-98a8-7899a952a4d2"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("4cfe7678-6e98-4ce9-a031-9a9e6d205996"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2001));

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
                keyValue: new Guid("53b2d295-6628-4f70-bacd-887a7fe4c34f"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2068));

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
                keyValue: new Guid("5c2d783a-8d86-40db-a682-abff1ebe1325"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1971));

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
                keyValue: new Guid("603ecb5e-9e89-462c-89b6-eedd06337574"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2012));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("69522111-2411-4920-ad1c-7a60b8d15a2f"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1998));

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
                keyValue: new Guid("69b2e6e4-3652-43f5-bbe7-46319d143f1e"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1983));

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
                keyValue: new Guid("6b440bd4-1fc3-4ff0-a657-d2da4cd7667c"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1978));

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
                keyValue: new Guid("7568f431-f970-42f2-860b-52b3d56e89f7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1993));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("78d4d89c-efc4-4672-9b41-bfb5bf6ce748"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2027));

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
                keyValue: new Guid("798912f4-7813-4126-9c99-c9921f85da6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2066));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("7a989cd1-be51-44c7-9e5b-a506942a0836"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2003));

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
                keyValue: new Guid("80779654-c53e-4502-b230-39476d0b5a31"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2136));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8185bf65-4cb0-45ad-85e2-5782302ec1fe"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2006));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("852e1cdc-8ba1-4615-acee-fc1692dc2d44"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2009));

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
                keyValue: new Guid("8b22ce5a-1d4c-436a-92dc-bff4c9af8565"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2127));

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
                keyValue: new Guid("8fff4f82-3314-4f5b-a255-661d5b5b2a6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("99da2463-52a3-4e35-978b-99c3c7a8c7fc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("a15fb960-6ed5-4562-8a91-76f069380bdc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2141));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("a2305318-91ce-4da7-aa32-dc00dc3a129b"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2032));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("aac495f0-cf83-40c2-90bc-b6edab8d02d5"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2139));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("acad96fe-fcc8-428b-b597-33e75dd3a5ea"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b18cc534-6c71-43e7-b3a7-c0ff2d8f7cd6"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2132));

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
                keyValue: new Guid("b65d8f64-a4a7-4a67-9554-8bbe686f1918"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2097));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b95c8dbf-b7bc-4a4c-82cf-2ec93d976934"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1995));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b997a2d6-aa12-46e8-b074-2222c388fcc1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1988));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("bdaac09a-fb61-4c12-8756-08cf07bb8cdd"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("c4a84b0a-bd4a-44b5-854e-6895ee11c347"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1996));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("ce065324-c0f1-401d-a3b4-b4284204ab8b"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("d49052cc-b76c-41ed-97a2-0586745a44bc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2102));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("d8d6121d-f8dd-4042-a45f-d3f4d9304d1d"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("da120915-15f5-46fc-af15-fee8d5939f86"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2005));

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
                keyValue: new Guid("e0a65440-da87-454d-aafc-cd59a53a92d1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2031));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e109ec6d-3b84-4978-b725-e00cbe152819"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2029));

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
                keyValue: new Guid("e3023e84-144e-4c66-b508-1d6c03c8e452"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1981));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e50c94ee-a2fc-4817-be47-fc24a2e762fd"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1989));

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
                keyValue: new Guid("ef6bfaf8-6b4b-40fd-a13a-6bdc27d8bec0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2010));

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
                keyValue: new Guid("f9775a11-583d-435b-a9c9-1b30d6b08e65"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fc61f0ae-1fac-4f04-a87a-7fe542e4398e"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1986));

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
                keyValue: new Guid("fdc88de9-5c83-43f7-a689-6aed7fe375c2"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(2104));

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
                keyValue: new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1824));

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
                keyValue: new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1793));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1814));

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
                keyValue: new Guid("d86c0ad0-1f0f-4d1d-b2c1-232874477770"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1813));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("e4d10bc8-a160-4a9d-bc87-c94cf849e14c"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("f6112698-650a-4567-8a85-b73755ae39c0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 27, 9, 16, 22, 515, DateTimeKind.Utc).AddTicks(1816));

            migrationBuilder.CreateIndex(
                name: "IX_DRIVER_WHAREHOUSE_WhareHouseId",
                schema: "SCT",
                table: "DRIVER_WHAREHOUSE",
                column: "WhareHouseId");
        }
    }
}
