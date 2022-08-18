using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class SoftDeleteAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 4, 7, 4, 3, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 6, 28, 7, 5, 14 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 4, 18, 9, 3, 10 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 2, 3, 7, 3, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings" },
                values: new object[] { 5, 23, 5 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 3, 1, 10, 9, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "Days" },
                values: new object[] { 3, 15 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 14, 6, 5, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 2, 14, 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 2, 6, 9, 1 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 1, 3, 15, 58, 47, 553, DateTimeKind.Unspecified).AddTicks(9611), 18, "http://gwendolyn.net", "distinctio", 17, 1, "reprehenderit" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 6, 17, 10, 40, 22, 974, DateTimeKind.Unspecified).AddTicks(4345), "http://delphine.name", 0, "aperiam", 48, 10L, 1, "Consequuntur nemo suscipit tempora nobis quam.\nOfficiis et debitis nisi nesciunt velit qui enim veniam.\nBeatae adipisci nesciunt a aperiam.\nVoluptas et sunt ab unde doloremque harum.\nVelit eos molestias quo." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 4, 21, 14, 17, 36, 438, DateTimeKind.Unspecified).AddTicks(9593), 21, "https://jade.org", 2, "numquam", 55, 6L, "Rem quia temporibus.\nLaudantium facere voluptatibus aliquid voluptatem unde sit eum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 5, 9, 15, 36, 46, 41, DateTimeKind.Unspecified).AddTicks(524), "http://lon.info", 2, "dolorem", 23, 2L, "dolor" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 4, 19, 12, 52, 8, 162, DateTimeKind.Unspecified).AddTicks(4453), 25, "http://reba.biz", 0, "voluptas", 42, 5L, "Quam temporibus sit suscipit atque amet porro autem. Ipsum laborum sequi quo voluptas. Quia commodi voluptatem nobis a et. Natus quis incidunt vel reiciendis earum quia." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 2, 13, 2, 12, 50, 107, DateTimeKind.Unspecified).AddTicks(4886), 19, "https://weston.name", "sit", 52, 5L, 1, "dicta" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 1, 25, 20, 5, 42, 625, DateTimeKind.Unspecified).AddTicks(5328), 25, "http://elwyn.org", 2, "est", 38, 3L, 0, "Qui consectetur nemo doloremque molestias deleniti dolores cupiditate modi.\nAut magni nesciunt ut sed hic odit.\nEaque doloribus aut facilis fugiat dolorem sunt dignissimos autem excepturi." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2019, 7, 22, 18, 23, 57, 148, DateTimeKind.Unspecified).AddTicks(8824), 22, "https://foster.org", 2, "eaque", 45, 6L, "Recusandae voluptatem ab architecto sit sed voluptatum molestiae." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2019, 9, 29, 10, 13, 27, 977, DateTimeKind.Unspecified).AddTicks(5524), 26, "http://marietta.info", 1, "id", 35, 9L, "Quo deserunt tenetur. Libero dignissimos consequuntur sapiente non a. Vel et quo et consequatur aut quaerat." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 1, 21, 7, 7, 52, 140, DateTimeKind.Unspecified).AddTicks(8056), 16, "https://marjory.net", 2, "quia", 26, 8L, 1, "Magni voluptate debitis." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2021, 5, 7, 8, 46, 58, 76, DateTimeKind.Unspecified).AddTicks(3304), 5L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2019, 11, 9, 20, 53, 47, 844, DateTimeKind.Unspecified).AddTicks(3369), 10L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2019, 9, 17, 16, 23, 33, 981, DateTimeKind.Unspecified).AddTicks(4321), 7L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 3, 22, 9, 54, 41, 292, DateTimeKind.Unspecified).AddTicks(2346), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 8, 3, 1, 13, 48, 433, DateTimeKind.Unspecified).AddTicks(5757), 7L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2021, 1, 27, 12, 6, 19, 218, DateTimeKind.Unspecified).AddTicks(1539), 7L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2019, 9, 22, 12, 12, 55, 686, DateTimeKind.Unspecified).AddTicks(2571), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2020, 7, 11, 10, 30, 39, 969, DateTimeKind.Unspecified).AddTicks(4676), 4L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 11, 30, 6, 51, 22, 221, DateTimeKind.Unspecified).AddTicks(2979), 8L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2020, 11, 25, 20, 26, 2, 117, DateTimeKind.Unspecified).AddTicks(6984), 8L, 3L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(4872), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(4663), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5172), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5155), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5197), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5190), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5219), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5212), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5241), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5234), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5261), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5254), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5282), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5275), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5301), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5295), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5321), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5314), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5341), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 44, 4, 255, DateTimeKind.Unspecified).AddTicks(5335), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Marcus59@gmail.com", new DateTimeOffset(new DateTime(2022, 12, 8, 14, 6, 28, 173, DateTimeKind.Unspecified).AddTicks(1521), new TimeSpan(0, 2, 0, 0, 0)), "Marcus Howell" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Emily82@yahoo.com", new DateTimeOffset(new DateTime(2023, 6, 26, 1, 24, 39, 30, DateTimeKind.Unspecified).AddTicks(8854), new TimeSpan(0, 3, 0, 0, 0)), "Emily Jacobson" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Brandon55@hotmail.com", new DateTimeOffset(new DateTime(2023, 5, 31, 3, 16, 42, 492, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, 3, 0, 0, 0)), "Brandon Kautzer" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Melissa.Moore35@yahoo.com", new DateTimeOffset(new DateTime(2023, 6, 12, 15, 15, 19, 791, DateTimeKind.Unspecified).AddTicks(7766), new TimeSpan(0, 3, 0, 0, 0)), "Melissa Moore" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Steve_Douglas@hotmail.com", new DateTimeOffset(new DateTime(2022, 10, 16, 21, 6, 44, 573, DateTimeKind.Unspecified).AddTicks(1476), new TimeSpan(0, 3, 0, 0, 0)), "Steve Douglas" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Bradford.Mayert19@hotmail.com", new DateTimeOffset(new DateTime(2022, 12, 2, 13, 33, 42, 451, DateTimeKind.Unspecified).AddTicks(941), new TimeSpan(0, 2, 0, 0, 0)), "Bradford Mayert" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Jacob.Torp5@hotmail.com", new DateTimeOffset(new DateTime(2023, 7, 17, 2, 6, 24, 492, DateTimeKind.Unspecified).AddTicks(8815), new TimeSpan(0, 3, 0, 0, 0)), "Jacob Torp" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Natasha.Volkman95@yahoo.com", new DateTimeOffset(new DateTime(2023, 5, 15, 18, 44, 2, 156, DateTimeKind.Unspecified).AddTicks(2756), new TimeSpan(0, 3, 0, 0, 0)), "Natasha Volkman" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Erick_Johnson86@gmail.com", new DateTimeOffset(new DateTime(2023, 2, 15, 8, 55, 50, 71, DateTimeKind.Unspecified).AddTicks(6219), new TimeSpan(0, 2, 0, 0, 0)), "Erick Johnson" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Christopher.Cartwright@gmail.", new DateTimeOffset(new DateTime(2023, 2, 11, 7, 56, 22, 130, DateTimeKind.Unspecified).AddTicks(2922), new TimeSpan(0, 2, 0, 0, 0)), "Christopher Cartwright" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 51, 2, 604, DateTimeKind.Unspecified).AddTicks(6005), 9L, "Repellendus earum qui est rem.\nPossimus beatae hic", 59, "non", new DateTimeOffset(new DateTime(2023, 3, 6, 16, 12, 50, 647, DateTimeKind.Unspecified).AddTicks(3742), new TimeSpan(0, 2, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 12, 8, 14, 39, 33, 133, DateTimeKind.Unspecified).AddTicks(9685), 5L, "Magnam sit voluptas blanditiis sint est rerum susc", 24, 1, "dolor", new DateTimeOffset(new DateTime(2023, 5, 24, 23, 19, 40, 93, DateTimeKind.Unspecified).AddTicks(5436), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 13, 22, 34, 28, 163, DateTimeKind.Unspecified).AddTicks(1753), 4L, "Quia blanditiis accusantium. Possimus doloribus di", 54, 1, "in", new DateTimeOffset(new DateTime(2023, 3, 9, 7, 31, 27, 733, DateTimeKind.Unspecified).AddTicks(3179), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 11, 6, 58, 27, 529, DateTimeKind.Unspecified).AddTicks(7662), 1L, "qui", 28, 2, "rerum", new DateTimeOffset(new DateTime(2023, 3, 17, 2, 39, 13, 645, DateTimeKind.Unspecified).AddTicks(3791), new TimeSpan(0, 2, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 2, 14, 9, 31, 53, 263, DateTimeKind.Unspecified).AddTicks(185), 2L, "consequuntur", 47, "assumenda", new DateTimeOffset(new DateTime(2022, 12, 11, 3, 20, 59, 243, DateTimeKind.Unspecified).AddTicks(2635), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime" },
                values: new object[] { new DateTime(2020, 3, 15, 22, 20, 45, 708, DateTimeKind.Unspecified).AddTicks(1170), 4L, "qui", 35, 2, "eligendi", new DateTimeOffset(new DateTime(2023, 3, 24, 9, 56, 34, 454, DateTimeKind.Unspecified).AddTicks(1802), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 11, 13, 18, 39, 29, 161, DateTimeKind.Unspecified).AddTicks(8031), 6L, "Nihil est est et dolor et.", 19, 0, "omnis", new DateTimeOffset(new DateTime(2023, 3, 3, 17, 33, 8, 409, DateTimeKind.Unspecified).AddTicks(2888), new TimeSpan(0, 2, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 7, 13, 7, 15, 15, 234, DateTimeKind.Unspecified).AddTicks(2690), 4L, "Officiis aliquam nulla fugiat facere laudantium mi", 24, 2, "corporis", new DateTimeOffset(new DateTime(2022, 12, 3, 6, 2, 27, 575, DateTimeKind.Unspecified).AddTicks(9517), new TimeSpan(0, 2, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 11, 8, 12, 56, 49, 256, DateTimeKind.Unspecified).AddTicks(9278), 10L, "Id eum sunt totam porro voluptatem voluptatem quae", 14, 1, "perferendis", new DateTimeOffset(new DateTime(2023, 2, 1, 22, 16, 26, 817, DateTimeKind.Unspecified).AddTicks(4630), new TimeSpan(0, 2, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 8, 3, 1, 57, 25, 588, DateTimeKind.Unspecified).AddTicks(1777), 9L, "Unde eaque itaque quos quaerat iure dignissimos et", 27, 1, "officia", new DateTimeOffset(new DateTime(2022, 9, 16, 19, 36, 14, 581, DateTimeKind.Unspecified).AddTicks(5074), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Enim cumque omnis corporis velit.\nEt ea aut quia laudantium quia quod.\nTenetur in praesentium dolorum illo ut quis et.\nOfficiis velit nostrum voluptatum vitae ipsum nam.\nQui tempore est officia incidunt.\nRerum omnis fuga molestiae quod repellat aliquid cum eum." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Ad cumque iure. Deleniti eligendi sit sed. Aperiam quibusdam aperiam. Quis rem autem dolores. In nobis ex ipsa esse eius qui. Tempora laudantium perspiciatis tempora et." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Repellat vel dolor modi aliquam qui in atque nesciunt voluptatem.\nBlanditiis harum aperiam.\nVoluptas occaecati quasi." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Modi aliquid ut magni magnam debitis iusto labore et. Id aut culpa voluptas nesciunt esse optio eligendi. Suscipit sed ipsum omnis eum. Distinctio ducimus porro illo. Autem eligendi doloremque facere explicabo atque consequuntur. Debitis eveniet iusto perspiciatis vel rerum harum quisquam modi aut." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "A nesciunt similique quia minima.AAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Sapiente quae et tempore non doloribus pariatur cupiditate animi impedit." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Maiores consequatur quos nam aspernatur. Et sit minus repudiandae repellat sint eum. Vel ea expedita sed veritatis dicta vitae voluptas quo." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Dolores nam culpa aut voluptatem dicta sed cupiditate vitae.\nEa consequatur consequatur illum quisquam impedit." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Qui facilis est unde rerum.\nEt recusandae ea.\nFugiat iusto ea tempore ea expedita.\nIn similique ratione ea voluptatem est eum officiis.\nIusto labore ad quos sint et amet aliquam." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Porro recusandae aliquam sed cum adipisci sit atque iste." });

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Priority",
                value: 8);

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
                value: 7);

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
                value: 10);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Priority",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Priority",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Priority",
                value: 10);

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
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Role",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Role",
                value: 1);

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
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "labore", "Cummerata, Grady and Mills", "https://mikayla.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "assumenda", "Wintheiser - Ryan", "https://berniece.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Adipisci aliquam natus aut laborum reprehenderit.\nFuga neque magni sequi dolor aperiam sit animi distinctio porro.\nFacere ipsa velit pariatur expedita a occaecati architecto perferendis.", "Rogahn Inc", "https://kale.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Praesentium exercitationem ratione.\nPraesentium velit aut.\nQuo est voluptatem cupiditate eligendi cupiditate aspernatur molestiae.\nOmnis quisquam dolores.\nEx sed eaque.\nEum temporibus hic omnis dicta sit illum ea.", "Bartell, Koelpin and Grant", "http://rhea.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Necessitatibus eligendi nemo recusandae est. Ut vel nostrum aut sit autem accusantium sequi. Repudiandae id ut nam. Laborum similique quis molestiae facilis. Voluptatibus ipsum occaecati quisquam accusantium ipsum vero placeat.", "Walsh - Herzog", "http://trystan.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Voluptas nostrum occaecati consequatur sit illo laborum distinctio.\nExplicabo sit doloribus at dolor commodi autem.\nError labore reiciendis eos.\nRatione quod et perferendis tempora accusantium alias ut provident.\nUt enim voluptatibus autem commodi id impedit.\nDolorum ea inventore ut excepturi ex do", "Schamberger - Volkman", "http://mose.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Aut error sit.\nIn consequatur est velit debitis ullam laborum ut sit.", "Herman - Borer", "http://elvera.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Laudantium iste et error repellendus et. Iure est mollitia magnam. Est qui qui. Ad asperiores eius dolor exercitationem facere voluptatibus omnis quis. Nulla laboriosam architecto provident quam eaque perferendis.", "Mertz, Erdman and Williamson", "http://yasmin.name" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Incidunt qui aspernatur.", "Wunsch - Gottlieb", "https://aimee.net" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Eum et ipsam soluta voluptate maiores. Dolores rerum quia eum quae. Et et qui quia et sapiente ut architecto quos. Enim voluptatem dicta aliquam ut.", "Gorczany, Schmidt and Durgan", "http://ardella.net" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Krista.Schoen41@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1198.jpg", "Krista Schoen", "1-529-765-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Antonio_Beatty@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/75.jpg", "Antonio Beatty", "854.973.38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Dana74@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/838.jpg", "Dana King", "887.620.75" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Mable_Rutherford@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/778.jpg", "Mable Rutherford", "608-293-16", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Nick.Yost@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1024.jpg", "Nick Yost", "1-953-915-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Enrique.Glover43@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/211.jpg", "Enrique Glover", "702.811.43", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Susan93@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/995.jpg", "Susan Waters", "1-981-429-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Belinda_Larson65@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/254.jpg", "Belinda Larson", "475.868.38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Lance78@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1186.jpg", "Lance Hane", "477.929.53" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Geneva.Renner@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1003.jpg", "Geneva Renner", "981.419.05" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 2, 13, 10, 1, 10 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 26, 8, 2, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 7, 25, 10, 2, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 7, 4, 1, 5, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings" },
                values: new object[] { 3, 26, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 1, 3, 11, 8, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "Days" },
                values: new object[] { 7, 27 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 25, 1, 1, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 7, 29, 8, 5, 13 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 1, 19, 5, 4 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 10, 25, 3, 34, 5, 290, DateTimeKind.Unspecified).AddTicks(972), 15, "https://caroline.name", "animi", 44, 0, "Quia delectus facere non.\nHarum facilis assumenda accusamus qui sed et repellat vero dolores.\nLibero et qui facilis sed nobis ut.\nQuaerat iure perferendis placeat aliquam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 7, 22, 23, 58, 11, 273, DateTimeKind.Unspecified).AddTicks(6525), "http://antonia.org", 1, "illo", 22, 7L, 0, "Ut voluptatibus dolore necessitatibus dolores soluta nihil. Et omnis nobis rem qui accusamus rerum aut a vero. Voluptatum quos voluptatem tenetur officiis non sint sit quia." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2019, 8, 10, 15, 10, 12, 718, DateTimeKind.Unspecified).AddTicks(4011), 17, "http://lindsey.org", 1, "officia", 33, 5L, "Veritatis sed saepe." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 10, 11, 18, 43, 57, 540, DateTimeKind.Unspecified).AddTicks(532), "https://madalyn.org", 0, "esse", 48, 4L, "Architecto suscipit ratione voluptatem aut ut iusto aut voluptates.\nSit ea et non omnis consectetur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 7, 6, 20, 0, 0, 590, DateTimeKind.Unspecified).AddTicks(2067), 28, "http://jeff.com", 1, "voluptates", 30, 4L, "Laborum necessitatibus molestiae voluptate libero." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 6, 5, 17, 56, 55, 88, DateTimeKind.Unspecified).AddTicks(4080), 23, "https://cielo.biz", "eligendi", 50, 4L, 0, "Dolorem provident aut rerum non.\nRatione explicabo doloribus omnis autem deleniti.\nQuo iste deleniti omnis minus voluptatem eaque.\nMinus non labore aut et ea.\nCorporis molestiae facilis et ut ut rerum dolorem aut provident.\nEaque omnis quos dolore aliquid magnam culpa." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 6, 19, 10, 43, 21, 298, DateTimeKind.Unspecified).AddTicks(8672), 17, "https://jermaine.biz", 0, "numquam", 31, 7L, 1, "exercitationem" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 1, 22, 6, 42, 43, 754, DateTimeKind.Unspecified).AddTicks(6794), 16, "http://petra.net", 0, "et", 53, 5L, "Minima consequatur est eos." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 1, 2, 15, 49, 41, 765, DateTimeKind.Unspecified).AddTicks(3875), 15, "https://ronny.name", 2, "error", 31, 10L, "Non aut et et. Architecto molestiae ut dolor veritatis velit. Eos qui hic omnis velit velit consequatur suscipit totam quo. Omnis facilis sunt et iusto omnis deserunt. Repudiandae qui ipsam facere est vero aspernatur amet." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 2, 7, 11, 54, 54, 533, DateTimeKind.Unspecified).AddTicks(601), 28, "https://antoinette.biz", 1, "ab", 38, 2L, 0, "Corporis laboriosam maiores. Voluptatem necessitatibus vel atque eum quia voluptatem soluta iusto. Aut perspiciatis dolores dignissimos voluptates provident. Quia ea corporis dignissimos." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2021, 3, 31, 19, 51, 14, 149, DateTimeKind.Unspecified).AddTicks(2398), 8L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2020, 1, 6, 4, 22, 54, 746, DateTimeKind.Unspecified).AddTicks(9275), 4L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 6, 15, 20, 41, 27, 659, DateTimeKind.Unspecified).AddTicks(2725), 6L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 9, 21, 1, 52, 34, 269, DateTimeKind.Unspecified).AddTicks(170), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 7, 15, 13, 15, 42, 875, DateTimeKind.Unspecified).AddTicks(2959), 5L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2021, 4, 22, 2, 58, 9, 460, DateTimeKind.Unspecified).AddTicks(2220), 2L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2021, 6, 30, 16, 0, 22, 673, DateTimeKind.Unspecified).AddTicks(6553), 9L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2019, 8, 28, 22, 2, 22, 90, DateTimeKind.Unspecified).AddTicks(2472), 6L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 12, 20, 7, 37, 42, 161, DateTimeKind.Unspecified).AddTicks(4263), 10L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2021, 6, 2, 11, 31, 7, 389, DateTimeKind.Unspecified).AddTicks(8093), 5L, 7L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4148), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(3918), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4506), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4488), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4728), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4716), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4805), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4793), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Carole_Homenick75@gmail.com", new DateTimeOffset(new DateTime(2022, 11, 7, 11, 10, 48, 638, DateTimeKind.Unspecified).AddTicks(8373), new TimeSpan(0, 2, 0, 0, 0)), "Carole Homenick" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Josephine11@gmail.com", new DateTimeOffset(new DateTime(2023, 3, 17, 11, 55, 40, 14, DateTimeKind.Unspecified).AddTicks(6358), new TimeSpan(0, 2, 0, 0, 0)), "Josephine Spencer" });

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
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Kathryn12@hotmail.com", new DateTimeOffset(new DateTime(2023, 5, 9, 7, 42, 3, 689, DateTimeKind.Unspecified).AddTicks(521), new TimeSpan(0, 3, 0, 0, 0)), "Kathryn Will" });

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
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Lora_Miller86@hotmail.com", new DateTimeOffset(new DateTime(2023, 4, 25, 12, 35, 45, 170, DateTimeKind.Unspecified).AddTicks(6065), new TimeSpan(0, 3, 0, 0, 0)), "Lora Miller" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 27, 1, 10, 3, 194, DateTimeKind.Unspecified).AddTicks(6623), 8L, "Enim voluptate illo numquam officia molestiae ut.", 50, "rem", new DateTimeOffset(new DateTime(2022, 8, 18, 13, 52, 42, 457, DateTimeKind.Unspecified).AddTicks(9679), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 3, 20, 12, 36, 58, 733, DateTimeKind.Unspecified).AddTicks(6517), 6L, "Non eligendi distinctio occaecati sed illum vel ei", 28, 2, "deserunt", new DateTimeOffset(new DateTime(2022, 11, 28, 18, 37, 35, 235, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 2, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 9, 9, 8, 3, 23, 135, DateTimeKind.Unspecified).AddTicks(964), 7L, "Quibusdam nostrum officia doloribus inventore.", 16, 0, "ut", new DateTimeOffset(new DateTime(2023, 7, 29, 11, 34, 36, 201, DateTimeKind.Unspecified).AddTicks(9616), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 21, 0, 53, 24, 640, DateTimeKind.Unspecified).AddTicks(7709), 5L, "Reprehenderit commodi iure laborum similique. Adip", 13, 1, "dolorem", new DateTimeOffset(new DateTime(2022, 11, 3, 7, 31, 22, 983, DateTimeKind.Unspecified).AddTicks(5282), new TimeSpan(0, 2, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 10, 8, 20, 36, 29, 361, DateTimeKind.Unspecified).AddTicks(9716), 5L, "Est qui officia cupiditate nihil ut nam aperiam do", 49, "corrupti", new DateTimeOffset(new DateTime(2022, 8, 19, 4, 48, 34, 628, DateTimeKind.Unspecified).AddTicks(6571), new TimeSpan(0, 3, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime" },
                values: new object[] { new DateTime(2021, 5, 6, 4, 50, 6, 354, DateTimeKind.Unspecified).AddTicks(8662), 3L, "Aliquid soluta laborum voluptatem velit autem et v", 56, 0, "sint", new DateTimeOffset(new DateTime(2023, 2, 13, 9, 25, 32, 223, DateTimeKind.Unspecified).AddTicks(5637), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 19, 8, 15, 50, 976, DateTimeKind.Unspecified).AddTicks(3511), 4L, "Aut eum nisi ut inventore voluptates.", 17, 1, "sit", new DateTimeOffset(new DateTime(2023, 6, 25, 18, 55, 8, 316, DateTimeKind.Unspecified).AddTicks(9309), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 11, 8, 17, 58, 11, 532, DateTimeKind.Unspecified).AddTicks(458), 6L, "Quaerat itaque nobis optio maxime qui.", 13, 1, "exercitationem", new DateTimeOffset(new DateTime(2023, 3, 30, 6, 20, 48, 114, DateTimeKind.Unspecified).AddTicks(4715), new TimeSpan(0, 3, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 7, 3, 9, 49, 26, 115, DateTimeKind.Unspecified).AddTicks(7176), 8L, "Sint beatae ut incidunt exercitationem nihil et.\nM", 56, 2, "tenetur", new DateTimeOffset(new DateTime(2022, 11, 23, 10, 50, 14, 41, DateTimeKind.Unspecified).AddTicks(5250), new TimeSpan(0, 2, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 18, 16, 3, 38, 99, DateTimeKind.Unspecified).AddTicks(7311), 2L, "Doloremque blanditiis illum est iste incidunt volu", 54, 2, "corporis", new DateTimeOffset(new DateTime(2023, 5, 25, 2, 39, 35, 753, DateTimeKind.Unspecified).AddTicks(3874), new TimeSpan(0, 3, 0, 0, 0)), 10L });

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
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Amet deleniti corrupti alias corrupti dicta aut corporis sint.\nQuisquam et quibusdam quia dolorem eos velit." });

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
                column: "Role",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Role",
                value: 2);

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
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "similique", "Kshlerin - Hickle", "https://seth.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "ipsam", "Kohler - Halvorson", "http://barney.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Nisi ratione quis fugiat.", "Lindgren LLC", "https://rowan.net" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Rerum non provident ipsum dolor vero. Non at explicabo est doloribus tenetur doloremque magni necessitatibus dolor. Quia laudantium in necessitatibus ut incidunt voluptatibus molestiae eaque. Quo quod iure laboriosam assumenda sunt hic fuga iste ad. Doloribus consequatur temporibus aperiam impedit", "Jakubowski, Erdman and Herzog", "https://millie.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Perferendis autem est. Quasi dolorem rerum illo deleniti et. Quis rem molestias delectus. Similique nemo ut in.", "DuBuque, Shanahan and Luettgen", "http://adele.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Sed aut ab nostrum ut.", "Paucek and Sons", "http://shanie.name" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "omnis", "Cartwright - Bosco", "http://karine.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Et qui quam. Sed fuga distinctio id rerum. Nulla sit pariatur dolorem iste in dolor impedit similique. Sed et odit placeat voluptatibus necessitatibus esse.", "Rath, Schamberger and Prohaska", "http://adah.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Dicta est voluptatem dolores non.\nDolore magnam nemo distinctio voluptatum aliquam qui molestiae hic.\nUt non minus aut id consectetur non omnis soluta.\nMagnam sint rerum est doloremque animi corporis saepe quasi.\nAutem delectus eveniet aliquam autem quae ipsam.", "Hermiston and Sons", "https://sandra.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Quia quaerat et ut iste pariatur fugiat voluptatem accusamus doloremque.\nUllam quis similique rerum non.\nQui corrupti assumenda magnam ex id.\nRerum sapiente voluptatem qui quos maiores.\nDolores cumque expedita quisquam est sunt quod incidunt laborum a.", "Hickle - Predovic", "https://myrtis.name" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Joann.Waters91@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/156.jpg", "Joann Waters", "758-647-50", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Jimmy.Strosin38@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1003.jpg", "Jimmy Strosin", "792-733-78" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Jane.Hand@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/969.jpg", "Jane Hand", "1-360-471-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Faith_Bergstrom@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/449.jpg", "Faith Bergstrom", "1-767-387-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Jerome_Schamberger@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/447.jpg", "Jerome Schamberger", "253-807-20", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Vincent_Gorczany90@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/840.jpg", "Vincent Gorczany", "832-797-95", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Genevieve0@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/348.jpg", "Genevieve Pfannerstill", "(406) 715-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Horace_Rempel@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/609.jpg", "Horace Rempel", "1-378-467-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Carrie27@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/506.jpg", "Carrie Rohan", "1-761-958-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Robert56@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/672.jpg", "Robert Witting", "804-371-92" });
        }
    }
}
