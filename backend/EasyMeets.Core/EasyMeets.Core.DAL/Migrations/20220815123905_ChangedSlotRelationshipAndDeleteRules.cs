using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class ChangedSlotRelationshipAndDeleteRules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailabilitySlots_AdvancedSlotSettings_AdvancedSlotSettingsId",
                table: "AvailabilitySlots");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_AvailabilitySlots_AvailabilitySlotId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_AvailabilitySlots_AdvancedSlotSettingsId",
                table: "AvailabilitySlots");

            migrationBuilder.DropColumn(
                name: "AdvancedSlotSettingsId",
                table: "AvailabilitySlots");

            migrationBuilder.AddColumn<long>(
                name: "AvailabilitySlotId",
                table: "AdvancedSlotSettings",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 1L, 2, 5, 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 1, 2L, 2, 5, 1, 7 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 3L, 18, 3, 5, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 4L, 3, 30, 4, 3, 5 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 5L, 1, 4, 5, 1, 10 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 6L, 8, 12, 10, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 2, 7L, 4, 3, 1, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 2, 8L, 17, 2, 5 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 9L, 18, 10, 4, 15 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 10L, 8, 8, 1, 3, 15 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 1, 5, 17, 36, 42, 315, DateTimeKind.Unspecified).AddTicks(6418), 26, "http://emma.org", 2L, "sed", 32, 5L, "magnam" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 7, 24, 13, 35, 34, 708, DateTimeKind.Unspecified).AddTicks(4214), 20, "https://gwen.org", 3L, "necessitatibus", 42, 3L, 0, "tempora" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 3, 10, 15, 30, 29, 419, DateTimeKind.Unspecified).AddTicks(4081), 22, "https://kristofer.name", 5L, "quis", 20, 4L, 1, "Et officiis labore." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 8, 16, 20, 53, 43, 342, DateTimeKind.Unspecified).AddTicks(8389), 30, "http://lukas.info", 1L, "consequuntur", 27, 5L, "Delectus libero maxime totam in reprehenderit.\nSint atque reprehenderit temporibus ut dignissimos.\nSed maiores perferendis doloribus." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2019, 8, 11, 10, 50, 3, 810, DateTimeKind.Unspecified).AddTicks(8315), 26, "https://priscilla.biz", 1L, "illum", 26, 1L, 0, "omnis" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2019, 11, 7, 14, 8, 28, 710, DateTimeKind.Unspecified).AddTicks(1590), 21, "https://chaim.biz", 5L, "dolores", 20, 8L, 1, "consequatur" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 7, 13, 16, 23, 16, 156, DateTimeKind.Unspecified).AddTicks(2075), 24, "https://darrion.name", 5L, "deserunt", 31, 8L, "Ullam eligendi saepe ipsam cumque corporis dolorem mollitia veniam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 9, 16, 8, 25, 19, 819, DateTimeKind.Unspecified).AddTicks(9835), 28, "http://tanya.org", 2L, "aut", 45, 7L, "Id commodi temporibus eum eum qui illo fugiat facilis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 6, 4, 16, 50, 6, 768, DateTimeKind.Unspecified).AddTicks(4144), 25, "https://aileen.biz", 2L, "impedit", 17, 9L, 0, "placeat" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 8, 11, 6, 20, 44, 615, DateTimeKind.Unspecified).AddTicks(5993), 16, "http://tara.net", 5L, "commodi", 52, 4L, "Ut quam minus dicta et. Quia error sit perspiciatis nisi maxime quasi. Necessitatibus in quae et dignissimos quam qui sit." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2020, 8, 30, 23, 32, 18, 112, DateTimeKind.Unspecified).AddTicks(5344), 10L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 3L, new DateTime(2020, 5, 12, 11, 13, 12, 249, DateTimeKind.Unspecified).AddTicks(7408), 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2019, 8, 4, 10, 42, 33, 836, DateTimeKind.Unspecified).AddTicks(7206), 8L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 3, 6, 12, 8, 46, 827, DateTimeKind.Unspecified).AddTicks(447), 3L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 3L, new DateTime(2020, 7, 14, 12, 44, 43, 18, DateTimeKind.Unspecified).AddTicks(5275), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 7, 17, 23, 51, 8, 447, DateTimeKind.Unspecified).AddTicks(7739), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2021, 1, 11, 21, 31, 54, 50, DateTimeKind.Unspecified).AddTicks(3456), 6L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 5, 13, 0, 49, 59, 289, DateTimeKind.Unspecified).AddTicks(2315), 8L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2019, 11, 11, 4, 42, 44, 354, DateTimeKind.Unspecified).AddTicks(338), 6L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 6, 18, 22, 20, 31, 414, DateTimeKind.Unspecified).AddTicks(5050), 9L, 5L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(367), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(566), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(550), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(589), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(582), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(608), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(602), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(627), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(621), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(646), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(640), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(665), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(658), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(682), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(676), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(805), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(793), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(831), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(824), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Conrad_Bartell@hotmail.com", new DateTimeOffset(new DateTime(2023, 5, 13, 23, 44, 0, 552, DateTimeKind.Unspecified).AddTicks(7019), new TimeSpan(0, 3, 0, 0, 0)), "Conrad Bartell" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Ronnie87@gmail.com", new DateTimeOffset(new DateTime(2022, 10, 19, 21, 2, 18, 135, DateTimeKind.Unspecified).AddTicks(7901), new TimeSpan(0, 3, 0, 0, 0)), "Ronnie Okuneva" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Carroll91@gmail.com", new DateTimeOffset(new DateTime(2022, 9, 9, 0, 47, 43, 492, DateTimeKind.Unspecified).AddTicks(2842), new TimeSpan(0, 3, 0, 0, 0)), "Carroll Hickle" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Brittany21@gmail.com", new DateTimeOffset(new DateTime(2023, 4, 21, 2, 41, 38, 634, DateTimeKind.Unspecified).AddTicks(4188), new TimeSpan(0, 3, 0, 0, 0)), "Brittany Roberts" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Shawn.Kuhn@gmail.com", new DateTimeOffset(new DateTime(2022, 9, 9, 12, 41, 57, 936, DateTimeKind.Unspecified).AddTicks(3310), new TimeSpan(0, 3, 0, 0, 0)), "Shawn Kuhn" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Rachael_Schmeler9@gmail.com", new DateTimeOffset(new DateTime(2023, 4, 6, 5, 45, 19, 77, DateTimeKind.Unspecified).AddTicks(1731), new TimeSpan(0, 3, 0, 0, 0)), "Rachael Schmeler" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Krystal29@gmail.com", new DateTimeOffset(new DateTime(2022, 9, 5, 4, 24, 47, 913, DateTimeKind.Unspecified).AddTicks(6687), new TimeSpan(0, 3, 0, 0, 0)), "Krystal Jakubowski" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Miriam_Luettgen37@yahoo.com", new DateTimeOffset(new DateTime(2023, 8, 8, 13, 23, 47, 696, DateTimeKind.Unspecified).AddTicks(2642), new TimeSpan(0, 3, 0, 0, 0)), "Miriam Luettgen" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Tommie63@yahoo.com", new DateTimeOffset(new DateTime(2023, 2, 10, 17, 26, 11, 277, DateTimeKind.Unspecified).AddTicks(6586), new TimeSpan(0, 2, 0, 0, 0)), "Tommie Bashirian" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Sean13@yahoo.com", new DateTimeOffset(new DateTime(2023, 7, 29, 3, 30, 55, 912, DateTimeKind.Unspecified).AddTicks(4882), new TimeSpan(0, 3, 0, 0, 0)), "Sean Schultz" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 15, 14, 30, 30, 499, DateTimeKind.Unspecified).AddTicks(8537), 4L, "Molestias et vitae omnis culpa.\nDebitis illo asper", 39, "voluptatum", new DateTimeOffset(new DateTime(2023, 6, 16, 10, 11, 35, 389, DateTimeKind.Unspecified).AddTicks(2009), new TimeSpan(0, 3, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 9, 18, 44, 34, 24, DateTimeKind.Unspecified).AddTicks(8514), 3L, "Enim odit ab ipsa dolorum voluptates veritatis.\nSi", 5L, "id", new DateTimeOffset(new DateTime(2023, 1, 8, 7, 26, 0, 661, DateTimeKind.Unspecified).AddTicks(1552), new TimeSpan(0, 2, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 8, 11, 47, 19, 85, DateTimeKind.Unspecified).AddTicks(8087), 8L, "omnis", 48, 5L, "magnam", new DateTimeOffset(new DateTime(2022, 10, 18, 16, 42, 51, 973, DateTimeKind.Unspecified).AddTicks(2341), new TimeSpan(0, 3, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 1, 1, 9, 56, 37, 772, DateTimeKind.Unspecified).AddTicks(5553), 10L, "Aut autem sed nam molestiae beatae quia laborum au", 39, 1L, "numquam", new DateTimeOffset(new DateTime(2023, 5, 21, 8, 45, 52, 99, DateTimeKind.Unspecified).AddTicks(1103), new TimeSpan(0, 3, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 1, 12, 53, 37, 622, DateTimeKind.Unspecified).AddTicks(5842), 1L, "maiores", 23, "quod", new DateTimeOffset(new DateTime(2023, 6, 7, 15, 55, 48, 650, DateTimeKind.Unspecified).AddTicks(5552), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 28, 10, 58, 17, 684, DateTimeKind.Unspecified).AddTicks(2102), 1L, "Quisquam minima cumque. Quas aut sequi molestiae l", 48, 3L, "nihil", new DateTimeOffset(new DateTime(2022, 8, 28, 13, 37, 38, 241, DateTimeKind.Unspecified).AddTicks(9144), new TimeSpan(0, 3, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2020, 4, 29, 12, 4, 14, 554, DateTimeKind.Unspecified).AddTicks(3272), 1L, "Excepturi laudantium quaerat.", 52, 2L, "ducimus", new DateTimeOffset(new DateTime(2022, 11, 14, 14, 25, 13, 684, DateTimeKind.Unspecified).AddTicks(2801), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 3, 11, 1, 4, 58, 216, DateTimeKind.Unspecified).AddTicks(4493), 9L, "Quos eum corrupti quidem eum maiores.", 28, "maiores", new DateTimeOffset(new DateTime(2023, 5, 24, 18, 2, 20, 336, DateTimeKind.Unspecified).AddTicks(4955), new TimeSpan(0, 3, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 10, 12, 20, 9, 10, 31, DateTimeKind.Unspecified).AddTicks(8481), 5L, "ut", 32, "ut", new DateTimeOffset(new DateTime(2023, 3, 5, 20, 30, 29, 426, DateTimeKind.Unspecified).AddTicks(7000), new TimeSpan(0, 2, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 16, 20, 47, 42, 445, DateTimeKind.Unspecified).AddTicks(5538), 7L, "Similique expedita incidunt et et.", 29, 4L, "natus", new DateTimeOffset(new DateTime(2023, 1, 3, 15, 34, 1, 570, DateTimeKind.Unspecified).AddTicks(2788), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Voluptatem distinctio qui molestiae voluptas alias numquam ut officia qui.\nAccusantium assumenda voluptatem." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Eius cumque ut hic explicabo a voluptates provident inventore.\nConsectetur et praesentium corrupti dignissimos.\nIn et voluptate." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Sint sit aut sapiente illum quaerat deleniti consequatur est.\nQuas vel consequatur natus quia error aliquam ipsa sunt totam.\nTenetur fugit maiores odit et tempore.\nQuo dicta sed sequi id." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "doloremAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AvailabilitySlotId",
                value: 10L);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Laudantium aut illum dolorem atque qui dolores voluptas voluptatem. Itaque odio id molestiae. Omnis enim tempora et laborum quia autem. Quia nihil id qui magni voluptatem nemo id aut optio." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "doloresAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Provident similique commodi adipisci enim error. Et autem a omnis. Laudantium quibusdam repellat sit ut sed est omnis culpa. Aut quos consectetur dolorum. Et vel et. Natus eaque sint et vero ut." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Reprehenderit omnis omnis dolor animi qui iure corporis." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Text",
                value: "Itaque odio eos dolor aut et voluptas tempora debitis sed.");

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
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Priority",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Priority",
                value: 6);

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
                value: 8);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Priority",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Priority",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
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
                keyValue: 5L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "ea", "Braun - Hamill", "https://kenyatta.name", "Africa/Ha" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "sint", "Kris - Mills", "https://adrienne.name", "America/N" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Odit corrupti quod fugit iste qui sed explicabo aperiam exercitationem.\nRerum molestias harum est odio sunt aut laboriosam magni et.\nDolores animi facere beatae est quod quis.", "Klocko - Hand", "http://hester.name", "Pacific/F" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "mollitia", "Russel, Mraz and Kunde", "http://rafaela.name", "America/S" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Tempora iusto omnis asperiores. Porro aspernatur ratione asperiores fugit magnam nesciunt non. Quae omnis ipsum odit cum rerum. Corrupti dolores incidunt quam et pariatur dolores. Sequi commodi culpa odit eveniet repudiandae. Voluptas non suscipit voluptas ex voluptate incidunt facilis.", "Turner - Boyer", "https://dane.org", "Europe/Lj" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Incidunt officiis mollitia neque.", "McLaughlin - Kuphal", "https://angel.biz", "Pacific/F" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Qui et quae.\nQuo consequatur vero voluptas nisi iusto quidem voluptates ut doloribus.\nFacilis odit sequi vitae laborum.\nVel qui et ut est sit ut.", "Kirlin - Mante", "https://bernadine.com", "Asia/Maga" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Qui dolor et in esse minima est eos quia molestiae.", "Pouros Group", "https://gaston.org", "Asia/Dhak" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Aut vitae ab.\nDebitis aut dolor aut.\nItaque possimus ut ea cupiditate sint necessitatibus numquam.\nPraesentium voluptatum et rem temporibus veritatis.\nAut alias perferendis occaecati excepturi voluptates quis tempore tenetur itaque.", "Boyer, Keebler and Medhurst", "http://marcelina.org", "Asia/Kuwa" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Qui sed accusantium ut minus aut et architecto.\nConsequatur veniam exercitationem est illum nam recusandae vel velit aliquam.", "Zieme and Sons", "http://chanel.org", "Asia/Ulaa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Maryann.Kreiger@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/419.jpg", "Maryann Kreiger", "350-597-88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Boyd_Jacobson@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/630.jpg", "Boyd Jacobson", "316-457-72", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Ashley.Braun4@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/50.jpg", "Ashley Braun", "213.756.72", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Bryant2@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/966.jpg", "Bryant Bartoletti", "843.280.01", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Neil44@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/796.jpg", "Neil Kertzmann", "716.422.59", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Karla_Hand71@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/669.jpg", "Karla Hand", "949-330-73", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Jamie.Funk@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/473.jpg", "Jamie Funk", "955.451.30", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Francisco_Oberbrunner@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/121.jpg", "Francisco Oberbrunner", "613.671.57", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Joel_Schimmel99@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/415.jpg", "Joel Schimmel", "539.901.47" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Hope42@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/75.jpg", "Hope Crooks", "1-672-449-" });

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedSlotSettings_AvailabilitySlotId",
                table: "AdvancedSlotSettings",
                column: "AvailabilitySlotId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedSlotSettings_AvailabilitySlots_AvailabilitySlotId",
                table: "AdvancedSlotSettings",
                column: "AvailabilitySlotId",
                principalTable: "AvailabilitySlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_AvailabilitySlots_AvailabilitySlotId",
                table: "Questions",
                column: "AvailabilitySlotId",
                principalTable: "AvailabilitySlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedSlotSettings_AvailabilitySlots_AvailabilitySlotId",
                table: "AdvancedSlotSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_AvailabilitySlots_AvailabilitySlotId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_AdvancedSlotSettings_AvailabilitySlotId",
                table: "AdvancedSlotSettings");

            migrationBuilder.DropColumn(
                name: "AvailabilitySlotId",
                table: "AdvancedSlotSettings");

            migrationBuilder.AddColumn<long>(
                name: "AdvancedSlotSettingsId",
                table: "AvailabilitySlots",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 6, 1, 5, 5, 7 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 3, 8, 20, 6, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 21, 7, 1, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 1, 10, 3, 5, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 8, 11, 7, 4, 12 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 6, 8, 3, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 3, 3, 7, 3, 15 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 3, 30, 8, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 27, 4, 5, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 6, 30, 4, 4, 1 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AdvancedSlotSettingsId", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1L, new DateTime(2020, 1, 21, 6, 28, 45, 681, DateTimeKind.Unspecified).AddTicks(4271), 25, "http://asia.com", 4L, "quam", 25, 7L, "Quas sed nihil repudiandae.\nArchitecto possimus beatae.\nConsequuntur et ipsum corrupti ipsum dolores.\nSit quam iure maiores corporis soluta.\nAmet veniam ratione voluptatem officiis repellendus alias quis aut." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AdvancedSlotSettingsId", "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2L, 5, new DateTime(2021, 5, 5, 19, 3, 31, 65, DateTimeKind.Unspecified).AddTicks(2180), 24, "https://mckenna.net", 2L, "commodi", 53, 4L, 1, "tenetur" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AdvancedSlotSettingsId", "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3L, 2, new DateTime(2020, 10, 13, 14, 32, 14, 370, DateTimeKind.Unspecified).AddTicks(2793), 20, "https://katrine.name", 3L, "facilis", 38, 3L, 0, "Dolorum rerum tenetur quia.\nAut tempore tempora odio natus laudantium nobis at qui.\nTempore aut aut.\nVoluptas vitae deleniti est qui." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AdvancedSlotSettingsId", "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4L, 2, new DateTime(2021, 1, 31, 17, 41, 39, 893, DateTimeKind.Unspecified).AddTicks(7252), 18, "https://betsy.info", 2L, "qui", 53, 2L, "Illum fugiat debitis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AdvancedSlotSettingsId", "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5L, 1, new DateTime(2020, 12, 17, 0, 22, 28, 823, DateTimeKind.Unspecified).AddTicks(5306), 16, "http://judson.com", 3L, "et", 23, 4L, 1, "Sed rerum alias voluptatem quia facere facere praesentium." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AdvancedSlotSettingsId", "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 6L, 1, new DateTime(2019, 12, 22, 17, 28, 3, 995, DateTimeKind.Unspecified).AddTicks(5777), 24, "https://quinten.net", 4L, "modi", 36, 10L, 0, "et" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AdvancedSlotSettingsId", "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 7L, 4, new DateTime(2020, 9, 13, 10, 48, 43, 65, DateTimeKind.Unspecified).AddTicks(641), 19, "https://bridgette.info", 1L, "atque", 52, 5L, "Quos fugiat hic consequatur ratione voluptatum sed. Commodi porro ipsum eaque voluptatem eaque in. Voluptate aliquam recusandae. Dolores omnis saepe aliquam et iusto maxime asperiores a. Aut eveniet distinctio." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AdvancedSlotSettingsId", "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 8L, 2, new DateTime(2019, 7, 25, 21, 36, 39, 608, DateTimeKind.Unspecified).AddTicks(7362), 25, "https://hubert.net", 3L, "rerum", 19, 10L, "Sit saepe ut voluptatibus natus facere aut voluptas ad.\nInventore reiciendis molestias.\nArchitecto totam qui ut.\nRem non consequuntur excepturi cumque eveniet cumque omnis omnis consequatur.\nAdipisci repellat similique voluptatem eos laudantium doloremque magni." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AdvancedSlotSettingsId", "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 9L, 5, new DateTime(2019, 12, 9, 5, 12, 42, 385, DateTimeKind.Unspecified).AddTicks(6336), 26, "http://catharine.name", 1L, "et", 24, 2L, 1, "Temporibus qui ut placeat. Maiores quo omnis quos similique labore qui velit. Dolores corporis qui omnis dolores voluptatem natus assumenda voluptas. Et distinctio velit et optio omnis iure vel quia. Asperiores esse similique eligendi exercitationem vel vel voluptas est repudiandae." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AdvancedSlotSettingsId", "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 10L, 1, new DateTime(2020, 11, 8, 9, 18, 33, 851, DateTimeKind.Unspecified).AddTicks(727), 22, "http://wilma.info", 3L, "eligendi", 60, 6L, "Qui dolor repellendus omnis vitae. Ut distinctio corporis aut. Quaerat autem eos. Non assumenda enim nihil dignissimos facilis quos. Et nihil minus quae autem perspiciatis consectetur." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2019, 7, 21, 14, 57, 22, 712, DateTimeKind.Unspecified).AddTicks(7752), 3L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 7L, new DateTime(2019, 12, 3, 20, 45, 34, 822, DateTimeKind.Unspecified).AddTicks(8008), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 6, 10, 18, 29, 35, 104, DateTimeKind.Unspecified).AddTicks(1580), 10L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2021, 1, 18, 16, 59, 30, 447, DateTimeKind.Unspecified).AddTicks(6239), 9L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 1L, new DateTime(2019, 10, 18, 0, 46, 42, 63, DateTimeKind.Unspecified).AddTicks(1233), 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 3, 17, 13, 10, 28, 690, DateTimeKind.Unspecified).AddTicks(8559), 7L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 11, 26, 19, 2, 47, 15, DateTimeKind.Unspecified).AddTicks(373), 10L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2019, 8, 27, 0, 33, 19, 1, DateTimeKind.Unspecified).AddTicks(5354), 6L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 10, 11, 10, 12, 55, 555, DateTimeKind.Unspecified).AddTicks(6283), 10L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2021, 2, 1, 22, 57, 29, 818, DateTimeKind.Unspecified).AddTicks(1998), 10L, 6L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1584), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 16, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1441), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1754), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 16, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1743), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1778), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 16, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1771), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1800), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 16, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1793), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1823), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 16, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1816), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1844), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 16, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1837), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1866), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 16, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1859), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1888), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 16, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1910), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 16, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1903), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1931), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 16, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1924), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Phillip_Sporer40@gmail.comAAAA", new DateTimeOffset(new DateTime(2022, 9, 27, 6, 1, 10, 773, DateTimeKind.Unspecified).AddTicks(3122), new TimeSpan(0, 3, 0, 0, 0)), "Phillip Sporer" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Carrie90@gmail.comAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 3, 23, 8, 17, 49, 498, DateTimeKind.Unspecified).AddTicks(6682), new TimeSpan(0, 2, 0, 0, 0)), "Carrie Green" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Beatrice80@hotmail.comAAAAAAAA", new DateTimeOffset(new DateTime(2022, 11, 30, 13, 58, 35, 967, DateTimeKind.Unspecified).AddTicks(2122), new TimeSpan(0, 2, 0, 0, 0)), "Beatrice Grant" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Lloyd98@hotmail.comAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 3, 12, 13, 6, 55, 162, DateTimeKind.Unspecified).AddTicks(4456), new TimeSpan(0, 2, 0, 0, 0)), "Lloyd Reichert" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Sergio98@gmail.comAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 3, 2, 13, 17, 39, 581, DateTimeKind.Unspecified).AddTicks(2466), new TimeSpan(0, 2, 0, 0, 0)), "Sergio Gaylord" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Sally20@gmail.comAAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 4, 14, 15, 56, 10, 330, DateTimeKind.Unspecified).AddTicks(1313), new TimeSpan(0, 3, 0, 0, 0)), "Sally Ebert" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Lorene.Koss38@yahoo.comAAAAAAA", new DateTimeOffset(new DateTime(2022, 9, 2, 11, 20, 34, 467, DateTimeKind.Unspecified).AddTicks(8404), new TimeSpan(0, 3, 0, 0, 0)), "Lorene Koss" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Gertrude.Erdman11@yahoo.comAAA", new DateTimeOffset(new DateTime(2023, 3, 22, 12, 13, 29, 777, DateTimeKind.Unspecified).AddTicks(5165), new TimeSpan(0, 2, 0, 0, 0)), "Gertrude Erdman" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Ida71@yahoo.comAAAAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 5, 7, 9, 54, 57, 410, DateTimeKind.Unspecified).AddTicks(7645), new TimeSpan(0, 3, 0, 0, 0)), "Ida Collier" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Glen72@hotmail.comAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 3, 15, 11, 52, 2, 175, DateTimeKind.Unspecified).AddTicks(5211), new TimeSpan(0, 2, 0, 0, 0)), "Glen Crist" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 2, 12, 22, 27, 14, 889, DateTimeKind.Unspecified).AddTicks(9024), 8L, "Accusantium consectetur nam temporibus eveniet quo", 34, "in", new DateTimeOffset(new DateTime(2022, 11, 9, 9, 50, 6, 10, DateTimeKind.Unspecified).AddTicks(8892), new TimeSpan(0, 2, 0, 0, 0)), 7L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 28, 17, 58, 34, 176, DateTimeKind.Unspecified).AddTicks(976), 7L, "eos", 3L, "earum", new DateTimeOffset(new DateTime(2022, 12, 12, 16, 12, 9, 708, DateTimeKind.Unspecified).AddTicks(8214), new TimeSpan(0, 2, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 8, 13, 8, 6, 6, 119, DateTimeKind.Unspecified).AddTicks(8809), 2L, "ut", 10, 3L, "maiores", new DateTimeOffset(new DateTime(2022, 12, 4, 0, 5, 18, 548, DateTimeKind.Unspecified).AddTicks(474), new TimeSpan(0, 2, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 28, 15, 16, 50, 163, DateTimeKind.Unspecified).AddTicks(4559), 3L, "culpa", 50, 3L, "dicta", new DateTimeOffset(new DateTime(2023, 2, 4, 19, 50, 23, 705, DateTimeKind.Unspecified).AddTicks(3759), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 27, 0, 30, 43, 297, DateTimeKind.Unspecified).AddTicks(9952), 6L, "Minus tempore et aut sint ducimus inventore.\nUt id", 50, "molestiae", new DateTimeOffset(new DateTime(2023, 1, 19, 6, 49, 17, 750, DateTimeKind.Unspecified).AddTicks(8110), new TimeSpan(0, 2, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 16, 10, 47, 58, 433, DateTimeKind.Unspecified).AddTicks(4043), 5L, "dolores", 41, 2L, "dicta", new DateTimeOffset(new DateTime(2023, 5, 21, 14, 22, 14, 257, DateTimeKind.Unspecified).AddTicks(5347), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 36, 6, 350, DateTimeKind.Unspecified).AddTicks(9519), 8L, "Qui consequatur ut sit corporis accusantium volupt", 38, 5L, "rerum", new DateTimeOffset(new DateTime(2022, 12, 13, 3, 8, 32, 437, DateTimeKind.Unspecified).AddTicks(7577), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 7, 24, 16, 16, 24, 583, DateTimeKind.Unspecified).AddTicks(8879), 6L, "Voluptas quia non nulla aspernatur eum.", 57, "dignissimos", new DateTimeOffset(new DateTime(2022, 10, 21, 7, 26, 1, 663, DateTimeKind.Unspecified).AddTicks(3177), new TimeSpan(0, 3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 10, 10, 8, 7, 27, 400, DateTimeKind.Unspecified).AddTicks(3247), 6L, "Voluptatum mollitia maiores itaque voluptatem dolo", 57, "nam", new DateTimeOffset(new DateTime(2023, 4, 8, 8, 1, 36, 377, DateTimeKind.Unspecified).AddTicks(3085), new TimeSpan(0, 3, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 3, 28, 2, 5, 1, 140, DateTimeKind.Unspecified).AddTicks(3779), 5L, "Provident aspernatur fugiat ipsam voluptas qui ape", 42, 3L, "vel", new DateTimeOffset(new DateTime(2023, 2, 12, 15, 55, 57, 736, DateTimeKind.Unspecified).AddTicks(3169), new TimeSpan(0, 2, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "estAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Recusandae rerum aspernatur optio.\nQuis est pariatur vero dignissimos.\nEst repudiandae tempora et libero amet.\nQuia expedita voluptatem tenetur qui enim qui.\nIure exercitationem dolorem id beatae fuga.\nEt molestiae sapiente enim." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Non eum ipsam qui ut aut.\nLibero at culpa et.\nEt ut quos qui commodi autem.\nExcepturi eum totam." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Quae sunt velit tenetur molestiae.\nNecessitatibus aliquam itaque velit ea porro sed accusamus neque.\nAccusantium quia voluptatem vitae accusamus qui et necessitatibus in.\nIn sit id.\nQuis iste suscipit itaque omnis sed nostrum delectus omnis dolor." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AvailabilitySlotId",
                value: 8L);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Eaque ut molestiae eveniet incidunt esse sed id.\nNemo quisquam rerum est voluptatem.\nSint dolores ab veritatis tenetur rerum id numquam voluptas.\nDelectus voluptatum sapiente molestiae voluptatum dolores eos." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Quas quae sunt placeat.\nSint accusantium voluptas itaque at aut qui sunt minus quam.\nQui impedit placeat praesentium qui qui aut officia." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Ad esse voluptas.\nError et qui alias qui accusantium repudiandae aut.\nIure omnis odio doloremque consequatur quo laborum consequatur unde." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Perspiciatis reiciendis quas reprehenderit odio fuga qui aspernatur dolor. Eveniet sunt alias. Optio atque minima laborum ea tempora quia est. Aliquid veniam cupiditate adipisci non qui rerum non dolorem a. Quia beatae voluptates." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Text",
                value: "Qui nam facilis recusandae esse ea voluptatem repudiandae libero animi.");

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Priority",
                value: 3);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Priority",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Priority",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Priority",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Priority",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Priority",
                value: 1);

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
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
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
                keyValue: 5L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Sed delectus dolorem consectetur vel.\nMollitia odit ea at corrupti aut laboriosam possimus.\nOdio repudiandae omnis qui eos totam impedit.\nAsperiores nulla optio distinctio.\nPraesentium odit inventore eveniet et aut ipsa et.\nAspernatur quidem aut qui aspernatur aperiam fugit sunt.", "McCullough - Fay", "http://neva.info", "Europe/Br" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Voluptatem velit et nemo et modi reprehenderit dolor. Adipisci eius tempora placeat ullam porro animi quia quibusdam fugit. Quibusdam alias consequuntur voluptatem quaerat quod ratione nobis id perspiciatis. Non aliquid hic distinctio ullam ducimus rerum eum ab sed.", "Olson, Schroeder and Langosh", "https://ramiro.org", "Europe/Lj" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Et qui commodi id doloremque modi qui.\nMagni nam sunt suscipit eum est praesentium.", "Nikolaus, Schowalter and Hirthe", "https://jarrod.net", "Asia/Riya" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "aperiam", "Mraz - Macejkovic", "https://libby.biz", "Europe/St" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Sunt sunt ut ullam recusandae doloremque illo molestias est.\nMinima fugit laborum sequi cum totam.", "Lebsack Group", "https://kelsie.net", "Europe/Pr" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Enim veritatis suscipit nisi repellendus possimus.\nSoluta quidem praesentium vero qui facere molestias eos et ipsa.\nPariatur laboriosam a.\nReiciendis quia itaque odit debitis animi.", "Gorczany, Fahey and Beer", "http://quincy.name", "Asia/Musc" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Commodi quia ut dolorem pariatur corporis voluptatem. Aut iusto et quo in magni corporis. Quis voluptas sit sint labore cumque. Nam sequi atque sunt sed. Inventore culpa quisquam et corrupti cupiditate velit expedita distinctio.", "Shields - McKenzie", "https://trace.name", "Pacific/H" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Aut explicabo sapiente laudantium adipisci laboriosam sed aspernatur reprehenderit. Rem exercitationem nihil assumenda rerum accusamus voluptate sunt qui illo. Blanditiis optio a eos est accusamus doloremque sint quia. Ea quod incidunt aut aliquam. Iure quisquam cupiditate. Consequatur minus aut in", "Gleichner and Sons", "https://flo.biz", "Asia/Jaka" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quidem at enim quibusdam.\nEt expedita voluptatibus facere hic.\nBlanditiis voluptatem qui occaecati minima tempore officia harum.\nFuga dicta quisquam doloremque ipsa.\nQuasi est nemo suscipit delectus.\nHic quibusdam sint vel vero occaecati dolore.", "Adams, Barton and Lang", "https://adrien.com", "Asia/Bang" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Animi delectus soluta.\nMagnam sint debitis est vitae expedita tempore repellat.\nEt et consequatur voluptatum nisi.", "Dach, Graham and Will", "https://hailee.name", "Europe/Bu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Sara7@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/514.jpg", "Sara Runte", "491.689.80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Sam32@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/710.jpg", "Sam Kemmer", "813.666.32", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Roberto99@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/7.jpg", "Roberto Dooley", "1-259-855-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Fred.Paucek35@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/521.jpg", "Fred Paucek", "1-640-543-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Eric69@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/117.jpg", "Eric Mosciski", "1-714-512-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Erma.Braun68@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/703.jpg", "Erma Braun", "1-225-938-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Bobby.Hyatt24@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/533.jpg", "Bobby Hyatt", "(420) 617-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Mitchell_Schamberger27@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1076.jpg", "Mitchell Schamberger", "1-437-406-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Lucille17@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1179.jpg", "Lucille Hegmann", "959.651.14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Kristine.Keeling@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/458.jpg", "Kristine Keeling", "(883) 647-" });

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilitySlots_AdvancedSlotSettingsId",
                table: "AvailabilitySlots",
                column: "AdvancedSlotSettingsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AvailabilitySlots_AdvancedSlotSettings_AdvancedSlotSettingsId",
                table: "AvailabilitySlots",
                column: "AdvancedSlotSettingsId",
                principalTable: "AdvancedSlotSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_AvailabilitySlots_AvailabilitySlotId",
                table: "Questions",
                column: "AvailabilitySlotId",
                principalTable: "AvailabilitySlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
