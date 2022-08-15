using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class ChangedSlotRelationshipAndDeleteRules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailabilitySlots_AdvancedSlotSettings_AdvancedSlotSettingsId",
                table: "AvailabilitySlots");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_AvailabilitySlots_AvailabilitySlotId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_AvailabilitySlots_AdvancedSlotSettingsId",
                table: "AvailabilitySlots");

            migrationBuilder.DropColumn(
                name: "AdvancedSlotSettingsId",
                table: "AvailabilitySlots");

            migrationBuilder.AddColumn<long>(
                name: "AvailabilitySlotId",
                table: "AdvancedSlotSettings",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 1L, 7, 18, 5, 5, 12 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 2L, 8, 22, 8, 3, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 3L, 7, 25, 3, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 4L, 7, 20, 1, 3, 5 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 5L, 8, 7, 6, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 6L, 25, 3, 2, 15 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 7L, 1, 24, 3, 4, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 8L, 3, 9, 9, 1, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "AvailabilitySlotId", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 9L, 2, 26, 3, 4, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 10L, 12, 9, 2, 5 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 1, 8, 21, 29, 32, 539, DateTimeKind.Unspecified).AddTicks(5498), 27, "https://clementine.org", 3L, "omnis", 30, 0, "Sunt quidem omnis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 8, 20, 11, 30, 44, 40, DateTimeKind.Unspecified).AddTicks(5940), 23, "http://nicolas.org", 1L, "voluptas", 50, 1L, 1, "Quasi eum doloremque odio quisquam neque laboriosam omnis cum at." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 2, 8, 6, 31, 52, 363, DateTimeKind.Unspecified).AddTicks(1831), 25, "https://aurore.biz", 3L, "magnam", 58, 8L, 0, "Rerum dolores cumque dolores nemo.\nRepudiandae dolorem aspernatur accusamus iste qui enim est.\nQuasi inventore quasi.\nEum optio quod nulla sint pariatur fugit similique dolores esse." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 4, 29, 9, 15, 17, 609, DateTimeKind.Unspecified).AddTicks(832), 23, "http://madisen.biz", 4L, "ullam", 40, 4L, "Ea et nam quos magnam ad. Consequatur qui est est numquam vitae possimus et dolor iste. Quam non libero. Error et delectus possimus voluptate sunt ad nihil qui sed. Eos laudantium repellat dolore aut quia qui eum magni recusandae. Non qui enim eveniet." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 6, 22, 1, 2, 28, 926, DateTimeKind.Unspecified).AddTicks(2530), 28, "http://sheridan.org", 5L, "optio", 48, 10L, "Aut deserunt sit et enim delectus qui mollitia nostrum. Ut ipsa ipsa aliquid animi. Eum iure voluptatem harum. Et enim saepe alias beatae at maiores. Cumque esse est." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 7, 17, 1, 36, 14, 945, DateTimeKind.Unspecified).AddTicks(1663), 17, "https://celia.com", 1L, "laboriosam", 30, 4L, 0, "Aliquid deleniti occaecati eaque nobis aliquam qui accusamus odio. Explicabo accusamus possimus rerum alias at dolore est sit consequatur. Id ut reprehenderit animi. Saepe rem excepturi autem dolore." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 4, 24, 0, 21, 34, 159, DateTimeKind.Unspecified).AddTicks(59), 21, "https://werner.name", 3L, "non", 16, 2L, "Et consectetur quos deleniti mollitia occaecati error ut.\nTotam autem quia minus aut porro.\nAut et cupiditate." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 8, 8, 13, 39, 41, 716, DateTimeKind.Unspecified).AddTicks(5331), 28, "http://aurelie.com", 2L, "ex", 30, 9L, 0, "Voluptas voluptatum libero voluptatem est voluptates fugit reiciendis esse eius.\nPorro quidem nostrum quod.\nSint nesciunt sequi quibusdam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 5, 20, 8, 26, 46, 108, DateTimeKind.Unspecified).AddTicks(6541), 29, "http://chase.com", "voluptatibus", 18, 9L, 1, "Facilis esse harum ut optio. Cumque suscipit et quod quia. Repudiandae suscipit iste eligendi natus repellat. Tenetur eum earum aliquid enim facilis omnis praesentium suscipit amet." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2019, 8, 28, 14, 45, 29, 962, DateTimeKind.Unspecified).AddTicks(5895), 24, "http://kiley.name", "quidem", 18, 1L, 0, "Ipsum consequuntur quas enim. Sint enim quibusdam corporis sed aut sed. Deleniti similique quidem sit est qui sed consequatur vel. Sequi dolore sapiente dignissimos ducimus molestiae. Iure reprehenderit aut quis quo et id ipsam praesentium rem." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 3, 12, 21, 10, 27, 799, DateTimeKind.Unspecified).AddTicks(5632), 1L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2021, 5, 9, 6, 51, 9, 884, DateTimeKind.Unspecified).AddTicks(2366), 4L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 7, 3, 11, 51, 50, 114, DateTimeKind.Unspecified).AddTicks(487), 9L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2020, 9, 8, 20, 38, 28, 12, DateTimeKind.Unspecified).AddTicks(2558), 10L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2020, 4, 13, 6, 20, 39, 949, DateTimeKind.Unspecified).AddTicks(9531), 5L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2019, 11, 24, 0, 42, 17, 841, DateTimeKind.Unspecified).AddTicks(8375), 7L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2021, 3, 23, 15, 44, 28, 553, DateTimeKind.Unspecified).AddTicks(1671), 3L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2021, 2, 6, 6, 49, 2, 818, DateTimeKind.Unspecified).AddTicks(1297), 2L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 7, 27, 17, 53, 14, 710, DateTimeKind.Unspecified).AddTicks(7078), 9L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 3, 14, 5, 17, 13, 383, DateTimeKind.Unspecified).AddTicks(4047), 7L, 6L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7384), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 16, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7248), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7594), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 16, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7578), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7614), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 16, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7609), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7634), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 16, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7628), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7653), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 16, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7647), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7671), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 16, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7665), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7689), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 16, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7683), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7706), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 16, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7701), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7724), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 16, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7719), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7742), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 16, 13, 39, 13, 851, DateTimeKind.Unspecified).AddTicks(7737), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Gwen45@gmail.com", new DateTimeOffset(new DateTime(2023, 7, 22, 6, 30, 53, 637, DateTimeKind.Unspecified).AddTicks(3163), new TimeSpan(0, 3, 0, 0, 0)), "Gwen Hermann" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Ora_DuBuque@yahoo.com", new DateTimeOffset(new DateTime(2023, 6, 10, 9, 42, 48, 372, DateTimeKind.Unspecified).AddTicks(3286), new TimeSpan(0, 3, 0, 0, 0)), "Ora DuBuque" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Cornelius36@yahoo.com", new DateTimeOffset(new DateTime(2022, 11, 16, 7, 20, 28, 353, DateTimeKind.Unspecified).AddTicks(9645), new TimeSpan(0, 2, 0, 0, 0)), "Cornelius Beahan" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Roger26@hotmail.com", new DateTimeOffset(new DateTime(2022, 12, 19, 8, 4, 53, 289, DateTimeKind.Unspecified).AddTicks(2), new TimeSpan(0, 2, 0, 0, 0)), "Roger Russel" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Rogelio_Wunsch@hotmail.com", new DateTimeOffset(new DateTime(2023, 1, 29, 9, 54, 51, 73, DateTimeKind.Unspecified).AddTicks(272), new TimeSpan(0, 2, 0, 0, 0)), "Rogelio Wunsch" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Terrell51@yahoo.com", new DateTimeOffset(new DateTime(2023, 5, 28, 9, 8, 12, 795, DateTimeKind.Unspecified).AddTicks(8026), new TimeSpan(0, 3, 0, 0, 0)), "Terrell Quitzon" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Barbara81@gmail.com", new DateTimeOffset(new DateTime(2022, 12, 3, 22, 24, 23, 275, DateTimeKind.Unspecified).AddTicks(6148), new TimeSpan(0, 2, 0, 0, 0)), "Barbara Reichert" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Brent49@gmail.com", new DateTimeOffset(new DateTime(2022, 10, 13, 9, 33, 49, 778, DateTimeKind.Unspecified).AddTicks(6037), new TimeSpan(0, 3, 0, 0, 0)), "Brent Yundt" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Luz.Hudson@yahoo.com", new DateTimeOffset(new DateTime(2023, 6, 28, 21, 40, 7, 991, DateTimeKind.Unspecified).AddTicks(7103), new TimeSpan(0, 3, 0, 0, 0)), "Luz Hudson" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Rosie_Bahringer@hotmail.com", new DateTimeOffset(new DateTime(2023, 6, 18, 13, 42, 25, 790, DateTimeKind.Unspecified).AddTicks(1399), new TimeSpan(0, 3, 0, 0, 0)), "Rosie Bahringer" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 8, 23, 12, 22, 38, 772, DateTimeKind.Unspecified).AddTicks(273), 10L, "Aut nobis magnam assumenda et.\nCupiditate praesent", 33, 2L, "incidunt", new DateTimeOffset(new DateTime(2022, 8, 30, 17, 33, 16, 444, DateTimeKind.Unspecified).AddTicks(4475), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 7, 22, 0, 9, 51, 306, DateTimeKind.Unspecified).AddTicks(9781), 3L, "Enim sed et provident asperiores consequuntur dele", 47, 2L, "impedit", new DateTimeOffset(new DateTime(2023, 5, 22, 9, 43, 30, 193, DateTimeKind.Unspecified).AddTicks(4248), new TimeSpan(0, 3, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 8, 21, 10, 49, 43, 341, DateTimeKind.Unspecified).AddTicks(8924), 5L, "corporis", 45, 3L, "sed", new DateTimeOffset(new DateTime(2023, 2, 15, 22, 3, 18, 841, DateTimeKind.Unspecified).AddTicks(9285), new TimeSpan(0, 2, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2019, 11, 4, 7, 6, 43, 238, DateTimeKind.Unspecified).AddTicks(4040), 7L, "Mollitia et quia laudantium numquam voluptatem vol", 27, 3L, "perspiciatis", new DateTimeOffset(new DateTime(2022, 11, 5, 15, 48, 3, 288, DateTimeKind.Unspecified).AddTicks(9380), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 11, 20, 10, 18, 10, 571, DateTimeKind.Unspecified).AddTicks(2930), 4L, "at", 51, 1L, "officiis", new DateTimeOffset(new DateTime(2023, 1, 17, 20, 59, 54, 79, DateTimeKind.Unspecified).AddTicks(6474), new TimeSpan(0, 2, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 9, 20, 5, 35, 50, 746, DateTimeKind.Unspecified).AddTicks(7286), 8L, "Enim soluta sint est corrupti numquam est eos ea.", 18, "asperiores", new DateTimeOffset(new DateTime(2023, 5, 28, 4, 16, 21, 454, DateTimeKind.Unspecified).AddTicks(207), new TimeSpan(0, 3, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 4, 16, 19, 17, 40, 812, DateTimeKind.Unspecified).AddTicks(3934), 4L, "Laboriosam quia et eaque velit ducimus voluptatum", 18, 2L, "dolorem", new DateTimeOffset(new DateTime(2022, 11, 24, 2, 18, 19, 674, DateTimeKind.Unspecified).AddTicks(8230), new TimeSpan(0, 2, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 4, 10, 5, 26, 26, 870, DateTimeKind.Unspecified).AddTicks(5208), "Et ut non omnis voluptatem nam.", 33, 4L, "facilis", new DateTimeOffset(new DateTime(2023, 3, 11, 20, 19, 11, 961, DateTimeKind.Unspecified).AddTicks(5328), new TimeSpan(0, 2, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 3, 19, 22, 11, 24, 630, DateTimeKind.Unspecified).AddTicks(8965), "Hic repudiandae eos molestiae nam mollitia maiores", 25, 2L, "cupiditate", new DateTimeOffset(new DateTime(2023, 5, 6, 14, 21, 33, 422, DateTimeKind.Unspecified).AddTicks(595), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 8, 19, 21, 45, 16, 924, DateTimeKind.Unspecified).AddTicks(7968), 3L, "Maxime omnis magni non unde recusandae nihil sed.", 44, 1L, "ducimus", new DateTimeOffset(new DateTime(2023, 4, 18, 21, 58, 35, 418, DateTimeKind.Unspecified).AddTicks(5643), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Text",
                value: "Et cum fugiat facere.AAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Nobis aut ea asperiores consequuntur saepe eius.AA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Modi est enim ullam quo aut pariatur labore modi.A" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Vero neque totam cum distinctio. Aut repudiandae omnis. Et et vel consequatur culpa ratione quia." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Aliquid consequuntur quae esse quo aut quia.AAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Est corrupti asperiores dicta ex quidem provident rerum doloremque et. In quam minus repudiandae maiores. Laborum saepe aliquam praesentium provident porro voluptatem nemo. Quia fuga illum quo." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Iure enim laudantium quae dignissimos quasi qui.AA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "laudantiumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Eos aut exercitationem reiciendis dolorem doloremque eum pariatur a et. Aut veritatis eos est voluptate delectus. Magni quasi dolore ducimus laboriosam neque. Labore blanditiis ipsa placeat incidunt voluptate placeat ut error." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "etAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Priority",
                value: 8);

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
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Priority",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Priority",
                value: 3);

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
                value: 9);

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
                values: new object[] { "Ut rerum fugit. Non minus fuga ut. Esse reiciendis voluptas cupiditate ut. Ut rerum sit impedit porro tenetur saepe et fugiat. Cupiditate minus ut asperiores earum sed. Modi et animi voluptate eius aut.", "Renner, Tremblay and Jenkins", "https://lois.name", "Asia/Toky" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Iure pariatur sed ad officiis.\nPossimus facere delectus fugiat odit debitis voluptatum porro in pariatur.\nIpsum similique omnis soluta facere.\nAperiam dolore voluptatem quia.\nIpsum itaque a et esse.\nQui nihil facilis omnis nihil eaque rerum atque sit.", "Bradtke - Abbott", "http://terry.net", "America/S" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Sit asperiores et quidem nobis aut et. Nihil nostrum vel. Ab id est ullam suscipit. Ut suscipit est ratione occaecati et. Dignissimos maiores ut praesentium minima et quibusdam aut iusto doloribus.", "Mueller - Powlowski", "http://cyrus.name", "Asia/Shan" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Accusantium ducimus assumenda voluptatum.", "Schinner LLC", "http://tevin.biz", "Asia/Jaka" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Voluptas doloremque qui.", "Huel - Little", "http://payton.com", "America/B" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Corporis cumque nemo vel.\nPraesentium nulla ea quasi tenetur sed voluptas ea.\nVoluptas voluptatem repellat occaecati ducimus quis rerum.\nQui aspernatur suscipit aliquid exercitationem ut impedit qui.\nVoluptatem aut sequi natus omnis reprehenderit id et illum.", "Bashirian - Treutel", "https://candelario.name", "Asia/Toky" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Facere omnis beatae repellendus sunt fuga ipsa.", "Bradtke and Sons", "http://michale.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Reiciendis exercitationem ad ipsum aut consequatur id enim. Aut recusandae aut ullam quia ut reiciendis. Ut vero asperiores non perspiciatis non perferendis necessitatibus in. Qui provident unde pariatur. Vitae minus qui vitae minima perspiciatis. Consectetur omnis fugiat reiciendis quisquam quo se", "Lindgren Inc", "http://halle.info", "Europe/Ri" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "In et autem dolorem impedit iure sint illum vero. Fugit et nesciunt laudantium. Veniam reprehenderit autem magni.", "Durgan - Heaney", "https://deborah.info", "Europe/Bu" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "eius", "Thiel, Klein and Rogahn", "http://keenan.com", "Pacific/T" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Percy.Carroll@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/728.jpg", "Percy Carroll", "1-449-781-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Chris_Simonis@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1187.jpg", "Chris Simonis", "703.819.22" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Alberta.Abshire@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/427.jpg", "Alberta Abshire", "400-558-59" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Theodore78@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/411.jpg", "Theodore Rempel", "(244) 911-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Gilbert2@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/72.jpg", "Gilbert Collins", "210.203.92" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Heather_Adams@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1142.jpg", "Heather Adams", "1-409-212-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Margarita.Carroll78@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1079.jpg", "Margarita Carroll", "(843) 524-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Floyd.Shanahan@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/819.jpg", "Floyd Shanahan", "887-385-32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Greg_Dooley@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1142.jpg", "Greg Dooley", "212-761-65" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Lydia.Bayer@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/428.jpg", "Lydia Bayer", "(724) 697-" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_AvailabilitySlots_AvailabilitySlotId",
                table: "Questions",
                column: "AvailabilitySlotId",
                principalTable: "AvailabilitySlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedSlotSettings_AvailabilitySlots_AvailabilitySlotId",
                table: "AdvancedSlotSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_AvailabilitySlots_AvailabilitySlotId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_AdvancedSlotSettings_AvailabilitySlotId",
                table: "AdvancedSlotSettings");

            migrationBuilder.DropColumn(
                name: "AvailabilitySlotId",
                table: "AdvancedSlotSettings");

            migrationBuilder.AddColumn<long>(
                name: "AdvancedSlotSettingsId",
                table: "AvailabilitySlots",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 5, 19, 3, 1, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 5, 6, 2, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 2, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 7, 10, 4, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 29, 2, 1, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 5, 25, 1, 1, 14 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 8, 18, 8, 5, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 4, 30, 7, 5, 5 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 4, 10, 1, 9 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AdvancedSlotSettingsId", "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "Type", "WelcomeMessage" },
                values: new object[] { 1L, 4, new DateTime(2020, 8, 21, 0, 32, 4, 504, DateTimeKind.Unspecified).AddTicks(1503), 26, "http://bertha.info", 1L, "consequatur", 39, 1, "Velit saepe officiis tenetur nisi quia at earum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AdvancedSlotSettingsId", "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2L, 3, new DateTime(2021, 5, 1, 6, 25, 7, 495, DateTimeKind.Unspecified).AddTicks(9112), 28, "https://drew.com", 3L, "nisi", 37, 10L, 0, "A quae rerum officiis aut minima vitae nihil et.\nQuis dolorem ut aut officia et consequuntur id." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AdvancedSlotSettingsId", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3L, new DateTime(2020, 2, 5, 7, 45, 21, 719, DateTimeKind.Unspecified).AddTicks(327), 16, "http://athena.net", 4L, "ut", 52, 9L, 1, "Consequatur sunt modi quis eveniet sunt rerum voluptatem a quod. Corrupti enim ad voluptatum dolores aliquam quia quam occaecati. Quam placeat consectetur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AdvancedSlotSettingsId", "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4L, 4, new DateTime(2020, 10, 4, 11, 2, 55, 647, DateTimeKind.Unspecified).AddTicks(5182), 29, "http://marianna.biz", 5L, "et", 20, 9L, "voluptates" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AdvancedSlotSettingsId", "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5L, 1, new DateTime(2021, 7, 10, 10, 45, 47, 535, DateTimeKind.Unspecified).AddTicks(4969), 19, "http://frank.com", 4L, "molestias", 32, 4L, "aut" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AdvancedSlotSettingsId", "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 6L, 1, new DateTime(2021, 7, 6, 11, 46, 55, 522, DateTimeKind.Unspecified).AddTicks(3684), 21, "https://jaquan.biz", 3L, "itaque", 48, 9L, 1, "Sunt consectetur qui accusamus numquam.\nVoluptas sit ratione laboriosam nemo temporibus excepturi et eius.\nIste aliquam culpa dolores vel dignissimos sunt.\nEt esse labore." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AdvancedSlotSettingsId", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 7L, new DateTime(2019, 8, 3, 1, 7, 43, 968, DateTimeKind.Unspecified).AddTicks(6157), 22, "http://garland.net", 5L, "rerum", 55, 9L, "Excepturi soluta autem.\nSed rerum voluptatem." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AdvancedSlotSettingsId", "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 8L, 4, new DateTime(2021, 1, 18, 7, 48, 44, 739, DateTimeKind.Unspecified).AddTicks(738), 20, "https://alden.info", 5L, "mollitia", 36, 4L, 1, "Expedita laudantium quia minus autem a qui commodi vitae." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AdvancedSlotSettingsId", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 9L, new DateTime(2020, 11, 28, 20, 42, 22, 639, DateTimeKind.Unspecified).AddTicks(7216), 26, "http://corene.org", "illo", 39, 5L, 0, "Possimus culpa aperiam ut magnam quo aliquam quisquam officiis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AdvancedSlotSettingsId", "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 10L, 4, new DateTime(2020, 8, 11, 9, 24, 56, 313, DateTimeKind.Unspecified).AddTicks(3053), 16, "http://eryn.info", "molestiae", 58, 7L, 1, "Inventore veniam ut molestiae laborum possimus amet et culpa quae.\nDolorem perferendis est voluptatem et doloribus.\nIusto possimus quidem dicta at." });

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
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2019, 12, 9, 12, 8, 2, 60, DateTimeKind.Unspecified).AddTicks(5001), 7L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 7, 19, 1, 17, 2, 99, DateTimeKind.Unspecified).AddTicks(1048), 5L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2019, 10, 15, 1, 9, 57, 208, DateTimeKind.Unspecified).AddTicks(5372), 2L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2019, 9, 8, 11, 19, 31, 33, DateTimeKind.Unspecified).AddTicks(4977), 5L, 3L });

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
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7292), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 16, 12, 22, 34, 161, DateTimeKind.Unspecified).AddTicks(7290), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Alfred.Runolfsdottir@yahoo.com", new DateTimeOffset(new DateTime(2022, 9, 1, 1, 13, 14, 216, DateTimeKind.Unspecified).AddTicks(8202), new TimeSpan(0, 3, 0, 0, 0)), "Alfred Runolfsdottir" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Sophia.Macejkovic69@gmail.comA", new DateTimeOffset(new DateTime(2023, 1, 13, 6, 27, 12, 104, DateTimeKind.Unspecified).AddTicks(9572), new TimeSpan(0, 3, 0, 0, 0)), "Sophia Macejkovic" });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 3, 12, 18, 11, 49, 581, DateTimeKind.Unspecified).AddTicks(5853), 5L, "Ut amet dolore facere et qui dolorem.\nSunt volupta", 12, "sit", new DateTimeOffset(new DateTime(2022, 10, 20, 10, 11, 53, 891, DateTimeKind.Unspecified).AddTicks(9247), new TimeSpan(0, 3, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 18, 1, 20, 33, 281, DateTimeKind.Unspecified).AddTicks(9777), 10L, "Voluptas dolorem sint.", 43, 5L, "ducimus", new DateTimeOffset(new DateTime(2022, 11, 23, 2, 35, 9, 235, DateTimeKind.Unspecified).AddTicks(9436), new TimeSpan(0, 3, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 30, 23, 22, 56, 562, DateTimeKind.Unspecified).AddTicks(4167), "velit", 49, 5L, "autem", new DateTimeOffset(new DateTime(2023, 6, 27, 5, 39, 41, 585, DateTimeKind.Unspecified).AddTicks(9454), new TimeSpan(0, 3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 11, 5, 2, 14, 730, DateTimeKind.Unspecified).AddTicks(7018), "Perferendis error nemo tempore perspiciatis.\nEnim", 28, 1L, "temporibus", new DateTimeOffset(new DateTime(2023, 1, 16, 8, 18, 6, 115, DateTimeKind.Unspecified).AddTicks(7169), new TimeSpan(0, 3, 0, 0, 0)), 2L });

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
                column: "Text",
                value: "Sint itaque ducimus.\nEt velit voluptatem qui magnam mollitia.\nEst error deleniti.");

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
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Aliquam quia et corporis ullam voluptas molestiae.\nEst iure est.\nOfficiis fugiat quos iste ut voluptas necessitatibus sunt quia.\nEst sint recusandae laboriosam in non autem." });

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
                keyValue: 5L,
                column: "Priority",
                value: 8);

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
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Molestiae sed vel aspernatur sunt qui.\nUt dolorum consequatur aperiam.\nConsequatur nihil molestiae.", "Jones - Windler", "https://chadd.net" });

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
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Dewey.Thiel@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1229.jpg", "Dewey Thiel", "422.765.91" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Lyle55@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/201.jpg", "Lyle Parisian", "(736) 994-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Max52@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1179.jpg", "Max Thompson", "1-876-525-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Tracy_Ziemann37@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/894.jpg", "Tracy Ziemann", "240.233.83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Lowell_Bashirian@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/510.jpg", "Lowell Bashirian", "498.777.22" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Patty.Emard33@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/311.jpg", "Patty Emard", "565-753-66" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Shannon.Rogahn91@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/204.jpg", "Shannon Rogahn", "809-678-54" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Wilfred.Streich@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/684.jpg", "Wilfred Streich", "1-996-452-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Randall_Ankunding@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/441.jpg", "Randall Ankunding", "211-206-32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Joyce.Douglas@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/185.jpg", "Joyce Douglas", "293-220-34" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_AvailabilitySlots_AvailabilitySlotId",
                table: "Questions",
                column: "AvailabilitySlotId",
                principalTable: "AvailabilitySlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
