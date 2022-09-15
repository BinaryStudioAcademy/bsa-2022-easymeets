using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class AddForeignKeySyncCalendars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "SyncGoogleCalendar",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SyncGoogleCalendar",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SyncGoogleCalendar",
                table: "SyncGoogleCalendar",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 23, 10, 15, 10, 356, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 2L,
                column: "SelectedDate",
                value: new DateTime(2023, 1, 27, 5, 3, 38, 702, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 3L,
                column: "SelectedDate",
                value: new DateTime(2023, 3, 11, 5, 55, 35, 449, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 4L,
                column: "SelectedDate",
                value: new DateTime(2023, 2, 4, 16, 24, 0, 23, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 5L,
                column: "SelectedDate",
                value: new DateTime(2023, 7, 7, 0, 51, 6, 880, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 6L,
                column: "SelectedDate",
                value: new DateTime(2023, 1, 20, 8, 53, 30, 485, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 7L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 22, 15, 27, 45, 657, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 8L,
                column: "SelectedDate",
                value: new DateTime(2023, 8, 2, 15, 40, 23, 982, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 9L,
                column: "SelectedDate",
                value: new DateTime(2023, 5, 3, 10, 47, 43, 540, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 10L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 14, 1, 46, 47, 837, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 11, 5, 55, 35, 458, DateTimeKind.Unspecified).AddTicks(3748), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 2, 15, 40, 23, 991, DateTimeKind.Unspecified).AddTicks(7771), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 12, 9, 37, 8, 387, DateTimeKind.Unspecified).AddTicks(9651), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 21, 14, 9, 9, 913, DateTimeKind.Unspecified).AddTicks(510), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 13, 9, 51, 13, 464, DateTimeKind.Unspecified).AddTicks(3445), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 1, 6, 50, 44, 690, DateTimeKind.Unspecified).AddTicks(7326), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 12, 12, 34, 40, 740, DateTimeKind.Unspecified).AddTicks(6748), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 14, 2, 39, 13, 902, DateTimeKind.Unspecified).AddTicks(3408), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 14, 19, 38, 17, 622, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 11, 0, 28, 57, 366, DateTimeKind.Unspecified).AddTicks(4698), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SyncGoogleCalendar",
                table: "SyncGoogleCalendar");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SyncGoogleCalendar");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SyncGoogleCalendar");

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 22, 13, 22, 41, 15, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 2L,
                column: "SelectedDate",
                value: new DateTime(2023, 1, 26, 8, 11, 9, 361, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 3L,
                column: "SelectedDate",
                value: new DateTime(2023, 3, 10, 9, 3, 6, 108, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 4L,
                column: "SelectedDate",
                value: new DateTime(2023, 2, 3, 19, 31, 30, 682, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 5L,
                column: "SelectedDate",
                value: new DateTime(2023, 7, 6, 3, 58, 37, 539, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 6L,
                column: "SelectedDate",
                value: new DateTime(2023, 1, 19, 12, 1, 1, 145, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 7L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 21, 18, 35, 16, 316, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 8L,
                column: "SelectedDate",
                value: new DateTime(2023, 8, 1, 18, 47, 54, 641, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 9L,
                column: "SelectedDate",
                value: new DateTime(2023, 5, 2, 13, 55, 14, 199, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 10L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 13, 4, 54, 18, 496, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 10, 9, 3, 6, 116, DateTimeKind.Unspecified).AddTicks(1937), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 1, 18, 47, 54, 649, DateTimeKind.Unspecified).AddTicks(5975), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 11, 12, 44, 39, 45, DateTimeKind.Unspecified).AddTicks(7856), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 20, 17, 16, 40, 570, DateTimeKind.Unspecified).AddTicks(8681), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 12, 12, 58, 44, 122, DateTimeKind.Unspecified).AddTicks(1614), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 31, 9, 58, 15, 348, DateTimeKind.Unspecified).AddTicks(5493), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 11, 15, 42, 11, 398, DateTimeKind.Unspecified).AddTicks(4917), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 13, 5, 46, 44, 560, DateTimeKind.Unspecified).AddTicks(1576), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 13, 22, 45, 48, 279, DateTimeKind.Unspecified).AddTicks(8859), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 10, 3, 36, 28, 24, DateTimeKind.Unspecified).AddTicks(2906), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
