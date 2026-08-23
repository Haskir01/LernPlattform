using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LernPlattform.Api.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pruefungsbereiche",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kuerzel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Beschreibung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Farbe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reihenfolge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pruefungsbereiche", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Themen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beschreibung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reihenfolge = table.Column<int>(type: "int", nullable: false),
                    PruefungsbereichId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Themen_Pruefungsbereiche_PruefungsbereichId",
                        column: x => x.PruefungsbereichId,
                        principalTable: "Pruefungsbereiche",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pruefungsbereiche",
                columns: new[] { "Id", "Beschreibung", "Farbe", "Kuerzel", "Reihenfolge", "Titel" },
                values: new object[,]
                {
                    { 1, "Teil 1 der gestreckten Abschlussprüfung", "#2E5395", "AP1", 1, "Einrichten eines IT-gestützten Arbeitsplatzes" },
                    { 2, "Teil 2 – Fachrichtung Systemintegration", "#1B7F5C", "AP2", 2, "Systemintegration" },
                    { 3, "Teil 2 – Fachrichtung Anwendungsentwicklung", "#A34700", "AP2", 3, "Anwendungsentwicklung" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Themen_PruefungsbereichId",
                table: "Themen",
                column: "PruefungsbereichId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Themen");

            migrationBuilder.DropTable(
                name: "Pruefungsbereiche");
        }
    }
}
