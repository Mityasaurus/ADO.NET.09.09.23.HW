using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Migrations
{
    /// <inheritdoc />
    public partial class InsertScoredConcededGoals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("update Teams " +
                                 "SET ScoredGoals = 19 " +
                                 "WHERE ID = 4");

            migrationBuilder.Sql("update Teams " +
                                 "SET ConcededGoals = 21 " +
                                 "WHERE ID = 4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
