using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class ScheduleDefinedExternally : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DefinedBy",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DefinedExternally",
                table: "Schedules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 16, 42, 57, 790, DateTimeKind.Unspecified).AddTicks(9493), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 16, 42, 57, 790, DateTimeKind.Unspecified).AddTicks(9327), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 16, 42, 57, 790, DateTimeKind.Unspecified).AddTicks(9765), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 16, 42, 57, 790, DateTimeKind.Unspecified).AddTicks(9749), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 16, 42, 57, 790, DateTimeKind.Unspecified).AddTicks(9798), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 16, 42, 57, 790, DateTimeKind.Unspecified).AddTicks(9788), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 16, 42, 57, 790, DateTimeKind.Unspecified).AddTicks(9831), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 16, 42, 57, 790, DateTimeKind.Unspecified).AddTicks(9820), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 16, 42, 57, 790, DateTimeKind.Unspecified).AddTicks(9890), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 16, 42, 57, 790, DateTimeKind.Unspecified).AddTicks(9879), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 16, 42, 57, 790, DateTimeKind.Unspecified).AddTicks(9923), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 16, 42, 57, 790, DateTimeKind.Unspecified).AddTicks(9912), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 16, 42, 57, 790, DateTimeKind.Unspecified).AddTicks(9954), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 16, 42, 57, 790, DateTimeKind.Unspecified).AddTicks(9944), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 16, 42, 57, 790, DateTimeKind.Unspecified).AddTicks(9985), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 16, 42, 57, 790, DateTimeKind.Unspecified).AddTicks(9976), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 16, 42, 57, 791, DateTimeKind.Unspecified).AddTicks(17), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 16, 42, 57, 791, DateTimeKind.Unspecified).AddTicks(7), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 16, 42, 57, 791, DateTimeKind.Unspecified).AddTicks(48), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 16, 42, 57, 791, DateTimeKind.Unspecified).AddTicks(38), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 5, 11, 43, 57, 570, DateTimeKind.Unspecified).AddTicks(4398), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 29, 9, 52, 52, 605, DateTimeKind.Unspecified).AddTicks(6840), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 12, 22, 3, 424, DateTimeKind.Unspecified).AddTicks(4234), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 14, 18, 16, 59, 375, DateTimeKind.Unspecified).AddTicks(323), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 6, 11, 49, 14, 56, DateTimeKind.Unspecified).AddTicks(2718), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 1, 4, 6, 46, 700, DateTimeKind.Unspecified).AddTicks(2614), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 18, 9, 51, 0, 117, DateTimeKind.Unspecified).AddTicks(5930), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 18, 5, 44, 43, 245, DateTimeKind.Unspecified).AddTicks(109), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 9, 0, 27, 51, 905, DateTimeKind.Unspecified).AddTicks(4059), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 18, 10, 21, 27, 862, DateTimeKind.Unspecified).AddTicks(1379), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 2, 24, 6, 30, 49, 788, DateTimeKind.Unspecified).AddTicks(3878), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 18, 16, 15, 38, 321, DateTimeKind.Unspecified).AddTicks(9446), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 28, 10, 12, 22, 718, DateTimeKind.Unspecified).AddTicks(1547), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 6, 14, 44, 24, 243, DateTimeKind.Unspecified).AddTicks(2517), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 10, 26, 27, 794, DateTimeKind.Unspecified).AddTicks(5751), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 17, 7, 25, 59, 20, DateTimeKind.Unspecified).AddTicks(9843), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 2, 25, 13, 9, 55, 70, DateTimeKind.Unspecified).AddTicks(9374), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 5, 30, 3, 14, 28, 232, DateTimeKind.Unspecified).AddTicks(6138), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 8, 30, 20, 13, 31, 952, DateTimeKind.Unspecified).AddTicks(3491), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 8, 27, 1, 4, 11, 696, DateTimeKind.Unspecified).AddTicks(7731), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefinedBy",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "DefinedExternally",
                table: "Schedules");

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5369), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5233), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5614), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5602), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5640), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5632), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5665), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5658), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5691), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5683), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5726), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5718), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5751), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5744), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5776), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5769), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5801), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5793), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5831), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 11, 51, 40, 491, DateTimeKind.Unspecified).AddTicks(5818), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 5, 6, 52, 40, 269, DateTimeKind.Unspecified).AddTicks(4452), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 29, 5, 1, 35, 304, DateTimeKind.Unspecified).AddTicks(6530), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 7, 30, 46, 123, DateTimeKind.Unspecified).AddTicks(3932), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 14, 13, 25, 42, 74, DateTimeKind.Unspecified).AddTicks(517), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 6, 6, 57, 56, 755, DateTimeKind.Unspecified).AddTicks(3153), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 31, 23, 15, 29, 399, DateTimeKind.Unspecified).AddTicks(3257), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 18, 4, 59, 42, 816, DateTimeKind.Unspecified).AddTicks(6750), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 18, 0, 53, 25, 944, DateTimeKind.Unspecified).AddTicks(1142), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 8, 19, 36, 34, 604, DateTimeKind.Unspecified).AddTicks(5206), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 18, 5, 30, 10, 561, DateTimeKind.Unspecified).AddTicks(2617), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 2, 24, 1, 39, 32, 510, DateTimeKind.Unspecified).AddTicks(4846), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 18, 11, 24, 21, 43, DateTimeKind.Unspecified).AddTicks(9151), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 28, 5, 21, 5, 440, DateTimeKind.Unspecified).AddTicks(1069), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 6, 9, 53, 6, 965, DateTimeKind.Unspecified).AddTicks(1918), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 28, 5, 35, 10, 516, DateTimeKind.Unspecified).AddTicks(4875), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 17, 2, 34, 41, 742, DateTimeKind.Unspecified).AddTicks(8778), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 2, 25, 8, 18, 37, 792, DateTimeKind.Unspecified).AddTicks(8221), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 5, 29, 22, 23, 10, 954, DateTimeKind.Unspecified).AddTicks(4904), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 8, 30, 15, 22, 14, 674, DateTimeKind.Unspecified).AddTicks(2173), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 8, 26, 20, 12, 54, 418, DateTimeKind.Unspecified).AddTicks(6242), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
