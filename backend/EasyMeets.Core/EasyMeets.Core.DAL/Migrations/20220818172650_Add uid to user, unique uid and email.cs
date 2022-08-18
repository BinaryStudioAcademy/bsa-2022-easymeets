using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class Adduidtouseruniqueuidandemail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Uid",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 6, 18, 1, 4, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 5, 15, 3, 5 });

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
                columns: new[] { "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 4, 19, 2, 13 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 9, 5, 4, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Days", "MinBookingMeetingDifference" },
                values: new object[] { 2, 7, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 8, 26, 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 30, 10, 3, 15 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 2, 3, 0, 28, 15, 611, DateTimeKind.Unspecified).AddTicks(1536), 17, "http://walker.net", "voluptatibus", 49, 7L, "Soluta enim officia voluptatum soluta. Excepturi id fugiat ut odit odio tenetur molestiae. Omnis maxime sit eum mollitia tempora saepe dolor et itaque. Et quidem quis esse maxime." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 2, 10, 10, 40, 30, 339, DateTimeKind.Unspecified).AddTicks(296), 28, "https://kacie.info", 2, "eligendi", 24, 10L, "Voluptate maxime libero omnis quis aut architecto." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 3, 6, 13, 9, 16, 420, DateTimeKind.Unspecified).AddTicks(7170), "https://brandy.name", 2, "ipsum", 36, 6L, 1, "Cupiditate soluta recusandae est sit dolore qui officia.\nProvident dolore et.\nFacere cupiditate autem voluptatibus sequi ipsam quaerat.\nEst repudiandae et magni ut expedita qui soluta.\nDebitis facilis sint labore fugit non dolorem dolores consequuntur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 5, 19, 22, 5, 12, 532, DateTimeKind.Unspecified).AddTicks(314), 17, "https://reyes.com", "porro", 26, 1L, 0, "cumque" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2019, 12, 1, 21, 19, 26, 793, DateTimeKind.Unspecified).AddTicks(2905), 24, "https://hermina.org", "maxime", 24, 9L, "Doloribus esse ea quia natus sunt molestiae ea dolores. Repellat nisi et veniam nihil nihil voluptas maiores. Iure in ut aut. Inventore et debitis. Perspiciatis labore non assumenda delectus minus optio saepe. Eveniet doloribus animi neque quia praesentium dignissimos qui." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 9, 28, 12, 30, 14, 131, DateTimeKind.Unspecified).AddTicks(6401), 24, "http://therese.info", "saepe", 45, 7L, "Quo architecto et consectetur sit animi vel alias omnis." });

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
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Size", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2019, 12, 20, 1, 50, 50, 192, DateTimeKind.Unspecified).AddTicks(2560), 18, "http://daryl.org", 2, 42, 1, "odio" });

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
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 6, 23, 21, 14, 34, 712, DateTimeKind.Unspecified).AddTicks(7553), 18, "https://shanelle.com", 2, "vel", 32, 8L, "consequatur" });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 4L, new DateTime(2020, 2, 26, 6, 47, 35, 740, DateTimeKind.Unspecified).AddTicks(6977), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 3, 2, 14, 7, 0, 532, DateTimeKind.Unspecified).AddTicks(9429), 8L, 5L });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 3, 5, 14, 13, 52, 120, DateTimeKind.Unspecified).AddTicks(2850), 7L });

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
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6284), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 19, 20, 26, 48, 460, DateTimeKind.Unspecified).AddTicks(6270), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Jeremiah82@gmail.com", new DateTimeOffset(new DateTime(2023, 3, 23, 1, 12, 18, 354, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 2, 0, 0, 0)), "Jeremiah Cremin" });

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
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Rosa.Macejkovic@yahoo.com", new DateTimeOffset(new DateTime(2023, 7, 28, 17, 59, 30, 671, DateTimeKind.Unspecified).AddTicks(1485), new TimeSpan(0, 3, 0, 0, 0)), "Rosa Macejkovic" });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime" },
                values: new object[] { new DateTime(2020, 1, 11, 13, 58, 10, 804, DateTimeKind.Unspecified).AddTicks(3872), 7L, "Quae reprehenderit velit nostrum. Non aspernatur e", 45, 2, "amet", new DateTimeOffset(new DateTime(2023, 8, 9, 11, 46, 29, 25, DateTimeKind.Unspecified).AddTicks(1653), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 11, 11, 4, 38, 34, 510, DateTimeKind.Unspecified).AddTicks(1388), 3L, "Non beatae est sed.", 38, new DateTimeOffset(new DateTime(2023, 3, 15, 10, 19, 18, 19, DateTimeKind.Unspecified).AddTicks(2165), new TimeSpan(0, 2, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 8, 9, 10, 52, 44, 890, DateTimeKind.Unspecified).AddTicks(7201), 3L, "Qui voluptatem atque quod et veniam.", 48, 0, "sit", new DateTimeOffset(new DateTime(2022, 12, 4, 1, 22, 37, 771, DateTimeKind.Unspecified).AddTicks(804), new TimeSpan(0, 2, 0, 0, 0)), 6L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 4, 12, 19, 29, 0, 589, DateTimeKind.Unspecified).AddTicks(7914), 1L, "Et nemo quam nulla suscipit delectus consequatur e", 47, "amet", new DateTimeOffset(new DateTime(2022, 11, 13, 13, 47, 30, 146, DateTimeKind.Unspecified).AddTicks(3614), new TimeSpan(0, 2, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 11, 3, 20, 50, 405, DateTimeKind.Unspecified).AddTicks(1470), 4L, "Et sed sit aliquid ut doloribus atque quo optio.\nD", 30, 2, "labore", new DateTimeOffset(new DateTime(2022, 10, 26, 23, 26, 7, 197, DateTimeKind.Unspecified).AddTicks(5736), new TimeSpan(0, 3, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 6, 1, 9, 51, 23, 904, DateTimeKind.Unspecified).AddTicks(2685), 5L, "maxime", 60, 1, "laudantium", new DateTimeOffset(new DateTime(2023, 4, 22, 8, 35, 59, 647, DateTimeKind.Unspecified).AddTicks(6354), new TimeSpan(0, 3, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 5, 24, 6, 18, 15, 139, DateTimeKind.Unspecified).AddTicks(7706), "Eum minima possimus et voluptatibus est aspernatur", 24, 0, "sed", new DateTimeOffset(new DateTime(2022, 12, 19, 18, 15, 47, 943, DateTimeKind.Unspecified).AddTicks(1185), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Voluptas et cumque nihil sunt dolor voluptatem suscipit incidunt tenetur." });

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
                keyValue: 6L,
                column: "Priority",
                value: 5);

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
                keyValue: 5L,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Role",
                value: 2);

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Morris_Mosciski@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1013.jpg", "Morris Mosciski", "520.634.86" });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Warren_Steuber@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/714.jpg", "Warren Steuber", "1-953-932-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Rochelle_Mohr@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/70.jpg", "Rochelle Mohr", "478-306-14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Deborah.Yundt@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/525.jpg", "Deborah Yundt", "462-638-47", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Gregory89@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/190.jpg", "Gregory Herman", "920-521-27", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Alton_Weissnat@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/856.jpg", "Alton Weissnat", "270-395-99", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Marilyn76@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/949.jpg", "Marilyn Cremin", "1-250-886-", 0 });

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Uid",
                table: "Users",
                column: "Uid",
                unique: true,
                filter: "[Uid] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Uid",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Uid",
                table: "Users");

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
                columns: new[] { "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 26, 2, 4 });

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
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 3, 26, 2, 4, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 11, 4, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 27, 4, 1, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Days", "MinBookingMeetingDifference" },
                values: new object[] { 1, 25, 1 });

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
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 19, 5, 4, 9 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 10, 25, 3, 34, 5, 290, DateTimeKind.Unspecified).AddTicks(972), 15, "https://caroline.name", "animi", 44, 4L, "Quia delectus facere non.\nHarum facilis assumenda accusamus qui sed et repellat vero dolores.\nLibero et qui facilis sed nobis ut.\nQuaerat iure perferendis placeat aliquam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 7, 22, 23, 58, 11, 273, DateTimeKind.Unspecified).AddTicks(6525), 17, "http://antonia.org", 1, "illo", 22, 7L, "Ut voluptatibus dolore necessitatibus dolores soluta nihil. Et omnis nobis rem qui accusamus rerum aut a vero. Voluptatum quos voluptatem tenetur officiis non sint sit quia." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2019, 8, 10, 15, 10, 12, 718, DateTimeKind.Unspecified).AddTicks(4011), "http://lindsey.org", 1, "officia", 33, 5L, 0, "Veritatis sed saepe." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 10, 11, 18, 43, 57, 540, DateTimeKind.Unspecified).AddTicks(532), 30, "https://madalyn.org", "esse", 48, 4L, 1, "Architecto suscipit ratione voluptatem aut ut iusto aut voluptates.\nSit ea et non omnis consectetur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 7, 6, 20, 0, 0, 590, DateTimeKind.Unspecified).AddTicks(2067), 28, "http://jeff.com", "voluptates", 30, 4L, "Laborum necessitatibus molestiae voluptate libero." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 6, 5, 17, 56, 55, 88, DateTimeKind.Unspecified).AddTicks(4080), 23, "https://cielo.biz", "eligendi", 50, 4L, "Dolorem provident aut rerum non.\nRatione explicabo doloribus omnis autem deleniti.\nQuo iste deleniti omnis minus voluptatem eaque.\nMinus non labore aut et ea.\nCorporis molestiae facilis et ut ut rerum dolorem aut provident.\nEaque omnis quos dolore aliquid magnam culpa." });

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
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Size", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 1, 22, 6, 42, 43, 754, DateTimeKind.Unspecified).AddTicks(6794), 16, "http://petra.net", 0, 53, 0, "Minima consequatur est eos." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 1, 2, 15, 49, 41, 765, DateTimeKind.Unspecified).AddTicks(3875), 15, "https://ronny.name", 2, "error", 31, 10L, 1, "Non aut et et. Architecto molestiae ut dolor veritatis velit. Eos qui hic omnis velit velit consequatur suscipit totam quo. Omnis facilis sunt et iusto omnis deserunt. Repudiandae qui ipsam facere est vero aspernatur amet." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 2, 7, 11, 54, 54, 533, DateTimeKind.Unspecified).AddTicks(601), 28, "https://antoinette.biz", 1, "ab", 38, 2L, "Corporis laboriosam maiores. Voluptatem necessitatibus vel atque eum quia voluptatem soluta iusto. Aut perspiciatis dolores dignissimos voluptates provident. Quia ea corporis dignissimos." });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 5L, new DateTime(2021, 6, 15, 20, 41, 27, 659, DateTimeKind.Unspecified).AddTicks(2725), 6L });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2021, 4, 22, 2, 58, 9, 460, DateTimeKind.Unspecified).AddTicks(2220), 5L });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 12, 20, 7, 37, 42, 161, DateTimeKind.Unspecified).AddTicks(4263), 8L });

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
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4148), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(3918), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Jon1@gmail.com", new DateTimeOffset(new DateTime(2023, 5, 19, 23, 25, 31, 980, DateTimeKind.Unspecified).AddTicks(9724), new TimeSpan(0, 3, 0, 0, 0)), "Jon Johnson" });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime" },
                values: new object[] { new DateTime(2020, 9, 27, 1, 10, 3, 194, DateTimeKind.Unspecified).AddTicks(6623), 8L, "Enim voluptate illo numquam officia molestiae ut.", 50, 1, "rem", new DateTimeOffset(new DateTime(2022, 8, 18, 13, 52, 42, 457, DateTimeKind.Unspecified).AddTicks(9679), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 9, 9, 8, 3, 23, 135, DateTimeKind.Unspecified).AddTicks(964), 7L, "Quibusdam nostrum officia doloribus inventore.", 16, new DateTimeOffset(new DateTime(2023, 7, 29, 11, 34, 36, 201, DateTimeKind.Unspecified).AddTicks(9616), new TimeSpan(0, 3, 0, 0, 0)), 1L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 10, 8, 20, 36, 29, 361, DateTimeKind.Unspecified).AddTicks(9716), 5L, "Est qui officia cupiditate nihil ut nam aperiam do", 49, 2, "corrupti", new DateTimeOffset(new DateTime(2022, 8, 19, 4, 48, 34, 628, DateTimeKind.Unspecified).AddTicks(6571), new TimeSpan(0, 3, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 6, 4, 50, 6, 354, DateTimeKind.Unspecified).AddTicks(8662), 3L, "Aliquid soluta laborum voluptatem velit autem et v", 56, 0, "sint", new DateTimeOffset(new DateTime(2023, 2, 13, 9, 25, 32, 223, DateTimeKind.Unspecified).AddTicks(5637), new TimeSpan(0, 2, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 19, 8, 15, 50, 976, DateTimeKind.Unspecified).AddTicks(3511), 4L, "Aut eum nisi ut inventore voluptates.", 17, "sit", new DateTimeOffset(new DateTime(2023, 6, 25, 18, 55, 8, 316, DateTimeKind.Unspecified).AddTicks(9309), new TimeSpan(0, 3, 0, 0, 0)), 2L });

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
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 18, 16, 3, 38, 99, DateTimeKind.Unspecified).AddTicks(7311), "Doloremque blanditiis illum est iste incidunt volu", 54, 2, "corporis", new DateTimeOffset(new DateTime(2023, 5, 25, 2, 39, 35, 753, DateTimeKind.Unspecified).AddTicks(3874), new TimeSpan(0, 3, 0, 0, 0)), 10L });

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
                keyValue: 5L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Role",
                value: 1);

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Joann.Waters91@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/156.jpg", "Joann Waters", "758-647-50" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Jimmy.Strosin38@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1003.jpg", "Jimmy Strosin", "792-733-78", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Jane.Hand@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/969.jpg", "Jane Hand", "1-360-471-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Faith_Bergstrom@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/449.jpg", "Faith Bergstrom", "1-767-387-" });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Vincent_Gorczany90@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/840.jpg", "Vincent Gorczany", "832-797-95", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Genevieve0@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/348.jpg", "Genevieve Pfannerstill", "(406) 715-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Horace_Rempel@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/609.jpg", "Horace Rempel", "1-378-467-", 1 });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Robert56@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/672.jpg", "Robert Witting", "804-371-92" });
        }
    }
}
