using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Weather.Migrations
{
    /// <inheritdoc />
    public partial class ColumnRenamed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SearchHistory",
                table: "ForecastHistories",
                newName: "SearchTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SearchTime",
                table: "ForecastHistories",
                newName: "SearchHistory");
        }
    }
}
