using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class Add_And_Rename_Columns_In_Tables_In_Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SlotMembers_AvailabilitySlots_AvailabilitySlotId",
                table: "SlotMembers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Meetings");

            migrationBuilder.RenameColumn(
                name: "AvailabilitySlotId",
                table: "SlotMembers",
                newName: "SlotId");

            migrationBuilder.RenameIndex(
                name: "IX_SlotMembers_AvailabilitySlotId",
                table: "SlotMembers",
                newName: "IX_SlotMembers_SlotId");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Questions",
                newName: "QuestionText");

            migrationBuilder.AddColumn<long>(
                name: "MeetingId",
                table: "ExternalAttendees",
                type: "bigint",
                nullable: false,
                defaultValue: 1L);

            migrationBuilder.CreateIndex(
                name: "IX_ExternalAttendees_MeetingId",
                table: "ExternalAttendees",
                column: "MeetingId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalAttendees_Meetings_MeetingId",
                table: "ExternalAttendees",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SlotMembers_AvailabilitySlots_SlotId",
                table: "SlotMembers",
                column: "SlotId",
                principalTable: "AvailabilitySlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExternalAttendees_Meetings_MeetingId",
                table: "ExternalAttendees");

            migrationBuilder.DropForeignKey(
                name: "FK_SlotMembers_AvailabilitySlots_SlotId",
                table: "SlotMembers");

            migrationBuilder.DropIndex(
                name: "IX_ExternalAttendees_MeetingId",
                table: "ExternalAttendees");

            migrationBuilder.DropColumn(
                name: "MeetingId",
                table: "ExternalAttendees");

            migrationBuilder.RenameColumn(
                name: "SlotId",
                table: "SlotMembers",
                newName: "AvailabilitySlotId");

            migrationBuilder.RenameIndex(
                name: "IX_SlotMembers_SlotId",
                table: "SlotMembers",
                newName: "IX_SlotMembers_AvailabilitySlotId");

            migrationBuilder.RenameColumn(
                name: "QuestionText",
                table: "Questions",
                newName: "Text");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Meetings",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_SlotMembers_AvailabilitySlots_AvailabilitySlotId",
                table: "SlotMembers",
                column: "AvailabilitySlotId",
                principalTable: "AvailabilitySlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
