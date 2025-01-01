using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sicotyc.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRolesNameDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("0304a87a-e49f-4811-a2a7-e68faf0f6930"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(233));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("0a66a417-0aaa-4aec-9cc6-e93a29598191"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(368));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("11e436c6-929e-41d2-bb40-ef58b0a6c54a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(262));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("14b7d51d-1584-4224-8c9b-fd3da3de7b23"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("14e4dfed-e5ae-4a07-886a-f8a685e1bb03"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(284));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("15db719f-1d18-406d-bc4b-144df7dce134"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("15fb0388-449a-493e-8b25-b5c9d48724de"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(114));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("16ff9b37-0c2b-425a-b13b-d7e4113a56f1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(270));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1a011e51-2471-4ccd-174c-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(291));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1aec098a-859a-4586-80b6-b6f4beb848fb"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1c8b7baf-7a76-4469-94b1-b6b79b87d3bc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1d6bfbaf-130a-48d3-b87a-16bc27544b17"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1e083ea3-4b61-4576-94fb-2cb0691f56bb"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1f0c7bcb-2f90-4ec4-89fa-87c7ec50a96a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("23078793-cd0a-4718-2aa4-08da71da4714"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(293));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("2807add9-17f6-4d7d-afb4-5a66de3feab0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("2d253e01-afa1-4a59-bc6a-26526f0d8498"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("2ea5c93e-b7e5-41d9-8db1-dce45c0975da"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(351));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("335af8da-4070-4382-9948-78f5d7c608ad"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("37a294bb-d8e2-4655-80a8-a2fe719766d4"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(201));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("43d3b835-0099-4c90-97e8-a90e46263981"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(107));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("47aa2631-2500-49b9-bb9a-b52dce33c3d4"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(373));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("47b84a27-c75a-44d3-174d-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("4a12b60a-033e-495e-98a8-7899a952a4d2"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(278));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("4cfe7678-6e98-4ce9-a031-9a9e6d205996"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(181));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("50bd3490-2377-4945-9229-f018f6b07bf8"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("53b2d295-6628-4f70-bacd-887a7fe4c34f"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(237));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("58250d62-975a-4883-81f7-946c91cf2dec"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("5c2d783a-8d86-40db-a682-abff1ebe1325"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("5f38d3fd-f34e-45eb-aebf-512f5ebd94ee"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(304));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("603ecb5e-9e89-462c-89b6-eedd06337574"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(196));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("69522111-2411-4920-ad1c-7a60b8d15a2f"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("6963984f-c5e0-4ed9-9647-46ac7054e344"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(298));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("69b2e6e4-3652-43f5-bbe7-46319d143f1e"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(119));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("6b1b516f-9073-4657-8a4c-9cb7ebe8ea25"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(205));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("6b440bd4-1fc3-4ff0-a657-d2da4cd7667c"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(111));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("752ce625-da67-4842-b19d-18c5572dbbce"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(199));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("7568f431-f970-42f2-860b-52b3d56e89f7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(130));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("78d4d89c-efc4-4672-9b41-bfb5bf6ce748"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("792f255c-2b8b-42e6-9968-2855373e5c86"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(251));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("798912f4-7813-4126-9c99-c9921f85da6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(235));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("7a989cd1-be51-44c7-9e5b-a506942a0836"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(183));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("7e603067-a1ed-4b52-174b-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("80779654-c53e-4502-b230-39476d0b5a31"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(359));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8185bf65-4cb0-45ad-85e2-5782302ec1fe"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(188));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("852e1cdc-8ba1-4615-acee-fc1692dc2d44"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(190));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("867c1549-7132-4e8e-174a-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(286));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8b22ce5a-1d4c-436a-92dc-bff4c9af8565"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8bd83659-b611-488d-aaac-e5d418bac06c"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8dc0180a-2ffc-4807-803a-37aab6ecaab2"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(246));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8e009c6d-5920-4135-8a26-49ec04c6e7d5"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(214));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8fff4f82-3314-4f5b-a255-661d5b5b2a6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(276));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("99da2463-52a3-4e35-978b-99c3c7a8c7fc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(349));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("a15fb960-6ed5-4562-8a91-76f069380bdc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(366));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("a2305318-91ce-4da7-aa32-dc00dc3a129b"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(224));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("aac495f0-cf83-40c2-90bc-b6edab8d02d5"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(363));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("acad96fe-fcc8-428b-b597-33e75dd3a5ea"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(128));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b18cc534-6c71-43e7-b3a7-c0ff2d8f7cd6"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(354));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b2a7d680-b5dc-41d1-9792-695602fc2954"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(253));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b65d8f64-a4a7-4a67-9554-8bbe686f1918"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(273));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b95c8dbf-b7bc-4a4c-82cf-2ec93d976934"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b997a2d6-aa12-46e8-b074-2222c388fcc1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("bdaac09a-fb61-4c12-8756-08cf07bb8cdd"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(266));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("c4a84b0a-bd4a-44b5-854e-6895ee11c347"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(173));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("ce065324-c0f1-401d-a3b4-b4284204ab8b"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(370));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("d49052cc-b76c-41ed-97a2-0586745a44bc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(280));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("d8d6121d-f8dd-4042-a45f-d3f4d9304d1d"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(264));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("da120915-15f5-46fc-af15-fee8d5939f86"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(186));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("de0cc597-ad66-4497-acab-33617eb077bd"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e0a65440-da87-454d-aafc-cd59a53a92d1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(222));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e109ec6d-3b84-4978-b725-e00cbe152819"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e129c250-de59-45d3-8794-58e073ff8064"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e3023e84-144e-4c66-b508-1d6c03c8e452"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(117));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e50c94ee-a2fc-4817-be47-fc24a2e762fd"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e5c70df3-cf54-477f-881d-7d142f0b51aa"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e83581fc-e05c-4c80-b5c2-e381fd7765d7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("eaf628ee-9413-472e-a5b7-3c9d45f10cf0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(257));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("ef6bfaf8-6b4b-40fd-a13a-6bdc27d8bec0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(194));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("f7ab3cf1-afe9-4b2b-977f-953d9f3b9275"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("f9775a11-583d-435b-a9c9-1b30d6b08e65"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(356));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fc61f0ae-1fac-4f04-a87a-7fe542e4398e"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(121));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fdc11a23-1dc7-4160-bb9d-019579c56e46"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fdc88de9-5c83-43f7-a689-6aed7fe375c2"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(282));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fe8b2536-5a20-4680-8dfe-526000df87e1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 67, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("71b0316a-9831-499a-b9bb-08da70ae70ed"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 66, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 66, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("86d227dc-e0ca-4a78-85f4-83a6eb30cbc7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 66, DateTimeKind.Utc).AddTicks(9779));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 66, DateTimeKind.Utc).AddTicks(9753));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 66, DateTimeKind.Utc).AddTicks(9783));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 66, DateTimeKind.Utc).AddTicks(9776));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("c6ed82d5-4a24-464b-bebd-f33c0b7f7d80"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 66, DateTimeKind.Utc).AddTicks(9786));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("cda56e87-1b44-4625-9f19-ac7eb282a9b7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 66, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("d86c0ad0-1f0f-4d1d-b2c1-232874477770"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 66, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("e4d10bc8-a160-4a9d-bc87-c94cf849e14c"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 66, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("f6112698-650a-4567-8a85-b73755ae39c0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 28, 27, 66, DateTimeKind.Utc).AddTicks(9778));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("0304a87a-e49f-4811-a2a7-e68faf0f6930"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("0a66a417-0aaa-4aec-9cc6-e93a29598191"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4411));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("11e436c6-929e-41d2-bb40-ef58b0a6c54a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("14b7d51d-1584-4224-8c9b-fd3da3de7b23"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("14e4dfed-e5ae-4a07-886a-f8a685e1bb03"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4341));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("15db719f-1d18-406d-bc4b-144df7dce134"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("15fb0388-449a-493e-8b25-b5c9d48724de"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("16ff9b37-0c2b-425a-b13b-d7e4113a56f1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1a011e51-2471-4ccd-174c-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4346));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1aec098a-859a-4586-80b6-b6f4beb848fb"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1c8b7baf-7a76-4469-94b1-b6b79b87d3bc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1d6bfbaf-130a-48d3-b87a-16bc27544b17"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1e083ea3-4b61-4576-94fb-2cb0691f56bb"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("1f0c7bcb-2f90-4ec4-89fa-87c7ec50a96a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4296));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("23078793-cd0a-4718-2aa4-08da71da4714"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4348));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("2807add9-17f6-4d7d-afb4-5a66de3feab0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("2d253e01-afa1-4a59-bc6a-26526f0d8498"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("2ea5c93e-b7e5-41d9-8db1-dce45c0975da"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("335af8da-4070-4382-9948-78f5d7c608ad"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("37a294bb-d8e2-4655-80a8-a2fe719766d4"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4272));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("43d3b835-0099-4c90-97e8-a90e46263981"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4186));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("47aa2631-2500-49b9-bb9a-b52dce33c3d4"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("47b84a27-c75a-44d3-174d-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("4a12b60a-033e-495e-98a8-7899a952a4d2"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("4cfe7678-6e98-4ce9-a031-9a9e6d205996"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("50bd3490-2377-4945-9229-f018f6b07bf8"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("53b2d295-6628-4f70-bacd-887a7fe4c34f"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("58250d62-975a-4883-81f7-946c91cf2dec"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4323));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("5c2d783a-8d86-40db-a682-abff1ebe1325"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("5f38d3fd-f34e-45eb-aebf-512f5ebd94ee"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("603ecb5e-9e89-462c-89b6-eedd06337574"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4268));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("69522111-2411-4920-ad1c-7a60b8d15a2f"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("6963984f-c5e0-4ed9-9647-46ac7054e344"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("69b2e6e4-3652-43f5-bbe7-46319d143f1e"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("6b1b516f-9073-4657-8a4c-9cb7ebe8ea25"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("6b440bd4-1fc3-4ff0-a657-d2da4cd7667c"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("752ce625-da67-4842-b19d-18c5572dbbce"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("7568f431-f970-42f2-860b-52b3d56e89f7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("78d4d89c-efc4-4672-9b41-bfb5bf6ce748"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4285));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("792f255c-2b8b-42e6-9968-2855373e5c86"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("798912f4-7813-4126-9c99-c9921f85da6b"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4299));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("7a989cd1-be51-44c7-9e5b-a506942a0836"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("7e603067-a1ed-4b52-174b-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("80779654-c53e-4502-b230-39476d0b5a31"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8185bf65-4cb0-45ad-85e2-5782302ec1fe"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("852e1cdc-8ba1-4615-acee-fc1692dc2d44"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("867c1549-7132-4e8e-174a-08da70ae983a"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4343));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8b22ce5a-1d4c-436a-92dc-bff4c9af8565"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4361));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8bd83659-b611-488d-aaac-e5d418bac06c"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8dc0180a-2ffc-4807-803a-37aab6ecaab2"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8e009c6d-5920-4135-8a26-49ec04c6e7d5"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("8fff4f82-3314-4f5b-a255-661d5b5b2a6e"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4334));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("99da2463-52a3-4e35-978b-99c3c7a8c7fc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("a15fb960-6ed5-4562-8a91-76f069380bdc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("a2305318-91ce-4da7-aa32-dc00dc3a129b"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("aac495f0-cf83-40c2-90bc-b6edab8d02d5"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("acad96fe-fcc8-428b-b597-33e75dd3a5ea"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b18cc534-6c71-43e7-b3a7-c0ff2d8f7cd6"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b2a7d680-b5dc-41d1-9792-695602fc2954"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b65d8f64-a4a7-4a67-9554-8bbe686f1918"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b95c8dbf-b7bc-4a4c-82cf-2ec93d976934"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("b997a2d6-aa12-46e8-b074-2222c388fcc1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("bdaac09a-fb61-4c12-8756-08cf07bb8cdd"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("c4a84b0a-bd4a-44b5-854e-6895ee11c347"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4206));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("ce065324-c0f1-401d-a3b4-b4284204ab8b"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4413));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("d49052cc-b76c-41ed-97a2-0586745a44bc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("d8d6121d-f8dd-4042-a45f-d3f4d9304d1d"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4326));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("da120915-15f5-46fc-af15-fee8d5939f86"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("de0cc597-ad66-4497-acab-33617eb077bd"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e0a65440-da87-454d-aafc-cd59a53a92d1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e109ec6d-3b84-4978-b725-e00cbe152819"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e129c250-de59-45d3-8794-58e073ff8064"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e3023e84-144e-4c66-b508-1d6c03c8e452"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e50c94ee-a2fc-4817-be47-fc24a2e762fd"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e5c70df3-cf54-477f-881d-7d142f0b51aa"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("e83581fc-e05c-4c80-b5c2-e381fd7765d7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("eaf628ee-9413-472e-a5b7-3c9d45f10cf0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4315));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("ef6bfaf8-6b4b-40fd-a13a-6bdc27d8bec0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("f7ab3cf1-afe9-4b2b-977f-953d9f3b9275"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("f9775a11-583d-435b-a9c9-1b30d6b08e65"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fc61f0ae-1fac-4f04-a87a-7fe542e4398e"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fdc11a23-1dc7-4160-bb9d-019579c56e46"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fdc88de9-5c83-43f7-a689-6aed7fe375c2"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4339));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                keyColumn: "LookupCodeId",
                keyValue: new Guid("fe8b2536-5a20-4680-8dfe-526000df87e1"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("71b0316a-9831-499a-b9bb-08da70ae70ed"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("86d227dc-e0ca-4a78-85f4-83a6eb30cbc7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("c6ed82d5-4a24-464b-bebd-f33c0b7f7d80"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("cda56e87-1b44-4625-9f19-ac7eb282a9b7"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3928));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("d86c0ad0-1f0f-4d1d-b2c1-232874477770"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("e4d10bc8-a160-4a9d-bc87-c94cf849e14c"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                keyColumn: "LookupCodeGroupId",
                keyValue: new Guid("f6112698-650a-4567-8a85-b73755ae39c0"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3933));
        }
    }
}
