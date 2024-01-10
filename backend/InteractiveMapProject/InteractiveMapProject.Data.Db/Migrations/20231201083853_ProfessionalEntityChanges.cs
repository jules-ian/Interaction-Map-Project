using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InteractiveMapProject.Data.Db.Migrations
{
    /// <inheritdoc />
    public partial class ProfessionalEntityChanges : Migration
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

            migrationBuilder.RenameColumn(
                name: "Function",
                table: "Professionals",
                newName: "ContactPerson_Function");

            migrationBuilder.RenameColumn(
                name: "ServiceName",
                table: "Professionals",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ResourcePersonName",
                table: "Professionals",
                newName: "ManagementType");

            migrationBuilder.RenameColumn(
                name: "ContactPersonPhoneNumber",
                table: "Professionals",
                newName: "ContactPerson_PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "ContactPersonEmail",
                table: "Professionals",
                newName: "EstablishmentType");

            migrationBuilder.AlterColumn<string>(
                name: "Address_PostalCode",
                table: "Professionals",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson_Email",
                table: "Professionals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson_Name",
                table: "Professionals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Audience",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("08499b0d-d84e-48fa-ab72-c92b44d970ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0-3 ans" },
                    { new Guid("08dd40aa-2914-4c89-8aea-e77690aca330"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Professionnels" },
                    { new Guid("111649a6-d9f0-4eb6-bc3d-d442cc7cb339"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parents" },
                    { new Guid("40583a00-202c-4f3a-84e0-7c694bc54c5c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12-18 ans" },
                    { new Guid("a704d604-64a4-4744-a6ff-367665f9fb63"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6-12 ans" },
                    { new Guid("dfa30635-f3a7-48c1-9e20-b1ed707e3b7d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-6 ans" }
                });

            migrationBuilder.InsertData(
                table: "Mission",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("11794a69-017f-4aac-b149-a45d7414b2fb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group de parole/Ateliers" },
                    { new Guid("28abc809-4cc2-4b3d-af91-84d8a253507f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référent santé accueil inclusif (RSAI)" },
                    { new Guid("48251484-af8d-46f0-bfee-7ac003ce4796"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de jour" },
                    { new Guid("57dcfb42-63e7-4fad-ae10-c01485392a54"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prestataire" },
                    { new Guid("5ac71f7a-a45e-4a6e-bb75-dd6c34dbce8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil occasionnel" },
                    { new Guid("5ce9bf4f-5f7e-4da2-9e54-2dc468b21076"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ressource documentaire" },
                    { new Guid("85066c22-a3db-463a-822d-a82517f133a1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petite enfance" },
                    { new Guid("a67ef4c6-13d2-46b7-822a-53a37338b19d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orientation" },
                    { new Guid("a924ab04-c9f7-4839-9a43-dbf1e911f0ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soins/santé/réeducation" },
                    { new Guid("b6b6eaa0-5bed-4d0a-9b53-f5c28ce107be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement administratif" },
                    { new Guid("b6c80dcb-af30-47e2-a92a-705f31b8e7a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scolarité" },
                    { new Guid("b8af1553-b757-4447-a812-8f54b18ab34e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement à la parentalité" },
                    { new Guid("e2ff102a-9fc5-452f-8304-713f1d95f265"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Répit" },
                    { new Guid("fb389fde-bcde-432b-940f-a5313e544261"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de nuit" },
                    { new Guid("fcd87608-d988-4de8-9572-2c57914be44d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de loisirs" }
                });

            migrationBuilder.InsertData(
                table: "PlaceOfIntervention",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("27e22fd0-f039-4fec-a701-ee526196ebcb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "École" },
                    { new Guid("2f00fb03-b808-4787-b587-371564857d92"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EAJE" },
                    { new Guid("387770a9-035f-4c9f-a1c8-4a8b5cb6edeb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Domicile" },
                    { new Guid("a4c84460-ae1b-401f-bdd1-826d91d0acae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cabinet" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("08499b0d-d84e-48fa-ab72-c92b44d970ed"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("08dd40aa-2914-4c89-8aea-e77690aca330"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("111649a6-d9f0-4eb6-bc3d-d442cc7cb339"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("40583a00-202c-4f3a-84e0-7c694bc54c5c"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("a704d604-64a4-4744-a6ff-367665f9fb63"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("dfa30635-f3a7-48c1-9e20-b1ed707e3b7d"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("11794a69-017f-4aac-b149-a45d7414b2fb"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("28abc809-4cc2-4b3d-af91-84d8a253507f"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("48251484-af8d-46f0-bfee-7ac003ce4796"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("57dcfb42-63e7-4fad-ae10-c01485392a54"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("5ac71f7a-a45e-4a6e-bb75-dd6c34dbce8d"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("5ce9bf4f-5f7e-4da2-9e54-2dc468b21076"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("85066c22-a3db-463a-822d-a82517f133a1"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("a67ef4c6-13d2-46b7-822a-53a37338b19d"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("a924ab04-c9f7-4839-9a43-dbf1e911f0ba"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("b6b6eaa0-5bed-4d0a-9b53-f5c28ce107be"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("b6c80dcb-af30-47e2-a92a-705f31b8e7a2"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("b8af1553-b757-4447-a812-8f54b18ab34e"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("e2ff102a-9fc5-452f-8304-713f1d95f265"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("fb389fde-bcde-432b-940f-a5313e544261"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("fcd87608-d988-4de8-9572-2c57914be44d"));

            migrationBuilder.DeleteData(
                table: "PlaceOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("27e22fd0-f039-4fec-a701-ee526196ebcb"));

            migrationBuilder.DeleteData(
                table: "PlaceOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("2f00fb03-b808-4787-b587-371564857d92"));

            migrationBuilder.DeleteData(
                table: "PlaceOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("387770a9-035f-4c9f-a1c8-4a8b5cb6edeb"));

            migrationBuilder.DeleteData(
                table: "PlaceOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("a4c84460-ae1b-401f-bdd1-826d91d0acae"));

            migrationBuilder.DropColumn(
                name: "ContactPerson_Email",
                table: "Professionals");

            migrationBuilder.DropColumn(
                name: "ContactPerson_Name",
                table: "Professionals");

            migrationBuilder.RenameColumn(
                name: "ContactPerson_Function",
                table: "Professionals",
                newName: "Function");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Professionals",
                newName: "ServiceName");

            migrationBuilder.RenameColumn(
                name: "ManagementType",
                table: "Professionals",
                newName: "ResourcePersonName");

            migrationBuilder.RenameColumn(
                name: "EstablishmentType",
                table: "Professionals",
                newName: "ContactPersonEmail");

            migrationBuilder.RenameColumn(
                name: "ContactPerson_PhoneNumber",
                table: "Professionals",
                newName: "ContactPersonPhoneNumber");

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
