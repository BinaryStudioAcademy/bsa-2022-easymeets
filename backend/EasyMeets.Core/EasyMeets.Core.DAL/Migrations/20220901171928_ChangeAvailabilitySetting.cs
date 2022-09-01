using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class ChangeAvailabilitySetting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Frequency",
                table: "AvailabilitySlots",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "AdvancedSlotSettings",
                newName: "Frequency");

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Frequency", "StartDate" },
                values: new object[] { 22, new DateTimeOffset(new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Frequency", "StartDate" },
                values: new object[] { 20, new DateTimeOffset(new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Frequency", "StartDate" },
                values: new object[] { 25, new DateTimeOffset(new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Frequency", "StartDate" },
                values: new object[] { 29, new DateTimeOffset(new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Frequency", "StartDate" },
                values: new object[] { 23, new DateTimeOffset(new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Frequency", "StartDate" },
                values: new object[] { 16, new DateTimeOffset(new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Frequency", "StartDate" },
                values: new object[] { 26, new DateTimeOffset(new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Frequency", "StartDate" },
                values: new object[] { 23, new DateTimeOffset(new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Frequency", "StartDate" },
                values: new object[] { 27, new DateTimeOffset(new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Frequency", "StartDate" },
                values: new object[] { 23, new DateTimeOffset(new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Color", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Color", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Color", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Color", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Color", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5368), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5163), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5643), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5626), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5685), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5672), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5721), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5708), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5756), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5744), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5805), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5791), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5840), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5828), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5873), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5862), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5907), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5895), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 3, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5951), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 2, 20, 19, 25, 421, DateTimeKind.Unspecified).AddTicks(5929), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 7, 15, 20, 25, 200, DateTimeKind.Unspecified).AddTicks(9081), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 31, 13, 29, 20, 236, DateTimeKind.Unspecified).AddTicks(1263), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 23, 15, 58, 31, 54, DateTimeKind.Unspecified).AddTicks(9698), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 16, 21, 53, 27, 5, DateTimeKind.Unspecified).AddTicks(9663), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 8, 15, 25, 41, 687, DateTimeKind.Unspecified).AddTicks(3266), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 3, 7, 43, 14, 331, DateTimeKind.Unspecified).AddTicks(3657), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 20, 13, 27, 27, 748, DateTimeKind.Unspecified).AddTicks(7339), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 20, 9, 21, 10, 876, DateTimeKind.Unspecified).AddTicks(1839), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 11, 4, 4, 19, 536, DateTimeKind.Unspecified).AddTicks(6027), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 20, 13, 57, 55, 493, DateTimeKind.Unspecified).AddTicks(3646), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 26, 10, 7, 17, 436, DateTimeKind.Unspecified).AddTicks(1679), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 19, 52, 5, 969, DateTimeKind.Unspecified).AddTicks(6282), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 30, 13, 48, 50, 365, DateTimeKind.Unspecified).AddTicks(8245), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 8, 18, 20, 51, 890, DateTimeKind.Unspecified).AddTicks(9151), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 30, 14, 2, 55, 442, DateTimeKind.Unspecified).AddTicks(2163), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 19, 11, 2, 26, 668, DateTimeKind.Unspecified).AddTicks(6118), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 27, 16, 46, 22, 718, DateTimeKind.Unspecified).AddTicks(5687), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 1, 6, 50, 55, 880, DateTimeKind.Unspecified).AddTicks(2421), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 1, 23, 49, 59, 599, DateTimeKind.Unspecified).AddTicks(9735), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 29, 4, 40, 39, 344, DateTimeKind.Unspecified).AddTicks(3855), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Color",
                table: "AvailabilitySlots",
                newName: "Frequency");

            migrationBuilder.RenameColumn(
                name: "Frequency",
                table: "AdvancedSlotSettings",
                newName: "Color");

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Color", "StartDate" },
                values: new object[] { 4, new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "StartDate" },
                values: new object[] { 3, new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Color", "StartDate" },
                values: new object[] { 6, new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Color", "StartDate" },
                values: new object[] { 8, new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "StartDate" },
                values: new object[] { 5, new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "StartDate" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "StartDate" },
                values: new object[] { 6, new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Color", "StartDate" },
                values: new object[] { 5, new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Color", "StartDate" },
                values: new object[] { 7, new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "StartDate" },
                values: new object[] { 5, new DateTimeOffset(new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Frequency", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Frequency", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Frequency", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Frequency", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Frequency", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Frequency", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Frequency", "UpdatedAt" },
                values: new object[] { 30, new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Frequency", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Frequency", "UpdatedAt" },
                values: new object[] { 28, new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Frequency", "UpdatedAt" },
                values: new object[] { 29, new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

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
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 31, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(3788), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 30, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(3593), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 31, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4147), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 30, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4116), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 31, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4201), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 30, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4183), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 31, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4251), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 30, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4232), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 31, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4322), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 30, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4301), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 31, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4367), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 30, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4351), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 31, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4416), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 30, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4399), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 31, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4465), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 30, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4447), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 31, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4516), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 30, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4497), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 31, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4562), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 30, 13, 9, 47, 765, DateTimeKind.Unspecified).AddTicks(4545), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 4, 8, 10, 47, 544, DateTimeKind.Unspecified).AddTicks(9705), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 28, 6, 19, 42, 580, DateTimeKind.Unspecified).AddTicks(1886), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 20, 8, 48, 53, 398, DateTimeKind.Unspecified).AddTicks(9561), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 13, 14, 43, 49, 349, DateTimeKind.Unspecified).AddTicks(6638), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 5, 8, 16, 4, 30, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 31, 0, 33, 36, 674, DateTimeKind.Unspecified).AddTicks(9419), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 17, 6, 17, 50, 92, DateTimeKind.Unspecified).AddTicks(2828), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 17, 2, 11, 33, 219, DateTimeKind.Unspecified).AddTicks(7098), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 7, 20, 54, 41, 880, DateTimeKind.Unspecified).AddTicks(1901), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 17, 6, 48, 17, 837, DateTimeKind.Unspecified).AddTicks(548), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 23, 2, 57, 39, 759, DateTimeKind.Unspecified).AddTicks(4613), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 17, 12, 42, 28, 292, DateTimeKind.Unspecified).AddTicks(9286), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 27, 6, 39, 12, 689, DateTimeKind.Unspecified).AddTicks(1362), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 5, 11, 11, 14, 214, DateTimeKind.Unspecified).AddTicks(2277), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 27, 6, 53, 17, 765, DateTimeKind.Unspecified).AddTicks(5298), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 16, 3, 52, 48, 991, DateTimeKind.Unspecified).AddTicks(9254), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 24, 9, 36, 45, 41, DateTimeKind.Unspecified).AddTicks(8737), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 28, 23, 41, 18, 203, DateTimeKind.Unspecified).AddTicks(5458), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 29, 16, 40, 21, 923, DateTimeKind.Unspecified).AddTicks(2836), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 25, 21, 31, 1, 667, DateTimeKind.Unspecified).AddTicks(7264), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
