using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orion.Migrations
{
    public partial class RenameBadmintonTours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistrations_BadmintonTours_EventIdId",
                table: "EventRegistrations");

            migrationBuilder.RenameColumn(
                name: "EventIdId",
                table: "EventRegistrations",
                newName: "TourIdId");

            migrationBuilder.RenameIndex(
                name: "IX_EventRegistrations_EventIdId",
                table: "EventRegistrations",
                newName: "IX_EventRegistrations_TourIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistrations_BadmintonTours_TourIdId",
                table: "EventRegistrations",
                column: "TourIdId",
                principalTable: "BadmintonTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistrations_BadmintonTours_TourIdId",
                table: "EventRegistrations");

            migrationBuilder.RenameColumn(
                name: "TourIdId",
                table: "EventRegistrations",
                newName: "EventIdId");

            migrationBuilder.RenameIndex(
                name: "IX_EventRegistrations_TourIdId",
                table: "EventRegistrations",
                newName: "IX_EventRegistrations_EventIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistrations_BadmintonTours_EventIdId",
                table: "EventRegistrations",
                column: "EventIdId",
                principalTable: "BadmintonTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
