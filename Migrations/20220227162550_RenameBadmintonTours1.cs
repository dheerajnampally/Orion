using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orion.Migrations
{
    public partial class RenameBadmintonTours1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistrations_BadmintonTours_TourIdId",
                table: "EventRegistrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BadmintonTours",
                table: "BadmintonTours");

            migrationBuilder.RenameTable(
                name: "BadmintonTours",
                newName: "Tours");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tours",
                table: "Tours",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistrations_Tours_TourIdId",
                table: "EventRegistrations",
                column: "TourIdId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistrations_Tours_TourIdId",
                table: "EventRegistrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tours",
                table: "Tours");

            migrationBuilder.RenameTable(
                name: "Tours",
                newName: "BadmintonTours");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BadmintonTours",
                table: "BadmintonTours",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistrations_BadmintonTours_TourIdId",
                table: "EventRegistrations",
                column: "TourIdId",
                principalTable: "BadmintonTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
