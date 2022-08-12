using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class PerformUserProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TimeZone",
                table: "Users",
                type: "int",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Country",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DateFormat",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TimeFormat",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "StartDate" },
                values: new object[] { 1, 3, 3, 28, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 1, 4, 5, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 8, 1, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 3, 2, 7, 27, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 8, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "EndDate", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 1, 5, 2, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 8, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 5, 5, 29, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 13, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 3, 3, 9, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 2, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 3, 5, 17, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 3, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 3, 4, 3, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 11, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 3, 4, 5, 5, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 4, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 3, 4, 4, 19, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 10, 13, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 9, 18, 8, 15, 11, 715, DateTimeKind.Unspecified).AddTicks(9996), "Aut et alias temporibus.\nRecusandae amet hic voluptas cumque sed quod blanditiis ipsam ut.\nAut distinctio occaecati labore dolorum rerum tempora.", 26, "https://gunnar.net", 5L, "ab", 37, 10L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 10, 5, 19, 52, 42, 706, DateTimeKind.Unspecified).AddTicks(364), "Tempora dolores magni saepe laborum.", 17, "http://myrl.org", "nobis", 57, 8L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 9, 19, 23, 11, 390, DateTimeKind.Unspecified).AddTicks(1671), "Atque temporibus hic necessitatibus et. Sed doloribus molestiae dolor repellat incidunt illo voluptates dignissimos. Sed esse eos. Voluptatem aut voluptatem dolores recusandae architecto.", 17, "https://tad.name", 3L, "eligendi", 38, 5L, 1, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 24, 4, 41, 51, 273, DateTimeKind.Unspecified).AddTicks(543), "Hic harum omnis dignissimos.", 29, "http://shanny.biz", 4L, "facilis", 21, 2L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 7, 11, 0, 17, 31, 91, DateTimeKind.Unspecified).AddTicks(2720), "et", 16, "https://rodger.com", "cum", 29, 9L, 1, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 12, 14, 2, 51, 55, 548, DateTimeKind.Unspecified).AddTicks(1388), "Excepturi voluptas totam nobis debitis consequatur in.", 18, "https://susie.com", 5L, "quis", 49, 6L, 2, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 12, 11, 18, 50, 49, 725, DateTimeKind.Unspecified).AddTicks(9430), "Ratione quis iure beatae consequatur.", 25, "http://javonte.name", "id", 45, 10L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 19, 3, 34, 7, 188, DateTimeKind.Unspecified).AddTicks(448), "Modi dignissimos consequatur pariatur suscipit excepturi consequuntur nulla et. Necessitatibus sunt molestiae et impedit iure velit tenetur. Harum molestiae itaque voluptatem voluptatem hic nobis repudiandae. Quia quo sunt sunt consequatur consequatur ut veritatis.", 28, "http://mathew.net", 3L, "ab", 51, 8L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 19, 0, 896, DateTimeKind.Unspecified).AddTicks(7596), "Quo sapiente blanditiis accusamus qui tempora nihil. Aut et corrupti architecto ut sit deserunt corrupti. Tempore nemo qui rerum. Nihil corporis voluptates eius aut. Dicta incidunt optio voluptatem natus error perspiciatis aperiam ab nihil.", 16, "https://gunner.name", 4L, "et", 25, 1L, 1, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 12, 27, 23, 21, 29, 219, DateTimeKind.Unspecified).AddTicks(9342), "nemo", 27, "http://scot.info", 5L, "sapiente", 51, 4L, 2, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 9, 29, 16, 30, 36, 465, DateTimeKind.Unspecified).AddTicks(841), 6L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2020, 6, 8, 13, 18, 17, 380, DateTimeKind.Unspecified).AddTicks(3903), 5L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2019, 10, 2, 21, 38, 44, 727, DateTimeKind.Unspecified).AddTicks(1936), 4L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2020, 4, 21, 15, 33, 2, 210, DateTimeKind.Unspecified).AddTicks(8557), 7L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt" },
                values: new object[] { 10L, new DateTime(2021, 6, 7, 11, 50, 11, 915, DateTimeKind.Unspecified).AddTicks(3982), new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2019, 9, 5, 6, 29, 25, 979, DateTimeKind.Unspecified).AddTicks(4975), new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2020, 3, 27, 10, 53, 17, 224, DateTimeKind.Unspecified).AddTicks(777), 2L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2019, 11, 1, 20, 42, 4, 735, DateTimeKind.Unspecified).AddTicks(8268), 6L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 8, 12, 7, 26, 21, 94, DateTimeKind.Unspecified).AddTicks(9715), 6L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 2, 26, 16, 43, 12, 228, DateTimeKind.Unspecified).AddTicks(8010), 10L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 1L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(811), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(753), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(901), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(894), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(916), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(912), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(929), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(925), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(941), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(937), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(954), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(949), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(965), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(962), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(977), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(973), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(989), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(985), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(1000), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(997), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Flora_Watsica@yahoo.com", new DateTimeOffset(new DateTime(2023, 1, 28, 6, 51, 49, 998, DateTimeKind.Unspecified).AddTicks(530), new TimeSpan(0, 2, 0, 0, 0)), "Flora Watsica" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Mathew_Block28@gmail.com", new DateTimeOffset(new DateTime(2022, 11, 4, 0, 16, 18, 313, DateTimeKind.Unspecified).AddTicks(4138), new TimeSpan(0, 2, 0, 0, 0)), "Mathew Block" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Amanda_Yundt74@hotmail.com", new DateTimeOffset(new DateTime(2023, 4, 23, 21, 21, 42, 698, DateTimeKind.Unspecified).AddTicks(8279), new TimeSpan(0, 3, 0, 0, 0)), "Amanda Yundt" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Harold.Marks4@hotmail.com", new DateTimeOffset(new DateTime(2023, 8, 9, 21, 56, 50, 686, DateTimeKind.Unspecified).AddTicks(801), new TimeSpan(0, 3, 0, 0, 0)), "Harold Marks" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Maxine_Thompson7@hotmail.com", new DateTimeOffset(new DateTime(2023, 4, 26, 17, 31, 8, 897, DateTimeKind.Unspecified).AddTicks(5487), new TimeSpan(0, 3, 0, 0, 0)), "Maxine Thompson" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Diane_Wuckert84@gmail.com", new DateTimeOffset(new DateTime(2022, 11, 14, 10, 56, 13, 90, DateTimeKind.Unspecified).AddTicks(6822), new TimeSpan(0, 2, 0, 0, 0)), "Diane Wuckert" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Samuel.Hammes@hotmail.com", new DateTimeOffset(new DateTime(2022, 9, 21, 13, 33, 2, 909, DateTimeKind.Unspecified).AddTicks(2237), new TimeSpan(0, 3, 0, 0, 0)), "Samuel Hammes" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Pablo48@gmail.com", new DateTimeOffset(new DateTime(2022, 12, 4, 14, 54, 13, 433, DateTimeKind.Unspecified).AddTicks(5587), new TimeSpan(0, 2, 0, 0, 0)), "Pablo Gleason" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Wm.Legros60@yahoo.com", new DateTimeOffset(new DateTime(2023, 7, 6, 10, 28, 6, 53, DateTimeKind.Unspecified).AddTicks(942), new TimeSpan(0, 3, 0, 0, 0)), "Wm Legros" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Lynda99@gmail.com", new DateTimeOffset(new DateTime(2022, 9, 2, 1, 52, 49, 94, DateTimeKind.Unspecified).AddTicks(6124), new TimeSpan(0, 3, 0, 0, 0)), "Lynda Olson" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 9, 12, 53, 43, 928, DateTimeKind.Unspecified).AddTicks(7231), "Eos ut est recusandae voluptatem voluptatem delect", 17, 3L, "fuga", new DateTimeOffset(new DateTime(2023, 5, 18, 9, 55, 54, 85, DateTimeKind.Unspecified).AddTicks(6111), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 30, 6, 33, 28, 391, DateTimeKind.Unspecified).AddTicks(2441), 4L, "Sunt sunt molestiae expedita.", 52, 4L, "in", new DateTimeOffset(new DateTime(2023, 7, 17, 5, 34, 23, 712, DateTimeKind.Unspecified).AddTicks(3215), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 10, 12, 6, 39, 34, 399, DateTimeKind.Unspecified).AddTicks(39), 2L, "Minus fugiat perferendis asperiores qui et et inve", 36, 3L, "corporis", new DateTimeOffset(new DateTime(2022, 9, 9, 8, 55, 28, 154, DateTimeKind.Unspecified).AddTicks(7126), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 12, 29, 20, 53, 45, 456, DateTimeKind.Unspecified).AddTicks(6612), 7L, "Aperiam deleniti tenetur voluptas numquam accusant", 21, 5L, "amet", new DateTimeOffset(new DateTime(2023, 6, 30, 5, 51, 43, 77, DateTimeKind.Unspecified).AddTicks(5657), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 13, 8, 29, 56, 178, DateTimeKind.Unspecified).AddTicks(7858), 1L, "Possimus nemo amet. Nulla eaque expedita ea maxime", 49, "facere", new DateTimeOffset(new DateTime(2023, 1, 22, 1, 32, 42, 689, DateTimeKind.Unspecified).AddTicks(6810), new TimeSpan(0, 2, 0, 0, 0)), 10L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 11, 22, 23, 26, 43, 357, DateTimeKind.Unspecified).AddTicks(413), 2L, "Nostrum labore praesentium eaque nihil.\nMaiores qu", 44, 5L, "molestiae", new DateTimeOffset(new DateTime(2023, 7, 21, 0, 42, 30, 161, DateTimeKind.Unspecified).AddTicks(8515), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 11, 4, 20, 17, 48, 120, DateTimeKind.Unspecified).AddTicks(3348), 6L, "eos", 38, 1L, "perspiciatis", new DateTimeOffset(new DateTime(2023, 6, 10, 16, 43, 18, 78, DateTimeKind.Unspecified).AddTicks(2106), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 20, 16, 26, 49, 661, DateTimeKind.Unspecified).AddTicks(3068), 1L, "Enim debitis molestiae sit quos laudantium ut eos", 49, 3L, "voluptatem", new DateTimeOffset(new DateTime(2023, 5, 20, 9, 15, 11, 404, DateTimeKind.Unspecified).AddTicks(2360), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 30, 22, 18, 8, 62, DateTimeKind.Unspecified).AddTicks(4593), 9L, "accusamus", 54, 4L, "culpa", new DateTimeOffset(new DateTime(2023, 6, 12, 10, 48, 38, 989, DateTimeKind.Unspecified).AddTicks(9785), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 5, 13, 22, 36, 524, DateTimeKind.Unspecified).AddTicks(6653), "Sit eius cum cupiditate in. Recusandae ut velit ut", 16, 5L, "sunt", new DateTimeOffset(new DateTime(2023, 3, 2, 14, 0, 37, 344, DateTimeKind.Unspecified).AddTicks(7615), new TimeSpan(0, 2, 0, 0, 0)), 6L, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Excepturi ab et ipsa sit omnis quo aliquid nostrum deserunt. Quis repudiandae libero. Quos ea quae rem sed." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Quia commodi necessitatibus a mollitia quia eum.\nPerferendis sed ea corporis.\nSuscipit est eum in rem excepturi quia hic aut.\nAutem aliquam quidem neque." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Veritatis id ipsa esse aut harum. Maxime quia distinctio ducimus hic magnam dolore illo quod nemo. Neque omnis vero qui quo. Voluptas hic laboriosam. Non quo laudantium provident rerum voluptatem. Quia et odio ut quis corporis rerum aliquam a placeat." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Text",
                value: "Neque deserunt dolores error laudantium.\nQuia iusto commodi ad a provident repudiandae ut modi inventore.\nQui optio dolor ab ut.\nVoluptas ratione vero nulla nobis asperiores a.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Laborum impedit veniam dicta.\nMolestiae et quasi corporis iure impedit." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "eumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Ex quia ab et repudiandae. Iusto blanditiis reprehenderit assumenda provident temporibus et mollitia. Est qui laborum velit quaerat ducimus." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Aut temporibus quae.\nEst fugiat voluptatem earum ut voluptates error dicta voluptate minima.\nDistinctio voluptatem non dolores tempora illo qui eos voluptatem.\nMaiores accusantium saepe magni suscipit ipsa.\nQuasi fugit est ut est totam." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Totam ipsam quisquam atque eius. Dolore maiores minima dolorem qui. Sint recusandae dignissimos nesciunt. Qui quia iste. Qui et et voluptas numquam sint sit ad dolores voluptatibus." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Text",
                value: "Atque et minus. Iusto et possimus iusto qui. Eius numquam reiciendis reiciendis ipsum nesciunt.");

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Priority",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Priority",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Priority",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Priority",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Priority",
                value: 9);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Priority",
                value: 9);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Priority",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Priority",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Priority",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "eos", "Beatty - Feeney", "http://cecil.name", "America/C" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "rerum", "Oberbrunner, Orn and Beier", "https://ricardo.org", "Asia/Vlad" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "At minima delectus dolor rerum tenetur.\nQuae quae modi est cum ut.", "Mertz, Macejkovic and Schultz", "https://kiley.com", "Asia/Kolk" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "illum", "Conroy Group", "https://opal.name", "Asia/Maga" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Aut sit dolores.", "Stoltenberg, Zemlak and Friesen", "https://paige.name", "America/C" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "At vitae dolore aut sint beatae vel dolore. Dicta quae voluptatem dolore. Velit sunt autem.", "Hickle - Lehner", "http://kody.biz", "Pacific/H" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Asperiores aspernatur cupiditate necessitatibus beatae. Explicabo et consequatur molestiae. Fugiat et aperiam in eos. Qui quisquam eaque deserunt qui ut. Ipsam delectus architecto eum dolor. Ad eveniet temporibus officiis unde cum.", "Wehner - Osinski", "https://octavia.name", "Europe/Lo" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Aut aut sapiente in aut doloribus ut exercitationem ratione. Iure quisquam provident. Ut id aliquid et in. Sed impedit quos minima odit.", "Mayert Group", "http://keyon.info", "Europe/He" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "qui", "Harvey - Fisher", "https://moriah.org", "Asia/Vlad" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Ipsa ea non nesciunt accusantium qui.\nEt at accusamus voluptas magnam quibusdam nihil.\nCumque perferendis quae autem harum nesciunt et.\nFugit quos ex.\nIn ipsa omnis ea consectetur.\nQuis quaerat libero voluptas ipsam porro consequatur optio neque.", "Zboncak - Daniel", "http://sophia.biz", "Europe/Be" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Country", "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, 2, "Jaime2@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/542.jpg", 2, "Jaime Kiehn", "428.929.25", 2, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Country", "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, 2, "Arthur0@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1030.jpg", 2, "Arthur Thompson", "1-822-417-", 2, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Country", "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, 2, "Dwayne_Ankunding@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/247.jpg", 2, "Dwayne Ankunding", "(488) 447-", 2, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Country", "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, 2, "Robin.Marks9@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1148.jpg", 2, "Robin Marks", "(636) 314-", 2, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Country", "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, 2, "Lila_Beatty@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/998.jpg", 2, "Lila Beatty", "591.782.07", 2, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Country", "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, 2, "Sam.DAmore@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/957.jpg", 2, "Sam D'Amore", "490.464.46", 2, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Country", "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, 2, "Billie.West@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/539.jpg", 2, "Billie West", "486.967.80", 2, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Country", "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, 2, "Violet_Mosciski44@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/447.jpg", 2, "Violet Mosciski", "940-466-18", 2, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Country", "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, 2, "Matt49@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/49.jpg", 2, "Matt Funk", "1-309-236-", 2, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Country", "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, 2, "Melvin.Pagac86@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1219.jpg", 2, "Melvin Pagac", "(617) 278-", 2, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateFormat",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TimeFormat",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "TimeZone",
                table: "Users",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "StartDate" },
                values: new object[] { 2, 2, 5, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 3, 2, 26, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 9, 6, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 2, 1, 4, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 2, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "EndDate", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 3, 1, 20, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 10, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 4, 6, 11, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 2, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 2, 6, 8, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 10, 4, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 4, 7, 12, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 7, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 1, 1, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 9, 8, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 1, 3, 3, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 8, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 2, 3, 5, 30, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 11, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 26, 5, 27, 18, 157, DateTimeKind.Unspecified).AddTicks(5561), "Error illo debitis ad.", 24, "https://keanu.net", 2L, "quidem", 45, 5L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 9, 28, 1, 32, 23, 12, DateTimeKind.Unspecified).AddTicks(816), "Recusandae quo quis voluptatem porro sed aut non. Recusandae recusandae minus et qui ea asperiores laborum assumenda. Architecto eum quam cumque atque facilis sequi eveniet et.", 30, "http://leslie.name", "harum", 44, 4L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 11, 30, 1, 19, 20, 330, DateTimeKind.Unspecified).AddTicks(9269), "Et optio dolores eos. Provident nobis omnis porro ipsam. Atque deleniti officiis et consectetur consequuntur.", 24, "https://fredy.name", 2L, "beatae", 41, 10L, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 1, 22, 11, 4, 409, DateTimeKind.Unspecified).AddTicks(8771), "Rerum cupiditate eos eligendi sunt laboriosam consectetur non.\nQuas et omnis quia et autem consectetur dolore modi fugiat.\nNatus pariatur voluptatem corporis repellendus ut esse rem quo omnis.\nCorporis ea non officiis molestiae doloribus.", 26, "http://liam.name", 1L, "quis", 42, 1L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 2, 25, 2, 10, 57, 920, DateTimeKind.Unspecified).AddTicks(8269), "Similique est exercitationem maxime quidem dignissimos sed animi ex.", 18, "https://lewis.name", "nesciunt", 26, 1L, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 31, 17, 59, 39, 329, DateTimeKind.Unspecified).AddTicks(1926), "Non tempore rem impedit sint enim sed. Praesentium et quia blanditiis repellendus omnis iure vitae numquam eos. Ut voluptas maiores magnam cumque et consequatur eveniet. Doloribus sit blanditiis aspernatur perferendis ut consequatur.", 19, "https://kamron.org", 1L, "illum", 45, 4L, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 17, 7, 10, 24, 17, DateTimeKind.Unspecified).AddTicks(7483), "Nostrum et fugiat consequatur qui.", 21, "https://willis.name", "voluptatem", 49, 4L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 6, 21, 17, 2, 453, DateTimeKind.Unspecified).AddTicks(5646), "Sapiente nemo dolor natus voluptatem sed. Iusto sint omnis est. Dolor ut dolores.", 20, "http://dangelo.biz", 4L, "esse", 20, 9L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 3, 1, 39, 366, DateTimeKind.Unspecified).AddTicks(7434), "Rerum magni quisquam nemo nostrum alias. Eum tempora velit sed est quo hic et incidunt magnam. Et deleniti non tenetur aut voluptas qui quisquam.", 15, "http://nathanael.net", 1L, "consequatur", 26, 9L, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 24, 14, 14, 2, 827, DateTimeKind.Unspecified).AddTicks(8613), "Minus nemo aut vel minus corrupti est porro pariatur.\nAdipisci aut similique nesciunt optio necessitatibus magni sed mollitia suscipit.\nMolestiae ut aut nemo excepturi.\nMinus harum ex nostrum eum minima omnis est voluptas dolor.\nNeque officia perferendis.\nAccusamus cupiditate dolorem.", 19, "https://maurice.biz", 3L, "delectus", 23, 9L, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2020, 8, 23, 11, 46, 20, 777, DateTimeKind.Unspecified).AddTicks(5827), 8L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 1, 15, 0, 4, 3, 195, DateTimeKind.Unspecified).AddTicks(7388), 7L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 4, 27, 16, 33, 11, 97, DateTimeKind.Unspecified).AddTicks(4093), 6L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 12, 4, 5, 48, 35, 934, DateTimeKind.Unspecified).AddTicks(3481), 1L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt" },
                values: new object[] { 6L, new DateTime(2020, 12, 9, 20, 28, 38, 929, DateTimeKind.Unspecified).AddTicks(1135), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 7, 5, 4, 14, 22, 105, DateTimeKind.Unspecified).AddTicks(486), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2021, 3, 27, 21, 55, 40, 731, DateTimeKind.Unspecified).AddTicks(8064), 5L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 6, 28, 23, 11, 11, 146, DateTimeKind.Unspecified).AddTicks(5668), 5L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2020, 3, 13, 14, 26, 21, 980, DateTimeKind.Unspecified).AddTicks(4243), 10L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2021, 2, 13, 11, 44, 28, 980, DateTimeKind.Unspecified).AddTicks(850), 6L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7034), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(6927), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7239), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7226), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7254), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7279), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7273), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7298), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7292), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7372), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7311), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7419), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7413), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7438), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7432), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7456), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7450), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Valerie.Trantow@gmail.com", new DateTimeOffset(new DateTime(2022, 8, 21, 8, 14, 35, 544, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 3, 0, 0, 0)), "Valerie Trantow" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Amber2@gmail.com", new DateTimeOffset(new DateTime(2023, 4, 7, 9, 31, 32, 216, DateTimeKind.Unspecified).AddTicks(1755), new TimeSpan(0, 3, 0, 0, 0)), "Amber Senger" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Ian78@gmail.com", new DateTimeOffset(new DateTime(2022, 12, 30, 22, 46, 6, 995, DateTimeKind.Unspecified).AddTicks(9603), new TimeSpan(0, 2, 0, 0, 0)), "Ian Schuster" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Jason_Mills7@gmail.com", new DateTimeOffset(new DateTime(2022, 11, 8, 3, 28, 11, 516, DateTimeKind.Unspecified).AddTicks(6946), new TimeSpan(0, 2, 0, 0, 0)), "Jason Mills" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Vanessa_Goyette@hotmail.com", new DateTimeOffset(new DateTime(2023, 6, 26, 19, 35, 52, 558, DateTimeKind.Unspecified).AddTicks(3673), new TimeSpan(0, 3, 0, 0, 0)), "Vanessa Goyette" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Erica87@yahoo.com", new DateTimeOffset(new DateTime(2022, 12, 27, 8, 5, 13, 34, DateTimeKind.Unspecified).AddTicks(2966), new TimeSpan(0, 2, 0, 0, 0)), "Erica Marquardt" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Johnnie.Moen@hotmail.com", new DateTimeOffset(new DateTime(2022, 10, 15, 21, 48, 5, 802, DateTimeKind.Unspecified).AddTicks(3493), new TimeSpan(0, 3, 0, 0, 0)), "Johnnie Moen" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Enrique.Toy@gmail.com", new DateTimeOffset(new DateTime(2023, 2, 7, 20, 51, 0, 184, DateTimeKind.Unspecified).AddTicks(3198), new TimeSpan(0, 2, 0, 0, 0)), "Enrique Toy" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Wendy74@gmail.com", new DateTimeOffset(new DateTime(2023, 8, 8, 23, 49, 13, 375, DateTimeKind.Unspecified).AddTicks(8122), new TimeSpan(0, 3, 0, 0, 0)), "Wendy Lowe" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Chad.Bednar56@yahoo.com", new DateTimeOffset(new DateTime(2022, 10, 21, 16, 43, 57, 702, DateTimeKind.Unspecified).AddTicks(3057), new TimeSpan(0, 3, 0, 0, 0)), "Chad Bednar" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 12, 13, 19, 46, 11, 190, DateTimeKind.Unspecified).AddTicks(7247), "Odit reiciendis nisi possimus repudiandae inventor", 25, 2L, "ipsa", new DateTimeOffset(new DateTime(2022, 9, 22, 16, 31, 9, 6, DateTimeKind.Unspecified).AddTicks(1920), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 11, 13, 9, 35, 44, 572, DateTimeKind.Unspecified).AddTicks(3426), 8L, "Cum enim dolore. Alias aut ab ut enim ipsam ducimu", 44, 1L, "id", new DateTimeOffset(new DateTime(2023, 7, 18, 8, 51, 11, 39, DateTimeKind.Unspecified).AddTicks(5906), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 5, 18, 23, 19, 420, DateTimeKind.Unspecified).AddTicks(7301), 4L, "Fuga aliquid cupiditate nisi similique. Cupiditate", 50, 1L, "et", new DateTimeOffset(new DateTime(2022, 11, 4, 1, 55, 10, 764, DateTimeKind.Unspecified).AddTicks(2636), new TimeSpan(0, 2, 0, 0, 0)), 3L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 11, 22, 19, 5, 9, 840, DateTimeKind.Unspecified).AddTicks(6975), 3L, "Asperiores omnis dicta distinctio non ex est.", 18, 3L, "vel", new DateTimeOffset(new DateTime(2023, 4, 20, 20, 34, 39, 697, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 2, 8, 22, 8, 2, 324, DateTimeKind.Unspecified).AddTicks(6597), 3L, "Molestiae nostrum temporibus fugiat placeat libero", 13, "inventore", new DateTimeOffset(new DateTime(2023, 4, 11, 0, 42, 23, 833, DateTimeKind.Unspecified).AddTicks(1883), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 5, 18, 13, 10, 719, DateTimeKind.Unspecified).AddTicks(55), 1L, "Voluptatum molestias quia minima quisquam vero vel", 30, 3L, "animi", new DateTimeOffset(new DateTime(2022, 11, 13, 21, 28, 49, 587, DateTimeKind.Unspecified).AddTicks(2033), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 10, 9, 10, 14, 27, 974, DateTimeKind.Unspecified).AddTicks(7923), 4L, "consequatur", 19, 3L, "at", new DateTimeOffset(new DateTime(2023, 4, 7, 16, 13, 54, 47, DateTimeKind.Unspecified).AddTicks(3911), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 12, 23, 29, 12, 644, DateTimeKind.Unspecified).AddTicks(2012), 9L, "Eos quod amet sed in vero. Saepe dolorum natus sed", 21, 4L, "quo", new DateTimeOffset(new DateTime(2023, 4, 1, 2, 9, 59, 784, DateTimeKind.Unspecified).AddTicks(2721), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 12, 4, 11, 0, 561, DateTimeKind.Unspecified).AddTicks(1866), 3L, "nihil", 44, 2L, "omnis", new DateTimeOffset(new DateTime(2022, 12, 29, 14, 50, 29, 995, DateTimeKind.Unspecified).AddTicks(3372), new TimeSpan(0, 2, 0, 0, 0)), 5L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 3, 17, 11, 24, 18, 404, DateTimeKind.Unspecified).AddTicks(497), "Doloremque laudantium aspernatur et eligendi dolor", 55, 4L, "doloribus", new DateTimeOffset(new DateTime(2023, 5, 6, 9, 24, 4, 350, DateTimeKind.Unspecified).AddTicks(1932), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Et natus iste repellat velit ratione quis.AAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Eos labore sint autem maiores. Sunt rerum omnis cumque harum ab voluptas. Non ullam fugit expedita tenetur." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Ipsam pariatur labore eius tempore repellat unde.\nPariatur aspernatur eos voluptatem possimus.\nDolorem nisi sunt nulla." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Text",
                value: "ducimusAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Perferendis beatae quia officiis.AAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Tempora voluptatem praesentium nisi dicta quasi.\nNon aut accusantium corrupti praesentium alias nemo soluta aut et.\nMinima nulla vero maiores impedit est sunt voluptatum consequuntur.\nQuidem eaque et dolore.\nEum consectetur ipsum cumque voluptatem et deleniti labore sit iure." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Et veniam consequuntur atque.\nEos maxime harum est nihil exercitationem ducimus quia veniam quae.\nEum incidunt eius sint.\nSit perspiciatis iste nobis accusamus.\nVoluptas dolores consequatur aliquid quo soluta est omnis.\nLaudantium sapiente porro dolores placeat molestiae atque quibusdam rerum." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Quia iusto dolor ut.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Molestiae minus ullam nemo. Sint reprehenderit incidunt et natus in nihil sint dolore laboriosam. Amet dolor debitis maxime ipsam corporis aut." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Text",
                value: "Assumenda molestiae laudantium reprehenderit ea.AA");

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Priority",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Priority",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Priority",
                value: 10);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Priority",
                value: 9);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Priority",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Priority",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Priority",
                value: 10);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Priority",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Libero qui necessitatibus natus asperiores et incidunt ea optio sit.", "Mills - Nader", "http://jettie.org", "Europe/So" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Commodi voluptatum officiis repellat atque sunt. Omnis doloremque fuga provident ullam. Aspernatur qui magnam sit dolores aliquid quae dolore dicta. Corrupti alias maxime cupiditate aliquam tempora accusamus. Est et ex harum hic ipsam quia at ab maxime. Sint laborum repellat rem perspiciatis tempor", "Grady - Wilkinson", "https://jacquelyn.com", "Asia/Kual" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Nemo sapiente odio ipsa.\nIllum reprehenderit autem ab quam consectetur omnis.", "Klocko - Wintheiser", "https://leta.info", "Asia/Toky" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Voluptatibus exercitationem voluptas. Ut consequatur qui sequi sit adipisci. Iusto repellat alias ipsum esse deserunt quis. Voluptas voluptatem rerum doloribus libero nemo neque enim voluptatem. Iusto quo natus et.", "Lebsack, Krajcik and Cartwright", "https://sabrina.org", "Pacific/N" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Voluptatem laboriosam dolore.\nVeritatis ipsam nisi qui.", "Kessler, Rowe and Walker", "http://janessa.org", "Asia/Maga" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "dolore", "McDermott, Luettgen and Berge", "http://carter.biz", "Australia" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Mollitia est vitae.", "Zulauf Inc", "http://danny.biz", "America/J" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Vel non totam ipsa est enim ut.\nRerum maxime tempora repellat et corrupti.\nDicta possimus labore consequatur natus sunt.\nDicta sed omnis porro aspernatur.\nNam a quia aut illo corporis itaque cumque occaecati eius.", "Mertz Group", "http://ayla.biz", "Europe/Be" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "rerum", "Olson Inc", "https://henriette.info", "Atlantic/" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Iure aut neque voluptatem voluptas.", "Morar - Koepp", "https://otis.com", "Pacific/A" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Country", "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { null, "Doug58@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1109.jpg", "Doug Baumbach", "568-425-13", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Country", "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { null, "Noah2@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/597.jpg", "Noah Swift", "394-517-52", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Country", "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { null, "Rebecca.Robel@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1144.jpg", "Rebecca Robel", "(895) 358-", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Country", "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { null, "Albert.Swaniawski76@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/216.jpg", "Albert Swaniawski", "326-405-30", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Country", "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { null, "Gertrude92@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/499.jpg", "Gertrude Koch", "1-450-952-", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Country", "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { null, "Jacob_Boyer@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/608.jpg", "Jacob Boyer", "811-396-49", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Country", "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { null, "Kay_Hilll76@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1013.jpg", "Kay Hilll", "1-614-740-", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Country", "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { null, "Ruben38@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1025.jpg", "Ruben Monahan", "851.634.09", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Country", "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { null, "Carrie.Morar@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/606.jpg", "Carrie Morar", "1-412-529-", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Country", "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { null, "Devin75@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/16.jpg", "Devin Cremin", "1-358-591-", null });
        }
    }
}
