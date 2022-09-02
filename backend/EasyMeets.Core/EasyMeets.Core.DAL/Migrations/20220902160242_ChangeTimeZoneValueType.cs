using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class ChangeTimeZoneValueType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TimeZoneValue",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TimeZoneValue",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TimeZoneValue",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TimeZoneValue",
                table: "ExternalAttendees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 4, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1257), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 3, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1167), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 4, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1390), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 3, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1382), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 4, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1405), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 3, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1401), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 4, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1418), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 3, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1414), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 4, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1429), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 3, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1426), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 4, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1440), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 3, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1437), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 4, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1451), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 3, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1448), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 4, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1462), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 3, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1458), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 4, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1473), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 3, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1469), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 4, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1484), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 3, 19, 2, 41, 322, DateTimeKind.Unspecified).AddTicks(1480), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 8, 14, 3, 41, 102, DateTimeKind.Unspecified).AddTicks(5965), new TimeSpan(0, 2, 0, 0, 0)), "" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 1, 12, 12, 36, 137, DateTimeKind.Unspecified).AddTicks(7357), new TimeSpan(0, 2, 0, 0, 0)), "" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 24, 14, 41, 46, 956, DateTimeKind.Unspecified).AddTicks(4783), new TimeSpan(0, 3, 0, 0, 0)), "" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 17, 20, 36, 42, 907, DateTimeKind.Unspecified).AddTicks(1181), new TimeSpan(0, 3, 0, 0, 0)), "" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 9, 14, 8, 57, 588, DateTimeKind.Unspecified).AddTicks(3384), new TimeSpan(0, 2, 0, 0, 0)), "" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 4, 6, 26, 30, 232, DateTimeKind.Unspecified).AddTicks(2983), new TimeSpan(0, 2, 0, 0, 0)), "" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 12, 10, 43, 649, DateTimeKind.Unspecified).AddTicks(6070), new TimeSpan(0, 3, 0, 0, 0)), "" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 21, 8, 4, 26, 776, DateTimeKind.Unspecified).AddTicks(9927), new TimeSpan(0, 2, 0, 0, 0)), "" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 12, 2, 47, 35, 437, DateTimeKind.Unspecified).AddTicks(3354), new TimeSpan(0, 3, 0, 0, 0)), "" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 21, 12, 41, 11, 394, DateTimeKind.Unspecified).AddTicks(98), new TimeSpan(0, 3, 0, 0, 0)), "" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 27, 8, 50, 33, 375, DateTimeKind.Unspecified).AddTicks(9478), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 18, 35, 21, 909, DateTimeKind.Unspecified).AddTicks(3745), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 31, 12, 32, 6, 305, DateTimeKind.Unspecified).AddTicks(5652), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 9, 17, 4, 7, 830, DateTimeKind.Unspecified).AddTicks(6525), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 1, 12, 46, 11, 381, DateTimeKind.Unspecified).AddTicks(9469), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 20, 9, 45, 42, 608, DateTimeKind.Unspecified).AddTicks(3356), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 28, 15, 29, 38, 658, DateTimeKind.Unspecified).AddTicks(2784), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 2, 5, 34, 11, 819, DateTimeKind.Unspecified).AddTicks(9449), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 2, 22, 33, 15, 539, DateTimeKind.Unspecified).AddTicks(6698), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 30, 3, 23, 55, 284, DateTimeKind.Unspecified).AddTicks(750), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "TimeZoneValue", "WithTeamMembers" },
                values: new object[] { "", true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "TimeZoneValue", "WithTeamMembers" },
                values: new object[] { "", false });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                column: "TimeZoneValue",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                column: "TimeZoneValue",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TimeZoneValue",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TimeZoneValue",
                table: "Teams",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TimeZoneValue",
                table: "Schedules",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TimeZoneValue",
                table: "ExternalAttendees",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4001), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(3858), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4180), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4169), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4204), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4197), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4226), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4219), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4248), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4241), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4280), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4273), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4301), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4294), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4322), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4315), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4344), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4336), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4375), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 16, 41, 5, 737, DateTimeKind.Unspecified).AddTicks(4358), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 7, 11, 42, 5, 517, DateTimeKind.Unspecified).AddTicks(6229), new TimeSpan(0, 2, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 31, 9, 51, 0, 552, DateTimeKind.Unspecified).AddTicks(8044), new TimeSpan(0, 2, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 23, 12, 20, 11, 371, DateTimeKind.Unspecified).AddTicks(5260), new TimeSpan(0, 3, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 16, 18, 15, 7, 322, DateTimeKind.Unspecified).AddTicks(1626), new TimeSpan(0, 3, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 8, 11, 47, 22, 3, DateTimeKind.Unspecified).AddTicks(4038), new TimeSpan(0, 2, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 3, 4, 4, 54, 647, DateTimeKind.Unspecified).AddTicks(4013), new TimeSpan(0, 2, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 9, 49, 8, 64, DateTimeKind.Unspecified).AddTicks(7269), new TimeSpan(0, 3, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 20, 5, 42, 51, 192, DateTimeKind.Unspecified).AddTicks(1472), new TimeSpan(0, 2, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 0, 25, 59, 852, DateTimeKind.Unspecified).AddTicks(5252), new TimeSpan(0, 3, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EventTime", "TimeZoneValue" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 20, 10, 19, 35, 809, DateTimeKind.Unspecified).AddTicks(2326), new TimeSpan(0, 3, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 26, 6, 28, 57, 766, DateTimeKind.Unspecified).AddTicks(7133), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 16, 13, 46, 300, DateTimeKind.Unspecified).AddTicks(1426), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 30, 10, 10, 30, 696, DateTimeKind.Unspecified).AddTicks(3333), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 8, 14, 42, 32, 221, DateTimeKind.Unspecified).AddTicks(4179), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 30, 10, 24, 35, 772, DateTimeKind.Unspecified).AddTicks(7134), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 19, 7, 24, 6, 999, DateTimeKind.Unspecified).AddTicks(1033), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 27, 13, 8, 3, 49, DateTimeKind.Unspecified).AddTicks(475), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 1, 3, 12, 36, 210, DateTimeKind.Unspecified).AddTicks(7204), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 20, 11, 39, 930, DateTimeKind.Unspecified).AddTicks(4472), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 29, 1, 2, 19, 674, DateTimeKind.Unspecified).AddTicks(8542), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TimeZoneValue",
                value: -300);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2L,
                column: "TimeZoneValue",
                value: -660);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3L,
                column: "TimeZoneValue",
                value: 480);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4L,
                column: "TimeZoneValue",
                value: -420);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5L,
                column: "TimeZoneValue",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6L,
                column: "TimeZoneValue",
                value: -540);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7L,
                column: "TimeZoneValue",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "TimeZoneValue", "WithTeamMembers" },
                values: new object[] { 300, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9L,
                column: "TimeZoneValue",
                value: 300);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "TimeZoneValue", "WithTeamMembers" },
                values: new object[] { 240, true });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                column: "TimeZoneValue",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                column: "TimeZoneValue",
                value: 0);
        }
    }
}
