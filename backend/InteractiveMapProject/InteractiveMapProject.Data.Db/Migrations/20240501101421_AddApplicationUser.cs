using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InteractiveMapProject.Data.Db.Migrations
{
    public partial class AddApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("0d0edd39-7dab-4041-acf9-354c62d0a7f0"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("5ac7dbf0-75aa-40b9-993c-b1d97b7f42f2"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("9523924f-8cb5-4008-979c-91b96779a56b"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("a0b4c38f-f92b-438b-a092-1d53eeb512e3"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("e65421ac-2c75-4a1a-810f-77e2ba94735c"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("ee0ade05-68fb-4bfc-9f26-1bca11edc9c9"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("059df970-a66a-4a2d-888c-141974946dfc"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("1d567382-8820-432b-b6bc-c0023cf398d4"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("3800d12a-f685-42da-9a4a-0c633f50784d"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("55cf1b02-722f-4df5-8762-f2bf5393db02"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("5bd2ea93-1ae3-4e30-8f62-3be44ac166a9"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("601b4142-4647-4b0c-9560-b73e0b238988"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("60c75055-328e-42ff-8e95-70e387ab009d"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("63985109-b470-4855-ba1a-c3ea5ee46572"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("7c89ae38-ecbb-464d-9b0e-42e977ef7055"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("8789bc01-35a9-4852-b8cd-ffbba481500e"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("8fea7ff5-dc8c-4a10-88fc-f35dba38cf3c"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("96cb0993-cfbe-48cf-a3a2-8b5d201dd574"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("db3a7349-b32b-44dd-936c-c9a89144791c"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("e163de6e-c2a8-40b7-919a-2dcb6e19f67b"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("11e5b81c-239c-4c85-8ea6-1b666c0261af"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("3e359c11-b16b-45e0-8ea1-2825f07f7644"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("3f98f25b-7f36-4a65-948c-6d2f02ebe5c2"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("711083b5-8eac-4b1f-930f-964ebe45ae07"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("750848bb-a735-426d-9b30-d587d221a2f8"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("c8d17a8b-d779-44e5-91d1-db7ab74783a0"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("f89b7694-0424-4728-9f40-2efebf657173"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("fecb12d7-d46b-46cd-8949-bd87c7a55e7c"));

            migrationBuilder.DeleteData(
                table: "ValidationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("08da705c-4dde-45ee-b94b-f1d7803093ad"));

            migrationBuilder.DeleteData(
                table: "ValidationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("b9d2a680-8fe6-4fbe-99bd-6032ec190bcc"));

            migrationBuilder.DeleteData(
                table: "ValidationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d23a0f58-a503-456e-9242-aa3c6ee7a9bd"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProfessionalId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Audiences",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("2c0200a4-d7d2-4937-a314-9d50d800b982"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0-3 ans" },
                    { new Guid("3e48fc6b-f15d-4c72-99be-b3919fd76177"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12-18 ans" },
                    { new Guid("8e030211-2730-4bba-bdea-031cf2b4a9d0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Professionnels" },
                    { new Guid("9d350951-833a-47e0-a8f2-b634dec0b7e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6-12 ans" },
                    { new Guid("f7b5e33d-1116-4526-9bb0-594f9da7c2b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-6 ans" },
                    { new Guid("fad61b38-c714-4de6-ab1b-e026a6af3c72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parents" }
                });

            migrationBuilder.InsertData(
                table: "Missions",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("077c6cdf-c659-4151-bc9c-e8dc85c07282"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Répit" },
                    { new Guid("0c197cb7-8c06-42ea-9c2f-410a2264f4f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil occasionnel" },
                    { new Guid("2082d8f7-8843-4b97-8e45-db50ad66aa8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group de parole/Ateliers" },
                    { new Guid("39d3bcd4-4b84-445f-8b94-cbcd183017e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soins/santé" },
                    { new Guid("731bb442-9389-4a80-9bec-4408d6ba9273"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement administratif" },
                    { new Guid("807c4c2a-66c2-4062-88f6-729ca93576da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information/orientation" },
                    { new Guid("98d8711b-a848-44ce-a5f5-4bc590b20de1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de loisirs" },
                    { new Guid("99400128-3613-4fa0-b61c-3a39e740ec38"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petite enfance" },
                    { new Guid("b253a9f8-ee72-42f2-8a6c-f5c3e791e8bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de nuit" },
                    { new Guid("bb49faa1-1b64-41b8-a034-9ba2f67e72e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culture et loisirs" },
                    { new Guid("c6fc014d-5f0d-459a-86f5-9cec13b6043e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scolarité" },
                    { new Guid("eae65982-9c2c-40a4-9487-d7927f445c21"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil d’urgence" },
                    { new Guid("f2410298-05ae-4f67-bd9b-f44d4b7b60fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rééducation" },
                    { new Guid("f277bfa6-83a2-4f25-93e2-af782af77bf5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement à la parentalité" }
                });

            migrationBuilder.InsertData(
                table: "PlacesOfIntervention",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("3744f86a-bfec-4125-a97f-d11fe2ba3c19"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiers lieu" },
                    { new Guid("38596a5b-4503-40de-bfe2-90e6d0406a3e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure de soins" },
                    { new Guid("3baca9a2-c4e8-4615-b929-702859286b8b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "École" },
                    { new Guid("3d4adf73-5726-48c7-9317-72dc9aa15c25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EAJE" },
                    { new Guid("52eb7d6b-4244-4941-972c-7b63ba783e83"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure d’orientation et d’information" },
                    { new Guid("6f67161d-68e0-4637-a452-cb97c1973644"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure individuelle" },
                    { new Guid("b0904bae-0333-433c-98c0-bd817b4327ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Institution" },
                    { new Guid("e119cf2d-4c9f-4c84-942f-721dd6134df3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Domicile" }
                });

            migrationBuilder.InsertData(
                table: "ValidationStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("404373e7-9cfe-4b84-9b35-4068b7f704d2"), "Approved" },
                    { new Guid("c44a582d-2524-4fe5-8684-183ad1103f70"), "Waiting After Update" },
                    { new Guid("ef0b5e43-1dc3-4f16-9d28-8035bf1eb3f5"), "Waiting After Creation" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("2c0200a4-d7d2-4937-a314-9d50d800b982"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("3e48fc6b-f15d-4c72-99be-b3919fd76177"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("8e030211-2730-4bba-bdea-031cf2b4a9d0"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("9d350951-833a-47e0-a8f2-b634dec0b7e5"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("f7b5e33d-1116-4526-9bb0-594f9da7c2b9"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("fad61b38-c714-4de6-ab1b-e026a6af3c72"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("077c6cdf-c659-4151-bc9c-e8dc85c07282"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("0c197cb7-8c06-42ea-9c2f-410a2264f4f1"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("2082d8f7-8843-4b97-8e45-db50ad66aa8a"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("39d3bcd4-4b84-445f-8b94-cbcd183017e7"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("731bb442-9389-4a80-9bec-4408d6ba9273"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("807c4c2a-66c2-4062-88f6-729ca93576da"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("98d8711b-a848-44ce-a5f5-4bc590b20de1"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("99400128-3613-4fa0-b61c-3a39e740ec38"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("b253a9f8-ee72-42f2-8a6c-f5c3e791e8bc"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("bb49faa1-1b64-41b8-a034-9ba2f67e72e9"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("c6fc014d-5f0d-459a-86f5-9cec13b6043e"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("eae65982-9c2c-40a4-9487-d7927f445c21"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("f2410298-05ae-4f67-bd9b-f44d4b7b60fd"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("f277bfa6-83a2-4f25-93e2-af782af77bf5"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("3744f86a-bfec-4125-a97f-d11fe2ba3c19"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("38596a5b-4503-40de-bfe2-90e6d0406a3e"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("3baca9a2-c4e8-4615-b929-702859286b8b"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("3d4adf73-5726-48c7-9317-72dc9aa15c25"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("52eb7d6b-4244-4941-972c-7b63ba783e83"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("6f67161d-68e0-4637-a452-cb97c1973644"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("b0904bae-0333-433c-98c0-bd817b4327ba"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("e119cf2d-4c9f-4c84-942f-721dd6134df3"));

            migrationBuilder.DeleteData(
                table: "ValidationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("404373e7-9cfe-4b84-9b35-4068b7f704d2"));

            migrationBuilder.DeleteData(
                table: "ValidationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c44a582d-2524-4fe5-8684-183ad1103f70"));

            migrationBuilder.DeleteData(
                table: "ValidationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ef0b5e43-1dc3-4f16-9d28-8035bf1eb3f5"));

            migrationBuilder.DropColumn(
                name: "ProfessionalId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Audiences",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("0d0edd39-7dab-4041-acf9-354c62d0a7f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6-12 ans" },
                    { new Guid("5ac7dbf0-75aa-40b9-993c-b1d97b7f42f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Professionnels" },
                    { new Guid("9523924f-8cb5-4008-979c-91b96779a56b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-6 ans" },
                    { new Guid("a0b4c38f-f92b-438b-a092-1d53eeb512e3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12-18 ans" },
                    { new Guid("e65421ac-2c75-4a1a-810f-77e2ba94735c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0-3 ans" },
                    { new Guid("ee0ade05-68fb-4bfc-9f26-1bca11edc9c9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parents" }
                });

            migrationBuilder.InsertData(
                table: "Missions",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("059df970-a66a-4a2d-888c-141974946dfc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information/orientation" },
                    { new Guid("1d567382-8820-432b-b6bc-c0023cf398d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culture et loisirs" },
                    { new Guid("3800d12a-f685-42da-9a4a-0c633f50784d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Répit" },
                    { new Guid("55cf1b02-722f-4df5-8762-f2bf5393db02"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de nuit" },
                    { new Guid("5bd2ea93-1ae3-4e30-8f62-3be44ac166a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rééducation" },
                    { new Guid("601b4142-4647-4b0c-9560-b73e0b238988"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil occasionnel" },
                    { new Guid("60c75055-328e-42ff-8e95-70e387ab009d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil d’urgence" },
                    { new Guid("63985109-b470-4855-ba1a-c3ea5ee46572"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement administratif" },
                    { new Guid("7c89ae38-ecbb-464d-9b0e-42e977ef7055"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de loisirs" },
                    { new Guid("8789bc01-35a9-4852-b8cd-ffbba481500e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group de parole/Ateliers" },
                    { new Guid("8fea7ff5-dc8c-4a10-88fc-f35dba38cf3c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soins/santé" },
                    { new Guid("96cb0993-cfbe-48cf-a3a2-8b5d201dd574"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scolarité" },
                    { new Guid("db3a7349-b32b-44dd-936c-c9a89144791c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement à la parentalité" },
                    { new Guid("e163de6e-c2a8-40b7-919a-2dcb6e19f67b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petite enfance" }
                });

            migrationBuilder.InsertData(
                table: "PlacesOfIntervention",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("11e5b81c-239c-4c85-8ea6-1b666c0261af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiers lieu" },
                    { new Guid("3e359c11-b16b-45e0-8ea1-2825f07f7644"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EAJE" },
                    { new Guid("3f98f25b-7f36-4a65-948c-6d2f02ebe5c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure d’orientation et d’information" },
                    { new Guid("711083b5-8eac-4b1f-930f-964ebe45ae07"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Domicile" },
                    { new Guid("750848bb-a735-426d-9b30-d587d221a2f8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "École" },
                    { new Guid("c8d17a8b-d779-44e5-91d1-db7ab74783a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure individuelle" },
                    { new Guid("f89b7694-0424-4728-9f40-2efebf657173"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Institution" },
                    { new Guid("fecb12d7-d46b-46cd-8949-bd87c7a55e7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Structure de soins" }
                });

            migrationBuilder.InsertData(
                table: "ValidationStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("08da705c-4dde-45ee-b94b-f1d7803093ad"), "Waiting After Creation" },
                    { new Guid("b9d2a680-8fe6-4fbe-99bd-6032ec190bcc"), "Approved" },
                    { new Guid("d23a0f58-a503-456e-9242-aa3c6ee7a9bd"), "Waiting After Update" }
                });
        }
    }
}
