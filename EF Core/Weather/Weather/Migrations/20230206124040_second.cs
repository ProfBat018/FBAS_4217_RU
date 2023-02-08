using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Weather.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clouds",
                columns: table => new
                {
                    CloudsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    all = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clouds", x => x.CloudsId);
                });

            migrationBuilder.CreateTable(
                name: "Coord",
                columns: table => new
                {
                    CoordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lon = table.Column<float>(type: "real", nullable: false),
                    lat = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coord", x => x.CoordId);
                });

            migrationBuilder.CreateTable(
                name: "Main",
                columns: table => new
                {
                    MainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    temp = table.Column<float>(type: "real", nullable: false),
                    feelslike = table.Column<float>(name: "feels_like", type: "real", nullable: false),
                    tempmin = table.Column<float>(name: "temp_min", type: "real", nullable: false),
                    tempmax = table.Column<float>(name: "temp_max", type: "real", nullable: false),
                    pressure = table.Column<int>(type: "int", nullable: false),
                    humidity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Main", x => x.MainId);
                });

            migrationBuilder.CreateTable(
                name: "Sys",
                columns: table => new
                {
                    SysId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sunrise = table.Column<int>(type: "int", nullable: false),
                    sunset = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys", x => x.SysId);
                });

            migrationBuilder.CreateTable(
                name: "Wind",
                columns: table => new
                {
                    WindId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    speed = table.Column<float>(type: "real", nullable: false),
                    deg = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wind", x => x.WindId);
                });

            migrationBuilder.CreateTable(
                name: "Forecasts",
                columns: table => new
                {
                    ForecastId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoordId = table.Column<int>(type: "int", nullable: false),
                    @base = table.Column<string>(name: "_base", type: "nvarchar(max)", nullable: false),
                    MainId = table.Column<int>(type: "int", nullable: false),
                    visibility = table.Column<int>(type: "int", nullable: false),
                    WindId = table.Column<int>(type: "int", nullable: false),
                    CloudsId = table.Column<int>(type: "int", nullable: false),
                    dt = table.Column<int>(type: "int", nullable: false),
                    SysId = table.Column<int>(type: "int", nullable: false),
                    timezone = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forecasts", x => x.ForecastId);
                    table.ForeignKey(
                        name: "FK_Forecasts_Clouds_CloudsId",
                        column: x => x.CloudsId,
                        principalTable: "Clouds",
                        principalColumn: "CloudsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forecasts_Coord_CoordId",
                        column: x => x.CoordId,
                        principalTable: "Coord",
                        principalColumn: "CoordId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forecasts_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "MainId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forecasts_Sys_SysId",
                        column: x => x.SysId,
                        principalTable: "Sys",
                        principalColumn: "SysId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forecasts_Wind_WindId",
                        column: x => x.WindId,
                        principalTable: "Wind",
                        principalColumn: "WindId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForecastHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForecastId = table.Column<int>(type: "int", nullable: false),
                    SearchHistory = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForecastHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForecastHistories_Forecasts_ForecastId",
                        column: x => x.ForecastId,
                        principalTable: "Forecasts",
                        principalColumn: "ForecastId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    WeatherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id = table.Column<int>(type: "int", nullable: false),
                    main = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ForecastId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.WeatherId);
                    table.ForeignKey(
                        name: "FK_Weather_Forecasts_ForecastId",
                        column: x => x.ForecastId,
                        principalTable: "Forecasts",
                        principalColumn: "ForecastId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ForecastHistories_ForecastId",
                table: "ForecastHistories",
                column: "ForecastId");

            migrationBuilder.CreateIndex(
                name: "IX_Forecasts_CloudsId",
                table: "Forecasts",
                column: "CloudsId");

            migrationBuilder.CreateIndex(
                name: "IX_Forecasts_CoordId",
                table: "Forecasts",
                column: "CoordId");

            migrationBuilder.CreateIndex(
                name: "IX_Forecasts_MainId",
                table: "Forecasts",
                column: "MainId");

            migrationBuilder.CreateIndex(
                name: "IX_Forecasts_SysId",
                table: "Forecasts",
                column: "SysId");

            migrationBuilder.CreateIndex(
                name: "IX_Forecasts_WindId",
                table: "Forecasts",
                column: "WindId");

            migrationBuilder.CreateIndex(
                name: "IX_Weather_ForecastId",
                table: "Weather",
                column: "ForecastId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForecastHistories");

            migrationBuilder.DropTable(
                name: "Weather");

            migrationBuilder.DropTable(
                name: "Forecasts");

            migrationBuilder.DropTable(
                name: "Clouds");

            migrationBuilder.DropTable(
                name: "Coord");

            migrationBuilder.DropTable(
                name: "Main");

            migrationBuilder.DropTable(
                name: "Sys");

            migrationBuilder.DropTable(
                name: "Wind");
        }
    }
}
