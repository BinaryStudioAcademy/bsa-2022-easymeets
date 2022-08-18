using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class MigrationWithFixedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 4, 1, 5, 6 });

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
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 8, 5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 10, 1, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 19, 10, 5, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 3, 6, 5, 10 });

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
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 4, 12, 0, 48, 41, 913, DateTimeKind.Unspecified).AddTicks(5030), 16, "https://shanny.net", 0, "doloremque", 46, 3L, "Corrupti adipisci reprehenderit unde consequatur explicabo aliquid deserunt aut." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 7, 20, 4, 15, 16, 989, DateTimeKind.Unspecified).AddTicks(9505), 16, "http://lempi.org", 2, "explicabo", 53, 7L, 0, "Consequatur optio iste." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 2, 29, 3, 39, 18, 61, DateTimeKind.Unspecified).AddTicks(441), "http://holden.com", 1, "quia", 38, 5L, "Aliquid beatae cumque.\nVoluptatem quia qui qui velit quibusdam placeat." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 5, 28, 6, 12, 57, 71, DateTimeKind.Unspecified).AddTicks(7964), 15, "https://nayeli.com", 1, "quos", 39, 10L, "Ut est nesciunt non numquam accusantium." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 1, 21, 18, 4, 26, 614, DateTimeKind.Unspecified).AddTicks(4361), 18, "http://floy.net", 1, "odit", 41, 10L, 1, "voluptate" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 3, 8, 5, 15, 30, 784, DateTimeKind.Unspecified).AddTicks(1106), 27, "https://tyreek.org", "quasi", 33, 10L, 0, "Eius labore esse neque labore dolor quia saepe.\nInventore aut fuga.\nDebitis quo velit voluptatem rerum.\nVitae voluptatem quia iste itaque officia.\nExercitationem dolor repudiandae nihil alias asperiores nam quis voluptate sit.\nNon accusamus qui ut modi ea et." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 6, 11, 1, 41, 54, 366, DateTimeKind.Unspecified).AddTicks(7577), 30, "http://kieran.biz", "quia", 33, 1, "nobis" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 8, 3, 16, 40, 44, 206, DateTimeKind.Unspecified).AddTicks(691), 20, "https://ara.name", "necessitatibus", 26, 9L, "Et odit sit mollitia nulla aspernatur voluptas." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 6, 6, 7, 15, 43, 941, DateTimeKind.Unspecified).AddTicks(5293), 28, "https://avis.name", 2, "aut", 58, "enim" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 11, 21, 16, 22, 26, 916, DateTimeKind.Unspecified).AddTicks(2247), 29, "https://casey.name", 0, "voluptatibus", 43, 6L, 0, "sunt" });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2019, 10, 14, 3, 44, 21, 857, DateTimeKind.Unspecified).AddTicks(6664), 8L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 5, 22, 2, 45, 51, 178, DateTimeKind.Unspecified).AddTicks(1754), 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt" },
                values: new object[] { 5L, new DateTime(2019, 10, 17, 13, 4, 55, 428, DateTimeKind.Unspecified).AddTicks(4202) });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 5, 3, 1, 4, 9, 423, DateTimeKind.Unspecified).AddTicks(571), 6L });

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
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(8318), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(7991), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(8731), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(8707), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(8790), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(8777), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(8825), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(8813), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(8884), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(8862), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(8942), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(8931), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(8973), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(8962), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(9090), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(9071), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(9127), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(9116), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(9179), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 59, 0, 650, DateTimeKind.Unspecified).AddTicks(9157), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Donald_Hills@yahoo.com", new DateTimeOffset(new DateTime(2022, 11, 23, 16, 0, 0, 427, DateTimeKind.Unspecified).AddTicks(6114), new TimeSpan(0, 2, 0, 0, 0)), "Donald Hills" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Leonard62@hotmail.com", new DateTimeOffset(new DateTime(2022, 12, 17, 14, 8, 55, 463, DateTimeKind.Unspecified).AddTicks(658), new TimeSpan(0, 2, 0, 0, 0)), "Leonard Effertz" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Dewey_Schuppe@yahoo.com", new DateTimeOffset(new DateTime(2022, 9, 9, 16, 38, 6, 281, DateTimeKind.Unspecified).AddTicks(9358), new TimeSpan(0, 3, 0, 0, 0)), "Dewey Schuppe" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Elijah.Blanda@gmail.com", new DateTimeOffset(new DateTime(2023, 4, 2, 22, 33, 2, 232, DateTimeKind.Unspecified).AddTicks(6749), new TimeSpan(0, 3, 0, 0, 0)), "Elijah Blanda" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Joel_Goldner@hotmail.com", new DateTimeOffset(new DateTime(2023, 2, 22, 16, 5, 16, 914, DateTimeKind.Unspecified).AddTicks(761), new TimeSpan(0, 2, 0, 0, 0)), "Joel Goldner" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Jaime.Veum2@hotmail.com", new DateTimeOffset(new DateTime(2022, 12, 20, 8, 22, 49, 558, DateTimeKind.Unspecified).AddTicks(1740), new TimeSpan(0, 2, 0, 0, 0)), "Jaime Veum" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Patti.Feil@yahoo.com", new DateTimeOffset(new DateTime(2023, 7, 6, 14, 7, 2, 975, DateTimeKind.Unspecified).AddTicks(6075), new TimeSpan(0, 3, 0, 0, 0)), "Patti Feil" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Jesus9@hotmail.com", new DateTimeOffset(new DateTime(2023, 1, 6, 10, 0, 46, 103, DateTimeKind.Unspecified).AddTicks(1378), new TimeSpan(0, 2, 0, 0, 0)), "Jesus Gorczany" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Jacob.Ondricka6@yahoo.com", new DateTimeOffset(new DateTime(2023, 3, 28, 4, 43, 54, 763, DateTimeKind.Unspecified).AddTicks(7167), new TimeSpan(0, 3, 0, 0, 0)), "Jacob Ondricka" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Erma.MacGyver86@hotmail.com", new DateTimeOffset(new DateTime(2023, 4, 6, 14, 37, 30, 720, DateTimeKind.Unspecified).AddTicks(7384), new TimeSpan(0, 3, 0, 0, 0)), "Erma MacGyver" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 6, 15, 11, 55, 19, 331, DateTimeKind.Unspecified).AddTicks(2144), 5L, "doloremque", 19, 2, "ut", new DateTimeOffset(new DateTime(2023, 1, 8, 21, 15, 17, 283, DateTimeKind.Unspecified).AddTicks(5212), new TimeSpan(0, 2, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 13, 19, 29, 31, 675, DateTimeKind.Unspecified).AddTicks(5836), 8L, "aliquid", 54, 0, "consequatur", new DateTimeOffset(new DateTime(2023, 5, 5, 15, 46, 15, 62, DateTimeKind.Unspecified).AddTicks(6206), new TimeSpan(0, 3, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 24, 10, 18, 7, 49, DateTimeKind.Unspecified).AddTicks(3480), 9L, "atque", 14, 2, "soluta", new DateTimeOffset(new DateTime(2022, 12, 16, 14, 28, 25, 639, DateTimeKind.Unspecified).AddTicks(5670), new TimeSpan(0, 2, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 29, 3, 39, 18, 61, DateTimeKind.Unspecified).AddTicks(441), 6L, "Id repudiandae odit quo aut quisquam.\nQuam et quia", 30, 0, "consequatur", new DateTimeOffset(new DateTime(2022, 10, 25, 16, 31, 14, 880, DateTimeKind.Unspecified).AddTicks(4240), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 18, 7, 5, 24, 18, DateTimeKind.Unspecified).AddTicks(9612), 10L, "Iusto atque ut est nesciunt non.", 48, 0, "doloribus", new DateTimeOffset(new DateTime(2022, 9, 14, 17, 43, 24, 537, DateTimeKind.Unspecified).AddTicks(9866), new TimeSpan(0, 3, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 24, 6, 10, 0, 75, DateTimeKind.Unspecified).AddTicks(7738), "fuga", 15, "cupiditate", new DateTimeOffset(new DateTime(2022, 8, 19, 0, 29, 34, 873, DateTimeKind.Unspecified).AddTicks(6957), new TimeSpan(0, 3, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 20, 13, 30, 18, 913, DateTimeKind.Unspecified).AddTicks(9011), 7L, "Libero sunt modi sint dolore doloribus ipsa quasi.", 21, 2, "fugit", new DateTimeOffset(new DateTime(2022, 11, 14, 17, 51, 9, 962, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 2, 0, 0, 0)), 7L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 18, 3, 54, 1, 72, DateTimeKind.Unspecified).AddTicks(6702), 1L, "dolor", 12, "neque", new DateTimeOffset(new DateTime(2023, 6, 8, 21, 53, 27, 512, DateTimeKind.Unspecified).AddTicks(2302), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 8, 5, 0, 36, 4, 341, DateTimeKind.Unspecified).AddTicks(3092), 3L, "Voluptatem rerum esse vitae. Quia iste itaque offi", 55, "quaerat", new DateTimeOffset(new DateTime(2023, 1, 9, 12, 26, 17, 701, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 3, 8, 21, 11, 859, DateTimeKind.Unspecified).AddTicks(9966), 5L, "vel", 35, 2, "ullam", new DateTimeOffset(new DateTime(2023, 4, 4, 13, 19, 19, 14, DateTimeKind.Unspecified).AddTicks(3345), new TimeSpan(0, 3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "doloremqueAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

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
                column: "Text",
                value: "harumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

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
                keyValue: 6L,
                column: "Priority",
                value: 5);

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

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
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Albert39@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1239.jpg", "Albert Barrows", "287.766.04" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Tyrone2@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1236.jpg", "Tyrone Gleason", "1-259-731-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Flora57@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/808.jpg", "Flora Abernathy", "489-790-47" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Sonja98@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/186.jpg", "Sonja Spinka", "392-637-49", 1 });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Chelsea_Mertz96@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/954.jpg", "Chelsea Mertz", "(258) 515-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Clinton.Hayes95@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1101.jpg", "Clinton Hayes", "(504) 681-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Randall9@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/481.jpg", "Randall Wintheiser", "897-873-88", 0 });

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
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Leona86@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/790.jpg", "Leona Cronin", "947.872.74" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 7, 4, 3, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 6, 28, 7, 5, 14 });

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
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 2, 7, 3, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 23, 5, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 10, 9, 4, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 1, 3, 4, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 8, 14, 6, 5, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 3, 2, 14, 3, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 2, 6, 9, 1, 9 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 1, 3, 15, 58, 47, 553, DateTimeKind.Unspecified).AddTicks(9611), 18, "http://gwendolyn.net", 2, "distinctio", 17, 4L, "reprehenderit" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 6, 17, 10, 40, 22, 974, DateTimeKind.Unspecified).AddTicks(4345), 17, "http://delphine.name", 0, "aperiam", 48, 10L, 1, "Consequuntur nemo suscipit tempora nobis quam.\nOfficiis et debitis nisi nesciunt velit qui enim veniam.\nBeatae adipisci nesciunt a aperiam.\nVoluptas et sunt ab unde doloremque harum.\nVelit eos molestias quo." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 4, 21, 14, 17, 36, 438, DateTimeKind.Unspecified).AddTicks(9593), "https://jade.org", 2, "numquam", 55, 6L, "Rem quia temporibus.\nLaudantium facere voluptatibus aliquid voluptatem unde sit eum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 5, 9, 15, 36, 46, 41, DateTimeKind.Unspecified).AddTicks(524), 30, "http://lon.info", 2, "dolorem", 23, 2L, "dolor" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 4, 19, 12, 52, 8, 162, DateTimeKind.Unspecified).AddTicks(4453), 25, "http://reba.biz", 0, "voluptas", 42, 5L, 0, "Quam temporibus sit suscipit atque amet porro autem. Ipsum laborum sequi quo voluptas. Quia commodi voluptatem nobis a et. Natus quis incidunt vel reiciendis earum quia." });

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
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 1, 25, 20, 5, 42, 625, DateTimeKind.Unspecified).AddTicks(5328), 25, "http://elwyn.org", "est", 38, 0, "Qui consectetur nemo doloremque molestias deleniti dolores cupiditate modi.\nAut magni nesciunt ut sed hic odit.\nEaque doloribus aut facilis fugiat dolorem sunt dignissimos autem excepturi." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2019, 7, 22, 18, 23, 57, 148, DateTimeKind.Unspecified).AddTicks(8824), 22, "https://foster.org", "eaque", 45, 6L, "Recusandae voluptatem ab architecto sit sed voluptatum molestiae." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2019, 9, 29, 10, 13, 27, 977, DateTimeKind.Unspecified).AddTicks(5524), 26, "http://marietta.info", 1, "id", 35, "Quo deserunt tenetur. Libero dignissimos consequuntur sapiente non a. Vel et quo et consequatur aut quaerat." });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2019, 9, 17, 16, 23, 33, 981, DateTimeKind.Unspecified).AddTicks(4321), 7L, 8L });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 8, 3, 1, 13, 48, 433, DateTimeKind.Unspecified).AddTicks(5757), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt" },
                values: new object[] { 1L, new DateTime(2021, 1, 27, 12, 6, 19, 218, DateTimeKind.Unspecified).AddTicks(1539) });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2020, 7, 11, 10, 30, 39, 969, DateTimeKind.Unspecified).AddTicks(4676), 9L });

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
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Bradford.Mayert19@hotmail.com", new DateTimeOffset(new DateTime(2022, 12, 2, 13, 33, 42, 451, DateTimeKind.Unspecified).AddTicks(941), new TimeSpan(0, 2, 0, 0, 0)), "Bradford Mayert" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Jacob.Torp5@hotmail.com", new DateTimeOffset(new DateTime(2023, 7, 17, 2, 6, 24, 492, DateTimeKind.Unspecified).AddTicks(8815), new TimeSpan(0, 3, 0, 0, 0)), "Jacob Torp" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Natasha.Volkman95@yahoo.com", new DateTimeOffset(new DateTime(2023, 5, 15, 18, 44, 2, 156, DateTimeKind.Unspecified).AddTicks(2756), new TimeSpan(0, 3, 0, 0, 0)), "Natasha Volkman" });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 51, 2, 604, DateTimeKind.Unspecified).AddTicks(6005), 9L, "Repellendus earum qui est rem.\nPossimus beatae hic", 59, 1, "non", new DateTimeOffset(new DateTime(2023, 3, 6, 16, 12, 50, 647, DateTimeKind.Unspecified).AddTicks(3742), new TimeSpan(0, 2, 0, 0, 0)), 9L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 2, 14, 9, 31, 53, 263, DateTimeKind.Unspecified).AddTicks(185), 2L, "consequuntur", 47, 2, "assumenda", new DateTimeOffset(new DateTime(2022, 12, 11, 3, 20, 59, 243, DateTimeKind.Unspecified).AddTicks(2635), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 3, 15, 22, 20, 45, 708, DateTimeKind.Unspecified).AddTicks(1170), "qui", 35, "eligendi", new DateTimeOffset(new DateTime(2023, 3, 24, 9, 56, 34, 454, DateTimeKind.Unspecified).AddTicks(1802), new TimeSpan(0, 2, 0, 0, 0)), 3L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 7, 13, 7, 15, 15, 234, DateTimeKind.Unspecified).AddTicks(2690), 4L, "Officiis aliquam nulla fugiat facere laudantium mi", 24, "corporis", new DateTimeOffset(new DateTime(2022, 12, 3, 6, 2, 27, 575, DateTimeKind.Unspecified).AddTicks(9517), new TimeSpan(0, 2, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 11, 8, 12, 56, 49, 256, DateTimeKind.Unspecified).AddTicks(9278), 10L, "Id eum sunt totam porro voluptatem voluptatem quae", 14, "perferendis", new DateTimeOffset(new DateTime(2023, 2, 1, 22, 16, 26, 817, DateTimeKind.Unspecified).AddTicks(4630), new TimeSpan(0, 2, 0, 0, 0)), 4L });

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
                column: "Text",
                value: "Maiores consequatur quos nam aspernatur. Et sit minus repudiandae repellat sint eum. Vel ea expedita sed veritatis dicta vitae voluptas quo.");

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

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
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Krista.Schoen41@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1198.jpg", "Krista Schoen", "1-529-765-" });

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
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Dana74@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/838.jpg", "Dana King", "887.620.75" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Mable_Rutherford@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/778.jpg", "Mable Rutherford", "608-293-16", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Nick.Yost@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1024.jpg", "Nick Yost", "1-953-915-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Enrique.Glover43@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/211.jpg", "Enrique Glover", "702.811.43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Susan93@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/995.jpg", "Susan Waters", "1-981-429-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Belinda_Larson65@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/254.jpg", "Belinda Larson", "475.868.38", 1 });

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
    }
}
