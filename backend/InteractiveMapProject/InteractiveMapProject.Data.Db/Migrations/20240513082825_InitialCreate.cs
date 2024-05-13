using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InteractiveMapProject.Data.Db.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProfessionalId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Audiences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audiences", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PlacesOfIntervention",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacesOfIntervention", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ValidationStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidationStatuses", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Professionals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstablishmentType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ManagementType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address_Street = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address_City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address_PostalCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactPerson_Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactPerson_Function = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactPerson_PhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactPerson_Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Geolocation_Latitude = table.Column<double>(type: "double", nullable: false),
                    Geolocation_Longitude = table.Column<double>(type: "double", nullable: false),
                    ValidationStatusId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professionals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professionals_ValidationStatuses_ValidationStatusId",
                        column: x => x.ValidationStatusId,
                        principalTable: "ValidationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PendingProfessionals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProfessionalId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstablishmentType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ManagementType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address_Street = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address_City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address_PostalCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactPerson_Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactPerson_Function = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactPerson_PhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactPerson_Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Geolocation_Latitude = table.Column<double>(type: "double", nullable: false),
                    Geolocation_Longitude = table.Column<double>(type: "double", nullable: false),
                    ValidationStatusId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingProfessionals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PendingProfessionals_Professionals_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "Professionals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PendingProfessionals_ValidationStatuses_ValidationStatusId",
                        column: x => x.ValidationStatusId,
                        principalTable: "ValidationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProfessionalsAudiences",
                columns: table => new
                {
                    ProfessionalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AudienceId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalsAudiences", x => new { x.ProfessionalId, x.AudienceId });
                    table.ForeignKey(
                        name: "FK_ProfessionalsAudiences_Audiences_AudienceId",
                        column: x => x.AudienceId,
                        principalTable: "Audiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionalsAudiences_Professionals_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "Professionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProfessionalsMissions",
                columns: table => new
                {
                    ProfessionalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    MissionId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalsMissions", x => new { x.ProfessionalId, x.MissionId });
                    table.ForeignKey(
                        name: "FK_ProfessionalsMissions_Missions_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Missions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionalsMissions_Professionals_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "Professionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProfessionalsPlacesOfIntervention",
                columns: table => new
                {
                    ProfessionalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PlaceOfInterventionId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalsPlacesOfIntervention", x => new { x.ProfessionalId, x.PlaceOfInterventionId });
                    table.ForeignKey(
                        name: "FK_ProfessionalsPlacesOfIntervention_PlacesOfIntervention_Place~",
                        column: x => x.PlaceOfInterventionId,
                        principalTable: "PlacesOfIntervention",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionalsPlacesOfIntervention_Professionals_Professional~",
                        column: x => x.ProfessionalId,
                        principalTable: "Professionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PendingProfessionalsAudiences",
                columns: table => new
                {
                    PendingProfessionalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AudienceId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingProfessionalsAudiences", x => new { x.PendingProfessionalId, x.AudienceId });
                    table.ForeignKey(
                        name: "FK_PendingProfessionalsAudiences_Audiences_AudienceId",
                        column: x => x.AudienceId,
                        principalTable: "Audiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PendingProfessionalsAudiences_PendingProfessionals_PendingPr~",
                        column: x => x.PendingProfessionalId,
                        principalTable: "PendingProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PendingProfessionalsMissions",
                columns: table => new
                {
                    PendingProfessionalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    MissionId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingProfessionalsMissions", x => new { x.PendingProfessionalId, x.MissionId });
                    table.ForeignKey(
                        name: "FK_PendingProfessionalsMissions_Missions_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Missions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PendingProfessionalsMissions_PendingProfessionals_PendingPro~",
                        column: x => x.PendingProfessionalId,
                        principalTable: "PendingProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PendingProfessionalsPlacesOfIntervention",
                columns: table => new
                {
                    PendingProfessionalId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PlaceOfInterventionId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingProfessionalsPlacesOfIntervention", x => new { x.PendingProfessionalId, x.PlaceOfInterventionId });
                    table.ForeignKey(
                        name: "FK_PendingProfessionalsPlacesOfIntervention_PendingProfessional~",
                        column: x => x.PendingProfessionalId,
                        principalTable: "PendingProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PendingProfessionalsPlacesOfIntervention_PlacesOfInterventio~",
                        column: x => x.PlaceOfInterventionId,
                        principalTable: "PlacesOfIntervention",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Audiences",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("498c8fbd-ce9d-4d74-b1af-4ffd6ced08d0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-6 ans" },
                    { new Guid("4f5177aa-fbe1-418c-8e29-c53fd57de0c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6-12 ans" },
                    { new Guid("946127b6-6086-49ae-9d37-74fea6f28b9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Professionnels" },
                    { new Guid("9ae46826-0a6f-48f5-ba9e-a7b1e6ac8786"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0-3 ans" },
                    { new Guid("bb1cc290-0fc8-404a-854a-c2b0aae68c80"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parents" },
                    { new Guid("dae32a6b-8991-49ae-97f4-59fe8d607552"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12-18 ans" }
                });

            migrationBuilder.InsertData(
                table: "Missions",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("2b2060e8-297f-4bee-8b88-67d651e8ae40"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement administratif" },
                    { new Guid("3c18485e-0085-4482-8c2f-aeb9925e9281"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rééducation" },
                    { new Guid("3fcb1d8e-e488-4f5a-b48f-c948f47679a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Répit" },
                    { new Guid("40ddc0af-3771-4985-afa5-41dee83aab40"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil d’urgence" },
                    { new Guid("51fe1c6b-f4fa-4ca2-bbfa-fa619ec8e652"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soins/santé" },
                    { new Guid("a1b17a70-be7f-40a6-abab-d0a26dfa2a7a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de nuit" },
                    { new Guid("aac34d8b-9e9c-4e22-84be-7eb2bf9e45a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de loisirs" },
                    { new Guid("aae7815a-a9cc-4d3c-8576-49a072c078bb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scolarité" },
                    { new Guid("af9d2f8e-d9cc-4d6f-81c2-2239aca90532"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement à la parentalité" },
                    { new Guid("b796ae0d-fca2-4fd5-af81-091ab862c3e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil occasionnel" },
                    { new Guid("b798e3aa-dc15-4edf-9e71-c5022d309bd8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culture et loisirs" },
                    { new Guid("bdd1387d-1a50-4dca-968f-ec92bf11ca7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petite enfance" },
                    { new Guid("dc45ccb9-7437-46ea-809b-ed531f06bc7a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group de parole/Ateliers" },
                    { new Guid("f65849f3-41f2-4108-9996-d7fd69fcbbbe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information/orientation" }
                });

            migrationBuilder.InsertData(
                table: "PlacesOfIntervention",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("33638c12-e1ac-4508-8717-741884e87136"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Domicile" },
                    { new Guid("49ff9e12-3f70-4835-9627-3a1b36bfbd09"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EAJE" },
                    { new Guid("6023fbc8-85cb-4589-b8d8-1408c3a27964"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "École" },
                    { new Guid("9d570b69-19a6-4a72-b703-b2a64b84c2f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiers lieu" },
                    { new Guid("a4d58208-fc49-41e1-bb58-64e856cd238c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure individuelle" },
                    { new Guid("be305923-75e1-43ea-87d0-c73ab7400db7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure d’orientation et d’information" },
                    { new Guid("d081df8c-d78f-47ea-8854-733693a57765"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Institution" },
                    { new Guid("dd417045-5bf9-4a70-810b-15b6bab90e96"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure de soins" }
                });

            migrationBuilder.InsertData(
                table: "ValidationStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("793127fc-5427-4471-b161-58bd68c6636a"), "Approved" },
                    { new Guid("bd7990de-181a-4cb5-9e80-8f8b1caccdd7"), "Waiting After Update" },
                    { new Guid("be4ce02e-e478-4168-bfc9-22d541acfcd6"), "Waiting After Creation" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PendingProfessionals_ProfessionalId",
                table: "PendingProfessionals",
                column: "ProfessionalId");

            migrationBuilder.CreateIndex(
                name: "IX_PendingProfessionals_ValidationStatusId",
                table: "PendingProfessionals",
                column: "ValidationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PendingProfessionalsAudiences_AudienceId",
                table: "PendingProfessionalsAudiences",
                column: "AudienceId");

            migrationBuilder.CreateIndex(
                name: "IX_PendingProfessionalsMissions_MissionId",
                table: "PendingProfessionalsMissions",
                column: "MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_PendingProfessionalsPlacesOfIntervention_PlaceOfIntervention~",
                table: "PendingProfessionalsPlacesOfIntervention",
                column: "PlaceOfInterventionId");

            migrationBuilder.CreateIndex(
                name: "IX_Professionals_ValidationStatusId",
                table: "Professionals",
                column: "ValidationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalsAudiences_AudienceId",
                table: "ProfessionalsAudiences",
                column: "AudienceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalsMissions_MissionId",
                table: "ProfessionalsMissions",
                column: "MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalsPlacesOfIntervention_PlaceOfInterventionId",
                table: "ProfessionalsPlacesOfIntervention",
                column: "PlaceOfInterventionId");
        }

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
                name: "PendingProfessionalsAudiences");

            migrationBuilder.DropTable(
                name: "PendingProfessionalsMissions");

            migrationBuilder.DropTable(
                name: "PendingProfessionalsPlacesOfIntervention");

            migrationBuilder.DropTable(
                name: "ProfessionalsAudiences");

            migrationBuilder.DropTable(
                name: "ProfessionalsMissions");

            migrationBuilder.DropTable(
                name: "ProfessionalsPlacesOfIntervention");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "PendingProfessionals");

            migrationBuilder.DropTable(
                name: "Audiences");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "PlacesOfIntervention");

            migrationBuilder.DropTable(
                name: "Professionals");

            migrationBuilder.DropTable(
                name: "ValidationStatuses");
        }
    }
}
