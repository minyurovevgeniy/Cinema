using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuditoriumManagement.Migrations
{
    /// <inheritdoc />
    public partial class AuditoriumProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlacesCount",
                table: "Auditoriums",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RowsCount",
                table: "Auditoriums",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlacesCount",
                table: "Auditoriums");

            migrationBuilder.DropColumn(
                name: "RowsCount",
                table: "Auditoriums");
        }
    }
}
