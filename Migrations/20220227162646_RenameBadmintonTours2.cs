using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orion.Migrations
{
    public partial class RenameBadmintonTours2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistrations_AspNetUsers_UserIdId",
                table: "EventRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistrations_Tours_TourIdId",
                table: "EventRegistrations");

            migrationBuilder.RenameColumn(
                name: "UserIdId",
                table: "EventRegistrations",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "TourIdId",
                table: "EventRegistrations",
                newName: "TourId");

            migrationBuilder.RenameIndex(
                name: "IX_EventRegistrations_UserIdId",
                table: "EventRegistrations",
                newName: "IX_EventRegistrations_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_EventRegistrations_TourIdId",
                table: "EventRegistrations",
                newName: "IX_EventRegistrations_TourId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistrations_AspNetUsers_UserId",
                table: "EventRegistrations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistrations_Tours_TourId",
                table: "EventRegistrations",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistrations_AspNetUsers_UserId",
                table: "EventRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_EventRegistrations_Tours_TourId",
                table: "EventRegistrations");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "EventRegistrations",
                newName: "UserIdId");

            migrationBuilder.RenameColumn(
                name: "TourId",
                table: "EventRegistrations",
                newName: "TourIdId");

            migrationBuilder.RenameIndex(
                name: "IX_EventRegistrations_UserId",
                table: "EventRegistrations",
                newName: "IX_EventRegistrations_UserIdId");

            migrationBuilder.RenameIndex(
                name: "IX_EventRegistrations_TourId",
                table: "EventRegistrations",
                newName: "IX_EventRegistrations_TourIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistrations_AspNetUsers_UserIdId",
                table: "EventRegistrations",
                column: "UserIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegistrations_Tours_TourIdId",
                table: "EventRegistrations",
                column: "TourIdId",
                principalTable: "Tours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
