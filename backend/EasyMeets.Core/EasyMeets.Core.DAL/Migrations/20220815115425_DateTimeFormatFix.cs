using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class DateTimeFormatFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 8, 21, 7, 1, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Days", "MinBookingMeetingDifference" },
                values: new object[] { 10, 5 });

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
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 6, 8, 3, 2, 6 });

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
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 4, 30, 3, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 1, 27, 4, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 6, 30, 4, 4, 1 });

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
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 5, 5, 19, 3, 31, 65, DateTimeKind.Unspecified).AddTicks(2180), 24, "https://mckenna.net", 2L, "commodi", 53, 4L, 1, "tenetur" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 10, 13, 14, 32, 14, 370, DateTimeKind.Unspecified).AddTicks(2793), 20, "https://katrine.name", 3L, "facilis", 38, 3L, 0, "Dolorum rerum tenetur quia.\nAut tempore tempora odio natus laudantium nobis at qui.\nTempore aut aut.\nVoluptas vitae deleniti est qui." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 1, 31, 17, 41, 39, 893, DateTimeKind.Unspecified).AddTicks(7252), 18, "https://betsy.info", 2L, "qui", 53, 2L, 0, "Illum fugiat debitis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 12, 17, 0, 22, 28, 823, DateTimeKind.Unspecified).AddTicks(5306), 16, "http://judson.com", 3L, "et", 23, 1, "Sed rerum alias voluptatem quia facere facere praesentium." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2019, 12, 22, 17, 28, 3, 995, DateTimeKind.Unspecified).AddTicks(5777), 24, "https://quinten.net", 4L, "modi", 36, 10L, 0, "et" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 9, 13, 10, 48, 43, 65, DateTimeKind.Unspecified).AddTicks(641), 19, "https://bridgette.info", 1L, "atque", 52, 5L, "Quos fugiat hic consequatur ratione voluptatum sed. Commodi porro ipsum eaque voluptatem eaque in. Voluptate aliquam recusandae. Dolores omnis saepe aliquam et iusto maxime asperiores a. Aut eveniet distinctio." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2019, 7, 25, 21, 36, 39, 608, DateTimeKind.Unspecified).AddTicks(7362), 25, "https://hubert.net", 3L, "rerum", 19, 10L, 0, "Sit saepe ut voluptatibus natus facere aut voluptas ad.\nInventore reiciendis molestias.\nArchitecto totam qui ut.\nRem non consequuntur excepturi cumque eveniet cumque omnis omnis consequatur.\nAdipisci repellat similique voluptatem eos laudantium doloremque magni." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2019, 12, 9, 5, 12, 42, 385, DateTimeKind.Unspecified).AddTicks(6336), "http://catharine.name", 1L, "et", 24, 2L, 1, "Temporibus qui ut placeat. Maiores quo omnis quos similique labore qui velit. Dolores corporis qui omnis dolores voluptatem natus assumenda voluptas. Et distinctio velit et optio omnis iure vel quia. Asperiores esse similique eligendi exercitationem vel vel voluptas est repudiandae." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 11, 8, 9, 18, 33, 851, DateTimeKind.Unspecified).AddTicks(727), 22, "http://wilma.info", "eligendi", 60, 6L, 0, "Qui dolor repellendus omnis vitae. Ut distinctio corporis aut. Quaerat autem eos. Non assumenda enim nihil dignissimos facilis quos. Et nihil minus quae autem perspiciatis consectetur." });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2019, 12, 3, 20, 45, 34, 822, DateTimeKind.Unspecified).AddTicks(8008), 3L, 9L });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 5L, new DateTime(2021, 1, 18, 16, 59, 30, 447, DateTimeKind.Unspecified).AddTicks(6239), 9L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2021, 5, 28, 15, 16, 50, 163, DateTimeKind.Unspecified).AddTicks(4559), 3L, "culpa", 50, 3L, "dicta", new DateTimeOffset(new DateTime(2023, 2, 4, 19, 50, 23, 705, DateTimeKind.Unspecified).AddTicks(3759), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 27, 0, 30, 43, 297, DateTimeKind.Unspecified).AddTicks(9952), 6L, "Minus tempore et aut sint ducimus inventore.\nUt id", 50, 2L, "molestiae", new DateTimeOffset(new DateTime(2023, 1, 19, 6, 49, 17, 750, DateTimeKind.Unspecified).AddTicks(8110), new TimeSpan(0, 2, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 16, 10, 47, 58, 433, DateTimeKind.Unspecified).AddTicks(4043), "dolores", 41, 2L, "dicta", new DateTimeOffset(new DateTime(2023, 5, 21, 14, 22, 14, 257, DateTimeKind.Unspecified).AddTicks(5347), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 36, 6, 350, DateTimeKind.Unspecified).AddTicks(9519), 8L, "Qui consequatur ut sit corporis accusantium volupt", 38, "rerum", new DateTimeOffset(new DateTime(2022, 12, 13, 3, 8, 32, 437, DateTimeKind.Unspecified).AddTicks(7577), new TimeSpan(0, 2, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime" },
                values: new object[] { new DateTime(2020, 7, 24, 16, 16, 24, 583, DateTimeKind.Unspecified).AddTicks(8879), 6L, "Voluptas quia non nulla aspernatur eum.", 57, "dignissimos", new DateTimeOffset(new DateTime(2022, 10, 21, 7, 26, 1, 663, DateTimeKind.Unspecified).AddTicks(3177), new TimeSpan(0, 3, 0, 0, 0)) });

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
                column: "Text",
                value: "Quae sunt velit tenetur molestiae.\nNecessitatibus aliquam itaque velit ea porro sed accusamus neque.\nAccusantium quia voluptatem vitae accusamus qui et necessitatibus in.\nIn sit id.\nQuis iste suscipit itaque omnis sed nostrum delectus omnis dolor.");

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4L,
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
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Status",
                value: 2);

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Sam32@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/710.jpg", "Sam Kemmer", "813.666.32", 0 });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Fred.Paucek35@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/521.jpg", "Fred Paucek", "1-640-543-", 0 });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Bobby.Hyatt24@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/533.jpg", "Bobby Hyatt", "(420) 617-", 1 });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Lucille17@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1179.jpg", "Lucille Hegmann", "959.651.14", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Kristine.Keeling@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/458.jpg", "Kristine Keeling", "(883) 647-", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 3, 21, 10, 1, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 2, 5, 19, 3, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 5, 6, 9, 2, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Days", "MinBookingMeetingDifference" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 7, 10, 4, 2, 10 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 2, 29, 2, 1, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 5, 25, 1, 1, 14 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 8, 18, 5, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 4, 30, 7, 5 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 5, 4, 10, 1, 9 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 8, 21, 0, 32, 4, 504, DateTimeKind.Unspecified).AddTicks(1503), 26, "http://bertha.info", 1L, "consequatur", 39, 6L, "Velit saepe officiis tenetur nisi quia at earum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 5, 1, 6, 25, 7, 495, DateTimeKind.Unspecified).AddTicks(9112), 28, "https://drew.com", 3L, "nisi", 37, 10L, 0, "A quae rerum officiis aut minima vitae nihil et.\nQuis dolorem ut aut officia et consequuntur id." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 2, 5, 7, 45, 21, 719, DateTimeKind.Unspecified).AddTicks(327), 16, "http://athena.net", 4L, "ut", 52, 9L, 1, "Consequatur sunt modi quis eveniet sunt rerum voluptatem a quod. Corrupti enim ad voluptatum dolores aliquam quia quam occaecati. Quam placeat consectetur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 10, 4, 11, 2, 55, 647, DateTimeKind.Unspecified).AddTicks(5182), 29, "http://marianna.biz", 5L, "et", 20, 9L, 1, "voluptates" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 7, 10, 10, 45, 47, 535, DateTimeKind.Unspecified).AddTicks(4969), 19, "http://frank.com", 4L, "molestias", 32, 0, "aut" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 7, 6, 11, 46, 55, 522, DateTimeKind.Unspecified).AddTicks(3684), 21, "https://jaquan.biz", 3L, "itaque", 48, 9L, 1, "Sunt consectetur qui accusamus numquam.\nVoluptas sit ratione laboriosam nemo temporibus excepturi et eius.\nIste aliquam culpa dolores vel dignissimos sunt.\nEt esse labore." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2019, 8, 3, 1, 7, 43, 968, DateTimeKind.Unspecified).AddTicks(6157), 22, "http://garland.net", 5L, "rerum", 55, 9L, "Excepturi soluta autem.\nSed rerum voluptatem." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 1, 18, 7, 48, 44, 739, DateTimeKind.Unspecified).AddTicks(738), 20, "https://alden.info", 5L, "mollitia", 36, 4L, 1, "Expedita laudantium quia minus autem a qui commodi vitae." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 11, 28, 20, 42, 22, 639, DateTimeKind.Unspecified).AddTicks(7216), "http://corene.org", 3L, "illo", 39, 5L, 0, "Possimus culpa aperiam ut magnam quo aliquam quisquam officiis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 8, 11, 9, 24, 56, 313, DateTimeKind.Unspecified).AddTicks(3053), 16, "http://eryn.info", "molestiae", 58, 7L, 1, "Inventore veniam ut molestiae laborum possimus amet et culpa quae.\nDolorem perferendis est voluptatem et doloribus.\nIusto possimus quidem dicta at." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 11, 8, 12, 49, 46, 697, DateTimeKind.Unspecified).AddTicks(4393), 6L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 1, 28, 1, 42, 13, 233, DateTimeKind.Unspecified).AddTicks(2975), 1L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2019, 12, 9, 12, 8, 2, 60, DateTimeKind.Unspecified).AddTicks(5001), 7L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 6L, new DateTime(2020, 7, 19, 1, 17, 2, 99, DateTimeKind.Unspecified).AddTicks(1048), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 9L, new DateTime(2019, 10, 15, 1, 9, 57, 208, DateTimeKind.Unspecified).AddTicks(5372), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2019, 9, 8, 11, 19, 31, 33, DateTimeKind.Unspecified).AddTicks(4977), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 1, 8, 11, 54, 56, 479, DateTimeKind.Unspecified).AddTicks(8932), 5L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2020, 5, 16, 0, 12, 21, 966, DateTimeKind.Unspecified).AddTicks(6186), 8L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 10, 22, 9, 42, 37, 430, DateTimeKind.Unspecified).AddTicks(8721), 2L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 5, 18, 16, 55, 56, 763, DateTimeKind.Unspecified).AddTicks(8794), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7113), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 16, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7067), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7198), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 16, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7209), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 16, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7207), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 16, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7214), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7269), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 16, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7266), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7278), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 16, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7276), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7285), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 16, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7283), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7292), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 16, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7299), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 16, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7297), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7305), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 16, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7304), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Don.Hayes@yahoo.comAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 5, 7, 21, 39, 58, 681, DateTimeKind.Unspecified).AddTicks(2517), new TimeSpan(0, 3, 0, 0, 0)), "Don Hayes" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Chad_Botsford0@yahoo.comAAAAAA", new DateTimeOffset(new DateTime(2023, 5, 23, 1, 42, 14, 790, DateTimeKind.Unspecified).AddTicks(3353), new TimeSpan(0, 3, 0, 0, 0)), "Chad Botsford" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Tabitha.Miller@gmail.comAAAAAA", new DateTimeOffset(new DateTime(2023, 2, 4, 2, 44, 22, 693, DateTimeKind.Unspecified).AddTicks(2042), new TimeSpan(0, 3, 0, 0, 0)), "Tabitha Miller" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "John.Grady@hotmail.comAAAAAAAA", new DateTimeOffset(new DateTime(2023, 8, 7, 21, 30, 42, 253, DateTimeKind.Unspecified).AddTicks(7518), new TimeSpan(0, 3, 0, 0, 0)), "John Grady" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Alfred.Runolfsdottir@yahoo.com", new DateTimeOffset(new DateTime(2022, 9, 1, 1, 13, 14, 216, DateTimeKind.Unspecified).AddTicks(8202), new TimeSpan(0, 3, 0, 0, 0)), "Alfred Runolfsdottir" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Sophia.Macejkovic69@gmail.comA", new DateTimeOffset(new DateTime(2023, 1, 13, 6, 27, 12, 104, DateTimeKind.Unspecified).AddTicks(9572), new TimeSpan(0, 3, 0, 0, 0)), "Sophia Macejkovic" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Allison_Conroy63@yahoo.comAAAA", new DateTimeOffset(new DateTime(2022, 10, 14, 15, 9, 20, 451, DateTimeKind.Unspecified).AddTicks(7772), new TimeSpan(0, 3, 0, 0, 0)), "Allison Conroy" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Jeannette_Mueller@gmail.comAAA", new DateTimeOffset(new DateTime(2023, 4, 4, 15, 44, 27, 737, DateTimeKind.Unspecified).AddTicks(5685), new TimeSpan(0, 3, 0, 0, 0)), "Jeannette Mueller" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Manuel.Beatty@hotmail.comAAAAA", new DateTimeOffset(new DateTime(2023, 5, 31, 4, 23, 17, 559, DateTimeKind.Unspecified).AddTicks(6278), new TimeSpan(0, 3, 0, 0, 0)), "Manuel Beatty" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Michele_Kutch20@yahoo.comAAAAA", new DateTimeOffset(new DateTime(2022, 11, 24, 7, 56, 39, 716, DateTimeKind.Unspecified).AddTicks(3032), new TimeSpan(0, 3, 0, 0, 0)), "Michele Kutch" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 2, 2, 3, 10, 5, 659, DateTimeKind.Unspecified).AddTicks(9171), 7L, "Expedita velit cupiditate quo blanditiis eius id e", 26, 5L, "vel", new DateTimeOffset(new DateTime(2022, 11, 9, 10, 55, 5, 624, DateTimeKind.Unspecified).AddTicks(4952), new TimeSpan(0, 3, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 25, 17, 28, 23, 142, DateTimeKind.Unspecified).AddTicks(8372), 2L, "Culpa alias et reiciendis.\nImpedit et minima occae", 56, 1L, "at", new DateTimeOffset(new DateTime(2022, 11, 4, 9, 18, 36, 658, DateTimeKind.Unspecified).AddTicks(7674), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 11, 25, 15, 24, 35, 829, DateTimeKind.Unspecified).AddTicks(7543), 4L, "corrupti", 21, 5L, "et", new DateTimeOffset(new DateTime(2023, 3, 3, 17, 58, 19, 210, DateTimeKind.Unspecified).AddTicks(745), new TimeSpan(0, 3, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2020, 2, 2, 11, 33, 21, 675, DateTimeKind.Unspecified).AddTicks(8342), 6L, "distinctio", 57, 5L, "nulla", new DateTimeOffset(new DateTime(2023, 4, 21, 21, 21, 48, 392, DateTimeKind.Unspecified).AddTicks(4270), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 11, 17, 2, 16, 44, 607, DateTimeKind.Unspecified).AddTicks(7869), 5L, "quis", 59, 4L, "et", new DateTimeOffset(new DateTime(2022, 10, 6, 3, 37, 58, 836, DateTimeKind.Unspecified).AddTicks(7790), new TimeSpan(0, 3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 3, 12, 18, 11, 49, 581, DateTimeKind.Unspecified).AddTicks(5853), "Ut amet dolore facere et qui dolorem.\nSunt volupta", 12, 4L, "sit", new DateTimeOffset(new DateTime(2022, 10, 20, 10, 11, 53, 891, DateTimeKind.Unspecified).AddTicks(9247), new TimeSpan(0, 3, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 18, 1, 20, 33, 281, DateTimeKind.Unspecified).AddTicks(9777), 10L, "Voluptas dolorem sint.", 43, "ducimus", new DateTimeOffset(new DateTime(2022, 11, 23, 2, 35, 9, 235, DateTimeKind.Unspecified).AddTicks(9436), new TimeSpan(0, 3, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime" },
                values: new object[] { new DateTime(2021, 1, 30, 23, 22, 56, 562, DateTimeKind.Unspecified).AddTicks(4167), 3L, "velit", 49, "autem", new DateTimeOffset(new DateTime(2023, 6, 27, 5, 39, 41, 585, DateTimeKind.Unspecified).AddTicks(9454), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 11, 5, 2, 14, 730, DateTimeKind.Unspecified).AddTicks(7018), 7L, "Perferendis error nemo tempore perspiciatis.\nEnim", 28, 1L, "temporibus", new DateTimeOffset(new DateTime(2023, 1, 16, 8, 18, 6, 115, DateTimeKind.Unspecified).AddTicks(7169), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 10, 22, 11, 8, 49, 534, DateTimeKind.Unspecified).AddTicks(9945), 4L, "Quaerat et aut. Iure et tempore dolor sed libero e", 46, 5L, "maiores", new DateTimeOffset(new DateTime(2022, 11, 11, 9, 10, 55, 163, DateTimeKind.Unspecified).AddTicks(5964), new TimeSpan(0, 3, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Sint itaque ducimus.\nEt velit voluptatem qui magnam mollitia.\nEst error deleniti." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Consequatur corrupti laudantium repudiandae quo mollitia." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "iustoAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Text",
                value: "Aliquam quia et corporis ullam voluptas molestiae.\nEst iure est.\nOfficiis fugiat quos iste ut voluptas necessitatibus sunt quia.\nEst sint recusandae laboriosam in non autem.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Accusamus unde dolor neque. Eveniet aut tenetur nihil vero. Ea dignissimos aliquam voluptatem alias sunt assumenda cum molestiae corrupti. Quibusdam expedita et tenetur quisquam voluptas dolore similique veritatis impedit." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Esse reiciendis labore aut consequatur consequatur eum ut quis id.\nSit recusandae voluptatem mollitia quod provident.\nUt odio eius officia est in cum perferendis qui modi.\nAdipisci qui a tempora." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "A sed omnis in sed vel. A rem quidem reiciendis quia et at recusandae. Recusandae magnam voluptates blanditiis aut sint porro fugiat est. Voluptates mollitia necessitatibus sit libero consequatur laboriosam ipsa. Eius in ut nostrum pariatur dicta labore ut. Consectetur voluptas qui sed ut ea molliti" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Voluptas ad vel sunt qui vel eum rem sed tenetur. Quo labore deleniti doloribus sunt neque. Deleniti consequatur omnis. Reprehenderit corporis recusandae explicabo." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Alias vitae minus modi commodi sit ullam.\nNumquam et iure rerum ipsum.\nNon qui ipsam deleniti sed.\nQuia ut similique necessitatibus sint quia pariatur deleniti.\nOmnis iusto pariatur vero." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Nostrum dolore adipisci sed ex eos deserunt dolorem iure." });

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Priority",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 4L,
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
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Priority",
                value: 4);

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4L,
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
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Reiciendis debitis molestias est rem illum sit impedit. Vitae velit non reprehenderit perspiciatis nobis facere quia consequuntur. Sint vel quis architecto exercitationem repudiandae ipsam.", "Klein Inc", "https://sherman.net", "Pacific/A" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "enim", "Langosh, Graham and Thiel", "http://green.biz", "America/L" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Voluptate rerum deleniti exercitationem placeat voluptatum possimus est facilis autem. Vitae eum officia consequatur sed quo esse laborum perspiciatis ut. Blanditiis ut ad quae hic cupiditate voluptatem.", "Bergnaum and Sons", "https://holly.info", "America/D" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Ullam natus ut et ipsam voluptas harum et.", "Adams, Lueilwitz and Hauck", "https://hettie.net", "Europe/Li" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Vel magnam veritatis sit non. Dolor non quis corrupti eum ipsa rerum quam sunt esse. Animi harum modi reiciendis tenetur est. Dolore aliquam totam eligendi recusandae occaecati deleniti sint.", "Kshlerin - Padberg", "https://destany.name", "Etc/UTC" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quia recusandae qui sit non dolorem.", "Barton, Pfannerstill and Shields", "https://evan.biz", "Asia/Bang" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Molestiae sed vel aspernatur sunt qui.\nUt dolorum consequatur aperiam.\nConsequatur nihil molestiae.", "Jones - Windler", "https://chadd.net", "Europe/Mo" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Aspernatur sunt neque.\nEst minima magnam rerum similique deserunt minima.\nNihil officiis alias adipisci commodi voluptates.", "Hand, Mohr and Walsh", "http://bo.biz", "America/G" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "eligendi", "Purdy - White", "https://khalid.name", "Europe/Br" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "esse", "Weimann - Shields", "http://colin.net", "Pacific/M" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 2, "Dewey.Thiel@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1229.jpg", "Dewey Thiel", "422.765.91", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 2, "Lyle55@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/201.jpg", "Lyle Parisian", "(736) 994-", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 2, "Max52@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1179.jpg", "Max Thompson", "1-876-525-", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 2, "Tracy_Ziemann37@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/894.jpg", "Tracy Ziemann", "240.233.83", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 2, "Lowell_Bashirian@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/510.jpg", "Lowell Bashirian", "498.777.22", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 2, "Patty.Emard33@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/311.jpg", "Patty Emard", "565-753-66", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 2, "Shannon.Rogahn91@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/204.jpg", "Shannon Rogahn", "809-678-54", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 2, "Wilfred.Streich@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/684.jpg", "Wilfred Streich", "1-996-452-", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 2, "Randall_Ankunding@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/441.jpg", "Randall Ankunding", "211-206-32", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 2, "Joyce.Douglas@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/185.jpg", "Joyce Douglas", "293-220-34", 2 });
        }
    }
}
