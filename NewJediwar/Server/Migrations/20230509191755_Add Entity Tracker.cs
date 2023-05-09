using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewJediwar.Server.Migrations
{
    public partial class AddEntityTracker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Players",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Players",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "GroundEnvironments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    TextureName = table.Column<string>(type: "TEXT", nullable: false),
                    IsPracticable = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsBuildable = table.Column<bool>(type: "INTEGER", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroundEnvironments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Rows = table.Column<int>(type: "INTEGER", nullable: false),
                    Columns = table.Column<int>(type: "INTEGER", nullable: false),
                    CellSize = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanetGrounds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Column = table.Column<int>(type: "INTEGER", nullable: false),
                    Row = table.Column<int>(type: "INTEGER", nullable: false),
                    GroundEnvironmentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PlanetId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanetGrounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanetGrounds_GroundEnvironments_GroundEnvironmentId",
                        column: x => x.GroundEnvironmentId,
                        principalTable: "GroundEnvironments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlanetGrounds_Planets_PlanetId",
                        column: x => x.PlanetId,
                        principalTable: "Planets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_Login",
                table: "Players",
                column: "Login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlanetGrounds_GroundEnvironmentId",
                table: "PlanetGrounds",
                column: "GroundEnvironmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlanetGrounds_PlanetId",
                table: "PlanetGrounds",
                column: "PlanetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanetGrounds");

            migrationBuilder.DropTable(
                name: "GroundEnvironments");

            migrationBuilder.DropTable(
                name: "Planets");

            migrationBuilder.DropIndex(
                name: "IX_Players_Login",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Players");
        }
    }
}
