using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class ChangeTimeZonetoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TimeZone",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.DropColumn(
                name:"TimeZone",
                table:   "Teams");

            migrationBuilder.AddColumn<int>(
                name: "TimeZone",
                table: "Teams",
                defaultValue: 0,
                nullable: false);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 13, 10, 10, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 26, 8, 2, 4, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 7, 25, 10, 9, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 7, 4, 1, 5, 9, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 26, 2, 4, 3, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 3, 11, 8, 4, 3, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 7, 27, 4, 1, 6, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 8, 25, 1, 1, 9, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 7, 29, 8, 5, 13, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 19, 5, 4, 9, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 10, 25, 3, 34, 5, 290, DateTimeKind.Unspecified).AddTicks(972), 15, "https://caroline.name", 2, "animi", 44, 4L, 0, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Quia delectus facere non.\nHarum facilis assumenda accusamus qui sed et repellat vero dolores.\nLibero et qui facilis sed nobis ut.\nQuaerat iure perferendis placeat aliquam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 7, 22, 23, 58, 11, 273, DateTimeKind.Unspecified).AddTicks(6525), 17, "http://antonia.org", 1, "illo", 22, 7L, 0, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Ut voluptatibus dolore necessitatibus dolores soluta nihil. Et omnis nobis rem qui accusamus rerum aut a vero. Voluptatum quos voluptatem tenetur officiis non sint sit quia." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2019, 8, 10, 15, 10, 12, 718, DateTimeKind.Unspecified).AddTicks(4011), 17, "http://lindsey.org", "officia", 33, 5L, 0, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Veritatis sed saepe." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 10, 11, 18, 43, 57, 540, DateTimeKind.Unspecified).AddTicks(532), 30, "https://madalyn.org", "esse", 48, 4L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Architecto suscipit ratione voluptatem aut ut iusto aut voluptates.\nSit ea et non omnis consectetur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 7, 6, 20, 0, 0, 590, DateTimeKind.Unspecified).AddTicks(2067), 28, "http://jeff.com", "voluptates", 30, 4L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Laborum necessitatibus molestiae voluptate libero." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 6, 5, 17, 56, 55, 88, DateTimeKind.Unspecified).AddTicks(4080), 23, "https://cielo.biz", "eligendi", 50, 4L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Dolorem provident aut rerum non.\nRatione explicabo doloribus omnis autem deleniti.\nQuo iste deleniti omnis minus voluptatem eaque.\nMinus non labore aut et ea.\nCorporis molestiae facilis et ut ut rerum dolorem aut provident.\nEaque omnis quos dolore aliquid magnam culpa." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 6, 19, 10, 43, 21, 298, DateTimeKind.Unspecified).AddTicks(8672), 17, "https://jermaine.biz", "numquam", 31, 7L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "exercitationem" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 1, 22, 6, 42, 43, 754, DateTimeKind.Unspecified).AddTicks(6794), "http://petra.net", 0, "et", 53, 0, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Minima consequatur est eos." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 1, 2, 15, 49, 41, 765, DateTimeKind.Unspecified).AddTicks(3875), 15, "https://ronny.name", 2, "error", 31, 10L, 1, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Non aut et et. Architecto molestiae ut dolor veritatis velit. Eos qui hic omnis velit velit consequatur suscipit totam quo. Omnis facilis sunt et iusto omnis deserunt. Repudiandae qui ipsam facere est vero aspernatur amet." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 2, 7, 11, 54, 54, 533, DateTimeKind.Unspecified).AddTicks(601), "https://antoinette.biz", 1, "ab", 38, 2L, 0, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Corporis laboriosam maiores. Voluptatem necessitatibus vel atque eum quia voluptatem soluta iusto. Aut perspiciatis dolores dignissimos voluptates provident. Quia ea corporis dignissimos." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2021, 3, 31, 19, 51, 14, 149, DateTimeKind.Unspecified).AddTicks(2398), 8L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2020, 1, 6, 4, 22, 54, 746, DateTimeKind.Unspecified).AddTicks(9275), 4L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2021, 6, 15, 20, 41, 27, 659, DateTimeKind.Unspecified).AddTicks(2725), 6L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 9, 21, 1, 52, 34, 269, DateTimeKind.Unspecified).AddTicks(170), 9L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 7, 15, 13, 15, 42, 875, DateTimeKind.Unspecified).AddTicks(2959), 5L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2021, 4, 22, 2, 58, 9, 460, DateTimeKind.Unspecified).AddTicks(2220), 2L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2021, 6, 30, 16, 0, 22, 673, DateTimeKind.Unspecified).AddTicks(6553), 9L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2019, 8, 28, 22, 2, 22, 90, DateTimeKind.Unspecified).AddTicks(2472), 6L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 12, 20, 7, 37, 42, 161, DateTimeKind.Unspecified).AddTicks(4263), 10L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2021, 6, 2, 11, 31, 7, 389, DateTimeKind.Unspecified).AddTicks(8093), 5L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 7L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4148), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(3918), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4506), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4488), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4553), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4542), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4591), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4577), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4652), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4626), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4728), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4716), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4769), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4758), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4805), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4793), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4842), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4830), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4898), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4878), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Henrietta18@hotmail.com", new DateTimeOffset(new DateTime(2022, 10, 18, 5, 37, 13, 517, DateTimeKind.Unspecified).AddTicks(876), new TimeSpan(0, 3, 0, 0, 0)), "Henrietta Lindgren" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Jimmy56@hotmail.com", new DateTimeOffset(new DateTime(2023, 4, 30, 14, 59, 48, 207, DateTimeKind.Unspecified).AddTicks(9891), new TimeSpan(0, 3, 0, 0, 0)), "Jimmy Jerde" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Lila_Heathcote62@gmail.com", new DateTimeOffset(new DateTime(2023, 4, 21, 18, 55, 19, 681, DateTimeKind.Unspecified).AddTicks(2057), new TimeSpan(0, 3, 0, 0, 0)), "Lila Heathcote" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Fannie34@hotmail.com", new DateTimeOffset(new DateTime(2023, 7, 19, 8, 9, 15, 419, DateTimeKind.Unspecified).AddTicks(8089), new TimeSpan(0, 3, 0, 0, 0)), "Fannie Kozey" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Carole_Homenick75@gmail.com", new DateTimeOffset(new DateTime(2022, 11, 7, 11, 10, 48, 638, DateTimeKind.Unspecified).AddTicks(8373), new TimeSpan(0, 2, 0, 0, 0)), "Carole Homenick" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Josephine11@gmail.com", new DateTimeOffset(new DateTime(2023, 3, 17, 11, 55, 40, 14, DateTimeKind.Unspecified).AddTicks(6358), new TimeSpan(0, 2, 0, 0, 0)), "Josephine Spencer" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Eduardo_Feest@hotmail.com", new DateTimeOffset(new DateTime(2022, 10, 4, 23, 47, 33, 491, DateTimeKind.Unspecified).AddTicks(7329), new TimeSpan(0, 3, 0, 0, 0)), "Eduardo Feest" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Kathryn12@hotmail.com", new DateTimeOffset(new DateTime(2023, 5, 9, 7, 42, 3, 689, DateTimeKind.Unspecified).AddTicks(521), new TimeSpan(0, 3, 0, 0, 0)), "Kathryn Will" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Jon1@gmail.com", new DateTimeOffset(new DateTime(2023, 5, 19, 23, 25, 31, 980, DateTimeKind.Unspecified).AddTicks(9724), new TimeSpan(0, 3, 0, 0, 0)), "Jon Johnson" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Lora_Miller86@hotmail.com", new DateTimeOffset(new DateTime(2023, 4, 25, 12, 35, 45, 170, DateTimeKind.Unspecified).AddTicks(6065), new TimeSpan(0, 3, 0, 0, 0)), "Lora Miller" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 27, 1, 10, 3, 194, DateTimeKind.Unspecified).AddTicks(6623), 8L, "Enim voluptate illo numquam officia molestiae ut.", 50, "rem", new DateTimeOffset(new DateTime(2022, 8, 18, 13, 52, 42, 457, DateTimeKind.Unspecified).AddTicks(9679), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 3, 20, 12, 36, 58, 733, DateTimeKind.Unspecified).AddTicks(6517), 6L, "Non eligendi distinctio occaecati sed illum vel ei", 28, "deserunt", new DateTimeOffset(new DateTime(2022, 11, 28, 18, 37, 35, 235, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 2, 0, 0, 0)), 9L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 9, 9, 8, 3, 23, 135, DateTimeKind.Unspecified).AddTicks(964), "Quibusdam nostrum officia doloribus inventore.", 16, 0, "ut", new DateTimeOffset(new DateTime(2023, 7, 29, 11, 34, 36, 201, DateTimeKind.Unspecified).AddTicks(9616), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 21, 0, 53, 24, 640, DateTimeKind.Unspecified).AddTicks(7709), 5L, "Reprehenderit commodi iure laborum similique. Adip", 13, 1, "dolorem", new DateTimeOffset(new DateTime(2022, 11, 3, 7, 31, 22, 983, DateTimeKind.Unspecified).AddTicks(5282), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 10, 8, 20, 36, 29, 361, DateTimeKind.Unspecified).AddTicks(9716), 5L, "Est qui officia cupiditate nihil ut nam aperiam do", 49, 2, "corrupti", new DateTimeOffset(new DateTime(2022, 8, 19, 4, 48, 34, 628, DateTimeKind.Unspecified).AddTicks(6571), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 6, 4, 50, 6, 354, DateTimeKind.Unspecified).AddTicks(8662), 3L, "Aliquid soluta laborum voluptatem velit autem et v", 56, 0, "sint", new DateTimeOffset(new DateTime(2023, 2, 13, 9, 25, 32, 223, DateTimeKind.Unspecified).AddTicks(5637), new TimeSpan(0, 2, 0, 0, 0)), 3L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 12, 19, 8, 15, 50, 976, DateTimeKind.Unspecified).AddTicks(3511), 4L, "Aut eum nisi ut inventore voluptates.", 17, "sit", new DateTimeOffset(new DateTime(2023, 6, 25, 18, 55, 8, 316, DateTimeKind.Unspecified).AddTicks(9309), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 11, 8, 17, 58, 11, 532, DateTimeKind.Unspecified).AddTicks(458), 6L, "Quaerat itaque nobis optio maxime qui.", 1, "exercitationem", new DateTimeOffset(new DateTime(2023, 3, 30, 6, 20, 48, 114, DateTimeKind.Unspecified).AddTicks(4715), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 7, 3, 9, 49, 26, 115, DateTimeKind.Unspecified).AddTicks(7176), 8L, "Sint beatae ut incidunt exercitationem nihil et.\nM", 56, "tenetur", new DateTimeOffset(new DateTime(2022, 11, 23, 10, 50, 14, 41, DateTimeKind.Unspecified).AddTicks(5250), new TimeSpan(0, 2, 0, 0, 0)), 3L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 4, 18, 16, 3, 38, 99, DateTimeKind.Unspecified).AddTicks(7311), 2L, "Doloremque blanditiis illum est iste incidunt volu", 54, "corporis", new DateTimeOffset(new DateTime(2023, 5, 25, 2, 39, 35, 753, DateTimeKind.Unspecified).AddTicks(3874), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "nostrumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Corporis voluptatem cumque rem ut aut omnis. Debitis qui architecto occaecati rerum et. Doloribus at suscipit. Similique non illo aliquid natus eum molestias." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Debitis mollitia reprehenderit exercitationem voluptate sint qui.\nQuas aut enim architecto quo qui est et recusandae.\nVoluptas blanditiis ipsa quae exercitationem voluptates facilis voluptatem.\nVitae voluptas aliquid perferendis autem est nostrum maiores reiciendis." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Vitae impedit id possimus placeat corporis minus vero. Similique amet aliquam labore ducimus labore minima et. Possimus libero voluptates. Illo et ea delectus nam. Quam molestias debitis illo enim dignissimos enim." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Sunt voluptatem eveniet quia rerum maxime repellat enim sit et. Occaecati consequuntur voluptas doloremque dignissimos non libero corrupti nostrum. Ut consequatur perspiciatis reiciendis exercitationem aspernatur. Quo qui ea tempora." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "quisAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Velit quidem temporibus. Porro expedita consectetur est itaque voluptatibus numquam porro. Ipsam est harum ut quaerat culpa consequatur qui nam excepturi. Neque quis voluptate." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Animi nesciunt laboriosam.AAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Text",
                value: "Amet deleniti corrupti alias corrupti dicta aut corporis sint.\nQuisquam et quibusdam quia dolorem eos velit.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "providentAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Priority",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Priority",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Priority",
                value: 9);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Priority",
                value: 9);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Priority",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Priority",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Priority",
                value: 9);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Priority",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Priority",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

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
                column: "Role",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Role",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Role",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Role",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "similique", "Kshlerin - Hickle", "https://seth.biz", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "ipsam", "Kohler - Halvorson", "http://barney.org", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Nisi ratione quis fugiat.", "Lindgren LLC", "https://rowan.net", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Rerum non provident ipsum dolor vero. Non at explicabo est doloribus tenetur doloremque magni necessitatibus dolor. Quia laudantium in necessitatibus ut incidunt voluptatibus molestiae eaque. Quo quod iure laboriosam assumenda sunt hic fuga iste ad. Doloribus consequatur temporibus aperiam impedit", "Jakubowski, Erdman and Herzog", "https://millie.com", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Perferendis autem est. Quasi dolorem rerum illo deleniti et. Quis rem molestias delectus. Similique nemo ut in.", "DuBuque, Shanahan and Luettgen", "http://adele.info", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Sed aut ab nostrum ut.", "Paucek and Sons", "http://shanie.name", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "omnis", "Cartwright - Bosco", "http://karine.org", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Et qui quam. Sed fuga distinctio id rerum. Nulla sit pariatur dolorem iste in dolor impedit similique. Sed et odit placeat voluptatibus necessitatibus esse.", "Rath, Schamberger and Prohaska", "http://adah.biz", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Dicta est voluptatem dolores non.\nDolore magnam nemo distinctio voluptatum aliquam qui molestiae hic.\nUt non minus aut id consectetur non omnis soluta.\nMagnam sint rerum est doloremque animi corporis saepe quasi.\nAutem delectus eveniet aliquam autem quae ipsam.", "Hermiston and Sons", "https://sandra.com", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quia quaerat et ut iste pariatur fugiat voluptatem accusamus doloremque.\nUllam quis similique rerum non.\nQui corrupti assumenda magnam ex id.\nRerum sapiente voluptatem qui quos maiores.\nDolores cumque expedita quisquam est sunt quod incidunt laborum a.", "Hickle - Predovic", "https://myrtis.name", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, "Joann.Waters91@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/156.jpg", "Joann Waters", "758-647-50", 1, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Jimmy.Strosin38@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1003.jpg", "Jimmy Strosin", "792-733-78", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Jane.Hand@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/969.jpg", "Jane Hand", "1-360-471-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Faith_Bergstrom@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/449.jpg", "Faith Bergstrom", "1-767-387-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { "Jerome_Schamberger@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/447.jpg", "Jerome Schamberger", "253-807-20", 1, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { 1, "Vincent_Gorczany90@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/840.jpg", "Vincent Gorczany", "832-797-95", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Genevieve0@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/348.jpg", "Genevieve Pfannerstill", "(406) 715-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Horace_Rempel@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/609.jpg", "Horace Rempel", "1-378-467-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Carrie27@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/506.jpg", "Carrie Rohan", "1-761-958-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Robert56@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/672.jpg", "Robert Witting", "804-371-92", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TimeZone",
                table: "Users",
                type: "int",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.DropColumn(
                name:"TimeZone",
                table:"Teams");

            migrationBuilder.AddColumn<string>(
                name: "TimeZone",
                table: "Teams");

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 17, 8, 15, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 23, 4, 1, 8, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 2, 10, 8, 14, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 3, 13, 7, 2, 11, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 5, 19, 4, 1, 6, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 4, 30, 5, 2, 8, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 8, 3, 1, 4, 13, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 6, 17, 5, 5, 3, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 6, 8, 4, 2, 2, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 7, 6, 2, 8, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 10, 33, 37, 632, DateTimeKind.Unspecified).AddTicks(3181), 19, "http://lesly.name", 1, "ut", 22, 5L, 1, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Enim aliquid cumque ea officia quod earum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 7, 15, 22, 9, 34, 135, DateTimeKind.Unspecified).AddTicks(7262), 28, "http://reese.com", 2, "temporibus", 28, 1L, 1, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Officiis omnis autem illum repellat iusto.\nUnde totam reiciendis in et.\nTemporibus vel ut numquam sit consequuntur molestiae." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 11, 30, 1, 16, 44, 428, DateTimeKind.Unspecified).AddTicks(7930), 29, "https://kamron.name", "tempore", 44, 10L, 1, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Magnam et voluptates perspiciatis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 11, 11, 12, 15, 5, 822, DateTimeKind.Unspecified).AddTicks(4565), 19, "http://kaleigh.info", "cumque", 50, 2L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Reprehenderit voluptatibus sequi id cupiditate. Est aut consequatur voluptates omnis sed itaque. Et qui sapiente consequuntur provident recusandae iste sint dolor non." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 3, 27, 21, 20, 54, 618, DateTimeKind.Unspecified).AddTicks(8806), 18, "https://charley.info", "ut", 40, 6L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "In animi et ipsum alias dolorem quisquam placeat esse." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 1, 21, 1, 2, 45, 618, DateTimeKind.Unspecified).AddTicks(1869), 28, "https://jalon.name", "error", 31, 5L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Et dolores qui rem consequatur est sapiente. Cupiditate porro eligendi perferendis consequatur. Aut commodi eligendi omnis repellat molestiae non." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 11, 18, 18, 32, 16, 33, DateTimeKind.Unspecified).AddTicks(4539), 16, "https://maiya.biz", "consequatur", 21, 5L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Et adipisci esse eos perspiciatis et minus voluptatem eveniet eaque. Id consequuntur sit beatae. Aperiam tenetur asperiores et in qui quis nisi voluptatum. In eveniet sed adipisci corporis dolores tempora laboriosam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 7, 18, 16, 49, 47, 788, DateTimeKind.Unspecified).AddTicks(4069), "https://cristal.com", 1, "vel", 54, 1, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Voluptatibus vero minus amet.\nEsse amet qui fugiat numquam.\nNemo atque deleniti.\nPlaceat voluptas eveniet." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2019, 11, 21, 17, 44, 39, 392, DateTimeKind.Unspecified).AddTicks(8171), 25, "https://vicente.info", 0, "dolorem", 53, 4L, 0, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "id" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 12, 3, 7, 5, 8, 608, DateTimeKind.Unspecified).AddTicks(5589), "https://andrew.name", 0, "nihil", 22, 5L, 1, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Odit ut porro corrupti optio est." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2019, 10, 14, 1, 52, 41, 862, DateTimeKind.Unspecified).AddTicks(5318), 2L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 11, 2, 11, 47, 7, 524, DateTimeKind.Unspecified).AddTicks(895), 6L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2019, 8, 5, 22, 15, 39, 940, DateTimeKind.Unspecified).AddTicks(7274), 4L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 2, 24, 14, 13, 53, 567, DateTimeKind.Unspecified).AddTicks(9834), 5L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 1, 17, 10, 14, 29, 620, DateTimeKind.Unspecified).AddTicks(1650), 6L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 5, 17, 8, 9, 46, 481, DateTimeKind.Unspecified).AddTicks(8859), 1L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 4, 8, 1, 58, 19, 233, DateTimeKind.Unspecified).AddTicks(6606), 2L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2021, 6, 29, 17, 34, 22, 312, DateTimeKind.Unspecified).AddTicks(2276), 8L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 6, 8, 3, 47, 14, 272, DateTimeKind.Unspecified).AddTicks(2834), 7L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 7, 10, 3, 20, 53, 662, DateTimeKind.Unspecified).AddTicks(8549), 6L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 1L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1269), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1152), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1407), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1400), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1423), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1418), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1438), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1433), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1453), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1448), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1468), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1463), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1482), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1477), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1497), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1492), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1512), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1507), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1527), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1522), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Thomas.Mayert@gmail.com", new DateTimeOffset(new DateTime(2022, 10, 2, 21, 41, 48, 730, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, 3, 0, 0, 0)), "Thomas Mayert" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Julia2@hotmail.com", new DateTimeOffset(new DateTime(2022, 9, 12, 19, 51, 32, 571, DateTimeKind.Unspecified).AddTicks(4496), new TimeSpan(0, 3, 0, 0, 0)), "Julia Schowalter" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Susan.DAmore@yahoo.com", new DateTimeOffset(new DateTime(2023, 1, 6, 5, 31, 4, 157, DateTimeKind.Unspecified).AddTicks(2529), new TimeSpan(0, 2, 0, 0, 0)), "Susan D'Amore" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Carolyn76@gmail.com", new DateTimeOffset(new DateTime(2023, 5, 3, 2, 17, 59, 777, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 3, 0, 0, 0)), "Carolyn Konopelski" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Loretta34@hotmail.com", new DateTimeOffset(new DateTime(2022, 11, 22, 18, 15, 48, 698, DateTimeKind.Unspecified).AddTicks(6090), new TimeSpan(0, 2, 0, 0, 0)), "Loretta Konopelski" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Misty67@gmail.com", new DateTimeOffset(new DateTime(2023, 2, 15, 3, 45, 44, 453, DateTimeKind.Unspecified).AddTicks(5544), new TimeSpan(0, 2, 0, 0, 0)), "Misty Lesch" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "George60@yahoo.com", new DateTimeOffset(new DateTime(2022, 10, 26, 0, 46, 34, 844, DateTimeKind.Unspecified).AddTicks(5371), new TimeSpan(0, 3, 0, 0, 0)), "George Bergstrom" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Alexander_Kassulke64@gmail.co", new DateTimeOffset(new DateTime(2023, 4, 15, 18, 31, 48, 191, DateTimeKind.Unspecified).AddTicks(2196), new TimeSpan(0, 3, 0, 0, 0)), "Alexander Kassulke" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Milton.Schuppe19@hotmail.com", new DateTimeOffset(new DateTime(2022, 11, 18, 13, 43, 10, 281, DateTimeKind.Unspecified).AddTicks(7839), new TimeSpan(0, 2, 0, 0, 0)), "Milton Schuppe" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Joanne29@hotmail.com", new DateTimeOffset(new DateTime(2022, 11, 4, 13, 35, 14, 761, DateTimeKind.Unspecified).AddTicks(6999), new TimeSpan(0, 2, 0, 0, 0)), "Joanne Walter" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 12, 7, 19, 52, 54, 651, DateTimeKind.Unspecified).AddTicks(9375), 3L, "Quod temporibus odio autem beatae voluptatem quisq", 40, "ab", new DateTimeOffset(new DateTime(2022, 12, 27, 0, 50, 27, 181, DateTimeKind.Unspecified).AddTicks(6641), new TimeSpan(0, 2, 0, 0, 0)), 3L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 29, 12, 2, 11, 435, DateTimeKind.Unspecified).AddTicks(927), 9L, "eveniet", 60, "placeat", new DateTimeOffset(new DateTime(2023, 7, 28, 16, 30, 44, 331, DateTimeKind.Unspecified).AddTicks(4276), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 3, 3, 41, 25, 723, DateTimeKind.Unspecified).AddTicks(2516), "corporis", 23, 1, "rerum", new DateTimeOffset(new DateTime(2023, 7, 29, 22, 37, 4, 220, DateTimeKind.Unspecified).AddTicks(178), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 9, 16, 40, 40, 146, DateTimeKind.Unspecified).AddTicks(445), 9L, "Atque reiciendis et voluptates expedita eaque illu", 42, 2, "et", new DateTimeOffset(new DateTime(2023, 6, 22, 0, 54, 48, 429, DateTimeKind.Unspecified).AddTicks(3094), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 9, 7, 8, 10, 894, DateTimeKind.Unspecified).AddTicks(5926), 1L, "Expedita nihil culpa officia in similique ipsam at", 12, 0, "dolore", new DateTimeOffset(new DateTime(2022, 10, 9, 3, 39, 27, 215, DateTimeKind.Unspecified).AddTicks(9007), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 4, 2, 17, 37, 637, DateTimeKind.Unspecified).AddTicks(5032), 5L, "Itaque totam ea earum.\nArchitecto qui earum nemo p", 54, 2, "voluptatem", new DateTimeOffset(new DateTime(2022, 9, 1, 12, 2, 27, 372, DateTimeKind.Unspecified).AddTicks(7517), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 12, 9, 18, 58, 48, 445, DateTimeKind.Unspecified).AddTicks(3549), 3L, "et", 59, "et", new DateTimeOffset(new DateTime(2023, 3, 6, 18, 16, 57, 709, DateTimeKind.Unspecified).AddTicks(215), new TimeSpan(0, 2, 0, 0, 0)), 9L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 1, 0, 49, 49, 323, DateTimeKind.Unspecified).AddTicks(4111), 8L, "Deleniti quo nobis et dignissimos cupiditate disti", 2, "et", new DateTimeOffset(new DateTime(2023, 2, 25, 13, 28, 48, 71, DateTimeKind.Unspecified).AddTicks(8981), new TimeSpan(0, 2, 0, 0, 0)), 2L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 12, 13, 10, 20, 26, 336, DateTimeKind.Unspecified).AddTicks(6472), 4L, "Occaecati iusto id adipisci consequatur possimus o", 29, "autem", new DateTimeOffset(new DateTime(2022, 9, 16, 0, 43, 32, 848, DateTimeKind.Unspecified).AddTicks(3971), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 7, 4, 18, 25, 17, 166, DateTimeKind.Unspecified).AddTicks(888), 7L, "Enim et vitae minus. Nemo natus nobis commodi. Dol", 16, "perferendis", new DateTimeOffset(new DateTime(2023, 7, 29, 9, 58, 36, 801, DateTimeKind.Unspecified).AddTicks(5983), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Quam ut ipsam laudantium ut occaecati. Atque consectetur est iusto sed eum. Reiciendis inventore corrupti eveniet eveniet ut ea doloremque ipsam sed. Ab ullam sed assumenda nisi. Culpa laborum eligendi est dicta expedita libero." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "abAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "rerumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Exercitationem sapiente porro.AAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "rationeAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Sint atque veritatis est doloribus quae.\nOdio quidem voluptatem dolor ea esse ullam et.\nSunt fuga excepturi in.\nTotam itaque perferendis similique id.\nNihil magni voluptas eos ea pariatur." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Temporibus voluptatem eligendi mollitia ut sint. Quibusdam porro itaque vel in. Et quia ut cumque inventore quia ut. In explicabo porro perspiciatis doloribus voluptas est quaerat rem. Atque repellendus commodi eum et animi non doloribus. Sapiente laboriosam pariatur." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Dolor fuga molestiae eaque odio ut iure adipisci quis et." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Text",
                value: "Velit fugiat sint sint.AAAAAAAAAAAAAAAAAAAAAAAAAAA");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Et qui aliquid asperiores. Quia optio sed itaque qui. In excepturi amet. Assumenda provident sit tempora numquam iure." });

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Priority",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Priority",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Priority",
                value: 3);

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
                value: 10);

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
                value: 10);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Priority",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Priority",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

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
                column: "Role",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Role",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Role",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Role",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quisquam repellat dolor velit harum nihil odit sapiente laborum. Quas quibusdam suscipit ut rerum velit. Ipsa maxime velit modi nam ullam. Corporis totam dolores. Sunt et quasi magni voluptatem deserunt. Voluptas voluptate animi omnis laboriosam ex itaque corrupti.", "McClure Inc", "http://roy.biz", "Asia/Kolk" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Illo sit quibusdam nostrum omnis.\nAnimi vero distinctio dolor eum libero aliquid.\nSed ipsa porro non aut corporis.", "Beier, Roob and Goldner", "https://marlon.com", "Pacific/N" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quia sint officia animi qui qui qui fugit velit.\nNisi fugit vero.\nVoluptatem recusandae fuga et qui mollitia aut laborum.\nRecusandae voluptatibus ipsum sit quia beatae qui maiores.\nItaque deserunt perferendis et.", "Parisian - Zieme", "http://duncan.net", "Atlantic/" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quasi itaque enim est. Harum illo nostrum ipsum. Autem est sint et aspernatur minima vel.", "Hahn Group", "http://neil.name", "Asia/Yere" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Hic dignissimos nulla illum tempore perspiciatis accusamus libero praesentium quisquam. Voluptatibus ad et minus laudantium qui minus debitis mollitia. Asperiores sed iste possimus.", "Sauer, Howe and Bailey", "http://dayton.info", "Asia/Taip" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Dolores aut animi autem repellendus.\nPlaceat quas eaque temporibus animi voluptates reiciendis doloribus.", "Murazik Inc", "https://brian.org", "Pacific/M" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Animi rem sed aut nemo pariatur nostrum modi et dolorem.\nCumque ex quaerat quia temporibus aut id ducimus.\nImpedit ut in.", "Yundt - Zemlak", "http://dallas.com", "Asia/Bang" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Qui dolor reprehenderit eum ullam cupiditate minus alias est. Nulla dolores iste. Fuga ut quibusdam natus iusto explicabo et.", "Lockman - Hudson", "http://verner.com", "Europe/Lo" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quidem nostrum sapiente dolor ad culpa est et libero. Est sapiente quasi sapiente quis. Ut maiores fugit aperiam alias et. Aliquid id recusandae nihil nemo tempora et est. Illum nemo rerum nostrum. Impedit non earum nostrum consequatur.", "O'Conner - Stanton", "https://alana.com", "Asia/Kolk" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "illo", "Bartoletti LLC", "https://easter.com", "Europe/Pr" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 0, "Hattie29@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/801.jpg", "Hattie Hane", "1-775-291-", 0, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "James38@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/282.jpg", "James Prohaska", "639.599.49", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Salvatore.Champlin40@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/706.jpg", "Salvatore Champlin", "561-981-13", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Toni25@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/433.jpg", "Toni Carroll", "714-216-42", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { "Lance_Ebert68@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/859.jpg", "Lance Ebert", "1-687-614-", 0, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { 0, "Clark_Moore@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/839.jpg", "Clark Moore", "741-251-70", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Rose90@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/337.jpg", "Rose Stracke", "797-876-66", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Henrietta85@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/197.jpg", "Henrietta Powlowski", "(447) 233-", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Carl77@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/188.jpg", "Carl Beahan", "853-403-53", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Alfred48@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/420.jpg", "Alfred Dietrich", "448-988-20", 5 });
        }
    }
}
