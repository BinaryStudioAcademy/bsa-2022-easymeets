using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class ChangedDeletionBehaviorForTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailabilitySlots_Teams_TeamId",
                table: "AvailabilitySlots");

            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_Teams_AddEventsFromTeamId",
                table: "Calendars");

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 21, 17, 22, 3, 617, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 2L,
                column: "SelectedDate",
                value: new DateTime(2023, 1, 25, 12, 10, 31, 963, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 3L,
                column: "SelectedDate",
                value: new DateTime(2023, 3, 9, 13, 2, 28, 710, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 4L,
                column: "SelectedDate",
                value: new DateTime(2023, 2, 2, 23, 30, 53, 284, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 5L,
                column: "SelectedDate",
                value: new DateTime(2023, 7, 5, 7, 58, 0, 141, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 6L,
                column: "SelectedDate",
                value: new DateTime(2023, 1, 18, 16, 0, 23, 746, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 7L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 20, 22, 34, 38, 918, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 8L,
                column: "SelectedDate",
                value: new DateTime(2023, 7, 31, 22, 47, 17, 243, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 9L,
                column: "SelectedDate",
                value: new DateTime(2023, 5, 1, 17, 54, 36, 801, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 10L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 12, 8, 53, 41, 98, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 9, 13, 2, 28, 723, DateTimeKind.Unspecified).AddTicks(4682), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 31, 22, 47, 17, 256, DateTimeKind.Unspecified).AddTicks(9270), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 10, 16, 44, 1, 653, DateTimeKind.Unspecified).AddTicks(1266), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 19, 21, 16, 3, 178, DateTimeKind.Unspecified).AddTicks(2176), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 11, 16, 58, 6, 729, DateTimeKind.Unspecified).AddTicks(5191), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 13, 57, 37, 955, DateTimeKind.Unspecified).AddTicks(9152), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 10, 19, 41, 34, 5, DateTimeKind.Unspecified).AddTicks(8657), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 12, 9, 46, 7, 167, DateTimeKind.Unspecified).AddTicks(5398), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 13, 2, 45, 10, 887, DateTimeKind.Unspecified).AddTicks(2723), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 9, 9, 7, 35, 50, 631, DateTimeKind.Unspecified).AddTicks(6853), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.AddForeignKey(
                name: "FK_AvailabilitySlots_Teams_TeamId",
                table: "AvailabilitySlots",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_AvailabilitySlots_Teams_TeamId",
                table: "AvailabilitySlots");

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
                name: "FK_AvailabilitySlots_Teams_TeamId",
                table: "AvailabilitySlots",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
