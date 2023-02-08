using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Weather.Migrations
{
    /// <inheritdoc />
    public partial class WeatherArraychanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Forecasts_ForecastId",
                table: "Weather");

            migrationBuilder.AlterColumn<string>(
                name: "_base",
                table: "Forecasts",
                type: "nvarchar(30)",
                nullable: true,
                defaultValue: "",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ForecastId",
                table: "Weather",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_Forecasts_ForecastId",
                table: "Weather",
                column: "ForecastId",
                principalTable: "Forecasts",
                principalColumn: "ForecastId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Forecasts_ForecastId",
                table: "Weather");

            migrationBuilder.AlterColumn<int>(
                name: "ForecastId",
                table: "Weather",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_Forecasts_ForecastId",
                table: "Weather",
                column: "ForecastId",
                principalTable: "Forecasts",
                principalColumn: "ForecastId");
        }
    }
}
