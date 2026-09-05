using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LernPlattform.Api.Migrations
{
    /// <inheritdoc />
    public partial class KurseUndFachgebiete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Themen_Pruefungsbereiche_PruefungsbereichId",
                table: "Themen");

            migrationBuilder.DropIndex(
                name: "IX_Themen_PruefungsbereichId",
                table: "Themen");

            migrationBuilder.AddColumn<int>(
                name: "FachgebietId",
                table: "Themen",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lernfeld",
                table: "Themen",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KursId",
                table: "Pruefungsbereiche",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Fachgebiete",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reihenfolge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fachgebiete", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kurse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reihenfolge = table.Column<int>(type: "int", nullable: false),
                    IsAktiv = table.Column<bool>(type: "bit", nullable: false),
                    Farbe = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurse", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Fachgebiete",
                columns: new[] { "Id", "Bezeichnung", "Reihenfolge" },
                values: new object[,]
                {
                    { 1, "Projektmanagement", 1 },
                    { 2, "Modellierung", 2 },
                    { 3, "Projektprüfung", 3 },
                    { 4, "Hardware", 4 },
                    { 5, "Betriebssysteme", 5 },
                    { 6, "Software und KI", 6 },
                    { 7, "Netzwerk", 7 },
                    { 8, "Netzwerkdienste", 8 },
                    { 9, "Cloud und Virtualisierung", 9 },
                    { 10, "IT-Sicherheit", 10 },
                    { 11, "Datenschutz", 11 },
                    { 12, "Storage und Backup", 12 },
                    { 13, "Verfügbarkeit", 13 },
                    { 14, "Systemadministration", 14 },
                    { 15, "Programmierung", 15 },
                    { 16, "Datenbanken", 16 },
                    { 17, "Softwarearchitektur", 17 },
                    { 18, "Softwarequalität", 18 },
                    { 19, "Benutzeroberfläche", 19 },
                    { 20, "Schnittstellen und Web", 20 },
                    { 21, "Werkzeuge und DevOps", 21 },
                    { 22, "Cyber-physische Systeme", 22 },
                    { 23, "BWL", 23 },
                    { 24, "WiSo", 24 },
                    { 25, "Recht und Lizenzen", 25 },
                    { 26, "Nachhaltigkeit", 26 },
                    { 27, "Service und Support", 27 },
                    { 28, "Kommunikation", 28 }
                });

            migrationBuilder.InsertData(
                table: "Kurse",
                columns: new[] { "Id", "Bezeichnung", "Farbe", "IsAktiv", "Reihenfolge" },
                values: new object[] { 1, "Fachinformatiker Baden-Württemberg", "#1F3864", false, 1 });

            migrationBuilder.UpdateData(
                table: "Pruefungsbereiche",
                keyColumn: "Id",
                keyValue: 1,
                column: "KursId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pruefungsbereiche",
                keyColumn: "Id",
                keyValue: 2,
                column: "KursId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pruefungsbereiche",
                keyColumn: "Id",
                keyValue: 3,
                column: "KursId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Pruefungsbereiche",
                columns: new[] { "Id", "Beschreibung", "Farbe", "Kuerzel", "KursId", "Reihenfolge", "Titel" },
                values: new object[] { 4, "Teil 2 – 10 Prozent der Gesamtnote", "#6B4C9A", "WiSo", 1, 4, "Wirtschafts- und Sozialkunde" });

            migrationBuilder.CreateIndex(
                name: "IX_Themen_FachgebietId",
                table: "Themen",
                column: "FachgebietId");

            migrationBuilder.CreateIndex(
                name: "IX_Pruefungsbereiche_KursId",
                table: "Pruefungsbereiche",
                column: "KursId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pruefungsbereiche_Kurse_KursId",
                table: "Pruefungsbereiche",
                column: "KursId",
                principalTable: "Kurse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Themen_Fachgebiete_FachgebietId",
                table: "Themen",
                column: "FachgebietId",
                principalTable: "Fachgebiete",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pruefungsbereiche_Kurse_KursId",
                table: "Pruefungsbereiche");

            migrationBuilder.DropForeignKey(
                name: "FK_Themen_Fachgebiete_FachgebietId",
                table: "Themen");

            migrationBuilder.DropTable(
                name: "Fachgebiete");

            migrationBuilder.DropTable(
                name: "Kurse");

            migrationBuilder.DropIndex(
                name: "IX_Themen_FachgebietId",
                table: "Themen");

            migrationBuilder.DropIndex(
                name: "IX_Pruefungsbereiche_KursId",
                table: "Pruefungsbereiche");

            migrationBuilder.DeleteData(
                table: "Pruefungsbereiche",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "FachgebietId",
                table: "Themen");

            migrationBuilder.DropColumn(
                name: "Lernfeld",
                table: "Themen");

            migrationBuilder.DropColumn(
                name: "KursId",
                table: "Pruefungsbereiche");

            migrationBuilder.CreateIndex(
                name: "IX_Themen_PruefungsbereichId",
                table: "Themen",
                column: "PruefungsbereichId");

            migrationBuilder.AddForeignKey(
                name: "FK_Themen_Pruefungsbereiche_PruefungsbereichId",
                table: "Themen",
                column: "PruefungsbereichId",
                principalTable: "Pruefungsbereiche",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
