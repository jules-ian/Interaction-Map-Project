using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InteractiveMapProject.Data.Db.Migrations
{
    /// <inheritdoc />
    public partial class PostalCodeString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("1d0244f0-e182-49f6-b37e-79c561aadb6c"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("9f097270-dcbd-4d04-b980-bef3382c50ac"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("ae6bd3c0-9271-4ab5-8e1b-973059d5e236"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("d9481828-5a78-4201-8eae-00dbc857103f"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("db0891bd-3704-438e-b001-65b84d47d32f"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("dc9b764f-4a27-4a8d-953e-04880d3801de"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("13309a40-ae58-48bc-a222-162327fba84c"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("1c1d9cc9-8acd-4a46-8e7b-619b535f0177"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("40d689cc-0f1d-4054-bc52-2aae8bead67a"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("4ed1e1b9-8f18-4a98-a681-13f55d7de995"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("505a06e3-164a-4cfe-9432-2e49415a0813"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("534b656d-bf94-4d5d-aa9e-d41f878df2f3"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("6fd4ae72-a20d-4a18-9843-853c3dae85b1"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("7c9be443-b28d-4a04-8af1-b69433c70116"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("9914a004-9cfc-4f71-90aa-bf35a9fc0a5a"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("9de2ae02-5652-4755-b59a-c4aa28ff95ab"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("b6e3adc4-d625-46f9-959e-eec65da4c3b5"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("bafcbe8f-666f-4fe4-9f7a-0f7b8e07d085"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("eba3a34d-79bd-491b-9455-8483c9af1637"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("fa9d27ca-1831-4bb6-8053-ed03df0a4c20"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("fbc107e1-e883-496c-bd6d-703424bf7d1b"));

            migrationBuilder.DeleteData(
                table: "PlaceOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("19309602-02cb-4cb1-972f-c498e5ea31a1"));

            migrationBuilder.DeleteData(
                table: "PlaceOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("52b075ff-0538-4478-9ac2-bd5e0cd87db7"));

            migrationBuilder.DeleteData(
                table: "PlaceOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("53121cc1-1d0d-422e-8b21-3cb6ce59f9c5"));

            migrationBuilder.DeleteData(
                table: "PlaceOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("ac036202-4fde-4ad2-adc2-dc6889388ab6"));

            migrationBuilder.AlterColumn<string>(
                name: "Address_PostalCode",
                table: "Professionals",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Audience",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("2b4d23bb-69f3-4293-b44c-bd2743fc972e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12-18 ans" },
                    { new Guid("78edc373-1e55-4642-beb2-c87a19dc64a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0-3 ans" },
                    { new Guid("970a7fac-b534-43a3-8c4f-4190755ed7cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Professionnels" },
                    { new Guid("b7608311-f345-4f6b-a3c8-83f6e9a314ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-6 ans" },
                    { new Guid("ed95a023-0a1c-4ad0-9ee0-03dc1d579249"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parents" },
                    { new Guid("fd0a0a32-95fe-47c1-9c26-e59927d71d3b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6-12 ans" }
                });

            migrationBuilder.InsertData(
                table: "Mission",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("0387aceb-1b7b-44e8-9037-a91eab6cea1d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ressource documentaire" },
                    { new Guid("16e80f07-e6df-481d-bcc1-bbe91473e124"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de loisirs" },
                    { new Guid("221d692d-35ef-47ac-8b2e-8b23e3c74d31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référent santé accueil inclusif (RSAI)" },
                    { new Guid("2f0e10fd-0820-408a-bf8f-30c9d2998aea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement administratif" },
                    { new Guid("3674fb22-177b-4d0c-aa7c-1278b4e13679"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de jour" },
                    { new Guid("3dfbf728-8b92-4db6-a9ee-bdd72f3377c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prestataire" },
                    { new Guid("6e5ba94d-74d9-4590-a601-d7d1a40a8bef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soins/santé/réeducation" },
                    { new Guid("74866b44-a0e2-4c4e-9f44-ff73c6f17a9a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Répit" },
                    { new Guid("77ac0c16-c62c-4108-8767-be200051a4da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil occasionnel" },
                    { new Guid("78748042-c2f4-4048-a7d1-253dec8daace"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group de parole/Ateliers" },
                    { new Guid("834ed4d1-927a-430f-845d-b307cdad0d80"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orientation" },
                    { new Guid("b8b2b4a8-8b32-4280-b411-1bce2b8d5b06"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scolarité" },
                    { new Guid("b9639141-3a1d-46f3-b495-dc89865de742"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement à la parentalité" },
                    { new Guid("cd88eacd-6066-46f2-99a3-4353860fc558"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de nuit" },
                    { new Guid("ded64fcb-50f1-4acf-83b1-4f9a78ac5a62"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petite enfance" }
                });

            migrationBuilder.InsertData(
                table: "PlaceOfIntervention",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("0c32ed40-6d6c-4fd5-ac61-a75e93e06621"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "École" },
                    { new Guid("19e6647e-bbea-4d0d-8221-93696e511f00"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cabinet" },
                    { new Guid("a36f0642-bb38-44c8-9f5d-31e2741574f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EAJE" },
                    { new Guid("e41afb76-b21b-4513-ad8f-557e72f4136f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Domicile" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("2b4d23bb-69f3-4293-b44c-bd2743fc972e"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("78edc373-1e55-4642-beb2-c87a19dc64a5"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("970a7fac-b534-43a3-8c4f-4190755ed7cc"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("b7608311-f345-4f6b-a3c8-83f6e9a314ab"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("ed95a023-0a1c-4ad0-9ee0-03dc1d579249"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("fd0a0a32-95fe-47c1-9c26-e59927d71d3b"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("0387aceb-1b7b-44e8-9037-a91eab6cea1d"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("16e80f07-e6df-481d-bcc1-bbe91473e124"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("221d692d-35ef-47ac-8b2e-8b23e3c74d31"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("2f0e10fd-0820-408a-bf8f-30c9d2998aea"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("3674fb22-177b-4d0c-aa7c-1278b4e13679"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("3dfbf728-8b92-4db6-a9ee-bdd72f3377c7"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("6e5ba94d-74d9-4590-a601-d7d1a40a8bef"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("74866b44-a0e2-4c4e-9f44-ff73c6f17a9a"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("77ac0c16-c62c-4108-8767-be200051a4da"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("78748042-c2f4-4048-a7d1-253dec8daace"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("834ed4d1-927a-430f-845d-b307cdad0d80"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("b8b2b4a8-8b32-4280-b411-1bce2b8d5b06"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("b9639141-3a1d-46f3-b495-dc89865de742"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("cd88eacd-6066-46f2-99a3-4353860fc558"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("ded64fcb-50f1-4acf-83b1-4f9a78ac5a62"));

            migrationBuilder.DeleteData(
                table: "PlaceOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("0c32ed40-6d6c-4fd5-ac61-a75e93e06621"));

            migrationBuilder.DeleteData(
                table: "PlaceOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("19e6647e-bbea-4d0d-8221-93696e511f00"));

            migrationBuilder.DeleteData(
                table: "PlaceOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("a36f0642-bb38-44c8-9f5d-31e2741574f0"));

            migrationBuilder.DeleteData(
                table: "PlaceOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("e41afb76-b21b-4513-ad8f-557e72f4136f"));

            migrationBuilder.AlterColumn<int>(
                name: "Address_PostalCode",
                table: "Professionals",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Audience",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("1d0244f0-e182-49f6-b37e-79c561aadb6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Professionnels" },
                    { new Guid("9f097270-dcbd-4d04-b980-bef3382c50ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-6 ans" },
                    { new Guid("ae6bd3c0-9271-4ab5-8e1b-973059d5e236"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12-18 ans" },
                    { new Guid("d9481828-5a78-4201-8eae-00dbc857103f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parents" },
                    { new Guid("db0891bd-3704-438e-b001-65b84d47d32f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0-3 ans" },
                    { new Guid("dc9b764f-4a27-4a8d-953e-04880d3801de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6-12 ans" }
                });

            migrationBuilder.InsertData(
                table: "Mission",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("13309a40-ae58-48bc-a222-162327fba84c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de nuit" },
                    { new Guid("1c1d9cc9-8acd-4a46-8e7b-619b535f0177"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement administratif" },
                    { new Guid("40d689cc-0f1d-4054-bc52-2aae8bead67a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Répit" },
                    { new Guid("4ed1e1b9-8f18-4a98-a681-13f55d7de995"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petite enfance" },
                    { new Guid("505a06e3-164a-4cfe-9432-2e49415a0813"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prestataire" },
                    { new Guid("534b656d-bf94-4d5d-aa9e-d41f878df2f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group de parole/Ateliers" },
                    { new Guid("6fd4ae72-a20d-4a18-9843-853c3dae85b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orientation" },
                    { new Guid("7c9be443-b28d-4a04-8af1-b69433c70116"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de loisirs" },
                    { new Guid("9914a004-9cfc-4f71-90aa-bf35a9fc0a5a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scolarité" },
                    { new Guid("9de2ae02-5652-4755-b59a-c4aa28ff95ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement à la parentalité" },
                    { new Guid("b6e3adc4-d625-46f9-959e-eec65da4c3b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soins/santé/réeducation" },
                    { new Guid("bafcbe8f-666f-4fe4-9f7a-0f7b8e07d085"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référent santé accueil inclusif (RSAI)" },
                    { new Guid("eba3a34d-79bd-491b-9455-8483c9af1637"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ressource documentaire" },
                    { new Guid("fa9d27ca-1831-4bb6-8053-ed03df0a4c20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de jour" },
                    { new Guid("fbc107e1-e883-496c-bd6d-703424bf7d1b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil occasionnel" }
                });

            migrationBuilder.InsertData(
                table: "PlaceOfIntervention",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("19309602-02cb-4cb1-972f-c498e5ea31a1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EAJE" },
                    { new Guid("52b075ff-0538-4478-9ac2-bd5e0cd87db7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cabinet" },
                    { new Guid("53121cc1-1d0d-422e-8b21-3cb6ce59f9c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Domicile" },
                    { new Guid("ac036202-4fde-4ad2-adc2-dc6889388ab6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "École" }
                });
        }
    }
}
