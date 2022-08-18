using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class Adduidtouseruniqueuidandemail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 5, 3, 5 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 2, 30, 4, 4, 7 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 7, 20, 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 6, 26, 5, 7 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 12, 9, 5, 14 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 6, 27, 3, 12 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 1, 29, 9, 4, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 1, 10, 4, 13 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 8, 16, 6, 1, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 6, 7, 2, 4 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 8, 30, 3, 12, 21, 429, DateTimeKind.Unspecified).AddTicks(6641), 30, "https://valentin.info", 2, "quis", 48, 7L, 0, "Consequatur et sed dolor voluptatum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2019, 11, 14, 18, 30, 57, 678, DateTimeKind.Unspecified).AddTicks(5662), 15, "http://gilbert.org", 2, "ea", 54, 4L, "Saepe ratione dignissimos sit facilis maiores voluptas alias.\nAliquam sit consequatur assumenda accusamus.\nConsequatur repellat tempora praesentium eos veritatis aperiam.\nEligendi odit qui similique animi velit architecto ipsum in.\nIn quisquam inventore sed quis.\nCommodi quia voluptatibus dolores et" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 3, 22, 19, 15, 15, 527, DateTimeKind.Unspecified).AddTicks(1975), 28, "https://norwood.net", "quia", 26, 4L, 0, "Tempora omnis rerum ab accusamus." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 6, 16, 13, 39, 58, 992, DateTimeKind.Unspecified).AddTicks(5880), 23, "https://kraig.org", "doloremque", 17, 9L, 0, "Et ut inventore enim sit.\nEt veniam est dolores ea ea.\nQuidem alias hic sed iste.\nQuia et magnam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 5, 25, 17, 41, 5, 114, DateTimeKind.Unspecified).AddTicks(2406), 18, "https://ralph.net", 2, "enim", 17, 2L, 0, "Laudantium ut est mollitia ut sint." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 7, 2, 5, 7, 46, 835, DateTimeKind.Unspecified).AddTicks(514), 25, "http://caesar.biz", "sit", 15, 1L, 1, "Suscipit est rerum laudantium voluptate libero rerum.\nSaepe qui tempora velit et nemo modi." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 8, 13, 9, 3, 17, 723, DateTimeKind.Unspecified).AddTicks(6078), 21, "https://garrick.biz", 2, "cupiditate", 29, 8L, "Voluptates id tempore et accusamus nihil rerum omnis.\nMagnam autem eum quae eum quibusdam explicabo aut harum illum.\nIpsum natus quis cumque sint sit.\nUnde ut labore." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 7, 6, 19, 56, 40, 715, DateTimeKind.Unspecified).AddTicks(5683), 29, "http://lucas.biz", "maiores", 56, 0, "at" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 2, 23, 23, 41, 41, 973, DateTimeKind.Unspecified).AddTicks(2250), 27, "http://jaylen.net", 2, "distinctio", 30, 2L, "molestias" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 10, 11, 21, 54, 21, 515, DateTimeKind.Unspecified).AddTicks(4944), 16, "http://trystan.com", "magnam", 27, 7L, 0, "Eveniet alias iusto. Reprehenderit placeat molestiae et placeat. Optio quaerat dicta et fugit et voluptates. Similique cumque ut cumque asperiores quia omnis assumenda. A ducimus exercitationem dolores. Cumque possimus nemo itaque aliquid reiciendis ut dicta." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2020, 5, 17, 19, 47, 40, 748, DateTimeKind.Unspecified).AddTicks(7541), 7L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 2, 14, 4, 33, 31, 999, DateTimeKind.Unspecified).AddTicks(3252), 5L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2019, 10, 21, 20, 20, 44, 334, DateTimeKind.Unspecified).AddTicks(5743), 9L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 4, 10, 5, 56, 21, 368, DateTimeKind.Unspecified).AddTicks(7582), 8L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2020, 1, 31, 11, 41, 37, 776, DateTimeKind.Unspecified).AddTicks(4063), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 12, 30, 17, 45, 44, 997, DateTimeKind.Unspecified).AddTicks(1809), 1L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2020, 6, 3, 19, 59, 42, 607, DateTimeKind.Unspecified).AddTicks(2487), 3L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2020, 9, 8, 23, 38, 19, 731, DateTimeKind.Unspecified).AddTicks(763), 7L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2020, 9, 28, 1, 6, 39, 692, DateTimeKind.Unspecified).AddTicks(3799), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 2, 25, 2, 55, 26, 317, DateTimeKind.Unspecified).AddTicks(4613), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3363), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 19, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3262), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3529), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 19, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3516), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3556), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 19, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3548), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3581), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 19, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3573), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3604), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 19, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3596), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3626), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 19, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3618), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3648), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 19, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3640), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3669), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 19, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3661), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3689), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 19, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3682), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3710), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 19, 19, 40, 15, 523, DateTimeKind.Unspecified).AddTicks(3702), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Johnnie51@yahoo.com", new DateTimeOffset(new DateTime(2022, 9, 1, 1, 2, 1, 684, DateTimeKind.Unspecified).AddTicks(5712), new TimeSpan(0, 3, 0, 0, 0)), "Johnnie Kessler" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Roberto14@hotmail.com", new DateTimeOffset(new DateTime(2023, 5, 22, 19, 1, 7, 355, DateTimeKind.Unspecified).AddTicks(1445), new TimeSpan(0, 3, 0, 0, 0)), "Roberto Rohan" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Marvin6@gmail.com", new DateTimeOffset(new DateTime(2023, 3, 12, 2, 15, 0, 108, DateTimeKind.Unspecified).AddTicks(5877), new TimeSpan(0, 2, 0, 0, 0)), "Marvin Yost" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Jamie.Ondricka@hotmail.com", new DateTimeOffset(new DateTime(2022, 11, 12, 13, 12, 25, 627, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, 2, 0, 0, 0)), "Jamie Ondricka" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Winston94@gmail.com", new DateTimeOffset(new DateTime(2022, 11, 20, 12, 24, 9, 528, DateTimeKind.Unspecified).AddTicks(2473), new TimeSpan(0, 2, 0, 0, 0)), "Winston Lang" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Tamara2@gmail.com", new DateTimeOffset(new DateTime(2022, 9, 14, 17, 42, 24, 255, DateTimeKind.Unspecified).AddTicks(417), new TimeSpan(0, 3, 0, 0, 0)), "Tamara Conroy" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Michael87@hotmail.com", new DateTimeOffset(new DateTime(2023, 5, 26, 7, 24, 30, 888, DateTimeKind.Unspecified).AddTicks(4881), new TimeSpan(0, 3, 0, 0, 0)), "Michael Hilll" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Betsy.Carroll@gmail.com", new DateTimeOffset(new DateTime(2023, 1, 16, 23, 55, 22, 873, DateTimeKind.Unspecified).AddTicks(2275), new TimeSpan(0, 2, 0, 0, 0)), "Betsy Carroll" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Darnell.Runte83@gmail.com", new DateTimeOffset(new DateTime(2023, 8, 9, 18, 43, 0, 316, DateTimeKind.Unspecified).AddTicks(979), new TimeSpan(0, 3, 0, 0, 0)), "Darnell Runte" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Alma.Luettgen69@yahoo.com", new DateTimeOffset(new DateTime(2023, 1, 27, 13, 17, 47, 389, DateTimeKind.Unspecified).AddTicks(5574), new TimeSpan(0, 2, 0, 0, 0)), "Alma Luettgen" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 6, 18, 22, 26, 32, 919, DateTimeKind.Unspecified).AddTicks(217), 9L, "Nihil facere natus aut facilis sit saepe amet dolo", 32, "aut", new DateTimeOffset(new DateTime(2023, 3, 8, 11, 4, 51, 982, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 6, 3, 16, 21, 18, 731, DateTimeKind.Unspecified).AddTicks(3978), 5L, "itaque", 52, 1, "nihil", new DateTimeOffset(new DateTime(2022, 10, 29, 3, 48, 56, 76, DateTimeKind.Unspecified).AddTicks(5493), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 2, 8, 13, 25, 38, 702, DateTimeKind.Unspecified).AddTicks(2781), 2L, "Quam excepturi corporis voluptas voluptas. Vero ve", 52, 1, "repudiandae", new DateTimeOffset(new DateTime(2023, 2, 10, 7, 16, 15, 257, DateTimeKind.Unspecified).AddTicks(5533), new TimeSpan(0, 2, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 23, 15, 50, 25, 428, DateTimeKind.Unspecified).AddTicks(5338), 10L, "Quis itaque quaerat sequi iste dicta recusandae qu", 55, "est", new DateTimeOffset(new DateTime(2023, 7, 11, 22, 35, 58, 714, DateTimeKind.Unspecified).AddTicks(2605), new TimeSpan(0, 3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 8, 29, 17, 11, 56, 651, DateTimeKind.Unspecified).AddTicks(4240), 5L, "sit", 29, 1, "est", new DateTimeOffset(new DateTime(2023, 4, 15, 20, 8, 27, 180, DateTimeKind.Unspecified).AddTicks(1778), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 10, 15, 22, 57, 11, 764, DateTimeKind.Unspecified).AddTicks(5983), "rerum", 55, 2, "vitae", new DateTimeOffset(new DateTime(2022, 11, 18, 6, 53, 16, 688, DateTimeKind.Unspecified).AddTicks(698), new TimeSpan(0, 2, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 21, 1, 54, 7, 940, DateTimeKind.Unspecified).AddTicks(3898), 3L, "Molestias quibusdam error et.", 47, "voluptates", new DateTimeOffset(new DateTime(2022, 8, 20, 8, 30, 59, 217, DateTimeKind.Unspecified).AddTicks(8487), new TimeSpan(0, 3, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 2, 9, 8, 25, 59, 73, DateTimeKind.Unspecified).AddTicks(4579), 4L, "possimus", 40, 1, "id", new DateTimeOffset(new DateTime(2023, 7, 7, 23, 42, 7, 900, DateTimeKind.Unspecified).AddTicks(348), new TimeSpan(0, 3, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime" },
                values: new object[] { new DateTime(2020, 7, 19, 23, 42, 29, 251, DateTimeKind.Unspecified).AddTicks(6293), 3L, "Voluptatibus iusto magni quae. Totam dolorem nesci", 59, 0, "numquam", new DateTimeOffset(new DateTime(2022, 12, 6, 22, 48, 21, 968, DateTimeKind.Unspecified).AddTicks(2444), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 1, 26, 4, 40, 29, 587, DateTimeKind.Unspecified).AddTicks(2574), 4L, "Impedit sed aut voluptas consequuntur quod aut mol", 56, "repudiandae", new DateTimeOffset(new DateTime(2022, 12, 4, 7, 37, 1, 60, DateTimeKind.Unspecified).AddTicks(7566), new TimeSpan(0, 2, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "sapienteAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Libero et dolorem distinctio corrupti non enim veniam ipsa.\nEst perspiciatis magnam voluptate placeat dicta corporis quas." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Illo odit consequatur molestiae rerum.\nEnim a dolores aliquam rem aut voluptas aut.\nEos debitis est in quisquam velit.\nCumque voluptatibus dolor aut veritatis molestiae eos." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Illum iusto sequi et excepturi ipsa iure et sint.A" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "rerumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Quo non consequatur quasi eum quam nisi ut eligendi sit. Aut explicabo occaecati sequi fugiat ipsam sequi. Earum corporis magnam voluptatum saepe commodi consequuntur. Eos suscipit debitis quos dolorem." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "quiAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "temporeAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "sedAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "laboriosamAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

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
                value: 8);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Priority",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Priority",
                value: 4);

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
                value: 6);

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
                value: 7);

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
                keyValue: 5L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

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
                values: new object[] { 1, 2 });

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
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Dolorum sed dolorem. Omnis a magni et molestias repellat ex vitae error. Commodi veritatis tempore nihil qui reiciendis ut voluptates est.", "Blick LLC", "https://rahul.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "sit", "Rippin Inc", "https://deshaun.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "qui", "Mitchell - Wyman", "http://brody.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Eum error molestiae sit natus aut et voluptate aliquam. Ex velit nobis aperiam corporis sit atque vel corporis. Ratione facere qui et quam. Maxime et quibusdam omnis officia enim eligendi quasi quo.", "Ernser - Bauch", "http://eldora.net" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Quisquam dolor fuga.\nDeserunt non unde.\nDistinctio qui ipsam quaerat.\nAutem facere ut enim qui est necessitatibus non.", "Lindgren, Bergstrom and Koch", "http://luciano.name" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Itaque et dignissimos ipsa. Quos quis enim et voluptas tempore in vel qui quam. Veniam et et et asperiores vel. Consequatur labore et. Corrupti ipsa modi officia velit veniam quis reiciendis vel. Impedit hic dolor dolorum laudantium quam et dolore non.", "Murray - Ward", "https://jeff.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Expedita id qui ipsa.\nNumquam distinctio sint ex.\nAut tenetur quasi et cupiditate facilis ut rerum consequatur earum.\nDoloribus ut rerum modi aut.", "Kautzer, Cole and Schulist", "https://river.name" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Distinctio aperiam magni iure officia at distinctio molestiae veritatis.\nQuia nobis asperiores aliquid officiis.\nEt ut libero nesciunt laudantium eligendi nesciunt sint.\nMollitia harum ratione commodi ut et est est ut.\nEligendi ex ut eum officia ipsa.\nVoluptatibus maiores sed.", "Gislason, Dietrich and Wisozk", "https://ellsworth.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Labore et nostrum ad.", "Shields - Hoeger", "http://maximo.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "expedita", "Leffler Group", "https://isom.net" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Elmer26@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/672.jpg", "Elmer Mayer", "1-767-964-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Kelly19@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/931.jpg", "Kelly Morar", "249-762-86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Eric67@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/419.jpg", "Eric Pagac", "(455) 514-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Harriet84@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1060.jpg", "Harriet Bauch", "618.644.79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Myron_Friesen42@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/293.jpg", "Myron Friesen", "564-421-56", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Terrance5@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/961.jpg", "Terrance Mertz", "1-968-904-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Mattie17@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1233.jpg", "Mattie Bins", "458-608-96", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Dwight.Williamson@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/80.jpg", "Dwight Williamson", "1-523-323-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Tara_Anderson@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/384.jpg", "Tara Anderson", "708-549-61" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Bill76@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/902.jpg", "Bill Langworth", "(352) 465-", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 27, 2, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 5, 14, 7, 2, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 23, 7, 3, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 25, 3, 12 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 29, 4, 4, 7 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 8, 1, 4, 4 });

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
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 8, 13, 10, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 1, 24, 5, 2, 12 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 2, 29, 3, 6 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 12, 6, 9, 28, 33, 390, DateTimeKind.Unspecified).AddTicks(1075), 24, "https://rowland.info", 0, "repudiandae", 28, 3L, 1, "Veritatis et nihil sit natus in." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 3, 28, 1, 24, 29, 72, DateTimeKind.Unspecified).AddTicks(7498), 19, "https://scottie.org", 0, "magni", 51, 2L, "Atque repellendus necessitatibus dolorem illo velit." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2019, 8, 22, 20, 10, 29, 489, DateTimeKind.Unspecified).AddTicks(8042), 17, "https://rosalee.info", "rerum", 24, 2L, 1, "Eum fugiat molestiae libero quia aperiam consequatur rerum quam consequuntur.\nVelit ut aut architecto vero rerum debitis nulla.\nNemo aliquid ut id soluta incidunt repellat iste.\nEt ad debitis ea facere.\nBlanditiis quis quo fugit qui et." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 5, 24, 12, 20, 29, 742, DateTimeKind.Unspecified).AddTicks(3674), 24, "https://anika.com", "cum", 21, 7L, 1, "Est et ipsa. Debitis occaecati ut. Ratione vitae nesciunt." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 6, 1, 6, 10, 50, 939, DateTimeKind.Unspecified).AddTicks(421), 30, "http://gilberto.com", 0, "labore", 22, 6L, 1, "Sapiente dolor est aut aut illo aspernatur odio ut.\nFacilis quaerat voluptatibus vel ut est aut quas." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 11, 10, 2, 55, 18, 57, DateTimeKind.Unspecified).AddTicks(4071), 23, "https://jaeden.biz", "corrupti", 32, 9L, 0, "Sunt vel at nam et molestias. Aliquid ut qui consequatur necessitatibus. Commodi molestias deleniti quisquam debitis rerum omnis reprehenderit amet. Voluptate id velit. Nobis est alias hic et vero. Asperiores qui at debitis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 9, 8, 15, 3, 38, 589, DateTimeKind.Unspecified).AddTicks(7988), 25, "https://vernice.net", 1, "omnis", 33, 7L, "Veritatis et nam. Numquam qui unde qui unde beatae qui expedita voluptatem. Voluptas reiciendis sunt mollitia. Sapiente eius omnis quisquam ea pariatur ut omnis dolorem. Quaerat distinctio magnam placeat fugit iste." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 3, 7, 9, 44, 32, 491, DateTimeKind.Unspecified).AddTicks(7127), 17, "https://jayne.org", "qui", 18, 1, "Ullam ducimus fugiat veniam esse ducimus.\nOmnis provident ex.\nLaborum voluptatibus in quae.\nCommodi illum et quibusdam dolorem." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 4, 18, 20, 6, 16, 665, DateTimeKind.Unspecified).AddTicks(9489), 19, "http://edwin.org", 0, "rerum", 57, 1L, "Cum placeat aliquam quia ut neque cumque nobis.\nPariatur omnis sit eos rerum sit numquam est magni repudiandae.\nVel dignissimos beatae vitae animi non veritatis praesentium.\nAut veniam ipsam ut eum reiciendis qui fugiat facere voluptates.\nQuod adipisci exercitationem voluptate.\nDignissimos modi nesc" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 2, 26, 19, 44, 46, 493, DateTimeKind.Unspecified).AddTicks(5965), 20, "http://ivah.biz", "magni", 55, 1L, 1, "maxime" });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 5, 28, 14, 36, 9, 272, DateTimeKind.Unspecified).AddTicks(1206), 3L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2020, 3, 24, 2, 32, 41, 101, DateTimeKind.Unspecified).AddTicks(9672), 4L, 1L });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2019, 9, 14, 21, 56, 30, 398, DateTimeKind.Unspecified).AddTicks(7016), 9L, 7L });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 4, 1, 14, 47, 6, 873, DateTimeKind.Unspecified).AddTicks(1487), 8L });

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
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6563), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 19, 17, 53, 13, 271, DateTimeKind.Unspecified).AddTicks(6557), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Isaac41@gmail.com", new DateTimeOffset(new DateTime(2023, 1, 23, 4, 19, 43, 162, DateTimeKind.Unspecified).AddTicks(4355), new TimeSpan(0, 2, 0, 0, 0)), "Isaac Zemlak" });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 12, 14, 7, 52, 29, 126, DateTimeKind.Unspecified).AddTicks(9779), 5L, "autem", 17, "amet", new DateTimeOffset(new DateTime(2023, 2, 11, 9, 34, 46, 670, DateTimeKind.Unspecified).AddTicks(446), new TimeSpan(0, 2, 0, 0, 0)), 8L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 12, 1, 15, 31, 3, 716, DateTimeKind.Unspecified).AddTicks(1527), 4L, "velit", 17, "magnam", new DateTimeOffset(new DateTime(2023, 2, 19, 5, 26, 53, 996, DateTimeKind.Unspecified).AddTicks(7273), new TimeSpan(0, 2, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 11, 30, 9, 46, 42, 646, DateTimeKind.Unspecified).AddTicks(4110), 4L, "Iste dolorum neque velit pariatur.\nQuo velit iure", 49, 0, "eos", new DateTimeOffset(new DateTime(2023, 7, 1, 0, 18, 26, 915, DateTimeKind.Unspecified).AddTicks(4518), new TimeSpan(0, 3, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 2, 14, 6, 40, 192, DateTimeKind.Unspecified).AddTicks(8570), "Esse ut et reprehenderit natus est natus maxime. D", 18, 0, "neque", new DateTimeOffset(new DateTime(2022, 12, 1, 9, 1, 11, 614, DateTimeKind.Unspecified).AddTicks(8909), new TimeSpan(0, 2, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 10, 22, 15, 28, 8, 664, DateTimeKind.Unspecified).AddTicks(8474), 5L, "Sit eos ea nemo. Labore vel quibusdam labore. Quis", 43, "id", new DateTimeOffset(new DateTime(2023, 7, 9, 14, 18, 11, 752, DateTimeKind.Unspecified).AddTicks(1879), new TimeSpan(0, 3, 0, 0, 0)), 1L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime" },
                values: new object[] { new DateTime(2019, 12, 22, 23, 29, 3, 68, DateTimeKind.Unspecified).AddTicks(1188), 2L, "sapiente", 54, 2, "reprehenderit", new DateTimeOffset(new DateTime(2023, 3, 10, 1, 55, 26, 899, DateTimeKind.Unspecified).AddTicks(9954), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 7, 31, 14, 37, 2, 769, DateTimeKind.Unspecified).AddTicks(9451), 7L, "Aliquid quia quis dolorum sint incidunt nulla. Tot", 55, "ipsa", new DateTimeOffset(new DateTime(2023, 4, 24, 22, 35, 37, 983, DateTimeKind.Unspecified).AddTicks(620), new TimeSpan(0, 3, 0, 0, 0)), 8L });

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
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "suntAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

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
                keyValue: 9L,
                column: "Priority",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Priority",
                value: 4);

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
                keyValue: 5L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

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
                values: new object[] { 2, 1 });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Leona.Bergnaum@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/625.jpg", "Leona Bergnaum", "751-288-13", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Muriel48@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/486.jpg", "Muriel Mitchell", "(610) 201-" });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Laura_Zieme@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/811.jpg", "Laura Zieme", "(841) 211-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "George27@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/842.jpg", "George Ullrich", "1-692-522-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Christina.Ortiz@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/370.jpg", "Christina Ortiz", "1-922-958-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Micheal_Walter@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1122.jpg", "Micheal Walter", "890-832-95", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Caleb28@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/679.jpg", "Caleb Lind", "582.583.34" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Taylor42@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/462.jpg", "Taylor Friesen", "(384) 523-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Leslie_Dickens47@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1014.jpg", "Leslie Dickens", "626-754-45", 1 });
        }
    }
}
