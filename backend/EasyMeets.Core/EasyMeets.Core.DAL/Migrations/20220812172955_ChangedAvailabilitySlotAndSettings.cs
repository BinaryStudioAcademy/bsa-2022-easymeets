using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class ChangedAvailabilitySlotAndSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedSlotSettings_AvailabilitySlots_AvailabilitySlotId",
                table: "AdvancedSlotSettings");

            migrationBuilder.DropIndex(
                name: "IX_AdvancedSlotSettings_AvailabilitySlotId",
                table: "AdvancedSlotSettings");

            migrationBuilder.DropColumn(
                name: "AvailabilitySlotId",
                table: "AdvancedSlotSettings");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "AdvancedSlotSettings");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "AvailabilitySlots",
                newName: "WelcomeMessage");

            migrationBuilder.RenameColumn(
                name: "PaddingBeforeMeeting",
                table: "AdvancedSlotSettings",
                newName: "PaddingMeeting");

            migrationBuilder.RenameColumn(
                name: "BookingScheduleBlockingTimeMeetingInHours",
                table: "AdvancedSlotSettings",
                newName: "MinBookingMeetingDifference");

            migrationBuilder.AlterColumn<long>(
                name: "AdvancedSlotSettingsId",
                table: "AvailabilitySlots",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AllowToAddGuests",
                table: "AvailabilitySlots",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "BookingsPerDay",
                table: "AvailabilitySlots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "AvailabilitySlots",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PasswordProtection",
                table: "AvailabilitySlots",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TimeZoneVisibility",
                table: "AvailabilitySlots",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 8, 9, 10, 15 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 14, 2, 1, 10 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 2, 28, 3, 1, 10 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 2, 6, 12, 4, 12 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 3, 7, 4, 7, 5 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Days" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 3, 12, 4, 2, 15 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 2, 25, 7, 5, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 4, 22, 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 6, 27, 2, 3, 11 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TimeZoneVisibility", "WelcomeMessage" },
                values: new object[] { true, 2, new DateTime(2020, 1, 9, 4, 22, 2, 527, DateTimeKind.Unspecified).AddTicks(900), 20, "Ukrainian", "http://marisa.org", 1L, "reprehenderit", 16, true, "Sequi voluptatem eveniet aut culpa quibusdam at iure assumenda repudiandae." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TeamId", "TimeZoneVisibility", "Type", "WelcomeMessage" },
                values: new object[] { true, 1, new DateTime(2019, 12, 22, 19, 3, 55, 274, DateTimeKind.Unspecified).AddTicks(5246), 21, "Ukrainian", "https://annetta.info", 5L, "nulla", 32, 7L, true, 2, "ipsum" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TeamId", "TimeZoneVisibility", "WelcomeMessage" },
                values: new object[] { true, 1, new DateTime(2021, 4, 7, 1, 56, 24, 152, DateTimeKind.Unspecified).AddTicks(9434), 27, "Ukrainian", "http://rosetta.org", 1L, "fugit", 57, 8L, true, "Vitae aut sed quo rerum ullam quaerat." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "Name", "Size", "TeamId", "TimeZoneVisibility", "WelcomeMessage" },
                values: new object[] { true, 5, new DateTime(2020, 9, 2, 2, 32, 58, 829, DateTimeKind.Unspecified).AddTicks(2649), 21, "Ukrainian", "https://kraig.info", "corrupti", 18, 10L, true, "Nesciunt sed corporis commodi.\nRerum excepturi quia nemo sit.\nVoluptatem eaque eum exercitationem reiciendis incidunt aliquam quasi." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TeamId", "TimeZoneVisibility", "Type", "WelcomeMessage" },
                values: new object[] { true, 2, new DateTime(2020, 7, 3, 1, 8, 5, 774, DateTimeKind.Unspecified).AddTicks(7080), 26, "Ukrainian", "https://hobart.info", 4L, "aut", 40, 4L, true, 2, "Consequatur vel nemo exercitationem eum aut.\nDoloribus voluptatum architecto et corrupti sed rerum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "Name", "Size", "TeamId", "TimeZoneVisibility", "Type", "WelcomeMessage" },
                values: new object[] { true, 2, new DateTime(2019, 12, 21, 11, 18, 11, 287, DateTimeKind.Unspecified).AddTicks(9327), 26, "Ukrainian", "https://benedict.biz", "voluptatibus", 54, 9L, true, 1, "Qui eos et soluta quaerat odit et veniam.\nItaque dolorum veniam quo dolores at velit tempore quia minima.\nId ut deserunt natus sint.\nEarum asperiores exercitationem alias autem." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TeamId", "TimeZoneVisibility", "WelcomeMessage" },
                values: new object[] { true, 1, new DateTime(2021, 6, 7, 3, 51, 53, 848, DateTimeKind.Unspecified).AddTicks(5758), 24, "Ukrainian", "https://dell.com", 5L, "ea", 44, 8L, true, "Odio recusandae assumenda dolor.\nTempore autem inventore aut esse tempore doloribus sint qui maxime.\nUt officiis dolores magni distinctio minus commodi dicta ipsam officiis.\nIpsa non rem.\nRem totam ipsam praesentium ea." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TeamId", "TimeZoneVisibility", "Type", "WelcomeMessage" },
                values: new object[] { true, 1, new DateTime(2020, 11, 26, 3, 4, 7, 991, DateTimeKind.Unspecified).AddTicks(8125), 25, "Ukrainian", "https://pete.info", 4L, "sunt", 19, 7L, true, 1, "Consectetur doloribus non rerum.\nAut voluptate eligendi laudantium quia distinctio.\nAspernatur doloremque dolor velit rerum voluptatem assumenda amet aliquid.\nNon accusantium officiis laudantium ut quod.\nEt vitae est tenetur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TeamId", "TimeZoneVisibility", "Type", "WelcomeMessage" },
                values: new object[] { true, 3, new DateTime(2020, 3, 12, 16, 0, 40, 521, DateTimeKind.Unspecified).AddTicks(3342), 19, "Ukrainian", "http://luciano.biz", 1L, "quas", 59, 4L, true, 2, "et" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "Name", "Size", "TeamId", "TimeZoneVisibility", "Type", "WelcomeMessage" },
                values: new object[] { true, 5, new DateTime(2021, 1, 28, 6, 51, 42, 228, DateTimeKind.Unspecified).AddTicks(7611), 17, "Ukrainian", "https://melisa.org", "odit", 52, 3L, true, 1, "Sapiente sed repudiandae libero officiis.\nMolestias consequatur voluptatem.\nNobis est sunt quaerat ut.\nEarum ut sed veritatis voluptatem.\nUt dolor reiciendis consequatur fuga dolor nostrum id corrupti." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 6, 5, 18, 32, 18, 290, DateTimeKind.Unspecified).AddTicks(8528), 4L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 3, 4, 22, 56, 28, 255, DateTimeKind.Unspecified).AddTicks(236), 7L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 2L, new DateTime(2020, 7, 28, 2, 20, 3, 240, DateTimeKind.Unspecified).AddTicks(6355), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 11, 11, 16, 17, 1, 998, DateTimeKind.Unspecified).AddTicks(9383), 8L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 4, 20, 16, 33, 9, 919, DateTimeKind.Unspecified).AddTicks(5486), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 12, 2, 9, 18, 22, 73, DateTimeKind.Unspecified).AddTicks(7726), 4L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2020, 1, 24, 18, 43, 47, 127, DateTimeKind.Unspecified).AddTicks(8398), 5L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 2, 23, 21, 13, 24, 337, DateTimeKind.Unspecified).AddTicks(7638), 2L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 12, 31, 13, 1, 53, 92, DateTimeKind.Unspecified).AddTicks(740), 8L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2019, 8, 15, 22, 41, 12, 649, DateTimeKind.Unspecified).AddTicks(2471), 3L, 10L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(308), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 13, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(165), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(598), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 13, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(581), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(623), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 13, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(615), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(644), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 13, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(637), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(664), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 13, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(657), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(683), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 13, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(677), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(703), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 13, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(696), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(722), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 13, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(715), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(741), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 13, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(734), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(760), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 13, 20, 29, 53, 627, DateTimeKind.Unspecified).AddTicks(754), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Edward39@yahoo.comAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 8, 6, 21, 53, 41, 528, DateTimeKind.Unspecified).AddTicks(9798), new TimeSpan(0, 3, 0, 0, 0)), "Edward Gutkowski" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Keith40@hotmail.comAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 3, 24, 23, 46, 10, 457, DateTimeKind.Unspecified).AddTicks(4016), new TimeSpan(0, 2, 0, 0, 0)), "Keith Purdy" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Tammy_Rodriguez@yahoo.comAAAAA", new DateTimeOffset(new DateTime(2023, 4, 11, 6, 37, 48, 737, DateTimeKind.Unspecified).AddTicks(607), new TimeSpan(0, 3, 0, 0, 0)), "Tammy Rodriguez" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Tony_OKeefe@gmail.comAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 4, 8, 10, 46, 4, 498, DateTimeKind.Unspecified).AddTicks(4165), new TimeSpan(0, 3, 0, 0, 0)), "Tony O'Keefe" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Kevin8@gmail.comAAAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 3, 21, 15, 23, 31, 70, DateTimeKind.Unspecified).AddTicks(9503), new TimeSpan(0, 2, 0, 0, 0)), "Kevin Luettgen" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Barbara_Legros@gmail.comAAAAAA", new DateTimeOffset(new DateTime(2022, 9, 17, 13, 38, 15, 272, DateTimeKind.Unspecified).AddTicks(5611), new TimeSpan(0, 3, 0, 0, 0)), "Barbara Legros" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Kathleen90@gmail.comAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 4, 17, 14, 51, 33, 988, DateTimeKind.Unspecified).AddTicks(6104), new TimeSpan(0, 3, 0, 0, 0)), "Kathleen Carter" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Herman91@hotmail.comAAAAAAAAAA", new DateTimeOffset(new DateTime(2022, 8, 29, 15, 18, 55, 285, DateTimeKind.Unspecified).AddTicks(4723), new TimeSpan(0, 3, 0, 0, 0)), "Herman Frami" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Victoria_Walker@gmail.comAAAAA", new DateTimeOffset(new DateTime(2022, 9, 20, 22, 29, 31, 101, DateTimeKind.Unspecified).AddTicks(9092), new TimeSpan(0, 3, 0, 0, 0)), "Victoria Walker" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Felicia59@yahoo.comAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 4, 18, 10, 38, 21, 914, DateTimeKind.Unspecified).AddTicks(1332), new TimeSpan(0, 3, 0, 0, 0)), "Felicia Erdman" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2020, 1, 16, 20, 58, 11, 559, DateTimeKind.Unspecified).AddTicks(6813), "rerum", 46, 1L, "dolorem", new DateTimeOffset(new DateTime(2023, 2, 20, 6, 26, 41, 964, DateTimeKind.Unspecified).AddTicks(4921), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2020, 10, 4, 1, 37, 52, 540, DateTimeKind.Unspecified).AddTicks(3555), 9L, "molestias", 50, 5L, "maiores", new DateTimeOffset(new DateTime(2023, 4, 9, 22, 11, 56, 152, DateTimeKind.Unspecified).AddTicks(6076), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2020, 11, 15, 8, 20, 25, 460, DateTimeKind.Unspecified).AddTicks(3552), 5L, "Illo pariatur harum non.", 34, 4L, "voluptatem", new DateTimeOffset(new DateTime(2023, 7, 22, 19, 52, 7, 764, DateTimeKind.Unspecified).AddTicks(4297), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 22, 21, 29, 9, 914, DateTimeKind.Unspecified).AddTicks(9302), 3L, "Cum autem reprehenderit quia sint molestiae enim v", 28, 1L, "esse", new DateTimeOffset(new DateTime(2023, 4, 8, 21, 39, 48, 130, DateTimeKind.Unspecified).AddTicks(2990), new TimeSpan(0, 3, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 7, 26, 11, 24, 20, 932, DateTimeKind.Unspecified).AddTicks(7095), 9L, "Aut aut voluptatem alias deserunt voluptas adipisc", 33, 2L, "ipsam", new DateTimeOffset(new DateTime(2023, 4, 6, 5, 27, 48, 881, DateTimeKind.Unspecified).AddTicks(7557), new TimeSpan(0, 3, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 6, 30, 12, 41, 36, 971, DateTimeKind.Unspecified).AddTicks(8287), 8L, "Ad incidunt iste culpa.", 22, 1L, "inventore", new DateTimeOffset(new DateTime(2022, 12, 12, 16, 41, 45, 718, DateTimeKind.Unspecified).AddTicks(8273), new TimeSpan(0, 2, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 7, 21, 2, 45, 10, 397, DateTimeKind.Unspecified).AddTicks(7245), 3L, "Quo est in voluptas maiores nihil beatae consectet", 60, 3L, "eum", new DateTimeOffset(new DateTime(2023, 8, 1, 14, 28, 55, 498, DateTimeKind.Unspecified).AddTicks(6576), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 6, 21, 15, 44, 55, 488, DateTimeKind.Unspecified).AddTicks(8640), 6L, "optio", 36, 1L, "beatae", new DateTimeOffset(new DateTime(2023, 7, 30, 4, 34, 14, 942, DateTimeKind.Unspecified).AddTicks(1760), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2019, 8, 29, 2, 18, 4, 210, DateTimeKind.Unspecified).AddTicks(5196), "Iure nulla reiciendis eum similique.", 33, 2L, "ipsum", new DateTimeOffset(new DateTime(2023, 6, 12, 7, 44, 47, 304, DateTimeKind.Unspecified).AddTicks(4781), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 1, 3, 4, 0, 17, 115, DateTimeKind.Unspecified).AddTicks(8344), 4L, "Veniam maiores accusantium fuga.\nSit laborum occae", 25, 3L, "reprehenderit", new DateTimeOffset(new DateTime(2023, 3, 24, 10, 13, 44, 213, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 2, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Soluta dolores qui mollitia dolor.AAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Itaque sit impedit velit necessitatibus aspernatur assumenda." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "culpaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Maiores cum adipisci.\nSed quaerat assumenda nemo blanditiis.\nDolorem libero modi ratione rerum ut consequatur.\nQuibusdam nisi qui voluptas rem quam qui quibusdam eveniet.\nQuasi dolores quos consectetur sint expedita.\nQuisquam asperiores inventore laboriosam nemo eveniet commodi veniam." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "idAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Autem minima itaque cupiditate dolor molestiae maiores laborum est.\nEst sit nesciunt.\nIusto sed autem quas ratione praesentium quia magnam magni quia.\nA quos et beatae nihil ipsum omnis explicabo.\nIn amet totam et qui reprehenderit assumenda." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "solutaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Quaerat sint iste debitis occaecati voluptates id in et. Eum voluptas sed minus. Et et ut voluptatem. Recusandae qui dolorem. Officia vel non. Excepturi quo nihil dolores dolorum." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Dignissimos sed sunt et.\nVoluptatem consequatur accusantium temporibus dolor dolore." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Sapiente ipsum odit ut dicta. Eveniet eligendi asperiores nam quibusdam. Delectus unde aspernatur officia sequi provident quia. Sed vero voluptatibus eaque quia. Laboriosam pariatur accusamus maxime voluptas quam aliquid alias praesentium. Magnam commodi doloremque." });

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
                value: 6);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Priority",
                value: 10);

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
                value: 6);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Priority",
                value: 10);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 10L,
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
                column: "Role",
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
                column: "Role",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Role",
                value: 1);

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Illum voluptas nam et explicabo debitis voluptate.", "Hickle, Kuphal and Erdman", "http://wendell.com", "America/M" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Optio aut officiis atque.", "Kris, Bartoletti and Von", "https://johnathon.org", "America/C" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Minus quia rerum id pariatur deserunt assumenda.", "Stokes - VonRueden", "https://nichole.org", "Australia" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "asperiores", "O'Conner, O'Conner and Rippin", "https://hallie.org", "America/H" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Ex hic nesciunt animi.", "Oberbrunner - Pfannerstill", "https://cayla.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Consequuntur impedit quia unde.", "Wiegand, Donnelly and Durgan", "http://keira.org", "Asia/Novo" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Porro voluptas dicta. Est velit voluptate omnis voluptatem sunt alias. Sint et totam sit esse incidunt. Vel mollitia quia odit eos.", "West - Kihn", "http://freeda.info", "Australia" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Velit accusamus illo. Laboriosam harum rerum laboriosam magnam. Nihil a vel. Nemo dolorem consectetur nulla qui rerum minus molestiae est. Quos fuga reprehenderit voluptatem officia fugiat ut repellat ut ea.", "Wiegand - Kuvalis", "https://rosina.biz", "Europe/Du" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Blanditiis at totam.\nEnim sunt nemo.\nAperiam vel ullam fugiat natus dolores aut voluptatem facilis libero.\nVoluptatem ut error fuga enim voluptates eos sit atque.", "Tillman, Armstrong and Pfeffer", "http://alexandro.net", "Asia/Musc" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "consequatur", "Nikolaus - Schultz", "https://mitchell.name", "Europe/Lo" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Antonia_Swift97@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/530.jpg", "Antonia Swift", "1-340-549-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Elena6@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/995.jpg", "Elena Heller", "(766) 613-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Karen90@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/756.jpg", "Karen Hauck", "1-390-825-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Kristie52@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/969.jpg", "Kristie Kiehn", "1-866-339-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Bob27@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/669.jpg", "Bob Hoeger", "(760) 697-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Joyce.Miller@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/62.jpg", "Joyce Miller", "1-512-818-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Leland98@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/115.jpg", "Leland Hyatt", "640-722-29" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Armando91@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/282.jpg", "Armando VonRueden", "(352) 674-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Bob68@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1246.jpg", "Bob Toy", "(484) 303-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Esther85@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/986.jpg", "Esther Klein", "383-877-74" });

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilitySlots_AdvancedSlotSettingsId",
                table: "AvailabilitySlots",
                column: "AdvancedSlotSettingsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AvailabilitySlots_AdvancedSlotSettings_AdvancedSlotSettingsId",
                table: "AvailabilitySlots",
                column: "AdvancedSlotSettingsId",
                principalTable: "AdvancedSlotSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailabilitySlots_AdvancedSlotSettings_AdvancedSlotSettingsId",
                table: "AvailabilitySlots");

            migrationBuilder.DropIndex(
                name: "IX_AvailabilitySlots_AdvancedSlotSettingsId",
                table: "AvailabilitySlots");

            migrationBuilder.DropColumn(
                name: "AllowToAddGuests",
                table: "AvailabilitySlots");

            migrationBuilder.DropColumn(
                name: "BookingsPerDay",
                table: "AvailabilitySlots");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "AvailabilitySlots");

            migrationBuilder.DropColumn(
                name: "PasswordProtection",
                table: "AvailabilitySlots");

            migrationBuilder.DropColumn(
                name: "TimeZoneVisibility",
                table: "AvailabilitySlots");

            migrationBuilder.RenameColumn(
                name: "WelcomeMessage",
                table: "AvailabilitySlots",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "PaddingMeeting",
                table: "AdvancedSlotSettings",
                newName: "PaddingBeforeMeeting");

            migrationBuilder.RenameColumn(
                name: "MinBookingMeetingDifference",
                table: "AdvancedSlotSettings",
                newName: "BookingScheduleBlockingTimeMeetingInHours");

            migrationBuilder.AlterColumn<long>(
                name: "AdvancedSlotSettingsId",
                table: "AvailabilitySlots",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "AvailabilitySlotId",
                table: "AdvancedSlotSettings",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "EndDate",
                table: "AdvancedSlotSettings",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting" },
                values: new object[] { 1L, 3, 28, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting" },
                values: new object[] { 1, 2L, 4, 5, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 8, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting" },
                values: new object[] { 3, 3L, 2, 7, 27, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting" },
                values: new object[] { 1, 4L, 5, 2, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 9, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting" },
                values: new object[] { 1, 5L, 5, 29, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 13 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "Days", "EndDate" },
                values: new object[] { 3, 6L, 9, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting" },
                values: new object[] { 3, 7L, 3, 5, 17, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting" },
                values: new object[] { 3, 8L, 4, 6, 3, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting" },
                values: new object[] { 3, 9L, 4, 5, 5, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting" },
                values: new object[] { 3, 10L, 4, 4, 19, new DateTimeOffset(new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 10, 13 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size" },
                values: new object[] { new DateTime(2019, 9, 18, 8, 15, 11, 715, DateTimeKind.Unspecified).AddTicks(9996), "Aut et alias temporibus.\nRecusandae amet hic voluptas cumque sed quod blanditiis ipsam ut.\nAut distinctio occaecati labore dolorum rerum tempora.", 26, "https://gunnar.net", 5L, "ab", 37 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type" },
                values: new object[] { new DateTime(2020, 10, 5, 19, 52, 42, 706, DateTimeKind.Unspecified).AddTicks(364), "Tempora dolores magni saepe laborum.", 17, "http://myrl.org", 1L, "nobis", 57, 8L, 1 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId" },
                values: new object[] { new DateTime(2020, 1, 9, 19, 23, 11, 390, DateTimeKind.Unspecified).AddTicks(1671), "Atque temporibus hic necessitatibus et. Sed doloribus molestiae dolor repellat incidunt illo voluptates dignissimos. Sed esse eos. Voluptatem aut voluptatem dolores recusandae architecto.", 17, "https://tad.name", 3L, "eligendi", 38, 5L });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "TeamId" },
                values: new object[] { new DateTime(2020, 3, 24, 4, 41, 51, 273, DateTimeKind.Unspecified).AddTicks(543), "Hic harum omnis dignissimos.", 29, "http://shanny.biz", "facilis", 21, 2L });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type" },
                values: new object[] { new DateTime(2020, 7, 11, 0, 17, 31, 91, DateTimeKind.Unspecified).AddTicks(2720), "et", 16, "https://rodger.com", 3L, "cum", 29, 9L, 1 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "TeamId", "Type" },
                values: new object[] { new DateTime(2020, 12, 14, 2, 51, 55, 548, DateTimeKind.Unspecified).AddTicks(1388), "Excepturi voluptas totam nobis debitis consequatur in.", 18, "https://susie.com", "quis", 49, 6L, 2 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 11, 18, 50, 49, 725, DateTimeKind.Unspecified).AddTicks(9430), "Ratione quis iure beatae consequatur.", 25, "http://javonte.name", 3L, "id", 45, 10L });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type" },
                values: new object[] { new DateTime(2020, 6, 19, 3, 34, 7, 188, DateTimeKind.Unspecified).AddTicks(448), "Modi dignissimos consequatur pariatur suscipit excepturi consequuntur nulla et. Necessitatibus sunt molestiae et impedit iure velit tenetur. Harum molestiae itaque voluptatem voluptatem hic nobis repudiandae. Quia quo sunt sunt consequatur consequatur ut veritatis.", 28, "http://mathew.net", 3L, "ab", 51, 8L, 2 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 19, 0, 896, DateTimeKind.Unspecified).AddTicks(7596), "Quo sapiente blanditiis accusamus qui tempora nihil. Aut et corrupti architecto ut sit deserunt corrupti. Tempore nemo qui rerum. Nihil corporis voluptates eius aut. Dicta incidunt optio voluptatem natus error perspiciatis aperiam ab nihil.", 16, "https://gunner.name", 4L, "et", 25, 1L, 1 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "TeamId", "Type" },
                values: new object[] { new DateTime(2020, 12, 27, 23, 21, 29, 219, DateTimeKind.Unspecified).AddTicks(9342), "nemo", 27, "http://scot.info", "sapiente", 51, 4L, 2 });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2020, 9, 29, 16, 30, 36, 465, DateTimeKind.Unspecified).AddTicks(841), 6L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2020, 6, 8, 13, 18, 17, 380, DateTimeKind.Unspecified).AddTicks(3903), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 9L, new DateTime(2019, 10, 2, 21, 38, 44, 727, DateTimeKind.Unspecified).AddTicks(1936), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2020, 4, 21, 15, 33, 2, 210, DateTimeKind.Unspecified).AddTicks(8557), 7L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2021, 6, 7, 11, 50, 11, 915, DateTimeKind.Unspecified).AddTicks(3982), 6L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2019, 9, 5, 6, 29, 25, 979, DateTimeKind.Unspecified).AddTicks(4975), 5L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2020, 3, 27, 10, 53, 17, 224, DateTimeKind.Unspecified).AddTicks(777), 2L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2019, 11, 1, 20, 42, 4, 735, DateTimeKind.Unspecified).AddTicks(8268), 6L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 8, 12, 7, 26, 21, 94, DateTimeKind.Unspecified).AddTicks(9715), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2020, 2, 26, 16, 43, 12, 228, DateTimeKind.Unspecified).AddTicks(8010), 10L, 1L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(811), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(753), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(901), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(894), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(916), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(912), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(929), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(925), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(941), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(937), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(954), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(949), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(965), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(962), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(977), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(973), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(989), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(985), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 14, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(1000), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 13, 9, 35, 21, 830, DateTimeKind.Unspecified).AddTicks(997), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Flora_Watsica@yahoo.com", new DateTimeOffset(new DateTime(2023, 1, 28, 6, 51, 49, 998, DateTimeKind.Unspecified).AddTicks(530), new TimeSpan(0, 2, 0, 0, 0)), "Flora Watsica" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Mathew_Block28@gmail.com", new DateTimeOffset(new DateTime(2022, 11, 4, 0, 16, 18, 313, DateTimeKind.Unspecified).AddTicks(4138), new TimeSpan(0, 2, 0, 0, 0)), "Mathew Block" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Amanda_Yundt74@hotmail.com", new DateTimeOffset(new DateTime(2023, 4, 23, 21, 21, 42, 698, DateTimeKind.Unspecified).AddTicks(8279), new TimeSpan(0, 3, 0, 0, 0)), "Amanda Yundt" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Harold.Marks4@hotmail.com", new DateTimeOffset(new DateTime(2023, 8, 9, 21, 56, 50, 686, DateTimeKind.Unspecified).AddTicks(801), new TimeSpan(0, 3, 0, 0, 0)), "Harold Marks" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Maxine_Thompson7@hotmail.com", new DateTimeOffset(new DateTime(2023, 4, 26, 17, 31, 8, 897, DateTimeKind.Unspecified).AddTicks(5487), new TimeSpan(0, 3, 0, 0, 0)), "Maxine Thompson" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Diane_Wuckert84@gmail.com", new DateTimeOffset(new DateTime(2022, 11, 14, 10, 56, 13, 90, DateTimeKind.Unspecified).AddTicks(6822), new TimeSpan(0, 2, 0, 0, 0)), "Diane Wuckert" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Samuel.Hammes@hotmail.com", new DateTimeOffset(new DateTime(2022, 9, 21, 13, 33, 2, 909, DateTimeKind.Unspecified).AddTicks(2237), new TimeSpan(0, 3, 0, 0, 0)), "Samuel Hammes" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Pablo48@gmail.com", new DateTimeOffset(new DateTime(2022, 12, 4, 14, 54, 13, 433, DateTimeKind.Unspecified).AddTicks(5587), new TimeSpan(0, 2, 0, 0, 0)), "Pablo Gleason" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Wm.Legros60@yahoo.com", new DateTimeOffset(new DateTime(2023, 7, 6, 10, 28, 6, 53, DateTimeKind.Unspecified).AddTicks(942), new TimeSpan(0, 3, 0, 0, 0)), "Wm Legros" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Lynda99@gmail.com", new DateTimeOffset(new DateTime(2022, 9, 2, 1, 52, 49, 94, DateTimeKind.Unspecified).AddTicks(6124), new TimeSpan(0, 3, 0, 0, 0)), "Lynda Olson" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2020, 9, 9, 12, 53, 43, 928, DateTimeKind.Unspecified).AddTicks(7231), "Eos ut est recusandae voluptatem voluptatem delect", 17, 3L, "fuga", new DateTimeOffset(new DateTime(2023, 5, 18, 9, 55, 54, 85, DateTimeKind.Unspecified).AddTicks(6111), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2019, 8, 30, 6, 33, 28, 391, DateTimeKind.Unspecified).AddTicks(2441), 4L, "Sunt sunt molestiae expedita.", 52, 4L, "in", new DateTimeOffset(new DateTime(2023, 7, 17, 5, 34, 23, 712, DateTimeKind.Unspecified).AddTicks(3215), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2019, 10, 12, 6, 39, 34, 399, DateTimeKind.Unspecified).AddTicks(39), 2L, "Minus fugiat perferendis asperiores qui et et inve", 36, 3L, "corporis", new DateTimeOffset(new DateTime(2022, 9, 9, 8, 55, 28, 154, DateTimeKind.Unspecified).AddTicks(7126), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 29, 20, 53, 45, 456, DateTimeKind.Unspecified).AddTicks(6612), 7L, "Aperiam deleniti tenetur voluptas numquam accusant", 21, 5L, "amet", new DateTimeOffset(new DateTime(2023, 6, 30, 5, 51, 43, 77, DateTimeKind.Unspecified).AddTicks(5657), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 8, 13, 8, 29, 56, 178, DateTimeKind.Unspecified).AddTicks(7858), 1L, "Possimus nemo amet. Nulla eaque expedita ea maxime", 49, 4L, "facere", new DateTimeOffset(new DateTime(2023, 1, 22, 1, 32, 42, 689, DateTimeKind.Unspecified).AddTicks(6810), new TimeSpan(0, 2, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 11, 22, 23, 26, 43, 357, DateTimeKind.Unspecified).AddTicks(413), 2L, "Nostrum labore praesentium eaque nihil.\nMaiores qu", 44, 5L, "molestiae", new DateTimeOffset(new DateTime(2023, 7, 21, 0, 42, 30, 161, DateTimeKind.Unspecified).AddTicks(8515), new TimeSpan(0, 3, 0, 0, 0)), 7L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 11, 4, 20, 17, 48, 120, DateTimeKind.Unspecified).AddTicks(3348), 6L, "eos", 38, 1L, "perspiciatis", new DateTimeOffset(new DateTime(2023, 6, 10, 16, 43, 18, 78, DateTimeKind.Unspecified).AddTicks(2106), new TimeSpan(0, 3, 0, 0, 0)), 7L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 8, 20, 16, 26, 49, 661, DateTimeKind.Unspecified).AddTicks(3068), 1L, "Enim debitis molestiae sit quos laudantium ut eos", 49, 3L, "voluptatem", new DateTimeOffset(new DateTime(2023, 5, 20, 9, 15, 11, 404, DateTimeKind.Unspecified).AddTicks(2360), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2020, 6, 30, 22, 18, 8, 62, DateTimeKind.Unspecified).AddTicks(4593), "accusamus", 54, 4L, "culpa", new DateTimeOffset(new DateTime(2023, 6, 12, 10, 48, 38, 989, DateTimeKind.Unspecified).AddTicks(9785), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 8, 5, 13, 22, 36, 524, DateTimeKind.Unspecified).AddTicks(6653), 5L, "Sit eius cum cupiditate in. Recusandae ut velit ut", 16, 5L, "sunt", new DateTimeOffset(new DateTime(2023, 3, 2, 14, 0, 37, 344, DateTimeKind.Unspecified).AddTicks(7615), new TimeSpan(0, 2, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Excepturi ab et ipsa sit omnis quo aliquid nostrum deserunt. Quis repudiandae libero. Quos ea quae rem sed." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Quia commodi necessitatibus a mollitia quia eum.\nPerferendis sed ea corporis.\nSuscipit est eum in rem excepturi quia hic aut.\nAutem aliquam quidem neque." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Veritatis id ipsa esse aut harum. Maxime quia distinctio ducimus hic magnam dolore illo quod nemo. Neque omnis vero qui quo. Voluptas hic laboriosam. Non quo laudantium provident rerum voluptatem. Quia et odio ut quis corporis rerum aliquam a placeat." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Neque deserunt dolores error laudantium.\nQuia iusto commodi ad a provident repudiandae ut modi inventore.\nQui optio dolor ab ut.\nVoluptas ratione vero nulla nobis asperiores a." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Laborum impedit veniam dicta.\nMolestiae et quasi corporis iure impedit." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "eumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Ex quia ab et repudiandae. Iusto blanditiis reprehenderit assumenda provident temporibus et mollitia. Est qui laborum velit quaerat ducimus." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Aut temporibus quae.\nEst fugiat voluptatem earum ut voluptates error dicta voluptate minima.\nDistinctio voluptatem non dolores tempora illo qui eos voluptatem.\nMaiores accusantium saepe magni suscipit ipsa.\nQuasi fugit est ut est totam." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Totam ipsam quisquam atque eius. Dolore maiores minima dolorem qui. Sint recusandae dignissimos nesciunt. Qui quia iste. Qui et et voluptas numquam sint sit ad dolores voluptatibus." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Atque et minus. Iusto et possimus iusto qui. Eius numquam reiciendis reiciendis ipsum nesciunt." });

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
                value: 4);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Priority",
                value: 2);

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
                value: 9);

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
                value: 2);

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
                column: "Status",
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
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

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
                column: "Role",
                value: 2);

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "eos", "Beatty - Feeney", "http://cecil.name", "America/C" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "rerum", "Oberbrunner, Orn and Beier", "https://ricardo.org", "Asia/Vlad" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "At minima delectus dolor rerum tenetur.\nQuae quae modi est cum ut.", "Mertz, Macejkovic and Schultz", "https://kiley.com", "Asia/Kolk" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "illum", "Conroy Group", "https://opal.name", "Asia/Maga" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Aut sit dolores.", "Stoltenberg, Zemlak and Friesen", "https://paige.name" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "At vitae dolore aut sint beatae vel dolore. Dicta quae voluptatem dolore. Velit sunt autem.", "Hickle - Lehner", "http://kody.biz", "Pacific/H" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Asperiores aspernatur cupiditate necessitatibus beatae. Explicabo et consequatur molestiae. Fugiat et aperiam in eos. Qui quisquam eaque deserunt qui ut. Ipsam delectus architecto eum dolor. Ad eveniet temporibus officiis unde cum.", "Wehner - Osinski", "https://octavia.name", "Europe/Lo" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Aut aut sapiente in aut doloribus ut exercitationem ratione. Iure quisquam provident. Ut id aliquid et in. Sed impedit quos minima odit.", "Mayert Group", "http://keyon.info", "Europe/He" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "qui", "Harvey - Fisher", "https://moriah.org", "Asia/Vlad" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Ipsa ea non nesciunt accusantium qui.\nEt at accusamus voluptas magnam quibusdam nihil.\nCumque perferendis quae autem harum nesciunt et.\nFugit quos ex.\nIn ipsa omnis ea consectetur.\nQuis quaerat libero voluptas ipsam porro consequatur optio neque.", "Zboncak - Daniel", "http://sophia.biz", "Europe/Be" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Jaime2@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/542.jpg", "Jaime Kiehn", "428.929.25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Arthur0@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1030.jpg", "Arthur Thompson", "1-822-417-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Dwayne_Ankunding@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/247.jpg", "Dwayne Ankunding", "(488) 447-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Robin.Marks9@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1148.jpg", "Robin Marks", "(636) 314-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Lila_Beatty@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/998.jpg", "Lila Beatty", "591.782.07" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Sam.DAmore@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/957.jpg", "Sam D'Amore", "490.464.46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Billie.West@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/539.jpg", "Billie West", "486.967.80" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Violet_Mosciski44@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/447.jpg", "Violet Mosciski", "940-466-18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Matt49@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/49.jpg", "Matt Funk", "1-309-236-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Melvin.Pagac86@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1219.jpg", "Melvin Pagac", "(617) 278-" });

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedSlotSettings_AvailabilitySlotId",
                table: "AdvancedSlotSettings",
                column: "AvailabilitySlotId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedSlotSettings_AvailabilitySlots_AvailabilitySlotId",
                table: "AdvancedSlotSettings",
                column: "AvailabilitySlotId",
                principalTable: "AvailabilitySlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
