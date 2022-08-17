using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class Changetimezonetoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 4, 12, 3, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 22, 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 6, 7, 1, 4, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 1, 5, 5, 4, 5 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 7, 18, 10, 2, 15 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 8, 5, 5, 5, 7 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 26, 5, 5, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Color", "Days", "PaddingMeeting" },
                values: new object[] { 4, 7, 5 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 3, 1, 20, 9, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 4, 8, 3, 5 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 11, 25, 0, 49, 37, 749, DateTimeKind.Unspecified).AddTicks(2038), 20, "http://gabriel.com", 5L, "qui", 28, 5L, "Sit repudiandae occaecati tenetur consequuntur pariatur qui error alias. Debitis est nihil minima sunt debitis adipisci natus. Recusandae et earum error velit et qui. Repellat asperiores dolorem ea sed maiores sit incidunt consequatur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 11, 25, 6, 29, 12, 400, DateTimeKind.Unspecified).AddTicks(2532), 28, "https://kali.biz", 4L, "asperiores", 56, 3L, "Fuga delectus quia facere. Velit eos nam. Porro necessitatibus id quasi. Eum illum quos iure assumenda pariatur est praesentium ut. Perferendis voluptatem illo. Iure qui quia in laborum eaque laborum quos reiciendis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 6, 11, 7, 8, 13, 542, DateTimeKind.Unspecified).AddTicks(5350), 23, "https://myrna.org", "a", 38, 6L, "Dicta et tempore." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 8, 21, 9, 40, 32, 389, DateTimeKind.Unspecified).AddTicks(6414), "https://ubaldo.biz", "tempora", 16, 10L, "Tempore fugiat ab. Eaque autem accusantium omnis qui molestias maxime dolores totam ad. Aspernatur voluptate similique qui sed iste labore." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 8, 7, 21, 31, 7, 355, DateTimeKind.Unspecified).AddTicks(1439), 17, "https://shanny.org", 3L, "rerum", 57, 1L, 1, "beatae" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2019, 12, 27, 10, 55, 51, 312, DateTimeKind.Unspecified).AddTicks(8790), 20, "http://penelope.biz", 1L, "iusto", 16, 6L, 0, "Non in est et iste qui vitae velit." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 2, 23, 13, 6, 54, 527, DateTimeKind.Unspecified).AddTicks(8619), 27, "https://myrl.net", "sit", 21, 8L, 1, "Commodi quae ea doloribus.\nVoluptatem provident quia.\nUt aliquid iure.\nOdio ipsa iste voluptas voluptas voluptatem doloremque facilis libero praesentium.\nDolor commodi est eum perferendis veritatis consectetur sunt.\nSint et iste." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 5, 5, 17, 37, 49, 336, DateTimeKind.Unspecified).AddTicks(9867), 27, "http://jermey.name", 2L, "in", 18, 4L, 0, "blanditiis" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 10, 7, 21, 17, 6, 720, DateTimeKind.Unspecified).AddTicks(1063), 21, "https://zane.net", 2L, "repellat", 46, 5L, 0, "Magni accusantium et eos similique quas.\nArchitecto sunt at corporis in soluta.\nNecessitatibus aliquid quia temporibus vero.\nDucimus id qui nihil commodi eaque iusto itaque assumenda esse." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2019, 10, 6, 16, 45, 58, 734, DateTimeKind.Unspecified).AddTicks(4672), 21, "https://kayli.biz", "nesciunt", 27, "Culpa animi porro dignissimos aut labore dolorum eos officia autem.\nNisi temporibus cum illum quis dolorem odit dolor magni aut." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2021, 4, 15, 5, 38, 15, 756, DateTimeKind.Unspecified).AddTicks(2021), 8L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 9L, new DateTime(2019, 10, 24, 1, 58, 14, 992, DateTimeKind.Unspecified).AddTicks(4522), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 3, 6, 8, 35, 1, 64, DateTimeKind.Unspecified).AddTicks(414), 8L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2019, 12, 12, 22, 49, 31, 374, DateTimeKind.Unspecified).AddTicks(3905), 1L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 4, 13, 14, 40, 44, 989, DateTimeKind.Unspecified).AddTicks(209), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 3, 26, 10, 16, 54, 50, DateTimeKind.Unspecified).AddTicks(8006), 5L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2020, 9, 19, 8, 3, 54, 834, DateTimeKind.Unspecified).AddTicks(3166), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 7, 25, 18, 21, 59, 181, DateTimeKind.Unspecified).AddTicks(6977), 3L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 5, 28, 5, 19, 2, 466, DateTimeKind.Unspecified).AddTicks(2224), 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 4, 8, 2, 21, 27, 173, DateTimeKind.Unspecified).AddTicks(6181), 8L, 8L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(4900), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(4709), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5102), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5087), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5137), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5126), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5170), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 18, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5159), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5202), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5191), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5235), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5224), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5300), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5289), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5332), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5321), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5364), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5353), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5396), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 48, 27, 61, DateTimeKind.Unspecified).AddTicks(5385), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Tom_Daniel@hotmail.com", new DateTimeOffset(new DateTime(2023, 5, 13, 5, 57, 1, 323, DateTimeKind.Unspecified).AddTicks(1889), new TimeSpan(0, 3, 0, 0, 0)), "Tom Daniel" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Vanessa78@gmail.com", new DateTimeOffset(new DateTime(2023, 1, 23, 3, 14, 57, 686, DateTimeKind.Unspecified).AddTicks(9248), new TimeSpan(0, 2, 0, 0, 0)), "Vanessa Thiel" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Kendra.Farrell@gmail.com", new DateTimeOffset(new DateTime(2023, 3, 28, 2, 12, 21, 462, DateTimeKind.Unspecified).AddTicks(2868), new TimeSpan(0, 3, 0, 0, 0)), "Kendra Farrell" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Alex5@hotmail.com", new DateTimeOffset(new DateTime(2023, 2, 28, 23, 1, 11, 939, DateTimeKind.Unspecified).AddTicks(2724), new TimeSpan(0, 2, 0, 0, 0)), "Alex Cassin" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Mattie.Okuneva53@yahoo.com", new DateTimeOffset(new DateTime(2023, 1, 12, 11, 11, 27, 450, DateTimeKind.Unspecified).AddTicks(5277), new TimeSpan(0, 2, 0, 0, 0)), "Mattie Okuneva" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Raymond54@gmail.com", new DateTimeOffset(new DateTime(2022, 9, 12, 21, 29, 39, 774, DateTimeKind.Unspecified).AddTicks(4924), new TimeSpan(0, 3, 0, 0, 0)), "Raymond Ankunding" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Victor42@gmail.com", new DateTimeOffset(new DateTime(2022, 9, 12, 4, 28, 8, 622, DateTimeKind.Unspecified).AddTicks(5013), new TimeSpan(0, 3, 0, 0, 0)), "Victor Kuhlman" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Vernon57@yahoo.com", new DateTimeOffset(new DateTime(2022, 11, 13, 21, 16, 4, 103, DateTimeKind.Unspecified).AddTicks(6300), new TimeSpan(0, 2, 0, 0, 0)), "Vernon Lakin" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Victoria.Bode30@hotmail.com", new DateTimeOffset(new DateTime(2022, 12, 20, 23, 58, 18, 123, DateTimeKind.Unspecified).AddTicks(2257), new TimeSpan(0, 2, 0, 0, 0)), "Victoria Bode" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Jordan94@yahoo.com", new DateTimeOffset(new DateTime(2023, 2, 22, 20, 23, 13, 667, DateTimeKind.Unspecified).AddTicks(357), new TimeSpan(0, 2, 0, 0, 0)), "Jordan Olson" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 30, 2, 58, 53, 763, DateTimeKind.Unspecified).AddTicks(5288), 10L, "aspernatur", 14, 3L, "soluta", new DateTimeOffset(new DateTime(2022, 11, 13, 22, 10, 31, 763, DateTimeKind.Unspecified).AddTicks(3085), new TimeSpan(0, 2, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 12, 29, 3, 27, 48, 102, DateTimeKind.Unspecified).AddTicks(9419), 9L, "Repellendus asperiores accusamus explicabo quibusd", 11, 2L, "aut", new DateTimeOffset(new DateTime(2023, 7, 27, 4, 43, 4, 659, DateTimeKind.Unspecified).AddTicks(2895), new TimeSpan(0, 3, 0, 0, 0)), 7L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2019, 11, 4, 10, 51, 1, 775, DateTimeKind.Unspecified).AddTicks(2473), 3L, "distinctio", 50, 2L, "esse", new DateTimeOffset(new DateTime(2022, 10, 9, 18, 4, 29, 550, DateTimeKind.Unspecified).AddTicks(5329), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 34, 20, 852, DateTimeKind.Unspecified).AddTicks(4025), 3L, "Omnis non fugiat velit voluptate aspernatur delect", 60, "laudantium", new DateTimeOffset(new DateTime(2022, 11, 9, 19, 5, 23, 127, DateTimeKind.Unspecified).AddTicks(3291), new TimeSpan(0, 2, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 29, 17, 4, 1, 196, DateTimeKind.Unspecified).AddTicks(4264), 1L, "Molestiae voluptatem nihil placeat et sint ipsa vo", 12, 5L, "dicta", new DateTimeOffset(new DateTime(2023, 1, 7, 14, 37, 56, 781, DateTimeKind.Unspecified).AddTicks(9239), new TimeSpan(0, 2, 0, 0, 0)), 7L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 11, 25, 2, 33, 3, 829, DateTimeKind.Unspecified).AddTicks(444), 4L, "Ad et et ab temporibus eligendi porro ad provident", 24, 2L, "mollitia", new DateTimeOffset(new DateTime(2023, 3, 26, 6, 57, 5, 249, DateTimeKind.Unspecified).AddTicks(112), new TimeSpan(0, 3, 0, 0, 0)), 7L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2021, 5, 16, 16, 47, 18, 79, DateTimeKind.Unspecified).AddTicks(4556), 9L, "Aut qui nam.", 21, 3L, "omnis", new DateTimeOffset(new DateTime(2023, 2, 8, 9, 26, 52, 312, DateTimeKind.Unspecified).AddTicks(5994), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 6, 15, 19, 32, 2, 117, DateTimeKind.Unspecified).AddTicks(1958), 7L, "Vitae temporibus itaque itaque et.\nOptio porro rep", 57, 5L, "alias", new DateTimeOffset(new DateTime(2023, 1, 4, 23, 19, 47, 64, DateTimeKind.Unspecified).AddTicks(6051), new TimeSpan(0, 2, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 29, 23, 51, 49, 660, DateTimeKind.Unspecified).AddTicks(1357), 8L, "Cupiditate assumenda voluptatibus consequatur mole", 49, 5L, "illo", new DateTimeOffset(new DateTime(2023, 5, 31, 12, 44, 2, 360, DateTimeKind.Unspecified).AddTicks(717), new TimeSpan(0, 3, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 10, 24, 13, 13, 6, 409, DateTimeKind.Unspecified).AddTicks(4726), 4L, "natus", 20, 5L, "perspiciatis", new DateTimeOffset(new DateTime(2022, 11, 12, 11, 20, 9, 505, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 2, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Dolorem expedita voluptate tenetur.AAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Et qui aspernatur.\nAut aliquid deserunt tempora dolores omnis magnam ea." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Aliquid sit soluta molestias ipsam qui.AAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Et veritatis et expedita magnam in accusantium magni. Recusandae ut provident. Labore voluptatum id similique repudiandae. Debitis est autem quis vitae enim architecto. Ullam quis illum quia ducimus minima consectetur officia." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Beatae et non incidunt et illo consequuntur dolorem. Et tenetur maxime non beatae delectus placeat. Fugiat minima soluta qui perferendis." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Est similique voluptatem nam quia occaecati voluptatum sed ut quia. Quo in et. In magnam sit in est est in repellat magni quas. Culpa aliquid voluptas." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Deserunt eveniet deserunt in.AAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Text",
                value: "Expedita minima quibusdam deleniti repudiandae aut ut veritatis doloribus id. Consequatur porro reiciendis suscipit rerum laboriosam minus non. Fuga quos dolorum. Sed molestias debitis aut perspiciatis labore nostrum delectus consequuntur maxime.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Numquam ea consequatur molestiae quidem eum dolores provident. Inventore aperiam qui consequatur. Dolor et iure fugit consequatur animi quod. Quis velit quo dolores dolorum sed. Dolores beatae quo." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Modi odit ut qui nemo sit. Iste consequatur fugiat tempora. Odio dolorum culpa officia fuga omnis. Nihil amet quas nemo." });

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Priority",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Priority",
                value: 10);

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
                value: 5);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Priority",
                value: 4);

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
                value: 2);

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
                value: 1);

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

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
                values: new object[] { 1, 2 });

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
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Rerum eum eum repellendus illum voluptatum veniam dolorem animi.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/625.jpg", "Bergnaum - Pagac", "http://coty.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Corporis totam iste consectetur. Omnis eum vel porro similique veritatis suscipit. Expedita eius voluptatem voluptatem molestiae veritatis consectetur. Quis sequi beatae.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/74.jpg", "Kuhlman Inc", "http://stan.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Inventore voluptates consequatur quis tempora cumque rerum.\nRepellat est voluptas et qui et perspiciatis.\nNatus consequatur qui aut vel quibusdam fuga ea id.\nMaiores culpa doloribus quisquam nemo aliquam porro rerum.\nExplicabo quia velit ab perferendis magnam.\nAut dolore sit vel error dolor praesen", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/165.jpg", "Smitham - Marks", "https://rocio.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Quidem rerum ipsum molestias iure et consequatur. Temporibus est voluptatum quibusdam laborum veniam. Corporis totam laborum occaecati dicta cupiditate quam facere. Qui et aut soluta adipisci quo corrupti voluptatibus est.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/478.jpg", "DuBuque, Lockman and Stanton", "http://river.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Possimus cumque odit magnam mollitia voluptas voluptatibus nobis nobis.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1248.jpg", "Wilkinson - Kuvalis", "https://eula.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Pariatur et maiores dicta.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/907.jpg", "Deckow - Greenfelder", "https://modesta.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Harum magni dolor nostrum officia distinctio id natus a.\nExpedita hic voluptas veritatis ut officia.\nSed eum ut aut temporibus eveniet expedita cupiditate cumque et.\nEt laboriosam hic.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/30.jpg", "Kuhic, Bernhard and Kilback", "http://lolita.name" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Doloribus molestiae amet quas est.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/692.jpg", "Morissette, Blick and Zulauf", "https://susan.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "nihil", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1029.jpg", "Kunde Group", "https://chandler.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Iure qui et repellat et. Magni voluptatem doloribus voluptas dolorem velit quia. Perspiciatis dicta ex qui sunt pariatur similique autem exercitationem perspiciatis.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/801.jpg", "Blick, Corkery and Flatley", "https://jerome.net" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Otis.Flatley@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/53.jpg", "Otis Flatley", "(274) 586-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Blake.Nikolaus@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/146.jpg", "Blake Nikolaus", "1-670-986-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Rodney47@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/269.jpg", "Rodney Pfeffer", "(832) 924-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Gerald_Altenwerth@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/412.jpg", "Gerald Altenwerth", "1-404-360-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Van_Doyle78@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/979.jpg", "Van Doyle", "365-548-83", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Judith.Kirlin@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/672.jpg", "Judith Kirlin", "257.921.14", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Darin.Wilkinson62@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/860.jpg", "Darin Wilkinson", "695-403-96", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Leland_Parker62@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/316.jpg", "Leland Parker", "(282) 440-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Jody.Runte@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/392.jpg", "Jody Runte", "1-999-507-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Roberto10@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/41.jpg", "Roberto Kris", "1-353-458-" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 2, 11, 2, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 5, 27, 10, 4, 13 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 2, 4, 1, 7 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 2, 20, 7, 2, 7 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 6, 13, 3, 4, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 1, 18, 9, 2, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 5, 16, 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Color", "Days", "PaddingMeeting" },
                values: new object[] { 7, 5, 13 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 1, 6, 16, 1, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 3, 11, 2, 3 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 4, 28, 9, 29, 9, 409, DateTimeKind.Unspecified).AddTicks(6212), 21, "http://horacio.name", 3L, "ut", 35, 9L, "Quibusdam adipisci quia aliquid velit perferendis porro quia modi dicta. Dicta facere et et fugiat et voluptatem voluptatum. Distinctio saepe laborum asperiores dolorem. Eum et rem corrupti. Nihil modi expedita neque et. Aut id omnis sed harum maxime." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 3, 6, 4, 34, 51, 8, DateTimeKind.Unspecified).AddTicks(5160), 26, "https://stephany.biz", 3L, "labore", 17, 8L, "Magnam sed ut quis omnis corporis.\nBeatae delectus et odio consequuntur natus illo et expedita et.\nCum aut quas tempore vero voluptatem optio qui natus qui.\nIncidunt quam corporis voluptatibus rerum culpa animi explicabo molestiae temporibus.\nExpedita esse in eos autem facilis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 3, 9, 4, 8, 6, 388, DateTimeKind.Unspecified).AddTicks(2423), 28, "http://eldon.name", "libero", 35, 7L, "Labore rem cum occaecati dicta.\nDolor alias magnam.\nRecusandae in quasi soluta voluptas nihil eius.\nEt amet perferendis sunt repellat ab.\nAdipisci nam ut.\nQuidem omnis aut sequi." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 2, 20, 18, 28, 0, 682, DateTimeKind.Unspecified).AddTicks(2638), "http://carroll.biz", "delectus", 58, 1L, "Excepturi ratione beatae beatae quaerat.\nNostrum voluptates iure.\nAtque corporis non nostrum odit est." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 32, 11, 782, DateTimeKind.Unspecified).AddTicks(2325), 21, "http://nicholaus.org", 4L, "ut", 47, 8L, 0, "sint" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 1, 11, 16, 48, 32, 846, DateTimeKind.Unspecified).AddTicks(3747), 18, "http://florian.net", 5L, "consequuntur", 27, 5L, 1, "Voluptatibus ipsa vel ad aut dolorum saepe rem quidem. Adipisci facilis sapiente ut esse ut aut. Omnis provident consequuntur voluptatibus voluptatibus." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 12, 1, 14, 13, 49, 311, DateTimeKind.Unspecified).AddTicks(2250), 25, "http://alexandria.net", "qui", 47, 4L, 0, "Molestias eos repellat beatae dolorum ea nostrum voluptatem eos ut." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 1, 1, 16, 16, 16, 62, DateTimeKind.Unspecified).AddTicks(5523), 25, "https://annetta.net", 5L, "totam", 57, 9L, 1, "Voluptatem sit animi itaque nemo laudantium.\nPariatur quibusdam magni ut.\nNon voluptatem culpa minima dolorum dolor molestiae quis.\nUt illo fugiat tempore asperiores omnis iure unde.\nQui rerum ipsa est.\nRerum pariatur aut et laudantium molestiae eaque magnam cumque nemo." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2021, 3, 28, 18, 55, 34, 72, DateTimeKind.Unspecified).AddTicks(7119), 27, "https://delmer.name", 1L, "aut", 31, 2L, 1, "Nihil temporibus voluptas possimus ut quod. Quod est quibusdam consectetur nisi laudantium et voluptas. Asperiores dicta impedit. Iusto deleniti qui a qui. Sit nam sequi assumenda modi." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 2, 12, 22, 42, 25, 873, DateTimeKind.Unspecified).AddTicks(5477), 29, "https://kristoffer.biz", "et", 37, "dolorum" });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2021, 1, 1, 23, 43, 43, 337, DateTimeKind.Unspecified).AddTicks(1935), 10L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 2L, new DateTime(2021, 1, 23, 22, 58, 20, 994, DateTimeKind.Unspecified).AddTicks(6546), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2021, 4, 23, 14, 13, 49, 115, DateTimeKind.Unspecified).AddTicks(3452), 7L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2021, 5, 4, 8, 52, 34, 269, DateTimeKind.Unspecified).AddTicks(9379), 7L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 1, 9, 20, 17, 8, 250, DateTimeKind.Unspecified).AddTicks(6322), 2L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2021, 5, 21, 7, 33, 49, 423, DateTimeKind.Unspecified).AddTicks(8180), 7L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 4, 23, 19, 37, 23, 332, DateTimeKind.Unspecified).AddTicks(3138), 7L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2020, 10, 13, 11, 48, 55, 374, DateTimeKind.Unspecified).AddTicks(849), 9L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 6, 27, 4, 58, 59, 481, DateTimeKind.Unspecified).AddTicks(4372), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2019, 12, 15, 7, 56, 6, 916, DateTimeKind.Unspecified).AddTicks(2028), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(7683), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(7445), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(7938), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(7975), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(7963), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(9053), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 18, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(8960), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(9097), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(9084), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(9132), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(9121), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(9165), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(9154), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(9197), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(9187), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(9227), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(9217), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(9257), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(9247), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Teresa46@yahoo.com", new DateTimeOffset(new DateTime(2023, 2, 5, 9, 24, 28, 690, DateTimeKind.Unspecified).AddTicks(1948), new TimeSpan(0, 2, 0, 0, 0)), "Teresa O'Keefe" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Maggie38@hotmail.com", new DateTimeOffset(new DateTime(2023, 7, 31, 8, 13, 31, 536, DateTimeKind.Unspecified).AddTicks(3432), new TimeSpan(0, 3, 0, 0, 0)), "Maggie Stracke" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Santiago_Collier32@yahoo.com", new DateTimeOffset(new DateTime(2023, 6, 3, 0, 29, 23, 129, DateTimeKind.Unspecified).AddTicks(7763), new TimeSpan(0, 3, 0, 0, 0)), "Santiago Collier" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Lynn.Beahan@yahoo.com", new DateTimeOffset(new DateTime(2022, 11, 15, 3, 10, 6, 754, DateTimeKind.Unspecified).AddTicks(5221), new TimeSpan(0, 2, 0, 0, 0)), "Lynn Beahan" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Becky_Schumm34@gmail.com", new DateTimeOffset(new DateTime(2022, 8, 21, 21, 4, 34, 237, DateTimeKind.Unspecified).AddTicks(156), new TimeSpan(0, 3, 0, 0, 0)), "Becky Schumm" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Lois78@gmail.com", new DateTimeOffset(new DateTime(2023, 8, 5, 5, 52, 58, 657, DateTimeKind.Unspecified).AddTicks(7436), new TimeSpan(0, 3, 0, 0, 0)), "Lois Schinner" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Louise_Cole@hotmail.com", new DateTimeOffset(new DateTime(2022, 10, 20, 6, 46, 0, 659, DateTimeKind.Unspecified).AddTicks(2183), new TimeSpan(0, 3, 0, 0, 0)), "Louise Cole" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Victoria.Gutmann64@hotmail.co", new DateTimeOffset(new DateTime(2023, 7, 18, 6, 22, 56, 202, DateTimeKind.Unspecified).AddTicks(5071), new TimeSpan(0, 3, 0, 0, 0)), "Victoria Gutmann" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Janis_Hoeger32@gmail.com", new DateTimeOffset(new DateTime(2022, 11, 25, 9, 51, 33, 334, DateTimeKind.Unspecified).AddTicks(2059), new TimeSpan(0, 2, 0, 0, 0)), "Janis Hoeger" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Jacqueline31@hotmail.com", new DateTimeOffset(new DateTime(2022, 11, 11, 9, 31, 16, 1, DateTimeKind.Unspecified).AddTicks(5325), new TimeSpan(0, 2, 0, 0, 0)), "Jacqueline Greenfelder" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 8, 18, 1, 28, 33, 721, DateTimeKind.Unspecified).AddTicks(3088), 6L, "Est eum ipsam illum maiores voluptatibus itaque qu", 11, 5L, "ut", new DateTimeOffset(new DateTime(2023, 1, 7, 15, 0, 56, 582, DateTimeKind.Unspecified).AddTicks(3845), new TimeSpan(0, 2, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 3, 9, 5, 2, 38, 16, DateTimeKind.Unspecified).AddTicks(8977), 8L, "Sint eius autem possimus ex distinctio explicabo n", 57, 3L, "et", new DateTimeOffset(new DateTime(2022, 9, 13, 19, 46, 43, 186, DateTimeKind.Unspecified).AddTicks(2049), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2021, 5, 27, 9, 47, 28, 467, DateTimeKind.Unspecified).AddTicks(9695), 4L, "Praesentium reprehenderit nesciunt et.", 38, 3L, "dolorum", new DateTimeOffset(new DateTime(2023, 1, 19, 18, 32, 15, 870, DateTimeKind.Unspecified).AddTicks(2410), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 18, 3, 51, 25, 585, DateTimeKind.Unspecified).AddTicks(9433), 10L, "Ipsam numquam omnis. Voluptatem ad eveniet. Et cup", 36, "minus", new DateTimeOffset(new DateTime(2023, 7, 10, 1, 46, 54, 833, DateTimeKind.Unspecified).AddTicks(719), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 7, 25, 12, 4, 22, 422, DateTimeKind.Unspecified).AddTicks(5893), 6L, "Ad recusandae voluptas ex est enim modi cumque und", 38, 1L, "quisquam", new DateTimeOffset(new DateTime(2023, 4, 17, 12, 34, 1, 974, DateTimeKind.Unspecified).AddTicks(1686), new TimeSpan(0, 3, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 8, 3, 20, 0, 36, 158, DateTimeKind.Unspecified).AddTicks(1742), 7L, "Debitis accusantium et et. Quos laudantium quia qu", 29, 3L, "dolore", new DateTimeOffset(new DateTime(2023, 1, 26, 13, 15, 7, 660, DateTimeKind.Unspecified).AddTicks(1717), new TimeSpan(0, 2, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2021, 6, 28, 13, 45, 20, 299, DateTimeKind.Unspecified).AddTicks(621), 7L, "Omnis repellat voluptatibus commodi corporis conse", 30, 5L, "rerum", new DateTimeOffset(new DateTime(2022, 10, 2, 13, 42, 12, 325, DateTimeKind.Unspecified).AddTicks(2996), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 6, 11, 23, 49, 19, 201, DateTimeKind.Unspecified).AddTicks(4009), 9L, "et", 22, 3L, "necessitatibus", new DateTimeOffset(new DateTime(2023, 3, 23, 23, 14, 25, 168, DateTimeKind.Unspecified).AddTicks(1955), new TimeSpan(0, 2, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 10, 27, 6, 25, 26, 756, DateTimeKind.Unspecified).AddTicks(3975), 2L, "Et cupiditate laborum.\nSit exercitationem voluptat", 38, 2L, "voluptas", new DateTimeOffset(new DateTime(2022, 10, 31, 0, 2, 23, 202, DateTimeKind.Unspecified).AddTicks(7165), new TimeSpan(0, 2, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 15, 12, 21, 12, 479, DateTimeKind.Unspecified).AddTicks(4203), 9L, "Officia laudantium nihil omnis excepturi eius. Vol", 43, 4L, "incidunt", new DateTimeOffset(new DateTime(2023, 1, 14, 11, 9, 25, 175, DateTimeKind.Unspecified).AddTicks(4868), new TimeSpan(0, 2, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "In debitis est et totam consequuntur. Voluptas totam odio aut eos blanditiis. Sit voluptas maiores reiciendis aut vel maiores id. Consequatur ut laudantium aut voluptatem est voluptatem esse. Reiciendis reiciendis illo vitae itaque. Repellat perferendis voluptatem repellat dicta et sit." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "facilisAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "molestiaeAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Cumque dolor nemo quia ut et dicta sit.\nExplicabo explicabo odit ea laborum unde repellendus provident.\nEnim id velit eaque velit.\nFacere id vel excepturi id voluptatem aliquam voluptatem." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Dolorem est non quidem possimus magni.AAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Ipsum dolor in delectus maiores.AAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Qui velit et hic quos quo doloribus voluptate.AAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Text",
                value: "Aut ex ipsam commodi distinctio soluta culpa fuga. Fuga ipsam temporibus architecto magnam repudiandae. Odio qui voluptate sed quo asperiores voluptatem qui est. Possimus quibusdam dignissimos ut consequatur. Officia nostrum sint et dolores.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Est quaerat in rerum quae.AAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Repellat et nesciunt reiciendis nihil quisquam quasi quis." });

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Priority",
                value: 1);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Priority",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Priority",
                value: 4);

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
                value: 5);

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
                column: "Status",
                value: 2);

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

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
                values: new object[] { 2, 1 });

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
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Doloremque similique provident. Expedita voluptatum deleniti. Dolores cumque sequi ea culpa corporis cupiditate soluta non. Quas autem amet voluptas sunt quis reprehenderit blanditiis nihil ea.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/726.jpg", "Nikolaus LLC", "http://maud.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Ipsam omnis esse et eligendi excepturi autem a.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/383.jpg", "Hoppe Inc", "http://jett.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Eveniet et veniam similique reiciendis voluptatem eum aut.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1183.jpg", "Medhurst LLC", "https://tillman.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "quibusdam", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/196.jpg", "Stiedemann - Senger", "http://rhett.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "At ducimus ex consequatur.\nNumquam ut minus ut non nulla ipsum.\nQuis quo quia.\nLibero est error.\nEt dolorum perspiciatis totam.\nSint sed maiores aspernatur.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1099.jpg", "Boehm, Jerde and Wolf", "http://russel.net" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Dicta tempore provident.\nQuis placeat iste fugit.\nAut inventore consequuntur dicta aut ratione quia sint.\nIn aut ullam.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1180.jpg", "Bahringer, Kihn and Huels", "https://hilda.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Consectetur molestiae eius neque architecto consequuntur reiciendis. Qui tenetur possimus nesciunt cum. In et sit suscipit rerum quo impedit. Voluptates inventore quidem aut accusamus perferendis magni. Temporibus adipisci qui quis aut eos natus. Provident ad alias id aut.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1020.jpg", "Schaden Inc", "https://jasper.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Laudantium quo earum.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1236.jpg", "O'Connell, Mante and Veum", "http://fermin.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Aperiam numquam expedita ratione impedit animi. Et consequatur nesciunt unde saepe repellat sequi reprehenderit laudantium nisi. Eos sunt amet. Voluptates amet quo rerum. Et aperiam sit aut cupiditate ab et ipsa. Deleniti in accusamus.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1113.jpg", "Vandervort Group", "http://janiya.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "quia", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/428.jpg", "Bins - Ward", "https://zelda.info" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Shannon.Mohr88@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/546.jpg", "Shannon Mohr", "(823) 967-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Warren55@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/891.jpg", "Warren Donnelly", "736.762.82", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Elbert.Klocko78@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1203.jpg", "Elbert Klocko", "(222) 922-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Janis87@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/964.jpg", "Janis Ullrich", "(261) 273-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Cheryl72@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1112.jpg", "Cheryl Towne", "991.929.66", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Willie.Smitham@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/863.jpg", "Willie Smitham", "478-570-48", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Wendy79@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/535.jpg", "Wendy Lindgren", "(698) 389-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Ian.Jones@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/729.jpg", "Ian Jones", "499-390-05" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Hector.Marvin@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/820.jpg", "Hector Marvin", "1-861-709-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Inez.Collier@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/395.jpg", "Inez Collier", "463-684-90" });
        }
    }
}
