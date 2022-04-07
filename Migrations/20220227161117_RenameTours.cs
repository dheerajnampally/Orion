using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orion.Migrations
{
    public partial class RenameTours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistrations_Tours_EventIdId",
                table: "EventRegistrations");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.CreateTable(
                name: "BadmintonTours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BadmintonTours", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistrations_BadmintonTours_EventIdId",
                table: "EventRegistrations",
                column: "EventIdId",
                principalTable: "BadmintonTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistrations_BadmintonTours_EventIdId",
                table: "EventRegistrations");

            migrationBuilder.DropTable(
                name: "BadmintonTours");

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistrations_Tours_EventIdId",
                table: "EventRegistrations",
                column: "EventIdId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
