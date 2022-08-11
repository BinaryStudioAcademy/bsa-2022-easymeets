using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class ChangeAvailabilitySlotAndSettings : Migration
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
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 7, 9, 5, 5, 2, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "StartDate" },
                values: new object[] { 1, 5, 30, 3, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 5, 24, 1, 3, 11, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "StartDate" },
                values: new object[] { 5, 14, 4, 2, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Days", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 26, 5, 11, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 12, 2, 6, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 3, 12, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 8, 9, 3, 5, 6, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 4, 27, 7, 1, 4, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 7, 12, 3, 4, 9, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TeamId", "TimeZoneVisibility", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 2, new DateTime(2020, 11, 20, 7, 43, 1, 890, DateTimeKind.Unspecified).AddTicks(2149), 17, "Ukrainian", "http://lennie.com", 5L, "ducimus", 60, 2L, true, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "aut" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "TeamId", "TimeZoneVisibility", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 2, new DateTime(2019, 10, 6, 8, 40, 57, 431, DateTimeKind.Unspecified).AddTicks(2932), 29, "Ukrainian", "https://major.com", 2L, "voluptas", 1L, true, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Quasi saepe necessitatibus. Veniam necessitatibus aut. Delectus asperiores impedit molestias in ea. Explicabo sint quo. Nulla rerum amet occaecati ut maiores. Quis est ut iusto voluptatibus sit delectus natus dolorem odit." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TimeZoneVisibility", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 1, new DateTime(2021, 3, 19, 13, 33, 15, 117, DateTimeKind.Unspecified).AddTicks(5135), 18, "Ukrainian", "https://keanu.org", 3L, "sit", 40, true, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Delectus aspernatur sed doloribus ipsam ut." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Language", "Link", "Name", "Size", "TeamId", "TimeZoneVisibility", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 2, new DateTime(2020, 2, 3, 3, 36, 48, 695, DateTimeKind.Unspecified).AddTicks(3687), "Ukrainian", "http://emma.net", "alias", 28, 2L, true, 1, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Quia id dolores et magni. Non esse magni velit cupiditate consectetur quis ipsa. Eos similique voluptate excepturi cumque natus in consectetur dolore est. Harum qui quidem nesciunt. Non voluptatem neque. Sit aut quasi id aut sunt quasi." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "Name", "Size", "TeamId", "TimeZoneVisibility", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 2, new DateTime(2019, 9, 6, 1, 0, 5, 16, DateTimeKind.Unspecified).AddTicks(4870), 17, "Ukrainian", "https://caterina.net", "cupiditate", 28, 8L, true, 1, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Ut enim laborum reiciendis at quasi aliquam ex dolorem. Quos qui assumenda et est odit. Consequatur magnam sunt dolores vel qui. Ut enim animi cum officia commodi sint. Voluptas nostrum cumque aut et tempore tempore natus facere." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TeamId", "TimeZoneVisibility", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 2, new DateTime(2021, 5, 23, 13, 1, 41, 613, DateTimeKind.Unspecified).AddTicks(9550), 27, "Ukrainian", "http://adell.net", 5L, "laboriosam", 48, 1L, true, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "deserunt" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TeamId", "TimeZoneVisibility", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 2, new DateTime(2019, 9, 15, 2, 32, 29, 119, DateTimeKind.Unspecified).AddTicks(6227), 28, "Ukrainian", "http://adalberto.biz", 5L, "voluptas", 37, 6L, true, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Cum numquam quos et voluptatem sequi a amet distinctio esse." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TeamId", "TimeZoneVisibility", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 1, new DateTime(2020, 11, 12, 3, 6, 48, 665, DateTimeKind.Unspecified).AddTicks(9787), 26, "Ukrainian", "https://hillary.net", 3L, "consectetur", 56, 4L, true, 1, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Tempore qui harum quia labore dolorum.\nDebitis et natus facere error quos ducimus fugiat eveniet.\nUllam ut est ipsam aut doloremque qui.\nEt ratione necessitatibus quo sit est fuga quia quis excepturi.\nNecessitatibus in eum molestias sit minima.\nQuibusdam autem voluptatem vel et at et est qui." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "Name", "Size", "TimeZoneVisibility", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 3, new DateTime(2020, 5, 3, 18, 21, 0, 358, DateTimeKind.Unspecified).AddTicks(1416), 22, "Ukrainian", "https://elias.name", "id", 51, true, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Dolor beatae a quod pariatur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TeamId", "TimeZoneVisibility", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 2, new DateTime(2021, 3, 16, 8, 16, 49, 858, DateTimeKind.Unspecified).AddTicks(9796), 21, "Ukrainian", "https://joanne.com", 5L, "neque", 15, 4L, true, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "at" });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2019, 7, 29, 3, 6, 45, 489, DateTimeKind.Unspecified).AddTicks(26), 7L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2020, 4, 2, 19, 18, 45, 882, DateTimeKind.Unspecified).AddTicks(9516), 1L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2019, 7, 20, 2, 22, 37, 953, DateTimeKind.Unspecified).AddTicks(8676), 10L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2019, 12, 28, 14, 22, 55, 220, DateTimeKind.Unspecified).AddTicks(2912), new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { 9L, new DateTime(2019, 7, 25, 9, 30, 1, 370, DateTimeKind.Unspecified).AddTicks(3928), 8L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2019, 12, 13, 19, 8, 7, 755, DateTimeKind.Unspecified).AddTicks(3944), 9L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 6, 19, 12, 8, 24, 269, DateTimeKind.Unspecified).AddTicks(4552), 8L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2020, 8, 10, 10, 11, 27, 730, DateTimeKind.Unspecified).AddTicks(4297), 6L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 7, 25, 20, 31, 44, 428, DateTimeKind.Unspecified).AddTicks(5318), 2L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { 6L, new DateTime(2019, 10, 5, 5, 18, 11, 465, DateTimeKind.Unspecified).AddTicks(3922), 7L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(513), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(379), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(715), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 12, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(698), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(740), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 12, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(733), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(825), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(755), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(858), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(850), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(880), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(873), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(901), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(894), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(922), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(915), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(943), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 12, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(936), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(964), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 12, 22, 51, 55, 235, DateTimeKind.Unspecified).AddTicks(957), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Carroll_Pouros5@yahoo.comAAAAA", new DateTimeOffset(new DateTime(2023, 5, 15, 2, 20, 14, 753, DateTimeKind.Unspecified).AddTicks(3868), new TimeSpan(0, 3, 0, 0, 0)), "Carroll Pouros" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Connie44@yahoo.comAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2022, 12, 2, 3, 0, 14, 246, DateTimeKind.Unspecified).AddTicks(2219), new TimeSpan(0, 2, 0, 0, 0)), "Connie Stoltenberg" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Janis_Legros23@hotmail.comAAAA", new DateTimeOffset(new DateTime(2022, 11, 6, 19, 55, 44, 688, DateTimeKind.Unspecified).AddTicks(593), new TimeSpan(0, 2, 0, 0, 0)), "Janis Legros" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Russell.Kunze@hotmail.comAAAAA", new DateTimeOffset(new DateTime(2022, 10, 16, 18, 30, 11, 665, DateTimeKind.Unspecified).AddTicks(1088), new TimeSpan(0, 3, 0, 0, 0)), "Russell Kunze" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Tabitha_Reynolds44@yahoo.comAA", new DateTimeOffset(new DateTime(2022, 10, 23, 19, 46, 55, 164, DateTimeKind.Unspecified).AddTicks(209), new TimeSpan(0, 3, 0, 0, 0)), "Tabitha Reynolds" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Edwin87@yahoo.comAAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 2, 12, 13, 13, 3, 858, DateTimeKind.Unspecified).AddTicks(6556), new TimeSpan(0, 2, 0, 0, 0)), "Edwin Hyatt" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Marjorie80@yahoo.comAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 1, 14, 16, 4, 24, 489, DateTimeKind.Unspecified).AddTicks(8956), new TimeSpan(0, 2, 0, 0, 0)), "Marjorie Effertz" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Norman_McGlynn76@yahoo.comAAAA", new DateTimeOffset(new DateTime(2023, 5, 11, 0, 2, 6, 239, DateTimeKind.Unspecified).AddTicks(9627), new TimeSpan(0, 3, 0, 0, 0)), "Norman McGlynn" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "June_Kovacek@yahoo.comAAAAAAAA", new DateTimeOffset(new DateTime(2023, 6, 17, 5, 19, 12, 82, DateTimeKind.Unspecified).AddTicks(1860), new TimeSpan(0, 3, 0, 0, 0)), "June Kovacek" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Kim_Ruecker18@hotmail.comAAAAA", new DateTimeOffset(new DateTime(2023, 7, 18, 16, 6, 19, 682, DateTimeKind.Unspecified).AddTicks(74), new TimeSpan(0, 3, 0, 0, 0)), "Kim Ruecker" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 2, 1, 2, 55, 37, 421, DateTimeKind.Unspecified).AddTicks(2625), 5L, "quaerat", 18, 4L, "aliquid", new DateTimeOffset(new DateTime(2022, 8, 22, 11, 47, 4, 481, DateTimeKind.Unspecified).AddTicks(1292), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 11, 14, 12, 17, 54, 90, DateTimeKind.Unspecified).AddTicks(9599), 7L, "Dolore doloribus fuga hic consequatur aut ipsum co", 38, 5L, "porro", new DateTimeOffset(new DateTime(2023, 6, 21, 10, 25, 58, 446, DateTimeKind.Unspecified).AddTicks(890), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 9, 1, 13, 45, 1, 493, DateTimeKind.Unspecified).AddTicks(3026), 1L, "dolore", 16, "quo", new DateTimeOffset(new DateTime(2023, 3, 20, 11, 49, 33, 373, DateTimeKind.Unspecified).AddTicks(6737), new TimeSpan(0, 2, 0, 0, 0)), 7L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 3, 20, 16, 5, 28, 406, DateTimeKind.Unspecified).AddTicks(8592), "quisquam", 21, 4L, "aut", new DateTimeOffset(new DateTime(2023, 2, 7, 20, 25, 32, 148, DateTimeKind.Unspecified).AddTicks(7355), new TimeSpan(0, 2, 0, 0, 0)), 9L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 11, 5, 13, 8, 20, 157, DateTimeKind.Unspecified).AddTicks(1240), 4L, "Eligendi quasi sed quod facere esse. Aut sit ab be", 54, 2L, "atque", new DateTimeOffset(new DateTime(2022, 10, 14, 7, 15, 29, 604, DateTimeKind.Unspecified).AddTicks(7101), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 19, 19, 9, 31, 696, DateTimeKind.Unspecified).AddTicks(1750), 2L, "aut", 59, 5L, "dolor", new DateTimeOffset(new DateTime(2023, 4, 20, 8, 36, 30, 495, DateTimeKind.Unspecified).AddTicks(8325), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 9, 18, 19, 31, 27, 79, DateTimeKind.Unspecified).AddTicks(5586), "nostrum", 59, "harum", new DateTimeOffset(new DateTime(2023, 4, 24, 16, 33, 36, 17, DateTimeKind.Unspecified).AddTicks(2699), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 2, 23, 16, 57, 52, 713, DateTimeKind.Unspecified).AddTicks(2568), 5L, "quas", 50, 1L, "error", new DateTimeOffset(new DateTime(2023, 3, 1, 9, 13, 15, 416, DateTimeKind.Unspecified).AddTicks(7127), new TimeSpan(0, 2, 0, 0, 0)), 8L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 9, 19, 29, 7, 941, DateTimeKind.Unspecified).AddTicks(8383), 5L, "Commodi illo nostrum. Qui recusandae molestiae et", 14, 3L, "aliquam", new DateTimeOffset(new DateTime(2023, 2, 1, 15, 10, 19, 900, DateTimeKind.Unspecified).AddTicks(1503), new TimeSpan(0, 2, 0, 0, 0)), 7L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 19, 9, 14, 49, 868, DateTimeKind.Unspecified).AddTicks(4849), 8L, "aut", 17, new DateTimeOffset(new DateTime(2023, 8, 6, 3, 14, 32, 748, DateTimeKind.Unspecified).AddTicks(7658), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "laborumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Natus dicta quo. Provident quos quasi voluptatem nobis voluptatibus qui nesciunt. Quas incidunt sed nihil non sit accusantium qui. Dolor quis qui tempora." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Quisquam sit ducimus.AAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "facilisAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Et esse et est asperiores modi perspiciatis accusantium molestiae ea.\nQui accusantium eveniet nostrum quos doloribus ipsum.\nVel corporis nihil." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "temporeAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Harum vero placeat sunt dolorem deserunt facilis similique quidem quia.\nFuga a suscipit asperiores." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Voluptatem totam nam consequatur. Voluptates iusto non laboriosam aperiam. Voluptas sunt ut et esse impedit. Temporibus soluta laudantium ut odio quia architecto reprehenderit earum. Sint tempore et incidunt et alias nam magnam." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Dolor dolor iure adipisci dolorem quia at accusantium." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Vel voluptatem unde quas soluta.\nIste sequi in dignissimos nemo a.\nRerum est ea perspiciatis modi unde sed eligendi est et." });

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Priority",
                value: 2);

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
                value: 5);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Priority",
                value: 6);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Priority",
                value: 1);

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

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
                keyValue: 6L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

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
                column: "Status",
                value: 1);

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
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Deleniti rerum vero voluptatem libero sed. Aut et qui maxime quaerat facilis molestiae earum qui. Et iure amet voluptatem sit impedit deleniti eligendi numquam eaque. Quo reiciendis ad aperiam eum sunt porro. Sunt reiciendis molestiae nam occaecati fugiat debitis autem qui. Fuga nam sunt.", "Kihn - Corwin", "https://raegan.net", "America/B" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "At aut ipsam quo repudiandae doloremque tempora. Fugit ut ut. Fugit ipsum fugiat non incidunt tempore accusantium qui tenetur. Architecto mollitia autem explicabo commodi.", "Robel LLC", "https://clementine.info", "Europe/Ro" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Illo eum delectus aut vitae.", "Olson, Mante and Hodkiewicz", "https://keeley.com", "America/L" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Ipsa iure aut nostrum nihil laudantium.", "Crooks, Yundt and Herman", "http://avis.org", "Europe/Za" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "aut", "Hayes Group", "http://maiya.name", "America/S" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Nihil maiores cupiditate sunt. Optio in nam neque inventore pariatur ab minima. Aut distinctio laudantium repellat. Reiciendis dolor est illo ea quaerat quidem quos tempore aspernatur. Facilis consequuntur quibusdam placeat quas.", "Stokes and Sons", "http://cicero.info", "Asia/Dhak" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Voluptates suscipit aut earum quasi sit rerum tempora.", "Heidenreich Inc", "http://alaina.name", "Australia" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quidem quas nemo praesentium rerum aliquam eius omnis id ea.", "Monahan - Will", "https://oma.name", "Europe/Br" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Necessitatibus aut harum ducimus.", "Larson and Sons", "https://lyda.org", "Europe/Ki" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quasi voluptates omnis voluptas voluptatem. Sed dolorem ut voluptatem voluptatem quia maiores eligendi. Iure ut dolorum nesciunt distinctio voluptatem ea adipisci voluptas omnis. Architecto rem alias esse quo autem tenetur distinctio non. Aliquam asperiores delectus consequatur ullam rerum maxime.", "McKenzie Inc", "http://katelin.info", "Europe/Vi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Johnathan.DuBuque@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1.jpg", "Johnathan DuBuque", "1-713-449-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Beulah_Williamson76@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1206.jpg", "Beulah Williamson", "(889) 423-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Merle_Casper@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/999.jpg", "Merle Casper", "(876) 416-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Melinda99@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1004.jpg", "Melinda Smitham", "534.583.07" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Charlene22@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/38.jpg", "Charlene Stracke", "473.544.72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Abel.Maggio@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/402.jpg", "Abel Maggio", "690-430-14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Beverly.Hand43@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/325.jpg", "Beverly Hand", "252.674.57" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Lucy_OHara80@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/638.jpg", "Lucy O'Hara", "1-673-374-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Heidi27@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/55.jpg", "Heidi Rempel", "760-963-90" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Rita70@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/183.jpg", "Rita Kassulke", "457-303-71" });

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
                columns: new[] { "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 1L, 2, 5, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 3, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "Color", "Days", "EndDate", "MaxNumberOfBookings", "StartDate" },
                values: new object[] { 3, 2L, 2, 26, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 9, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 2, 3L, 1, 4, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 2, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "StartDate" },
                values: new object[] { 4L, 1, 1, 20, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 9, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Days", "EndDate", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 1, 5L, 4, 11, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 6L, 5, 6, 8, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 7L, 12, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 7, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 1, 8L, 1, 6, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 9, 8, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 1, 9L, 3, 3, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 8, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 2, 10L, 3, 5, 30, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 11, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 26, 5, 27, 18, 157, DateTimeKind.Unspecified).AddTicks(5561), "Error illo debitis ad.", 24, "https://keanu.net", 2L, "quidem", 45, 5L, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 9, 28, 1, 32, 23, 12, DateTimeKind.Unspecified).AddTicks(816), "Recusandae quo quis voluptatem porro sed aut non. Recusandae recusandae minus et qui ea asperiores laborum assumenda. Architecto eum quam cumque atque facilis sequi eveniet et.", 30, "http://leslie.name", 1L, "harum", 4L, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 11, 30, 1, 19, 20, 330, DateTimeKind.Unspecified).AddTicks(9269), "Et optio dolores eos. Provident nobis omnis porro ipsam. Atque deleniti officiis et consectetur consequuntur.", 24, "https://fredy.name", 2L, "beatae", 41, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Description", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 1, 22, 11, 4, 409, DateTimeKind.Unspecified).AddTicks(8771), "Rerum cupiditate eos eligendi sunt laboriosam consectetur non.\nQuas et omnis quia et autem consectetur dolore modi fugiat.\nNatus pariatur voluptatem corporis repellendus ut esse rem quo omnis.\nCorporis ea non officiis molestiae doloribus.", "http://liam.name", "quis", 42, 1L, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 2, 25, 2, 10, 57, 920, DateTimeKind.Unspecified).AddTicks(8269), "Similique est exercitationem maxime quidem dignissimos sed animi ex.", 18, "https://lewis.name", "nesciunt", 26, 1L, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 31, 17, 59, 39, 329, DateTimeKind.Unspecified).AddTicks(1926), "Non tempore rem impedit sint enim sed. Praesentium et quia blanditiis repellendus omnis iure vitae numquam eos. Ut voluptas maiores magnam cumque et consequatur eveniet. Doloribus sit blanditiis aspernatur perferendis ut consequatur.", 19, "https://kamron.org", 1L, "illum", 45, 4L, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 17, 7, 10, 24, 17, DateTimeKind.Unspecified).AddTicks(7483), "Nostrum et fugiat consequatur qui.", 21, "https://willis.name", 3L, "voluptatem", 49, 4L, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 6, 21, 17, 2, 453, DateTimeKind.Unspecified).AddTicks(5646), "Sapiente nemo dolor natus voluptatem sed. Iusto sint omnis est. Dolor ut dolores.", 20, "http://dangelo.biz", 4L, "esse", 20, 9L, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 3, 1, 39, 366, DateTimeKind.Unspecified).AddTicks(7434), "Rerum magni quisquam nemo nostrum alias. Eum tempora velit sed est quo hic et incidunt magnam. Et deleniti non tenetur aut voluptas qui quisquam.", 15, "http://nathanael.net", "consequatur", 26, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 24, 14, 14, 2, 827, DateTimeKind.Unspecified).AddTicks(8613), "Minus nemo aut vel minus corrupti est porro pariatur.\nAdipisci aut similique nesciunt optio necessitatibus magni sed mollitia suscipit.\nMolestiae ut aut nemo excepturi.\nMinus harum ex nostrum eum minima omnis est voluptas dolor.\nNeque officia perferendis.\nAccusamus cupiditate dolorem.", 19, "https://maurice.biz", 3L, "delectus", 23, 9L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2020, 8, 23, 11, 46, 20, 777, DateTimeKind.Unspecified).AddTicks(5827), 8L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 1, 15, 0, 4, 3, 195, DateTimeKind.Unspecified).AddTicks(7388), 7L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 4, 27, 16, 33, 11, 97, DateTimeKind.Unspecified).AddTicks(4093), 6L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 12, 4, 5, 48, 35, 934, DateTimeKind.Unspecified).AddTicks(3481), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { 6L, new DateTime(2020, 12, 9, 20, 28, 38, 929, DateTimeKind.Unspecified).AddTicks(1135), 6L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 7, 5, 4, 14, 22, 105, DateTimeKind.Unspecified).AddTicks(486), 5L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2021, 3, 27, 21, 55, 40, 731, DateTimeKind.Unspecified).AddTicks(8064), 5L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 6, 28, 23, 11, 11, 146, DateTimeKind.Unspecified).AddTicks(5668), 5L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2020, 3, 13, 14, 26, 21, 980, DateTimeKind.Unspecified).AddTicks(4243), 10L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { 10L, new DateTime(2021, 2, 13, 11, 44, 28, 980, DateTimeKind.Unspecified).AddTicks(850), 6L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7034), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(6927), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7239), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7226), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7254), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7279), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7273), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7298), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7292), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7372), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7311), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7419), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7413), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7438), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7432), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7456), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7450), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Valerie.Trantow@gmail.com", new DateTimeOffset(new DateTime(2022, 8, 21, 8, 14, 35, 544, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 3, 0, 0, 0)), "Valerie Trantow" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Amber2@gmail.com", new DateTimeOffset(new DateTime(2023, 4, 7, 9, 31, 32, 216, DateTimeKind.Unspecified).AddTicks(1755), new TimeSpan(0, 3, 0, 0, 0)), "Amber Senger" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Ian78@gmail.com", new DateTimeOffset(new DateTime(2022, 12, 30, 22, 46, 6, 995, DateTimeKind.Unspecified).AddTicks(9603), new TimeSpan(0, 2, 0, 0, 0)), "Ian Schuster" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Jason_Mills7@gmail.com", new DateTimeOffset(new DateTime(2022, 11, 8, 3, 28, 11, 516, DateTimeKind.Unspecified).AddTicks(6946), new TimeSpan(0, 2, 0, 0, 0)), "Jason Mills" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Vanessa_Goyette@hotmail.com", new DateTimeOffset(new DateTime(2023, 6, 26, 19, 35, 52, 558, DateTimeKind.Unspecified).AddTicks(3673), new TimeSpan(0, 3, 0, 0, 0)), "Vanessa Goyette" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Erica87@yahoo.com", new DateTimeOffset(new DateTime(2022, 12, 27, 8, 5, 13, 34, DateTimeKind.Unspecified).AddTicks(2966), new TimeSpan(0, 2, 0, 0, 0)), "Erica Marquardt" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Johnnie.Moen@hotmail.com", new DateTimeOffset(new DateTime(2022, 10, 15, 21, 48, 5, 802, DateTimeKind.Unspecified).AddTicks(3493), new TimeSpan(0, 3, 0, 0, 0)), "Johnnie Moen" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Enrique.Toy@gmail.com", new DateTimeOffset(new DateTime(2023, 2, 7, 20, 51, 0, 184, DateTimeKind.Unspecified).AddTicks(3198), new TimeSpan(0, 2, 0, 0, 0)), "Enrique Toy" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Wendy74@gmail.com", new DateTimeOffset(new DateTime(2023, 8, 8, 23, 49, 13, 375, DateTimeKind.Unspecified).AddTicks(8122), new TimeSpan(0, 3, 0, 0, 0)), "Wendy Lowe" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Chad.Bednar56@yahoo.com", new DateTimeOffset(new DateTime(2022, 10, 21, 16, 43, 57, 702, DateTimeKind.Unspecified).AddTicks(3057), new TimeSpan(0, 3, 0, 0, 0)), "Chad Bednar" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 12, 13, 19, 46, 11, 190, DateTimeKind.Unspecified).AddTicks(7247), 6L, "Odit reiciendis nisi possimus repudiandae inventor", 25, 2L, "ipsa", new DateTimeOffset(new DateTime(2022, 9, 22, 16, 31, 9, 6, DateTimeKind.Unspecified).AddTicks(1920), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 11, 13, 9, 35, 44, 572, DateTimeKind.Unspecified).AddTicks(3426), 8L, "Cum enim dolore. Alias aut ab ut enim ipsam ducimu", 44, 1L, "id", new DateTimeOffset(new DateTime(2023, 7, 18, 8, 51, 11, 39, DateTimeKind.Unspecified).AddTicks(5906), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 5, 18, 23, 19, 420, DateTimeKind.Unspecified).AddTicks(7301), 4L, "Fuga aliquid cupiditate nisi similique. Cupiditate", 50, "et", new DateTimeOffset(new DateTime(2022, 11, 4, 1, 55, 10, 764, DateTimeKind.Unspecified).AddTicks(2636), new TimeSpan(0, 2, 0, 0, 0)), 3L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 11, 22, 19, 5, 9, 840, DateTimeKind.Unspecified).AddTicks(6975), "Asperiores omnis dicta distinctio non ex est.", 18, 3L, "vel", new DateTimeOffset(new DateTime(2023, 4, 20, 20, 34, 39, 697, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 2, 8, 22, 8, 2, 324, DateTimeKind.Unspecified).AddTicks(6597), 3L, "Molestiae nostrum temporibus fugiat placeat libero", 13, 4L, "inventore", new DateTimeOffset(new DateTime(2023, 4, 11, 0, 42, 23, 833, DateTimeKind.Unspecified).AddTicks(1883), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 5, 18, 13, 10, 719, DateTimeKind.Unspecified).AddTicks(55), 1L, "Voluptatum molestias quia minima quisquam vero vel", 30, 3L, "animi", new DateTimeOffset(new DateTime(2022, 11, 13, 21, 28, 49, 587, DateTimeKind.Unspecified).AddTicks(2033), new TimeSpan(0, 2, 0, 0, 0)), 7L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 10, 9, 10, 14, 27, 974, DateTimeKind.Unspecified).AddTicks(7923), "consequatur", 19, "at", new DateTimeOffset(new DateTime(2023, 4, 7, 16, 13, 54, 47, DateTimeKind.Unspecified).AddTicks(3911), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 12, 23, 29, 12, 644, DateTimeKind.Unspecified).AddTicks(2012), 9L, "Eos quod amet sed in vero. Saepe dolorum natus sed", 21, 4L, "quo", new DateTimeOffset(new DateTime(2023, 4, 1, 2, 9, 59, 784, DateTimeKind.Unspecified).AddTicks(2721), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 12, 4, 11, 0, 561, DateTimeKind.Unspecified).AddTicks(1866), 3L, "nihil", 44, 2L, "omnis", new DateTimeOffset(new DateTime(2022, 12, 29, 14, 50, 29, 995, DateTimeKind.Unspecified).AddTicks(3372), new TimeSpan(0, 2, 0, 0, 0)), 5L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 3, 17, 11, 24, 18, 404, DateTimeKind.Unspecified).AddTicks(497), 5L, "Doloremque laudantium aspernatur et eligendi dolor", 55, new DateTimeOffset(new DateTime(2023, 5, 6, 9, 24, 4, 350, DateTimeKind.Unspecified).AddTicks(1932), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Et natus iste repellat velit ratione quis.AAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Eos labore sint autem maiores. Sunt rerum omnis cumque harum ab voluptas. Non ullam fugit expedita tenetur." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Ipsam pariatur labore eius tempore repellat unde.\nPariatur aspernatur eos voluptatem possimus.\nDolorem nisi sunt nulla." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "ducimusAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Perferendis beatae quia officiis.AAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Tempora voluptatem praesentium nisi dicta quasi.\nNon aut accusantium corrupti praesentium alias nemo soluta aut et.\nMinima nulla vero maiores impedit est sunt voluptatum consequuntur.\nQuidem eaque et dolore.\nEum consectetur ipsum cumque voluptatem et deleniti labore sit iure." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Et veniam consequuntur atque.\nEos maxime harum est nihil exercitationem ducimus quia veniam quae.\nEum incidunt eius sint.\nSit perspiciatis iste nobis accusamus.\nVoluptas dolores consequatur aliquid quo soluta est omnis.\nLaudantium sapiente porro dolores placeat molestiae atque quibusdam rerum." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Quia iusto dolor ut.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Molestiae minus ullam nemo. Sint reprehenderit incidunt et natus in nihil sint dolore laboriosam. Amet dolor debitis maxime ipsam corporis aut." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Assumenda molestiae laudantium reprehenderit ea.AA" });

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
                value: 8);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Priority",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Priority",
                value: 10);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 6L,
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
                value: 10);

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

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
                keyValue: 6L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

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
                column: "Status",
                value: 2);

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
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Libero qui necessitatibus natus asperiores et incidunt ea optio sit.", "Mills - Nader", "http://jettie.org", "Europe/So" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Commodi voluptatum officiis repellat atque sunt. Omnis doloremque fuga provident ullam. Aspernatur qui magnam sit dolores aliquid quae dolore dicta. Corrupti alias maxime cupiditate aliquam tempora accusamus. Est et ex harum hic ipsam quia at ab maxime. Sint laborum repellat rem perspiciatis tempor", "Grady - Wilkinson", "https://jacquelyn.com", "Asia/Kual" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Nemo sapiente odio ipsa.\nIllum reprehenderit autem ab quam consectetur omnis.", "Klocko - Wintheiser", "https://leta.info", "Asia/Toky" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Voluptatibus exercitationem voluptas. Ut consequatur qui sequi sit adipisci. Iusto repellat alias ipsum esse deserunt quis. Voluptas voluptatem rerum doloribus libero nemo neque enim voluptatem. Iusto quo natus et.", "Lebsack, Krajcik and Cartwright", "https://sabrina.org", "Pacific/N" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Voluptatem laboriosam dolore.\nVeritatis ipsam nisi qui.", "Kessler, Rowe and Walker", "http://janessa.org", "Asia/Maga" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "dolore", "McDermott, Luettgen and Berge", "http://carter.biz", "Australia" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Mollitia est vitae.", "Zulauf Inc", "http://danny.biz", "America/J" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Vel non totam ipsa est enim ut.\nRerum maxime tempora repellat et corrupti.\nDicta possimus labore consequatur natus sunt.\nDicta sed omnis porro aspernatur.\nNam a quia aut illo corporis itaque cumque occaecati eius.", "Mertz Group", "http://ayla.biz", "Europe/Be" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "rerum", "Olson Inc", "https://henriette.info", "Atlantic/" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Iure aut neque voluptatem voluptas.", "Morar - Koepp", "https://otis.com", "Pacific/A" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Doug58@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1109.jpg", "Doug Baumbach", "568-425-13" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Noah2@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/597.jpg", "Noah Swift", "394-517-52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Rebecca.Robel@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1144.jpg", "Rebecca Robel", "(895) 358-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Albert.Swaniawski76@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/216.jpg", "Albert Swaniawski", "326-405-30" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Gertrude92@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/499.jpg", "Gertrude Koch", "1-450-952-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Jacob_Boyer@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/608.jpg", "Jacob Boyer", "811-396-49" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Kay_Hilll76@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1013.jpg", "Kay Hilll", "1-614-740-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Ruben38@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1025.jpg", "Ruben Monahan", "851.634.09" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Carrie.Morar@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/606.jpg", "Carrie Morar", "1-412-529-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Devin75@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/16.jpg", "Devin Cremin", "1-358-591-" });

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
