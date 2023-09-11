using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Application.Migrations
{
    /// <inheritdoc />
    public partial class TestDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Draws", "Losses", "TeamCity", "TeamName", "Wins" },
                values: new object[,]
                {
                    { 1, 11, 6, "Madrid", "Real Madrid", 21 },
                    { 2, 9, 3, "Barcelona", "FC Barcelona", 26 },
                    { 3, 6, 10, "Madrid", "Atletico Madrid", 22 },
                    { 4, 7, 16, "Valencia", "Valencia CF", 15 },
                    { 5, 8, 13, "Seville", "Sevilla FC", 17 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
