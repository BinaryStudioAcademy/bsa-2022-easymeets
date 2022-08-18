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
                values: new object[] { 1, 5, 27, 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 5, 14, 7, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 1, 23, 7, 3, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 2, 25, 2, 3, 12 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 2, 6, 29, 4, 7 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 8, 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 6, 5, 10, 3, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 13, 10, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 24, 5, 2, 12 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 29, 8, 3, 6 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 12, 6, 9, 28, 33, 390, DateTimeKind.Unspecified).AddTicks(1075), 24, "https://rowland.info", 0, "repudiandae", 28, 3L, 1, "Veritatis et nihil sit natus in." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 3, 28, 1, 24, 29, 72, DateTimeKind.Unspecified).AddTicks(7498), 19, "https://scottie.org", 0, "magni", 51, 2L, 1, "Atque repellendus necessitatibus dolorem illo velit." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2019, 8, 22, 20, 10, 29, 489, DateTimeKind.Unspecified).AddTicks(8042), "https://rosalee.info", 2, "rerum", 24, 2L, 1, "Eum fugiat molestiae libero quia aperiam consequatur rerum quam consequuntur.\nVelit ut aut architecto vero rerum debitis nulla.\nNemo aliquid ut id soluta incidunt repellat iste.\nEt ad debitis ea facere.\nBlanditiis quis quo fugit qui et." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 5, 24, 12, 20, 29, 742, DateTimeKind.Unspecified).AddTicks(3674), 24, "https://anika.com", 1, "cum", 21, 7L, "Est et ipsa. Debitis occaecati ut. Ratione vitae nesciunt." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2021, 6, 1, 6, 10, 50, 939, DateTimeKind.Unspecified).AddTicks(421), 30, "http://gilberto.com", 0, "labore", 22, 6L, 1, "Sapiente dolor est aut aut illo aspernatur odio ut.\nFacilis quaerat voluptatibus vel ut est aut quas." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 11, 10, 2, 55, 18, 57, DateTimeKind.Unspecified).AddTicks(4071), "https://jaeden.biz", 1, "corrupti", 32, 9L, "Sunt vel at nam et molestias. Aliquid ut qui consequatur necessitatibus. Commodi molestias deleniti quisquam debitis rerum omnis reprehenderit amet. Voluptate id velit. Nobis est alias hic et vero. Asperiores qui at debitis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 9, 8, 15, 3, 38, 589, DateTimeKind.Unspecified).AddTicks(7988), 25, "https://vernice.net", 1, "omnis", 33, "Veritatis et nam. Numquam qui unde qui unde beatae qui expedita voluptatem. Voluptas reiciendis sunt mollitia. Sapiente eius omnis quisquam ea pariatur ut omnis dolorem. Quaerat distinctio magnam placeat fugit iste." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 3, 7, 9, 44, 32, 491, DateTimeKind.Unspecified).AddTicks(7127), 17, "https://jayne.org", 2, "qui", 18, 1, "Ullam ducimus fugiat veniam esse ducimus.\nOmnis provident ex.\nLaborum voluptatibus in quae.\nCommodi illum et quibusdam dolorem." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 4, 18, 20, 6, 16, 665, DateTimeKind.Unspecified).AddTicks(9489), 19, "http://edwin.org", 0, "rerum", 57, 1L, 0, "Cum placeat aliquam quia ut neque cumque nobis.\nPariatur omnis sit eos rerum sit numquam est magni repudiandae.\nVel dignissimos beatae vitae animi non veritatis praesentium.\nAut veniam ipsam ut eum reiciendis qui fugiat facere voluptates.\nQuod adipisci exercitationem voluptate.\nDignissimos modi nesc" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 2, 26, 19, 44, 46, 493, DateTimeKind.Unspecified).AddTicks(5965), 20, "http://ivah.biz", "magni", 55, 1L, 1, "maxime" });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 12, 12, 16, 59, 48, 537, DateTimeKind.Unspecified).AddTicks(3480), 10L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 6L, new DateTime(2021, 5, 28, 14, 36, 9, 272, DateTimeKind.Unspecified).AddTicks(1206), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 1L, new DateTime(2020, 3, 24, 2, 32, 41, 101, DateTimeKind.Unspecified).AddTicks(9672), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 7, 15, 15, 39, 0, 221, DateTimeKind.Unspecified).AddTicks(6660), 4L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2019, 9, 14, 21, 56, 30, 398, DateTimeKind.Unspecified).AddTicks(7016), 9L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2020, 6, 20, 6, 19, 43, 960, DateTimeKind.Unspecified).AddTicks(4859), 3L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 3, 18, 6, 37, 53, 306, DateTimeKind.Unspecified).AddTicks(1511), 1L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2019, 7, 27, 7, 48, 15, 932, DateTimeKind.Unspecified).AddTicks(4361), 3L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 9L, new DateTime(2020, 4, 1, 14, 47, 6, 873, DateTimeKind.Unspecified).AddTicks(1487), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 4, 2, 21, 38, 43, 187, DateTimeKind.Unspecified).AddTicks(3001), 6L, 4L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6324), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 19, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6213), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6494), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 19, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6481), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6520), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 19, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6512), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6543), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 19, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6535), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6563), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6557), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6583), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 19, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6577), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6603), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 19, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6596), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6623), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 19, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6616), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6642), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 19, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6636), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6662), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 19, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6655), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Stewart89@hotmail.com", new DateTimeOffset(new DateTime(2023, 7, 4, 6, 22, 50, 931, DateTimeKind.Unspecified).AddTicks(470), new TimeSpan(0, 3, 0, 0, 0)), "Stewart Herzog" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Enrique.Yundt42@gmail.com", new DateTimeOffset(new DateTime(2022, 12, 4, 8, 5, 57, 472, DateTimeKind.Unspecified).AddTicks(1054), new TimeSpan(0, 2, 0, 0, 0)), "Enrique Yundt" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Isaac41@gmail.com", new DateTimeOffset(new DateTime(2023, 1, 23, 4, 19, 43, 162, DateTimeKind.Unspecified).AddTicks(4355), new TimeSpan(0, 2, 0, 0, 0)), "Isaac Zemlak" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Lena_Hilll55@hotmail.com", new DateTimeOffset(new DateTime(2023, 2, 2, 15, 44, 53, 594, DateTimeKind.Unspecified).AddTicks(2451), new TimeSpan(0, 2, 0, 0, 0)), "Lena Hilll" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Kim_Reichel26@yahoo.com", new DateTimeOffset(new DateTime(2023, 2, 11, 4, 3, 26, 202, DateTimeKind.Unspecified).AddTicks(1204), new TimeSpan(0, 2, 0, 0, 0)), "Kim Reichel" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Stanley.Ritchie@gmail.com", new DateTimeOffset(new DateTime(2023, 4, 5, 17, 31, 17, 455, DateTimeKind.Unspecified).AddTicks(9670), new TimeSpan(0, 3, 0, 0, 0)), "Stanley Ritchie" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Phil.Ledner31@hotmail.com", new DateTimeOffset(new DateTime(2023, 2, 21, 2, 43, 59, 761, DateTimeKind.Unspecified).AddTicks(3285), new TimeSpan(0, 2, 0, 0, 0)), "Phil Ledner" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Lana6@yahoo.com", new DateTimeOffset(new DateTime(2023, 7, 14, 0, 34, 11, 730, DateTimeKind.Unspecified).AddTicks(8480), new TimeSpan(0, 3, 0, 0, 0)), "Lana Paucek" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Sonja51@hotmail.com", new DateTimeOffset(new DateTime(2023, 8, 18, 2, 28, 25, 870, DateTimeKind.Unspecified).AddTicks(4735), new TimeSpan(0, 3, 0, 0, 0)), "Sonja Kirlin" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Max14@hotmail.com", new DateTimeOffset(new DateTime(2023, 3, 17, 14, 1, 55, 847, DateTimeKind.Unspecified).AddTicks(4181), new TimeSpan(0, 2, 0, 0, 0)), "Max Kassulke" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 12, 14, 7, 52, 29, 126, DateTimeKind.Unspecified).AddTicks(9779), 5L, "autem", 17, 2, "amet", new DateTimeOffset(new DateTime(2023, 2, 11, 9, 34, 46, 670, DateTimeKind.Unspecified).AddTicks(446), new TimeSpan(0, 2, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 8, 9, 7, 19, 44, 56, DateTimeKind.Unspecified).AddTicks(2085), 10L, "Dolores voluptas aut laboriosam quam modi odit vel", 46, 0, "libero", new DateTimeOffset(new DateTime(2022, 11, 30, 12, 1, 27, 507, DateTimeKind.Unspecified).AddTicks(9549), new TimeSpan(0, 2, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 40, 23, 357, DateTimeKind.Unspecified).AddTicks(6203), 10L, "aut", 42, 2, "molestias", new DateTimeOffset(new DateTime(2023, 1, 9, 23, 35, 10, 156, DateTimeKind.Unspecified).AddTicks(2437), new TimeSpan(0, 2, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 12, 1, 15, 31, 3, 716, DateTimeKind.Unspecified).AddTicks(1527), 4L, "velit", 17, 2, "magnam", new DateTimeOffset(new DateTime(2023, 2, 19, 5, 26, 53, 996, DateTimeKind.Unspecified).AddTicks(7273), new TimeSpan(0, 2, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 11, 30, 9, 46, 42, 646, DateTimeKind.Unspecified).AddTicks(4110), 4L, "Iste dolorum neque velit pariatur.\nQuo velit iure", 0, "eos", new DateTimeOffset(new DateTime(2023, 7, 1, 0, 18, 26, 915, DateTimeKind.Unspecified).AddTicks(4518), new TimeSpan(0, 3, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 2, 14, 6, 40, 192, DateTimeKind.Unspecified).AddTicks(8570), 9L, "Esse ut et reprehenderit natus est natus maxime. D", 18, "neque", new DateTimeOffset(new DateTime(2022, 12, 1, 9, 1, 11, 614, DateTimeKind.Unspecified).AddTicks(8909), new TimeSpan(0, 2, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 10, 22, 15, 28, 8, 664, DateTimeKind.Unspecified).AddTicks(8474), 5L, "Sit eos ea nemo. Labore vel quibusdam labore. Quis", 43, 0, "id", new DateTimeOffset(new DateTime(2023, 7, 9, 14, 18, 11, 752, DateTimeKind.Unspecified).AddTicks(1879), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 6, 29, 6, 47, 44, 737, DateTimeKind.Unspecified).AddTicks(8164), 9L, "Et aperiam inventore.\nConsequatur qui illo et veri", 33, 2, "deserunt", new DateTimeOffset(new DateTime(2023, 6, 7, 15, 16, 22, 530, DateTimeKind.Unspecified).AddTicks(4140), new TimeSpan(0, 3, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 22, 23, 29, 3, 68, DateTimeKind.Unspecified).AddTicks(1188), 2L, "sapiente", 54, "reprehenderit", new DateTimeOffset(new DateTime(2023, 3, 10, 1, 55, 26, 899, DateTimeKind.Unspecified).AddTicks(9954), new TimeSpan(0, 2, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 7, 31, 14, 37, 2, 769, DateTimeKind.Unspecified).AddTicks(9451), 7L, "Aliquid quia quis dolorum sint incidunt nulla. Tot", 55, 0, "ipsa", new DateTimeOffset(new DateTime(2023, 4, 24, 22, 35, 37, 983, DateTimeKind.Unspecified).AddTicks(620), new TimeSpan(0, 3, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "fugaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Magni omnis nemo sequi nemo quam itaque. Nulla amet et voluptatum rem doloremque sequi. Dolorem totam dolor sed blanditiis voluptatem. Omnis animi ullam est dicta. Rerum suscipit sed repellat eum eveniet possimus. Quo neque natus." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Adipisci nostrum ut.\nIpsum deserunt laudantium provident doloremque ut.\nOfficia ex numquam sint." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Text",
                value: "suntAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Dolor labore accusamus expedita quae omnis impedit facilis. Ut dolor aut eligendi aliquam autem sed omnis consectetur. Libero et dolor distinctio. Quod quo possimus repellat beatae temporibus consequuntur sunt praesentium repellendus." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "eumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "commodiAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "laboreAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Quia aut doloremque amet quos est id reprehenderit.\nDolor sit eum nam dolorem." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Modi ut dolorem rerum sit qui sit. Quis quibusdam nihil odio sed porro qui eaque. Quia quia nisi aperiam ex cupiditate quo. Eos debitis sint in deserunt dolore eveniet. Vero dicta dolorem odit." });

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Priority",
                value: 10);

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
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Priority",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Priority",
                value: 7);

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
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Priority",
                value: 4);

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
                keyValue: 5L,
                column: "Role",
                value: 2);

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
                column: "Role",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Role",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Ipsum porro commodi eaque quo.", "Miller LLC", "https://bridget.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Unde illo vero quis magnam natus voluptas.", "Metz, Lemke and Bahringer", "http://edwina.net" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Ipsam fugiat sed distinctio sed perspiciatis repellendus non.\nMaxime in labore dolores.\nEt labore error vero deleniti in fugiat deserunt.", "Bradtke and Sons", "https://ezequiel.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Ad voluptatum deleniti quia voluptas.", "Rippin, Cronin and Larkin", "http://celia.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Et exercitationem et.", "Hayes Group", "https://aurelie.name" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "a", "Marks, Rippin and Schowalter", "https://annamarie.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Repellendus quis numquam est sed est nihil. Doloremque deleniti vero vitae ab ea et. Voluptatem consequuntur et molestiae eaque et dolor asperiores. Voluptatem magnam possimus provident officiis autem dolorum distinctio repellendus.", "Welch - Frami", "https://wilfred.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Ut praesentium necessitatibus quisquam voluptatum impedit et itaque assumenda autem. In ex qui molestias. Debitis eligendi aut debitis qui id commodi ipsam pariatur. Doloremque aspernatur enim et sunt earum. Libero maxime iste dolorem.", "Kreiger LLC", "https://sherwood.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Et aspernatur facilis saepe.", "Smith Inc", "https://amelie.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Nulla quibusdam sunt sint accusamus laudantium vitae.", "Halvorson LLC", "https://ignatius.org" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Leona.Bergnaum@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/625.jpg", "Leona Bergnaum", "751-288-13" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Muriel48@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/486.jpg", "Muriel Mitchell", "(610) 201-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Olive39@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/700.jpg", "Olive Frami", "939.934.30", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Laura_Zieme@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/811.jpg", "Laura Zieme", "(841) 211-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "George27@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/842.jpg", "George Ullrich", "1-692-522-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Christina.Ortiz@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/370.jpg", "Christina Ortiz", "1-922-958-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Micheal_Walter@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1122.jpg", "Micheal Walter", "890-832-95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Caleb28@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/679.jpg", "Caleb Lind", "582.583.34", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Taylor42@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/462.jpg", "Taylor Friesen", "(384) 523-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Leslie_Dickens47@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1014.jpg", "Leslie Dickens", "626-754-45" });

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
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 2, 26, 8, 4 });

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
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 1, 3, 26, 2, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 3, 11, 8, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 7, 27, 4, 1, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 25, 1, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 7, 29, 8, 5, 13 });

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
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 10, 25, 3, 34, 5, 290, DateTimeKind.Unspecified).AddTicks(972), 15, "https://caroline.name", 2, "animi", 44, 4L, 0, "Quia delectus facere non.\nHarum facilis assumenda accusamus qui sed et repellat vero dolores.\nLibero et qui facilis sed nobis ut.\nQuaerat iure perferendis placeat aliquam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 7, 22, 23, 58, 11, 273, DateTimeKind.Unspecified).AddTicks(6525), 17, "http://antonia.org", 1, "illo", 22, 7L, 0, "Ut voluptatibus dolore necessitatibus dolores soluta nihil. Et omnis nobis rem qui accusamus rerum aut a vero. Voluptatum quos voluptatem tenetur officiis non sint sit quia." });

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
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 10, 11, 18, 43, 57, 540, DateTimeKind.Unspecified).AddTicks(532), 30, "https://madalyn.org", 0, "esse", 48, 4L, "Architecto suscipit ratione voluptatem aut ut iusto aut voluptates.\nSit ea et non omnis consectetur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 7, 6, 20, 0, 0, 590, DateTimeKind.Unspecified).AddTicks(2067), 28, "http://jeff.com", 1, "voluptates", 30, 4L, 0, "Laborum necessitatibus molestiae voluptate libero." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 6, 5, 17, 56, 55, 88, DateTimeKind.Unspecified).AddTicks(4080), "https://cielo.biz", 0, "eligendi", 50, 4L, "Dolorem provident aut rerum non.\nRatione explicabo doloribus omnis autem deleniti.\nQuo iste deleniti omnis minus voluptatem eaque.\nMinus non labore aut et ea.\nCorporis molestiae facilis et ut ut rerum dolorem aut provident.\nEaque omnis quos dolore aliquid magnam culpa." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 6, 19, 10, 43, 21, 298, DateTimeKind.Unspecified).AddTicks(8672), 17, "https://jermaine.biz", 0, "numquam", 31, "exercitationem" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 1, 22, 6, 42, 43, 754, DateTimeKind.Unspecified).AddTicks(6794), 16, "http://petra.net", 0, "et", 53, 0, "Minima consequatur est eos." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 1, 2, 15, 49, 41, 765, DateTimeKind.Unspecified).AddTicks(3875), 15, "https://ronny.name", 2, "error", 31, 10L, 1, "Non aut et et. Architecto molestiae ut dolor veritatis velit. Eos qui hic omnis velit velit consequatur suscipit totam quo. Omnis facilis sunt et iusto omnis deserunt. Repudiandae qui ipsam facere est vero aspernatur amet." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 2, 7, 11, 54, 54, 533, DateTimeKind.Unspecified).AddTicks(601), 28, "https://antoinette.biz", "ab", 38, 2L, 0, "Corporis laboriosam maiores. Voluptatem necessitatibus vel atque eum quia voluptatem soluta iusto. Aut perspiciatis dolores dignissimos voluptates provident. Quia ea corporis dignissimos." });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 10L, new DateTime(2020, 1, 6, 4, 22, 54, 746, DateTimeKind.Unspecified).AddTicks(9275), 4L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2020, 7, 15, 13, 15, 42, 875, DateTimeKind.Unspecified).AddTicks(2959), 5L, 8L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 6, 30, 16, 0, 22, 673, DateTimeKind.Unspecified).AddTicks(6553), 9L, 6L });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 7L, new DateTime(2020, 12, 20, 7, 37, 42, 161, DateTimeKind.Unspecified).AddTicks(4263), 10L });

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
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4652), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4626), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Lila_Heathcote62@gmail.com", new DateTimeOffset(new DateTime(2023, 4, 21, 18, 55, 19, 681, DateTimeKind.Unspecified).AddTicks(2057), new TimeSpan(0, 3, 0, 0, 0)), "Lila Heathcote" });

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
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Lora_Miller86@hotmail.com", new DateTimeOffset(new DateTime(2023, 4, 25, 12, 35, 45, 170, DateTimeKind.Unspecified).AddTicks(6065), new TimeSpan(0, 3, 0, 0, 0)), "Lora Miller" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 27, 1, 10, 3, 194, DateTimeKind.Unspecified).AddTicks(6623), 8L, "Enim voluptate illo numquam officia molestiae ut.", 50, 1, "rem", new DateTimeOffset(new DateTime(2022, 8, 18, 13, 52, 42, 457, DateTimeKind.Unspecified).AddTicks(9679), new TimeSpan(0, 3, 0, 0, 0)), 5L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 10, 8, 20, 36, 29, 361, DateTimeKind.Unspecified).AddTicks(9716), 5L, "Est qui officia cupiditate nihil ut nam aperiam do", 2, "corrupti", new DateTimeOffset(new DateTime(2022, 8, 19, 4, 48, 34, 628, DateTimeKind.Unspecified).AddTicks(6571), new TimeSpan(0, 3, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 6, 4, 50, 6, 354, DateTimeKind.Unspecified).AddTicks(8662), 3L, "Aliquid soluta laborum voluptatem velit autem et v", 56, "sint", new DateTimeOffset(new DateTime(2023, 2, 13, 9, 25, 32, 223, DateTimeKind.Unspecified).AddTicks(5637), new TimeSpan(0, 2, 0, 0, 0)), 3L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 7, 3, 9, 49, 26, 115, DateTimeKind.Unspecified).AddTicks(7176), 8L, "Sint beatae ut incidunt exercitationem nihil et.\nM", 56, "tenetur", new DateTimeOffset(new DateTime(2022, 11, 23, 10, 50, 14, 41, DateTimeKind.Unspecified).AddTicks(5250), new TimeSpan(0, 2, 0, 0, 0)), 3L });

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
                column: "Text",
                value: "Vitae impedit id possimus placeat corporis minus vero. Similique amet aliquam labore ducimus labore minima et. Possimus libero voluptates. Illo et ea delectus nam. Quam molestias debitis illo enim dignissimos enim.");

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
                keyValue: 2L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Role",
                value: 1);

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
                column: "Role",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Role",
                value: 2);

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
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Jane.Hand@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/969.jpg", "Jane Hand", "1-360-471-", 1 });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Vincent_Gorczany90@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/840.jpg", "Vincent Gorczany", "832-797-95", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Genevieve0@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/348.jpg", "Genevieve Pfannerstill", "(406) 715-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Horace_Rempel@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/609.jpg", "Horace Rempel", "1-378-467-", 1 });

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
