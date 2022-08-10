using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class AddPropertiesToUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateFormat",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TimeFormat",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 3, 5, 4, 6, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 5, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 2, 5, 25, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 8, 5, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 3, 3, 2, 17, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 10, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 2, 7, 17, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 9, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 3, 2, 7, 2, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 5, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 8, 13, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 2, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 1, 5, 18, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 8, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "StartDate" },
                values: new object[] { 3, 4, 3, 24, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 3, 1, 8, 8, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 12, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "EndDate", "StartDate" },
                values: new object[] { 6, 20, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 7, 17, 15, 7, 20, 383, DateTimeKind.Unspecified).AddTicks(4926), "Optio quo quisquam ipsa. Eum pariatur omnis libero et hic beatae. Porro vitae corporis temporibus quia quo dolorem earum earum iusto.", 26, "https://shemar.biz", 1L, "velit", 57, 4L, 2, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 26, 21, 22, 14, 918, DateTimeKind.Unspecified).AddTicks(2972), "Dolorem soluta est dolores id et mollitia ipsum ipsum consectetur. Ipsum cumque qui similique quia voluptas modi sit. Hic distinctio ut ex ad asperiores eos.", 15, "http://edward.net", 2L, "corrupti", 57, 1L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 5, 14, 43, 9, 786, DateTimeKind.Unspecified).AddTicks(3806), "Qui quia qui magni autem. Aut dolor facilis autem quidem optio repellat. Aspernatur excepturi ipsum ullam et officiis repellat. Exercitationem et architecto consequatur voluptas. Iusto velit tenetur et id est.", 15, "https://nasir.biz", 4L, "blanditiis", 43, 2L, 1, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 24, 17, 53, 14, 743, DateTimeKind.Unspecified).AddTicks(1741), "Aut minima quam inventore voluptatem sunt. Et qui est voluptas. Quod ea nihil dolor voluptatem autem.", 29, "http://braeden.name", 4L, "omnis", 28, 8L, 1, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 12, 3, 0, 57, 50, 783, DateTimeKind.Unspecified).AddTicks(6476), "Earum porro illo est assumenda excepturi expedita at.", 16, "http://marcel.com", 1L, "at", 54, 7L, 1, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 11, 21, 6, 12, 0, 359, DateTimeKind.Unspecified).AddTicks(9649), "harum", 29, "https://oral.biz", "et", 49, 10L, 2, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 11, 22, 15, 4, 52, 807, DateTimeKind.Unspecified).AddTicks(6435), "At at est esse voluptatem rerum. Ducimus cupiditate repudiandae officia. Quo eum doloribus voluptates mollitia commodi. Et itaque cupiditate. Maiores reiciendis nobis.", 29, "http://oscar.net", "voluptas", 60, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 4, 21, 8, 3, 21, 899, DateTimeKind.Unspecified).AddTicks(8971), "Delectus est placeat molestias vitae.", 27, "https://rodolfo.com", 2L, "id", 48, 8L, 1, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 29, 0, 18, 8, 502, DateTimeKind.Unspecified).AddTicks(9767), "Veniam accusantium et rerum sed fuga autem quo.\nId nemo corporis ut aut.\nAdipisci qui voluptas voluptatibus.", 21, "https://elinore.org", "ut", 32, 5L, 1, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 9, 12, 22, 50, 17, 525, DateTimeKind.Unspecified).AddTicks(8032), "Asperiores minima sed sunt qui voluptatem temporibus accusantium reprehenderit.\nQui reprehenderit et omnis nemo.\nVel quis quibusdam autem ipsum totam.\nUt alias quis sunt sequi et.\nVoluptatem placeat nesciunt repellendus quod numquam ab officia magnam placeat.\nVoluptas et et repellat aut architecto a", 22, "https://damion.name", 4L, "labore", 2L, 2, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2019, 7, 23, 19, 8, 56, 510, DateTimeKind.Unspecified).AddTicks(2425), 9L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2020, 8, 2, 15, 25, 16, 586, DateTimeKind.Unspecified).AddTicks(5740), 8L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2019, 11, 12, 7, 56, 45, 618, DateTimeKind.Unspecified).AddTicks(4482), 2L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 6, 28, 16, 24, 54, 600, DateTimeKind.Unspecified).AddTicks(9464), 3L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { 2L, new DateTime(2020, 6, 7, 4, 15, 11, 367, DateTimeKind.Unspecified).AddTicks(8558), 2L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 4, 11, 11, 32, 57, 679, DateTimeKind.Unspecified).AddTicks(3327), 9L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2019, 8, 16, 6, 33, 6, 762, DateTimeKind.Unspecified).AddTicks(9503), 6L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2020, 5, 7, 10, 35, 26, 605, DateTimeKind.Unspecified).AddTicks(1137), 10L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2021, 3, 27, 22, 50, 54, 264, DateTimeKind.Unspecified).AddTicks(4090), 1L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { 4L, new DateTime(2020, 12, 11, 16, 12, 20, 892, DateTimeKind.Unspecified).AddTicks(1440), 3L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 12, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5132), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 11, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5050), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 12, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5453), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 11, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5392), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 12, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5472), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 11, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5467), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 12, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5486), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 11, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5482), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 12, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5499), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 11, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5495), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 12, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5511), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 11, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5507), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 12, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5523), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 11, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5519), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 12, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5535), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 11, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5531), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 12, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5547), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 11, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5543), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 12, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5559), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 11, 22, 3, 46, 165, DateTimeKind.Unspecified).AddTicks(5555), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Irvin.Hermiston@yahoo.com", new DateTimeOffset(new DateTime(2023, 7, 31, 1, 34, 4, 852, DateTimeKind.Unspecified).AddTicks(1478), new TimeSpan(0, 3, 0, 0, 0)), "Irvin Hermiston" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Johnnie_Lubowitz@gmail.com", new DateTimeOffset(new DateTime(2022, 10, 30, 11, 10, 5, 489, DateTimeKind.Unspecified).AddTicks(833), new TimeSpan(0, 2, 0, 0, 0)), "Johnnie Lubowitz" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Flora.Schroeder@yahoo.com", new DateTimeOffset(new DateTime(2023, 6, 14, 6, 43, 36, 965, DateTimeKind.Unspecified).AddTicks(6223), new TimeSpan(0, 3, 0, 0, 0)), "Flora Schroeder" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Terrence.Barrows@yahoo.com", new DateTimeOffset(new DateTime(2023, 2, 25, 5, 7, 30, 603, DateTimeKind.Unspecified).AddTicks(1320), new TimeSpan(0, 2, 0, 0, 0)), "Terrence Barrows" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Jeannette19@yahoo.com", new DateTimeOffset(new DateTime(2023, 4, 3, 11, 43, 53, 864, DateTimeKind.Unspecified).AddTicks(8444), new TimeSpan(0, 3, 0, 0, 0)), "Jeannette Durgan" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Katie10@gmail.com", new DateTimeOffset(new DateTime(2022, 11, 17, 18, 4, 20, 865, DateTimeKind.Unspecified).AddTicks(429), new TimeSpan(0, 2, 0, 0, 0)), "Katie Frami" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Candice.Romaguera@gmail.com", new DateTimeOffset(new DateTime(2023, 1, 2, 8, 48, 30, 893, DateTimeKind.Unspecified).AddTicks(1977), new TimeSpan(0, 2, 0, 0, 0)), "Candice Romaguera" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Shelly_Kilback@gmail.com", new DateTimeOffset(new DateTime(2022, 10, 6, 1, 28, 18, 589, DateTimeKind.Unspecified).AddTicks(4450), new TimeSpan(0, 3, 0, 0, 0)), "Shelly Kilback" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Joanne.Corwin21@gmail.com", new DateTimeOffset(new DateTime(2022, 12, 30, 16, 15, 14, 53, DateTimeKind.Unspecified).AddTicks(6405), new TimeSpan(0, 2, 0, 0, 0)), "Joanne Corwin" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Marie69@yahoo.com", new DateTimeOffset(new DateTime(2022, 11, 2, 19, 12, 11, 715, DateTimeKind.Unspecified).AddTicks(6912), new TimeSpan(0, 2, 0, 0, 0)), "Marie Lockman" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 12, 26, 1, 32, 58, 534, DateTimeKind.Unspecified).AddTicks(1704), 2L, "Qui quia rem illo optio consectetur. Quia illum no", 37, 4L, "quod", new DateTimeOffset(new DateTime(2022, 11, 10, 3, 58, 23, 165, DateTimeKind.Unspecified).AddTicks(7742), new TimeSpan(0, 2, 0, 0, 0)), 1L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 9, 15, 57, 59, 360, DateTimeKind.Unspecified).AddTicks(6762), 9L, "Officiis sunt consequatur odio nihil.", 19, 2L, "architecto", new DateTimeOffset(new DateTime(2023, 5, 5, 18, 45, 0, 436, DateTimeKind.Unspecified).AddTicks(209), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 13, 22, 38, 29, 153, DateTimeKind.Unspecified).AddTicks(4224), 10L, "itaque", 37, 3L, "dolorum", new DateTimeOffset(new DateTime(2022, 8, 22, 12, 7, 35, 692, DateTimeKind.Unspecified).AddTicks(2376), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 2, 11, 7, 50, 24, 352, DateTimeKind.Unspecified).AddTicks(5018), "Similique omnis doloribus aperiam rerum iusto enim", 31, 2L, "dignissimos", new DateTimeOffset(new DateTime(2023, 2, 27, 14, 51, 5, 291, DateTimeKind.Unspecified).AddTicks(6441), new TimeSpan(0, 2, 0, 0, 0)), 4L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 4, 23, 22, 43, 206, DateTimeKind.Unspecified).AddTicks(4144), 5L, "hic", 47, "ut", new DateTimeOffset(new DateTime(2023, 4, 24, 14, 20, 40, 642, DateTimeKind.Unspecified).AddTicks(4330), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 9, 16, 52, 7, 801, DateTimeKind.Unspecified).AddTicks(9019), 6L, "Debitis id exercitationem et est enim ratione modi", 31, 4L, "nesciunt", new DateTimeOffset(new DateTime(2023, 3, 10, 16, 20, 53, 411, DateTimeKind.Unspecified).AddTicks(4869), new TimeSpan(0, 2, 0, 0, 0)), 5L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 12, 7, 4, 46, 852, DateTimeKind.Unspecified).AddTicks(37), 3L, "Assumenda ipsam minima sunt numquam omnis maiores", 43, "pariatur", new DateTimeOffset(new DateTime(2022, 11, 17, 0, 17, 55, 963, DateTimeKind.Unspecified).AddTicks(5489), new TimeSpan(0, 2, 0, 0, 0)), 4L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 42, 58, 464, DateTimeKind.Unspecified).AddTicks(1287), 7L, "Est molestias qui quam dicta quos et.", 28, 2L, "voluptatem", new DateTimeOffset(new DateTime(2022, 10, 22, 13, 16, 14, 342, DateTimeKind.Unspecified).AddTicks(8334), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 22, 23, 58, 36, 779, DateTimeKind.Unspecified).AddTicks(9363), 2L, "officia", 33, 4L, "perspiciatis", new DateTimeOffset(new DateTime(2023, 6, 11, 13, 28, 23, 124, DateTimeKind.Unspecified).AddTicks(6867), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 16, 6, 12, 3, 589, DateTimeKind.Unspecified).AddTicks(403), 4L, "Laborum provident quo. Qui blanditiis voluptatum i", 56, 5L, new DateTimeOffset(new DateTime(2023, 3, 31, 0, 33, 55, 325, DateTimeKind.Unspecified).AddTicks(8598), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Text",
                value: "mollitiaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "maioresAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Id dolore sit possimus nostrum et magni.\nAut et cumque.\nDistinctio quasi sit minus.\nError id voluptatum et dolorem nulla tempora enim.\nQuas tenetur in." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Text",
                value: "sintAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "repudiandaeAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Voluptates odio explicabo nisi.AAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Omnis laborum officia consequatur facere ullam illum consequuntur eaque iusto. Corporis ullam accusamus magni corporis omnis tenetur pariatur laborum. Accusamus doloremque minima. Unde velit quisquam nisi amet architecto." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Est non laudantium.\nAb soluta neque qui excepturi qui numquam ipsum inventore accusamus." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Dignissimos veniam aut voluptatum sed placeat ex. Vel veniam possimus non nihil praesentium sapiente expedita odit. Quasi reiciendis dolor aut rerum quo similique blanditiis. Velit porro iusto ipsa sit corrupti vel id qui velit. Nesciunt autem totam enim repudiandae. Enim iste odio doloremque non ip" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Eaque eaque mollitia ab. Temporibus quibusdam est. Temporibus officiis id." });

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
                value: 9);

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
                value: 2);

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
                value: 4);

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
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Status",
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
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

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
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "At eum aperiam est quia.", "Robel Inc", "http://savion.com", "Europe/Be" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Eos voluptatem nulla optio accusamus quia optio consequatur. Officia et et recusandae blanditiis eos. Cumque veritatis voluptates voluptas sed voluptatum eum quae. Deleniti molestiae fuga est placeat quibusdam eos debitis. Dolor quas nemo commodi laboriosam et aut non deserunt asperiores.", "Kassulke - Jacobi", "https://jerrod.info", "Europe/So" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "rem", "Okuneva, Hyatt and Sporer", "https://madelyn.biz", "Asia/Kolk" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Expedita similique qui voluptate tempora enim placeat.\nAccusantium quia sed velit placeat voluptates.\nRatione sint ex.\nEst laudantium optio laboriosam neque non non.", "Friesen, Schamberger and Schamberger", "http://arvid.com", "Europe/Vi" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Ducimus quaerat quia ea tempora et nemo qui aspernatur doloremque. Id omnis officia natus ullam vel qui maxime. Debitis eveniet animi et aut explicabo id quisquam ea occaecati.", "Farrell, Schulist and Stamm", "https://alessia.biz", "America/M" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Nulla natus maiores laborum. Sit veniam vel dicta deserunt maxime. Atque consectetur delectus quia quos. Et impedit inventore ea et autem dolorum aut incidunt. Maxime a autem dignissimos et dolorem qui assumenda aut.", "Luettgen - Upton", "https://lillie.name" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Vero iure quis officia aut.\nTotam qui rerum.\nOfficiis nisi optio et voluptas nemo laborum.", "Rippin, Schuster and Weimann", "https://joshuah.net", "Pacific/F" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Error voluptatem ipsa et occaecati est eius.", "Glover - Gislason", "https://hipolito.net", "Asia/Kabu" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Ut enim asperiores voluptatem vitae rem temporibus tenetur aut. Iusto beatae ipsam maiores facere. Officiis eos animi quo excepturi. Qui aut architecto. Repellendus corrupti aut eum nulla vitae placeat excepturi quo odit. Natus doloremque tempore.", "Fritsch and Sons", "https://hudson.biz", "America/S" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "explicabo", "Konopelski - Wunsch", "http://isaias.org", "Europe/Ki" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "24h", "Andrew_Tremblay@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/894.jpg", "ENG", "Andrew Tremblay", "272-948-89", "DD/MM/YYYY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "24h", "Dianne_Leuschke83@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1161.jpg", "ENG", "Dianne Leuschke", "1-390-834-", "DD/MM/YYYY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "24h", "Toby.Johnson@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/30.jpg", "ENG", "Toby Johnson", "738.868.88", "DD/MM/YYYY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "24h", "Geoffrey_Gibson@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/72.jpg", "ENG", "Geoffrey Gibson", "1-452-837-", "DD/MM/YYYY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "24h", "Eduardo_Cormier@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1183.jpg", "ENG", "Eduardo Cormier", "1-244-350-", "DD/MM/YYYY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "24h", "Ellen_Braun54@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/296.jpg", "ENG", "Ellen Braun", "(759) 739-", "DD/MM/YYYY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "24h", "Johnnie.Fadel@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/675.jpg", "ENG", "Johnnie Fadel", "1-828-634-", "DD/MM/YYYY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "24h", "Kevin_Krajcik15@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/30.jpg", "ENG", "Kevin Krajcik", "(337) 608-", "DD/MM/YYYY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "24h", "Jimmy_Stracke24@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/465.jpg", "ENG", "Jimmy Stracke", "365-468-11", "DD/MM/YYYY" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Language", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "24h", "Reginald.Koch14@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/358.jpg", "ENG", "Reginald Koch", "(551) 512-", "DD/MM/YYYY" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateFormat",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TimeFormat",
                table: "Users");

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
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 3, 2, 26, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 9, 6, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 1, 1, 20, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 9, 10, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 1, 4, 6, 11, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 2, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 6, 8, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 10, 4, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 3, 7, 12, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 7, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "StartDate" },
                values: new object[] { 1, 1, 6, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 9, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[] { 1, 3, 3, 19, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 8, new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "EndDate", "StartDate" },
                values: new object[] { 5, 30, new DateTimeOffset(new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 9, 28, 1, 32, 23, 12, DateTimeKind.Unspecified).AddTicks(816), "Recusandae quo quis voluptatem porro sed aut non. Recusandae recusandae minus et qui ea asperiores laborum assumenda. Architecto eum quam cumque atque facilis sequi eveniet et.", 30, "http://leslie.name", 1L, "harum", 44, 4L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 11, 30, 1, 19, 20, 330, DateTimeKind.Unspecified).AddTicks(9269), "Et optio dolores eos. Provident nobis omnis porro ipsam. Atque deleniti officiis et consectetur consequuntur.", 24, "https://fredy.name", 2L, "beatae", 41, 10L, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 1, 22, 11, 4, 409, DateTimeKind.Unspecified).AddTicks(8771), "Rerum cupiditate eos eligendi sunt laboriosam consectetur non.\nQuas et omnis quia et autem consectetur dolore modi fugiat.\nNatus pariatur voluptatem corporis repellendus ut esse rem quo omnis.\nCorporis ea non officiis molestiae doloribus.", 26, "http://liam.name", 1L, "quis", 42, 1L, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 2, 25, 2, 10, 57, 920, DateTimeKind.Unspecified).AddTicks(8269), "Similique est exercitationem maxime quidem dignissimos sed animi ex.", 18, "https://lewis.name", 3L, "nesciunt", 26, 1L, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 31, 17, 59, 39, 329, DateTimeKind.Unspecified).AddTicks(1926), "Non tempore rem impedit sint enim sed. Praesentium et quia blanditiis repellendus omnis iure vitae numquam eos. Ut voluptas maiores magnam cumque et consequatur eveniet. Doloribus sit blanditiis aspernatur perferendis ut consequatur.", 19, "https://kamron.org", "illum", 45, 4L, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 17, 7, 10, 24, 17, DateTimeKind.Unspecified).AddTicks(7483), "Nostrum et fugiat consequatur qui.", 21, "https://willis.name", "voluptatem", 49, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 12, 28, 3, 1, 39, 366, DateTimeKind.Unspecified).AddTicks(7434), "Rerum magni quisquam nemo nostrum alias. Eum tempora velit sed est quo hic et incidunt magnam. Et deleniti non tenetur aut voluptas qui quisquam.", 15, "http://nathanael.net", "consequatur", 26, 9L, 2, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Description", "Frequency", "Link", "LocationId", "Name", "TeamId", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 24, 14, 14, 2, 827, DateTimeKind.Unspecified).AddTicks(8613), "Minus nemo aut vel minus corrupti est porro pariatur.\nAdipisci aut similique nesciunt optio necessitatibus magni sed mollitia suscipit.\nMolestiae ut aut nemo excepturi.\nMinus harum ex nostrum eum minima omnis est voluptas dolor.\nNeque officia perferendis.\nAccusamus cupiditate dolorem.", 19, "https://maurice.biz", 3L, "delectus", 9L, 1, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 12, 4, 5, 48, 35, 934, DateTimeKind.Unspecified).AddTicks(3481), 1L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 1L });

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
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 11, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7239), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 10, 21, 40, 13, 690, DateTimeKind.Unspecified).AddTicks(7226), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Vanessa_Goyette@hotmail.com", new DateTimeOffset(new DateTime(2023, 6, 26, 19, 35, 52, 558, DateTimeKind.Unspecified).AddTicks(3673), new TimeSpan(0, 3, 0, 0, 0)), "Vanessa Goyette" });

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
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 11, 22, 19, 5, 9, 840, DateTimeKind.Unspecified).AddTicks(6975), "Asperiores omnis dicta distinctio non ex est.", 18, 3L, "vel", new DateTimeOffset(new DateTime(2023, 4, 20, 20, 34, 39, 697, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 2, 8, 22, 8, 2, 324, DateTimeKind.Unspecified).AddTicks(6597), 3L, "Molestiae nostrum temporibus fugiat placeat libero", 13, "inventore", new DateTimeOffset(new DateTime(2023, 4, 11, 0, 42, 23, 833, DateTimeKind.Unspecified).AddTicks(1883), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 10, 9, 10, 14, 27, 974, DateTimeKind.Unspecified).AddTicks(7923), 4L, "consequatur", 19, "at", new DateTimeOffset(new DateTime(2023, 4, 7, 16, 13, 54, 47, DateTimeKind.Unspecified).AddTicks(3911), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 3, 17, 11, 24, 18, 404, DateTimeKind.Unspecified).AddTicks(497), 5L, "Doloremque laudantium aspernatur et eligendi dolor", 55, 4L, new DateTimeOffset(new DateTime(2023, 5, 6, 9, 24, 4, 350, DateTimeKind.Unspecified).AddTicks(1932), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Text",
                value: "Et natus iste repellat velit ratione quis.AAAAAAAA");

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
                column: "Text",
                value: "ducimusAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

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
                column: "Role",
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
                column: "Status",
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
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

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
                column: "Status",
                value: 2);

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
