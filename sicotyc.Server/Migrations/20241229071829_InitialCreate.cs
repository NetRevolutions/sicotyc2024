using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sicotyc.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "SCT");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "COMPANY",
                schema: "SCT",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ruc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CompanyComercialName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CompanyState = table.Column<int>(type: "int", nullable: true),
                    CompanyCondition = table.Column<int>(type: "int", nullable: true),
                    CompanyFiscalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPANY", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "DRIVER",
                schema: "SCT",
                columns: table => new
                {
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ruc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentExpiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnableIMO = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AntecedentesPolicialesExpiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AntecedentesPenalesExpiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DRIVER", x => x.DriverId);
                });

            migrationBuilder.CreateTable(
                name: "LOOKUP_CODE_GROUP",
                schema: "SCT",
                columns: table => new
                {
                    LookupCodeGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LookupCodeGroupName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOOKUP_CODE_GROUP", x => x.LookupCodeGroupId);
                });

            migrationBuilder.CreateTable(
                name: "OPTIONS",
                schema: "SCT",
                columns: table => new
                {
                    OptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionOrder = table.Column<int>(type: "int", nullable: false),
                    OptionLevel = table.Column<int>(type: "int", nullable: false),
                    OptionParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPTIONS", x => x.OptionId);
                });

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
                    Axles = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UNIT_TRANSPORT_DETAIL", x => x.UnitTransportDetailId);
                });

            migrationBuilder.CreateTable(
                name: "USER_DETAIL",
                schema: "SCT",
                columns: table => new
                {
                    UserDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_DETAIL", x => x.UserDetailId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "COMPANY_TYPE",
                schema: "SCT",
                columns: table => new
                {
                    CompanyTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPANY_TYPE", x => x.CompanyTypeId);
                    table.ForeignKey(
                        name: "FK_COMPANY_TYPE_COMPANY_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "SCT",
                        principalTable: "COMPANY",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WHAREHOUSE",
                schema: "SCT",
                columns: table => new
                {
                    WhareHouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AliasName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AditionalDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WHAREHOUSE", x => x.WhareHouseId);
                    table.ForeignKey(
                        name: "FK_WHAREHOUSE_COMPANY_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "SCT",
                        principalTable: "COMPANY",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DRIVER_LICENSE",
                schema: "SCT",
                columns: table => new
                {
                    LicenseNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LicenseType = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverLicenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicenseExpiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DRIVER_LICENSE", x => new { x.DriverId, x.LicenseNumber, x.LicenseType });
                    table.ForeignKey(
                        name: "FK_DRIVER_LICENSE_DRIVER_DriverId",
                        column: x => x.DriverId,
                        principalSchema: "SCT",
                        principalTable: "DRIVER",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LOOKUP_CODE",
                schema: "SCT",
                columns: table => new
                {
                    LookupCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LookupCodeValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LookupCodeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LookupCodeOrder = table.Column<int>(type: "int", nullable: false),
                    LookupCodeGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOOKUP_CODE", x => x.LookupCodeId);
                    table.ForeignKey(
                        name: "FK_LOOKUP_CODE_LOOKUP_CODE_GROUP_LookupCodeGroupId",
                        column: x => x.LookupCodeGroupId,
                        principalSchema: "SCT",
                        principalTable: "LOOKUP_CODE_GROUP",
                        principalColumn: "LookupCodeGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OPTIONS_ROLE",
                schema: "SCT",
                columns: table => new
                {
                    OptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPTIONS_ROLE", x => new { x.OptionId, x.Id });
                    table.ForeignKey(
                        name: "FK_OPTIONS_ROLE_AspNetRoles_Id",
                        column: x => x.Id,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OPTIONS_ROLE_OPTIONS_OptionId",
                        column: x => x.OptionId,
                        principalSchema: "SCT",
                        principalTable: "OPTIONS",
                        principalColumn: "OptionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "COMPLEMENT_TRANSPORT",
                schema: "SCT",
                columns: table => new
                {
                    ComplementTransportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransportDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Plate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FabricationYear = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModelYear = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TechnicalReviewExpiredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditinalNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleQualificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleQualificationExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VehicleConfiguration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPLEMENT_TRANSPORT", x => x.ComplementTransportId);
                    table.ForeignKey(
                        name: "FK_COMPLEMENT_TRANSPORT_UNIT_TRANSPORT_DETAIL_TransportDetailId",
                        column: x => x.TransportDetailId,
                        principalSchema: "SCT",
                        principalTable: "UNIT_TRANSPORT_DETAIL",
                        principalColumn: "UnitTransportDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UNIT_TRANSPORT",
                schema: "SCT",
                columns: table => new
                {
                    UnitTransportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ruc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FabricationYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoatExpiredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TechnicalReviewExpiredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fuel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleQualificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleQualificationExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VehicleConfiguration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitTransportDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UNIT_TRANSPORT", x => x.UnitTransportId);
                    table.ForeignKey(
                        name: "FK_UNIT_TRANSPORT_UNIT_TRANSPORT_DETAIL_UnitTransportDetailId",
                        column: x => x.UnitTransportDetailId,
                        principalSchema: "SCT",
                        principalTable: "UNIT_TRANSPORT_DETAIL",
                        principalColumn: "UnitTransportDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_COMPANY_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "SCT",
                        principalTable: "COMPANY",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_USER_DETAIL_UserDetailId",
                        column: x => x.UserDetailId,
                        principalSchema: "SCT",
                        principalTable: "USER_DETAIL",
                        principalColumn: "UserDetailId");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("091249cd-a7b3-467d-8938-2aa534324e21"), null, "Administrator", "ADMINISTRATOR" },
                    { new Guid("34872081-8ad9-4a28-bd76-29be97039208"), null, "Agency", "AGENCY" },
                    { new Guid("45825849-2dc8-4631-beac-aaf53f844c6e"), null, "Forwarder-Biller", "FORWARDER-BILLER" },
                    { new Guid("4a784ae9-f240-48e9-a98d-57f8b557d922"), null, "Forwarder", "FORWARDER" },
                    { new Guid("e9accb7a-dfd4-43d8-9038-ea8bf23b270d"), null, "Forwarder-Coordinator", "FORWARDER-COORDINATOR" }
                });

            migrationBuilder.InsertData(
                schema: "SCT",
                table: "LOOKUP_CODE_GROUP",
                columns: new[] { "LookupCodeGroupId", "CreatedOn", "CreatedBy", "DeletedOn", "LookupCodeGroupName", "LastUpdatedOn", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("71b0316a-9831-499a-b9bb-08da70ae70ed"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3938), "SYSTEM", null, "TIPO DE PAGO PEAJE", null, null },
                    { new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3941), "SYSTEM", null, "TIPO DE UNIDAD DE TRANSPORTE", null, null },
                    { new Guid("86d227dc-e0ca-4a78-85f4-83a6eb30cbc7"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3935), "SYSTEM", null, "TIPO DE DOC. IDENTIDAD", null, null },
                    { new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3914), "SYSTEM", null, "CATEGORIA VEHICULOS", null, null },
                    { new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3937), "SYSTEM", null, "TIPO DE LICENCIA DE CONDUCIR", null, null },
                    { new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3932), "SYSTEM", null, "ESTADO EMPRESA", null, null },
                    { new Guid("c6ed82d5-4a24-464b-bebd-f33c0b7f7d80"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3939), "SYSTEM", null, "TIPO DE SERVICIO", null, null },
                    { new Guid("cda56e87-1b44-4625-9f19-ac7eb282a9b7"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3928), "SYSTEM", null, "CLAIMS PERMITIDOS", null, null },
                    { new Guid("d86c0ad0-1f0f-4d1d-b2c1-232874477770"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3931), "SYSTEM", null, "CONDICION EMPRESA", null, null },
                    { new Guid("e4d10bc8-a160-4a9d-bc87-c94cf849e14c"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3936), "SYSTEM", null, "TIPO DE EMPRESA", null, null },
                    { new Guid("f6112698-650a-4567-8a85-b73755ae39c0"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(3933), "SYSTEM", null, "TIPO DE COMBUSTIBLE", null, null }
                });

            migrationBuilder.InsertData(
                schema: "SCT",
                table: "LOOKUP_CODE",
                columns: new[] { "LookupCodeId", "CreatedOn", "CreatedBy", "DeletedOn", "LookupCodeGroupId", "LookupCodeName", "LookupCodeOrder", "LookupCodeValue", "LastUpdatedOn", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0304a87a-e49f-4811-a2a7-e68faf0f6930"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4298), "SYSTEM", null, new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"), "Obligado a emitir comprobantes electronicos", 6, "OBLIGADO_EMITIR_COMPROBANTE_ELECTRONICO", null, null },
                    { new Guid("0a66a417-0aaa-4aec-9cc6-e93a29598191"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4411), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "CAMA BAJA 40 PIES", 10, "CB40", null, null },
                    { new Guid("11e436c6-929e-41d2-bb40-ef58b0a6c54a"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4325), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "A-I", 1, "A1", null, null },
                    { new Guid("14b7d51d-1584-4224-8c9b-fd3da3de7b23"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4210), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "O4 - Remolques de PBV mayor a 10 TN", 15, "O4", null, null },
                    { new Guid("14e4dfed-e5ae-4a07-886a-f8a685e1bb03"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4341), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "A-IV o Especial", 11, "A4", null, null },
                    { new Guid("15db719f-1d18-406d-bc4b-144df7dce134"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4292), "SYSTEM", null, new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"), "Baja Temporal", 3, "BAJA_TEMPORAL", null, null },
                    { new Guid("15fb0388-449a-493e-8b25-b5c9d48724de"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4190), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "L4 - Tres Ruedas Asimetricas al Eje Longitudinal", 4, "L4", null, null },
                    { new Guid("16ff9b37-0c2b-425a-b13b-d7e4113a56f1"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4331), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "A-IIIb", 5, "A3B", null, null },
                    { new Guid("1a011e51-2471-4ccd-174c-08da70ae983a"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4346), "SYSTEM", null, new Guid("71b0316a-9831-499a-b9bb-08da70ae70ed"), "Por Eje3", 3, "ByAxis3", null, null },
                    { new Guid("1aec098a-859a-4586-80b6-b6f4beb848fb"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4277), "SYSTEM", null, new Guid("cda56e87-1b44-4625-9f19-ac7eb282a9b7"), "ID", 5, "Id", null, null },
                    { new Guid("1c8b7baf-7a76-4469-94b1-b6b79b87d3bc"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4371), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "CONTAINERA DE 20 PIES (2 EJES)", 7, "CONT20S2", null, null },
                    { new Guid("1d6bfbaf-130a-48d3-b87a-16bc27544b17"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4294), "SYSTEM", null, new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"), "Baja Definitiva", 4, "BAJA_DEFINITIVA", null, null },
                    { new Guid("1e083ea3-4b61-4576-94fb-2cb0691f56bb"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4304), "SYSTEM", null, new Guid("f6112698-650a-4567-8a85-b73755ae39c0"), "GNV (Gas Natural Vehicular)", 4, "GNV", null, null },
                    { new Guid("1f0c7bcb-2f90-4ec4-89fa-87c7ec50a96a"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4296), "SYSTEM", null, new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"), "Omiso", 5, "OMISO", null, null },
                    { new Guid("23078793-cd0a-4718-2aa4-08da71da4714"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4348), "SYSTEM", null, new Guid("71b0316a-9831-499a-b9bb-08da70ae70ed"), "Por Eje4", 4, "ByAxis4", null, null },
                    { new Guid("2807add9-17f6-4d7d-afb4-5a66de3feab0"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4302), "SYSTEM", null, new Guid("f6112698-650a-4567-8a85-b73755ae39c0"), "GLP (Gas Licuado de Petroleo)", 3, "GLP", null, null },
                    { new Guid("2d253e01-afa1-4a59-bc6a-26526f0d8498"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4306), "SYSTEM", null, new Guid("86d227dc-e0ca-4a78-85f4-83a6eb30cbc7"), "Documento Nacional de Identidad", 1, "DNI", null, null },
                    { new Guid("2ea5c93e-b7e5-41d9-8db1-dce45c0975da"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4365), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "PLATAFORMA DE  40 PIES (3 EJES)", 3, "PLAT40S3", null, null },
                    { new Guid("335af8da-4070-4382-9948-78f5d7c608ad"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4330), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "A-IIIa", 4, "A3A", null, null },
                    { new Guid("37a294bb-d8e2-4655-80a8-a2fe719766d4"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4272), "SYSTEM", null, new Guid("cda56e87-1b44-4625-9f19-ac7eb282a9b7"), "FIRSTNAME", 2, "FirstName", null, null },
                    { new Guid("43d3b835-0099-4c90-97e8-a90e46263981"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4186), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "L2 - Tres Ruedas - Hasta 50 cm3 - Vel. Max. 50 km/h", 2, "L2", null, null },
                    { new Guid("47aa2631-2500-49b9-bb9a-b52dce33c3d4"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4415), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "CAMA CUNA 40 PIES", 12, "CC40", null, null },
                    { new Guid("47b84a27-c75a-44d3-174d-08da70ae983a"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4349), "SYSTEM", null, new Guid("71b0316a-9831-499a-b9bb-08da70ae70ed"), "Por Eje5", 5, "ByAxis5", null, null },
                    { new Guid("4a12b60a-033e-495e-98a8-7899a952a4d2"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4336), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "B-IIa", 8, "B2A", null, null },
                    { new Guid("4cfe7678-6e98-4ce9-a031-9a9e6d205996"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4211), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "SA - Casas Rodantes", 16, "SA", null, null },
                    { new Guid("50bd3490-2377-4945-9229-f018f6b07bf8"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4280), "SYSTEM", null, new Guid("cda56e87-1b44-4625-9f19-ac7eb282a9b7"), "PHONENUMBER", 6, "PhoneNumber", null, null },
                    { new Guid("53b2d295-6628-4f70-bacd-887a7fe4c34f"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4301), "SYSTEM", null, new Guid("f6112698-650a-4567-8a85-b73755ae39c0"), "Gasolina", 2, "GAS", null, null },
                    { new Guid("58250d62-975a-4883-81f7-946c91cf2dec"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4323), "SYSTEM", null, new Guid("e4d10bc8-a160-4a9d-bc87-c94cf849e14c"), "Otros", 2, "OT", null, null },
                    { new Guid("5c2d783a-8d86-40db-a682-abff1ebe1325"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4182), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "L1 - Dos Ruedas - Hasta 50 cm3 - Vel. Max. 50 km/h", 1, "L1", null, null },
                    { new Guid("5f38d3fd-f34e-45eb-aebf-512f5ebd94ee"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4354), "SYSTEM", null, new Guid("c6ed82d5-4a24-464b-bebd-f33c0b7f7d80"), "CARGA SUELTA", 3, "CS", null, null },
                    { new Guid("603ecb5e-9e89-462c-89b6-eedd06337574"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4268), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "SG - Porta Tropas", 22, "SG", null, null },
                    { new Guid("69522111-2411-4920-ad1c-7a60b8d15a2f"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4208), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "O3 - Remolques de PBV mayor a 3.5 TN hasta 10 TN", 14, "O3", null, null },
                    { new Guid("6963984f-c5e0-4ed9-9647-46ac7054e344"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4351), "SYSTEM", null, new Guid("c6ed82d5-4a24-464b-bebd-f33c0b7f7d80"), "IMPORTACION", 1, "IMPO", null, null },
                    { new Guid("69b2e6e4-3652-43f5-bbe7-46319d143f1e"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4194), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "M1 - Hasta 9 Asientos (Inc. conductor)", 6, "M1", null, null },
                    { new Guid("6b1b516f-9073-4657-8a4c-9cb7ebe8ea25"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4276), "SYSTEM", null, new Guid("cda56e87-1b44-4625-9f19-ac7eb282a9b7"), "EMAIL", 4, "Email", null, null },
                    { new Guid("6b440bd4-1fc3-4ff0-a657-d2da4cd7667c"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4189), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "L3 - Dos Ruedas - Mas de 50 cm3 - Vel. Mayor 50 km/h", 3, "L3", null, null },
                    { new Guid("752ce625-da67-4842-b19d-18c5572dbbce"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4270), "SYSTEM", null, new Guid("cda56e87-1b44-4625-9f19-ac7eb282a9b7"), "USERNAME", 1, "UserName", null, null },
                    { new Guid("7568f431-f970-42f2-860b-52b3d56e89f7"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4203), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "N3 - De PBV mayor a 12 TN", 11, "N3", null, null },
                    { new Guid("78d4d89c-efc4-4672-9b41-bfb5bf6ce748"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4285), "SYSTEM", null, new Guid("d86c0ad0-1f0f-4d1d-b2c1-232874477770"), "Habido", 1, "HABIDO", null, null },
                    { new Guid("792f255c-2b8b-42e6-9968-2855373e5c86"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4311), "SYSTEM", null, new Guid("86d227dc-e0ca-4a78-85f4-83a6eb30cbc7"), "Partida de Nacimiento", 4, "PNAC", null, null },
                    { new Guid("798912f4-7813-4126-9c99-c9921f85da6b"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4299), "SYSTEM", null, new Guid("f6112698-650a-4567-8a85-b73755ae39c0"), "DIESEL", 1, "DSL", null, null },
                    { new Guid("7a989cd1-be51-44c7-9e5b-a506942a0836"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4213), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "SB - Vehiculos Blindados para el transporte de Valores", 17, "SB", null, null },
                    { new Guid("7e603067-a1ed-4b52-174b-08da70ae983a"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4344), "SYSTEM", null, new Guid("71b0316a-9831-499a-b9bb-08da70ae70ed"), "Por Eje2", 2, "ByAxis2", null, null },
                    { new Guid("80779654-c53e-4502-b230-39476d0b5a31"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4370), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "CONTAINERA DE 40 PIES (3 EJES)", 6, "CONT40S3", null, null },
                    { new Guid("8185bf65-4cb0-45ad-85e2-5782302ec1fe"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4216), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "SD - Vehiculos Funerarios", 19, "SD", null, null },
                    { new Guid("852e1cdc-8ba1-4615-acee-fc1692dc2d44"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4218), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "SE - Bomberos", 20, "SE", null, null },
                    { new Guid("867c1549-7132-4e8e-174a-08da70ae983a"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4343), "SYSTEM", null, new Guid("71b0316a-9831-499a-b9bb-08da70ae70ed"), "Por Eje", 1, "ByAxis", null, null },
                    { new Guid("8b22ce5a-1d4c-436a-92dc-bff4c9af8565"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4361), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "REMOLCADOR", 1, "REM", null, null },
                    { new Guid("8bd83659-b611-488d-aaac-e5d418bac06c"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4359), "SYSTEM", null, new Guid("c6ed82d5-4a24-464b-bebd-f33c0b7f7d80"), "CAMA BAJA", 6, "CB", null, null },
                    { new Guid("8dc0180a-2ffc-4807-803a-37aab6ecaab2"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4307), "SYSTEM", null, new Guid("86d227dc-e0ca-4a78-85f4-83a6eb30cbc7"), "Carnet de Extranjería", 2, "CEX", null, null },
                    { new Guid("8e009c6d-5920-4135-8a26-49ec04c6e7d5"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4284), "SYSTEM", null, new Guid("cda56e87-1b44-4625-9f19-ac7eb282a9b7"), "IMG", 8, "Img", null, null },
                    { new Guid("8fff4f82-3314-4f5b-a255-661d5b5b2a6e"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4334), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "B-I", 7, "B1", null, null },
                    { new Guid("99da2463-52a3-4e35-978b-99c3c7a8c7fc"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4363), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "PLATAFORMA DE  40 PIES (2 EJES)", 2, "PLAT40S2", null, null },
                    { new Guid("a15fb960-6ed5-4562-8a91-76f069380bdc"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4375), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "FURGON ALAS DE GAVIOTA", 9, "FURGALGAV", null, null },
                    { new Guid("a2305318-91ce-4da7-aa32-dc00dc3a129b"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4291), "SYSTEM", null, new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"), "Obligado a llevar Contabilidad", 2, "OBLIGADO_LLEVAR_CONTABILIDAD", null, null },
                    { new Guid("aac495f0-cf83-40c2-90bc-b6edab8d02d5"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4373), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "FURGON CERRADO", 8, "FURGCER", null, null },
                    { new Guid("acad96fe-fcc8-428b-b597-33e75dd3a5ea"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4201), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "N2 - De PBV mayor a 3.5 TN hasta 12 TN", 10, "N2", null, null },
                    { new Guid("b18cc534-6c71-43e7-b3a7-c0ff2d8f7cd6"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4367), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "PLATAFORMA DE  20 PIES (2 EJES)", 4, "PLAT20S2", null, null },
                    { new Guid("b2a7d680-b5dc-41d1-9792-695602fc2954"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4312), "SYSTEM", null, new Guid("86d227dc-e0ca-4a78-85f4-83a6eb30cbc7"), "Carnet de FFAA", 5, "CFFAA", null, null },
                    { new Guid("b65d8f64-a4a7-4a67-9554-8bbe686f1918"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4333), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "A-IIIc", 6, "A3C", null, null },
                    { new Guid("b95c8dbf-b7bc-4a4c-82cf-2ec93d976934"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4205), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "O1 - Remolques de PBV de 0.75 TN o menos", 12, "O1", null, null },
                    { new Guid("b997a2d6-aa12-46e8-b074-2222c388fcc1"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4198), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "M3 - Mas de 9 asientos - PBV Mayor 5 TN", 8, "M3", null, null },
                    { new Guid("bdaac09a-fb61-4c12-8756-08cf07bb8cdd"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4328), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "A-IIb", 3, "A2B", null, null },
                    { new Guid("c4a84b0a-bd4a-44b5-854e-6895ee11c347"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4206), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "O2 - Remolques de PBV mayor a 0.75 TN hasta 3.5 TN", 13, "O2", null, null },
                    { new Guid("ce065324-c0f1-401d-a3b4-b4284204ab8b"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4413), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "CAMA BAJA 20 PIES", 11, "CB20", null, null },
                    { new Guid("d49052cc-b76c-41ed-97a2-0586745a44bc"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4338), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "B-IIb", 9, "B2B", null, null },
                    { new Guid("d8d6121d-f8dd-4042-a45f-d3f4d9304d1d"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4326), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "A-IIa", 2, "A2A", null, null },
                    { new Guid("da120915-15f5-46fc-af15-fee8d5939f86"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4215), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "SC - Ambulancias", 18, "SC", null, null },
                    { new Guid("de0cc597-ad66-4497-acab-33617eb077bd"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4309), "SYSTEM", null, new Guid("86d227dc-e0ca-4a78-85f4-83a6eb30cbc7"), "Pasaporte", 3, "PASS", null, null },
                    { new Guid("e0a65440-da87-454d-aafc-cd59a53a92d1"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4289), "SYSTEM", null, new Guid("b0dd9a3b-a5ed-4960-b94b-155ae7809e86"), "Activo", 1, "ACTIVO", null, null },
                    { new Guid("e109ec6d-3b84-4978-b725-e00cbe152819"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4287), "SYSTEM", null, new Guid("d86c0ad0-1f0f-4d1d-b2c1-232874477770"), "No Habido", 2, "NO_HABIDO", null, null },
                    { new Guid("e129c250-de59-45d3-8794-58e073ff8064"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4274), "SYSTEM", null, new Guid("cda56e87-1b44-4625-9f19-ac7eb282a9b7"), "LASTNAME", 3, "LastName", null, null },
                    { new Guid("e3023e84-144e-4c66-b508-1d6c03c8e452"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4192), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "L5 - Tres Ruedas Simetricas al Eje Longitudinal, Peso menor a 1 TN", 5, "L5", null, null },
                    { new Guid("e50c94ee-a2fc-4817-be47-fc24a2e762fd"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4200), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "N1 - De PBV de 3.5 TN o menos", 9, "N1", null, null },
                    { new Guid("e5c70df3-cf54-477f-881d-7d142f0b51aa"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4358), "SYSTEM", null, new Guid("c6ed82d5-4a24-464b-bebd-f33c0b7f7d80"), "TRACCIÓN", 5, "TX", null, null },
                    { new Guid("e83581fc-e05c-4c80-b5c2-e381fd7765d7"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4353), "SYSTEM", null, new Guid("c6ed82d5-4a24-464b-bebd-f33c0b7f7d80"), "EXPORTACION", 2, "EXPO", null, null },
                    { new Guid("eaf628ee-9413-472e-a5b7-3c9d45f10cf0"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4315), "SYSTEM", null, new Guid("e4d10bc8-a160-4a9d-bc87-c94cf849e14c"), "Empresa de Transporte", 1, "ET", null, null },
                    { new Guid("ef6bfaf8-6b4b-40fd-a13a-6bdc27d8bec0"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4219), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "SF - Vehiculos Celulares", 21, "SF", null, null },
                    { new Guid("f7ab3cf1-afe9-4b2b-977f-953d9f3b9275"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4282), "SYSTEM", null, new Guid("cda56e87-1b44-4625-9f19-ac7eb282a9b7"), "ROLE", 7, "Role", null, null },
                    { new Guid("f9775a11-583d-435b-a9c9-1b30d6b08e65"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4368), "SYSTEM", null, new Guid("74fa91f9-2019-4e0b-97c5-63b790594515"), "CONTAINERA DE 40 PIES (2 EJES)", 5, "CONT40S2", null, null },
                    { new Guid("fc61f0ae-1fac-4f04-a87a-7fe542e4398e"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4196), "SYSTEM", null, new Guid("a0860957-dc94-4006-86fc-b9ccf4f78a33"), "M2 - Mas de 9 asientos - PBV Maximo 5 TN", 7, "M2", null, null },
                    { new Guid("fdc11a23-1dc7-4160-bb9d-019579c56e46"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4356), "SYSTEM", null, new Guid("c6ed82d5-4a24-464b-bebd-f33c0b7f7d80"), "DEVOLUCIÓN DE VACÍO", 4, "DV", null, null },
                    { new Guid("fdc88de9-5c83-43f7-a689-6aed7fe375c2"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4339), "SYSTEM", null, new Guid("ab544e6e-6107-45bb-bf5b-b89401dc8afc"), "B-IIc", 10, "B2C", null, null },
                    { new Guid("fe8b2536-5a20-4680-8dfe-526000df87e1"), new DateTime(2024, 12, 29, 7, 18, 28, 962, DateTimeKind.Utc).AddTicks(4314), "SYSTEM", null, new Guid("86d227dc-e0ca-4a78-85f4-83a6eb30cbc7"), "Pasaporte Diplomatico", 6, "PASSD", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

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

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_TYPE_CompanyId",
                schema: "SCT",
                table: "COMPANY_TYPE",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_COMPLEMENT_TRANSPORT_TransportDetailId",
                schema: "SCT",
                table: "COMPLEMENT_TRANSPORT",
                column: "TransportDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_LOOKUP_CODE_LookupCodeGroupId",
                schema: "SCT",
                table: "LOOKUP_CODE",
                column: "LookupCodeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_OPTIONS_ROLE_Id",
                schema: "SCT",
                table: "OPTIONS_ROLE",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UNIT_TRANSPORT_UnitTransportDetailId",
                schema: "SCT",
                table: "UNIT_TRANSPORT",
                column: "UnitTransportDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WHAREHOUSE_CompanyId",
                schema: "SCT",
                table: "WHAREHOUSE",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "COMPANY_TYPE",
                schema: "SCT");

            migrationBuilder.DropTable(
                name: "COMPLEMENT_TRANSPORT",
                schema: "SCT");

            migrationBuilder.DropTable(
                name: "DRIVER_LICENSE",
                schema: "SCT");

            migrationBuilder.DropTable(
                name: "LOOKUP_CODE",
                schema: "SCT");

            migrationBuilder.DropTable(
                name: "OPTIONS_ROLE",
                schema: "SCT");

            migrationBuilder.DropTable(
                name: "UNIT_TRANSPORT",
                schema: "SCT");

            migrationBuilder.DropTable(
                name: "WHAREHOUSE",
                schema: "SCT");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DRIVER",
                schema: "SCT");

            migrationBuilder.DropTable(
                name: "LOOKUP_CODE_GROUP",
                schema: "SCT");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "OPTIONS",
                schema: "SCT");

            migrationBuilder.DropTable(
                name: "UNIT_TRANSPORT_DETAIL",
                schema: "SCT");

            migrationBuilder.DropTable(
                name: "COMPANY",
                schema: "SCT");

            migrationBuilder.DropTable(
                name: "USER_DETAIL",
                schema: "SCT");
        }
    }
}
