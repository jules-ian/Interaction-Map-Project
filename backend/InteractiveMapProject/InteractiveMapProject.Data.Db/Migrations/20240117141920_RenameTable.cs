using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InteractiveMapProject.Data.Db.Migrations
{
    /// <inheritdoc />
    public partial class RenameTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PendingProfessionalAudiences_Audiences_AudienceId",
                table: "PendingProfessionalAudiences");

            migrationBuilder.DropForeignKey(
                name: "FK_PendingProfessionalAudiences_PendingProfessionals_PendingProfessionalId",
                table: "PendingProfessionalAudiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PendingProfessionalAudiences",
                table: "PendingProfessionalAudiences");

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

            migrationBuilder.DeleteData(
                table: "ValidationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("1b255f17-18b7-40d3-8fc0-9d249eae398c"));

            migrationBuilder.DeleteData(
                table: "ValidationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("26e80480-0431-44c1-a135-94c31f46011b"));

            migrationBuilder.DeleteData(
                table: "ValidationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("6c546dc4-ef17-4986-96de-840a302b755e"));

            migrationBuilder.RenameTable(
                name: "PendingProfessionalAudiences",
                newName: "PendingProfessionalsAudiences");

            migrationBuilder.RenameIndex(
                name: "IX_PendingProfessionalAudiences_AudienceId",
                table: "PendingProfessionalsAudiences",
                newName: "IX_PendingProfessionalsAudiences_AudienceId");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "PendingProfessionals",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PendingProfessionalsAudiences",
                table: "PendingProfessionalsAudiences",
                columns: new[] { "PendingProfessionalId", "AudienceId" });

            migrationBuilder.InsertData(
                table: "Audiences",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("200a7713-a503-4197-802b-3bfea5442b00"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Professionnels" },
                    { new Guid("2917f241-c795-4c06-936c-f67799408316"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-6 ans" },
                    { new Guid("397e7679-8380-4ac7-a869-71844052da00"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12-18 ans" },
                    { new Guid("7faba611-d697-4d2d-bbad-f4a68a568849"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parents" },
                    { new Guid("e31ee107-d36c-467e-b36f-9594d68d6a8c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0-3 ans" },
                    { new Guid("f8741e85-0dd8-479e-a52c-17529f0fb5de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6-12 ans" }
                });

            migrationBuilder.InsertData(
                table: "Missions",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("063c0f5a-3d50-4feb-ae3b-572e22e04849"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rééducation" },
                    { new Guid("3ad4a1a7-b003-495d-a238-5c3ace6ac480"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil occasionnel" },
                    { new Guid("40a25171-aa9b-43e0-8c50-e01d6bfe8a75"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information/orientation" },
                    { new Guid("584e5a97-6268-4b0d-948b-d11009a9783d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de loisirs" },
                    { new Guid("5f8a0f19-a9d5-44df-a66d-d05e8c5c7bf4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culture et loisirs" },
                    { new Guid("68cc3438-f4ef-4917-bc7f-b177263f1243"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scolarité" },
                    { new Guid("80d1a09f-fe78-4d97-a3ed-b5a0eba3eb43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soins/santé" },
                    { new Guid("87121d06-4847-435c-85a9-169c805de82d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group de parole/Ateliers" },
                    { new Guid("906e68ce-e559-4423-949d-b9a1933e1297"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement administratif" },
                    { new Guid("96ebbecc-237c-4b19-8f93-f1094f67ea70"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement à la parentalité" },
                    { new Guid("aea635f6-7c91-472c-ba4d-697b59f79c9f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petite enfance" },
                    { new Guid("d80fefdd-d0d6-4b2c-b168-8f692ba64d94"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil d’urgence" },
                    { new Guid("ea3e4b99-35cd-4cf7-b647-b20fe580080b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Répit" },
                    { new Guid("f61ae959-ff74-4002-a054-57911aa633b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de nuit" }
                });

            migrationBuilder.InsertData(
                table: "PlacesOfIntervention",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("130826aa-0b73-47f8-a1b1-0b7b2c198c9d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure individuelle" },
                    { new Guid("4c27a475-b5ad-4a5c-aa17-ea0325297be4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "École" },
                    { new Guid("8c6ca971-a130-45ee-9da2-f785867630cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EAJE" },
                    { new Guid("b9f6cab0-d421-4811-b02e-42e76b0b0217"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiers lieu" },
                    { new Guid("bda0116c-f8a0-4779-9fa9-a5883153e2df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure d’orientation et d’information" },
                    { new Guid("e0f0be08-60f0-431f-a3ba-a5ae52d8a5b8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure de soins" },
                    { new Guid("f1ec238a-d67c-4d2d-acbf-54096e6be8ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Domicile" },
                    { new Guid("fdaa71ab-3921-4a59-ad7c-eba224e9b0ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Institution" }
                });

            migrationBuilder.InsertData(
                table: "ValidationStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("437d9c06-8259-4969-bf61-50fee2d37b4f"), "Waiting After Creation" },
                    { new Guid("50c85248-ec09-4d32-8ff0-c2ffe9ce95d3"), "Approved" },
                    { new Guid("ecee07ae-d9f5-49ad-90fb-011dd2d72d7d"), "Waiting After Update" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PendingProfessionalsAudiences_Audiences_AudienceId",
                table: "PendingProfessionalsAudiences",
                column: "AudienceId",
                principalTable: "Audiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PendingProfessionalsAudiences_PendingProfessionals_PendingProfessionalId",
                table: "PendingProfessionalsAudiences",
                column: "PendingProfessionalId",
                principalTable: "PendingProfessionals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PendingProfessionalsAudiences_Audiences_AudienceId",
                table: "PendingProfessionalsAudiences");

            migrationBuilder.DropForeignKey(
                name: "FK_PendingProfessionalsAudiences_PendingProfessionals_PendingProfessionalId",
                table: "PendingProfessionalsAudiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PendingProfessionalsAudiences",
                table: "PendingProfessionalsAudiences");

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("200a7713-a503-4197-802b-3bfea5442b00"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("2917f241-c795-4c06-936c-f67799408316"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("397e7679-8380-4ac7-a869-71844052da00"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("7faba611-d697-4d2d-bbad-f4a68a568849"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("e31ee107-d36c-467e-b36f-9594d68d6a8c"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("f8741e85-0dd8-479e-a52c-17529f0fb5de"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("063c0f5a-3d50-4feb-ae3b-572e22e04849"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("3ad4a1a7-b003-495d-a238-5c3ace6ac480"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("40a25171-aa9b-43e0-8c50-e01d6bfe8a75"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("584e5a97-6268-4b0d-948b-d11009a9783d"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("5f8a0f19-a9d5-44df-a66d-d05e8c5c7bf4"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("68cc3438-f4ef-4917-bc7f-b177263f1243"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("80d1a09f-fe78-4d97-a3ed-b5a0eba3eb43"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("87121d06-4847-435c-85a9-169c805de82d"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("906e68ce-e559-4423-949d-b9a1933e1297"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("96ebbecc-237c-4b19-8f93-f1094f67ea70"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("aea635f6-7c91-472c-ba4d-697b59f79c9f"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("d80fefdd-d0d6-4b2c-b168-8f692ba64d94"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("ea3e4b99-35cd-4cf7-b647-b20fe580080b"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("f61ae959-ff74-4002-a054-57911aa633b1"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("130826aa-0b73-47f8-a1b1-0b7b2c198c9d"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("4c27a475-b5ad-4a5c-aa17-ea0325297be4"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("8c6ca971-a130-45ee-9da2-f785867630cc"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("b9f6cab0-d421-4811-b02e-42e76b0b0217"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("bda0116c-f8a0-4779-9fa9-a5883153e2df"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("e0f0be08-60f0-431f-a3ba-a5ae52d8a5b8"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("f1ec238a-d67c-4d2d-acbf-54096e6be8ec"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("fdaa71ab-3921-4a59-ad7c-eba224e9b0ad"));

            migrationBuilder.DeleteData(
                table: "ValidationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("437d9c06-8259-4969-bf61-50fee2d37b4f"));

            migrationBuilder.DeleteData(
                table: "ValidationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("50c85248-ec09-4d32-8ff0-c2ffe9ce95d3"));

            migrationBuilder.DeleteData(
                table: "ValidationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ecee07ae-d9f5-49ad-90fb-011dd2d72d7d"));

            migrationBuilder.RenameTable(
                name: "PendingProfessionalsAudiences",
                newName: "PendingProfessionalAudiences");

            migrationBuilder.RenameIndex(
                name: "IX_PendingProfessionalsAudiences_AudienceId",
                table: "PendingProfessionalAudiences",
                newName: "IX_PendingProfessionalAudiences_AudienceId");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "PendingProfessionals",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PendingProfessionalAudiences",
                table: "PendingProfessionalAudiences",
                columns: new[] { "PendingProfessionalId", "AudienceId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_PendingProfessionalAudiences_Audiences_AudienceId",
                table: "PendingProfessionalAudiences",
                column: "AudienceId",
                principalTable: "Audiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PendingProfessionalAudiences_PendingProfessionals_PendingProfessionalId",
                table: "PendingProfessionalAudiences",
                column: "PendingProfessionalId",
                principalTable: "PendingProfessionals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
