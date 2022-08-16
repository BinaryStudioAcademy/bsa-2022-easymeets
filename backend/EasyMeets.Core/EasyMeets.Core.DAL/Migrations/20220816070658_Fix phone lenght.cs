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
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 15, 6, 2, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 1, 9, 3, 10, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 2, 23, 8, 4, 4, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 4, 20, 9, 2, 11, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "PaddingMeeting", "StartDate" },
                values: new object[] { 7, 14, 2, new DateTimeOffset(new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 10, 20, 4, 18, 42, 206, DateTimeKind.Unspecified).AddTicks(1391), 19, "https://akeem.com", 3L, "magnam", 31, 4L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "id" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 1, 3, 6, 54, 43, 172, DateTimeKind.Unspecified).AddTicks(9468), 24, "http://avis.com", 1L, "enim", 49, 10L, 1, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Beatae qui odio est nisi ipsam nulla asperiores." });

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
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 3, 26, 23, 31, 48, 208, DateTimeKind.Unspecified).AddTicks(2056), 16, "http://dovie.name", 2L, "provident", 45, 9L, 1, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Tempora ducimus veritatis unde debitis molestias aut. Quo praesentium vel optio enim. Consectetur et ea tempora itaque molestias est odit labore. Voluptatem sed natus occaecati molestiae deleniti et unde. Aut itaque vel repellendus. Et corporis suscipit hic ut consequatur dolore mollitia." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 12, 14, 21, 34, 30, 220, DateTimeKind.Unspecified).AddTicks(1129), 16, "https://berta.com", 5L, "beatae", 15, 6L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Vero error quia consequatur asperiores rem fugit officia sint.\nEt vel soluta voluptatibus nemo.\nSed natus quasi praesentium dolores." });

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
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 10, 3, 5, 28, 33, 955, DateTimeKind.Unspecified).AddTicks(5449), 18, "https://alexandrine.org", 3L, "asperiores", 52, 4L, 0, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Nihil illo nesciunt in.\nConsequuntur asperiores assumenda itaque porro iusto et voluptatem.\nOmnis quasi molestiae autem cum vel voluptatibus velit.\nDolores omnis aperiam maxime qui qui odio praesentium repellendus vel.\nEt quam dicta optio." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2019, 8, 19, 0, 27, 38, 916, DateTimeKind.Unspecified).AddTicks(7202), 16, "http://corine.info", "veritatis", 51, 2L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "modi" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 8, 13, 21, 22, 1, 797, DateTimeKind.Unspecified).AddTicks(6814), 15, "https://brady.net", "enim", 32, 6L, 1, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Sed recusandae perspiciatis possimus necessitatibus deserunt doloremque." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 11, 25, 9, 16, 32, 894, DateTimeKind.Unspecified).AddTicks(8800), 18, "http://bailee.name", 2L, "ut", 49, 1, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Consequatur recusandae magni." });

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
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2019, 8, 1, 12, 56, 24, 93, DateTimeKind.Unspecified).AddTicks(7337), 7L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 2L });

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
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 9, 4, 20, 15, 0, 112, DateTimeKind.Unspecified).AddTicks(6397), 9L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 2L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 4, 17, 13, 17, 33, 94, DateTimeKind.Unspecified).AddTicks(8891), 8L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 9L });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 17, 8, 41, 19, 813, DateTimeKind.Unspecified).AddTicks(3289), 2L, "Quam nesciunt quis vel. Consequatur aspernatur qui", 35, 4L, "facere", new DateTimeOffset(new DateTime(2022, 12, 7, 17, 1, 21, 365, DateTimeKind.Unspecified).AddTicks(5499), new TimeSpan(0, 2, 0, 0, 0)), 7L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 11, 30, 5, 26, 45, 883, DateTimeKind.Unspecified).AddTicks(7562), "Vitae consequatur impedit.", 19, 3L, "est", new DateTimeOffset(new DateTime(2023, 1, 1, 20, 23, 49, 96, DateTimeKind.Unspecified).AddTicks(181), new TimeSpan(0, 2, 0, 0, 0)), 5L, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

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
                column: "Text",
                value: "Consequatur quo porro ut explicabo et sint aperiam. Ut qui neque harum voluptatem necessitatibus. Rerum repellat occaecati voluptatem laboriosam nostrum illo.");

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
                keyValue: 5L,
                column: "Priority",
                value: 1);

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
                column: "Role",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
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
                column: "Status",
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
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

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
                column: "Role",
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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Seth_Ullrich@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/764.jpg", "Seth Ullrich", "740.582.42" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Tommie.McCullough@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1043.jpg", "Tommie McCullough", "632-746-39", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Karl.Swaniawski44@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/48.jpg", "Karl Swaniawski", "(779) 420-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Cesar18@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1152.jpg", "Cesar Rosenbaum", "645.236.79" });

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
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Sophia_Rohan92@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/390.jpg", "Sophia Rohan", "948-323-40" });

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
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Bernice.Dicki@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1019.jpg", "Bernice Dicki", "(712) 768-" });
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
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 5, 1, 4, new DateTimeOffset(new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 5, 1, 1, 7, new DateTimeOffset(new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 8, 18, 3, 5, 9, new DateTimeOffset(new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 30, 4, 3, 5, new DateTimeOffset(new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 4, 5, 1, 10, new DateTimeOffset(new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 8, 12, 2, 1, new DateTimeOffset(new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 4, 3, 1, 3, 9, new DateTimeOffset(new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 4, 17, 2, 5, 1, new DateTimeOffset(new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 18, 10, 4, 15, new DateTimeOffset(new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "PaddingMeeting", "StartDate" },
                values: new object[] { 8, 8, 15, new DateTimeOffset(new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2021, 1, 5, 17, 36, 42, 315, DateTimeKind.Unspecified).AddTicks(6418), 26, "http://emma.org", 2L, "sed", 32, 5L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "magnam" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 7, 24, 13, 35, 34, 708, DateTimeKind.Unspecified).AddTicks(4214), 20, "https://gwen.org", 3L, "necessitatibus", 42, 3L, 0, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "tempora" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 3, 10, 15, 30, 29, 419, DateTimeKind.Unspecified).AddTicks(4081), 22, "https://kristofer.name", 5L, "quis", 20, 4L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Et officiis labore." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 8, 16, 20, 53, 43, 342, DateTimeKind.Unspecified).AddTicks(8389), 30, "http://lukas.info", 1L, "consequuntur", 27, 5L, 0, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Delectus libero maxime totam in reprehenderit.\nSint atque reprehenderit temporibus ut dignissimos.\nSed maiores perferendis doloribus." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2019, 8, 11, 10, 50, 3, 810, DateTimeKind.Unspecified).AddTicks(8315), 26, "https://priscilla.biz", 1L, "illum", 26, 1L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "omnis" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2019, 11, 7, 14, 8, 28, 710, DateTimeKind.Unspecified).AddTicks(1590), 21, "https://chaim.biz", 5L, "dolores", 20, 8L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "consequatur" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 7, 13, 16, 23, 16, 156, DateTimeKind.Unspecified).AddTicks(2075), 24, "https://darrion.name", 5L, "deserunt", 31, 8L, 1, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Ullam eligendi saepe ipsam cumque corporis dolorem mollitia veniam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 9, 16, 8, 25, 19, 819, DateTimeKind.Unspecified).AddTicks(9835), 28, "http://tanya.org", "aut", 45, 7L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Id commodi temporibus eum eum qui illo fugiat facilis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 6, 4, 16, 50, 6, 768, DateTimeKind.Unspecified).AddTicks(4144), 25, "https://aileen.biz", "impedit", 17, 9L, 0, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "placeat" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 8, 11, 6, 20, 44, 615, DateTimeKind.Unspecified).AddTicks(5993), 16, "http://tara.net", 5L, "commodi", 52, 0, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Ut quam minus dicta et. Quia error sit perspiciatis nisi maxime quasi. Necessitatibus in quae et dignissimos quam qui sit." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 8, 30, 23, 32, 18, 112, DateTimeKind.Unspecified).AddTicks(5344), 10L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2020, 5, 12, 11, 13, 12, 249, DateTimeKind.Unspecified).AddTicks(7408), 10L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2019, 8, 4, 10, 42, 33, 836, DateTimeKind.Unspecified).AddTicks(7206), 8L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 3, 6, 12, 8, 46, 827, DateTimeKind.Unspecified).AddTicks(447), 3L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { 3L, new DateTime(2020, 7, 14, 12, 44, 43, 18, DateTimeKind.Unspecified).AddTicks(5275), 9L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 7, 17, 23, 51, 8, 447, DateTimeKind.Unspecified).AddTicks(7739), 4L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2021, 1, 11, 21, 31, 54, 50, DateTimeKind.Unspecified).AddTicks(3456), 6L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 5, 13, 0, 49, 59, 289, DateTimeKind.Unspecified).AddTicks(2315), 8L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2019, 11, 11, 4, 42, 44, 354, DateTimeKind.Unspecified).AddTicks(338), 6L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 18, 22, 20, 31, 414, DateTimeKind.Unspecified).AddTicks(5050), 9L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(367), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(241), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(566), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(550), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(589), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(582), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(608), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(602), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(627), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(621), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(646), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(640), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(665), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(658), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(682), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(676), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(805), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(793), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 17, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(831), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 16, 15, 39, 4, 134, DateTimeKind.Unspecified).AddTicks(824), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Conrad_Bartell@hotmail.com", new DateTimeOffset(new DateTime(2023, 5, 13, 23, 44, 0, 552, DateTimeKind.Unspecified).AddTicks(7019), new TimeSpan(0, 3, 0, 0, 0)), "Conrad Bartell" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Ronnie87@gmail.com", new DateTimeOffset(new DateTime(2022, 10, 19, 21, 2, 18, 135, DateTimeKind.Unspecified).AddTicks(7901), new TimeSpan(0, 3, 0, 0, 0)), "Ronnie Okuneva" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Carroll91@gmail.com", new DateTimeOffset(new DateTime(2022, 9, 9, 0, 47, 43, 492, DateTimeKind.Unspecified).AddTicks(2842), new TimeSpan(0, 3, 0, 0, 0)), "Carroll Hickle" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Brittany21@gmail.com", new DateTimeOffset(new DateTime(2023, 4, 21, 2, 41, 38, 634, DateTimeKind.Unspecified).AddTicks(4188), new TimeSpan(0, 3, 0, 0, 0)), "Brittany Roberts" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Shawn.Kuhn@gmail.com", new DateTimeOffset(new DateTime(2022, 9, 9, 12, 41, 57, 936, DateTimeKind.Unspecified).AddTicks(3310), new TimeSpan(0, 3, 0, 0, 0)), "Shawn Kuhn" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Rachael_Schmeler9@gmail.com", new DateTimeOffset(new DateTime(2023, 4, 6, 5, 45, 19, 77, DateTimeKind.Unspecified).AddTicks(1731), new TimeSpan(0, 3, 0, 0, 0)), "Rachael Schmeler" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Krystal29@gmail.com", new DateTimeOffset(new DateTime(2022, 9, 5, 4, 24, 47, 913, DateTimeKind.Unspecified).AddTicks(6687), new TimeSpan(0, 3, 0, 0, 0)), "Krystal Jakubowski" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Miriam_Luettgen37@yahoo.com", new DateTimeOffset(new DateTime(2023, 8, 8, 13, 23, 47, 696, DateTimeKind.Unspecified).AddTicks(2642), new TimeSpan(0, 3, 0, 0, 0)), "Miriam Luettgen" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Tommie63@yahoo.com", new DateTimeOffset(new DateTime(2023, 2, 10, 17, 26, 11, 277, DateTimeKind.Unspecified).AddTicks(6586), new TimeSpan(0, 2, 0, 0, 0)), "Tommie Bashirian" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Sean13@yahoo.com", new DateTimeOffset(new DateTime(2023, 7, 29, 3, 30, 55, 912, DateTimeKind.Unspecified).AddTicks(4882), new TimeSpan(0, 3, 0, 0, 0)), "Sean Schultz" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 15, 14, 30, 30, 499, DateTimeKind.Unspecified).AddTicks(8537), 4L, "Molestias et vitae omnis culpa.\nDebitis illo asper", 39, 3L, "voluptatum", new DateTimeOffset(new DateTime(2023, 6, 16, 10, 11, 35, 389, DateTimeKind.Unspecified).AddTicks(2009), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 4, 9, 18, 44, 34, 24, DateTimeKind.Unspecified).AddTicks(8514), 3L, "Enim odit ab ipsa dolorum voluptates veritatis.\nSi", 18, 5L, "id", new DateTimeOffset(new DateTime(2023, 1, 8, 7, 26, 0, 661, DateTimeKind.Unspecified).AddTicks(1552), new TimeSpan(0, 2, 0, 0, 0)), 1L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 8, 11, 47, 19, 85, DateTimeKind.Unspecified).AddTicks(8087), 8L, "omnis", 48, 5L, "magnam", new DateTimeOffset(new DateTime(2022, 10, 18, 16, 42, 51, 973, DateTimeKind.Unspecified).AddTicks(2341), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 1, 9, 56, 37, 772, DateTimeKind.Unspecified).AddTicks(5553), "Aut autem sed nam molestiae beatae quia laborum au", 39, 1L, "numquam", new DateTimeOffset(new DateTime(2023, 5, 21, 8, 45, 52, 99, DateTimeKind.Unspecified).AddTicks(1103), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 1, 12, 53, 37, 622, DateTimeKind.Unspecified).AddTicks(5842), 1L, "maiores", 23, 2L, "quod", new DateTimeOffset(new DateTime(2023, 6, 7, 15, 55, 48, 650, DateTimeKind.Unspecified).AddTicks(5552), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 28, 10, 58, 17, 684, DateTimeKind.Unspecified).AddTicks(2102), 1L, "Quisquam minima cumque. Quas aut sequi molestiae l", 48, 3L, "nihil", new DateTimeOffset(new DateTime(2022, 8, 28, 13, 37, 38, 241, DateTimeKind.Unspecified).AddTicks(9144), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 4, 29, 12, 4, 14, 554, DateTimeKind.Unspecified).AddTicks(3272), 1L, "Excepturi laudantium quaerat.", 52, 2L, "ducimus", new DateTimeOffset(new DateTime(2022, 11, 14, 14, 25, 13, 684, DateTimeKind.Unspecified).AddTicks(2801), new TimeSpan(0, 2, 0, 0, 0)), 10L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 3, 11, 1, 4, 58, 216, DateTimeKind.Unspecified).AddTicks(4493), 9L, "Quos eum corrupti quidem eum maiores.", 28, 5L, "maiores", new DateTimeOffset(new DateTime(2023, 5, 24, 18, 2, 20, 336, DateTimeKind.Unspecified).AddTicks(4955), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 10, 12, 20, 9, 10, 31, DateTimeKind.Unspecified).AddTicks(8481), 5L, "ut", 32, 5L, "ut", new DateTimeOffset(new DateTime(2023, 3, 5, 20, 30, 29, 426, DateTimeKind.Unspecified).AddTicks(7000), new TimeSpan(0, 2, 0, 0, 0)), 2L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 2, 16, 20, 47, 42, 445, DateTimeKind.Unspecified).AddTicks(5538), 7L, "Similique expedita incidunt et et.", 29, 4L, "natus", new DateTimeOffset(new DateTime(2023, 1, 3, 15, 34, 1, 570, DateTimeKind.Unspecified).AddTicks(2788), new TimeSpan(0, 2, 0, 0, 0)), 5L, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Voluptatem distinctio qui molestiae voluptas alias numquam ut officia qui.\nAccusantium assumenda voluptatem." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Eius cumque ut hic explicabo a voluptates provident inventore.\nConsectetur et praesentium corrupti dignissimos.\nIn et voluptate." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Sint sit aut sapiente illum quaerat deleniti consequatur est.\nQuas vel consequatur natus quia error aliquam ipsa sunt totam.\nTenetur fugit maiores odit et tempore.\nQuo dicta sed sequi id." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "doloremAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Text",
                value: "totamAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Laudantium aut illum dolorem atque qui dolores voluptas voluptatem. Itaque odio id molestiae. Omnis enim tempora et laborum quia autem. Quia nihil id qui magni voluptatem nemo id aut optio." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "doloresAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Provident similique commodi adipisci enim error. Et autem a omnis. Laudantium quibusdam repellat sit ut sed est omnis culpa. Aut quos consectetur dolorum. Et vel et. Natus eaque sint et vero ut." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Reprehenderit omnis omnis dolor animi qui iure corporis." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Itaque odio eos dolor aut et voluptas tempora debitis sed." });

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
                value: 8);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Priority",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Priority",
                value: 4);

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
                value: 8);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Priority",
                value: 8);

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
                column: "Status",
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
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

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
                column: "Role",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "ea", "Braun - Hamill", "https://kenyatta.name", "Africa/Ha" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "sint", "Kris - Mills", "https://adrienne.name", "America/N" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Odit corrupti quod fugit iste qui sed explicabo aperiam exercitationem.\nRerum molestias harum est odio sunt aut laboriosam magni et.\nDolores animi facere beatae est quod quis.", "Klocko - Hand", "http://hester.name", "Pacific/F" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "mollitia", "Russel, Mraz and Kunde", "http://rafaela.name", "America/S" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Tempora iusto omnis asperiores. Porro aspernatur ratione asperiores fugit magnam nesciunt non. Quae omnis ipsum odit cum rerum. Corrupti dolores incidunt quam et pariatur dolores. Sequi commodi culpa odit eveniet repudiandae. Voluptas non suscipit voluptas ex voluptate incidunt facilis.", "Turner - Boyer", "https://dane.org", "Europe/Lj" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Incidunt officiis mollitia neque.", "McLaughlin - Kuphal", "https://angel.biz", "Pacific/F" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Qui et quae.\nQuo consequatur vero voluptas nisi iusto quidem voluptates ut doloribus.\nFacilis odit sequi vitae laborum.\nVel qui et ut est sit ut.", "Kirlin - Mante", "https://bernadine.com", "Asia/Maga" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Qui dolor et in esse minima est eos quia molestiae.", "Pouros Group", "https://gaston.org", "Asia/Dhak" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Aut vitae ab.\nDebitis aut dolor aut.\nItaque possimus ut ea cupiditate sint necessitatibus numquam.\nPraesentium voluptatum et rem temporibus veritatis.\nAut alias perferendis occaecati excepturi voluptates quis tempore tenetur itaque.", "Boyer, Keebler and Medhurst", "http://marcelina.org", "Asia/Kuwa" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Qui sed accusantium ut minus aut et architecto.\nConsequatur veniam exercitationem est illum nam recusandae vel velit aliquam.", "Zieme and Sons", "http://chanel.org", "Asia/Ulaa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Maryann.Kreiger@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/419.jpg", "Maryann Kreiger", "350-597-88" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Boyd_Jacobson@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/630.jpg", "Boyd Jacobson", "316-457-72", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Ashley.Braun4@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/50.jpg", "Ashley Braun", "213.756.72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Bryant2@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/966.jpg", "Bryant Bartoletti", "843.280.01" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Neil44@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/796.jpg", "Neil Kertzmann", "716.422.59", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Karla_Hand71@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/669.jpg", "Karla Hand", "949-330-73" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Jamie.Funk@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/473.jpg", "Jamie Funk", "955.451.30" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Francisco_Oberbrunner@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/121.jpg", "Francisco Oberbrunner", "613.671.57" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Joel_Schimmel99@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/415.jpg", "Joel Schimmel", "539.901.47" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Hope42@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/75.jpg", "Hope Crooks", "1-672-449-" });
        }
    }
}
