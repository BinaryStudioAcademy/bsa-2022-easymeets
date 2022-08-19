using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class AddedSoftDeleteAndFixedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 4, 4, 5, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 3, 12, 6, 1, 13 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 6, 4, 8, 4, 14 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 8, 3, 5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 5, 10, 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 1, 10, 5, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 6, 15, 1, 10 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 5, 2, 4, 4, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 1, 7, 10, 5, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 5, 4, 5, 2, 3 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 4, 12, 0, 48, 41, 913, DateTimeKind.Unspecified).AddTicks(5030), 16, "https://shanny.net", 0, "doloremque", 46, 3L, 1, "Corrupti adipisci reprehenderit unde consequatur explicabo aliquid deserunt aut." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 7, 20, 4, 15, 16, 989, DateTimeKind.Unspecified).AddTicks(9505), 16, "http://lempi.org", "explicabo", 53, 7L, "Consequatur optio iste." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 2, 29, 3, 39, 18, 61, DateTimeKind.Unspecified).AddTicks(441), 21, "http://holden.com", 1, "quia", 38, 5L, 0, "Aliquid beatae cumque.\nVoluptatem quia qui qui velit quibusdam placeat." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 5, 28, 6, 12, 57, 71, DateTimeKind.Unspecified).AddTicks(7964), 15, "https://nayeli.com", 1, "quos", 39, 10L, 1, "Ut est nesciunt non numquam accusantium." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 1, 21, 18, 4, 26, 614, DateTimeKind.Unspecified).AddTicks(4361), 18, "http://floy.net", "odit", 41, 10L, 1, "voluptate" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 3, 8, 5, 15, 30, 784, DateTimeKind.Unspecified).AddTicks(1106), 27, "https://tyreek.org", "quasi", 33, 10L, "Eius labore esse neque labore dolor quia saepe.\nInventore aut fuga.\nDebitis quo velit voluptatem rerum.\nVitae voluptatem quia iste itaque officia.\nExercitationem dolor repudiandae nihil alias asperiores nam quis voluptate sit.\nNon accusamus qui ut modi ea et." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 6, 11, 1, 41, 54, 366, DateTimeKind.Unspecified).AddTicks(7577), 30, "http://kieran.biz", 2, "quia", 33, 3L, 1, "nobis" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 8, 3, 16, 40, 44, 206, DateTimeKind.Unspecified).AddTicks(691), 20, "https://ara.name", "necessitatibus", 26, 9L, 0, "Et odit sit mollitia nulla aspernatur voluptas." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 6, 6, 7, 15, 43, 941, DateTimeKind.Unspecified).AddTicks(5293), 28, "https://avis.name", 2, "aut", 58, 9L, 1, "enim" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 11, 21, 16, 22, 26, 916, DateTimeKind.Unspecified).AddTicks(2247), 29, "https://casey.name", 0, "voluptatibus", 43, 6L, "sunt" });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2020, 10, 23, 13, 17, 22, 296, DateTimeKind.Unspecified).AddTicks(4676), 1L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 10, 6, 14, 3, 14, 116, DateTimeKind.Unspecified).AddTicks(7873), 2L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 11, 6, 6, 4, 37, 929, DateTimeKind.Unspecified).AddTicks(5830), 1L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2019, 10, 14, 3, 44, 21, 857, DateTimeKind.Unspecified).AddTicks(6664), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 5, 22, 2, 45, 51, 178, DateTimeKind.Unspecified).AddTicks(1754), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 5L, new DateTime(2019, 10, 17, 13, 4, 55, 428, DateTimeKind.Unspecified).AddTicks(4202), 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2021, 7, 14, 5, 31, 55, 24, DateTimeKind.Unspecified).AddTicks(9201), 1L, 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 5, 3, 1, 4, 9, 423, DateTimeKind.Unspecified).AddTicks(571), 4L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2021, 5, 7, 1, 31, 28, 26, DateTimeKind.Unspecified).AddTicks(3205), 9L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2020, 3, 28, 16, 30, 1, 197, DateTimeKind.Unspecified).AddTicks(8083), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(8089), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(7679), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(8964), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(8898), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9104), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9063), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9223), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9197), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9555), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9517), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9676), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9650), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9809), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9776), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9932), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9866), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 532, DateTimeKind.Unspecified).AddTicks(19), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9993), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 532, DateTimeKind.Unspecified).AddTicks(91), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 532, DateTimeKind.Unspecified).AddTicks(68), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Donald_Hills@yahoo.com", new DateTimeOffset(new DateTime(2022, 11, 23, 16, 14, 33, 297, DateTimeKind.Unspecified).AddTicks(2027), new TimeSpan(0, 2, 0, 0, 0)), "Donald Hills" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Leonard62@hotmail.com", new DateTimeOffset(new DateTime(2022, 12, 17, 14, 23, 28, 332, DateTimeKind.Unspecified).AddTicks(6148), new TimeSpan(0, 2, 0, 0, 0)), "Leonard Effertz" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Dewey_Schuppe@yahoo.com", new DateTimeOffset(new DateTime(2022, 9, 9, 16, 52, 39, 151, DateTimeKind.Unspecified).AddTicks(5428), new TimeSpan(0, 3, 0, 0, 0)), "Dewey Schuppe" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Elijah.Blanda@gmail.com", new DateTimeOffset(new DateTime(2023, 4, 2, 22, 47, 35, 102, DateTimeKind.Unspecified).AddTicks(3409), new TimeSpan(0, 3, 0, 0, 0)), "Elijah Blanda" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Joel_Goldner@hotmail.com", new DateTimeOffset(new DateTime(2023, 2, 22, 16, 19, 49, 783, DateTimeKind.Unspecified).AddTicks(7722), new TimeSpan(0, 2, 0, 0, 0)), "Joel Goldner" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Jaime.Veum2@hotmail.com", new DateTimeOffset(new DateTime(2022, 12, 20, 8, 37, 22, 427, DateTimeKind.Unspecified).AddTicks(9219), new TimeSpan(0, 2, 0, 0, 0)), "Jaime Veum" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Patti.Feil@yahoo.com", new DateTimeOffset(new DateTime(2023, 7, 6, 14, 21, 35, 845, DateTimeKind.Unspecified).AddTicks(4506), new TimeSpan(0, 3, 0, 0, 0)), "Patti Feil" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Jesus9@hotmail.com", new DateTimeOffset(new DateTime(2023, 1, 6, 10, 15, 18, 973, DateTimeKind.Unspecified).AddTicks(499), new TimeSpan(0, 2, 0, 0, 0)), "Jesus Gorczany" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Jacob.Ondricka6@yahoo.com", new DateTimeOffset(new DateTime(2023, 3, 28, 4, 58, 27, 633, DateTimeKind.Unspecified).AddTicks(6130), new TimeSpan(0, 3, 0, 0, 0)), "Jacob Ondricka" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Erma.MacGyver86@hotmail.com", new DateTimeOffset(new DateTime(2023, 4, 6, 14, 52, 3, 590, DateTimeKind.Unspecified).AddTicks(5247), new TimeSpan(0, 3, 0, 0, 0)), "Erma MacGyver" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 6, 15, 11, 55, 19, 331, DateTimeKind.Unspecified).AddTicks(2144), 5L, "doloremque", 19, "ut", new DateTimeOffset(new DateTime(2023, 1, 8, 21, 29, 50, 143, DateTimeKind.Unspecified).AddTicks(4347), new TimeSpan(0, 2, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 13, 19, 29, 31, 675, DateTimeKind.Unspecified).AddTicks(5836), 8L, "aliquid", 54, 0, "consequatur", new DateTimeOffset(new DateTime(2023, 5, 5, 16, 0, 47, 922, DateTimeKind.Unspecified).AddTicks(5745), new TimeSpan(0, 3, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 24, 10, 18, 7, 49, DateTimeKind.Unspecified).AddTicks(3480), 9L, "atque", 14, 2, "soluta", new DateTimeOffset(new DateTime(2022, 12, 16, 14, 42, 58, 499, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 2, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 29, 3, 39, 18, 61, DateTimeKind.Unspecified).AddTicks(441), 6L, "Id repudiandae odit quo aut quisquam.\nQuam et quia", 30, "consequatur", new DateTimeOffset(new DateTime(2022, 10, 25, 16, 45, 47, 740, DateTimeKind.Unspecified).AddTicks(4378), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 18, 7, 5, 24, 18, DateTimeKind.Unspecified).AddTicks(9612), 10L, "Iusto atque ut est nesciunt non.", 48, 0, "doloribus", new DateTimeOffset(new DateTime(2022, 9, 14, 17, 57, 57, 398, DateTimeKind.Unspecified).AddTicks(932), new TimeSpan(0, 3, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 24, 6, 10, 0, 75, DateTimeKind.Unspecified).AddTicks(7738), 4L, "fuga", 15, 2, "cupiditate", new DateTimeOffset(new DateTime(2022, 8, 19, 0, 44, 7, 733, DateTimeKind.Unspecified).AddTicks(8294), new TimeSpan(0, 3, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 20, 13, 30, 18, 913, DateTimeKind.Unspecified).AddTicks(9011), 7L, "Libero sunt modi sint dolore doloribus ipsa quasi.", 21, 2, "fugit", new DateTimeOffset(new DateTime(2022, 11, 14, 18, 5, 42, 823, DateTimeKind.Unspecified).AddTicks(1035), new TimeSpan(0, 2, 0, 0, 0)), 7L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 18, 3, 54, 1, 72, DateTimeKind.Unspecified).AddTicks(6702), 1L, "dolor", 12, "neque", new DateTimeOffset(new DateTime(2023, 6, 8, 22, 8, 0, 372, DateTimeKind.Unspecified).AddTicks(4596), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 8, 5, 0, 36, 4, 341, DateTimeKind.Unspecified).AddTicks(3092), 3L, "Voluptatem rerum esse vitae. Quia iste itaque offi", 55, "quaerat", new DateTimeOffset(new DateTime(2023, 1, 9, 12, 40, 50, 561, DateTimeKind.Unspecified).AddTicks(8630), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 3, 8, 21, 11, 859, DateTimeKind.Unspecified).AddTicks(9966), 5L, "vel", 35, 2, "ullam", new DateTimeOffset(new DateTime(2023, 4, 4, 13, 33, 51, 874, DateTimeKind.Unspecified).AddTicks(7614), new TimeSpan(0, 3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Text",
                value: "doloremqueAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Reprehenderit unde consequatur explicabo. Deserunt aut impedit aut quo. Soluta vitae atque dolores tempore debitis explicabo voluptas. Consequatur optio iste." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Quo aut quisquam.\nQuam et quia id veritatis ab.\nBeatae cumque quas voluptatem quia.\nQui velit quibusdam placeat magni et.\nAd et voluptate amet.\nDoloribus esse quos iusto atque ut est nesciunt." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "accusantiumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Cupiditate perferendis fuga sunt maiores autem odit alias.\nFugit ea impedit libero sunt modi." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "doloribusAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "harumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Esse neque labore dolor.\nSaepe alias inventore aut.\nQuaerat debitis quo velit voluptatem rerum esse vitae." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "isteAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Dolor repudiandae nihil alias asperiores.\nQuis voluptate sit sunt non accusamus qui ut.\nEa et et rerum.\nIpsa voluptate temporibus est sit eius dolor quia explicabo nobis.\nSunt dolore rerum reprehenderit reiciendis ullam.\nVel sapiente necessitatibus." });

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
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Priority",
                value: 1);

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
                value: 9);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Priority",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Priority",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Priority",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Priority",
                value: 9);

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
                column: "Role",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Role",
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
                keyValue: 5L,
                column: "Role",
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
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "reprehenderit", "Breitenberg Inc", "http://richard.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Harum soluta vitae atque dolores tempore debitis explicabo.\nBeatae consequatur optio iste qui.\nRepudiandae odit quo aut quisquam et quam.\nQuia id veritatis ab aliquid beatae cumque quas.\nQuia qui qui.\nQuibusdam placeat magni et.", "Schowalter - Boyer", "http://lamont.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Iusto atque ut est nesciunt non. Accusantium et maxime architecto. Cupiditate perferendis fuga sunt maiores autem odit alias. Fugit ea impedit libero sunt modi.", "Gorczany LLC", "http://christopher.net" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Esse neque labore dolor.\nSaepe alias inventore aut.\nQuaerat debitis quo velit voluptatem rerum esse vitae.", "Frami, Zboncak and Baumbach", "http://loren.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Repudiandae nihil alias asperiores nam quis voluptate sit sunt.", "Casper LLC", "https://laisha.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Sapiente ipsa voluptate temporibus est sit eius dolor quia explicabo.\nVoluptatum sunt dolore rerum reprehenderit reiciendis ullam illo.\nSapiente necessitatibus totam molestias et odit sit mollitia nulla.\nVoluptas et architecto.\nAccusantium aliquam quis quia reiciendis qui est aut.\nEnim est aspernat", "Stroman Group", "http://damien.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Architecto sunt ut neque et neque fuga recusandae modi voluptas.\nIn non modi et voluptatem at voluptatem incidunt eaque.", "Mosciski - Weber", "https://dejah.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Alias at nihil nemo voluptatem nam hic soluta.", "Smitham Inc", "https://junior.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Optio impedit qui nemo qui reprehenderit quod consequatur aut. Ut esse ipsa quidem voluptatem omnis delectus recusandae quis dolorum. Vel ut enim hic omnis saepe. In necessitatibus magni perferendis quia asperiores fugiat omnis alias ex. Praesentium delectus earum aut. Porro ut et quia non saepe si", "Willms - Hettinger", "https://callie.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Repellendus temporibus quia assumenda modi labore.", "Hyatt - Hamill", "http://braeden.info" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Albert39@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1239.jpg", "Albert Barrows", "287.766.04", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Tyrone2@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1236.jpg", "Tyrone Gleason", "1-259-731-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Flora57@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/808.jpg", "Flora Abernathy", "489-790-47", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Sonja98@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/186.jpg", "Sonja Spinka", "392-637-49" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Brittany94@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/851.jpg", "Brittany Mueller", "(319) 287-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Chelsea_Mertz96@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/954.jpg", "Chelsea Mertz", "(258) 515-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Clinton.Hayes95@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1101.jpg", "Clinton Hayes", "(504) 681-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Randall9@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/481.jpg", "Randall Wintheiser", "897-873-88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Orlando.Wiza@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/757.jpg", "Orlando Wiza", "(884) 579-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Leona86@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/790.jpg", "Leona Cronin", "947.872.74" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 6, 18, 4, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 5, 15, 8, 3, 5 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 8, 16, 4, 1, 13 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 3, 15, 4, 1, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 4, 22, 9, 2, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 4, 8, 2, 13 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 7, 9, 4, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 8, 7, 1, 3, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 2, 8, 26, 1, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 3, 30, 10, 3, 15 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 2, 3, 0, 28, 15, 611, DateTimeKind.Unspecified).AddTicks(1536), 17, "http://walker.net", 2, "voluptatibus", 49, 7L, 0, "Soluta enim officia voluptatum soluta. Excepturi id fugiat ut odit odio tenetur molestiae. Omnis maxime sit eum mollitia tempora saepe dolor et itaque. Et quidem quis esse maxime." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 2, 10, 10, 40, 30, 339, DateTimeKind.Unspecified).AddTicks(296), 28, "https://kacie.info", "eligendi", 24, 10L, "Voluptate maxime libero omnis quis aut architecto." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 3, 6, 13, 9, 16, 420, DateTimeKind.Unspecified).AddTicks(7170), 17, "https://brandy.name", 2, "ipsum", 36, 6L, 1, "Cupiditate soluta recusandae est sit dolore qui officia.\nProvident dolore et.\nFacere cupiditate autem voluptatibus sequi ipsam quaerat.\nEst repudiandae et magni ut expedita qui soluta.\nDebitis facilis sint labore fugit non dolorem dolores consequuntur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 5, 19, 22, 5, 12, 532, DateTimeKind.Unspecified).AddTicks(314), 17, "https://reyes.com", 0, "porro", 26, 1L, 0, "cumque" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2019, 12, 1, 21, 19, 26, 793, DateTimeKind.Unspecified).AddTicks(2905), 24, "https://hermina.org", "maxime", 24, 9L, 0, "Doloribus esse ea quia natus sunt molestiae ea dolores. Repellat nisi et veniam nihil nihil voluptas maiores. Iure in ut aut. Inventore et debitis. Perspiciatis labore non assumenda delectus minus optio saepe. Eveniet doloribus animi neque quia praesentium dignissimos qui." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 9, 28, 12, 30, 14, 131, DateTimeKind.Unspecified).AddTicks(6401), 24, "http://therese.info", "saepe", 45, 7L, "Quo architecto et consectetur sit animi vel alias omnis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 7, 26, 19, 50, 18, 451, DateTimeKind.Unspecified).AddTicks(5528), 25, "https://alison.net", 1, "ab", 46, 8L, 0, "voluptatem" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2019, 12, 20, 1, 50, 50, 192, DateTimeKind.Unspecified).AddTicks(2560), 18, "http://daryl.org", "et", 42, 5L, 1, "odio" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 5, 26, 19, 28, 46, 412, DateTimeKind.Unspecified).AddTicks(7240), 20, "https://elizabeth.name", 0, "cum", 33, 1L, 0, "quo" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 6, 23, 21, 14, 34, 712, DateTimeKind.Unspecified).AddTicks(7553), 18, "https://shanelle.com", 2, "vel", 32, 8L, "consequatur" });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2020, 3, 19, 8, 22, 55, 985, DateTimeKind.Unspecified).AddTicks(590), 9L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2019, 8, 28, 4, 0, 59, 464, DateTimeKind.Unspecified).AddTicks(944), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 2, 26, 6, 47, 35, 740, DateTimeKind.Unspecified).AddTicks(6977), 8L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 3, 2, 14, 7, 0, 532, DateTimeKind.Unspecified).AddTicks(9429), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 2, 24, 16, 47, 1, 94, DateTimeKind.Unspecified).AddTicks(936), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 1L, new DateTime(2020, 3, 23, 0, 9, 1, 974, DateTimeKind.Unspecified).AddTicks(2104), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2019, 7, 30, 16, 18, 10, 725, DateTimeKind.Unspecified).AddTicks(2802), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 4, 21, 10, 50, 9, 981, DateTimeKind.Unspecified).AddTicks(4720), 10L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 3, 5, 14, 13, 52, 120, DateTimeKind.Unspecified).AddTicks(2850), 10L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 10, 8, 10, 6, 14, 311, DateTimeKind.Unspecified).AddTicks(1437), 3L, 8L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6114), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(5976), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6284), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6270), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6309), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6303), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6330), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6324), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6350), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6344), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6369), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6363), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6388), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6381), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6407), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6401), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6426), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6419), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6444), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6438), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Glenn_Price@gmail.com", new DateTimeOffset(new DateTime(2023, 7, 1, 10, 53, 32, 165, DateTimeKind.Unspecified).AddTicks(7187), new TimeSpan(0, 3, 0, 0, 0)), "Glenn Price" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Harry2@gmail.com", new DateTimeOffset(new DateTime(2023, 2, 11, 18, 57, 10, 359, DateTimeKind.Unspecified).AddTicks(2610), new TimeSpan(0, 2, 0, 0, 0)), "Harry Adams" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Mable_Kreiger@gmail.com", new DateTimeOffset(new DateTime(2023, 4, 24, 4, 52, 44, 18, DateTimeKind.Unspecified).AddTicks(1331), new TimeSpan(0, 3, 0, 0, 0)), "Mable Kreiger" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Patty.Kris36@yahoo.com", new DateTimeOffset(new DateTime(2023, 7, 11, 0, 33, 48, 514, DateTimeKind.Unspecified).AddTicks(9267), new TimeSpan(0, 3, 0, 0, 0)), "Patty Kris" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Sabrina.Dickinson41@gmail.com", new DateTimeOffset(new DateTime(2023, 7, 12, 9, 35, 2, 978, DateTimeKind.Unspecified).AddTicks(9962), new TimeSpan(0, 3, 0, 0, 0)), "Sabrina Dickinson" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Jeremiah82@gmail.com", new DateTimeOffset(new DateTime(2023, 3, 23, 1, 12, 18, 354, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 2, 0, 0, 0)), "Jeremiah Cremin" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Lisa4@hotmail.com", new DateTimeOffset(new DateTime(2023, 1, 8, 3, 32, 41, 473, DateTimeKind.Unspecified).AddTicks(765), new TimeSpan(0, 2, 0, 0, 0)), "Lisa Bergnaum" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Jody_Gorczany53@gmail.com", new DateTimeOffset(new DateTime(2023, 3, 4, 10, 47, 51, 369, DateTimeKind.Unspecified).AddTicks(9923), new TimeSpan(0, 2, 0, 0, 0)), "Jody Gorczany" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Rosa.Macejkovic@yahoo.com", new DateTimeOffset(new DateTime(2023, 7, 28, 17, 59, 30, 671, DateTimeKind.Unspecified).AddTicks(1485), new TimeSpan(0, 3, 0, 0, 0)), "Rosa Macejkovic" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Amanda.OKeefe@yahoo.com", new DateTimeOffset(new DateTime(2022, 12, 28, 4, 54, 51, 636, DateTimeKind.Unspecified).AddTicks(3893), new TimeSpan(0, 2, 0, 0, 0)), "Amanda O'Keefe" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 1, 11, 13, 58, 10, 804, DateTimeKind.Unspecified).AddTicks(3872), 7L, "Quae reprehenderit velit nostrum. Non aspernatur e", 45, "amet", new DateTimeOffset(new DateTime(2023, 8, 9, 11, 46, 29, 25, DateTimeKind.Unspecified).AddTicks(1653), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 11, 19, 9, 37, 47, 752, DateTimeKind.Unspecified).AddTicks(5123), 1L, "Autem sed voluptatem aut laboriosam atque magnam q", 30, 1, "amet", new DateTimeOffset(new DateTime(2023, 2, 24, 19, 31, 52, 36, DateTimeKind.Unspecified).AddTicks(7426), new TimeSpan(0, 2, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 11, 11, 4, 38, 34, 510, DateTimeKind.Unspecified).AddTicks(1388), 3L, "Non beatae est sed.", 38, 0, "ut", new DateTimeOffset(new DateTime(2023, 3, 15, 10, 19, 18, 19, DateTimeKind.Unspecified).AddTicks(2165), new TimeSpan(0, 2, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 8, 9, 10, 52, 44, 890, DateTimeKind.Unspecified).AddTicks(7201), 3L, "Qui voluptatem atque quod et veniam.", 48, "sit", new DateTimeOffset(new DateTime(2022, 12, 4, 1, 22, 37, 771, DateTimeKind.Unspecified).AddTicks(804), new TimeSpan(0, 2, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 3, 20, 22, 0, 34, 985, DateTimeKind.Unspecified).AddTicks(9640), 1L, "Quo incidunt natus rerum omnis vitae.", 54, 1, "exercitationem", new DateTimeOffset(new DateTime(2023, 8, 8, 12, 36, 50, 967, DateTimeKind.Unspecified).AddTicks(6281), new TimeSpan(0, 3, 0, 0, 0)), 7L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 10, 24, 6, 11, 7, 626, DateTimeKind.Unspecified).AddTicks(9626), 9L, "Et dolorum aut doloremque quo.", 11, 1, "sit", new DateTimeOffset(new DateTime(2023, 8, 12, 6, 25, 12, 712, DateTimeKind.Unspecified).AddTicks(8740), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 4, 12, 19, 29, 0, 589, DateTimeKind.Unspecified).AddTicks(7914), 1L, "Et nemo quam nulla suscipit delectus consequatur e", 47, 1, "amet", new DateTimeOffset(new DateTime(2022, 11, 13, 13, 47, 30, 146, DateTimeKind.Unspecified).AddTicks(3614), new TimeSpan(0, 2, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 11, 3, 20, 50, 405, DateTimeKind.Unspecified).AddTicks(1470), 4L, "Et sed sit aliquid ut doloribus atque quo optio.\nD", 30, "labore", new DateTimeOffset(new DateTime(2022, 10, 26, 23, 26, 7, 197, DateTimeKind.Unspecified).AddTicks(5736), new TimeSpan(0, 3, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 6, 1, 9, 51, 23, 904, DateTimeKind.Unspecified).AddTicks(2685), 5L, "maxime", 60, "laudantium", new DateTimeOffset(new DateTime(2023, 4, 22, 8, 35, 59, 647, DateTimeKind.Unspecified).AddTicks(6354), new TimeSpan(0, 3, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 5, 24, 6, 18, 15, 139, DateTimeKind.Unspecified).AddTicks(7706), 2L, "Eum minima possimus et voluptatibus est aspernatur", 24, 0, "sed", new DateTimeOffset(new DateTime(2022, 12, 19, 18, 15, 47, 943, DateTimeKind.Unspecified).AddTicks(1185), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Text",
                value: "Voluptas et cumque nihil sunt dolor voluptatem suscipit incidunt tenetur.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Dolor est mollitia rerum.\nOmnis neque incidunt omnis facere non.\nEst ut deserunt hic fugit voluptatem eum voluptas ut et." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Non officia molestiae.\nAlias consectetur voluptate sit ex veniam consequuntur eos occaecati.\nEst dolor quia." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Quo aut similique recusandae aut. Ut ab laborum laborum aspernatur. Aut explicabo quas totam qui voluptas quo quia quaerat. Dignissimos et nostrum et quidem nemo blanditiis. Hic et repellat laboriosam voluptatibus consequuntur et voluptatem. Enim explicabo voluptatem qui sapiente sed unde similique" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Et omnis qui quia culpa cumque veritatis occaecati.\nAperiam non nihil tempore voluptatum.\nEst nostrum est.\nQuos aut deserunt iusto omnis repellat asperiores et iste placeat.\nIllo ut dolore aut ut.\nNobis et sunt sequi rerum." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Dolorem sapiente est aperiam soluta voluptas rerum." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Magni et reiciendis. Quidem tempore ex dolor ex nulla est corporis distinctio laborum. Natus sit voluptatibus saepe fugit id ipsum." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Incidunt voluptatem autem.\nQuia provident natus repudiandae nobis accusantium impedit.\nAliquid blanditiis labore in magni non quaerat id qui aut.\nIllum aliquam omnis." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "quibusdamAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Est in quae.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

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
                value: 4);

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
                value: 5);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Priority",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Priority",
                value: 3);

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
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Priority",
                value: 6);

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
                column: "Role",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Role",
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
                keyValue: 5L,
                column: "Role",
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
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Autem voluptas nobis doloribus quia aperiam est inventore saepe.\nDignissimos quibusdam assumenda itaque consequuntur veritatis.\nAspernatur animi numquam et qui pariatur.", "Crist LLC", "https://jamaal.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Enim maiores sunt fugiat voluptatibus totam est quo ipsum.", "Rohan, Hackett and Corkery", "http://dorothea.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Ipsa eos non.\nSit reprehenderit dolorum iusto rerum occaecati quia dignissimos.", "Schowalter LLC", "http://eunice.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Nulla necessitatibus sit cumque eius saepe nihil laborum eveniet non.", "Funk Group", "http://rosemarie.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "voluptates", "Weber Group", "http://kieran.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Ducimus officia ut qui necessitatibus. Labore nulla eius inventore a ut veritatis est. Quia nostrum a dicta dignissimos pariatur autem accusantium maiores molestiae. Minima vel minima distinctio. Iste omnis repudiandae officiis enim non omnis occaecati non.", "Halvorson, Dooley and VonRueden", "http://ignatius.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Quas harum praesentium autem dolorem quia magnam dolorem optio nihil.", "Lubowitz, Schaden and Volkman", "https://pierre.name" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Quia veritatis at natus assumenda.\nRatione ipsam fugit.\nSimilique asperiores asperiores.\nMollitia minima amet tempore quia repellat neque.\nVelit nulla numquam magni eum fuga dolores et.", "Treutel, Dietrich and Pacocha", "http://dillon.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Sed sed omnis dolor voluptatem libero sunt nobis.\nId culpa et cupiditate voluptatem.\nNesciunt voluptates odit quas quos at quibusdam odit omnis nostrum.\nIpsa quas eos enim omnis modi porro.\nQuod quod autem laborum.", "Reichert and Sons", "http://katarina.name" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Autem voluptates autem optio nostrum optio.", "Klocko, Cassin and Nolan", "https://jovani.net" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Morris_Mosciski@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1013.jpg", "Morris Mosciski", "520.634.86", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Shane8@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/287.jpg", "Shane Shanahan", "1-885-775-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Warren_Steuber@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/714.jpg", "Warren Steuber", "1-953-932-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Rochelle_Mohr@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/70.jpg", "Rochelle Mohr", "478-306-14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Deborah.Yundt@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/525.jpg", "Deborah Yundt", "462-638-47" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Gregory89@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/190.jpg", "Gregory Herman", "920-521-27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Alton_Weissnat@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/856.jpg", "Alton Weissnat", "270-395-99", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Marilyn76@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/949.jpg", "Marilyn Cremin", "1-250-886-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Toby69@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/252.jpg", "Toby Stark", "1-417-464-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Jessie72@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1056.jpg", "Jessie Graham", "(830) 378-" });
        }
    }
}
