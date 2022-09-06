using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class ChangedRelationBetweenAvailabilityAndMeetings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_AvailabilitySlots_AvailabilitySlotId",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_AvailabilitySlotId",
                table: "Meetings");

            migrationBuilder.AlterColumn<long>(
                name: "AvailabilitySlotId",
                table: "Meetings",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 2, 12, 39, 44, 334, DateTimeKind.Unspecified).AddTicks(6629), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 24, 22, 24, 32, 868, DateTimeKind.Unspecified).AddTicks(1242), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 3, 16, 21, 17, 264, DateTimeKind.Unspecified).AddTicks(3224), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 12, 20, 53, 18, 789, DateTimeKind.Unspecified).AddTicks(4122), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 4, 16, 35, 22, 340, DateTimeKind.Unspecified).AddTicks(7124), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 23, 13, 34, 53, 567, DateTimeKind.Unspecified).AddTicks(1072), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 3, 19, 18, 49, 617, DateTimeKind.Unspecified).AddTicks(562), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 5, 9, 23, 22, 778, DateTimeKind.Unspecified).AddTicks(7381), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 6, 2, 22, 26, 498, DateTimeKind.Unspecified).AddTicks(4701), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 9, 2, 7, 13, 6, 242, DateTimeKind.Unspecified).AddTicks(8819), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_AvailabilitySlotId",
                table: "Meetings",
                column: "AvailabilitySlotId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_AvailabilitySlots_AvailabilitySlotId",
                table: "Meetings",
                column: "AvailabilitySlotId",
                principalTable: "AvailabilitySlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_AvailabilitySlots_AvailabilitySlotId",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_AvailabilitySlotId",
                table: "Meetings");

            migrationBuilder.AlterColumn<long>(
                name: "AvailabilitySlotId",
                table: "Meetings",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 2, 5, 1, 33, 603, DateTimeKind.Unspecified).AddTicks(986), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 24, 14, 46, 22, 136, DateTimeKind.Unspecified).AddTicks(5876), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 3, 8, 43, 6, 532, DateTimeKind.Unspecified).AddTicks(7959), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 12, 13, 15, 8, 57, DateTimeKind.Unspecified).AddTicks(8929), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 4, 8, 57, 11, 609, DateTimeKind.Unspecified).AddTicks(2015), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 23, 5, 56, 42, 835, DateTimeKind.Unspecified).AddTicks(6054), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 3, 11, 40, 38, 885, DateTimeKind.Unspecified).AddTicks(5789), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 5, 1, 45, 12, 47, DateTimeKind.Unspecified).AddTicks(2674), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 5, 18, 44, 15, 767, DateTimeKind.Unspecified).AddTicks(62), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 9, 1, 23, 34, 55, 511, DateTimeKind.Unspecified).AddTicks(4243), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_AvailabilitySlotId",
                table: "Meetings",
                column: "AvailabilitySlotId",
                unique: true,
                filter: "[AvailabilitySlotId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_AvailabilitySlots_AvailabilitySlotId",
                table: "Meetings",
                column: "AvailabilitySlotId",
                principalTable: "AvailabilitySlots",
                principalColumn: "Id");
        }
    }
}
