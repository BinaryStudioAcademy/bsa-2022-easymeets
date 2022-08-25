using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class Change_SlotMember_Relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SlotMembers_Meetings_EventId",
                table: "SlotMembers");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "SlotMembers",
                newName: "AvailabilitySlotId");

            migrationBuilder.RenameIndex(
                name: "IX_SlotMembers_EventId",
                table: "SlotMembers",
                newName: "IX_SlotMembers_AvailabilitySlotId");

            migrationBuilder.AddForeignKey(
                name: "FK_SlotMembers_AvailabilitySlots_AvailabilitySlotId",
                table: "SlotMembers",
                column: "AvailabilitySlotId",
                principalTable: "AvailabilitySlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SlotMembers_AvailabilitySlots_AvailabilitySlotId",
                table: "SlotMembers");

            migrationBuilder.RenameColumn(
                name: "AvailabilitySlotId",
                table: "SlotMembers",
                newName: "EventId");

            migrationBuilder.RenameIndex(
                name: "IX_SlotMembers_AvailabilitySlotId",
                table: "SlotMembers",
                newName: "IX_SlotMembers_EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_SlotMembers_Meetings_EventId",
                table: "SlotMembers",
                column: "EventId",
                principalTable: "Meetings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
