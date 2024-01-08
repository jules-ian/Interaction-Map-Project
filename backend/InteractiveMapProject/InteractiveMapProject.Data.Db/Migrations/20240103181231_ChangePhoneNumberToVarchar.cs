using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InteractiveMapProject.Data.Db.Migrations
{
    /// <inheritdoc />
    public partial class ChangePhoneNumberToVarchar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("12b1c47b-e752-4203-8059-a8bbcb526a9d"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("1a582e56-4e22-40f9-ad71-2f59ad0f8522"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("4c7ab37a-62c3-40e7-bfc5-210d9a3654c4"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("55bc3bb7-3b5d-49e0-a62f-27a705ec84ac"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("d68a3fe3-a1b1-4005-9a67-fec96f230245"));

            migrationBuilder.DeleteData(
                table: "Audiences",
                keyColumn: "Id",
                keyValue: new Guid("f51fc34c-1c5a-45f6-be14-dc1a8e08b54a"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("10072e8f-03bd-457f-a6d8-01b0bd368ea0"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("28c560d8-701f-4013-9c74-12c138651b78"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("2dc71c9e-e077-4cf5-8a84-e2c7ea86f133"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("360bdf6a-396a-40df-b4a4-97b259b4c12a"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("4d0ddaaf-0d0c-4ac7-8c53-1244c3926511"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("6eeefc1e-bd62-46f9-9ffd-8c4e154b579b"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("783ad868-f47d-42ce-8350-652e623c836f"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("863f82c8-2319-4adb-95ca-a678eec78e11"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("8a5157a5-8bee-4f15-b6d7-9308f1440b02"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("90a445eb-5c48-45b2-9e9b-db10c70e018f"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("a8d51451-da44-4248-85ee-b251822415cc"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("af71ede5-4336-4422-bf0f-0cef2a108fe8"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("bb8f5973-92d2-4136-956a-8802d2296385"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("d80477b2-ebb6-4b8a-8044-8002e4ebaabf"));

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: new Guid("df65210e-8ec6-4750-8703-39110fddbdea"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("1012d645-73b3-494d-96ba-49e60a2a606e"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("5c236e21-df55-42b9-9d10-6787f0379f8e"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("80cd1709-4478-4b40-8c0d-7dfd5e7ab210"));

            migrationBuilder.DeleteData(
                table: "PlacesOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("a0b8c54b-c1e4-4c53-9711-6872f5ac6ecb"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Professionals",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPerson_PhoneNumber",
                table: "Professionals",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Professionals",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ContactPerson_PhoneNumber",
                table: "Professionals",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }
    }
}
