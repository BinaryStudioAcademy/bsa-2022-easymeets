using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class UseDateTimewithexclusiontimeranges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DayTimeRanges");

            migrationBuilder.DropTable(
                name: "ExclusionDates");

            migrationBuilder.CreateTable(
                name: "ExclusionTimeRanges",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleId = table.Column<long>(type: "bigint", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExclusionTimeRanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExclusionTimeRanges_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "ExclusionTimeRanges",
                columns: new[] { "Id", "End", "IsDeleted", "ScheduleId", "Start" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 10, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), false, 3L, new DateTime(2022, 10, 30, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2023, 2, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), false, 1L, new DateTime(2023, 2, 3, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2023, 3, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), false, 9L, new DateTime(2023, 3, 19, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new DateTime(2023, 2, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), false, 2L, new DateTime(2023, 2, 12, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, new DateTime(2023, 7, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), false, 6L, new DateTime(2023, 7, 15, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, new DateTime(2023, 1, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), false, 1L, new DateTime(2023, 1, 28, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, new DateTime(2022, 10, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), false, 6L, new DateTime(2022, 10, 30, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, new DateTime(2023, 8, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), false, 8L, new DateTime(2023, 8, 10, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9L, new DateTime(2023, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), false, 8L, new DateTime(2023, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10L, new DateTime(2022, 10, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), false, 7L, new DateTime(2022, 10, 21, 13, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 19, 7, 37, 26, 689, DateTimeKind.Unspecified).AddTicks(375), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 10, 17, 22, 15, 222, DateTimeKind.Unspecified).AddTicks(4751), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 20, 11, 18, 59, 618, DateTimeKind.Unspecified).AddTicks(6704), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 15, 51, 1, 143, DateTimeKind.Unspecified).AddTicks(7646), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 21, 11, 33, 4, 695, DateTimeKind.Unspecified).AddTicks(625), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 9, 8, 32, 35, 921, DateTimeKind.Unspecified).AddTicks(4545), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 20, 14, 16, 31, 971, DateTimeKind.Unspecified).AddTicks(4003), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 4, 21, 5, 133, DateTimeKind.Unspecified).AddTicks(700), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 22, 21, 20, 8, 852, DateTimeKind.Unspecified).AddTicks(7982), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 19, 2, 10, 48, 597, DateTimeKind.Unspecified).AddTicks(2066), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_ExclusionTimeRanges_ScheduleId",
                table: "ExclusionTimeRanges",
                column: "ScheduleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExclusionTimeRanges");

            migrationBuilder.CreateTable(
                name: "ExclusionDates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SelectedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    End = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Start = table.Column<TimeSpan>(type: "time", nullable: false)
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
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "ExclusionDates",
                columns: new[] { "Id", "IsDeleted", "ScheduleId", "SelectedDate" },
                values: new object[,]
                {
                    { 1L, false, 3L, new DateTime(2022, 10, 30, 7, 59, 46, 306, DateTimeKind.Local).AddTicks(3644) },
                    { 2L, false, 1L, new DateTime(2023, 2, 3, 2, 48, 14, 652, DateTimeKind.Local).AddTicks(904) },
                    { 3L, false, 9L, new DateTime(2023, 3, 18, 3, 40, 11, 399, DateTimeKind.Local).AddTicks(3806) },
                    { 4L, false, 2L, new DateTime(2023, 2, 11, 14, 8, 35, 973, DateTimeKind.Local).AddTicks(12) },
                    { 5L, false, 6L, new DateTime(2023, 7, 13, 22, 35, 42, 829, DateTimeKind.Local).AddTicks(9475) },
                    { 6L, false, 1L, new DateTime(2023, 1, 27, 6, 38, 6, 435, DateTimeKind.Local).AddTicks(8355) },
                    { 7L, false, 6L, new DateTime(2022, 10, 29, 13, 12, 21, 607, DateTimeKind.Local).AddTicks(2796) },
                    { 8L, false, 8L, new DateTime(2023, 8, 9, 13, 24, 59, 932, DateTimeKind.Local).AddTicks(7598) },
                    { 9L, false, 8L, new DateTime(2023, 5, 10, 8, 32, 19, 490, DateTimeKind.Local).AddTicks(1624) },
                    { 10L, false, 7L, new DateTime(2022, 10, 20, 23, 31, 23, 787, DateTimeKind.Local).AddTicks(7753) }
                });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 18, 3, 40, 11, 426, DateTimeKind.Unspecified).AddTicks(2342), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 9, 13, 24, 59, 959, DateTimeKind.Unspecified).AddTicks(6722), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 19, 7, 21, 44, 355, DateTimeKind.Unspecified).AddTicks(8652), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 28, 11, 53, 45, 880, DateTimeKind.Unspecified).AddTicks(9509), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 20, 7, 35, 49, 432, DateTimeKind.Unspecified).AddTicks(2473), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 8, 4, 35, 20, 658, DateTimeKind.Unspecified).AddTicks(6380), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 19, 10, 19, 16, 708, DateTimeKind.Unspecified).AddTicks(5830), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 21, 0, 23, 49, 870, DateTimeKind.Unspecified).AddTicks(2516), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 21, 17, 22, 53, 589, DateTimeKind.Unspecified).AddTicks(9787), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 17, 22, 13, 33, 334, DateTimeKind.Unspecified).AddTicks(3862), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

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
    }
}
