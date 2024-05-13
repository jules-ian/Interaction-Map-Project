using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InteractiveMapProject.Data.Db.Migrations
{
    public partial class AddIdentityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PendingProfessionals_ValidationStatuses_ValidationStatusId",
                table: "PendingProfessionals");

            migrationBuilder.DropForeignKey(
                name: "FK_Professionals_ValidationStatuses_ValidationStatusId",
                table: "Professionals");

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

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_PendingProfessionals_ValidationStatuses_ValidationStatusId",
                table: "PendingProfessionals",
                column: "ValidationStatusId",
                principalTable: "ValidationStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Professionals_ValidationStatuses_ValidationStatusId",
                table: "Professionals",
                column: "ValidationStatusId",
                principalTable: "ValidationStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PendingProfessionals_ValidationStatuses_ValidationStatusId",
                table: "PendingProfessionals");

            migrationBuilder.DropForeignKey(
                name: "FK_Professionals_ValidationStatuses_ValidationStatusId",
                table: "Professionals");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
                name: "FK_PendingProfessionals_ValidationStatuses_ValidationStatusId",
                table: "PendingProfessionals",
                column: "ValidationStatusId",
                principalTable: "ValidationStatuses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Professionals_ValidationStatuses_ValidationStatusId",
                table: "Professionals",
                column: "ValidationStatusId",
                principalTable: "ValidationStatuses",
                principalColumn: "Id");
        }
    }
}
