using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InteractiveMapProject.Data.Db.Migrations
{
    /// <inheritdoc />
    public partial class ValidationOfProfessionals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("204d6123-2943-4cb0-8bf6-96df118407a9"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("3e8d427e-3411-4ec5-9ab8-4f2e72868167"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("4ad7e403-febd-46a7-81ec-d48caec35fef"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("62e26312-79f9-42cf-a74c-f76b01c29ec0"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("71e35027-0d98-412f-a1a0-4c025654584f"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("e9eb23b8-7b4e-411a-a142-477ed5e4d2c3"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("01b73f77-c28e-4f76-95b9-c031fe9bef33"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("1105c7c7-7747-48a7-a83d-e30f903e4fb2"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("1e06a7b1-b104-4f82-b342-5f49efe72b33"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("223f1c1b-b203-4044-8cc8-acdc4e06d447"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("2cc0132e-9ae8-4614-b408-c17731dda093"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("6927eccf-1781-4f2b-a754-576bfdfdffc6"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("840c721e-ca75-44f2-81e8-f3596fc0bcd7"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("90cdb7da-ce68-4d5e-b7fa-37b90a915f0a"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("984ea5d1-0550-4c41-b95e-28a86a0b1737"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("aa549435-62af-4d97-a41f-eee328687212"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("b44b01bb-4671-452d-9f2e-baaef54cced9"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("bbcb1ad4-b519-4329-821f-2b4306baa7e2"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("e29322ba-52cc-4c45-8cae-c9c06f2e7815"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("ec2aa828-cc2f-44da-a4a8-1ac31156be18"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("006b5183-9ce2-4638-acbb-3119d122ca97"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("044dc5ef-5ef4-4350-9d57-e8d962342c86"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("1b15c2fd-dbb9-4175-bdd6-9b7fb5b7bfdb"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("3c8c54de-1473-46f2-8b47-32d6c6c40c2c"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("3ee7f715-7424-4f19-8e2b-50ffacd9db8f"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("70f8cb94-eb69-44b0-9439-fc1463ea3e95"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("83e3dfa0-9e0e-41f8-8073-6df13e73e82f"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("dc704ad5-c20d-4ffe-858e-d741676dc048"));

            migrationBuilder.AddColumn<Guid>(
                name: "ValidationStatusId",
                table: "Professionals",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ValidationStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidationStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PendingProfessionals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    ContactPerson_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPerson_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Geolocation_Latitude = table.Column<double>(type: "float", nullable: false),
                    Geolocation_Longitude = table.Column<double>(type: "float", nullable: false),
                    ValidationStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PendingProfessionalAudiences",
                columns: table => new
                {
                    PendingProfessionalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AudienceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingProfessionalAudiences", x => new { x.PendingProfessionalId, x.AudienceId });
                    table.ForeignKey(
                        name: "FK_PendingProfessionalAudiences_Audiences_AudienceId",
                        column: x => x.AudienceId,
                        principalTable: "Audiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PendingProfessionalAudiences_PendingProfessionals_PendingProfessionalId",
                        column: x => x.PendingProfessionalId,
                        principalTable: "PendingProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PendingProfessionalsMissions",
                columns: table => new
                {
                    PendingProfessionalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                        name: "FK_PendingProfessionalsMissions_PendingProfessionals_PendingProfessionalId",
                        column: x => x.PendingProfessionalId,
                        principalTable: "PendingProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PendingProfessionalsPlacesOfIntervention",
                columns: table => new
                {
                    PendingProfessionalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceOfInterventionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingProfessionalsPlacesOfIntervention", x => new { x.PendingProfessionalId, x.PlaceOfInterventionId });
                    table.ForeignKey(
                        name: "FK_PendingProfessionalsPlacesOfIntervention_PendingProfessionals_PendingProfessionalId",
                        column: x => x.PendingProfessionalId,
                        principalTable: "PendingProfessionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PendingProfessionalsPlacesOfIntervention_PlacesOfIntervention_PlaceOfInterventionId",
                        column: x => x.PlaceOfInterventionId,
                        principalTable: "PlacesOfIntervention",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Audiences",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("19772152-f82f-4e36-ab6a-a629f1b413f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0-3 ans" },
                    { new Guid("1e49c055-7a4e-4a4b-8c04-f654ee753b27"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12-18 ans" },
                    { new Guid("4846bbb4-8f3e-47a8-9dba-9345c8ded78a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-6 ans" },
                    { new Guid("d0f480c9-d3e6-4604-a7cb-10abc2c346b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6-12 ans" },
                    { new Guid("edfdcb42-0313-46f2-a5d3-5c8441dd8209"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Professionnels" },
                    { new Guid("ff35fadc-740f-4046-a6cb-14be3cb5d51f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parents" }
                });

            migrationBuilder.InsertData(
                table: "Missions",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("083f63e8-96be-416c-b2f5-3c255e3d957a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rééducation" },
                    { new Guid("11ebcb8a-fece-4fc8-b464-296370040a99"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de nuit" },
                    { new Guid("1e4393e8-96f3-47ca-891a-5fb3ba16ee6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement administratif" },
                    { new Guid("31c2f5af-69a7-4558-81ae-44990492fa85"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil occasionnel" },
                    { new Guid("70bec29d-7d2e-4fc3-b0e2-c931fff5f33c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement à la parentalité" },
                    { new Guid("9a3d1cc6-b40f-4a1b-83e6-0aa0c253c156"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scolarité" },
                    { new Guid("b6136f4f-d1a4-4718-8e8f-bc40a9fa47e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil d’urgence" },
                    { new Guid("c1088f1d-6f2e-4752-a4d7-141ae6e52ebf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petite enfance" },
                    { new Guid("c579adc0-3ae4-48e0-bb5f-d0d3eb5b864f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group de parole/Ateliers" },
                    { new Guid("da1ab655-1403-4f5e-b14f-941fee5c199d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soins/santé" },
                    { new Guid("e2f0be63-6c44-4529-96e7-225d6551984d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Répit" },
                    { new Guid("ef2dd6ce-3cc0-4175-8733-c2162b6303ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de loisirs" },
                    { new Guid("f472b572-e2d0-4a45-8af4-c504c68443df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information/orientation" },
                    { new Guid("fc78bfcf-6753-49f8-8ef2-3bdbf1b4166a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culture et loisirs" }
                });

            migrationBuilder.InsertData(
                table: "PlacesOfIntervention",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("3a2949b1-5bd8-4c8a-b042-0195a149a8f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure individuelle" },
                    { new Guid("618d2c25-7790-40ff-a8e3-aadc210e8afa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "École" },
                    { new Guid("732a37f0-55b8-4297-be75-048431217693"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure de soins" },
                    { new Guid("cae4187d-93d8-4f53-9c0f-49adc7de314a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Domicile" },
                    { new Guid("d0ce58dd-80f1-4660-bf24-76488b5b0e42"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Institution" },
                    { new Guid("e7defe56-5010-44c0-9ad7-56a9c7794dcd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiers lieu" },
                    { new Guid("eed81397-85ef-4c25-aafd-5cde21606069"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure d’orientation et d’information" },
                    { new Guid("f240abbd-25d4-47e3-b08a-c7e91dd70d17"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EAJE" }
                });

            migrationBuilder.InsertData(
                table: "ValidationStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1b255f17-18b7-40d3-8fc0-9d249eae398c"), "Approved" },
                    { new Guid("26e80480-0431-44c1-a135-94c31f46011b"), "Waiting After Update" },
                    { new Guid("6c546dc4-ef17-4986-96de-840a302b755e"), "Waiting After Creation" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Professionals_ValidationStatusId",
                table: "Professionals",
                column: "ValidationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PendingProfessionalAudiences_AudienceId",
                table: "PendingProfessionalAudiences",
                column: "AudienceId");

            migrationBuilder.CreateIndex(
                name: "IX_PendingProfessionals_ProfessionalId",
                table: "PendingProfessionals",
                column: "ProfessionalId");

            migrationBuilder.CreateIndex(
                name: "IX_PendingProfessionals_ValidationStatusId",
                table: "PendingProfessionals",
                column: "ValidationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PendingProfessionalsMissions_MissionId",
                table: "PendingProfessionalsMissions",
                column: "MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_PendingProfessionalsPlacesOfIntervention_PlaceOfInterventionId",
                table: "PendingProfessionalsPlacesOfIntervention",
                column: "PlaceOfInterventionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Professionals_ValidationStatuses_ValidationStatusId",
                table: "Professionals",
                column: "ValidationStatusId",
                principalTable: "ValidationStatuses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professionals_ValidationStatuses_ValidationStatusId",
                table: "Professionals");

            migrationBuilder.DropTable(
                name: "PendingProfessionalAudiences");

            migrationBuilder.DropTable(
                name: "PendingProfessionalsMissions");

            migrationBuilder.DropTable(
                name: "PendingProfessionalsPlacesOfIntervention");

            migrationBuilder.DropTable(
                name: "PendingProfessionals");

            migrationBuilder.DropTable(
                name: "ValidationStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Professionals_ValidationStatusId",
                table: "Professionals");

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("19772152-f82f-4e36-ab6a-a629f1b413f2"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("1e49c055-7a4e-4a4b-8c04-f654ee753b27"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("4846bbb4-8f3e-47a8-9dba-9345c8ded78a"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("d0f480c9-d3e6-4604-a7cb-10abc2c346b7"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("edfdcb42-0313-46f2-a5d3-5c8441dd8209"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("ff35fadc-740f-4046-a6cb-14be3cb5d51f"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("083f63e8-96be-416c-b2f5-3c255e3d957a"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("11ebcb8a-fece-4fc8-b464-296370040a99"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("1e4393e8-96f3-47ca-891a-5fb3ba16ee6d"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("31c2f5af-69a7-4558-81ae-44990492fa85"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("70bec29d-7d2e-4fc3-b0e2-c931fff5f33c"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("9a3d1cc6-b40f-4a1b-83e6-0aa0c253c156"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("b6136f4f-d1a4-4718-8e8f-bc40a9fa47e0"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("c1088f1d-6f2e-4752-a4d7-141ae6e52ebf"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("c579adc0-3ae4-48e0-bb5f-d0d3eb5b864f"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("da1ab655-1403-4f5e-b14f-941fee5c199d"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("e2f0be63-6c44-4529-96e7-225d6551984d"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("ef2dd6ce-3cc0-4175-8733-c2162b6303ca"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("f472b572-e2d0-4a45-8af4-c504c68443df"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("fc78bfcf-6753-49f8-8ef2-3bdbf1b4166a"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("3a2949b1-5bd8-4c8a-b042-0195a149a8f9"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("618d2c25-7790-40ff-a8e3-aadc210e8afa"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("732a37f0-55b8-4297-be75-048431217693"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("cae4187d-93d8-4f53-9c0f-49adc7de314a"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("d0ce58dd-80f1-4660-bf24-76488b5b0e42"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("e7defe56-5010-44c0-9ad7-56a9c7794dcd"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("eed81397-85ef-4c25-aafd-5cde21606069"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("f240abbd-25d4-47e3-b08a-c7e91dd70d17"));

            migrationBuilder.DropColumn(
                name: "ValidationStatusId",
                table: "Professionals");

            migrationBuilder.InsertData(
                table: "Audiences",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("204d6123-2943-4cb0-8bf6-96df118407a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6-12 ans" },
                    { new Guid("3e8d427e-3411-4ec5-9ab8-4f2e72868167"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-6 ans" },
                    { new Guid("4ad7e403-febd-46a7-81ec-d48caec35fef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Professionnels" },
                    { new Guid("62e26312-79f9-42cf-a74c-f76b01c29ec0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parents" },
                    { new Guid("71e35027-0d98-412f-a1a0-4c025654584f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0-3 ans" },
                    { new Guid("e9eb23b8-7b4e-411a-a142-477ed5e4d2c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12-18 ans" }
                });

            migrationBuilder.InsertData(
                table: "Missions",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("01b73f77-c28e-4f76-95b9-c031fe9bef33"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement administratif" },
                    { new Guid("1105c7c7-7747-48a7-a83d-e30f903e4fb2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soins/santé" },
                    { new Guid("1e06a7b1-b104-4f82-b342-5f49efe72b33"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culture et loisirs" },
                    { new Guid("223f1c1b-b203-4044-8cc8-acdc4e06d447"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Répit" },
                    { new Guid("2cc0132e-9ae8-4614-b408-c17731dda093"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information/orientation" },
                    { new Guid("6927eccf-1781-4f2b-a754-576bfdfdffc6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de loisirs" },
                    { new Guid("840c721e-ca75-44f2-81e8-f3596fc0bcd7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scolarité" },
                    { new Guid("90cdb7da-ce68-4d5e-b7fa-37b90a915f0a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil d’urgence" },
                    { new Guid("984ea5d1-0550-4c41-b95e-28a86a0b1737"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rééducation" },
                    { new Guid("aa549435-62af-4d97-a41f-eee328687212"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petite enfance" },
                    { new Guid("b44b01bb-4671-452d-9f2e-baaef54cced9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de nuit" },
                    { new Guid("bbcb1ad4-b519-4329-821f-2b4306baa7e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil occasionnel" },
                    { new Guid("e29322ba-52cc-4c45-8cae-c9c06f2e7815"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group de parole/Ateliers" },
                    { new Guid("ec2aa828-cc2f-44da-a4a8-1ac31156be18"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement à la parentalité" }
                });

            migrationBuilder.InsertData(
                table: "PlacesOfIntervention",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("006b5183-9ce2-4638-acbb-3119d122ca97"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EAJE" },
                    { new Guid("044dc5ef-5ef4-4350-9d57-e8d962342c86"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "École" },
                    { new Guid("1b15c2fd-dbb9-4175-bdd6-9b7fb5b7bfdb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure de soins" },
                    { new Guid("3c8c54de-1473-46f2-8b47-32d6c6c40c2c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiers lieu" },
                    { new Guid("3ee7f715-7424-4f19-8e2b-50ffacd9db8f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Domicile" },
                    { new Guid("70f8cb94-eb69-44b0-9439-fc1463ea3e95"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Institution" },
                    { new Guid("83e3dfa0-9e0e-41f8-8073-6df13e73e82f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure individuelle" },
                    { new Guid("dc704ad5-c20d-4ffe-858e-d741676dc048"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure d’orientation et d’information" }
                });
        }
    }
}
