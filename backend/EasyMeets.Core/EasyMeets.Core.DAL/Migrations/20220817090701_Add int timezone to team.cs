using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class Addinttimezonetoteam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimeZone",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 2, 11, 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 27, 10, 4, 13 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 1, 2, 4, 1, 7 });

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
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 2, 6, 13, 3, 3 });

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
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings" },
                values: new object[] { 2, 5, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 7, 5, 4, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 6, 16, 1, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 11, 2, 3, 14 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 4, 28, 9, 29, 9, 409, DateTimeKind.Unspecified).AddTicks(6212), 21, "http://horacio.name", 3L, "ut", 35, 9L, 1, "Quibusdam adipisci quia aliquid velit perferendis porro quia modi dicta. Dicta facere et et fugiat et voluptatem voluptatum. Distinctio saepe laborum asperiores dolorem. Eum et rem corrupti. Nihil modi expedita neque et. Aut id omnis sed harum maxime." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 3, 6, 4, 34, 51, 8, DateTimeKind.Unspecified).AddTicks(5160), 26, "https://stephany.biz", 3L, "labore", 17, 8L, "Magnam sed ut quis omnis corporis.\nBeatae delectus et odio consequuntur natus illo et expedita et.\nCum aut quas tempore vero voluptatem optio qui natus qui.\nIncidunt quam corporis voluptatibus rerum culpa animi explicabo molestiae temporibus.\nExpedita esse in eos autem facilis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 3, 9, 4, 8, 6, 388, DateTimeKind.Unspecified).AddTicks(2423), 28, "http://eldon.name", 3L, "libero", 35, 7L, 0, "Labore rem cum occaecati dicta.\nDolor alias magnam.\nRecusandae in quasi soluta voluptas nihil eius.\nEt amet perferendis sunt repellat ab.\nAdipisci nam ut.\nQuidem omnis aut sequi." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 2, 20, 18, 28, 0, 682, DateTimeKind.Unspecified).AddTicks(2638), 23, "http://carroll.biz", 3L, "delectus", 58, 1L, 1, "Excepturi ratione beatae beatae quaerat.\nNostrum voluptates iure.\nAtque corporis non nostrum odit est." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 32, 11, 782, DateTimeKind.Unspecified).AddTicks(2325), 21, "http://nicholaus.org", 4L, "ut", 47, 8L, "sint" });

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
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 12, 1, 14, 13, 49, 311, DateTimeKind.Unspecified).AddTicks(2250), 25, "http://alexandria.net", 2L, "qui", 47, 4L, "Molestias eos repellat beatae dolorum ea nostrum voluptatem eos ut." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 1, 1, 16, 16, 16, 62, DateTimeKind.Unspecified).AddTicks(5523), 25, "https://annetta.net", "totam", 57, 9L, 1, "Voluptatem sit animi itaque nemo laudantium.\nPariatur quibusdam magni ut.\nNon voluptatem culpa minima dolorum dolor molestiae quis.\nUt illo fugiat tempore asperiores omnis iure unde.\nQui rerum ipsa est.\nRerum pariatur aut et laudantium molestiae eaque magnam cumque nemo." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2021, 3, 28, 18, 55, 34, 72, DateTimeKind.Unspecified).AddTicks(7119), 27, "https://delmer.name", 1L, "aut", 31, 2L, "Nihil temporibus voluptas possimus ut quod. Quod est quibusdam consectetur nisi laudantium et voluptas. Asperiores dicta impedit. Iusto deleniti qui a qui. Sit nam sequi assumenda modi." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 2, 12, 22, 42, 25, 873, DateTimeKind.Unspecified).AddTicks(5477), 29, "https://kristoffer.biz", 1L, "et", 37, 1L, 0, "dolorum" });

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
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 1, 23, 22, 58, 20, 994, DateTimeKind.Unspecified).AddTicks(6546), 4L, 5L });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 10L, new DateTime(2021, 5, 4, 8, 52, 34, 269, DateTimeKind.Unspecified).AddTicks(9379), 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 3L, new DateTime(2021, 1, 9, 20, 17, 8, 250, DateTimeKind.Unspecified).AddTicks(6322), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 5L, new DateTime(2021, 5, 21, 7, 33, 49, 423, DateTimeKind.Unspecified).AddTicks(8180), 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 4, 23, 19, 37, 23, 332, DateTimeKind.Unspecified).AddTicks(3138), 8L });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 6, 27, 4, 58, 59, 481, DateTimeKind.Unspecified).AddTicks(4372), 1L, 5L });

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
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(9053), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 6, 59, 626, DateTimeKind.Unspecified).AddTicks(8960), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Maggie38@hotmail.com", new DateTimeOffset(new DateTime(2023, 7, 31, 8, 13, 31, 536, DateTimeKind.Unspecified).AddTicks(3432), new TimeSpan(0, 3, 0, 0, 0)), "Maggie Stracke" });

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
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Janis_Hoeger32@gmail.com", new DateTimeOffset(new DateTime(2022, 11, 25, 9, 51, 33, 334, DateTimeKind.Unspecified).AddTicks(2059), new TimeSpan(0, 2, 0, 0, 0)), "Janis Hoeger" });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 27, 9, 47, 28, 467, DateTimeKind.Unspecified).AddTicks(9695), 4L, "Praesentium reprehenderit nesciunt et.", 38, 3L, "dolorum", new DateTimeOffset(new DateTime(2023, 1, 19, 18, 32, 15, 870, DateTimeKind.Unspecified).AddTicks(2410), new TimeSpan(0, 2, 0, 0, 0)), 2L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 7, 25, 12, 4, 22, 422, DateTimeKind.Unspecified).AddTicks(5893), 6L, "Ad recusandae voluptas ex est enim modi cumque und", 38, "quisquam", new DateTimeOffset(new DateTime(2023, 4, 17, 12, 34, 1, 974, DateTimeKind.Unspecified).AddTicks(1686), new TimeSpan(0, 3, 0, 0, 0)), 4L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 6, 28, 13, 45, 20, 299, DateTimeKind.Unspecified).AddTicks(621), 7L, "Omnis repellat voluptatibus commodi corporis conse", 30, 5L, "rerum", new DateTimeOffset(new DateTime(2022, 10, 2, 13, 42, 12, 325, DateTimeKind.Unspecified).AddTicks(2996), new TimeSpan(0, 3, 0, 0, 0)), 5L });

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
                column: "Text",
                value: "Qui velit et hic quos quo doloribus voluptate.AAAA");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Aut ex ipsam commodi distinctio soluta culpa fuga. Fuga ipsam temporibus architecto magnam repudiandae. Odio qui voluptate sed quo asperiores voluptatem qui est. Possimus quibusdam dignissimos ut consequatur. Officia nostrum sint et dolores." });

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
                keyValue: 6L,
                column: "Priority",
                value: 7);

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
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Role",
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
                keyValue: 7L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Shannon.Mohr88@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/546.jpg", "Shannon Mohr", "(823) 967-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Warren55@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/891.jpg", "Warren Donnelly", "736.762.82" });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Cheryl72@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1112.jpg", "Cheryl Towne", "991.929.66" });

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
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Wendy79@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/535.jpg", "Wendy Lindgren", "(698) 389-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Ian.Jones@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/729.jpg", "Ian Jones", "499-390-05", 0 });

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
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Inez.Collier@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/395.jpg", "Inez Collier", "463-684-90", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeZone",
                table: "Teams");

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 1, 19, 7, 2, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 2, 8, 2, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 4, 4, 5, 5, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 8, 22, 2, 3, 10 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 1, 8, 4, 8, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 4, 4, 4, 1, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings" },
                values: new object[] { 1, 6, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 5, 11, 6, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 5, 24, 3, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 8, 27, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 10, 6, 12, 25, 54, 447, DateTimeKind.Unspecified).AddTicks(6406), 16, "http://kameron.biz", 2L, "est", 31, 4L, 0, "Officia et eaque sit neque dolorem voluptatibus consequatur.\nSint animi incidunt.\nAut quo modi quia pariatur pariatur vel veniam sed excepturi.\nUnde ut nesciunt fugiat." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 6, 27, 4, 15, 26, 978, DateTimeKind.Unspecified).AddTicks(1410), 25, "https://kay.name", 2L, "voluptas", 22, 3L, "Necessitatibus iure fugiat fugit voluptatum in id." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 10, 22, 6, 18, 46, 880, DateTimeKind.Unspecified).AddTicks(5407), 29, "https://jacques.name", 5L, "blanditiis", 15, 2L, 1, "Omnis est mollitia similique est voluptatibus rerum iste enim. Quae est nemo excepturi architecto adipisci molestias id fugiat. Fugiat hic dolorem molestiae ea cumque eligendi omnis. Perferendis quibusdam unde ut quaerat laudantium. Molestiae non error ut iure. Cupiditate dignissimos ipsam quae repe" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2019, 10, 26, 18, 3, 41, 621, DateTimeKind.Unspecified).AddTicks(4814), 19, "https://fanny.name", 1L, "nisi", 19, 10L, 0, "Ullam consequatur maiores in et rerum.\nIpsum ab commodi eum excepturi enim repudiandae non.\nQui sunt et sit." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 3, 10, 12, 30, 52, 526, DateTimeKind.Unspecified).AddTicks(6565), 25, "http://vern.info", 3L, "et", 49, 10L, "Qui excepturi expedita porro. Facere ea ullam facilis sit quidem eaque quaerat. Doloribus placeat delectus est quis. Dolor nostrum et nostrum sequi consequatur ut sed. Vel deleniti officiis atque quia voluptatem dolorem voluptatem qui ut. Quia mollitia optio est modi eius quos." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 5, 20, 3, 31, 25, 801, DateTimeKind.Unspecified).AddTicks(2979), 26, "http://joshua.info", 3L, "fugit", 55, 2L, 0, "dolores" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 7, 29, 0, 41, 10, 985, DateTimeKind.Unspecified).AddTicks(8732), 29, "http://rupert.com", 4L, "sunt", 53, 6L, "Maiores provident quidem voluptatem quasi provident est mollitia." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 3, 27, 15, 57, 36, 40, DateTimeKind.Unspecified).AddTicks(5287), 26, "http://kevon.com", "consectetur", 40, 3L, 0, "Dolor sunt sunt." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 3, 28, 21, 9, 37, 143, DateTimeKind.Unspecified).AddTicks(3701), 24, "http://dasia.net", 2L, "quis", 40, 8L, "Aut est et eum voluptatem magni quis eum dolores." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 1, 27, 18, 46, 31, 749, DateTimeKind.Unspecified).AddTicks(2808), 30, "https://jules.name", 3L, "id", 15, 2L, 1, "consectetur" });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 10, 29, 11, 20, 29, 872, DateTimeKind.Unspecified).AddTicks(9664), 5L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2020, 9, 10, 17, 32, 34, 451, DateTimeKind.Unspecified).AddTicks(8791), 3L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 11, 23, 6, 46, 39, 105, DateTimeKind.Unspecified).AddTicks(4856), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 5L, new DateTime(2020, 7, 12, 21, 45, 14, 679, DateTimeKind.Unspecified).AddTicks(2766), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 1L, new DateTime(2021, 5, 13, 20, 11, 46, 736, DateTimeKind.Unspecified).AddTicks(8466), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 3L, new DateTime(2021, 2, 21, 16, 43, 23, 991, DateTimeKind.Unspecified).AddTicks(249), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2021, 1, 2, 4, 54, 11, 976, DateTimeKind.Unspecified).AddTicks(1081), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2019, 8, 27, 19, 16, 28, 758, DateTimeKind.Unspecified).AddTicks(581), 3L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 12, 31, 7, 41, 46, 921, DateTimeKind.Unspecified).AddTicks(9122), 9L, 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 12, 29, 19, 41, 10, 209, DateTimeKind.Unspecified).AddTicks(9086), 9L, 3L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(8626), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(8365), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(8853), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(8837), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(8885), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(8874), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(8925), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(8904), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(8954), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(8944), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(8981), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(8971), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(9007), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(8998), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(9034), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(9024), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(9060), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(9051), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(9087), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 18, 12, 5, 10, 120, DateTimeKind.Unspecified).AddTicks(9078), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Ed.Will@hotmail.com", new DateTimeOffset(new DateTime(2022, 11, 2, 22, 9, 10, 485, DateTimeKind.Unspecified).AddTicks(3909), new TimeSpan(0, 2, 0, 0, 0)), "Ed Will" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Derrick_Rippin@yahoo.com", new DateTimeOffset(new DateTime(2023, 2, 8, 21, 19, 41, 885, DateTimeKind.Unspecified).AddTicks(1648), new TimeSpan(0, 2, 0, 0, 0)), "Derrick Rippin" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Beulah.Hartmann42@hotmail.com", new DateTimeOffset(new DateTime(2022, 10, 3, 21, 6, 54, 740, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 3, 0, 0, 0)), "Beulah Hartmann" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Kyle71@hotmail.com", new DateTimeOffset(new DateTime(2023, 1, 28, 15, 57, 18, 168, DateTimeKind.Unspecified).AddTicks(3362), new TimeSpan(0, 2, 0, 0, 0)), "Kyle Parker" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Darrel_Stroman75@hotmail.com", new DateTimeOffset(new DateTime(2023, 7, 28, 13, 35, 38, 98, DateTimeKind.Unspecified).AddTicks(6255), new TimeSpan(0, 3, 0, 0, 0)), "Darrel Stroman" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Kellie_Doyle@gmail.com", new DateTimeOffset(new DateTime(2022, 9, 28, 9, 45, 30, 25, DateTimeKind.Unspecified).AddTicks(8812), new TimeSpan(0, 3, 0, 0, 0)), "Kellie Doyle" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Bridget_Barrows@hotmail.com", new DateTimeOffset(new DateTime(2023, 4, 26, 6, 45, 37, 221, DateTimeKind.Unspecified).AddTicks(466), new TimeSpan(0, 3, 0, 0, 0)), "Bridget Barrows" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Celia.Mosciski30@gmail.com", new DateTimeOffset(new DateTime(2022, 10, 3, 16, 2, 47, 554, DateTimeKind.Unspecified).AddTicks(7480), new TimeSpan(0, 3, 0, 0, 0)), "Celia Mosciski" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Sandra_Weber1@hotmail.com", new DateTimeOffset(new DateTime(2023, 5, 1, 0, 14, 9, 560, DateTimeKind.Unspecified).AddTicks(980), new TimeSpan(0, 3, 0, 0, 0)), "Sandra Weber" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Dominic46@hotmail.com", new DateTimeOffset(new DateTime(2023, 3, 6, 0, 19, 48, 55, DateTimeKind.Unspecified).AddTicks(3090), new TimeSpan(0, 2, 0, 0, 0)), "Dominic Sauer" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 24, 3, 28, 13, 966, DateTimeKind.Unspecified).AddTicks(3116), 5L, "repudiandae", 19, 1L, "reiciendis", new DateTimeOffset(new DateTime(2022, 8, 21, 23, 12, 43, 163, DateTimeKind.Unspecified).AddTicks(4062), new TimeSpan(0, 3, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 15, 2, 44, 53, 758, DateTimeKind.Unspecified).AddTicks(7065), 5L, "Aperiam voluptatem veniam maxime non est vel odio.", 45, 1L, "quia", new DateTimeOffset(new DateTime(2023, 4, 5, 7, 14, 4, 280, DateTimeKind.Unspecified).AddTicks(8694), new TimeSpan(0, 3, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 10, 17, 19, 49, 11, 610, DateTimeKind.Unspecified).AddTicks(9435), 10L, "Officiis quia ut dolorem minus exercitationem repe", 15, 2L, "minus", new DateTimeOffset(new DateTime(2023, 6, 25, 15, 1, 58, 378, DateTimeKind.Unspecified).AddTicks(5139), new TimeSpan(0, 3, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 5, 25, 5, 24, 47, 150, DateTimeKind.Unspecified).AddTicks(2474), 5L, "Ipsa doloribus perferendis est fugit error ipsa op", 27, "dolorum", new DateTimeOffset(new DateTime(2022, 9, 5, 19, 31, 15, 351, DateTimeKind.Unspecified).AddTicks(1386), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 24, 3, 17, 20, 596, DateTimeKind.Unspecified).AddTicks(4955), 7L, "Voluptate in sunt magnam repellendus aliquid dolor", 57, "illum", new DateTimeOffset(new DateTime(2023, 2, 10, 22, 31, 18, 984, DateTimeKind.Unspecified).AddTicks(3598), new TimeSpan(0, 2, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 9, 26, 12, 17, 59, 595, DateTimeKind.Unspecified).AddTicks(6886), 3L, "Qui autem optio consequatur quo.", 14, 1L, "deserunt", new DateTimeOffset(new DateTime(2023, 3, 6, 16, 10, 22, 822, DateTimeKind.Unspecified).AddTicks(6764), new TimeSpan(0, 2, 0, 0, 0)), 7L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 9, 1, 8, 15, 54, 647, DateTimeKind.Unspecified).AddTicks(6300), 4L, "Fugiat adipisci quo quos.\nQuia beatae et.\nPorro oc", 35, 3L, "nostrum", new DateTimeOffset(new DateTime(2022, 10, 10, 12, 34, 6, 767, DateTimeKind.Unspecified).AddTicks(7789), new TimeSpan(0, 3, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 11, 16, 23, 33, 29, 385, DateTimeKind.Unspecified).AddTicks(4292), 5L, "rem", 11, 1L, "qui", new DateTimeOffset(new DateTime(2023, 3, 28, 17, 8, 39, 886, DateTimeKind.Unspecified).AddTicks(9184), new TimeSpan(0, 3, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 8, 9, 15, 34, 17, 742, DateTimeKind.Unspecified).AddTicks(9828), 5L, "Et non quisquam et est provident in ut. Est repudi", 58, 3L, "assumenda", new DateTimeOffset(new DateTime(2023, 2, 28, 17, 5, 25, 293, DateTimeKind.Unspecified).AddTicks(7471), new TimeSpan(0, 2, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 11, 26, 6, 9, 24, 18, DateTimeKind.Unspecified).AddTicks(6485), 4L, "Non nulla expedita consequuntur dolores id ipsam i", 15, 5L, "esse", new DateTimeOffset(new DateTime(2023, 4, 16, 17, 53, 11, 190, DateTimeKind.Unspecified).AddTicks(4624), new TimeSpan(0, 3, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Odio ut animi nam nihil laborum.AAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Magnam odit iusto vel.\nId fuga sint.\nEt voluptatem officia aliquam ea omnis debitis voluptatem sit aperiam.\nQui dolore sit eum ut quia." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "sequiAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "quamAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "velAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "eosAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Text",
                value: "Velit amet veritatis voluptatem non incidunt rerum adipisci illum aut.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "fugaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Sed explicabo delectus et deleniti et. Deserunt doloremque exercitationem et ut. Voluptatem ut praesentium id praesentium dolorem aliquid. Quia odio aut qui maxime sequi consequuntur molestiae maiores veritatis. Cupiditate blanditiis atque corrupti non neque repellendus libero et. Perspiciatis aut e" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Ut aperiam quia suscipit a. Ratione maiores est vel ut facilis. Quia ut ratione fugit voluptatem ab quibusdam aut explicabo quia. Quae non quod adipisci." });

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
                value: 4);

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
                value: 8);

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
                value: 3);

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
                value: 9);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Priority",
                value: 8);

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
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Role",
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
                keyValue: 7L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Molestias consequatur veritatis laudantium impedit enim ut illum doloremque.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/259.jpg", "Upton and Sons", "https://chad.net" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "nobis", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/605.jpg", "Corwin - Kunze", "http://cynthia.net" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Rerum ex repellat.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1205.jpg", "Ebert - Bartoletti", "http://sally.name" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "in", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/328.jpg", "Murazik, Bogan and Bartell", "http://viola.name" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Et sint molestiae quas rerum ea.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1236.jpg", "Upton - Renner", "http://zechariah.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Occaecati officia enim velit odit et eveniet est pariatur.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/655.jpg", "Conroy Group", "http://hudson.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Numquam quos itaque earum omnis aut.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/247.jpg", "Rolfson - Botsford", "https://carolyne.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "doloremque", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/202.jpg", "Dach and Sons", "http://eulah.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Sint odio enim tempora dolor nulla rerum at aliquid.\nMolestiae reiciendis eum perspiciatis asperiores repudiandae.\nSoluta sequi quam ut.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/374.jpg", "Sipes - Schuster", "https://catharine.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink" },
                values: new object[] { "Odio quasi voluptatibus qui veniam ratione.", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/517.jpg", "Hamill Group", "https://rashad.biz" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Tommy_Lynch@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/229.jpg", "Tommy Lynch", "(757) 893-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Ella_Sauer49@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/853.jpg", "Ella Sauer", "(381) 599-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Pam_Klein@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/872.jpg", "Pam Klein", "(291) 923-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Beatrice_Grant@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/448.jpg", "Beatrice Grant", "1-619-719-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Kristie_Walker43@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/572.jpg", "Kristie Walker", "1-234-812-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Lori.Bernhard26@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/995.jpg", "Lori Bernhard", "(973) 772-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Jeanette48@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/951.jpg", "Jeanette Kuvalis", "760-682-21" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Andrea_Botsford51@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1193.jpg", "Andrea Botsford", "554.657.42", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Archie.Bednar82@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/506.jpg", "Archie Bednar", "(400) 210-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Billie_Blanda52@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/338.jpg", "Billie Blanda", "721-329-62", 0 });
        }
    }
}
