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
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 4, 11, 1, 6, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 1, 4, 6, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 8, 24, 5, 5, 6, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 6, 19, 7, 5, 10, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 13, 6, 3, 14, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 8, 16, 5, 4, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 4, 8, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 2, 11, 10, 1, 5, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 2, 1, 8, 1, 2, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 4, 1, 8, 4, 1, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 7, 26, 6, 38, 9, 872, DateTimeKind.Unspecified).AddTicks(5378), 15, "http://kurtis.net", 2, "accusantium", 37, 8L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "In voluptas porro." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 10, 1, 8, 14, 9, 532, DateTimeKind.Unspecified).AddTicks(8802), 16, "http://martine.net", 1, "repellat", 33, 2L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Quia fuga sint. Aut sequi laudantium omnis libero. Explicabo nulla molestiae." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 7, 15, 23, 30, 15, 739, DateTimeKind.Unspecified).AddTicks(4083), 16, "https://tina.com", 2, "eius", 23, 7L, 0, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "In maiores autem vel delectus et ullam illo maiores explicabo." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 10, 4, 2, 15, 34, 515, DateTimeKind.Unspecified).AddTicks(8074), 19, "https://elta.name", "omnis", 40, 2L, 0, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Quod esse quos hic ad tenetur consequuntur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 11, 15, 1, 27, 14, 10, DateTimeKind.Unspecified).AddTicks(1787), 27, "http://antonio.net", 1, "veritatis", 34, 10L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Ducimus numquam aut est ut autem amet.\nQuia quas id ratione." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2019, 8, 1, 18, 9, 0, 695, DateTimeKind.Unspecified).AddTicks(9446), 29, "https://fredy.name", 2, "debitis", 41, 2L, 0, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Autem magnam exercitationem fugit quo." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 1, 28, 9, 11, 19, 437, DateTimeKind.Unspecified).AddTicks(2516), 27, "https://guy.com", 1, "aut", 30, 1, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Molestias saepe placeat rem non ipsum incidunt.\nVeritatis et rerum neque fugit consequuntur quis quibusdam.\nProvident cumque aut neque consequuntur delectus.\nArchitecto non blanditiis consequuntur eos fugiat.\nIpsum explicabo est voluptas.\nSit eaque dolorum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 6, 3, 8, 48, 34, 329, DateTimeKind.Unspecified).AddTicks(8625), 29, "http://baylee.biz", 1, "neque", 19, 5L, 1, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Necessitatibus debitis sit nam neque reprehenderit harum esse sapiente.\nIpsam occaecati voluptatum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 4, 6, 3, 4, 10, 785, DateTimeKind.Unspecified).AddTicks(7474), 16, "http://oleta.biz", 1, "accusamus", 59, 1L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "ut" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2019, 10, 26, 9, 11, 52, 22, DateTimeKind.Unspecified).AddTicks(4091), 26, "http://kian.net", 2, "quis", 39, 3L, 0, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "quos" });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 6, 10, 18, 38, 36, 131, DateTimeKind.Unspecified).AddTicks(5441), 10L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2020, 4, 27, 1, 8, 8, 333, DateTimeKind.Unspecified).AddTicks(2953), 5L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 5, 10, 21, 16, 15, 621, DateTimeKind.Unspecified).AddTicks(8992), 3L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 4, 22, 0, 50, 14, 494, DateTimeKind.Unspecified).AddTicks(2517), 4L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2021, 2, 19, 9, 40, 4, 468, DateTimeKind.Unspecified).AddTicks(4846), new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 12, 5, 6, 20, 57, 471, DateTimeKind.Unspecified).AddTicks(5473), 6L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2019, 11, 9, 15, 38, 6, 560, DateTimeKind.Unspecified).AddTicks(8522), 8L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2019, 7, 31, 19, 49, 50, 906, DateTimeKind.Unspecified).AddTicks(6597), 8L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 4, 11, 4, 52, 7, 518, DateTimeKind.Unspecified).AddTicks(6706), 5L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2019, 12, 9, 11, 32, 25, 261, DateTimeKind.Unspecified).AddTicks(1458), new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 6L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4128), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 18, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4024), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4222), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 18, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4216), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4239), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 18, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4234), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4254), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 18, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4249), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4269), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 18, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4264), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4284), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 18, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4279), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4299), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 18, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4294), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4314), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 18, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4309), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4329), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 18, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4324), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4344), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 18, 13, 37, 34, 554, DateTimeKind.Unspecified).AddTicks(4339), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Oscar_Schmeler3@gmail.com", new DateTimeOffset(new DateTime(2023, 7, 31, 0, 32, 43, 589, DateTimeKind.Unspecified).AddTicks(1827), new TimeSpan(0, 3, 0, 0, 0)), "Oscar Schmeler" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Beverly_Tromp0@hotmail.com", new DateTimeOffset(new DateTime(2023, 7, 28, 14, 57, 1, 998, DateTimeKind.Unspecified).AddTicks(1539), new TimeSpan(0, 3, 0, 0, 0)), "Beverly Tromp" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Eddie_Ritchie83@hotmail.com", new DateTimeOffset(new DateTime(2023, 1, 17, 6, 24, 15, 792, DateTimeKind.Unspecified).AddTicks(2546), new TimeSpan(0, 2, 0, 0, 0)), "Eddie Ritchie" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Daryl.Cormier51@gmail.com", new DateTimeOffset(new DateTime(2023, 6, 20, 1, 42, 48, 106, DateTimeKind.Unspecified).AddTicks(2883), new TimeSpan(0, 3, 0, 0, 0)), "Daryl Cormier" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Cathy.Lueilwitz@gmail.com", new DateTimeOffset(new DateTime(2023, 5, 16, 3, 15, 53, 997, DateTimeKind.Unspecified).AddTicks(9670), new TimeSpan(0, 3, 0, 0, 0)), "Cathy Lueilwitz" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Lyle.Gottlieb@hotmail.com", new DateTimeOffset(new DateTime(2023, 6, 16, 5, 3, 34, 944, DateTimeKind.Unspecified).AddTicks(9822), new TimeSpan(0, 3, 0, 0, 0)), "Lyle Gottlieb" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Raquel.Mertz@gmail.com", new DateTimeOffset(new DateTime(2023, 2, 6, 21, 51, 54, 536, DateTimeKind.Unspecified).AddTicks(189), new TimeSpan(0, 2, 0, 0, 0)), "Raquel Mertz" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Bernice_Lockman@gmail.com", new DateTimeOffset(new DateTime(2022, 9, 24, 3, 14, 51, 167, DateTimeKind.Unspecified).AddTicks(1515), new TimeSpan(0, 3, 0, 0, 0)), "Bernice Lockman" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Marcia_Tromp39@yahoo.com", new DateTimeOffset(new DateTime(2023, 7, 10, 11, 39, 57, 711, DateTimeKind.Unspecified).AddTicks(1875), new TimeSpan(0, 3, 0, 0, 0)), "Marcia Tromp" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Ginger_Treutel@hotmail.com", new DateTimeOffset(new DateTime(2023, 1, 16, 1, 39, 53, 372, DateTimeKind.Unspecified).AddTicks(5357), new TimeSpan(0, 2, 0, 0, 0)), "Ginger Treutel" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 11, 30, 22, 39, 14, 149, DateTimeKind.Unspecified).AddTicks(6332), 5L, "Atque ipsam reiciendis qui numquam minima. Et fugi", 43, "voluptatem", new DateTimeOffset(new DateTime(2023, 3, 30, 1, 8, 59, 820, DateTimeKind.Unspecified).AddTicks(6076), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 29, 13, 32, 42, 376, DateTimeKind.Unspecified).AddTicks(8098), 1L, "Ea soluta cupiditate.\nQuia quo totam qui dolores f", 15, 2, "ea", new DateTimeOffset(new DateTime(2022, 12, 2, 8, 56, 34, 773, DateTimeKind.Unspecified).AddTicks(3774), new TimeSpan(0, 2, 0, 0, 0)), 5L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 8, 5, 35, 42, 415, DateTimeKind.Unspecified).AddTicks(5769), 5L, "Quia iusto provident non tenetur accusamus vero ap", 1, "repellendus", new DateTimeOffset(new DateTime(2023, 7, 1, 4, 35, 23, 666, DateTimeKind.Unspecified).AddTicks(251), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 9, 7, 21, 19, 49, 2, DateTimeKind.Unspecified).AddTicks(6221), 1L, "Quae quis libero voluptate repellendus asperiores.", 35, "qui", new DateTimeOffset(new DateTime(2023, 3, 2, 16, 9, 27, 555, DateTimeKind.Unspecified).AddTicks(4794), new TimeSpan(0, 2, 0, 0, 0)), 9L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 7, 28, 4, 30, 41, 927, DateTimeKind.Unspecified).AddTicks(3310), 3L, "Voluptatibus aperiam veritatis quam officiis est p", 22, "adipisci", new DateTimeOffset(new DateTime(2023, 6, 13, 23, 35, 10, 576, DateTimeKind.Unspecified).AddTicks(17), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 24, 17, 45, 48, 104, DateTimeKind.Unspecified).AddTicks(9784), 3L, "Aliquid eveniet aut iure sint mollitia laudantium", 52, 2, "eligendi", new DateTimeOffset(new DateTime(2022, 11, 9, 6, 59, 43, 244, DateTimeKind.Unspecified).AddTicks(7062), new TimeSpan(0, 2, 0, 0, 0)), 1L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 9, 18, 39, 58, 472, DateTimeKind.Unspecified).AddTicks(6442), "Consectetur sequi cupiditate sed.", 29, 1, "exercitationem", new DateTimeOffset(new DateTime(2023, 2, 9, 7, 33, 4, 773, DateTimeKind.Unspecified).AddTicks(4818), new TimeSpan(0, 2, 0, 0, 0)), 8L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 10, 31, 7, 18, 42, 320, DateTimeKind.Unspecified).AddTicks(5846), 9L, "rem", 21, 2, "velit", new DateTimeOffset(new DateTime(2023, 3, 24, 16, 3, 15, 331, DateTimeKind.Unspecified).AddTicks(9958), new TimeSpan(0, 2, 0, 0, 0)), 6L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 7, 8, 17, 18, 44, 365, DateTimeKind.Unspecified).AddTicks(2847), 6L, "Sunt aliquam quae consequuntur natus placeat vel v", 42, "est", new DateTimeOffset(new DateTime(2023, 3, 29, 9, 7, 56, 857, DateTimeKind.Unspecified).AddTicks(9254), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 3, 3, 53, 39, 895, DateTimeKind.Unspecified).AddTicks(1116), 1L, "Modi et non veniam.", 38, 1, "optio", new DateTimeOffset(new DateTime(2022, 10, 25, 13, 17, 15, 599, DateTimeKind.Unspecified).AddTicks(2169), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Commodi reiciendis nam.\nVoluptas et magnam maxime.\nNostrum alias dicta voluptatem reiciendis velit cum quibusdam architecto eius.\nQuo reprehenderit neque.\nA ipsa placeat ipsam." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Culpa eius aliquid et quibusdam quibusdam assumenda vero ducimus eum.\nEt quis error vero.\nAliquid perferendis tenetur.\nEt iure voluptas laborum at facilis qui porro.\nQui consequuntur id necessitatibus aut dicta qui aut non aut.\nExercitationem omnis et delectus nihil occaecati consectetur iste quam." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Asperiores iusto similique.AAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Text",
                value: "Corrupti reiciendis doloribus saepe accusantium.AA");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "ipsumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "accusamusAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "repellendusAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "etAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "esseAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "maximeAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

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
                value: 6);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Priority",
                value: 4);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Priority",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Priority",
                value: 5);

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
                column: "Role",
                value: 2);

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
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 6L,
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
                column: "Role",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

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
                values: new object[] { "quia", "O'Hara - Shanahan", "https://dedrick.info", "Europe/St" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Modi tenetur aspernatur.\nNon voluptas quia officia.\nVeniam debitis at est omnis.", "Gibson, Murazik and Stiedemann", "https://justice.name", "Europe/Lo" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Laboriosam officiis odit facilis est.", "Altenwerth - Beer", "https://diego.org", "America/C" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Eum enim est porro odit et.\nSapiente sapiente non vitae repudiandae animi aut vel ratione.", "Stoltenberg, Nader and Conroy", "https://yasmin.info", "Europe/Be" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Temporibus provident ipsa iste debitis rerum nesciunt consequatur et.\nRem aliquid qui aliquam totam qui ratione consequatur et cum.\nUt eligendi et doloribus illum.", "Kulas LLC", "http://lilyan.org", "Africa/Al" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quia sunt et.", "Walsh LLC", "https://bailey.info", "America/G" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Magni sit et nihil esse eos.\nConsequuntur quia sed voluptas accusamus excepturi iste quod.\nAt voluptatum asperiores omnis dolor voluptatibus veniam quaerat.", "Trantow, Cremin and West", "https://cade.org", "Atlantic/" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Et eligendi amet suscipit fugit.\nAlias est in assumenda quasi eius qui et ducimus.\nIn quos qui nobis eveniet error.\nSunt atque non sed id non blanditiis.", "Murphy and Sons", "https://petra.org", "Asia/Seou" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Enim velit qui quod ad qui ab enim.\nSit animi quia.\nQuis facilis nesciunt harum qui.\nAut quae aspernatur accusamus sunt consequatur assumenda.", "Becker, Monahan and Cremin", "http://brayan.org", "America/L" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "expedita", "Block LLC", "http://winnifred.org", "Europe/Lj" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Dolores57@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/670.jpg", "Dolores Grant", "982-883-70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Genevieve.Zulauf@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/384.jpg", "Genevieve Zulauf", "203-311-54" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Warren98@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/736.jpg", "Warren Grimes", "(971) 612-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Jared_Murray@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/217.jpg", "Jared Murray", "(575) 441-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Josh_Hettinger23@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/397.jpg", "Josh Hettinger", "1-649-900-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Jorge29@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/338.jpg", "Jorge Ortiz", "(927) 472-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Sophia_Weissnat@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1016.jpg", "Sophia Weissnat", "(695) 263-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Tonya_Huels@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/921.jpg", "Tonya Huels", "1-733-373-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Johnathan.Parker@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/223.jpg", "Johnathan Parker", "1-230-780-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Ashley.Gutmann@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1081.jpg", "Ashley Gutmann", "727.346.60" });
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
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 1, 15, 2, 2, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 8, 5, 13, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 5, 22, 8, 4, 3, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 15, 6, 1, 13, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 6, 15, 8, 2, 11, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 9, 10, 10, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 23, 8, 4, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 1, 14, 6, 4, 6, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 4, 20, 9, 2, 11, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 7, 14, 1, 3, 2, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2021, 4, 1, 4, 29, 32, 901, DateTimeKind.Unspecified).AddTicks(3747), 2L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 12, 5, 4, 27, 10, 722, DateTimeKind.Unspecified).AddTicks(6307), 2L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2019, 9, 15, 13, 29, 28, 64, DateTimeKind.Unspecified).AddTicks(707), 7L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2019, 8, 1, 12, 56, 24, 93, DateTimeKind.Unspecified).AddTicks(7337), 7L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 7, 12, 21, 27, 57, 541, DateTimeKind.Unspecified).AddTicks(1541), new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2021, 5, 12, 18, 20, 14, 193, DateTimeKind.Unspecified).AddTicks(853), 5L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 2, 22, 20, 21, 35, 933, DateTimeKind.Unspecified).AddTicks(7408), 4L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 9, 4, 20, 15, 0, 112, DateTimeKind.Unspecified).AddTicks(6397), 9L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 1, 11, 22, 15, 29, 592, DateTimeKind.Unspecified).AddTicks(9733), 9L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 4, 17, 13, 17, 33, 94, DateTimeKind.Unspecified).AddTicks(8891), new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 9L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 18, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8171), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 17, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(7981), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 18, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8380), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 17, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8364), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 18, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8416), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 17, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8405), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 18, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8474), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 17, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8437), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 18, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8506), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 17, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8496), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 18, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8535), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 17, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8525), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 18, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8563), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 17, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8553), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 18, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8591), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 17, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8581), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 18, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8618), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 17, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8609), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 18, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8645), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 17, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8635), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Toby_Spinka43@yahoo.com", new DateTimeOffset(new DateTime(2022, 10, 18, 11, 21, 31, 861, DateTimeKind.Unspecified).AddTicks(2859), new TimeSpan(0, 3, 0, 0, 0)), "Toby Spinka" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Justin_Raynor74@yahoo.com", new DateTimeOffset(new DateTime(2023, 5, 25, 23, 39, 37, 576, DateTimeKind.Unspecified).AddTicks(890), new TimeSpan(0, 3, 0, 0, 0)), "Justin Raynor" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Eduardo.Nicolas@yahoo.com", new DateTimeOffset(new DateTime(2023, 4, 8, 17, 36, 30, 452, DateTimeKind.Unspecified).AddTicks(1015), new TimeSpan(0, 3, 0, 0, 0)), "Eduardo Nicolas" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Agnes_Botsford@gmail.com", new DateTimeOffset(new DateTime(2023, 6, 24, 16, 58, 57, 200, DateTimeKind.Unspecified).AddTicks(9377), new TimeSpan(0, 3, 0, 0, 0)), "Agnes Botsford" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Abel_Schmitt@gmail.com", new DateTimeOffset(new DateTime(2023, 4, 28, 11, 38, 13, 525, DateTimeKind.Unspecified).AddTicks(6416), new TimeSpan(0, 3, 0, 0, 0)), "Abel Schmitt" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Vickie52@yahoo.com", new DateTimeOffset(new DateTime(2023, 5, 17, 3, 15, 8, 10, DateTimeKind.Unspecified).AddTicks(9598), new TimeSpan(0, 3, 0, 0, 0)), "Vickie Wisozk" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Michael34@yahoo.com", new DateTimeOffset(new DateTime(2022, 12, 6, 14, 11, 44, 784, DateTimeKind.Unspecified).AddTicks(5818), new TimeSpan(0, 2, 0, 0, 0)), "Michael Davis" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Carla.Shields88@gmail.com", new DateTimeOffset(new DateTime(2023, 2, 15, 17, 0, 12, 293, DateTimeKind.Unspecified).AddTicks(7975), new TimeSpan(0, 2, 0, 0, 0)), "Carla Shields" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Frederick_Witting18@yahoo.com", new DateTimeOffset(new DateTime(2023, 3, 20, 8, 17, 56, 960, DateTimeKind.Unspecified).AddTicks(7372), new TimeSpan(0, 2, 0, 0, 0)), "Frederick Witting" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Frances.Schneider@gmail.com", new DateTimeOffset(new DateTime(2022, 8, 29, 6, 17, 47, 506, DateTimeKind.Unspecified).AddTicks(178), new TimeSpan(0, 3, 0, 0, 0)), "Frances Schneider" });

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
                values: new object[] { 5L, "adipisciAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Modi facilis fugit quas rerum repellendus tempore eum quia velit." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "voluptatemAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Text",
                value: "Quibusdam quis ex. Laudantium et nemo. Aut cum odio. Quo voluptate quo accusamus dolor a.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Consequatur quo porro ut explicabo et sint aperiam. Ut qui neque harum voluptatem necessitatibus. Rerum repellat occaecati voluptatem laboriosam nostrum illo." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Et possimus laudantium quia rerum adipisci debitis occaecati. Officia at omnis tempore suscipit suscipit totam tenetur quibusdam nemo. Vel dolore maxime eligendi molestiae occaecati laudantium. Iusto reprehenderit ut cum qui vero aut. Similique voluptatem quod nemo." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Tempore earum qui sunt voluptatem sed perferendis. In adipisci ducimus explicabo. Eum quam praesentium enim et voluptatum adipisci ut. Non quos ea officiis autem nemo vitae. Fugit necessitatibus exercitationem eos sint rerum aut." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Molestiae voluptatum ut nisi et autem.\nProvident consequatur reprehenderit reprehenderit ab quos.\nEt quae suscipit cum corrupti ex." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "velAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Rerum rerum natus maxime reiciendis aut.\nVoluptate officiis quaerat ut alias id." });

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
                keyValue: 6L,
                column: "Priority",
                value: 6);

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
                value: 10);

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
                column: "Role",
                value: 1);

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
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 6L,
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
                column: "Role",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

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
                values: new object[] { "perferendis", "Boyer, Bechtelar and Little", "http://austyn.net", "Australia" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Pariatur atque ut voluptate suscipit. Dolor laudantium voluptatem unde qui illum qui. Quos beatae sint ullam est velit et. Aut ipsam eligendi autem a. Ut sint voluptatem et non labore. Perspiciatis eum nisi ipsa dolor.", "McKenzie and Sons", "http://johnny.org", "Europe/Br" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Et enim facilis mollitia at iusto a rerum. Voluptate veniam sed saepe earum soluta eligendi non ipsam at. Enim fuga enim qui ipsum est aut modi et. Unde eligendi est iusto et. A necessitatibus necessitatibus voluptates veritatis numquam enim.", "Schaden, Harris and Champlin", "http://efrain.org", "America/H" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Libero amet necessitatibus vero.", "Volkman, Kshlerin and Crooks", "https://erick.name", "Africa/Jo" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "doloribus", "Corwin - Okuneva", "https://palma.info", "Europe/Vi" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "velit", "McGlynn - Simonis", "http://cathryn.net", "Asia/Kual" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Eveniet veniam aut ab debitis facere et voluptates velit enim.", "Schaden Group", "http://karolann.org", "Europe/Vi" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "aut", "Wehner, Swaniawski and West", "http://tiffany.org", "Asia/Yaku" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "quidem", "Ryan and Sons", "https://lorenzo.info", "Europe/Co" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "iste", "Ferry Group", "http://benedict.name", "Asia/Dhak" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Seth_Ullrich@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/764.jpg", "Seth Ullrich", "740.582.42" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Tommie.McCullough@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1043.jpg", "Tommie McCullough", "632-746-39" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Karl.Swaniawski44@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/48.jpg", "Karl Swaniawski", "(779) 420-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Cesar18@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1152.jpg", "Cesar Rosenbaum", "645.236.79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Forrest_Kerluke@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/372.jpg", "Forrest Kerluke", "(245) 379-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Sophia_Rohan92@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/390.jpg", "Sophia Rohan", "948-323-40", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Blanche_Kling65@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1094.jpg", "Blanche Kling", "985-600-56" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Warren_Ondricka39@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/711.jpg", "Warren Ondricka", "931.651.92" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Jody.Heidenreich@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/380.jpg", "Jody Heidenreich", "1-947-874-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Bernice.Dicki@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1019.jpg", "Bernice Dicki", "(712) 768-" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 10, 20, 4, 18, 42, 206, DateTimeKind.Unspecified).AddTicks(1391), 19, "https://akeem.com", 3L, "magnam", 31, 4L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "id" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 1, 3, 6, 54, 43, 172, DateTimeKind.Unspecified).AddTicks(9468), 24, "http://avis.com", 1L, "enim", 49, 10L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Beatae qui odio est nisi ipsam nulla asperiores." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 11, 29, 3, 37, 7, 284, DateTimeKind.Unspecified).AddTicks(3466), 25, "http://ruthe.org", 4L, "et", 19, 5L, 1, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Vel velit sit ea molestiae laudantium distinctio itaque pariatur.\nQuod officiis et sunt aliquid.\nEos debitis ut libero non repudiandae consequatur.\nNemo tenetur illo perspiciatis possimus officia aperiam.\nPossimus commodi et modi voluptatem quibusdam earum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 3, 26, 23, 31, 48, 208, DateTimeKind.Unspecified).AddTicks(2056), 16, "http://dovie.name", 2L, "provident", 45, 9L, 1, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Tempora ducimus veritatis unde debitis molestias aut. Quo praesentium vel optio enim. Consectetur et ea tempora itaque molestias est odit labore. Voluptatem sed natus occaecati molestiae deleniti et unde. Aut itaque vel repellendus. Et corporis suscipit hic ut consequatur dolore mollitia." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 12, 14, 21, 34, 30, 220, DateTimeKind.Unspecified).AddTicks(1129), 16, "https://berta.com", 5L, "beatae", 15, 6L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Vero error quia consequatur asperiores rem fugit officia sint.\nEt vel soluta voluptatibus nemo.\nSed natus quasi praesentium dolores." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 1, 14, 12, 14, 47, 359, DateTimeKind.Unspecified).AddTicks(1810), 17, "http://bernie.com", 4L, "ex", 35, 4L, 1, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Non quia tempore voluptatibus dolorum nesciunt atque officiis sunt. Minima possimus quod corrupti aut non. Assumenda doloremque laudantium accusamus eum quia." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 10, 3, 5, 28, 33, 955, DateTimeKind.Unspecified).AddTicks(5449), 18, "https://alexandrine.org", 3L, "asperiores", 52, 0, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Nihil illo nesciunt in.\nConsequuntur asperiores assumenda itaque porro iusto et voluptatem.\nOmnis quasi molestiae autem cum vel voluptatibus velit.\nDolores omnis aperiam maxime qui qui odio praesentium repellendus vel.\nEt quam dicta optio." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 8, 19, 0, 27, 38, 916, DateTimeKind.Unspecified).AddTicks(7202), 16, "http://corine.info", 2L, "veritatis", 51, 2L, 0, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "modi" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 8, 13, 21, 22, 1, 797, DateTimeKind.Unspecified).AddTicks(6814), 15, "https://brady.net", 2L, "enim", 32, 6L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Sed recusandae perspiciatis possimus necessitatibus deserunt doloremque." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 11, 25, 9, 16, 32, 894, DateTimeKind.Unspecified).AddTicks(8800), 18, "http://bailee.name", 2L, "ut", 49, 4L, 1, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Consequatur recusandae magni." });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 31, 8, 38, 38, 616, DateTimeKind.Unspecified).AddTicks(7517), 1L, "Id modi dolor.", 15, 4L, "omnis", new DateTimeOffset(new DateTime(2023, 3, 19, 0, 47, 28, 241, DateTimeKind.Unspecified).AddTicks(739), new TimeSpan(0, 2, 0, 0, 0)), 1L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 31, 8, 7, 50, 109, DateTimeKind.Unspecified).AddTicks(310), 6L, "Voluptas molestiae tempora officiis impedit.", 43, 2L, "quia", new DateTimeOffset(new DateTime(2022, 9, 21, 4, 55, 39, 565, DateTimeKind.Unspecified).AddTicks(8878), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 17, 8, 41, 19, 813, DateTimeKind.Unspecified).AddTicks(3289), 2L, "Quam nesciunt quis vel. Consequatur aspernatur qui", 4L, "facere", new DateTimeOffset(new DateTime(2022, 12, 7, 17, 1, 21, 365, DateTimeKind.Unspecified).AddTicks(5499), new TimeSpan(0, 2, 0, 0, 0)), 7L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 11, 30, 5, 26, 45, 883, DateTimeKind.Unspecified).AddTicks(7562), 10L, "Vitae consequatur impedit.", 19, 3L, "est", new DateTimeOffset(new DateTime(2023, 1, 1, 20, 23, 49, 96, DateTimeKind.Unspecified).AddTicks(181), new TimeSpan(0, 2, 0, 0, 0)), 5L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 6, 5, 33, 22, 513, DateTimeKind.Unspecified).AddTicks(5024), 5L, "Quia ut sunt dolores quae nesciunt recusandae eum", 37, 4L, "atque", new DateTimeOffset(new DateTime(2023, 3, 30, 15, 43, 30, 316, DateTimeKind.Unspecified).AddTicks(9070), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 3, 10, 6, 47, 59, 69, DateTimeKind.Unspecified).AddTicks(8732), 4L, "Aspernatur aspernatur velit labore enim voluptatem", 29, 4L, "eos", new DateTimeOffset(new DateTime(2023, 6, 14, 21, 55, 35, 771, DateTimeKind.Unspecified).AddTicks(4004), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 25, 4, 56, 24, 64, DateTimeKind.Unspecified).AddTicks(4741), "Magni porro perspiciatis harum qui et dolorum. Omn", 53, 4L, "eos", new DateTimeOffset(new DateTime(2023, 7, 19, 15, 15, 1, 859, DateTimeKind.Unspecified).AddTicks(2098), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 10, 3, 0, 11, 35, 483, DateTimeKind.Unspecified).AddTicks(3795), 3L, "Beatae magnam tempora adipisci aliquid iure illum", 35, 3L, "sit", new DateTimeOffset(new DateTime(2023, 8, 13, 13, 12, 33, 398, DateTimeKind.Unspecified).AddTicks(3516), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 5, 22, 2, 28, 258, DateTimeKind.Unspecified).AddTicks(4103), 3L, "Autem officiis occaecati voluptates. Illo repellen", 16, 3L, "aut", new DateTimeOffset(new DateTime(2023, 2, 18, 15, 3, 36, 109, DateTimeKind.Unspecified).AddTicks(9580), new TimeSpan(0, 2, 0, 0, 0)), 4L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 12, 12, 31, 58, 460, DateTimeKind.Unspecified).AddTicks(599), 6L, "Vitae mollitia doloribus ipsa dolor cum blanditiis", 54, 5L, "temporibus", new DateTimeOffset(new DateTime(2023, 5, 14, 16, 30, 44, 1, DateTimeKind.Unspecified).AddTicks(6066), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

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
