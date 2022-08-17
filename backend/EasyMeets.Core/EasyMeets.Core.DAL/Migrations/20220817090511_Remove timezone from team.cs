using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class Removetimezonefromteam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeZone",
                table: "Teams");

            migrationBuilder.AlterColumn<int>(
                name: "TimeZone",
                table: "Users",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 19, 7, 9, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 5, 2, 8, 2, 1, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 4, 4, 5, 5, 8, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 8, 22, 2, 3, 10, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 8, 4, 4, 8, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 4, 4, 4, 1, 1, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 6, 16, 2, 1, 1, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 5, 11, 3, 13, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 5, 24, 3, 3, 15, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 8, 27, 3, 2, 3, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 10, 6, 12, 25, 54, 447, DateTimeKind.Unspecified).AddTicks(6406), 16, "http://kameron.biz", 2L, "est", 0, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Officia et eaque sit neque dolorem voluptatibus consequatur.\nSint animi incidunt.\nAut quo modi quia pariatur pariatur vel veniam sed excepturi.\nUnde ut nesciunt fugiat." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 6, 27, 4, 15, 26, 978, DateTimeKind.Unspecified).AddTicks(1410), 25, "https://kay.name", 2L, "voluptas", 22, 3L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Necessitatibus iure fugiat fugit voluptatum in id." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 10, 22, 6, 18, 46, 880, DateTimeKind.Unspecified).AddTicks(5407), 29, "https://jacques.name", 5L, "blanditiis", 15, 2L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Omnis est mollitia similique est voluptatibus rerum iste enim. Quae est nemo excepturi architecto adipisci molestias id fugiat. Fugiat hic dolorem molestiae ea cumque eligendi omnis. Perferendis quibusdam unde ut quaerat laudantium. Molestiae non error ut iure. Cupiditate dignissimos ipsam quae repe" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2019, 10, 26, 18, 3, 41, 621, DateTimeKind.Unspecified).AddTicks(4814), 19, "https://fanny.name", 1L, "nisi", 19, 10L, 0, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Ullam consequatur maiores in et rerum.\nIpsum ab commodi eum excepturi enim repudiandae non.\nQui sunt et sit." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2021, 3, 10, 12, 30, 52, 526, DateTimeKind.Unspecified).AddTicks(6565), 25, "http://vern.info", 3L, "et", 49, 10L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Qui excepturi expedita porro. Facere ea ullam facilis sit quidem eaque quaerat. Doloribus placeat delectus est quis. Dolor nostrum et nostrum sequi consequatur ut sed. Vel deleniti officiis atque quia voluptatem dolorem voluptatem qui ut. Quia mollitia optio est modi eius quos." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 5, 20, 3, 31, 25, 801, DateTimeKind.Unspecified).AddTicks(2979), 26, "http://joshua.info", 3L, "fugit", 55, 2L, 0, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "dolores" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 7, 29, 0, 41, 10, 985, DateTimeKind.Unspecified).AddTicks(8732), 29, "http://rupert.com", 4L, "sunt", 53, 6L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Maiores provident quidem voluptatem quasi provident est mollitia." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 3, 27, 15, 57, 36, 40, DateTimeKind.Unspecified).AddTicks(5287), 26, "http://kevon.com", 5L, "consectetur", 40, 3L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Dolor sunt sunt." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 3, 28, 21, 9, 37, 143, DateTimeKind.Unspecified).AddTicks(3701), 24, "http://dasia.net", "quis", 40, 8L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Aut est et eum voluptatem magni quis eum dolores." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 1, 27, 18, 46, 31, 749, DateTimeKind.Unspecified).AddTicks(2808), 30, "https://jules.name", 3L, "id", 15, 2L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "consectetur" });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 10, 29, 11, 20, 29, 872, DateTimeKind.Unspecified).AddTicks(9664), 5L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { 2L, new DateTime(2020, 9, 10, 17, 32, 34, 451, DateTimeKind.Unspecified).AddTicks(8791), 3L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 11, 23, 6, 46, 39, 105, DateTimeKind.Unspecified).AddTicks(4856), 3L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 7, 12, 21, 45, 14, 679, DateTimeKind.Unspecified).AddTicks(2766), 4L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { 1L, new DateTime(2021, 5, 13, 20, 11, 46, 736, DateTimeKind.Unspecified).AddTicks(8466), 9L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2021, 2, 21, 16, 43, 23, 991, DateTimeKind.Unspecified).AddTicks(249), 8L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2021, 1, 2, 4, 54, 11, 976, DateTimeKind.Unspecified).AddTicks(1081), 7L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2019, 8, 27, 19, 16, 28, 758, DateTimeKind.Unspecified).AddTicks(581), 3L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 12, 31, 7, 41, 46, 921, DateTimeKind.Unspecified).AddTicks(9122), new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 12, 29, 19, 41, 10, 209, DateTimeKind.Unspecified).AddTicks(9086), 9L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 3L });

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
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Derrick_Rippin@yahoo.com", new DateTimeOffset(new DateTime(2023, 2, 8, 21, 19, 41, 885, DateTimeKind.Unspecified).AddTicks(1648), new TimeSpan(0, 2, 0, 0, 0)), "Derrick Rippin" });

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
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Kyle71@hotmail.com", new DateTimeOffset(new DateTime(2023, 1, 28, 15, 57, 18, 168, DateTimeKind.Unspecified).AddTicks(3362), new TimeSpan(0, 2, 0, 0, 0)), "Kyle Parker" });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 24, 3, 28, 13, 966, DateTimeKind.Unspecified).AddTicks(3116), 5L, "repudiandae", 19, 1L, "reiciendis", new DateTimeOffset(new DateTime(2022, 8, 21, 23, 12, 43, 163, DateTimeKind.Unspecified).AddTicks(4062), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 15, 2, 44, 53, 758, DateTimeKind.Unspecified).AddTicks(7065), 5L, "Aperiam voluptatem veniam maxime non est vel odio.", 45, 1L, new DateTimeOffset(new DateTime(2023, 4, 5, 7, 14, 4, 280, DateTimeKind.Unspecified).AddTicks(8694), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 10, 17, 19, 49, 11, 610, DateTimeKind.Unspecified).AddTicks(9435), 10L, "Officiis quia ut dolorem minus exercitationem repe", 15, 2L, "minus", new DateTimeOffset(new DateTime(2023, 6, 25, 15, 1, 58, 378, DateTimeKind.Unspecified).AddTicks(5139), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 25, 5, 24, 47, 150, DateTimeKind.Unspecified).AddTicks(2474), 5L, "Ipsa doloribus perferendis est fugit error ipsa op", 27, 5L, "dolorum", new DateTimeOffset(new DateTime(2022, 9, 5, 19, 31, 15, 351, DateTimeKind.Unspecified).AddTicks(1386), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 24, 3, 17, 20, 596, DateTimeKind.Unspecified).AddTicks(4955), 7L, "Voluptate in sunt magnam repellendus aliquid dolor", 57, 1L, "illum", new DateTimeOffset(new DateTime(2023, 2, 10, 22, 31, 18, 984, DateTimeKind.Unspecified).AddTicks(3598), new TimeSpan(0, 2, 0, 0, 0)), 3L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 9, 26, 12, 17, 59, 595, DateTimeKind.Unspecified).AddTicks(6886), 3L, "Qui autem optio consequatur quo.", 14, 1L, "deserunt", new DateTimeOffset(new DateTime(2023, 3, 6, 16, 10, 22, 822, DateTimeKind.Unspecified).AddTicks(6764), new TimeSpan(0, 2, 0, 0, 0)), 7L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 9, 1, 8, 15, 54, 647, DateTimeKind.Unspecified).AddTicks(6300), 4L, "Fugiat adipisci quo quos.\nQuia beatae et.\nPorro oc", 35, 3L, "nostrum", new DateTimeOffset(new DateTime(2022, 10, 10, 12, 34, 6, 767, DateTimeKind.Unspecified).AddTicks(7789), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 11, 16, 23, 33, 29, 385, DateTimeKind.Unspecified).AddTicks(4292), 5L, "rem", 11, 1L, "qui", new DateTimeOffset(new DateTime(2023, 3, 28, 17, 8, 39, 886, DateTimeKind.Unspecified).AddTicks(9184), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 9, 15, 34, 17, 742, DateTimeKind.Unspecified).AddTicks(9828), 5L, "Et non quisquam et est provident in ut. Est repudi", 58, "assumenda", new DateTimeOffset(new DateTime(2023, 2, 28, 17, 5, 25, 293, DateTimeKind.Unspecified).AddTicks(7471), new TimeSpan(0, 2, 0, 0, 0)), 6L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 11, 26, 6, 9, 24, 18, DateTimeKind.Unspecified).AddTicks(6485), 4L, "Non nulla expedita consequuntur dolores id ipsam i", 15, "esse", new DateTimeOffset(new DateTime(2023, 4, 16, 17, 53, 11, 190, DateTimeKind.Unspecified).AddTicks(4624), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValue: 5L,
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
                keyValue: 10L,
                column: "Role",
                value: 2);

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { 1, "Tommy_Lynch@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/229.jpg", "Tommy Lynch", "(757) 893-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { "Ella_Sauer49@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/853.jpg", "Ella Sauer", "(381) 599-", 1, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, "Pam_Klein@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/872.jpg", "Pam Klein", "(291) 923-", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Beatrice_Grant@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/448.jpg", "Beatrice Grant", "1-619-719-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Kristie_Walker43@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/572.jpg", "Kristie Walker", "1-234-812-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Lori.Bernhard26@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/995.jpg", "Lori Bernhard", "(973) 772-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { "Jeanette48@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/951.jpg", "Jeanette Kuvalis", "760-682-21", 1, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { "Andrea_Botsford51@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1193.jpg", "Andrea Botsford", "554.657.42", 1, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, "Archie.Bednar82@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/506.jpg", "Archie Bednar", "(400) 210-", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 0, "Billie_Blanda52@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/338.jpg", "Billie Blanda", "721-329-62", 0, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TimeZone",
                table: "Users",
                type: "int",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 10);

            migrationBuilder.AddColumn<string>(
                name: "TimeZone",
                table: "Teams",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 15, 6, 2, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 8, 24, 5, 5, 13, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 2, 15, 6, 1, 13, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 6, 15, 2, 11, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 1, 9, 10, 3, 10, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 23, 8, 4, 4, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 1, 14, 4, 6, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

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
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 10, 20, 4, 18, 42, 206, DateTimeKind.Unspecified).AddTicks(1391), 19, "https://akeem.com", 3L, "magnam", 1, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "id" });

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
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 11, 29, 3, 37, 7, 284, DateTimeKind.Unspecified).AddTicks(3466), 25, "http://ruthe.org", 4L, "et", 19, 5L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Vel velit sit ea molestiae laudantium distinctio itaque pariatur.\nQuod officiis et sunt aliquid.\nEos debitis ut libero non repudiandae consequatur.\nNemo tenetur illo perspiciatis possimus officia aperiam.\nPossimus commodi et modi voluptatem quibusdam earum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 3, 26, 23, 31, 48, 208, DateTimeKind.Unspecified).AddTicks(2056), 16, "http://dovie.name", 2L, "provident", 45, 9L, 1, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Tempora ducimus veritatis unde debitis molestias aut. Quo praesentium vel optio enim. Consectetur et ea tempora itaque molestias est odit labore. Voluptatem sed natus occaecati molestiae deleniti et unde. Aut itaque vel repellendus. Et corporis suscipit hic ut consequatur dolore mollitia." });

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
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 10, 3, 5, 28, 33, 955, DateTimeKind.Unspecified).AddTicks(5449), 18, "https://alexandrine.org", 3L, "asperiores", 52, 4L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Nihil illo nesciunt in.\nConsequuntur asperiores assumenda itaque porro iusto et voluptatem.\nOmnis quasi molestiae autem cum vel voluptatibus velit.\nDolores omnis aperiam maxime qui qui odio praesentium repellendus vel.\nEt quam dicta optio." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 8, 19, 0, 27, 38, 916, DateTimeKind.Unspecified).AddTicks(7202), 16, "http://corine.info", 2L, "veritatis", 51, 2L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "modi" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 8, 13, 21, 22, 1, 797, DateTimeKind.Unspecified).AddTicks(6814), 15, "https://brady.net", "enim", 32, 6L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Sed recusandae perspiciatis possimus necessitatibus deserunt doloremque." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 11, 25, 9, 16, 32, 894, DateTimeKind.Unspecified).AddTicks(8800), 18, "http://bailee.name", 2L, "ut", 49, 4L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Consequatur recusandae magni." });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { 4L, new DateTime(2020, 12, 5, 4, 27, 10, 722, DateTimeKind.Unspecified).AddTicks(6307), 2L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { 8L, new DateTime(2020, 7, 12, 21, 27, 57, 541, DateTimeKind.Unspecified).AddTicks(1541), 4L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2020, 1, 11, 22, 15, 29, 592, DateTimeKind.Unspecified).AddTicks(9733), new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 4, 17, 13, 17, 33, 94, DateTimeKind.Unspecified).AddTicks(8891), 8L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 9L });

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
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 18, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8416), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 17, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8405), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 18, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8474), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 17, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8437), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 18, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8535), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 17, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8525), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Toby_Spinka43@yahoo.com", new DateTimeOffset(new DateTime(2022, 10, 18, 11, 21, 31, 861, DateTimeKind.Unspecified).AddTicks(2859), new TimeSpan(0, 3, 0, 0, 0)), "Toby Spinka" });

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
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Agnes_Botsford@gmail.com", new DateTimeOffset(new DateTime(2023, 6, 24, 16, 58, 57, 200, DateTimeKind.Unspecified).AddTicks(9377), new TimeSpan(0, 3, 0, 0, 0)), "Agnes Botsford" });

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
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Vickie52@yahoo.com", new DateTimeOffset(new DateTime(2023, 5, 17, 3, 15, 8, 10, DateTimeKind.Unspecified).AddTicks(9598), new TimeSpan(0, 3, 0, 0, 0)), "Vickie Wisozk" });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 31, 8, 7, 50, 109, DateTimeKind.Unspecified).AddTicks(310), 6L, "Voluptas molestiae tempora officiis impedit.", 43, 2L, new DateTimeOffset(new DateTime(2022, 9, 21, 4, 55, 39, 565, DateTimeKind.Unspecified).AddTicks(8878), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 17, 8, 41, 19, 813, DateTimeKind.Unspecified).AddTicks(3289), 2L, "Quam nesciunt quis vel. Consequatur aspernatur qui", 35, 4L, "facere", new DateTimeOffset(new DateTime(2022, 12, 7, 17, 1, 21, 365, DateTimeKind.Unspecified).AddTicks(5499), new TimeSpan(0, 2, 0, 0, 0)), 7L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 11, 30, 5, 26, 45, 883, DateTimeKind.Unspecified).AddTicks(7562), 10L, "Vitae consequatur impedit.", 19, 3L, "est", new DateTimeOffset(new DateTime(2023, 1, 1, 20, 23, 49, 96, DateTimeKind.Unspecified).AddTicks(181), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 6, 5, 33, 22, 513, DateTimeKind.Unspecified).AddTicks(5024), 5L, "Quia ut sunt dolores quae nesciunt recusandae eum", 37, 4L, "atque", new DateTimeOffset(new DateTime(2023, 3, 30, 15, 43, 30, 316, DateTimeKind.Unspecified).AddTicks(9070), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 25, 4, 56, 24, 64, DateTimeKind.Unspecified).AddTicks(4741), 6L, "Magni porro perspiciatis harum qui et dolorum. Omn", 53, 4L, "eos", new DateTimeOffset(new DateTime(2023, 7, 19, 15, 15, 1, 859, DateTimeKind.Unspecified).AddTicks(2098), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 5, 22, 2, 28, 258, DateTimeKind.Unspecified).AddTicks(4103), 3L, "Autem officiis occaecati voluptates. Illo repellen", 16, "aut", new DateTimeOffset(new DateTime(2023, 2, 18, 15, 3, 36, 109, DateTimeKind.Unspecified).AddTicks(9580), new TimeSpan(0, 2, 0, 0, 0)), 4L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 12, 12, 31, 58, 460, DateTimeKind.Unspecified).AddTicks(599), 6L, "Vitae mollitia doloribus ipsa dolor cum blanditiis", 54, "temporibus", new DateTimeOffset(new DateTime(2023, 5, 14, 16, 30, 44, 1, DateTimeKind.Unspecified).AddTicks(6066), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Quibusdam quis ex. Laudantium et nemo. Aut cum odio. Quo voluptate quo accusamus dolor a." });

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
                column: "Text",
                value: "Tempore earum qui sunt voluptatem sed perferendis. In adipisci ducimus explicabo. Eum quam praesentium enim et voluptatum adipisci ut. Non quos ea officiis autem nemo vitae. Fugit necessitatibus exercitationem eos sint rerum aut.");

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
                keyValue: 1L,
                column: "Priority",
                value: 1);

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
                keyValue: 5L,
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
                keyValue: 5L,
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
                keyValue: 10L,
                column: "Role",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink", "TimeZone" },
                values: new object[] { "perferendis", "", "Boyer, Bechtelar and Little", "http://austyn.net", "Australia" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Pariatur atque ut voluptate suscipit. Dolor laudantium voluptatem unde qui illum qui. Quos beatae sint ullam est velit et. Aut ipsam eligendi autem a. Ut sint voluptatem et non labore. Perspiciatis eum nisi ipsa dolor.", "", "McKenzie and Sons", "http://johnny.org", "Europe/Br" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Et enim facilis mollitia at iusto a rerum. Voluptate veniam sed saepe earum soluta eligendi non ipsam at. Enim fuga enim qui ipsum est aut modi et. Unde eligendi est iusto et. A necessitatibus necessitatibus voluptates veritatis numquam enim.", "", "Schaden, Harris and Champlin", "http://efrain.org", "America/H" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Libero amet necessitatibus vero.", "", "Volkman, Kshlerin and Crooks", "https://erick.name", "Africa/Jo" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink", "TimeZone" },
                values: new object[] { "doloribus", "", "Corwin - Okuneva", "https://palma.info", "Europe/Vi" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink", "TimeZone" },
                values: new object[] { "velit", "", "McGlynn - Simonis", "http://cathryn.net", "Asia/Kual" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Eveniet veniam aut ab debitis facere et voluptates velit enim.", "", "Schaden Group", "http://karolann.org", "Europe/Vi" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink", "TimeZone" },
                values: new object[] { "aut", "", "Wehner, Swaniawski and West", "http://tiffany.org", "Asia/Yaku" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink", "TimeZone" },
                values: new object[] { "quidem", "", "Ryan and Sons", "https://lorenzo.info", "Europe/Co" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "LogoPath", "Name", "PageLink", "TimeZone" },
                values: new object[] { "iste", "", "Ferry Group", "http://benedict.name", "Asia/Dhak" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { 0, "Seth_Ullrich@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/764.jpg", "Seth Ullrich", "740.582.42", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { "Tommie.McCullough@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1043.jpg", "Tommie McCullough", "632-746-39", 0, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 0, "Karl.Swaniawski44@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/48.jpg", "Karl Swaniawski", "(779) 420-", 1, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Cesar18@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1152.jpg", "Cesar Rosenbaum", "645.236.79", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Forrest_Kerluke@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/372.jpg", "Forrest Kerluke", "(245) 379-", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Sophia_Rohan92@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/390.jpg", "Sophia Rohan", "948-323-40", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { "Blanche_Kling65@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1094.jpg", "Blanche Kling", "985-600-56", 0, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { "Warren_Ondricka39@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/711.jpg", "Warren Ondricka", "931.651.92", 0, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 0, "Jody.Heidenreich@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/380.jpg", "Jody Heidenreich", "1-947-874-", 1, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, "Bernice.Dicki@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1019.jpg", "Bernice Dicki", "(712) 768-", 1, 5 });
        }
    }
}
