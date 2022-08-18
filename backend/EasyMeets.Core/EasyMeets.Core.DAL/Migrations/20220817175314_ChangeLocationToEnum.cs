using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class ChangeLocationToEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailabilitySlots_Locations_LocationId",
                table: "AvailabilitySlots");

            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Locations_LocationId",
                table: "Meetings");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_LocationId",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_AvailabilitySlots_LocationId",
                table: "AvailabilitySlots");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "AvailabilitySlots");

            migrationBuilder.AddColumn<int>(
                name: "LocationType",
                table: "Meetings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocationType",
                table: "AvailabilitySlots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 2, 17, 8, 15 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 2, 23, 4, 1, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 2, 2, 10, 8, 14 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 13, 7, 2, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 5, 19, 4, 1, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 4, 30, 2, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 8, 1, 4, 13 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 6, 17, 5, 5, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "PaddingMeeting" },
                values: new object[] { 1, 6, 8, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 1, 2, 7, 6, 8 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 10, 33, 37, 632, DateTimeKind.Unspecified).AddTicks(3181), 19, "http://lesly.name", 1, "ut", 22, 1, "Enim aliquid cumque ea officia quod earum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 7, 15, 22, 9, 34, 135, DateTimeKind.Unspecified).AddTicks(7262), 28, "http://reese.com", 2, 28, 1L, "Officiis omnis autem illum repellat iusto.\nUnde totam reiciendis in et.\nTemporibus vel ut numquam sit consequuntur molestiae." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 11, 30, 1, 16, 44, 428, DateTimeKind.Unspecified).AddTicks(7930), 29, "https://kamron.name", 1, "tempore", 44, 10L, 1, "Magnam et voluptates perspiciatis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 11, 11, 12, 15, 5, 822, DateTimeKind.Unspecified).AddTicks(4565), 19, "http://kaleigh.info", "cumque", 50, 2L, "Reprehenderit voluptatibus sequi id cupiditate. Est aut consequatur voluptates omnis sed itaque. Et qui sapiente consequuntur provident recusandae iste sint dolor non." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 3, 27, 21, 20, 54, 618, DateTimeKind.Unspecified).AddTicks(8806), 18, "https://charley.info", 1, "ut", 40, 6L, "In animi et ipsum alias dolorem quisquam placeat esse." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 1, 21, 1, 2, 45, 618, DateTimeKind.Unspecified).AddTicks(1869), 28, "https://jalon.name", "error", 31, 5L, 0, "Et dolores qui rem consequatur est sapiente. Cupiditate porro eligendi perferendis consequatur. Aut commodi eligendi omnis repellat molestiae non." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 11, 18, 18, 32, 16, 33, DateTimeKind.Unspecified).AddTicks(4539), 16, "https://maiya.biz", "consequatur", 21, 5L, "Et adipisci esse eos perspiciatis et minus voluptatem eveniet eaque. Id consequuntur sit beatae. Aperiam tenetur asperiores et in qui quis nisi voluptatum. In eveniet sed adipisci corporis dolores tempora laboriosam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 7, 18, 16, 49, 47, 788, DateTimeKind.Unspecified).AddTicks(4069), 16, "https://cristal.com", 1, "vel", 54, 5L, "Voluptatibus vero minus amet.\nEsse amet qui fugiat numquam.\nNemo atque deleniti.\nPlaceat voluptas eveniet." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2019, 11, 21, 17, 44, 39, 392, DateTimeKind.Unspecified).AddTicks(8171), 25, "https://vicente.info", "dolorem", 53, 4L, 0, "id" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 12, 3, 7, 5, 8, 608, DateTimeKind.Unspecified).AddTicks(5589), 28, "https://andrew.name", "nihil", 22, "Odit ut porro corrupti optio est." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2019, 10, 14, 1, 52, 41, 862, DateTimeKind.Unspecified).AddTicks(5318), 2L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 4L, new DateTime(2020, 11, 2, 11, 47, 7, 524, DateTimeKind.Unspecified).AddTicks(895), 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 7L, new DateTime(2019, 8, 5, 22, 15, 39, 940, DateTimeKind.Unspecified).AddTicks(7274), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 2, 24, 14, 13, 53, 567, DateTimeKind.Unspecified).AddTicks(9834), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 1, 17, 10, 14, 29, 620, DateTimeKind.Unspecified).AddTicks(1650), 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 5, 17, 8, 9, 46, 481, DateTimeKind.Unspecified).AddTicks(8859), 1L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 4, 8, 1, 58, 19, 233, DateTimeKind.Unspecified).AddTicks(6606), 2L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2021, 6, 29, 17, 34, 22, 312, DateTimeKind.Unspecified).AddTicks(2276), 8L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 6, 8, 3, 47, 14, 272, DateTimeKind.Unspecified).AddTicks(2834), 7L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 7, 10, 3, 20, 53, 662, DateTimeKind.Unspecified).AddTicks(8549), 6L, 1L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1269), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1152), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1407), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1400), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1423), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1418), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1438), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1433), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1453), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1448), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1468), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1463), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1482), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1477), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1497), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1492), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1512), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1507), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1527), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1522), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Thomas.Mayert@gmail.com", new DateTimeOffset(new DateTime(2022, 10, 2, 21, 41, 48, 730, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, 3, 0, 0, 0)), "Thomas Mayert" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Julia2@hotmail.com", new DateTimeOffset(new DateTime(2022, 9, 12, 19, 51, 32, 571, DateTimeKind.Unspecified).AddTicks(4496), new TimeSpan(0, 3, 0, 0, 0)), "Julia Schowalter" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Susan.DAmore@yahoo.com", new DateTimeOffset(new DateTime(2023, 1, 6, 5, 31, 4, 157, DateTimeKind.Unspecified).AddTicks(2529), new TimeSpan(0, 2, 0, 0, 0)), "Susan D'Amore" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Carolyn76@gmail.com", new DateTimeOffset(new DateTime(2023, 5, 3, 2, 17, 59, 777, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 3, 0, 0, 0)), "Carolyn Konopelski" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Loretta34@hotmail.com", new DateTimeOffset(new DateTime(2022, 11, 22, 18, 15, 48, 698, DateTimeKind.Unspecified).AddTicks(6090), new TimeSpan(0, 2, 0, 0, 0)), "Loretta Konopelski" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Misty67@gmail.com", new DateTimeOffset(new DateTime(2023, 2, 15, 3, 45, 44, 453, DateTimeKind.Unspecified).AddTicks(5544), new TimeSpan(0, 2, 0, 0, 0)), "Misty Lesch" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "George60@yahoo.com", new DateTimeOffset(new DateTime(2022, 10, 26, 0, 46, 34, 844, DateTimeKind.Unspecified).AddTicks(5371), new TimeSpan(0, 3, 0, 0, 0)), "George Bergstrom" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Alexander_Kassulke64@gmail.co", new DateTimeOffset(new DateTime(2023, 4, 15, 18, 31, 48, 191, DateTimeKind.Unspecified).AddTicks(2196), new TimeSpan(0, 3, 0, 0, 0)), "Alexander Kassulke" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Milton.Schuppe19@hotmail.com", new DateTimeOffset(new DateTime(2022, 11, 18, 13, 43, 10, 281, DateTimeKind.Unspecified).AddTicks(7839), new TimeSpan(0, 2, 0, 0, 0)), "Milton Schuppe" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Joanne29@hotmail.com", new DateTimeOffset(new DateTime(2022, 11, 4, 13, 35, 14, 761, DateTimeKind.Unspecified).AddTicks(6999), new TimeSpan(0, 2, 0, 0, 0)), "Joanne Walter" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 7, 19, 52, 54, 651, DateTimeKind.Unspecified).AddTicks(9375), 3L, "Quod temporibus odio autem beatae voluptatem quisq", 40, 1, "ab", new DateTimeOffset(new DateTime(2022, 12, 27, 0, 50, 27, 181, DateTimeKind.Unspecified).AddTicks(6641), new TimeSpan(0, 2, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 8, 29, 12, 2, 11, 435, DateTimeKind.Unspecified).AddTicks(927), 9L, "eveniet", 60, 2, "placeat", new DateTimeOffset(new DateTime(2023, 7, 28, 16, 30, 44, 331, DateTimeKind.Unspecified).AddTicks(4276), new TimeSpan(0, 3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 6, 3, 3, 41, 25, 723, DateTimeKind.Unspecified).AddTicks(2516), 7L, "corporis", 23, 1, "rerum", new DateTimeOffset(new DateTime(2023, 7, 29, 22, 37, 4, 220, DateTimeKind.Unspecified).AddTicks(178), new TimeSpan(0, 3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 3, 9, 16, 40, 40, 146, DateTimeKind.Unspecified).AddTicks(445), 9L, "Atque reiciendis et voluptates expedita eaque illu", 42, 2, "et", new DateTimeOffset(new DateTime(2023, 6, 22, 0, 54, 48, 429, DateTimeKind.Unspecified).AddTicks(3094), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 9, 7, 8, 10, 894, DateTimeKind.Unspecified).AddTicks(5926), 1L, "Expedita nihil culpa officia in similique ipsam at", 12, "dolore", new DateTimeOffset(new DateTime(2022, 10, 9, 3, 39, 27, 215, DateTimeKind.Unspecified).AddTicks(9007), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 4, 2, 17, 37, 637, DateTimeKind.Unspecified).AddTicks(5032), 5L, "Itaque totam ea earum.\nArchitecto qui earum nemo p", 54, 2, "voluptatem", new DateTimeOffset(new DateTime(2022, 9, 1, 12, 2, 27, 372, DateTimeKind.Unspecified).AddTicks(7517), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 9, 18, 58, 48, 445, DateTimeKind.Unspecified).AddTicks(3549), 3L, "et", 59, 1, "et", new DateTimeOffset(new DateTime(2023, 3, 6, 18, 16, 57, 709, DateTimeKind.Unspecified).AddTicks(215), new TimeSpan(0, 2, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 1, 0, 49, 49, 323, DateTimeKind.Unspecified).AddTicks(4111), 8L, "Deleniti quo nobis et dignissimos cupiditate disti", 13, 2, "et", new DateTimeOffset(new DateTime(2023, 2, 25, 13, 28, 48, 71, DateTimeKind.Unspecified).AddTicks(8981), new TimeSpan(0, 2, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 12, 13, 10, 20, 26, 336, DateTimeKind.Unspecified).AddTicks(6472), 4L, "Occaecati iusto id adipisci consequatur possimus o", 29, 2, "autem", new DateTimeOffset(new DateTime(2022, 9, 16, 0, 43, 32, 848, DateTimeKind.Unspecified).AddTicks(3971), new TimeSpan(0, 3, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 7, 4, 18, 25, 17, 166, DateTimeKind.Unspecified).AddTicks(888), "Enim et vitae minus. Nemo natus nobis commodi. Dol", 16, 2, "perferendis", new DateTimeOffset(new DateTime(2023, 7, 29, 9, 58, 36, 801, DateTimeKind.Unspecified).AddTicks(5983), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Quam ut ipsam laudantium ut occaecati. Atque consectetur est iusto sed eum. Reiciendis inventore corrupti eveniet eveniet ut ea doloremque ipsam sed. Ab ullam sed assumenda nisi. Culpa laborum eligendi est dicta expedita libero." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "abAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "rerumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Text",
                value: "Exercitationem sapiente porro.AAAAAAAAAAAAAAAAAAAA");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "rationeAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Sint atque veritatis est doloribus quae.\nOdio quidem voluptatem dolor ea esse ullam et.\nSunt fuga excepturi in.\nTotam itaque perferendis similique id.\nNihil magni voluptas eos ea pariatur." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Temporibus voluptatem eligendi mollitia ut sint. Quibusdam porro itaque vel in. Et quia ut cumque inventore quia ut. In explicabo porro perspiciatis doloribus voluptas est quaerat rem. Atque repellendus commodi eum et animi non doloribus. Sapiente laboriosam pariatur." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Dolor fuga molestiae eaque odio ut iure adipisci quis et." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Velit fugiat sint sint.AAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Et qui aliquid asperiores. Quia optio sed itaque qui. In excepturi amet. Assumenda provident sit tempora numquam iure." });

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
                value: 3);

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
                keyValue: 7L,
                column: "Priority",
                value: 10);

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
                value: 3);

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
                column: "Role",
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
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quisquam repellat dolor velit harum nihil odit sapiente laborum. Quas quibusdam suscipit ut rerum velit. Ipsa maxime velit modi nam ullam. Corporis totam dolores. Sunt et quasi magni voluptatem deserunt. Voluptas voluptate animi omnis laboriosam ex itaque corrupti.", "McClure Inc", "http://roy.biz", "Asia/Kolk" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Illo sit quibusdam nostrum omnis.\nAnimi vero distinctio dolor eum libero aliquid.\nSed ipsa porro non aut corporis.", "Beier, Roob and Goldner", "https://marlon.com", "Pacific/N" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quia sint officia animi qui qui qui fugit velit.\nNisi fugit vero.\nVoluptatem recusandae fuga et qui mollitia aut laborum.\nRecusandae voluptatibus ipsum sit quia beatae qui maiores.\nItaque deserunt perferendis et.", "Parisian - Zieme", "http://duncan.net", "Atlantic/" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quasi itaque enim est. Harum illo nostrum ipsum. Autem est sint et aspernatur minima vel.", "Hahn Group", "http://neil.name", "Asia/Yere" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Hic dignissimos nulla illum tempore perspiciatis accusamus libero praesentium quisquam. Voluptatibus ad et minus laudantium qui minus debitis mollitia. Asperiores sed iste possimus.", "Sauer, Howe and Bailey", "http://dayton.info", "Asia/Taip" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Dolores aut animi autem repellendus.\nPlaceat quas eaque temporibus animi voluptates reiciendis doloribus.", "Murazik Inc", "https://brian.org", "Pacific/M" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Animi rem sed aut nemo pariatur nostrum modi et dolorem.\nCumque ex quaerat quia temporibus aut id ducimus.\nImpedit ut in.", "Yundt - Zemlak", "http://dallas.com", "Asia/Bang" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Qui dolor reprehenderit eum ullam cupiditate minus alias est. Nulla dolores iste. Fuga ut quibusdam natus iusto explicabo et.", "Lockman - Hudson", "http://verner.com", "Europe/Lo" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quidem nostrum sapiente dolor ad culpa est et libero. Est sapiente quasi sapiente quis. Ut maiores fugit aperiam alias et. Aliquid id recusandae nihil nemo tempora et est. Illum nemo rerum nostrum. Impedit non earum nostrum consequatur.", "O'Conner - Stanton", "https://alana.com", "Asia/Kolk" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "illo", "Bartoletti LLC", "https://easter.com", "Europe/Pr" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Hattie29@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/801.jpg", "Hattie Hane", "1-775-291-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "James38@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/282.jpg", "James Prohaska", "639.599.49", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Salvatore.Champlin40@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/706.jpg", "Salvatore Champlin", "561-981-13", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Toni25@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/433.jpg", "Toni Carroll", "714-216-42", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Lance_Ebert68@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/859.jpg", "Lance Ebert", "1-687-614-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Clark_Moore@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/839.jpg", "Clark Moore", "741-251-70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Rose90@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/337.jpg", "Rose Stracke", "797-876-66" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Henrietta85@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/197.jpg", "Henrietta Powlowski", "(447) 233-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Carl77@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/188.jpg", "Carl Beahan", "853-403-53", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Alfred48@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/420.jpg", "Alfred Dietrich", "448-988-20", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationType",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "LocationType",
                table: "AvailabilitySlots");

            migrationBuilder.AddColumn<long>(
                name: "LocationId",
                table: "Meetings",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LocationId",
                table: "AvailabilitySlots",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 7, 30, 6, 14 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 1, 6, 6, 3, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 3, 8, 30, 4, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 11, 8, 1, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 7, 28, 6, 2, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 5, 1, 3, 14 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 1, 5, 3, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 7, 14, 8, 1, 7 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "PaddingMeeting" },
                values: new object[] { 2, 1, 20, 13 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 3, 3, 14, 3, 14 });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2020, 11, 8, 13, 2, 15, 376, DateTimeKind.Unspecified).AddTicks(6182), 5L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 7L, new DateTime(2020, 12, 3, 22, 39, 46, 879, DateTimeKind.Unspecified).AddTicks(343), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 2L, new DateTime(2019, 9, 16, 21, 16, 27, 409, DateTimeKind.Unspecified).AddTicks(2531), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 12, 13, 0, 40, 44, 260, DateTimeKind.Unspecified).AddTicks(709), 7L, 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 5, 31, 5, 17, 54, 329, DateTimeKind.Unspecified).AddTicks(8612), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 7, 15, 13, 5, 42, 5, DateTimeKind.Unspecified).AddTicks(6910), 7L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 2, 28, 15, 28, 34, 943, DateTimeKind.Unspecified).AddTicks(2372), 7L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 8, 6, 17, 50, 7, 929, DateTimeKind.Unspecified).AddTicks(4079), 9L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2021, 2, 25, 23, 42, 19, 617, DateTimeKind.Unspecified).AddTicks(7407), 10L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2021, 7, 10, 11, 37, 7, 127, DateTimeKind.Unspecified).AddTicks(6415), 3L, 3L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(7681), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 18, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(7513), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(7937), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 18, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(7965), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 18, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(7958), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(7986), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 18, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(7980), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(8007), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 18, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(8000), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(8027), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 18, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(8020), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(8047), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 18, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(8041), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(8068), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 18, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(8061), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(8089), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 18, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(8082), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(8109), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 18, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Hannah.Vandervort39@hotmail.c", new DateTimeOffset(new DateTime(2023, 7, 22, 17, 4, 31, 833, DateTimeKind.Unspecified).AddTicks(947), new TimeSpan(0, 3, 0, 0, 0)), "Hannah Vandervort" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Salvador_Durgan@hotmail.com", new DateTimeOffset(new DateTime(2022, 9, 3, 18, 40, 46, 275, DateTimeKind.Unspecified).AddTicks(2261), new TimeSpan(0, 3, 0, 0, 0)), "Salvador Durgan" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Eduardo_Kuhlman@hotmail.com", new DateTimeOffset(new DateTime(2023, 7, 9, 21, 46, 26, 944, DateTimeKind.Unspecified).AddTicks(56), new TimeSpan(0, 3, 0, 0, 0)), "Eduardo Kuhlman" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Mike.Wunsch@yahoo.com", new DateTimeOffset(new DateTime(2023, 4, 3, 9, 59, 9, 93, DateTimeKind.Unspecified).AddTicks(8750), new TimeSpan(0, 3, 0, 0, 0)), "Mike Wunsch" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Alicia4@gmail.com", new DateTimeOffset(new DateTime(2023, 7, 28, 7, 48, 12, 870, DateTimeKind.Unspecified).AddTicks(580), new TimeSpan(0, 3, 0, 0, 0)), "Alicia Wuckert" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Delia16@hotmail.com", new DateTimeOffset(new DateTime(2023, 2, 20, 4, 14, 2, 155, DateTimeKind.Unspecified).AddTicks(2474), new TimeSpan(0, 2, 0, 0, 0)), "Delia Kilback" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Glenda59@hotmail.com", new DateTimeOffset(new DateTime(2023, 6, 15, 19, 22, 18, 189, DateTimeKind.Unspecified).AddTicks(1755), new TimeSpan(0, 3, 0, 0, 0)), "Glenda Nienow" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Felicia28@yahoo.com", new DateTimeOffset(new DateTime(2023, 5, 4, 18, 3, 2, 983, DateTimeKind.Unspecified).AddTicks(6127), new TimeSpan(0, 3, 0, 0, 0)), "Felicia Douglas" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Cristina.Reinger@gmail.com", new DateTimeOffset(new DateTime(2023, 1, 6, 14, 9, 50, 341, DateTimeKind.Unspecified).AddTicks(6338), new TimeSpan(0, 2, 0, 0, 0)), "Cristina Reinger" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Gustavo.Maggio79@yahoo.com", new DateTimeOffset(new DateTime(2022, 8, 28, 14, 15, 2, 713, DateTimeKind.Unspecified).AddTicks(9722), new TimeSpan(0, 3, 0, 0, 0)), "Gustavo Maggio" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1L, false, "Zoom" },
                    { 2L, false, "GoogleMeet" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 3L, false, "Discord" },
                    { 4L, false, "Skype" },
                    { 5L, false, "Slack" }
                });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Praesentium et veniam exercitationem id eius error fugiat. Quisquam voluptas qui voluptas omnis vero ducimus quo. Adipisci temporibus molestiae minus cumque." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Est autem sit id cum nam. Et cupiditate voluptas neque molestiae autem dolores necessitatibus necessitatibus animi. Quae aut illum quia aut." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Aut quis maxime qui.\nExpedita odio blanditiis dolorem illum.\nOdit corporis sunt consectetur non sed eveniet est quibusdam autem.\nOdit atque voluptatibus sed qui." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Text",
                value: "Ipsum qui sit. Illum voluptas molestiae fugit sapiente qui voluptatem. Sit ea quasi amet aut.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Facere maxime error quam temporibus minima a.\nQui ea voluptatem qui et.\nVoluptatum nostrum quia non voluptatibus.\nDebitis aperiam quia velit est vel illum." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Qui eius laudantium officiis natus temporibus ea dolores doloribus quod. Ea culpa quos tempore et sed voluptas. Ipsum sed harum. Sunt in sit nulla magni repellat fugit cum. Eum aliquid magni deserunt cum quo illo quo aut qui. Repudiandae laudantium voluptatem at voluptatem vel consequatur voluptates" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Impedit repellat omnis atque praesentium dolorem rerum maiores minus. Et amet aperiam cum eum eaque quaerat ad. Impedit eos quis quae voluptatem dolor eligendi." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Velit ut in animi culpa error.\nExercitationem quia sint autem odit nam inventore laudantium." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Occaecati rem qui modi magni quos velit hic.\nDelectus laborum totam ea quibusdam cumque iusto molestiae tenetur.\nIpsa nulla id veritatis.\nAutem sit aliquid sed et et ea autem.\nAutem temporibus consequuntur molestias sunt sunt.\nMolestiae est occaecati sed non." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Cupiditate consequuntur at aperiam fugiat. Magni dolorum eum voluptatum. Pariatur qui laborum rem vel officia non harum. Quia ut quod possimus. Quia qui delectus corrupti voluptates modi. Fugit aliquid illo debitis quis et." });

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Priority",
                value: 9);

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
                value: 10);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Priority",
                value: 10);

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
                value: 3);

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
                value: 3);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Priority",
                value: 5);

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
                column: "Role",
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
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "perspiciatis", "Crona - Klein", "http://torey.biz", "Asia/Tehr" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Consequatur ut corporis occaecati sunt molestias cumque sapiente nemo voluptas.", "Bode, Leffler and Satterfield", "http://ashly.net", "Asia/Kual" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Repellat et consequatur dolorem rerum velit et accusamus.\nUt natus unde cupiditate.\nVoluptas quo quas ducimus et qui tempore commodi eum reprehenderit.\nQuidem maxime commodi.\nAccusantium ut occaecati consequuntur eaque molestias iusto voluptatum temporibus veniam.\nEarum occaecati expedita.", "Zboncak Inc", "http://tommie.net", "Asia/Vlad" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Dolore enim reiciendis.", "Dach - Barton", "https://mireille.info", "Etc/UTC" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Natus repellat corporis nihil non fuga. Eligendi odit illo saepe et sequi rerum et labore tempora. Omnis quia beatae iusto. Soluta minus dolore.", "Reilly, Wehner and Haag", "https://herman.name", "Asia/Sing" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Nemo ipsum blanditiis sunt tempora impedit maxime cumque eaque et. Ab atque quos. Magnam aut dolorem ipsam sed pariatur doloribus.", "Deckow Inc", "http://kyla.biz", "Europe/Is" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Et illum quasi ut.\nEt quis sit aut quo ratione voluptas quas in.\nConsequatur ea eos voluptate voluptatem deleniti corrupti in eveniet quis.\nEa velit nobis.\nNulla vel natus id et quia.", "Marks and Sons", "https://viva.com", "Europe/Pr" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quo voluptas autem quia architecto reprehenderit quis repellendus aliquid. Sapiente sed harum. Neque pariatur rerum non qui doloribus quis. Ut sit non exercitationem consequuntur perferendis voluptatibus consequatur modi ad. Laudantium non laborum et aut nostrum ut aut.", "Hammes - Balistreri", "https://durward.info", "Europe/Bu" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Nostrum in temporibus pariatur. Necessitatibus blanditiis consectetur sit eveniet facere. Incidunt id quo et et accusamus. Sit reprehenderit magnam omnis ut voluptatibus consequatur fugit mollitia non. Ipsum architecto omnis necessitatibus quos esse fugit qui.", "Turcotte Inc", "http://cayla.name", "Europe/Vi" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Non qui nam ullam dolor impedit non.", "Leannon, Goodwin and Wintheiser", "https://maxie.com", "Europe/Mo" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Sherri_Goodwin@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/13.jpg", "Sherri Goodwin", "311-956-45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Dennis72@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/980.jpg", "Dennis Yundt", "(387) 827-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Ronald21@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/654.jpg", "Ronald Herzog", "256.553.77", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "James_Lebsack@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/792.jpg", "James Lebsack", "612.275.79", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Rebecca.Sanford@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/47.jpg", "Rebecca Sanford", "888.482.76", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Jacob_Labadie24@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/249.jpg", "Jacob Labadie", "1-770-707-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Allen16@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/118.jpg", "Allen Muller", "834-241-53" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Myron.Mills55@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/32.jpg", "Myron Mills", "1-402-525-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Lillie_Schmeler@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/669.jpg", "Lillie Schmeler", "254-356-67", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Elsa.Hegmann@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/547.jpg", "Elsa Hegmann", "(348) 379-", 0 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2019, 8, 4, 22, 43, 4, 419, DateTimeKind.Unspecified).AddTicks(2216), 23, "http://genesis.name", 4L, "iste", 41, 0, "officiis" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 5, 22, 10, 13, 20, 947, DateTimeKind.Unspecified).AddTicks(3731), 20, "https://ramona.org", 5L, 29, 8L, "Laudantium omnis beatae aut est vel nihil occaecati voluptates. Ratione repudiandae exercitationem. Minus facilis quasi sequi consequatur blanditiis sunt omnis rerum porro." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 2, 1, 13, 53, 4, 376, DateTimeKind.Unspecified).AddTicks(2838), 17, "https://demarco.biz", 4L, "totam", 55, 5L, 0, "nam" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2021, 1, 2, 16, 6, 47, 218, DateTimeKind.Unspecified).AddTicks(7758), 21, "http://teresa.com", 1L, "libero", 22, 1L, "nemo" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 1, 19, 3, 45, 19, 905, DateTimeKind.Unspecified).AddTicks(3858), 29, "https://jayson.name", 4L, "magni", 29, 4L, "Ut sunt velit a. Iure atque nesciunt. Id molestiae ab omnis distinctio a nisi omnis recusandae. Non iste officiis illo dolores molestiae earum eos est reiciendis. Vel minus eligendi." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 11, 30, 3, 59, 38, 245, DateTimeKind.Unspecified).AddTicks(8534), 21, "http://johnny.info", 5L, "cupiditate", 36, 9L, 1, "A nihil sapiente quis assumenda incidunt. Aut praesentium mollitia. Ratione similique minus quia." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2019, 12, 23, 11, 28, 42, 719, DateTimeKind.Unspecified).AddTicks(2607), 30, "http://lesley.info", 3L, "dolor", 47, 7L, "Ducimus qui aperiam enim. Ea officiis maxime. Deleniti quia ad aut. Fugiat delectus debitis molestias aspernatur. Nostrum nesciunt quisquam ad quisquam delectus." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 10, 15, 3, 35, 58, 803, DateTimeKind.Unspecified).AddTicks(8928), 28, "https://alysha.name", 1L, "enim", 42, 10L, "Porro quia ipsam nostrum quis aperiam quia reiciendis.\nEos quidem quidem.\nNostrum sit et quas voluptatem sint.\nConsequatur aut minus quos corrupti cumque maiores id.\nVoluptate vel voluptatum reiciendis vero id quibusdam quis qui pariatur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 4, 23, 20, 47, 50, 369, DateTimeKind.Unspecified).AddTicks(7770), 15, "http://calista.org", 1L, "accusamus", 27, 8L, 1, "Alias repellendus sequi ut ut sint.\nLaborum aut explicabo rerum impedit veniam id incidunt." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 12, 19, 1, 14, 23, 555, DateTimeKind.Unspecified).AddTicks(1075), 29, "https://seth.org", 1L, "qui", 30, "A minus error ipsam. Aspernatur voluptatem aut ea pariatur quod. Aut et facere aut et dolorum repellendus. Non maxime voluptatem earum qui. Culpa optio voluptatem tempora sint eos nemo." });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 6, 3, 11, 36, 36, 869, DateTimeKind.Unspecified).AddTicks(6739), 7L, "Et non impedit eaque repellendus.\nAutem nobis nobi", 49, 5L, "tenetur", new DateTimeOffset(new DateTime(2023, 3, 15, 7, 42, 40, 985, DateTimeKind.Unspecified).AddTicks(3680), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 4, 5, 5, 41, 12, 556, DateTimeKind.Unspecified).AddTicks(8538), 10L, "animi", 28, 4L, "eum", new DateTimeOffset(new DateTime(2023, 2, 16, 6, 45, 45, 748, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, 2, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 9, 15, 4, 39, 482, DateTimeKind.Unspecified).AddTicks(9178), 9L, "Commodi unde perferendis ducimus modi nihil rerum", 26, 4L, "inventore", new DateTimeOffset(new DateTime(2023, 4, 4, 0, 13, 51, 485, DateTimeKind.Unspecified).AddTicks(9697), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 1, 24, 16, 9, 35, 494, DateTimeKind.Unspecified).AddTicks(9409), 2L, "Sit facere expedita eaque accusamus molestias id e", 41, 4L, "sed", new DateTimeOffset(new DateTime(2023, 2, 15, 17, 42, 46, 416, DateTimeKind.Unspecified).AddTicks(7511), new TimeSpan(0, 2, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 12, 25, 16, 18, 12, 62, DateTimeKind.Unspecified).AddTicks(6991), 6L, "Dolorum dolorum architecto et voluptas nostrum qui", 34, 1L, "ipsam", new DateTimeOffset(new DateTime(2022, 11, 6, 10, 40, 23, 93, DateTimeKind.Unspecified).AddTicks(8445), new TimeSpan(0, 2, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 23, 4, 21, 3, 828, DateTimeKind.Unspecified).AddTicks(3973), 4L, "Labore est fugit quos dolorum sed quia iusto quod.", 27, 2L, "et", new DateTimeOffset(new DateTime(2022, 12, 18, 11, 12, 54, 355, DateTimeKind.Unspecified).AddTicks(8028), new TimeSpan(0, 2, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 3, 18, 13, 21, 5, 676, DateTimeKind.Unspecified).AddTicks(4428), 9L, "ut", 19, 5L, "mollitia", new DateTimeOffset(new DateTime(2023, 4, 18, 2, 36, 18, 746, DateTimeKind.Unspecified).AddTicks(7211), new TimeSpan(0, 3, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 11, 12, 3, 39, 42, 658, DateTimeKind.Unspecified).AddTicks(5909), 2L, "Omnis eaque sapiente nisi alias dolore.", 39, 2L, "ex", new DateTimeOffset(new DateTime(2022, 9, 9, 13, 3, 37, 353, DateTimeKind.Unspecified).AddTicks(1458), new TimeSpan(0, 3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 10, 5, 50, 28, 861, DateTimeKind.Unspecified).AddTicks(2539), 9L, "Pariatur autem quidem quia similique amet voluptat", 47, 4L, "explicabo", new DateTimeOffset(new DateTime(2023, 7, 8, 9, 0, 17, 833, DateTimeKind.Unspecified).AddTicks(8287), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 9, 25, 14, 28, 41, 735, DateTimeKind.Unspecified).AddTicks(458), "odio", 12, 2L, "sunt", new DateTimeOffset(new DateTime(2022, 12, 11, 3, 41, 32, 352, DateTimeKind.Unspecified).AddTicks(1878), new TimeSpan(0, 2, 0, 0, 0)), 8L });

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_LocationId",
                table: "Meetings",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilitySlots_LocationId",
                table: "AvailabilitySlots",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AvailabilitySlots_Locations_LocationId",
                table: "AvailabilitySlots",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Locations_LocationId",
                table: "Meetings",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
