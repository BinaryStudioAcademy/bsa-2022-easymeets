using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class ChangedDeletionRuleCalendarsAndTeems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_Teams_AddEventsFromTeamId",
                table: "Calendars");

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 21, 15, 13, 25, 670, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 2L,
                column: "SelectedDate",
                value: new DateTime(2023, 1, 25, 10, 1, 54, 16, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 3L,
                column: "SelectedDate",
                value: new DateTime(2023, 3, 9, 10, 53, 50, 763, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 4L,
                column: "SelectedDate",
                value: new DateTime(2023, 2, 2, 21, 22, 15, 337, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 5L,
                column: "SelectedDate",
                value: new DateTime(2023, 7, 5, 5, 49, 22, 194, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 6L,
                column: "SelectedDate",
                value: new DateTime(2023, 1, 18, 13, 51, 45, 799, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 7L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 20, 20, 26, 0, 971, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 8L,
                column: "SelectedDate",
                value: new DateTime(2023, 7, 31, 20, 38, 39, 296, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 9L,
                column: "SelectedDate",
                value: new DateTime(2023, 5, 1, 15, 45, 58, 854, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 10L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 12, 6, 45, 3, 151, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 9, 10, 53, 50, 776, DateTimeKind.Unspecified).AddTicks(5910), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 31, 20, 38, 39, 310, DateTimeKind.Unspecified).AddTicks(479), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 10, 14, 35, 23, 706, DateTimeKind.Unspecified).AddTicks(2466), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 19, 19, 7, 25, 231, DateTimeKind.Unspecified).AddTicks(3364), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 11, 14, 49, 28, 782, DateTimeKind.Unspecified).AddTicks(6368), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 11, 49, 0, 9, DateTimeKind.Unspecified).AddTicks(415), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 10, 17, 32, 56, 58, DateTimeKind.Unspecified).AddTicks(9916), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 12, 7, 37, 29, 220, DateTimeKind.Unspecified).AddTicks(6644), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 13, 0, 36, 32, 940, DateTimeKind.Unspecified).AddTicks(3956), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 9, 9, 5, 27, 12, 684, DateTimeKind.Unspecified).AddTicks(8073), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_Teams_AddEventsFromTeamId",
                table: "Calendars",
                column: "AddEventsFromTeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_Teams_AddEventsFromTeamId",
                table: "Calendars");

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 21, 7, 47, 55, 452, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 2L,
                column: "SelectedDate",
                value: new DateTime(2023, 1, 25, 2, 36, 23, 798, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 3L,
                column: "SelectedDate",
                value: new DateTime(2023, 3, 9, 3, 28, 20, 545, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 4L,
                column: "SelectedDate",
                value: new DateTime(2023, 2, 2, 13, 56, 45, 119, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 5L,
                column: "SelectedDate",
                value: new DateTime(2023, 7, 4, 22, 23, 51, 976, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 6L,
                column: "SelectedDate",
                value: new DateTime(2023, 1, 18, 6, 26, 15, 581, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 7L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 20, 13, 0, 30, 753, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 8L,
                column: "SelectedDate",
                value: new DateTime(2023, 7, 31, 13, 13, 9, 78, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 9L,
                column: "SelectedDate",
                value: new DateTime(2023, 5, 1, 8, 20, 28, 636, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 10L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 11, 23, 19, 32, 933, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 9, 3, 28, 20, 560, DateTimeKind.Unspecified).AddTicks(17), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 31, 13, 13, 9, 93, DateTimeKind.Unspecified).AddTicks(4467), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 10, 7, 9, 53, 489, DateTimeKind.Unspecified).AddTicks(6418), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 19, 11, 41, 55, 14, DateTimeKind.Unspecified).AddTicks(7281), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 11, 7, 23, 58, 566, DateTimeKind.Unspecified).AddTicks(247), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 4, 23, 29, 792, DateTimeKind.Unspecified).AddTicks(4157), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 10, 10, 7, 25, 842, DateTimeKind.Unspecified).AddTicks(3608), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 12, 0, 11, 59, 4, DateTimeKind.Unspecified).AddTicks(300), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 12, 17, 11, 2, 723, DateTimeKind.Unspecified).AddTicks(7641), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 9, 8, 22, 1, 42, 468, DateTimeKind.Unspecified).AddTicks(1733), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_Teams_AddEventsFromTeamId",
                table: "Calendars",
                column: "AddEventsFromTeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
