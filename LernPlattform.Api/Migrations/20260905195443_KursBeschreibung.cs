using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LernPlattform.Api.Migrations
{
    /// <inheritdoc />
    public partial class KursBeschreibung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Beschreibung",
                table: "Kurse",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Kurse",
                keyColumn: "Id",
                keyValue: 1,
                column: "Beschreibung",
                value: "AP1, AP2 und Wiso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Beschreibung",
                table: "Kurse");
        }
    }
}
