using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class ChangeTimeZoneToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeZone",
                table: "Users");
            
            migrationBuilder.AddColumn<int>(
                name: "TimeZone",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0L);
            
            migrationBuilder.DropColumn(
                name: "TimeZone",
                table: "Teams");
            
            migrationBuilder.AddColumn<int>(
                name: "TimeZone",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 7, 6, 10, 2, 4, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 6, 1, 1, 5, 6, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 7, 12, 4, 3, 5, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 3, 4, 3, 5, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 7, 17, 8, 14, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "StartDate" },
                values: new object[] { 1, 2, 2, 2, 1, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 6, 29, 5, 10, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 1, 21, 9, 7, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 5, 2, 1, 14, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 8, 26, 4, 9, new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 5, 21, 17, 34, 14, 918, DateTimeKind.Unspecified).AddTicks(3379), 20, "http://eldora.biz", 0, "veritatis", 60, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Facere a reprehenderit eligendi. Impedit iste vero iusto. Rerum aut odit consequuntur. Quis eveniet nihil a ut itaque maiores. Amet fuga ex inventore nam sed sit quo ea. Aliquid non sed qui aspernatur velit tenetur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 1, 30, 21, 25, 30, 699, DateTimeKind.Unspecified).AddTicks(2395), "https://dolly.info", "doloremque", 34, 9L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Omnis labore quia sit consequatur.\nNobis ullam iure natus commodi aspernatur occaecati adipisci quia nihil." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2019, 12, 17, 13, 19, 46, 122, DateTimeKind.Unspecified).AddTicks(1164), 21, "http://krista.info", 0, "voluptatem", 20, 6L, 0, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Sunt consequuntur eius aut enim. Quia doloremque vero facere. Veniam quae eos." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 3, 18, 9, 40, 20, 70, DateTimeKind.Unspecified).AddTicks(8998), 20, "https://jayden.com", 1, "sit", 8L, 0, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Officiis omnis et maiores rem libero cum accusamus.\nRem officiis voluptates maxime odio qui laboriosam vel qui.\nPraesentium ratione voluptate aperiam.\nConsequatur in nemo cupiditate qui perspiciatis aut.\nIllo soluta ut dolores.\nQuisquam sit labore sapiente id." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 2, 10, 0, 17, 55, 260, DateTimeKind.Unspecified).AddTicks(1815), 26, "https://connor.org", 0, "qui", 54, 7L, 1, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Et dolores est et vel a. Modi tempora debitis deleniti. Reprehenderit consequuntur quisquam dolorem. Quam iste libero ut doloribus cumque laudantium voluptatem qui beatae. Ab vel neque vitae eos ab quisquam debitis qui nobis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 1, 22, 14, 15, 2, 882, DateTimeKind.Unspecified).AddTicks(2357), 17, "http://lacy.name", "cumque", 28, 7L, 1, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Natus qui quidem voluptas ratione qui voluptatem perspiciatis nostrum.\nNisi reprehenderit odio et itaque quasi velit delectus laboriosam.\nImpedit temporibus illo eaque fugiat sit.\nDolores assumenda quos velit dolorem vel.\nDignissimos et sapiente quia consequuntur fugit.\nSit autem non ut commodi sed." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 7, 13, 4, 19, 18, 650, DateTimeKind.Unspecified).AddTicks(4935), "https://adrianna.name", 1, "corporis", 22, 3L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Aut ea expedita et facilis. Atque ratione sunt et eaque et laborum sed repellat. Autem doloremque impedit." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 8, 7, 14, 42, 24, 184, DateTimeKind.Unspecified).AddTicks(5957), 21, "https://shanon.org", 2, "adipisci", 57, 1L, 0, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Sed ad unde voluptas eius et. Qui aut dignissimos aspernatur repudiandae hic aut. A officiis et. Quod eveniet facilis aliquid ducimus nobis sed officiis. Quas sit harum quos asperiores consequatur quos aut voluptates accusamus. Illo minima et adipisci eius similique in doloribus." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 3, 6, 9, 16, 29, 782, DateTimeKind.Unspecified).AddTicks(4896), 16, "https://pearlie.info", 2, "voluptas", 46, 1L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Quis vitae sint ut ut reiciendis.\nUt aut rem." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 5, 15, 15, 9, 51, 840, DateTimeKind.Unspecified).AddTicks(2764), 15, "https://chaya.biz", 1, "amet", 37, 9L, 0, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Distinctio occaecati amet voluptatem." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 4, 5, 2, 52, 24, 396, DateTimeKind.Unspecified).AddTicks(5709), 10L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2019, 9, 25, 6, 35, 58, 721, DateTimeKind.Unspecified).AddTicks(6626), 4L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 4, 18, 14, 1, 59, 754, DateTimeKind.Unspecified).AddTicks(5445), 1L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2021, 3, 31, 19, 3, 8, 180, DateTimeKind.Unspecified).AddTicks(3144), 8L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { 3L, new DateTime(2020, 7, 20, 7, 25, 13, 994, DateTimeKind.Unspecified).AddTicks(5259), 7L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 8, 30, 22, 13, 1, 993, DateTimeKind.Unspecified).AddTicks(6143), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2021, 4, 29, 8, 36, 12, 532, DateTimeKind.Unspecified).AddTicks(9931), 4L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 10, 5, 0, 1, 4, 318, DateTimeKind.Unspecified).AddTicks(5090), 3L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 12, 26, 22, 54, 10, 921, DateTimeKind.Unspecified).AddTicks(1443), 1L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 5, 2, 18, 52, 14, 351, DateTimeKind.Unspecified).AddTicks(71), 2L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 6L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7446), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 19, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7311), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7648), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 19, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7634), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 19, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7663), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 19, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7683), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7709), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 19, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7703), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7728), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 19, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7722), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7747), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 19, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7740), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7765), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 19, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7759), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7784), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 19, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7778), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7803), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 19, 18, 43, 21, 47, DateTimeKind.Unspecified).AddTicks(7797), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Rose.Powlowski86@gmail.com", new DateTimeOffset(new DateTime(2023, 1, 11, 19, 32, 10, 160, DateTimeKind.Unspecified).AddTicks(8791), new TimeSpan(0, 2, 0, 0, 0)), "Rose Powlowski" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Abraham_Schamberger60@gmail.c", new DateTimeOffset(new DateTime(2023, 5, 25, 22, 25, 42, 719, DateTimeKind.Unspecified).AddTicks(5324), new TimeSpan(0, 3, 0, 0, 0)), "Abraham Schamberger" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Lucille92@hotmail.com", new DateTimeOffset(new DateTime(2023, 4, 9, 19, 9, 56, 71, DateTimeKind.Unspecified).AddTicks(4453), new TimeSpan(0, 3, 0, 0, 0)), "Lucille Emard" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Deanna.McKenzie@yahoo.com", new DateTimeOffset(new DateTime(2023, 1, 26, 9, 1, 28, 76, DateTimeKind.Unspecified).AddTicks(1259), new TimeSpan(0, 2, 0, 0, 0)), "Deanna McKenzie" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Wayne64@hotmail.com", new DateTimeOffset(new DateTime(2023, 4, 25, 21, 44, 30, 262, DateTimeKind.Unspecified).AddTicks(4875), new TimeSpan(0, 3, 0, 0, 0)), "Wayne Franecki" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Arnold29@yahoo.com", new DateTimeOffset(new DateTime(2023, 1, 2, 22, 44, 5, 335, DateTimeKind.Unspecified).AddTicks(3375), new TimeSpan(0, 2, 0, 0, 0)), "Arnold Mraz" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Marcos7@gmail.com", new DateTimeOffset(new DateTime(2023, 8, 14, 19, 44, 22, 164, DateTimeKind.Unspecified).AddTicks(5156), new TimeSpan(0, 3, 0, 0, 0)), "Marcos Harber" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Chris.Hoeger@yahoo.com", new DateTimeOffset(new DateTime(2023, 7, 30, 10, 0, 19, 339, DateTimeKind.Unspecified).AddTicks(2901), new TimeSpan(0, 3, 0, 0, 0)), "Chris Hoeger" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Samantha66@yahoo.com", new DateTimeOffset(new DateTime(2023, 1, 29, 15, 12, 26, 94, DateTimeKind.Unspecified).AddTicks(8129), new TimeSpan(0, 2, 0, 0, 0)), "Samantha Schiller" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Guillermo_Leannon81@gmail.com", new DateTimeOffset(new DateTime(2022, 8, 31, 6, 17, 57, 952, DateTimeKind.Unspecified).AddTicks(6117), new TimeSpan(0, 3, 0, 0, 0)), "Guillermo Leannon" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 1, 17, 23, 27, 25, 177, DateTimeKind.Unspecified).AddTicks(2402), 7L, "Voluptate provident est iste at optio iure debitis", 49, 2, "earum", new DateTimeOffset(new DateTime(2022, 9, 25, 19, 58, 0, 388, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 29, 14, 15, 13, 539, DateTimeKind.Unspecified).AddTicks(7580), 7L, "et", 59, 1, "provident", new DateTimeOffset(new DateTime(2023, 5, 23, 9, 1, 52, 964, DateTimeKind.Unspecified).AddTicks(8465), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 3, 6, 5, 22, 9, 652, DateTimeKind.Unspecified).AddTicks(1819), 10L, "Autem cupiditate ea reiciendis aspernatur quisquam", 14, 2, "facilis", new DateTimeOffset(new DateTime(2023, 7, 16, 18, 46, 3, 919, DateTimeKind.Unspecified).AddTicks(1517), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 1, 8, 27, 0, 875, DateTimeKind.Unspecified).AddTicks(4728), 2L, "Quidem fugit voluptas ducimus.", 33, 0, "explicabo", new DateTimeOffset(new DateTime(2022, 12, 13, 1, 19, 49, 142, DateTimeKind.Unspecified).AddTicks(3258), new TimeSpan(0, 2, 0, 0, 0)), 6L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 9, 8, 11, 48, 59, 689, DateTimeKind.Unspecified).AddTicks(7452), 3L, "Sapiente qui quod cum nobis non aut eveniet.\nNon d", 19, 1, "ad", new DateTimeOffset(new DateTime(2023, 7, 25, 4, 40, 47, 173, DateTimeKind.Unspecified).AddTicks(4586), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 26, 12, 45, 32, 536, DateTimeKind.Unspecified).AddTicks(4550), 9L, "Ipsam itaque nam quae.", 31, "qui", new DateTimeOffset(new DateTime(2023, 3, 5, 18, 56, 20, 63, DateTimeKind.Unspecified).AddTicks(959), new TimeSpan(0, 2, 0, 0, 0)), 8L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 11, 11, 13, 26, 38, 434, DateTimeKind.Unspecified).AddTicks(4264), 8L, "Ex aperiam eius saepe alias eligendi. Expedita dol", "ex", new DateTimeOffset(new DateTime(2023, 2, 2, 2, 58, 0, 495, DateTimeKind.Unspecified).AddTicks(124), new TimeSpan(0, 2, 0, 0, 0)), 7L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 11, 30, 5, 0, 25, 179, DateTimeKind.Unspecified).AddTicks(4031), 10L, "Mollitia est et.\nItaque eum deleniti et odio magna", 52, 1, "aliquam", new DateTimeOffset(new DateTime(2023, 6, 3, 0, 0, 37, 3, DateTimeKind.Unspecified).AddTicks(4440), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 10, 24, 5, 37, 7, 332, DateTimeKind.Unspecified).AddTicks(762), 10L, "Id accusamus ipsam expedita sunt eum excepturi. Al", 25, 0, "dolor", new DateTimeOffset(new DateTime(2022, 9, 9, 8, 27, 4, 220, DateTimeKind.Unspecified).AddTicks(2249), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 2, 27, 23, 16, 49, 759, DateTimeKind.Unspecified).AddTicks(6013), 1L, "dignissimos", 18, 0, "delectus", new DateTimeOffset(new DateTime(2023, 7, 30, 1, 13, 35, 878, DateTimeKind.Unspecified).AddTicks(2722), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Voluptas qui itaque et voluptas atque voluptatem facilis." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Text",
                value: "Reprehenderit ut officia mollitia rerum quis.AAAAA");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Eos id est modi unde non tenetur repellat officia eius." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Excepturi molestias labore eaque quis ut rem libero cupiditate ut.\nSoluta eligendi cumque sit quidem.\nSed voluptas laborum culpa fuga iure beatae voluptatibus neque nisi.\nEnim enim saepe sunt itaque voluptas ut maiores ducimus sunt.\nHic hic necessitatibus molestias et ex quia impedit autem eligendi." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "eosAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "quiAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Tenetur cum ut praesentium laudantium voluptatem. Perspiciatis ut ratione quo facilis ratione aut quia fugit. Dignissimos quisquam ratione ratione ex perspiciatis quas est. Numquam laborum officia rerum qui eos quod dolor distinctio." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "eaqueAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "quiAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Reiciendis et facere incidunt vel.\nEt cumque sed ea est.\nRatione aliquam exercitationem ad molestiae eaque veniam aut.\nAut expedita perspiciatis laboriosam aliquid laboriosam.\nNon aliquid asperiores." });

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Priority",
                value: 5);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Priority",
                value: 2);

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
                value: 4);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Priority",
                value: 1);

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
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Status",
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
                value: 1);

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
                column: "Role",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Deleniti aliquid eaque qui sunt quaerat ab facere.", "Conn - Gislason", "https://domenico.com", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "incidunt", "Stanton, Goldner and Pacocha", "http://kacey.name", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "id", "Mante, Kilback and Sanford", "https://jaquan.info", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "provident", "Ferry - Wilderman", "http://freda.biz", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "iure", "Bailey, Huels and Homenick", "https://josh.name", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "sed", "Jacobs, Torphy and Hane", "https://dina.name", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Laudantium quia laboriosam at aut. Vel rerum fuga sed provident reprehenderit qui enim. Eius consequatur est ut et perferendis quisquam perspiciatis repudiandae ut. Rerum eligendi sed voluptas.", "Volkman, Heidenreich and Kreiger", "http://jacklyn.info", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quos ut aut nesciunt.\nBlanditiis quos vitae sit fuga autem in aut error.\nExcepturi consectetur nam quis fugiat nihil autem officia.\nAccusantium beatae voluptatem sequi illum.\nConsequatur praesentium est nostrum dignissimos id totam dicta aperiam.\nDeleniti aut quis aut.", "Klein - Greenholt", "https://emmanuel.com", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Voluptatem aut alias soluta cumque nesciunt eum repellendus deleniti. Quia aut quod qui autem commodi est quo totam omnis. Iste dignissimos voluptatem ipsa explicabo vel quasi beatae dicta ducimus. Exercitationem et quia odio earum non. Quia dolor eius recusandae quia quia possimus.", "Littel - Fadel", "https://reta.name", 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Ad est et odit et.\nQuas modi deleniti est.", "Torphy - Tillman", "http://luis.org", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { "Sophie.Kuphal88@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/117.jpg", "Sophie Kuphal", "1-722-898-", 1, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, "Thelma93@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/706.jpg", "Thelma Hettinger", "1-626-217-", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Mandy.OConnell59@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1101.jpg", "Mandy O'Connell", "216-632-75", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, "Gustavo_Gerhold@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1158.jpg", "Gustavo Gerhold", "895.619.39", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 0, "Frederick.Purdy45@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/254.jpg", "Frederick Purdy", "840.490.07", 1, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { 1, "Doreen_Rempel@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/973.jpg", "Doreen Rempel", "375-677-30", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Alfonso93@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1105.jpg", "Alfonso Stroman", "(613) 611-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { "Freda_Thiel@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/717.jpg", "Freda Thiel", "(648) 212-", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, "Minnie.Upton@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1220.jpg", "Minnie Upton", "1-312-602-", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { "Lucas99@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/885.jpg", "Lucas Turcotte", "1-997-592-", 0, 0 });
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
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TimeZone",
                table: "Teams",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 2, 17, 8, 1, 15, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 23, 4, 1, 8, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 2, 10, 8, 2, 14, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 13, 7, 2, 11, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 5, 19, 4, 6, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "StartDate" },
                values: new object[] { 3, 4, 30, 5, 2, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 8, 3, 4, 13, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting", "StartDate" },
                values: new object[] { 3, 6, 17, 5, 3, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 8, 4, 2, 2, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting", "StartDate" },
                values: new object[] { 1, 2, 7, 2, 8, new DateTimeOffset(new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 10, 33, 37, 632, DateTimeKind.Unspecified).AddTicks(3181), 19, "http://lesly.name", 1, "ut", 22, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Enim aliquid cumque ea officia quod earum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 7, 15, 22, 9, 34, 135, DateTimeKind.Unspecified).AddTicks(7262), "http://reese.com", "temporibus", 28, 1L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Officiis omnis autem illum repellat iusto.\nUnde totam reiciendis in et.\nTemporibus vel ut numquam sit consequuntur molestiae." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 11, 30, 1, 16, 44, 428, DateTimeKind.Unspecified).AddTicks(7930), 29, "https://kamron.name", 1, "tempore", 44, 10L, 1, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Magnam et voluptates perspiciatis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 11, 11, 12, 15, 5, 822, DateTimeKind.Unspecified).AddTicks(4565), 19, "http://kaleigh.info", 0, "cumque", 2L, 1, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Reprehenderit voluptatibus sequi id cupiditate. Est aut consequatur voluptates omnis sed itaque. Et qui sapiente consequuntur provident recusandae iste sint dolor non." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 3, 27, 21, 20, 54, 618, DateTimeKind.Unspecified).AddTicks(8806), 18, "https://charley.info", 1, "ut", 40, 6L, 0, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "In animi et ipsum alias dolorem quisquam placeat esse." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 1, 21, 1, 2, 45, 618, DateTimeKind.Unspecified).AddTicks(1869), 28, "https://jalon.name", "error", 31, 5L, 0, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Et dolores qui rem consequatur est sapiente. Cupiditate porro eligendi perferendis consequatur. Aut commodi eligendi omnis repellat molestiae non." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 11, 18, 18, 32, 16, 33, DateTimeKind.Unspecified).AddTicks(4539), "https://maiya.biz", 0, "consequatur", 21, 5L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Et adipisci esse eos perspiciatis et minus voluptatem eveniet eaque. Id consequuntur sit beatae. Aperiam tenetur asperiores et in qui quis nisi voluptatum. In eveniet sed adipisci corporis dolores tempora laboriosam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 7, 18, 16, 49, 47, 788, DateTimeKind.Unspecified).AddTicks(4069), 16, "https://cristal.com", 1, "vel", 54, 5L, 1, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Voluptatibus vero minus amet.\nEsse amet qui fugiat numquam.\nNemo atque deleniti.\nPlaceat voluptas eveniet." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2019, 11, 21, 17, 44, 39, 392, DateTimeKind.Unspecified).AddTicks(8171), 25, "https://vicente.info", 0, "dolorem", 53, 4L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "id" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "UpdatedAt", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 12, 3, 7, 5, 8, 608, DateTimeKind.Unspecified).AddTicks(5589), 28, "https://andrew.name", 0, "nihil", 22, 5L, 1, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Odit ut porro corrupti optio est." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2019, 10, 14, 1, 52, 41, 862, DateTimeKind.Unspecified).AddTicks(5318), 2L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 11, 2, 11, 47, 7, 524, DateTimeKind.Unspecified).AddTicks(895), 6L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2019, 8, 5, 22, 15, 39, 940, DateTimeKind.Unspecified).AddTicks(7274), 4L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 2, 24, 14, 13, 53, 567, DateTimeKind.Unspecified).AddTicks(9834), 5L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt" },
                values: new object[] { 6L, new DateTime(2021, 1, 17, 10, 14, 29, 620, DateTimeKind.Unspecified).AddTicks(1650), 6L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 5, 17, 8, 9, 46, 481, DateTimeKind.Unspecified).AddTicks(8859), new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 4, 8, 1, 58, 19, 233, DateTimeKind.Unspecified).AddTicks(6606), 2L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2021, 6, 29, 17, 34, 22, 312, DateTimeKind.Unspecified).AddTicks(2276), 8L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 6, 8, 3, 47, 14, 272, DateTimeKind.Unspecified).AddTicks(2834), 7L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 7, 10, 3, 20, 53, 662, DateTimeKind.Unspecified).AddTicks(8549), 6L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 1L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1269), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1152), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1407), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1400), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1423), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1418), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1438), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1433), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1453), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1448), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1468), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1463), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1482), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1477), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1497), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1492), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1512), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1507), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1527), new TimeSpan(0, 3, 0, 0, 0)), 9L, new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1522), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Thomas.Mayert@gmail.com", new DateTimeOffset(new DateTime(2022, 10, 2, 21, 41, 48, 730, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, 3, 0, 0, 0)), "Thomas Mayert" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Julia2@hotmail.com", new DateTimeOffset(new DateTime(2022, 9, 12, 19, 51, 32, 571, DateTimeKind.Unspecified).AddTicks(4496), new TimeSpan(0, 3, 0, 0, 0)), "Julia Schowalter" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Susan.DAmore@yahoo.com", new DateTimeOffset(new DateTime(2023, 1, 6, 5, 31, 4, 157, DateTimeKind.Unspecified).AddTicks(2529), new TimeSpan(0, 2, 0, 0, 0)), "Susan D'Amore" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Carolyn76@gmail.com", new DateTimeOffset(new DateTime(2023, 5, 3, 2, 17, 59, 777, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 3, 0, 0, 0)), "Carolyn Konopelski" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Loretta34@hotmail.com", new DateTimeOffset(new DateTime(2022, 11, 22, 18, 15, 48, 698, DateTimeKind.Unspecified).AddTicks(6090), new TimeSpan(0, 2, 0, 0, 0)), "Loretta Konopelski" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Misty67@gmail.com", new DateTimeOffset(new DateTime(2023, 2, 15, 3, 45, 44, 453, DateTimeKind.Unspecified).AddTicks(5544), new TimeSpan(0, 2, 0, 0, 0)), "Misty Lesch" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "George60@yahoo.com", new DateTimeOffset(new DateTime(2022, 10, 26, 0, 46, 34, 844, DateTimeKind.Unspecified).AddTicks(5371), new TimeSpan(0, 3, 0, 0, 0)), "George Bergstrom" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Alexander_Kassulke64@gmail.co", new DateTimeOffset(new DateTime(2023, 4, 15, 18, 31, 48, 191, DateTimeKind.Unspecified).AddTicks(2196), new TimeSpan(0, 3, 0, 0, 0)), "Alexander Kassulke" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Milton.Schuppe19@hotmail.com", new DateTimeOffset(new DateTime(2022, 11, 18, 13, 43, 10, 281, DateTimeKind.Unspecified).AddTicks(7839), new TimeSpan(0, 2, 0, 0, 0)), "Milton Schuppe" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Joanne29@hotmail.com", new DateTimeOffset(new DateTime(2022, 11, 4, 13, 35, 14, 761, DateTimeKind.Unspecified).AddTicks(6999), new TimeSpan(0, 2, 0, 0, 0)), "Joanne Walter" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 12, 7, 19, 52, 54, 651, DateTimeKind.Unspecified).AddTicks(9375), 3L, "Quod temporibus odio autem beatae voluptatem quisq", 40, 1, "ab", new DateTimeOffset(new DateTime(2022, 12, 27, 0, 50, 27, 181, DateTimeKind.Unspecified).AddTicks(6641), new TimeSpan(0, 2, 0, 0, 0)), 3L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 8, 29, 12, 2, 11, 435, DateTimeKind.Unspecified).AddTicks(927), 9L, "eveniet", 60, 2, "placeat", new DateTimeOffset(new DateTime(2023, 7, 28, 16, 30, 44, 331, DateTimeKind.Unspecified).AddTicks(4276), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 6, 3, 3, 41, 25, 723, DateTimeKind.Unspecified).AddTicks(2516), 7L, "corporis", 23, 1, "rerum", new DateTimeOffset(new DateTime(2023, 7, 29, 22, 37, 4, 220, DateTimeKind.Unspecified).AddTicks(178), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 9, 16, 40, 40, 146, DateTimeKind.Unspecified).AddTicks(445), 9L, "Atque reiciendis et voluptates expedita eaque illu", 42, 2, "et", new DateTimeOffset(new DateTime(2023, 6, 22, 0, 54, 48, 429, DateTimeKind.Unspecified).AddTicks(3094), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 9, 9, 7, 8, 10, 894, DateTimeKind.Unspecified).AddTicks(5926), 1L, "Expedita nihil culpa officia in similique ipsam at", 12, 0, "dolore", new DateTimeOffset(new DateTime(2022, 10, 9, 3, 39, 27, 215, DateTimeKind.Unspecified).AddTicks(9007), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 4, 2, 17, 37, 637, DateTimeKind.Unspecified).AddTicks(5032), 5L, "Itaque totam ea earum.\nArchitecto qui earum nemo p", 54, "voluptatem", new DateTimeOffset(new DateTime(2022, 9, 1, 12, 2, 27, 372, DateTimeKind.Unspecified).AddTicks(7517), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2019, 12, 9, 18, 58, 48, 445, DateTimeKind.Unspecified).AddTicks(3549), 3L, "et", "et", new DateTimeOffset(new DateTime(2023, 3, 6, 18, 16, 57, 709, DateTimeKind.Unspecified).AddTicks(215), new TimeSpan(0, 2, 0, 0, 0)), 9L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 1, 1, 0, 49, 49, 323, DateTimeKind.Unspecified).AddTicks(4111), 8L, "Deleniti quo nobis et dignissimos cupiditate disti", 13, 2, "et", new DateTimeOffset(new DateTime(2023, 2, 25, 13, 28, 48, 71, DateTimeKind.Unspecified).AddTicks(8981), new TimeSpan(0, 2, 0, 0, 0)), 2L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 12, 13, 10, 20, 26, 336, DateTimeKind.Unspecified).AddTicks(6472), 4L, "Occaecati iusto id adipisci consequatur possimus o", 29, 2, "autem", new DateTimeOffset(new DateTime(2022, 9, 16, 0, 43, 32, 848, DateTimeKind.Unspecified).AddTicks(3971), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 7, 4, 18, 25, 17, 166, DateTimeKind.Unspecified).AddTicks(888), 7L, "Enim et vitae minus. Nemo natus nobis commodi. Dol", 16, 2, "perferendis", new DateTimeOffset(new DateTime(2023, 7, 29, 9, 58, 36, 801, DateTimeKind.Unspecified).AddTicks(5983), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Quam ut ipsam laudantium ut occaecati. Atque consectetur est iusto sed eum. Reiciendis inventore corrupti eveniet eveniet ut ea doloremque ipsam sed. Ab ullam sed assumenda nisi. Culpa laborum eligendi est dicta expedita libero." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Text",
                value: "abAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "rerumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Exercitationem sapiente porro.AAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "rationeAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Sint atque veritatis est doloribus quae.\nOdio quidem voluptatem dolor ea esse ullam et.\nSunt fuga excepturi in.\nTotam itaque perferendis similique id.\nNihil magni voluptas eos ea pariatur." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Temporibus voluptatem eligendi mollitia ut sint. Quibusdam porro itaque vel in. Et quia ut cumque inventore quia ut. In explicabo porro perspiciatis doloribus voluptas est quaerat rem. Atque repellendus commodi eum et animi non doloribus. Sapiente laboriosam pariatur." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "Dolor fuga molestiae eaque odio ut iure adipisci quis et." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Velit fugiat sint sint.AAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Et qui aliquid asperiores. Quia optio sed itaque qui. In excepturi amet. Assumenda provident sit tempora numquam iure." });

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
                value: 5);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Priority",
                value: 3);

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
                value: 9);

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
                value: 6);

            migrationBuilder.UpdateData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Priority",
                value: 3);

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
                column: "Status",
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
                value: 2);

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
                column: "Role",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quisquam repellat dolor velit harum nihil odit sapiente laborum. Quas quibusdam suscipit ut rerum velit. Ipsa maxime velit modi nam ullam. Corporis totam dolores. Sunt et quasi magni voluptatem deserunt. Voluptas voluptate animi omnis laboriosam ex itaque corrupti.", "McClure Inc", "http://roy.biz", "Asia/Kolk" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Illo sit quibusdam nostrum omnis.\nAnimi vero distinctio dolor eum libero aliquid.\nSed ipsa porro non aut corporis.", "Beier, Roob and Goldner", "https://marlon.com", "Pacific/N" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quia sint officia animi qui qui qui fugit velit.\nNisi fugit vero.\nVoluptatem recusandae fuga et qui mollitia aut laborum.\nRecusandae voluptatibus ipsum sit quia beatae qui maiores.\nItaque deserunt perferendis et.", "Parisian - Zieme", "http://duncan.net", "Atlantic/" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quasi itaque enim est. Harum illo nostrum ipsum. Autem est sint et aspernatur minima vel.", "Hahn Group", "http://neil.name", "Asia/Yere" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Hic dignissimos nulla illum tempore perspiciatis accusamus libero praesentium quisquam. Voluptatibus ad et minus laudantium qui minus debitis mollitia. Asperiores sed iste possimus.", "Sauer, Howe and Bailey", "http://dayton.info", "Asia/Taip" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Dolores aut animi autem repellendus.\nPlaceat quas eaque temporibus animi voluptates reiciendis doloribus.", "Murazik Inc", "https://brian.org", "Pacific/M" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Animi rem sed aut nemo pariatur nostrum modi et dolorem.\nCumque ex quaerat quia temporibus aut id ducimus.\nImpedit ut in.", "Yundt - Zemlak", "http://dallas.com", "Asia/Bang" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Qui dolor reprehenderit eum ullam cupiditate minus alias est. Nulla dolores iste. Fuga ut quibusdam natus iusto explicabo et.", "Lockman - Hudson", "http://verner.com", "Europe/Lo" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quidem nostrum sapiente dolor ad culpa est et libero. Est sapiente quasi sapiente quis. Ut maiores fugit aperiam alias et. Aliquid id recusandae nihil nemo tempora et est. Illum nemo rerum nostrum. Impedit non earum nostrum consequatur.", "O'Conner - Stanton", "https://alana.com", "Asia/Kolk" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "illo", "Bartoletti LLC", "https://easter.com", "Europe/Pr" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { "Hattie29@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/801.jpg", "Hattie Hane", "1-775-291-", 0, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 0, "James38@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/282.jpg", "James Prohaska", "639.599.49", 1, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Salvatore.Champlin40@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/706.jpg", "Salvatore Champlin", "561-981-13", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 0, "Toni25@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/433.jpg", "Toni Carroll", "714-216-42", 1, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 1, "Lance_Ebert68@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/859.jpg", "Lance Ebert", "1-687-614-", 0, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { 0, "Clark_Moore@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/839.jpg", "Clark Moore", "741-251-70", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeZone" },
                values: new object[] { "Rose90@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/337.jpg", "Rose Stracke", "797-876-66", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { "Henrietta85@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/197.jpg", "Henrietta Powlowski", "(447) 233-", 1, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { 0, "Carl77@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/188.jpg", "Carl Beahan", "853-403-53", 1, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[] { "Alfred48@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/420.jpg", "Alfred Dietrich", "448-988-20", 1, 5 });
        }
    }
}
