using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class AddFieldForPasswordProtection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PasswordProtectionIsUsed",
                table: "AvailabilitySlots",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 7, 30, 1, 14, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 6, 6, 3, 6, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 8, 30, 4, 2, 11, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 3, 11, 8, 2, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "StartDate" },
                values: new object[] { 3, 7, 28, 6, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 5, 1, 5, 14, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "StartDate" },
                values: new object[] { 2, 1, 3, 5, 3, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 7, 8, 1, 7, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Color", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 4, 13, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 3, 3, 2, 14, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2019, 8, 4, 22, 43, 4, 419, DateTimeKind.Unspecified).AddTicks(2216), 23, "http://genesis.name", 4L, "iste", 41, 5L, 0, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "officiis" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 5, 22, 10, 13, 20, 947, DateTimeKind.Unspecified).AddTicks(3731), 20, "https://ramona.org", 5L, "temporibus", 29, 8L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Laudantium omnis beatae aut est vel nihil occaecati voluptates. Ratione repudiandae exercitationem. Minus facilis quasi sequi consequatur blanditiis sunt omnis rerum porro." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 2, 1, 13, 53, 4, 376, DateTimeKind.Unspecified).AddTicks(2838), 17, "https://demarco.biz", "totam", 55, 0, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "nam" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2021, 1, 2, 16, 6, 47, 218, DateTimeKind.Unspecified).AddTicks(7758), 21, "http://teresa.com", 1L, "libero", 22, 1L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "nemo" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 1, 19, 3, 45, 19, 905, DateTimeKind.Unspecified).AddTicks(3858), 29, "https://jayson.name", 4L, "magni", 29, 4L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Ut sunt velit a. Iure atque nesciunt. Id molestiae ab omnis distinctio a nisi omnis recusandae. Non iste officiis illo dolores molestiae earum eos est reiciendis. Vel minus eligendi." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 11, 30, 3, 59, 38, 245, DateTimeKind.Unspecified).AddTicks(8534), 21, "http://johnny.info", 5L, "cupiditate", 36, 9L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "A nihil sapiente quis assumenda incidunt. Aut praesentium mollitia. Ratione similique minus quia." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2019, 12, 23, 11, 28, 42, 719, DateTimeKind.Unspecified).AddTicks(2607), 30, "http://lesley.info", "dolor", 47, 7L, 1, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Ducimus qui aperiam enim. Ea officiis maxime. Deleniti quia ad aut. Fugiat delectus debitis molestias aspernatur. Nostrum nesciunt quisquam ad quisquam delectus." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 10, 15, 3, 35, 58, 803, DateTimeKind.Unspecified).AddTicks(8928), 28, "https://alysha.name", 1L, "enim", 42, 10L, 1, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Porro quia ipsam nostrum quis aperiam quia reiciendis.\nEos quidem quidem.\nNostrum sit et quas voluptatem sint.\nConsequatur aut minus quos corrupti cumque maiores id.\nVoluptate vel voluptatum reiciendis vero id quibusdam quis qui pariatur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 4, 23, 20, 47, 50, 369, DateTimeKind.Unspecified).AddTicks(7770), "http://calista.org", 1L, "accusamus", 27, 8L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Alias repellendus sequi ut ut sint.\nLaborum aut explicabo rerum impedit veniam id incidunt." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 12, 19, 1, 14, 23, 555, DateTimeKind.Unspecified).AddTicks(1075), 29, "https://seth.org", 1L, "qui", 30, 5L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "A minus error ipsam. Aspernatur voluptatem aut ea pariatur quod. Aut et facere aut et dolorum repellendus. Non maxime voluptatem earum qui. Culpa optio voluptatem tempora sint eos nemo." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 11, 8, 13, 2, 15, 376, DateTimeKind.Unspecified).AddTicks(6182), 5L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 12, 3, 22, 39, 46, 879, DateTimeKind.Unspecified).AddTicks(343), 9L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2019, 9, 16, 21, 16, 27, 409, DateTimeKind.Unspecified).AddTicks(2531), 9L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 12, 13, 0, 40, 44, 260, DateTimeKind.Unspecified).AddTicks(709), new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2021, 5, 31, 5, 17, 54, 329, DateTimeKind.Unspecified).AddTicks(8612), 6L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 7, 15, 13, 5, 42, 5, DateTimeKind.Unspecified).AddTicks(6910), 7L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 2, 28, 15, 28, 34, 943, DateTimeKind.Unspecified).AddTicks(2372), 7L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 8, 6, 17, 50, 7, 929, DateTimeKind.Unspecified).AddTicks(4079), new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2021, 2, 25, 23, 42, 19, 617, DateTimeKind.Unspecified).AddTicks(7407), 10L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2021, 7, 10, 11, 37, 7, 127, DateTimeKind.Unspecified).AddTicks(6415), 3L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(7681), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 18, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(7513), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Hannah.Vandervort39@hotmail.c", new DateTimeOffset(new DateTime(2023, 7, 22, 17, 4, 31, 833, DateTimeKind.Unspecified).AddTicks(947), new TimeSpan(0, 3, 0, 0, 0)), "Hannah Vandervort" });

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

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 3, 11, 36, 36, 869, DateTimeKind.Unspecified).AddTicks(6739), 7L, "Et non impedit eaque repellendus.\nAutem nobis nobi", 49, 5L, "tenetur", new DateTimeOffset(new DateTime(2023, 3, 15, 7, 42, 40, 985, DateTimeKind.Unspecified).AddTicks(3680), new TimeSpan(0, 2, 0, 0, 0)), 5L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 4, 5, 5, 41, 12, 556, DateTimeKind.Unspecified).AddTicks(8538), 10L, "animi", 28, 4L, "eum", new DateTimeOffset(new DateTime(2023, 2, 16, 6, 45, 45, 748, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, 2, 0, 0, 0)), 1L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 12, 9, 15, 4, 39, 482, DateTimeKind.Unspecified).AddTicks(9178), 9L, "Commodi unde perferendis ducimus modi nihil rerum", 26, "inventore", new DateTimeOffset(new DateTime(2023, 4, 4, 0, 13, 51, 485, DateTimeKind.Unspecified).AddTicks(9697), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 24, 16, 9, 35, 494, DateTimeKind.Unspecified).AddTicks(9409), 2L, "Sit facere expedita eaque accusamus molestias id e", 41, 4L, "sed", new DateTimeOffset(new DateTime(2023, 2, 15, 17, 42, 46, 416, DateTimeKind.Unspecified).AddTicks(7511), new TimeSpan(0, 2, 0, 0, 0)), 8L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 12, 25, 16, 18, 12, 62, DateTimeKind.Unspecified).AddTicks(6991), 6L, "Dolorum dolorum architecto et voluptas nostrum qui", 34, 1L, "ipsam", new DateTimeOffset(new DateTime(2022, 11, 6, 10, 40, 23, 93, DateTimeKind.Unspecified).AddTicks(8445), new TimeSpan(0, 2, 0, 0, 0)), 10L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 23, 4, 21, 3, 828, DateTimeKind.Unspecified).AddTicks(3973), "Labore est fugit quos dolorum sed quia iusto quod.", 27, 2L, "et", new DateTimeOffset(new DateTime(2022, 12, 18, 11, 12, 54, 355, DateTimeKind.Unspecified).AddTicks(8028), new TimeSpan(0, 2, 0, 0, 0)), 2L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 18, 13, 21, 5, 676, DateTimeKind.Unspecified).AddTicks(4428), 9L, "ut", 19, 5L, "mollitia", new DateTimeOffset(new DateTime(2023, 4, 18, 2, 36, 18, 746, DateTimeKind.Unspecified).AddTicks(7211), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 11, 12, 3, 39, 42, 658, DateTimeKind.Unspecified).AddTicks(5909), 2L, "Omnis eaque sapiente nisi alias dolore.", 39, 2L, "ex", new DateTimeOffset(new DateTime(2022, 9, 9, 13, 3, 37, 353, DateTimeKind.Unspecified).AddTicks(1458), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 10, 5, 50, 28, 861, DateTimeKind.Unspecified).AddTicks(2539), 9L, "Pariatur autem quidem quia similique amet voluptat", 47, 4L, "explicabo", new DateTimeOffset(new DateTime(2023, 7, 8, 9, 0, 17, 833, DateTimeKind.Unspecified).AddTicks(8287), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 9, 25, 14, 28, 41, 735, DateTimeKind.Unspecified).AddTicks(458), 7L, "odio", 12, 2L, "sunt", new DateTimeOffset(new DateTime(2022, 12, 11, 3, 41, 32, 352, DateTimeKind.Unspecified).AddTicks(1878), new TimeSpan(0, 2, 0, 0, 0)), 8L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Ipsum qui sit. Illum voluptas molestiae fugit sapiente qui voluptatem. Sit ea quasi amet aut." });

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
                column: "Text",
                value: "Impedit repellat omnis atque praesentium dolorem rerum maiores minus. Et amet aperiam cum eum eaque quaerat ad. Impedit eos quis quae voluptatem dolor eligendi.");

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
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

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
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Sherri_Goodwin@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/13.jpg", "Sherri Goodwin", "311-956-45", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Dennis72@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/980.jpg", "Dennis Yundt", "(387) 827-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Ronald21@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/654.jpg", "Ronald Herzog", "256.553.77", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "James_Lebsack@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/792.jpg", "James Lebsack", "612.275.79", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Rebecca.Sanford@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/47.jpg", "Rebecca Sanford", "888.482.76" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Jacob_Labadie24@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/249.jpg", "Jacob Labadie", "1-770-707-" });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Myron.Mills55@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/32.jpg", "Myron Mills", "1-402-525-" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordProtectionIsUsed",
                table: "AvailabilitySlots");

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
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 8, 24, 5, 5, 13, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 5, 22, 8, 4, 3, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 2, 15, 6, 13, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "StartDate" },
                values: new object[] { 2, 6, 15, 8, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 1, 9, 10, 10, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "StartDate" },
                values: new object[] { 1, 2, 23, 8, 4, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 1, 6, 4, 6, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Color", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 4, 9, 11, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 7, 1, 3, 2, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 10, 20, 4, 18, 42, 206, DateTimeKind.Unspecified).AddTicks(1391), 19, "https://akeem.com", 3L, "magnam", 31, 4L, 1, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "id" });

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
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 11, 29, 3, 37, 7, 284, DateTimeKind.Unspecified).AddTicks(3466), 25, "http://ruthe.org", "et", 19, 1, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Vel velit sit ea molestiae laudantium distinctio itaque pariatur.\nQuod officiis et sunt aliquid.\nEos debitis ut libero non repudiandae consequatur.\nNemo tenetur illo perspiciatis possimus officia aperiam.\nPossimus commodi et modi voluptatem quibusdam earum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 3, 26, 23, 31, 48, 208, DateTimeKind.Unspecified).AddTicks(2056), 16, "http://dovie.name", 2L, "provident", 45, 9L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Tempora ducimus veritatis unde debitis molestias aut. Quo praesentium vel optio enim. Consectetur et ea tempora itaque molestias est odit labore. Voluptatem sed natus occaecati molestiae deleniti et unde. Aut itaque vel repellendus. Et corporis suscipit hic ut consequatur dolore mollitia." });

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
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 1, 14, 12, 14, 47, 359, DateTimeKind.Unspecified).AddTicks(1810), 17, "http://bernie.com", 4L, "ex", 35, 4L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Non quia tempore voluptatibus dolorum nesciunt atque officiis sunt. Minima possimus quod corrupti aut non. Assumenda doloremque laudantium accusamus eum quia." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 10, 3, 5, 28, 33, 955, DateTimeKind.Unspecified).AddTicks(5449), 18, "https://alexandrine.org", "asperiores", 52, 4L, 0, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Nihil illo nesciunt in.\nConsequuntur asperiores assumenda itaque porro iusto et voluptatem.\nOmnis quasi molestiae autem cum vel voluptatibus velit.\nDolores omnis aperiam maxime qui qui odio praesentium repellendus vel.\nEt quam dicta optio." });

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
                columns: new[] { "CreatedAt", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 8, 13, 21, 22, 1, 797, DateTimeKind.Unspecified).AddTicks(6814), "https://brady.net", 2L, "enim", 32, 6L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Sed recusandae perspiciatis possimus necessitatibus deserunt doloremque." });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2019, 8, 1, 12, 56, 24, 93, DateTimeKind.Unspecified).AddTicks(7337), new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 7, 12, 21, 27, 57, 541, DateTimeKind.Unspecified).AddTicks(1541), 4L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2021, 5, 12, 18, 20, 14, 193, DateTimeKind.Unspecified).AddTicks(853), 5L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 2L });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 9, 4, 20, 15, 0, 112, DateTimeKind.Unspecified).AddTicks(6397), new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2020, 1, 11, 22, 15, 29, 592, DateTimeKind.Unspecified).AddTicks(9733), 9L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 4, 17, 13, 17, 33, 94, DateTimeKind.Unspecified).AddTicks(8891), 8L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 9L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 18, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(8171), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 17, 10, 6, 57, 215, DateTimeKind.Unspecified).AddTicks(7981), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 31, 8, 7, 50, 109, DateTimeKind.Unspecified).AddTicks(310), 6L, "Voluptas molestiae tempora officiis impedit.", 43, 2L, "quia", new DateTimeOffset(new DateTime(2022, 9, 21, 4, 55, 39, 565, DateTimeKind.Unspecified).AddTicks(8878), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 17, 8, 41, 19, 813, DateTimeKind.Unspecified).AddTicks(3289), 2L, "Quam nesciunt quis vel. Consequatur aspernatur qui", 35, "facere", new DateTimeOffset(new DateTime(2022, 12, 7, 17, 1, 21, 365, DateTimeKind.Unspecified).AddTicks(5499), new TimeSpan(0, 2, 0, 0, 0)), 7L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 6, 5, 33, 22, 513, DateTimeKind.Unspecified).AddTicks(5024), 5L, "Quia ut sunt dolores quae nesciunt recusandae eum", 37, 4L, "atque", new DateTimeOffset(new DateTime(2023, 3, 30, 15, 43, 30, 316, DateTimeKind.Unspecified).AddTicks(9070), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 3, 10, 6, 47, 59, 69, DateTimeKind.Unspecified).AddTicks(8732), "Aspernatur aspernatur velit labore enim voluptatem", 29, 4L, "eos", new DateTimeOffset(new DateTime(2023, 6, 14, 21, 55, 35, 771, DateTimeKind.Unspecified).AddTicks(4004), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 5, 22, 2, 28, 258, DateTimeKind.Unspecified).AddTicks(4103), 3L, "Autem officiis occaecati voluptates. Illo repellen", 16, 3L, "aut", new DateTimeOffset(new DateTime(2023, 2, 18, 15, 3, 36, 109, DateTimeKind.Unspecified).AddTicks(9580), new TimeSpan(0, 2, 0, 0, 0)), 4L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 12, 12, 31, 58, 460, DateTimeKind.Unspecified).AddTicks(599), 6L, "Vitae mollitia doloribus ipsa dolor cum blanditiis", 54, 5L, "temporibus", new DateTimeOffset(new DateTime(2023, 5, 14, 16, 30, 44, 1, DateTimeKind.Unspecified).AddTicks(6066), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

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
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Seth_Ullrich@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/764.jpg", "Seth Ullrich", "740.582.42", 1 });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Cesar18@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1152.jpg", "Cesar Rosenbaum", "645.236.79", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Forrest_Kerluke@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/372.jpg", "Forrest Kerluke", "(245) 379-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Sophia_Rohan92@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/390.jpg", "Sophia Rohan", "948-323-40" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Blanche_Kling65@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1094.jpg", "Blanche Kling", "985-600-56" });

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
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Jody.Heidenreich@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/380.jpg", "Jody Heidenreich", "1-947-874-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Bernice.Dicki@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1019.jpg", "Bernice Dicki", "(712) 768-", 1 });
        }
    }
}
