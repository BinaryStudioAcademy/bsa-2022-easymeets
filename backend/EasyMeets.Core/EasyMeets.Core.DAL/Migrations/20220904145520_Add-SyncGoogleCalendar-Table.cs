using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class AddSyncGoogleCalendarTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SyncGoogleCalendar",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 17, 55, 19, 566, DateTimeKind.Unspecified).AddTicks(9876), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 17, 55, 19, 566, DateTimeKind.Unspecified).AddTicks(9830), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 17, 55, 19, 566, DateTimeKind.Unspecified).AddTicks(9968), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 17, 55, 19, 566, DateTimeKind.Unspecified).AddTicks(9963), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 17, 55, 19, 566, DateTimeKind.Unspecified).AddTicks(9983), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 17, 55, 19, 566, DateTimeKind.Unspecified).AddTicks(9978), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 17, 55, 19, 566, DateTimeKind.Unspecified).AddTicks(9997), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 17, 55, 19, 566, DateTimeKind.Unspecified).AddTicks(9992), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 17, 55, 19, 567, DateTimeKind.Unspecified).AddTicks(11), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 17, 55, 19, 567, DateTimeKind.Unspecified).AddTicks(6), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 17, 55, 19, 567, DateTimeKind.Unspecified).AddTicks(25), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 17, 55, 19, 567, DateTimeKind.Unspecified).AddTicks(20), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 17, 55, 19, 567, DateTimeKind.Unspecified).AddTicks(38), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 17, 55, 19, 567, DateTimeKind.Unspecified).AddTicks(34), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 17, 55, 19, 567, DateTimeKind.Unspecified).AddTicks(52), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 17, 55, 19, 567, DateTimeKind.Unspecified).AddTicks(48), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 17, 55, 19, 567, DateTimeKind.Unspecified).AddTicks(66), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 17, 55, 19, 567, DateTimeKind.Unspecified).AddTicks(61), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 17, 55, 19, 567, DateTimeKind.Unspecified).AddTicks(80), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 17, 55, 19, 567, DateTimeKind.Unspecified).AddTicks(75), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 10, 12, 56, 19, 349, DateTimeKind.Unspecified).AddTicks(1147), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 3, 11, 5, 14, 384, DateTimeKind.Unspecified).AddTicks(2243), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 26, 13, 34, 25, 202, DateTimeKind.Unspecified).AddTicks(8978), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 19, 19, 29, 21, 153, DateTimeKind.Unspecified).AddTicks(4519), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 11, 13, 1, 35, 834, DateTimeKind.Unspecified).AddTicks(6430), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 6, 5, 19, 8, 478, DateTimeKind.Unspecified).AddTicks(5798), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 23, 11, 3, 21, 895, DateTimeKind.Unspecified).AddTicks(8704), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 23, 6, 57, 5, 23, DateTimeKind.Unspecified).AddTicks(2381), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 14, 1, 40, 13, 683, DateTimeKind.Unspecified).AddTicks(5713), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 23, 11, 33, 49, 640, DateTimeKind.Unspecified).AddTicks(2278), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 1, 7, 43, 11, 638, DateTimeKind.Unspecified).AddTicks(6769), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 23, 17, 28, 0, 172, DateTimeKind.Unspecified).AddTicks(822), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 2, 11, 24, 44, 568, DateTimeKind.Unspecified).AddTicks(2706), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 11, 15, 56, 46, 93, DateTimeKind.Unspecified).AddTicks(3558), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 3, 11, 38, 49, 644, DateTimeKind.Unspecified).AddTicks(6493), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 22, 8, 38, 20, 871, DateTimeKind.Unspecified).AddTicks(374), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 2, 14, 22, 16, 920, DateTimeKind.Unspecified).AddTicks(9796), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 4, 26, 50, 82, DateTimeKind.Unspecified).AddTicks(6457), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 4, 21, 25, 53, 802, DateTimeKind.Unspecified).AddTicks(3702), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 9, 1, 2, 16, 33, 546, DateTimeKind.Unspecified).AddTicks(7751), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SyncGoogleCalendar");

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3226), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3169), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3327), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3322), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3342), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3337), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3356), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3352), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3371), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3366), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3385), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3380), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3399), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3394), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3413), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3408), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3427), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3422), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3441), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 16, 29, 8, 533, DateTimeKind.Unspecified).AddTicks(3436), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 10, 11, 30, 8, 315, DateTimeKind.Unspecified).AddTicks(3097), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 3, 9, 39, 3, 350, DateTimeKind.Unspecified).AddTicks(4284), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 26, 12, 8, 14, 169, DateTimeKind.Unspecified).AddTicks(995), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 19, 18, 3, 10, 119, DateTimeKind.Unspecified).AddTicks(6538), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 11, 11, 35, 24, 800, DateTimeKind.Unspecified).AddTicks(8470), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 6, 3, 52, 57, 444, DateTimeKind.Unspecified).AddTicks(7839), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 23, 9, 37, 10, 862, DateTimeKind.Unspecified).AddTicks(722), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 23, 5, 30, 53, 989, DateTimeKind.Unspecified).AddTicks(4451), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 14, 0, 14, 2, 649, DateTimeKind.Unspecified).AddTicks(7760), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 23, 10, 7, 38, 606, DateTimeKind.Unspecified).AddTicks(4306), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 1, 6, 17, 0, 604, DateTimeKind.Unspecified).AddTicks(2652), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 23, 16, 1, 49, 137, DateTimeKind.Unspecified).AddTicks(6763), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 2, 9, 58, 33, 533, DateTimeKind.Unspecified).AddTicks(8663), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 11, 14, 30, 35, 58, DateTimeKind.Unspecified).AddTicks(9493), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 3, 10, 12, 38, 610, DateTimeKind.Unspecified).AddTicks(2437), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 22, 7, 12, 9, 836, DateTimeKind.Unspecified).AddTicks(6331), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 2, 12, 56, 5, 886, DateTimeKind.Unspecified).AddTicks(5756), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 3, 0, 39, 48, DateTimeKind.Unspecified).AddTicks(2444), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 4, 19, 59, 42, 767, DateTimeKind.Unspecified).AddTicks(9689), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 9, 1, 0, 50, 22, 512, DateTimeKind.Unspecified).AddTicks(3738), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
