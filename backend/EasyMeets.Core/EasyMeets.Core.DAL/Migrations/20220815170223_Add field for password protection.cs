using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class Addfieldforpasswordprotection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PasswordProtectionIsUsed",
                table: "AvailabilitySlots",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 3, 15, 2, 4, 5 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 7, 10, 2, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 10, 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 8, 12, 1, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 5, 1, 4, 1, 7 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 3, 23, 2, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 6, 15, 10, 2, 7 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 1, 13, 10, 15 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 12, 5, 3, 12 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 4, 20, 9, 1, 15 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 2, 5, 21, 42, 6, 789, DateTimeKind.Unspecified).AddTicks(5454), 18, "http://johnnie.net", 5L, "et", 47, 5L, "Rerum voluptatem aut laboriosam non eos sed dolor. Odio ipsam consectetur ut maiores. Et ipsa deserunt et sapiente. Amet molestiae nesciunt optio ipsa omnis facere. Sint saepe quidem perferendis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 5, 29, 16, 14, 32, 955, DateTimeKind.Unspecified).AddTicks(976), 20, "http://jaylon.info", "id", 48, 2L, "Totam eum mollitia in voluptatem. Reprehenderit non illo enim est. Eos itaque occaecati quo. Doloribus optio fugit vel earum et est. Explicabo tempora voluptatem quam pariatur sed id dolores possimus et." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 2, 10, 5, 1, 23, 60, DateTimeKind.Unspecified).AddTicks(3442), 19, "https://dessie.org", 2L, "possimus", 18, 8L, 1, "sed" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 1, 27, 7, 43, 0, 701, DateTimeKind.Unspecified).AddTicks(8006), 17, "http://catherine.com", 4L, "dolore", 42, 5L, "Ipsum et aut quas culpa aut et soluta similique quam. Eveniet veniam ullam non. Sed amet reiciendis cumque sint. Provident qui et omnis consequatur eos. Laborum nobis porro aut delectus." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 11, 2, 2, 12, 40, 270, DateTimeKind.Unspecified).AddTicks(1506), 29, "http://sylvester.com", 2L, "natus", 29, 3L, 0, "Necessitatibus illo rem impedit suscipit vitae minima corporis cum.\nIste ut tempore magnam inventore tenetur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 4, 23, 15, 26, 37, 739, DateTimeKind.Unspecified).AddTicks(8206), 20, "https://angelina.com", 5L, "soluta", 50, 2L, 1, "Optio quia dolor delectus ullam fugit ex non hic. Unde omnis quis omnis doloribus nemo. Sit repudiandae sint est nostrum debitis reiciendis voluptatem id. Animi totam molestias cumque quisquam voluptas ut aliquid. Omnis sequi fugit. Ut eveniet omnis ab quia eligendi nesciunt." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2019, 12, 30, 13, 31, 24, 120, DateTimeKind.Unspecified).AddTicks(190), 24, "http://cary.org", 4L, "id", 45, 2L, "qui" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2019, 12, 24, 17, 35, 52, 299, DateTimeKind.Unspecified).AddTicks(5697), 26, "https://litzy.org", "voluptas", 16, 2L, 1, "veritatis" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 9, 18, 19, 18, 15, 741, DateTimeKind.Unspecified).AddTicks(9784), 28, "http://bennett.name", 3L, 52, 1L, 0, "Fugiat aliquid impedit quis consectetur dolor sint distinctio beatae." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 2, 6, 13, 58, 55, 614, DateTimeKind.Unspecified).AddTicks(6603), 30, "https://elsa.com", 1L, "sunt", 43, 4L, "molestias" });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 3, 25, 20, 26, 5, 506, DateTimeKind.Unspecified).AddTicks(5569), 1L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 5L, new DateTime(2020, 12, 4, 15, 35, 56, 888, DateTimeKind.Unspecified).AddTicks(4903), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2019, 10, 31, 11, 59, 17, 648, DateTimeKind.Unspecified).AddTicks(4079), 5L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 10, 26, 1, 53, 35, 598, DateTimeKind.Unspecified).AddTicks(9635), 4L, 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 7, 5, 22, 7, 43, 551, DateTimeKind.Unspecified).AddTicks(9061), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2020, 6, 15, 7, 44, 26, 827, DateTimeKind.Unspecified).AddTicks(1914), 10L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2019, 8, 30, 16, 30, 40, 387, DateTimeKind.Unspecified).AddTicks(6233), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2020, 3, 7, 14, 0, 0, 837, DateTimeKind.Unspecified).AddTicks(2709), 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2019, 11, 29, 13, 2, 37, 473, DateTimeKind.Unspecified).AddTicks(7574), 5L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 1, 1, 18, 34, 42, 47, DateTimeKind.Unspecified).AddTicks(3104), 3L, 8L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(3801), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 16, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(3593), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4108), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 16, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4087), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4155), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 16, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4142), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4196), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 16, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4184), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4237), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 16, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4224), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4276), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 16, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4263), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4319), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 16, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4306), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4360), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 16, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4347), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4400), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 16, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4388), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4438), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 16, 20, 2, 21, 197, DateTimeKind.Unspecified).AddTicks(4427), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Tara_Bode31@hotmail.comAAAAAAA", new DateTimeOffset(new DateTime(2022, 11, 18, 7, 42, 16, 759, DateTimeKind.Unspecified).AddTicks(4116), new TimeSpan(0, 2, 0, 0, 0)), "Tara Bode" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Gerald.Strosin@gmail.comAAAAAA", new DateTimeOffset(new DateTime(2023, 7, 17, 21, 14, 41, 738, DateTimeKind.Unspecified).AddTicks(3405), new TimeSpan(0, 3, 0, 0, 0)), "Gerald Strosin" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Willis.Schuster@gmail.comAAAAA", new DateTimeOffset(new DateTime(2023, 6, 7, 0, 29, 46, 112, DateTimeKind.Unspecified).AddTicks(8600), new TimeSpan(0, 3, 0, 0, 0)), "Willis Schuster" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Kim_Kuhlman@yahoo.comAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 6, 11, 7, 46, 0, 815, DateTimeKind.Unspecified).AddTicks(1889), new TimeSpan(0, 3, 0, 0, 0)), "Kim Kuhlman" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Beatrice.Carroll69@hotmail.com", new DateTimeOffset(new DateTime(2023, 7, 13, 14, 2, 5, 480, DateTimeKind.Unspecified).AddTicks(5392), new TimeSpan(0, 3, 0, 0, 0)), "Beatrice Carroll" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Kenny_Hodkiewicz@yahoo.comAAAA", new DateTimeOffset(new DateTime(2022, 9, 13, 12, 22, 18, 541, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 3, 0, 0, 0)), "Kenny Hodkiewicz" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Keith.Turcotte@hotmail.comAAAA", new DateTimeOffset(new DateTime(2022, 12, 17, 22, 5, 50, 504, DateTimeKind.Unspecified).AddTicks(1686), new TimeSpan(0, 2, 0, 0, 0)), "Keith Turcotte" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Erika73@gmail.comAAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2022, 11, 15, 1, 50, 35, 247, DateTimeKind.Unspecified).AddTicks(1598), new TimeSpan(0, 2, 0, 0, 0)), "Erika Farrell" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Diana_Medhurst@hotmail.comAAAA", new DateTimeOffset(new DateTime(2022, 12, 15, 5, 8, 10, 278, DateTimeKind.Unspecified).AddTicks(8345), new TimeSpan(0, 2, 0, 0, 0)), "Diana Medhurst" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Juana_Doyle72@gmail.comAAAAAAA", new DateTimeOffset(new DateTime(2022, 11, 22, 9, 40, 43, 119, DateTimeKind.Unspecified).AddTicks(3805), new TimeSpan(0, 2, 0, 0, 0)), "Juana Doyle" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 6, 17, 1, 29, 8, 15, DateTimeKind.Unspecified).AddTicks(7933), 5L, "rem", 26, 2L, "fugiat", new DateTimeOffset(new DateTime(2023, 3, 6, 0, 57, 51, 868, DateTimeKind.Unspecified).AddTicks(4349), new TimeSpan(0, 2, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 8, 28, 21, 47, 26, 341, DateTimeKind.Unspecified).AddTicks(3109), 8L, "Praesentium adipisci est suscipit quis dicta est r", 40, 2L, "eum", new DateTimeOffset(new DateTime(2022, 12, 22, 5, 57, 46, 880, DateTimeKind.Unspecified).AddTicks(4716), new TimeSpan(0, 2, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 12, 15, 11, 0, 38, 401, DateTimeKind.Unspecified).AddTicks(6931), 9L, "Praesentium sed rerum et consequatur error aut nih", 46, 1L, "omnis", new DateTimeOffset(new DateTime(2022, 12, 12, 20, 13, 1, 36, DateTimeKind.Unspecified).AddTicks(9672), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 30, 7, 23, 19, 723, DateTimeKind.Unspecified).AddTicks(6580), 9L, "Illo voluptatem est molestias maxime eaque.\nRerum", 39, "fugiat", new DateTimeOffset(new DateTime(2023, 1, 16, 1, 5, 5, 500, DateTimeKind.Unspecified).AddTicks(3717), new TimeSpan(0, 2, 0, 0, 0)), 7L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 9, 21, 16, 12, 15, 319, DateTimeKind.Unspecified).AddTicks(8111), 3L, "Labore earum ut soluta doloremque nesciunt vel adi", 4L, "totam", new DateTimeOffset(new DateTime(2022, 12, 19, 14, 10, 13, 387, DateTimeKind.Unspecified).AddTicks(8124), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2019, 8, 25, 11, 54, 2, 204, DateTimeKind.Unspecified).AddTicks(8839), 7L, "Ea ullam sed voluptatibus.\nEst et ex quasi dolor h", 29, 4L, "voluptas", new DateTimeOffset(new DateTime(2023, 3, 20, 17, 2, 50, 232, DateTimeKind.Unspecified).AddTicks(8645), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 6, 11, 18, 0, 58, 109, DateTimeKind.Unspecified).AddTicks(7089), 7L, "velit", 4L, "iste", new DateTimeOffset(new DateTime(2023, 3, 28, 15, 54, 22, 431, DateTimeKind.Unspecified).AddTicks(8475), new TimeSpan(0, 3, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 23, 12, 29, 43, 604, DateTimeKind.Unspecified).AddTicks(3974), 10L, "Facere asperiores ab perferendis recusandae volupt", 48, "veritatis", new DateTimeOffset(new DateTime(2022, 9, 18, 19, 15, 39, 143, DateTimeKind.Unspecified).AddTicks(8), new TimeSpan(0, 3, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 1, 18, 17, 13, 26, 518, DateTimeKind.Unspecified).AddTicks(9038), 8L, "Ad ad temporibus nam nostrum qui ut dolorem rerum", 35, 1L, "eligendi", new DateTimeOffset(new DateTime(2023, 2, 18, 6, 25, 59, 809, DateTimeKind.Unspecified).AddTicks(101), new TimeSpan(0, 2, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 3, 30, 9, 5, 6, 76, DateTimeKind.Unspecified).AddTicks(6383), 3L, "Dolor veritatis asperiores odit modi dicta. Asperi", 22, 2L, "quod", new DateTimeOffset(new DateTime(2022, 9, 26, 15, 57, 6, 222, DateTimeKind.Unspecified).AddTicks(7383), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Commodi dolor aperiam sed omnis. Qui ut impedit qui quam quo et quaerat officiis. Nam molestiae et consequatur reiciendis esse rerum iusto. Iste soluta iusto veniam eveniet accusamus temporibus qui quis id. Ratione sed alias et rerum." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Iste qui quia sint illum molestias labore et veritatis. Dolor aut quis ut dolor reprehenderit quia. Aut facilis mollitia sit reprehenderit. Quibusdam repudiandae sed animi doloribus et molestiae et amet." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Officiis sit sit commodi.\nIn quibusdam dolorum deleniti.\nMagnam animi sunt debitis.\nEt alias occaecati officia ad fugiat.\nConsequuntur vel laudantium consectetur aspernatur cumque magni numquam." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Amet recusandae placeat quis enim.\nDeleniti deserunt quo aut et ut placeat." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Quia praesentium rem eaque rerum quia aut.AAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Vel impedit vitae quis consectetur. Repudiandae ut nihil sapiente nobis ipsum aliquam. Est ab quasi perspiciatis perspiciatis placeat velit voluptatem facilis praesentium." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Natus fugiat aspernatur qui.AAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Vel tenetur eos aut perferendis earum ut aut molestiae eaque." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Ea magni similique et doloribus. Id iusto quia. Minus iusto voluptas. Nihil molestiae voluptatem quia. Explicabo sit accusantium eos consectetur architecto natus sunt quisquam et. Voluptatum ad culpa quaerat laudantium repudiandae molestiae veritatis et." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "voluptatemAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

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
                value: 4);

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
                keyValue: 8L,
                column: "Priority",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Priority",
                value: 9);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Priority",
                value: 10);

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
                column: "Status",
                value: 1);

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
                column: "Role",
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
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Hic ipsam voluptas voluptate magni. Aliquid eum dicta eaque hic vitae. Dolorem est tempora officia culpa fugit natus eos. Voluptatibus autem enim natus. Ipsam qui et temporibus non.", "Torp Group", "http://catharine.net", "Europe/Lo" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Numquam perferendis perferendis maiores enim quae voluptatem amet rerum earum. Aut repellendus ab nobis dolores debitis officiis eum esse maxime. Deleniti et rerum dolores ut. Sed quibusdam dignissimos non inventore quibusdam blanditiis aspernatur et nisi. Id consequatur voluptas eveniet.", "Wehner, Lesch and Wilkinson", "http://loma.net", "America/D" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Ullam sed ab ut. Sit commodi consequatur expedita voluptatem et. Eveniet eaque non quasi veniam. Quibusdam ut voluptatibus tempore culpa natus similique necessitatibus eaque.", "Nikolaus, Moore and Wilkinson", "https://ray.com", "Asia/Kolk" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Sit labore vitae et aut nihil voluptatibus accusamus. Eos vel eum odit non. Ipsum adipisci illum sed voluptates sed est. Cumque quaerat ipsa et iusto minus illo. Ipsam sint sunt excepturi aspernatur assumenda incidunt.", "Breitenberg Group", "https://lucie.name", "Pacific/M" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Aut reprehenderit voluptatem omnis est nihil error est nisi.\nRerum numquam aspernatur illo asperiores cupiditate quisquam voluptas in.\nHarum cum asperiores labore eum temporibus harum.\nEveniet dolor veniam.\nAd eum necessitatibus vel ipsum tempore.\nOfficia veniam atque dolor ut ipsa.", "Swift, Stracke and Shields", "https://gerda.org", "Europe/Ro" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "est", "Hammes, Zemlak and Bosco", "https://jaunita.info", "Pacific/P" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Et quia non consectetur laboriosam.", "Schroeder Inc", "https://brennon.net", "America/L" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Sit exercitationem id sed quidem.\nQuaerat voluptatum eum quos corporis aut dolore.", "Ondricka Group", "https://grayson.net", "Europe/Wa" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Reiciendis minima est consequuntur nisi sint omnis eum excepturi enim.", "Maggio, Nolan and Kris", "https://adela.com", "Europe/Lo" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "facilis", "Hills, Yost and Beahan", "https://luna.name", "Europe/Lo" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Terry.Moen12@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/348.jpg", "Terry Moen", "1-943-310-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Annie71@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/790.jpg", "Annie Mosciski", "784.508.33", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Nathaniel16@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/623.jpg", "Nathaniel Cummerata", "(902) 538-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Katherine_Kerluke10@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/352.jpg", "Katherine Kerluke", "1-556-841-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Drew_Bins@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/379.jpg", "Drew Bins", "1-549-758-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Blake46@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1067.jpg", "Blake Graham", "(971) 896-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Doug26@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1018.jpg", "Doug White", "(861) 786-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Marshall87@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/185.jpg", "Marshall Rodriguez", "359-358-76", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Whitney73@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1137.jpg", "Whitney Bednar", "671-571-93", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Amos21@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/851.jpg", "Amos Barton", "1-333-246-" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordProtectionIsUsed",
                table: "AvailabilitySlots");

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
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 8, 20, 6, 1, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 8, 21, 7, 1, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 1, 10, 3, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 8, 11, 7, 4, 12 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 6, 8, 3, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 3, 7, 3, 3, 15 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 4, 30, 8, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 27, 4, 5, 6 });

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
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 1, 21, 6, 28, 45, 681, DateTimeKind.Unspecified).AddTicks(4271), 25, "http://asia.com", 4L, "quam", 25, 7L, "Quas sed nihil repudiandae.\nArchitecto possimus beatae.\nConsequuntur et ipsum corrupti ipsum dolores.\nSit quam iure maiores corporis soluta.\nAmet veniam ratione voluptatem officiis repellendus alias quis aut." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 5, 5, 19, 3, 31, 65, DateTimeKind.Unspecified).AddTicks(2180), 24, "https://mckenna.net", "commodi", 53, 4L, "tenetur" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 10, 13, 14, 32, 14, 370, DateTimeKind.Unspecified).AddTicks(2793), 20, "https://katrine.name", 3L, "facilis", 38, 3L, 0, "Dolorum rerum tenetur quia.\nAut tempore tempora odio natus laudantium nobis at qui.\nTempore aut aut.\nVoluptas vitae deleniti est qui." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 1, 31, 17, 41, 39, 893, DateTimeKind.Unspecified).AddTicks(7252), 18, "https://betsy.info", 2L, "qui", 53, 2L, "Illum fugiat debitis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 12, 17, 0, 22, 28, 823, DateTimeKind.Unspecified).AddTicks(5306), 16, "http://judson.com", 3L, "et", 23, 4L, 1, "Sed rerum alias voluptatem quia facere facere praesentium." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 12, 22, 17, 28, 3, 995, DateTimeKind.Unspecified).AddTicks(5777), 24, "https://quinten.net", 4L, "modi", 36, 10L, 0, "et" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 9, 13, 10, 48, 43, 65, DateTimeKind.Unspecified).AddTicks(641), 19, "https://bridgette.info", 1L, "atque", 52, 5L, "Quos fugiat hic consequatur ratione voluptatum sed. Commodi porro ipsum eaque voluptatem eaque in. Voluptate aliquam recusandae. Dolores omnis saepe aliquam et iusto maxime asperiores a. Aut eveniet distinctio." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2019, 7, 25, 21, 36, 39, 608, DateTimeKind.Unspecified).AddTicks(7362), 25, "https://hubert.net", "rerum", 19, 10L, 0, "Sit saepe ut voluptatibus natus facere aut voluptas ad.\nInventore reiciendis molestias.\nArchitecto totam qui ut.\nRem non consequuntur excepturi cumque eveniet cumque omnis omnis consequatur.\nAdipisci repellat similique voluptatem eos laudantium doloremque magni." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2019, 12, 9, 5, 12, 42, 385, DateTimeKind.Unspecified).AddTicks(6336), 26, "http://catharine.name", 1L, 24, 2L, 1, "Temporibus qui ut placeat. Maiores quo omnis quos similique labore qui velit. Dolores corporis qui omnis dolores voluptatem natus assumenda voluptas. Et distinctio velit et optio omnis iure vel quia. Asperiores esse similique eligendi exercitationem vel vel voluptas est repudiandae." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 11, 8, 9, 18, 33, 851, DateTimeKind.Unspecified).AddTicks(727), 22, "http://wilma.info", 3L, "eligendi", 60, 6L, "Qui dolor repellendus omnis vitae. Ut distinctio corporis aut. Quaerat autem eos. Non assumenda enim nihil dignissimos facilis quos. Et nihil minus quae autem perspiciatis consectetur." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2019, 7, 21, 14, 57, 22, 712, DateTimeKind.Unspecified).AddTicks(7752), 3L, 8L });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2019, 10, 18, 0, 46, 42, 63, DateTimeKind.Unspecified).AddTicks(1233), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2020, 3, 17, 13, 10, 28, 690, DateTimeKind.Unspecified).AddTicks(8559), 7L, 10L });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2019, 8, 27, 0, 33, 19, 1, DateTimeKind.Unspecified).AddTicks(5354), 1L });

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
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1754), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 16, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1743), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Carrie90@gmail.comAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 3, 23, 8, 17, 49, 498, DateTimeKind.Unspecified).AddTicks(6682), new TimeSpan(0, 2, 0, 0, 0)), "Carrie Green" });

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
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Lloyd98@hotmail.comAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 3, 12, 13, 6, 55, 162, DateTimeKind.Unspecified).AddTicks(4456), new TimeSpan(0, 2, 0, 0, 0)), "Lloyd Reichert" });

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
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Lorene.Koss38@yahoo.comAAAAAAA", new DateTimeOffset(new DateTime(2022, 9, 2, 11, 20, 34, 467, DateTimeKind.Unspecified).AddTicks(8404), new TimeSpan(0, 3, 0, 0, 0)), "Lorene Koss" });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 2, 12, 22, 27, 14, 889, DateTimeKind.Unspecified).AddTicks(9024), 8L, "Accusantium consectetur nam temporibus eveniet quo", 34, 3L, "in", new DateTimeOffset(new DateTime(2022, 11, 9, 9, 50, 6, 10, DateTimeKind.Unspecified).AddTicks(8892), new TimeSpan(0, 2, 0, 0, 0)), 7L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 28, 17, 58, 34, 176, DateTimeKind.Unspecified).AddTicks(976), 7L, "eos", 18, 3L, "earum", new DateTimeOffset(new DateTime(2022, 12, 12, 16, 12, 9, 708, DateTimeKind.Unspecified).AddTicks(8214), new TimeSpan(0, 2, 0, 0, 0)), 6L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 28, 15, 16, 50, 163, DateTimeKind.Unspecified).AddTicks(4559), 3L, "culpa", 50, "dicta", new DateTimeOffset(new DateTime(2023, 2, 4, 19, 50, 23, 705, DateTimeKind.Unspecified).AddTicks(3759), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 27, 0, 30, 43, 297, DateTimeKind.Unspecified).AddTicks(9952), 6L, "Minus tempore et aut sint ducimus inventore.\nUt id", 2L, "molestiae", new DateTimeOffset(new DateTime(2023, 1, 19, 6, 49, 17, 750, DateTimeKind.Unspecified).AddTicks(8110), new TimeSpan(0, 2, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2021, 1, 16, 10, 47, 58, 433, DateTimeKind.Unspecified).AddTicks(4043), 5L, "dolores", 41, 2L, "dicta", new DateTimeOffset(new DateTime(2023, 5, 21, 14, 22, 14, 257, DateTimeKind.Unspecified).AddTicks(5347), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 36, 6, 350, DateTimeKind.Unspecified).AddTicks(9519), 8L, "Qui consequatur ut sit corporis accusantium volupt", 5L, "rerum", new DateTimeOffset(new DateTime(2022, 12, 13, 3, 8, 32, 437, DateTimeKind.Unspecified).AddTicks(7577), new TimeSpan(0, 2, 0, 0, 0)), 10L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 10, 10, 8, 7, 27, 400, DateTimeKind.Unspecified).AddTicks(3247), 6L, "Voluptatum mollitia maiores itaque voluptatem dolo", 57, 5L, "nam", new DateTimeOffset(new DateTime(2023, 4, 8, 8, 1, 36, 377, DateTimeKind.Unspecified).AddTicks(3085), new TimeSpan(0, 3, 0, 0, 0)), 6L });

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
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "totamAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

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
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Qui nam facilis recusandae esse ea voluptatem repudiandae libero animi." });

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
                column: "Role",
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
                column: "Role",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Role",
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
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Status",
                value: 1);

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Sara7@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/514.jpg", "Sara Runte", "491.689.80", 1 });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Roberto99@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/7.jpg", "Roberto Dooley", "1-259-855-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Fred.Paucek35@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/521.jpg", "Fred Paucek", "1-640-543-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Eric69@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/117.jpg", "Eric Mosciski", "1-714-512-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Erma.Braun68@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/703.jpg", "Erma Braun", "1-225-938-" });

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
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Mitchell_Schamberger27@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1076.jpg", "Mitchell Schamberger", "1-437-406-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Lucille17@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1179.jpg", "Lucille Hegmann", "959.651.14", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Kristine.Keeling@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/458.jpg", "Kristine Keeling", "(883) 647-" });
        }
    }
}
