using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Migrations
{
    /// <inheritdoc />
    public partial class ScoredConcededGoalsColumnsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConcededGoals",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ScoredGoals",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ConcededGoals", "ScoredGoals" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ConcededGoals", "ScoredGoals" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "ConcededGoals", "ScoredGoals" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "ConcededGoals", "ScoredGoals" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "ConcededGoals", "ScoredGoals" },
                values: new object[] { 0, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcededGoals",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ScoredGoals",
                table: "Teams");
        }
    }
}
