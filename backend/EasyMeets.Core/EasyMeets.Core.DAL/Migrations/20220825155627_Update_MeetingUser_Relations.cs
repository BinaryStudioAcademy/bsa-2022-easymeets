using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class Update_MeetingUser_Relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                 name: "MeetingMembers",
                 columns: table => new
                 {
                     TeamMemberId = table.Column<long>(type: "bigint", nullable: false),
                     MeetingId = table.Column<long>(type: "bigint", nullable: false)
                 },
                 constraints: table =>
                 {
                     table.PrimaryKey("PK_MeetingMembers", x => new { x.TeamMemberId, x.MeetingId });
                     table.ForeignKey(
                         name: "FK_MeetingMembers_Meetings_MeetingId",
                         column: x => x.MeetingId,
                         principalTable: "Meetings",
                         principalColumn: "Id",
                         onDelete: ReferentialAction.Cascade);
                     table.ForeignKey(
                         name: "FK_MeetingMembers_TeamMembers_TeamMemberId",
                         column: x => x.TeamMemberId,
                         principalTable: "TeamMembers",
                         principalColumn: "Id",
                         onDelete: ReferentialAction.Cascade);
                 });

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

            migrationBuilder.DropTable(
              name: "UserSlot");

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
            migrationBuilder.DropTable(
                name: "MeetingMembers");

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

            migrationBuilder.CreateTable(
                name: "UserSlot",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailabilitySlotId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSlot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSlot_AvailabilitySlots_AvailabilitySlotId",
                        column: x => x.AvailabilitySlotId,
                        principalTable: "AvailabilitySlots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSlot_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserSlot",
                columns: new[] { "Id", "AvailabilitySlotId", "IsDeleted", "UserId" },
                values: new object[,]
                {
                    { 1L, 1L, false, 1L },
                    { 2L, 2L, false, 2L },
                    { 3L, 3L, false, 3L },
                    { 4L, 4L, false, 4L },
                    { 5L, 5L, false, 5L },
                    { 6L, 6L, false, 6L },
                    { 7L, 7L, false, 7L },
                    { 8L, 8L, false, 8L },
                    { 9L, 9L, false, 9L },
                    { 10L, 10L, false, 10L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserSlot_AvailabilitySlotId",
                table: "UserSlot",
                column: "AvailabilitySlotId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSlot_UserId",
                table: "UserSlot",
                column: "UserId");

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
