using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class Fixphonelenght : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 1, 4, 17, 8, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 1, 5, 5, 13 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 4, 7, 4, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 2, 27, 6, 1, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 3, 7, 6, 1, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 11, 5, 5, 15 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings" },
                values: new object[] { 2, 9, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 2, 26, 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 2, 18, 5, 1, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 5, 17, 10, 2, 6 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 5, 3, 16, 34, 13, 135, DateTimeKind.Unspecified).AddTicks(8749), 24, "https://lawson.biz", 2L, "quia", 57, 1L, "sed" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 2, 11, 21, 35, 5, 701, DateTimeKind.Unspecified).AddTicks(1365), 16, "http://zoe.com", 3L, "in", 26, 5L, "maiores" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 5, 12, 19, 37, 20, 810, DateTimeKind.Unspecified).AddTicks(5715), 19, "http://jovani.org", "voluptatum", 35, 4L, "Recusandae commodi et qui.\nOdit est est hic ea.\nFuga suscipit sit voluptates voluptate.\nAmet voluptas ut in dolore mollitia placeat voluptatibus recusandae.\nQuod vitae ratione rerum magnam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 3, 6, 0, 56, 26, 492, DateTimeKind.Unspecified).AddTicks(4940), "http://noah.name", 1L, "et", 24, 1L, "Incidunt quia facere atque totam necessitatibus laborum amet et nulla.\nNisi hic vel.\nCulpa et consequatur blanditiis exercitationem aliquam est expedita.\nAtque quidem ad omnis quia alias sequi voluptatem ea.\nImpedit ducimus vero ad quos voluptatem repellendus." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 2, 8, 13, 49, 32, 438, DateTimeKind.Unspecified).AddTicks(2560), 29, "https://chesley.info", "ratione", 33, 7L, "odit" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 1, 29, 12, 7, 12, 527, DateTimeKind.Unspecified).AddTicks(4140), 20, "https://khalid.com", 3L, "nisi", 31, 1L, 1, "Voluptates ipsam voluptatem hic ea. Quae sit cupiditate. Sed omnis repudiandae et corporis. Eum aut sapiente eaque est. Quis nihil sed deleniti ut occaecati laborum ducimus laudantium inventore." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 4, 19, 4, 54, 3, 44, DateTimeKind.Unspecified).AddTicks(503), 17, "https://demetrius.name", 4L, "impedit", 58, 6L, 0, "Enim impedit unde beatae reprehenderit inventore sit cumque minus. Et veritatis nobis id facere numquam laborum ducimus. Odio sed dolorum suscipit laborum necessitatibus quasi. Minus fuga et et aliquid omnis id voluptatem blanditiis ducimus." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 7, 10, 3, 55, 10, 918, DateTimeKind.Unspecified).AddTicks(9662), 15, "https://roxane.biz", 5L, "aperiam", 51, 6L, 1, "Voluptatum distinctio sint sed reprehenderit.\nEt tempora delectus ea quisquam placeat est.\nRepellat tempora nisi fugiat.\nTenetur architecto suscipit sunt.\nItaque ut quos.\nFugiat unde sit atque odio porro voluptatem consequatur totam fugit." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 2, 23, 11, 0, 1, 976, DateTimeKind.Unspecified).AddTicks(4487), 19, "http://casimer.org", 3L, "ullam", 6L, 0, "Tempora ipsum esse voluptas in qui et quis fugit vel. Iusto molestiae voluptates at aut aut. Repudiandae eum quia." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 1, 23, 19, 28, 17, 833, DateTimeKind.Unspecified).AddTicks(6880), 17, "http://dominic.com", 1L, "qui", 23, 4L, 1, "Tempore tempore sunt dolorem sequi quos ut. Quia omnis et. Consequatur sit est possimus ex reprehenderit libero ex sit." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2020, 3, 7, 10, 21, 26, 322, DateTimeKind.Unspecified).AddTicks(5348), 7L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 5, 12, 1, 40, 25, 213, DateTimeKind.Unspecified).AddTicks(1636), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 9, 22, 13, 52, 29, 366, DateTimeKind.Unspecified).AddTicks(9257), 6L, 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2020, 7, 4, 8, 59, 8, 777, DateTimeKind.Unspecified).AddTicks(3499), 8L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2021, 5, 6, 20, 8, 55, 149, DateTimeKind.Unspecified).AddTicks(6589), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2020, 10, 20, 2, 52, 59, 637, DateTimeKind.Unspecified).AddTicks(7605), 4L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 12, 3, 2, 24, 43, 176, DateTimeKind.Unspecified).AddTicks(2973), 4L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 1, 17, 18, 14, 18, 608, DateTimeKind.Unspecified).AddTicks(9938), 4L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2020, 3, 1, 6, 13, 38, 244, DateTimeKind.Unspecified).AddTicks(8178), 3L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2019, 12, 13, 20, 36, 27, 932, DateTimeKind.Unspecified).AddTicks(2582), 5L, 7L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3293), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 16, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3111), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3486), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 16, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3474), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3517), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 16, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3508), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3544), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 16, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3536), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3571), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 16, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3563), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3599), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 16, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3626), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 16, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3652), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 16, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3643), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3698), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 16, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3689), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3725), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 16, 17, 28, 53, 443, DateTimeKind.Unspecified).AddTicks(3717), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Jonathan51@gmail.comAAAAAAAAAA", new DateTimeOffset(new DateTime(2022, 12, 1, 20, 32, 6, 525, DateTimeKind.Unspecified).AddTicks(4414), new TimeSpan(0, 2, 0, 0, 0)), "Jonathan Shanahan" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Stacy_Hoeger@yahoo.comAAAAAAAA", new DateTimeOffset(new DateTime(2023, 2, 5, 17, 12, 2, 271, DateTimeKind.Unspecified).AddTicks(5923), new TimeSpan(0, 2, 0, 0, 0)), "Stacy Hoeger" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Jamie.Padberg11@hotmail.comAAA", new DateTimeOffset(new DateTime(2023, 5, 16, 1, 34, 49, 326, DateTimeKind.Unspecified).AddTicks(133), new TimeSpan(0, 3, 0, 0, 0)), "Jamie Padberg" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Marc_Quitzon6@gmail.comAAAAAAA", new DateTimeOffset(new DateTime(2022, 9, 12, 7, 53, 9, 194, DateTimeKind.Unspecified).AddTicks(7548), new TimeSpan(0, 3, 0, 0, 0)), "Marc Quitzon" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Willie3@gmail.comAAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2022, 12, 31, 16, 26, 53, 803, DateTimeKind.Unspecified).AddTicks(4472), new TimeSpan(0, 2, 0, 0, 0)), "Willie Dare" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Carlton.McKenzie@yahoo.comAAAA", new DateTimeOffset(new DateTime(2023, 6, 19, 4, 27, 51, 781, DateTimeKind.Unspecified).AddTicks(4970), new TimeSpan(0, 3, 0, 0, 0)), "Carlton McKenzie" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Sonja99@yahoo.comAAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2022, 9, 13, 19, 29, 38, 783, DateTimeKind.Unspecified).AddTicks(873), new TimeSpan(0, 3, 0, 0, 0)), "Sonja Fritsch" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Barry98@hotmail.comAAAAAAAAAAA", new DateTimeOffset(new DateTime(2022, 10, 16, 17, 3, 25, 787, DateTimeKind.Unspecified).AddTicks(3779), new TimeSpan(0, 3, 0, 0, 0)), "Barry Breitenberg" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Sidney31@gmail.comAAAAAAAAAAAA", new DateTimeOffset(new DateTime(2023, 4, 4, 12, 26, 37, 659, DateTimeKind.Unspecified).AddTicks(9643), new TimeSpan(0, 3, 0, 0, 0)), "Sidney Harvey" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Joan.Gerhold5@yahoo.comAAAAAAA", new DateTimeOffset(new DateTime(2023, 4, 7, 3, 19, 15, 979, DateTimeKind.Unspecified).AddTicks(3014), new TimeSpan(0, 3, 0, 0, 0)), "Joan Gerhold" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 4, 10, 20, 49, 0, 141, DateTimeKind.Unspecified).AddTicks(2233), 2L, "Quibusdam rerum ea eum sint illo maiores aut. Fugi", 53, 1L, "dignissimos", new DateTimeOffset(new DateTime(2023, 5, 24, 22, 21, 22, 1, DateTimeKind.Unspecified).AddTicks(8125), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 15, 16, 3, 38, 396, DateTimeKind.Unspecified).AddTicks(3342), 2L, "rem", 51, 2L, "ab", new DateTimeOffset(new DateTime(2023, 6, 14, 19, 51, 31, 900, DateTimeKind.Unspecified).AddTicks(1365), new TimeSpan(0, 3, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 7, 4, 50, 27, 501, DateTimeKind.Unspecified).AddTicks(4387), "Voluptatibus quo aliquam sit exercitationem volupt", 42, 4L, "corrupti", new DateTimeOffset(new DateTime(2022, 9, 12, 8, 36, 26, 810, DateTimeKind.Unspecified).AddTicks(6165), new TimeSpan(0, 3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 7, 4, 4, 17, 53, 381, DateTimeKind.Unspecified).AddTicks(3355), 7L, 29, 5L, "cupiditate", new DateTimeOffset(new DateTime(2023, 1, 13, 11, 5, 28, 749, DateTimeKind.Unspecified).AddTicks(7499), new TimeSpan(0, 2, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 9, 4, 45, 19, 893, DateTimeKind.Unspecified).AddTicks(9831), 2L, "Vel fuga in quas illum incidunt minus.", 31, 4L, "id", new DateTimeOffset(new DateTime(2022, 8, 20, 1, 48, 41, 392, DateTimeKind.Unspecified).AddTicks(136), new TimeSpan(0, 3, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 1, 12, 34, 32, 225, DateTimeKind.Unspecified).AddTicks(687), 1L, "Perferendis qui ut. Veniam reiciendis ut ratione e", 23, "dolorem", new DateTimeOffset(new DateTime(2022, 8, 23, 13, 0, 50, 314, DateTimeKind.Unspecified).AddTicks(8829), new TimeSpan(0, 3, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 8, 23, 40, 22, 60, DateTimeKind.Unspecified).AddTicks(6989), 2L, "deserunt", 30, 2L, "a", new DateTimeOffset(new DateTime(2023, 7, 9, 8, 22, 0, 55, DateTimeKind.Unspecified).AddTicks(9957), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 6, 12, 14, 25, 19, 64, DateTimeKind.Unspecified).AddTicks(6999), "Illo nesciunt quisquam ad rem et autem.", 41, "dolores", new DateTimeOffset(new DateTime(2022, 12, 31, 11, 10, 59, 364, DateTimeKind.Unspecified).AddTicks(6559), new TimeSpan(0, 2, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 6, 18, 7, 35, 1, 893, DateTimeKind.Unspecified).AddTicks(1054), 10L, "Sint ab illo et repudiandae et.", 56, 2L, "similique", new DateTimeOffset(new DateTime(2022, 9, 11, 13, 1, 18, 15, DateTimeKind.Unspecified).AddTicks(3746), new TimeSpan(0, 3, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 17, 18, 18, 46, 705, DateTimeKind.Unspecified).AddTicks(7873), 7L, "Sed et quia ad rerum. Maiores mollitia aspernatur", 54, 2L, "ut", new DateTimeOffset(new DateTime(2023, 7, 3, 6, 13, 54, 827, DateTimeKind.Unspecified).AddTicks(746), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "accusamusAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Text",
                value: "Aut sed quia quia illum illum. Nobis illum dicta veniam voluptas aut ipsam dolorum. Dolor atque nihil et quo quis quisquam officiis saepe ex.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Incidunt aliquid modi vel aut voluptas porro voluptatibus ducimus neque.\nMollitia molestias laudantium veritatis voluptatem quidem qui.\nQuod id reiciendis doloribus iusto vitae aut nihil.\nVoluptatem voluptatum est quia aperiam est voluptas.\nPorro et quae itaque reprehenderit sint voluptas et qui." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Eius eaque ut.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Harum et blanditiis consequuntur beatae iusto nihil sunt illo est. Autem non praesentium. Veritatis molestiae modi debitis non est praesentium sapiente consectetur. Corporis sunt ducimus. Accusamus repudiandae quia rerum officia quo cupiditate et nemo commodi." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Impedit et necessitatibus veniam et ipsa sed. Ipsum consequatur ipsam quod vel ut ut accusamus. Ut reiciendis in quos vel nam illum. Et fuga rem fugiat eligendi." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Qui quia ullam aut. Quas corporis pariatur nostrum est voluptatum est saepe doloremque sequi. Totam necessitatibus repellat id dolorum quod ut accusamus. Libero non laudantium et iste consequatur. Voluptates possimus magnam." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Ex ullam quas qui non odit veritatis voluptas et quae. Cumque aspernatur sed. Sint ipsum pariatur ab sit quod facere molestiae maiores laudantium." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "adAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Text",
                value: "velitAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

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
                value: 4);

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
                value: 6);

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
                value: 9);

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
                value: 10);

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

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
                column: "Status",
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
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "ut", "Hickle Group", "https://ada.net", "Europe/St" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Aspernatur magni dolores.", "Daugherty - Monahan", "http://wallace.info", "America/H" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Omnis odio provident voluptate.\nDolorem dolor impedit.\nQuos doloremque nulla eaque modi vitae unde distinctio ipsa laboriosam.\nVitae similique dolor sit soluta pariatur.\nMolestiae quis sapiente molestias.\nTemporibus eveniet dolor error praesentium ut enim.", "Cartwright LLC", "http://caden.info", "Asia/Bagh" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Aspernatur quis omnis hic voluptatem cumque.\nNobis qui ducimus sequi est quidem eos eos.\nRecusandae perspiciatis vitae.", "Watsica Inc", "http://nathaniel.info", "Africa/Mo" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "possimus", "Boyle, Bauch and Hoeger", "http://michaela.com", "Africa/Jo" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Tempore magnam reprehenderit sed est provident non. Eum accusantium ullam rerum aut qui. Molestiae perferendis sit nisi quam suscipit aut accusamus distinctio enim. Sed molestias aut magni quia nulla et et cupiditate. Culpa debitis eius aut qui.", "Keeling Group", "http://jamel.net", "America/G" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Velit et aperiam nulla.", "Skiles and Sons", "https://tiara.net", "Europe/Mo" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "voluptatem", "Durgan, Grant and Brakus", "https://barrett.name", "Asia/Toky" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Aut molestias rerum quam. Suscipit corporis eligendi fugit similique sit animi facilis aliquid. Veritatis occaecati pariatur eius aliquid pariatur aut.", "Champlin - Swaniawski", "https://jason.com", "Asia/Rang" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Repellendus inventore rerum aliquid amet pariatur non eius.", "West LLC", "https://winfield.net", "America/M" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Christine_Emmerich@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/410.jpg", "Christine Emmerich", "1-265-694-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Dolores_Gibson74@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1143.jpg", "Dolores Gibson", "(966) 412-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Jaime.Kozey64@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/642.jpg", "Jaime Kozey", "552-769-95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Mae.Altenwerth23@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/922.jpg", "Mae Altenwerth", "924-604-35" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "John57@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/795.jpg", "John Windler", "1-283-657-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Jon.Buckridge56@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1008.jpg", "Jon Buckridge", "478-957-25", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Marc.Lehner30@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1111.jpg", "Marc Lehner", "742.897.06", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Laurie.Fritsch@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/153.jpg", "Laurie Fritsch", "976.656.58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Terrance.McClure45@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/145.jpg", "Terrance McClure", "952.699.63", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Bryant61@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/201.jpg", "Bryant Paucek", "1-780-917-", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 2, 6, 1, 5, 5 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 8, 6, 1, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 8, 21, 1, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 1, 10, 3, 5, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 8, 11, 7, 4, 12 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 6, 8, 3, 2, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings" },
                values: new object[] { 3, 7, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 4, 30, 8, 3, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 1, 27, 4, 5, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 6, 30, 4, 4, 1 });

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
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 5, 5, 19, 3, 31, 65, DateTimeKind.Unspecified).AddTicks(2180), 24, "https://mckenna.net", 2L, "commodi", 53, 4L, "tenetur" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 10, 13, 14, 32, 14, 370, DateTimeKind.Unspecified).AddTicks(2793), 20, "https://katrine.name", "facilis", 38, 3L, "Dolorum rerum tenetur quia.\nAut tempore tempora odio natus laudantium nobis at qui.\nTempore aut aut.\nVoluptas vitae deleniti est qui." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 1, 31, 17, 41, 39, 893, DateTimeKind.Unspecified).AddTicks(7252), "https://betsy.info", 2L, "qui", 53, 2L, "Illum fugiat debitis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 12, 17, 0, 22, 28, 823, DateTimeKind.Unspecified).AddTicks(5306), 16, "http://judson.com", "et", 23, 4L, "Sed rerum alias voluptatem quia facere facere praesentium." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 12, 22, 17, 28, 3, 995, DateTimeKind.Unspecified).AddTicks(5777), 24, "https://quinten.net", 4L, "modi", 36, 10L, 0, "et" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 9, 13, 10, 48, 43, 65, DateTimeKind.Unspecified).AddTicks(641), 19, "https://bridgette.info", 1L, "atque", 52, 5L, 1, "Quos fugiat hic consequatur ratione voluptatum sed. Commodi porro ipsum eaque voluptatem eaque in. Voluptate aliquam recusandae. Dolores omnis saepe aliquam et iusto maxime asperiores a. Aut eveniet distinctio." });

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
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2019, 12, 9, 5, 12, 42, 385, DateTimeKind.Unspecified).AddTicks(6336), 26, "http://catharine.name", 1L, "et", 2L, 1, "Temporibus qui ut placeat. Maiores quo omnis quos similique labore qui velit. Dolores corporis qui omnis dolores voluptatem natus assumenda voluptas. Et distinctio velit et optio omnis iure vel quia. Asperiores esse similique eligendi exercitationem vel vel voluptas est repudiandae." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 11, 8, 9, 18, 33, 851, DateTimeKind.Unspecified).AddTicks(727), 22, "http://wilma.info", 3L, "eligendi", 60, 6L, 0, "Qui dolor repellendus omnis vitae. Ut distinctio corporis aut. Quaerat autem eos. Non assumenda enim nihil dignissimos facilis quos. Et nihil minus quae autem perspiciatis consectetur." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2019, 7, 21, 14, 57, 22, 712, DateTimeKind.Unspecified).AddTicks(7752), 3L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2019, 12, 3, 20, 45, 34, 822, DateTimeKind.Unspecified).AddTicks(8008), 9L });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2021, 1, 18, 16, 59, 30, 447, DateTimeKind.Unspecified).AddTicks(6239), 9L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2019, 10, 18, 0, 46, 42, 63, DateTimeKind.Unspecified).AddTicks(1233), 6L });

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
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1910), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 16, 14, 54, 24, 435, DateTimeKind.Unspecified).AddTicks(1903), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Beatrice80@hotmail.comAAAAAAAA", new DateTimeOffset(new DateTime(2022, 11, 30, 13, 58, 35, 967, DateTimeKind.Unspecified).AddTicks(2122), new TimeSpan(0, 2, 0, 0, 0)), "Beatrice Grant" });

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
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 8, 13, 8, 6, 6, 119, DateTimeKind.Unspecified).AddTicks(8809), "ut", 10, 3L, "maiores", new DateTimeOffset(new DateTime(2022, 12, 4, 0, 5, 18, 548, DateTimeKind.Unspecified).AddTicks(474), new TimeSpan(0, 2, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 28, 15, 16, 50, 163, DateTimeKind.Unspecified).AddTicks(4559), 3L, 50, 3L, "dicta", new DateTimeOffset(new DateTime(2023, 2, 4, 19, 50, 23, 705, DateTimeKind.Unspecified).AddTicks(3759), new TimeSpan(0, 2, 0, 0, 0)), 5L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 16, 10, 47, 58, 433, DateTimeKind.Unspecified).AddTicks(4043), 5L, "dolores", 41, "dicta", new DateTimeOffset(new DateTime(2023, 5, 21, 14, 22, 14, 257, DateTimeKind.Unspecified).AddTicks(5347), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 5, 16, 13, 36, 6, 350, DateTimeKind.Unspecified).AddTicks(9519), 8L, "Qui consequatur ut sit corporis accusantium volupt", 38, 5L, "rerum", new DateTimeOffset(new DateTime(2022, 12, 13, 3, 8, 32, 437, DateTimeKind.Unspecified).AddTicks(7577), new TimeSpan(0, 2, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 7, 24, 16, 16, 24, 583, DateTimeKind.Unspecified).AddTicks(8879), "Voluptas quia non nulla aspernatur eum.", 57, "dignissimos", new DateTimeOffset(new DateTime(2022, 10, 21, 7, 26, 1, 663, DateTimeKind.Unspecified).AddTicks(3177), new TimeSpan(0, 3, 0, 0, 0)), 10L });

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
                column: "Text",
                value: "Recusandae rerum aspernatur optio.\nQuis est pariatur vero dignissimos.\nEst repudiandae tempora et libero amet.\nQuia expedita voluptatem tenetur qui enim qui.\nIure exercitationem dolorem id beatae fuga.\nEt molestiae sapiente enim.");

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
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Quae sunt velit tenetur molestiae.\nNecessitatibus aliquam itaque velit ea porro sed accusamus neque.\nAccusantium quia voluptatem vitae accusamus qui et necessitatibus in.\nIn sit id.\nQuis iste suscipit itaque omnis sed nostrum delectus omnis dolor." });

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
                column: "Text",
                value: "Qui nam facilis recusandae esse ea voluptatem repudiandae libero animi.");

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
                keyValue: 5L,
                column: "Priority",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Priority",
                value: 8);

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

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
                column: "Status",
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
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

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
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Sam32@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/710.jpg", "Sam Kemmer", "813.666.32", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Roberto99@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/7.jpg", "Roberto Dooley", "1-259-855-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Fred.Paucek35@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/521.jpg", "Fred Paucek", "1-640-543-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Eric69@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/117.jpg", "Eric Mosciski", "1-714-512-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Erma.Braun68@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/703.jpg", "Erma Braun", "1-225-938-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Bobby.Hyatt24@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/533.jpg", "Bobby Hyatt", "(420) 617-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Mitchell_Schamberger27@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1076.jpg", "Mitchell Schamberger", "1-437-406-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Lucille17@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1179.jpg", "Lucille Hegmann", "959.651.14", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Kristine.Keeling@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/458.jpg", "Kristine Keeling", "(883) 647-", 1 });
        }
    }
}
