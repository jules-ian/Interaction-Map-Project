using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InteractiveMapProject.Data.Db.Migrations
{
    /// <inheritdoc />
    public partial class FieldOfIntervetionTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FieldOfIntervention_Audience",
                table: "Professionals");

            migrationBuilder.DropColumn(
                name: "FieldOfIntervention_PlaceOfIntervention",
                table: "Professionals");

            migrationBuilder.DropColumn(
                name: "FieldOfIntervention_SectorOfIntervetion",
                table: "Professionals");

            migrationBuilder.DropColumn(
                name: "Mission",
                table: "Professionals");

            migrationBuilder.CreateTable(
                name: "Audience",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audience", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mission",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaceOfIntervention",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceOfIntervention", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalAudience",
                columns: table => new
                {
                    ProfessionalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AudienceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalAudience", x => new { x.ProfessionalId, x.AudienceId });
                    table.ForeignKey(
                        name: "FK_ProfessionalAudience_Audience_AudienceId",
                        column: x => x.AudienceId,
                        principalTable: "Audience",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionalAudience_Professionals_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "Professionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalMission",
                columns: table => new
                {
                    ProfessionalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalMission", x => new { x.ProfessionalId, x.MissionId });
                    table.ForeignKey(
                        name: "FK_ProfessionalMission_Mission_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Mission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionalMission_Professionals_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "Professionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalPlaceOfIntervention",
                columns: table => new
                {
                    ProfessionalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceOfInterventionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalPlaceOfIntervention", x => new { x.ProfessionalId, x.PlaceOfInterventionId });
                    table.ForeignKey(
                        name: "FK_ProfessionalPlaceOfIntervention_PlaceOfIntervention_PlaceOfInterventionId",
                        column: x => x.PlaceOfInterventionId,
                        principalTable: "PlaceOfIntervention",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionalPlaceOfIntervention_Professionals_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "Professionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalAudience_AudienceId",
                table: "ProfessionalAudience",
                column: "AudienceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalMission_MissionId",
                table: "ProfessionalMission",
                column: "MissionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalPlaceOfIntervention_PlaceOfInterventionId",
                table: "ProfessionalPlaceOfIntervention",
                column: "PlaceOfInterventionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfessionalAudience");

            migrationBuilder.DropTable(
                name: "ProfessionalMission");

            migrationBuilder.DropTable(
                name: "ProfessionalPlaceOfIntervention");

            migrationBuilder.DropTable(
                name: "Audience");

            migrationBuilder.DropTable(
                name: "Mission");

            migrationBuilder.DropTable(
                name: "PlaceOfIntervention");

            migrationBuilder.AddColumn<int>(
                name: "FieldOfIntervention_Audience",
                table: "Professionals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FieldOfIntervention_PlaceOfIntervention",
                table: "Professionals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FieldOfIntervention_SectorOfIntervetion",
                table: "Professionals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Mission",
                table: "Professionals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
