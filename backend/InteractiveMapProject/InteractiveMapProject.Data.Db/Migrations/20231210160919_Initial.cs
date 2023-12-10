using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InteractiveMapProject.Data.Db.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Audiences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlacesOfIntervention",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacesOfIntervention", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professionals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstablishmentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagementType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPerson_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPerson_Function = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPerson_PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    ContactPerson_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Geolocation_Latitude = table.Column<double>(type: "float", nullable: false),
                    Geolocation_Longitude = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professionals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalsAudiences",
                columns: table => new
                {
                    ProfessionalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AudienceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalsMissions",
                columns: table => new
                {
                    ProfessionalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalsPlacesOfIntervention",
                columns: table => new
                {
                    ProfessionalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceOfInterventionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalsPlacesOfIntervention", x => new { x.ProfessionalId, x.PlaceOfInterventionId });
                    table.ForeignKey(
                        name: "FK_ProfessionalsPlacesOfIntervention_PlacesOfIntervention_PlaceOfInterventionId",
                        column: x => x.PlaceOfInterventionId,
                        principalTable: "PlacesOfIntervention",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionalsPlacesOfIntervention_Professionals_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "Professionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Audiences",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("12b1c47b-e752-4203-8059-a8bbcb526a9d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0-3 ans" },
                    { new Guid("1a582e56-4e22-40f9-ad71-2f59ad0f8522"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Professionnels" },
                    { new Guid("4c7ab37a-62c3-40e7-bfc5-210d9a3654c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parents" },
                    { new Guid("55bc3bb7-3b5d-49e0-a62f-27a705ec84ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6-12 ans" },
                    { new Guid("d68a3fe3-a1b1-4005-9a67-fec96f230245"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12-18 ans" },
                    { new Guid("f51fc34c-1c5a-45f6-be14-dc1a8e08b54a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-6 ans" }
                });

            migrationBuilder.InsertData(
                table: "Missions",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("10072e8f-03bd-457f-a6d8-01b0bd368ea0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group de parole/Ateliers" },
                    { new Guid("28c560d8-701f-4013-9c74-12c138651b78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référent santé accueil inclusif (RSAI)" },
                    { new Guid("2dc71c9e-e077-4cf5-8a84-e2c7ea86f133"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prestataire" },
                    { new Guid("360bdf6a-396a-40df-b4a4-97b259b4c12a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil occasionnel" },
                    { new Guid("4d0ddaaf-0d0c-4ac7-8c53-1244c3926511"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soins/santé/réeducation" },
                    { new Guid("6eeefc1e-bd62-46f9-9ffd-8c4e154b579b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scolarité" },
                    { new Guid("783ad868-f47d-42ce-8350-652e623c836f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de nuit" },
                    { new Guid("863f82c8-2319-4adb-95ca-a678eec78e11"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement administratif" },
                    { new Guid("8a5157a5-8bee-4f15-b6d7-9308f1440b02"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de jour" },
                    { new Guid("90a445eb-5c48-45b2-9e9b-db10c70e018f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Répit" },
                    { new Guid("a8d51451-da44-4248-85ee-b251822415cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petite enfance" },
                    { new Guid("af71ede5-4336-4422-bf0f-0cef2a108fe8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ressource documentaire" },
                    { new Guid("bb8f5973-92d2-4136-956a-8802d2296385"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orientation" },
                    { new Guid("d80477b2-ebb6-4b8a-8044-8002e4ebaabf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de loisirs" },
                    { new Guid("df65210e-8ec6-4750-8703-39110fddbdea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement à la parentalité" }
                });

            migrationBuilder.InsertData(
                table: "PlacesOfIntervention",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("1012d645-73b3-494d-96ba-49e60a2a606e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "École" },
                    { new Guid("5c236e21-df55-42b9-9d10-6787f0379f8e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Domicile" },
                    { new Guid("80cd1709-4478-4b40-8c0d-7dfd5e7ab210"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EAJE" },
                    { new Guid("a0b8c54b-c1e4-4c53-9711-6872f5ac6ecb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cabinet" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfessionalsAudiences");

            migrationBuilder.DropTable(
                name: "ProfessionalsMissions");

            migrationBuilder.DropTable(
                name: "ProfessionalsPlacesOfIntervention");

            migrationBuilder.DropTable(
                name: "Audiences");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "PlacesOfIntervention");

            migrationBuilder.DropTable(
                name: "Professionals");
        }
    }
}
