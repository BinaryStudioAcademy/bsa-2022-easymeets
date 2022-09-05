using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class Addexclusiondates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExclusionDates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleId = table.Column<long>(type: "bigint", nullable: false),
                    SelectedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExclusionDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExclusionDates_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DayTimeRanges",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExclusionDateId = table.Column<long>(type: "bigint", nullable: false),
                    Start = table.Column<TimeSpan>(type: "time", nullable: false),
                    End = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayTimeRanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DayTimeRanges_ExclusionDates_ExclusionDateId",
                        column: x => x.ExclusionDateId,
                        principalTable: "ExclusionDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "ExclusionDates",
                columns: new[] { "Id", "IsDeleted", "ScheduleId", "SelectedDate" },
                values: new object[,]
                {
                    { 1L, false, 3L, new DateTime(2022, 10, 14, 7, 32, 51, 547, DateTimeKind.Local).AddTicks(2488) },
                    { 2L, false, 1L, new DateTime(2023, 1, 18, 2, 21, 19, 892, DateTimeKind.Local).AddTicks(9796) },
                    { 3L, false, 9L, new DateTime(2023, 3, 2, 3, 13, 16, 640, DateTimeKind.Local).AddTicks(2704) },
                    { 4L, false, 2L, new DateTime(2023, 1, 26, 13, 41, 41, 213, DateTimeKind.Local).AddTicks(8912) },
                    { 5L, false, 6L, new DateTime(2023, 6, 27, 22, 8, 48, 70, DateTimeKind.Local).AddTicks(8375) },
                    { 6L, false, 1L, new DateTime(2023, 1, 11, 6, 11, 11, 676, DateTimeKind.Local).AddTicks(7255) },
                    { 7L, false, 6L, new DateTime(2022, 10, 13, 12, 45, 26, 848, DateTimeKind.Local).AddTicks(1696) },
                    { 8L, false, 8L, new DateTime(2023, 7, 24, 12, 58, 5, 173, DateTimeKind.Local).AddTicks(6500) },
                    { 9L, false, 8L, new DateTime(2023, 4, 24, 8, 5, 24, 731, DateTimeKind.Local).AddTicks(526) },
                    { 10L, false, 7L, new DateTime(2022, 10, 4, 23, 4, 29, 28, DateTimeKind.Local).AddTicks(6657) }
                });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 7, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7122), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 6, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(6995), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 7, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7378), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 6, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7364), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 7, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7408), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 6, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7399), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 7, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7431), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 6, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7424), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 7, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7453), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 6, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7446), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 7, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7475), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 6, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7467), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 7, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7496), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 6, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7489), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 7, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7518), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 6, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7510), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 7, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7539), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 6, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7532), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 7, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7560), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 6, 13, 25, 24, 600, DateTimeKind.Unspecified).AddTicks(7553), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 11, 8, 26, 24, 380, DateTimeKind.Unspecified).AddTicks(8622), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 4, 6, 35, 19, 416, DateTimeKind.Unspecified).AddTicks(641), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 27, 9, 4, 30, 234, DateTimeKind.Unspecified).AddTicks(7988), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 20, 14, 59, 26, 185, DateTimeKind.Unspecified).AddTicks(4365), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 12, 8, 31, 40, 866, DateTimeKind.Unspecified).AddTicks(7598), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 7, 0, 49, 13, 510, DateTimeKind.Unspecified).AddTicks(8159), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 24, 6, 33, 26, 928, DateTimeKind.Unspecified).AddTicks(1927), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 24, 2, 27, 10, 55, DateTimeKind.Unspecified).AddTicks(6774), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 14, 21, 10, 18, 716, DateTimeKind.Unspecified).AddTicks(683), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 24, 7, 3, 54, 672, DateTimeKind.Unspecified).AddTicks(7865), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 2, 3, 13, 16, 652, DateTimeKind.Unspecified).AddTicks(8833), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 12, 58, 5, 186, DateTimeKind.Unspecified).AddTicks(3285), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 3, 6, 54, 49, 582, DateTimeKind.Unspecified).AddTicks(5241), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 12, 11, 26, 51, 107, DateTimeKind.Unspecified).AddTicks(6111), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 4, 7, 8, 54, 658, DateTimeKind.Unspecified).AddTicks(9085), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 23, 4, 8, 25, 885, DateTimeKind.Unspecified).AddTicks(3002), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 3, 9, 52, 21, 935, DateTimeKind.Unspecified).AddTicks(2461), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 23, 56, 55, 96, DateTimeKind.Unspecified).AddTicks(9160), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 5, 16, 55, 58, 816, DateTimeKind.Unspecified).AddTicks(6441), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 1, 21, 46, 38, 561, DateTimeKind.Unspecified).AddTicks(536), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "DayTimeRanges",
                columns: new[] { "Id", "End", "ExclusionDateId", "IsDeleted", "Start" },
                values: new object[,]
                {
                    { 1L, new TimeSpan(0, 15, 0, 0, 0), 3L, false, new TimeSpan(0, 8, 0, 0, 0) },
                    { 2L, new TimeSpan(0, 16, 0, 0, 0), 4L, false, new TimeSpan(0, 12, 0, 0, 0) },
                    { 3L, new TimeSpan(0, 17, 0, 0, 0), 2L, false, new TimeSpan(0, 9, 0, 0, 0) },
                    { 4L, new TimeSpan(0, 16, 0, 0, 0), 9L, false, new TimeSpan(0, 8, 0, 0, 0) },
                    { 5L, new TimeSpan(0, 17, 0, 0, 0), 6L, false, new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DayTimeRanges_ExclusionDateId",
                table: "DayTimeRanges",
                column: "ExclusionDateId");

            migrationBuilder.CreateIndex(
                name: "IX_ExclusionDates_ScheduleId",
                table: "ExclusionDates",
                column: "ScheduleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DayTimeRanges");

            migrationBuilder.DropTable(
                name: "ExclusionDates");

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 18, 36, 17, 191, DateTimeKind.Unspecified).AddTicks(9964), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 18, 36, 17, 191, DateTimeKind.Unspecified).AddTicks(9840), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(205), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(195), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(232), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(224), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(258), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(249), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(283), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(275), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(308), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(300), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(333), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(325), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(629), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(598), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(706), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(699), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 6, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(725), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 5, 18, 36, 17, 192, DateTimeKind.Unspecified).AddTicks(719), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 10, 13, 37, 16, 973, DateTimeKind.Unspecified).AddTicks(4406), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 3, 11, 46, 12, 8, DateTimeKind.Unspecified).AddTicks(5611), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 26, 14, 15, 22, 827, DateTimeKind.Unspecified).AddTicks(2342), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 19, 20, 10, 18, 777, DateTimeKind.Unspecified).AddTicks(8003), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 11, 13, 42, 33, 458, DateTimeKind.Unspecified).AddTicks(9892), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 6, 6, 0, 6, 102, DateTimeKind.Unspecified).AddTicks(9277), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 23, 11, 44, 19, 520, DateTimeKind.Unspecified).AddTicks(2089), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 23, 7, 38, 2, 647, DateTimeKind.Unspecified).AddTicks(5849), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 14, 2, 21, 11, 307, DateTimeKind.Unspecified).AddTicks(9167), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 23, 12, 14, 47, 264, DateTimeKind.Unspecified).AddTicks(5757), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 1, 8, 24, 9, 262, DateTimeKind.Unspecified).AddTicks(1986), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 23, 18, 8, 57, 795, DateTimeKind.Unspecified).AddTicks(6054), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 2, 12, 5, 42, 191, DateTimeKind.Unspecified).AddTicks(7937), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 11, 16, 37, 43, 716, DateTimeKind.Unspecified).AddTicks(8764), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 3, 12, 19, 47, 268, DateTimeKind.Unspecified).AddTicks(1720), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 22, 9, 19, 18, 494, DateTimeKind.Unspecified).AddTicks(5600), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 2, 15, 3, 14, 544, DateTimeKind.Unspecified).AddTicks(5020), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 5, 7, 47, 706, DateTimeKind.Unspecified).AddTicks(1681), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 4, 22, 6, 51, 425, DateTimeKind.Unspecified).AddTicks(8923), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 1, 2, 57, 31, 170, DateTimeKind.Unspecified).AddTicks(2970), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
