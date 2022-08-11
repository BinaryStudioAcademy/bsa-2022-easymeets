using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class ChangesInAvailabilitySlotAndSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 7, 3, 8, 1, 8, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 1, 23, 3, 5, 14, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 3, 3, 8, 2, 15, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 6, 9, 1, 4, 5, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 5, 12, 10, 5, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "StartDate" },
                values: new object[] { 3, 8, 18, 4, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 4, 5, 4, 3, 3, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 1, 8, 4, 5, 12, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 2, 3, 8, 15, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 7, 1, 4, 4, 9, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TeamId", "TimeZoneVisibility", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 3, new DateTime(2020, 11, 25, 5, 57, 48, 647, DateTimeKind.Unspecified).AddTicks(1013), 25, "Ukrainian", "https://layne.info", 5L, "aut", 27, 1L, true, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Architecto ea id atque porro consequatur ducimus tempore ut.\nAlias eos praesentium tenetur porro cum molestiae.\nNihil minima doloremque cumque et aut harum laboriosam consequatur dolores.\nIncidunt iste a velit quis eius et voluptas blanditiis laborum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "Name", "Size", "TeamId", "TimeZoneVisibility", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 4, new DateTime(2020, 9, 1, 7, 42, 33, 549, DateTimeKind.Unspecified).AddTicks(7406), 20, "Ukrainian", "http://jonathon.biz", "eos", 49, 9L, true, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "omnis" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "Name", "Size", "TeamId", "TimeZoneVisibility", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 1, new DateTime(2021, 6, 29, 23, 53, 2, 196, DateTimeKind.Unspecified).AddTicks(5849), 20, "Ukrainian", "https://breanna.com", "dolor", 53, 2L, true, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Sunt dolorum voluptatem." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Language", "Link", "Name", "Size", "TeamId", "TimeZoneVisibility", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 4, new DateTime(2020, 4, 16, 18, 53, 13, 431, DateTimeKind.Unspecified).AddTicks(6495), "Ukrainian", "https://torrance.name", "porro", 38, 4L, true, 1, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Ut minima velit magni ad a mollitia delectus exercitationem." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TimeZoneVisibility", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 1, new DateTime(2021, 4, 10, 15, 58, 26, 370, DateTimeKind.Unspecified).AddTicks(7159), 26, "Ukrainian", "https://kory.net", 1L, "voluptatem", 60, true, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Voluptatibus architecto est et debitis corrupti sint debitis ipsam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TeamId", "TimeZoneVisibility", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 3, new DateTime(2019, 9, 17, 7, 1, 34, 893, DateTimeKind.Unspecified).AddTicks(9276), 27, "Ukrainian", "http://felicita.biz", 2L, "explicabo", 33, 3L, true, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "commodi" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TeamId", "TimeZoneVisibility", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 4, new DateTime(2019, 9, 26, 9, 23, 36, 851, DateTimeKind.Unspecified).AddTicks(8068), 26, "Ukrainian", "https://mary.name", 1L, "excepturi", 17, 3L, true, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Minus dolorum aliquam aspernatur.\nMinima quidem alias necessitatibus maiores non adipisci voluptatem omnis.\nInventore similique voluptatem velit.\nTempore et non hic culpa qui.\nQuibusdam ipsam consequuntur voluptas et voluptate minima quo." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TeamId", "TimeZoneVisibility", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 3, new DateTime(2020, 7, 1, 11, 35, 4, 750, DateTimeKind.Unspecified).AddTicks(2147), 27, "Ukrainian", "https://daphnee.net", 5L, "ut", 57, 6L, true, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Facilis numquam sed quia esse est occaecati sunt et. Deserunt consequatur distinctio dolore ipsum. Ipsam sequi quisquam molestiae ab aut aspernatur aut eos culpa. Repudiandae dolorem perferendis aspernatur est eius minus amet nemo. Esse id possimus numquam veniam eum et id tenetur. Quod quos et aspe" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TeamId", "TimeZoneVisibility", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 5, new DateTime(2020, 6, 19, 14, 55, 56, 949, DateTimeKind.Unspecified).AddTicks(8349), 27, "Ukrainian", "http://kathryn.net", 4L, "debitis", 59, 2L, true, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Quam libero aliquam repellendus et officiis.\nNeque tenetur voluptatem rem harum praesentium quam.\nAccusantium sint sed adipisci.\nSit vero alias voluptatem voluptatem." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AllowToAddGuests", "BookingsPerDay", "CreatedAt", "Frequency", "Language", "Link", "LocationId", "Name", "Size", "TimeZoneVisibility", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { true, 4, new DateTime(2020, 8, 1, 22, 26, 51, 784, DateTimeKind.Unspecified).AddTicks(3200), 18, "Ukrainian", "https://kolby.biz", 1L, "eius", 27, true, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Qui voluptas officia repellendus quibusdam laborum minus culpa dolor aliquid. Saepe numquam odit nostrum blanditiis tempore. Saepe et aperiam consequuntur iure. Excepturi quis suscipit et et repellat." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2019, 11, 18, 3, 14, 25, 498, DateTimeKind.Unspecified).AddTicks(6476), 10L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2019, 11, 27, 19, 47, 56, 348, DateTimeKind.Unspecified).AddTicks(1073), 6L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 9, 5, 20, 37, 52, 728, DateTimeKind.Unspecified).AddTicks(9256), new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 11, 8, 15, 35, 20, 184, DateTimeKind.Unspecified).AddTicks(9048), 9L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2021, 2, 5, 15, 2, 6, 548, DateTimeKind.Unspecified).AddTicks(1765), new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2019, 12, 4, 5, 8, 48, 3, DateTimeKind.Unspecified).AddTicks(6629), 7L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 3, 4, 15, 43, 1, 923, DateTimeKind.Unspecified).AddTicks(5973), 9L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 10, 12, 19, 44, 29, 391, DateTimeKind.Unspecified).AddTicks(2592), 2L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2019, 10, 19, 18, 9, 37, 468, DateTimeKind.Unspecified).AddTicks(3192), new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 1, 4, 5, 21, 47, 553, DateTimeKind.Unspecified).AddTicks(6870), new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 10L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1577), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 12, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1468), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1758), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 12, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1744), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1781), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 12, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1774), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1802), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 12, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1796), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1822), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 12, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1816), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1842), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 12, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1835), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1861), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 12, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1855), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1880), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 12, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1874), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1900), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 12, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1893), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 13, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1920), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 12, 14, 30, 56, 662, DateTimeKind.Unspecified).AddTicks(1914), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Maxine85@hotmail.comAAAAAAAAAA", new DateTimeOffset(new DateTime(2022, 10, 16, 15, 25, 16, 443, DateTimeKind.Unspecified).AddTicks(8847), new TimeSpan(0, 3, 0, 0, 0)), "Maxine Crona" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Verna_Dickinson@yahoo.comAAAAA", new DateTimeOffset(new DateTime(2022, 9, 30, 7, 9, 17, 80, DateTimeKind.Unspecified).AddTicks(6951), new TimeSpan(0, 3, 0, 0, 0)), "Verna Dickinson" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Lowell.Bernier@yahoo.comAAAAAA", new DateTimeOffset(new DateTime(2022, 9, 19, 8, 47, 42, 348, DateTimeKind.Unspecified).AddTicks(680), new TimeSpan(0, 3, 0, 0, 0)), "Lowell Bernier" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Samuel55@gmail.comAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 1, 21, 5, 13, 49, 667, DateTimeKind.Unspecified).AddTicks(9723), new TimeSpan(0, 2, 0, 0, 0)), "Samuel Stamm" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Chad4@gmail.comAAAAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2022, 12, 25, 12, 55, 52, 603, DateTimeKind.Unspecified).AddTicks(3502), new TimeSpan(0, 2, 0, 0, 0)), "Chad Lemke" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Rebecca.Boyle@yahoo.comAAAAAAA", new DateTimeOffset(new DateTime(2022, 11, 24, 0, 26, 54, 130, DateTimeKind.Unspecified).AddTicks(9504), new TimeSpan(0, 2, 0, 0, 0)), "Rebecca Boyle" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Leona.OConner36@yahoo.comAAAAA", new DateTimeOffset(new DateTime(2022, 11, 12, 15, 14, 54, 594, DateTimeKind.Unspecified).AddTicks(1044), new TimeSpan(0, 2, 0, 0, 0)), "Leona O'Conner" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Lynn13@yahoo.comAAAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 8, 3, 17, 14, 19, 732, DateTimeKind.Unspecified).AddTicks(6893), new TimeSpan(0, 3, 0, 0, 0)), "Lynn Champlin" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Gerard90@yahoo.comAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 2, 2, 4, 42, 52, 785, DateTimeKind.Unspecified).AddTicks(5483), new TimeSpan(0, 2, 0, 0, 0)), "Gerard Koelpin" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Marsha4@hotmail.comAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 7, 5, 2, 9, 56, 439, DateTimeKind.Unspecified).AddTicks(3434), new TimeSpan(0, 3, 0, 0, 0)), "Marsha Parker" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 10, 11, 23, 1, 12, 20, DateTimeKind.Unspecified).AddTicks(2426), 8L, "Aut explicabo vitae aliquid nesciunt quod. Itaque", 57, 5L, "tenetur", new DateTimeOffset(new DateTime(2022, 12, 29, 15, 59, 7, 803, DateTimeKind.Unspecified).AddTicks(7346), new TimeSpan(0, 2, 0, 0, 0)), 5L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 11, 16, 24, 1, 529, DateTimeKind.Unspecified).AddTicks(4513), 7L, "Saepe laudantium exercitationem.", 23, 3L, "culpa", new DateTimeOffset(new DateTime(2023, 2, 24, 4, 0, 51, 546, DateTimeKind.Unspecified).AddTicks(1546), new TimeSpan(0, 2, 0, 0, 0)), 7L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 4, 28, 19, 28, 58, 590, DateTimeKind.Unspecified).AddTicks(8750), 3L, "rerum", 42, 5L, "quaerat", new DateTimeOffset(new DateTime(2023, 4, 12, 6, 31, 32, 870, DateTimeKind.Unspecified).AddTicks(1937), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 12, 17, 8, 3, 33, 695, DateTimeKind.Unspecified).AddTicks(5984), 7L, "asperiores", 45, 5L, "dolores", new DateTimeOffset(new DateTime(2023, 5, 19, 1, 33, 7, 125, DateTimeKind.Unspecified).AddTicks(9004), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 3, 13, 5, 57, 33, 811, DateTimeKind.Unspecified).AddTicks(4602), 2L, "Occaecati non occaecati neque officia dignissimos", 42, 3L, "autem", new DateTimeOffset(new DateTime(2023, 7, 1, 23, 7, 40, 130, DateTimeKind.Unspecified).AddTicks(8016), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 1, 11, 22, 5, 509, DateTimeKind.Unspecified).AddTicks(6048), "aspernatur", 20, 2L, "libero", new DateTimeOffset(new DateTime(2023, 4, 20, 18, 49, 25, 123, DateTimeKind.Unspecified).AddTicks(2307), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 4, 18, 20, 56, 7, 978, DateTimeKind.Unspecified).AddTicks(2482), 1L, "Impedit repellat non quisquam.\nUt natus debitis di", 52, 5L, "doloribus", new DateTimeOffset(new DateTime(2022, 11, 13, 17, 21, 48, 947, DateTimeKind.Unspecified).AddTicks(640), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 20, 7, 43, 31, 160, DateTimeKind.Unspecified).AddTicks(8767), "Id officia hic voluptates autem aspernatur dolorem", 31, 5L, "aut", new DateTimeOffset(new DateTime(2023, 1, 14, 13, 14, 19, 389, DateTimeKind.Unspecified).AddTicks(2899), new TimeSpan(0, 2, 0, 0, 0)), 5L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 11, 27, 19, 30, 34, 251, DateTimeKind.Unspecified).AddTicks(2217), 8L, "aperiam", 28, 1L, "consequuntur", new DateTimeOffset(new DateTime(2023, 1, 10, 15, 1, 48, 53, DateTimeKind.Unspecified).AddTicks(4520), new TimeSpan(0, 2, 0, 0, 0)), 7L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 10, 14, 22, 4, 5, 652, DateTimeKind.Unspecified).AddTicks(9788), 6L, "Rerum facilis non laboriosam deserunt nobis accusa", 45, 2L, "nobis", new DateTimeOffset(new DateTime(2022, 11, 15, 1, 29, 27, 692, DateTimeKind.Unspecified).AddTicks(6327), new TimeSpan(0, 2, 0, 0, 0)), 9L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Aut aliquam repellat facere debitis neque illum in. Qui libero quas a. Et dolores asperiores necessitatibus quia cum fugiat tempora. Veritatis eveniet officia. Cupiditate perspiciatis earum." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Voluptatem nihil consequatur.\nOdio culpa et quos autem.\nDoloribus consequatur sit fuga aut.\nBlanditiis nesciunt praesentium commodi.\nEst ex atque.\nMagnam dolores dignissimos." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Cum sequi quaerat et nesciunt et.\nIllo praesentium magnam natus reprehenderit sed eos alias.\nIn corrupti voluptatem et et perferendis ad.\nPlaceat facilis consequatur est cum nisi ex alias velit est.\nEst exercitationem minima natus vel consectetur.\nDeserunt et aliquam id quia rerum expedita eveniet." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Autem aspernatur accusamus minus.\nDolorem voluptatum aliquid vel voluptatem fugiat.\nRerum ut est architecto sunt in sunt minus.\nAlias dolores sint voluptates earum vel aut atque nobis rerum.\nDolorum inventore magni eveniet.\nSint et voluptas aut sed quia quidem voluptas nisi quod." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Reiciendis explicabo incidunt autem pariatur aut voluptas.\nAutem molestiae quod eum ut exercitationem beatae vel sequi nisi.\nDoloremque sequi fugiat necessitatibus et aliquam sed.\nSed ipsum reprehenderit velit aperiam consequuntur." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Enim facilis suscipit voluptatem saepe nostrum soluta.\nInventore et dolores facilis ipsum.\nCulpa enim animi doloribus officiis omnis dolor consectetur.\nEt nostrum voluptas cumque odio incidunt qui." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Velit consequatur tenetur eius adipisci quas. Quia facere debitis perspiciatis. Nostrum necessitatibus dolorem eum aut voluptate enim qui quia. Dolores distinctio impedit natus nemo." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Provident temporibus est quod aut reiciendis veniam sequi aut aut." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Quisquam et explicabo vitae.AAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Recusandae qui facere quae iure non corporis.\nFuga exercitationem error eveniet quisquam earum eveniet.\nEt libero officiis fugiat est quo aut aut sint asperiores." });

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Priority",
                value: 4);

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
                value: 8);

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
                value: 6);

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
                value: 4);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Priority",
                value: 4);

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
                value: 3);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

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
                keyValue: 10L,
                column: "Role",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Sit repellat expedita.\nMagni quia aut recusandae temporibus.\nEt qui nam enim excepturi rerum aut.", "Runolfsdottir - Marvin", "http://nora.name", "Asia/Maga" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "possimus", "Marvin - Kuhic", "https://krystina.net", "Asia/Alma" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Voluptatum laudantium sit quibusdam dolore aperiam excepturi modi non.\nEt vitae saepe sunt aut perferendis.\nFugiat aliquam laudantium.\nMolestiae ea et magnam.", "Howell Inc", "https://sim.biz", "Asia/Kara" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Repudiandae ad occaecati aut tenetur ex consequatur.", "Leffler, Sawayn and O'Conner", "http://winnifred.biz", "Europe/Be" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quo dolores blanditiis eum veritatis quia sequi perspiciatis mollitia.\nQuia nostrum eligendi voluptas corrupti.\nEst amet ut harum tenetur aliquam.", "Reinger, Spencer and Gulgowski", "https://jasen.biz", "Europe/Ki" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "beatae", "Littel - Lubowitz", "http://allie.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Qui est voluptatibus impedit at officia unde porro alias et.\nAssumenda sit nulla ut officia iusto tenetur id.", "Bernier, Kuhlman and Weimann", "http://harrison.net", "Pacific/P" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Vel enim quam vitae magni alias aut sit velit error.", "Prosacco Inc", "http://josianne.net", "Asia/Riya" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "explicabo", "Hartmann, Wisoky and Carter", "http://idella.name", "Asia/Bang" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Rerum et a incidunt praesentium et qui dicta inventore repellat.\nDeleniti illo a enim aspernatur.", "Bailey LLC", "http://emerson.info", "Australia" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Joseph_Douglas99@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/338.jpg", "Joseph Douglas", "552-876-47" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Ann88@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/309.jpg", "Ann Cormier", "(552) 780-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Daniel.Sauer@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/553.jpg", "Daniel Sauer", "498-307-92" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Clyde.Hane17@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/960.jpg", "Clyde Hane", "(729) 739-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Lester_Labadie@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/723.jpg", "Lester Labadie", "872.869.28" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Francis41@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/482.jpg", "Francis Johnson", "903-764-91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Ellen.Schulist37@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1002.jpg", "Ellen Schulist", "811-390-59" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Maryann.OConnell@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1182.jpg", "Maryann O'Connell", "(703) 270-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Cameron3@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/480.jpg", "Cameron Jones", "1-404-432-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Johanna_Mann@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1179.jpg", "Johanna Mann", "690-955-57" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 2, 2, 5, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 3, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 3, 2, 2, 26, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 9, 6, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 2, 1, 4, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 2, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 3, 1, 1, 20, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 9, 10, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 6, 11, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 2, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "StartDate" },
                values: new object[] { 2, 5, 6, 8, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 4, 7, 12, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 7, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 1, 1, 6, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 9, 8, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 1, 3, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 8, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 2, 3, 5, 30, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 11, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 26, 5, 27, 18, 157, DateTimeKind.Unspecified).AddTicks(5561), "Error illo debitis ad.", 24, "https://keanu.net", 2L, "quidem", 45, 5L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 9, 28, 1, 32, 23, 12, DateTimeKind.Unspecified).AddTicks(816), "Recusandae quo quis voluptatem porro sed aut non. Recusandae recusandae minus et qui ea asperiores laborum assumenda. Architecto eum quam cumque atque facilis sequi eveniet et.", 30, "http://leslie.name", "harum", 44, 4L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 11, 30, 1, 19, 20, 330, DateTimeKind.Unspecified).AddTicks(9269), "Et optio dolores eos. Provident nobis omnis porro ipsam. Atque deleniti officiis et consectetur consequuntur.", 24, "https://fredy.name", "beatae", 41, 10L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 2, 25, 2, 10, 57, 920, DateTimeKind.Unspecified).AddTicks(8269), "Similique est exercitationem maxime quidem dignissimos sed animi ex.", 18, "https://lewis.name", 3L, "nesciunt", 26, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 31, 17, 59, 39, 329, DateTimeKind.Unspecified).AddTicks(1926), "Non tempore rem impedit sint enim sed. Praesentium et quia blanditiis repellendus omnis iure vitae numquam eos. Ut voluptas maiores magnam cumque et consequatur eveniet. Doloribus sit blanditiis aspernatur perferendis ut consequatur.", 19, "https://kamron.org", 1L, "illum", 45, 4L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 17, 7, 10, 24, 17, DateTimeKind.Unspecified).AddTicks(7483), "Nostrum et fugiat consequatur qui.", 21, "https://willis.name", 3L, "voluptatem", 49, 4L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 6, 21, 17, 2, 453, DateTimeKind.Unspecified).AddTicks(5646), "Sapiente nemo dolor natus voluptatem sed. Iusto sint omnis est. Dolor ut dolores.", 20, "http://dangelo.biz", 4L, "esse", 20, 9L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 3, 1, 39, 366, DateTimeKind.Unspecified).AddTicks(7434), "Rerum magni quisquam nemo nostrum alias. Eum tempora velit sed est quo hic et incidunt magnam. Et deleniti non tenetur aut voluptas qui quisquam.", 15, "http://nathanael.net", 1L, "consequatur", 26, 9L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 24, 14, 14, 2, 827, DateTimeKind.Unspecified).AddTicks(8613), "Minus nemo aut vel minus corrupti est porro pariatur.\nAdipisci aut similique nesciunt optio necessitatibus magni sed mollitia suscipit.\nMolestiae ut aut nemo excepturi.\nMinus harum ex nostrum eum minima omnis est voluptas dolor.\nNeque officia perferendis.\nAccusamus cupiditate dolorem.", 19, "https://maurice.biz", 3L, "delectus", 23, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 4, 27, 16, 33, 11, 97, DateTimeKind.Unspecified).AddTicks(4093), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 12, 4, 5, 48, 35, 934, DateTimeKind.Unspecified).AddTicks(3481), 1L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 12, 9, 20, 28, 38, 929, DateTimeKind.Unspecified).AddTicks(1135), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 1L });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2020, 3, 13, 14, 26, 21, 980, DateTimeKind.Unspecified).AddTicks(4243), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2021, 2, 13, 11, 44, 28, 980, DateTimeKind.Unspecified).AddTicks(850), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 3L });

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
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7254), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7438), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7432), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Chad.Bednar56@yahoo.com", new DateTimeOffset(new DateTime(2022, 10, 21, 16, 43, 57, 702, DateTimeKind.Unspecified).AddTicks(3057), new TimeSpan(0, 3, 0, 0, 0)), "Chad Bednar" });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 5, 18, 23, 19, 420, DateTimeKind.Unspecified).AddTicks(7301), 4L, "Fuga aliquid cupiditate nisi similique. Cupiditate", 50, 1L, "et", new DateTimeOffset(new DateTime(2022, 11, 4, 1, 55, 10, 764, DateTimeKind.Unspecified).AddTicks(2636), new TimeSpan(0, 2, 0, 0, 0)), 3L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 11, 22, 19, 5, 9, 840, DateTimeKind.Unspecified).AddTicks(6975), 3L, "Asperiores omnis dicta distinctio non ex est.", 18, 3L, "vel", new DateTimeOffset(new DateTime(2023, 4, 20, 20, 34, 39, 697, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 5, 18, 13, 10, 719, DateTimeKind.Unspecified).AddTicks(55), "Voluptatum molestias quia minima quisquam vero vel", 30, 3L, "animi", new DateTimeOffset(new DateTime(2022, 11, 13, 21, 28, 49, 587, DateTimeKind.Unspecified).AddTicks(2033), new TimeSpan(0, 2, 0, 0, 0)), 7L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 10, 9, 10, 14, 27, 974, DateTimeKind.Unspecified).AddTicks(7923), 4L, "consequatur", 19, 3L, "at", new DateTimeOffset(new DateTime(2023, 4, 7, 16, 13, 54, 47, DateTimeKind.Unspecified).AddTicks(3911), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 12, 23, 29, 12, 644, DateTimeKind.Unspecified).AddTicks(2012), "Eos quod amet sed in vero. Saepe dolorum natus sed", 21, 4L, "quo", new DateTimeOffset(new DateTime(2023, 4, 1, 2, 9, 59, 784, DateTimeKind.Unspecified).AddTicks(2721), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 3, 17, 11, 24, 18, 404, DateTimeKind.Unspecified).AddTicks(497), 5L, "Doloremque laudantium aspernatur et eligendi dolor", 55, 4L, "doloribus", new DateTimeOffset(new DateTime(2023, 5, 6, 9, 24, 4, 350, DateTimeKind.Unspecified).AddTicks(1932), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValue: 5L,
                column: "Priority",
                value: 9);

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
                value: 1);

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

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
                keyValue: 10L,
                column: "Role",
                value: 1);

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
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "dolore", "McDermott, Luettgen and Berge", "http://carter.biz" });

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
        }
    }
}
