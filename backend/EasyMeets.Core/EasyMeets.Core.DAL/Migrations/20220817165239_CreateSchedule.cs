using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class CreateSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamMemberMeetings");

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailabilitySlotId = table.Column<long>(type: "bigint", nullable: false),
                    TimeZone = table.Column<int>(type: "int", nullable: false),
                    WithTeamMembers = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedule_AvailabilitySlots_AvailabilitySlotId",
                        column: x => x.AvailabilitySlotId,
                        principalTable: "AvailabilitySlots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleItem",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleId = table.Column<long>(type: "bigint", nullable: false),
                    Start = table.Column<TimeSpan>(type: "time", nullable: false),
                    End = table.Column<TimeSpan>(type: "time", nullable: false),
                    WeekDay = table.Column<int>(type: "int", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleItem_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SlotMembers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<long>(type: "bigint", nullable: false),
                    EventId = table.Column<long>(type: "bigint", nullable: false),
                    ScheduleId = table.Column<long>(type: "bigint", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlotMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SlotMembers_Meetings_EventId",
                        column: x => x.EventId,
                        principalTable: "Meetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SlotMembers_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SlotMembers_Users_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 5, 5, 5, 7 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 22, 8, 5, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 1, 1, 3, 5, 15 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 4, 29, 9, 5, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 3, 19, 1, 3, 7 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 8, 9, 6, 2, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 7, 30, 1, 2, 10 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 8, 22, 4, 4, 14 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 8, 12, 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 5, 10, 5, 1, 8 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 1, 5, 9, 17, 7, 420, DateTimeKind.Unspecified).AddTicks(9532), "http://gabrielle.net", 1L, "voluptatem", 35, 3L, 1, "pariatur" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 1, 1, 21, 55, 57, 360, DateTimeKind.Unspecified).AddTicks(873), 29, "http://marianne.net", 1L, "eligendi", 34, 3L, 0, "Necessitatibus eum illum a tempora. Et blanditiis natus sed quidem delectus temporibus id temporibus aperiam. Cumque explicabo ipsa beatae dolorem commodi officia. Tenetur rerum unde quaerat amet." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 4, 21, 9, 25, 25, 206, DateTimeKind.Unspecified).AddTicks(3722), 28, "https://ronny.biz", "quia", 50, 6L, "Deserunt et fuga voluptas perspiciatis dignissimos praesentium alias beatae nihil.\nReiciendis velit sequi unde nostrum.\nVoluptatum eveniet mollitia eaque nostrum nemo aut nam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 1, 1, 17, 36, 18, 719, DateTimeKind.Unspecified).AddTicks(8103), 17, "https://alda.name", 4L, "blanditiis", 46, 7L, 0, "Illum qui enim est est recusandae eius iure quae omnis.\nRepellendus a totam omnis dolores incidunt labore itaque consequatur nulla.\nOptio in hic sed tempore dolores accusamus vitae omnis enim.\nSequi ut excepturi voluptas velit voluptas fugiat adipisci voluptates atque.\nNostrum esse mollitia repudian" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 9, 9, 22, 13, 49, 933, DateTimeKind.Unspecified).AddTicks(2141), 22, "http://roberta.net", "veniam", 56, 7L, "eaque" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 1, 30, 3, 13, 48, 325, DateTimeKind.Unspecified).AddTicks(2656), 28, "http://josue.biz", 4L, "dolor", 52, 7L, "Excepturi ipsum quo magnam vel ut beatae. Voluptates rerum sed ea quos. Quo debitis esse aperiam incidunt. Error quisquam laudantium." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 1, 15, 18, 55, 59, 785, DateTimeKind.Unspecified).AddTicks(6999), 15, "http://jeanette.info", 1L, "ipsa", 19, 3L, 0, "Ducimus et repellat vitae et alias maxime dolorem consequuntur. Est a et delectus vel. Consequatur dolorem autem id et aut et perferendis libero." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 3, 29, 3, 55, 49, 473, DateTimeKind.Unspecified).AddTicks(2010), 24, "http://norval.org", 4L, "quasi", 41, 4L, 0, "Soluta incidunt vel autem nihil." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 7, 27, 15, 15, 57, 511, DateTimeKind.Unspecified).AddTicks(8766), 17, "http://kallie.biz", 5L, "neque", 51, 3L, "Voluptatem odit quae libero. Reiciendis corrupti ut error nihil ipsam illo inventore nesciunt. Odio enim adipisci iusto dignissimos non qui consequuntur sequi nisi. Veritatis consequatur et non tenetur natus. Velit ullam sequi rerum. Ratione qui omnis deserunt quaerat doloribus earum molestias incid" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2021, 4, 17, 20, 39, 20, 25, DateTimeKind.Unspecified).AddTicks(1194), 20, "https://delores.name", "neque", 50, "Sed amet veritatis aut natus quia vitae iste." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 5, 30, 16, 17, 40, 169, DateTimeKind.Unspecified).AddTicks(9914), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 8, 26, 3, 39, 24, 961, DateTimeKind.Unspecified).AddTicks(9383), 3L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2021, 2, 12, 4, 50, 3, 514, DateTimeKind.Unspecified).AddTicks(4849), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2019, 10, 20, 1, 0, 21, 542, DateTimeKind.Unspecified).AddTicks(5816), 1L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2019, 11, 20, 15, 14, 29, 83, DateTimeKind.Unspecified).AddTicks(3199), 7L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2020, 2, 12, 20, 38, 57, 932, DateTimeKind.Unspecified).AddTicks(3745), 4L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2019, 10, 13, 2, 36, 52, 426, DateTimeKind.Unspecified).AddTicks(9067), 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 3, 19, 0, 6, 33, 837, DateTimeKind.Unspecified).AddTicks(2192), 4L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 1, 19, 7, 56, 37, 940, DateTimeKind.Unspecified).AddTicks(6138), 6L, 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2020, 8, 29, 3, 50, 15, 464, DateTimeKind.Unspecified).AddTicks(8399), 9L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8548), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 18, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8669), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 18, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8661), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8687), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 18, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8681), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8705), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 18, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8700), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8723), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 18, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8717), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8741), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 18, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8735), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8758), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 18, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8752), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8775), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 18, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8770), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 18, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8787), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8810), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 18, 19, 52, 37, 454, DateTimeKind.Unspecified).AddTicks(8804), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Joseph.Kirlin14@hotmail.com", new DateTimeOffset(new DateTime(2023, 1, 12, 23, 32, 26, 915, DateTimeKind.Unspecified).AddTicks(5992), new TimeSpan(0, 2, 0, 0, 0)), "Joseph Kirlin" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Joel.Doyle@gmail.com", new DateTimeOffset(new DateTime(2022, 10, 18, 4, 8, 20, 280, DateTimeKind.Unspecified).AddTicks(5866), new TimeSpan(0, 3, 0, 0, 0)), "Joel Doyle" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Tommy36@yahoo.com", new DateTimeOffset(new DateTime(2022, 8, 19, 12, 57, 21, 643, DateTimeKind.Unspecified).AddTicks(5017), new TimeSpan(0, 3, 0, 0, 0)), "Tommy Collier" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Salvador_Gorczany@hotmail.com", new DateTimeOffset(new DateTime(2022, 11, 21, 12, 27, 28, 682, DateTimeKind.Unspecified).AddTicks(9687), new TimeSpan(0, 2, 0, 0, 0)), "Salvador Gorczany" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Alexandra_Powlowski4@yahoo.co", new DateTimeOffset(new DateTime(2023, 8, 12, 1, 58, 41, 931, DateTimeKind.Unspecified).AddTicks(5229), new TimeSpan(0, 3, 0, 0, 0)), "Alexandra Powlowski" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Eva_Leannon58@hotmail.com", new DateTimeOffset(new DateTime(2023, 5, 31, 21, 44, 19, 842, DateTimeKind.Unspecified).AddTicks(8891), new TimeSpan(0, 3, 0, 0, 0)), "Eva Leannon" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Ismael90@yahoo.com", new DateTimeOffset(new DateTime(2023, 7, 20, 6, 35, 33, 990, DateTimeKind.Unspecified).AddTicks(8506), new TimeSpan(0, 3, 0, 0, 0)), "Ismael Goodwin" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Julie.Price48@yahoo.com", new DateTimeOffset(new DateTime(2022, 9, 29, 3, 14, 14, 881, DateTimeKind.Unspecified).AddTicks(1974), new TimeSpan(0, 3, 0, 0, 0)), "Julie Price" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Leon_Jast46@yahoo.com", new DateTimeOffset(new DateTime(2022, 12, 2, 14, 54, 44, 42, DateTimeKind.Unspecified).AddTicks(9198), new TimeSpan(0, 2, 0, 0, 0)), "Leon Jast" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Kelly.OKeefe@hotmail.com", new DateTimeOffset(new DateTime(2022, 10, 19, 15, 57, 3, 917, DateTimeKind.Unspecified).AddTicks(3885), new TimeSpan(0, 3, 0, 0, 0)), "Kelly O'Keefe" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 9, 19, 5, 4, 8, 722, DateTimeKind.Unspecified).AddTicks(9450), 1L, "Voluptas cum vero ut tempora sed porro amet. Dolor", 58, "molestias", new DateTimeOffset(new DateTime(2023, 3, 16, 5, 55, 15, 153, DateTimeKind.Unspecified).AddTicks(6139), new TimeSpan(0, 2, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 1, 6, 15, 43, 5, 514, DateTimeKind.Unspecified).AddTicks(2043), "at", 44, 1L, "molestiae", new DateTimeOffset(new DateTime(2022, 10, 29, 4, 33, 16, 654, DateTimeKind.Unspecified).AddTicks(3873), new TimeSpan(0, 3, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 6, 5, 48, 18, 671, DateTimeKind.Unspecified).AddTicks(9869), "Quis est voluptatem fugit. Voluptatum magni dolore", 35, 3L, "ut", new DateTimeOffset(new DateTime(2022, 12, 15, 4, 38, 33, 920, DateTimeKind.Unspecified).AddTicks(6343), new TimeSpan(0, 2, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 22, 13, 20, 51, 200, DateTimeKind.Unspecified).AddTicks(8050), 3L, "Tempora illum dolore.", 55, 3L, "dignissimos", new DateTimeOffset(new DateTime(2023, 4, 3, 0, 34, 21, 43, DateTimeKind.Unspecified).AddTicks(442), new TimeSpan(0, 3, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 18, 1, 27, 38, 529, DateTimeKind.Unspecified).AddTicks(8686), 10L, "Assumenda et quo corporis accusantium in ducimus.", 52, 4L, "occaecati", new DateTimeOffset(new DateTime(2023, 6, 23, 2, 56, 54, 207, DateTimeKind.Unspecified).AddTicks(3685), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2021, 7, 16, 6, 54, 33, 38, DateTimeKind.Unspecified).AddTicks(5589), 9L, "similique", 57, 4L, "provident", new DateTimeOffset(new DateTime(2023, 8, 8, 6, 45, 45, 532, DateTimeKind.Unspecified).AddTicks(4011), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 20, 0, 13, 14, 103, DateTimeKind.Unspecified).AddTicks(4426), 6L, "Ipsam consequatur itaque eveniet amet suscipit lab", 33, 4L, "at", new DateTimeOffset(new DateTime(2022, 12, 29, 0, 40, 34, 482, DateTimeKind.Unspecified).AddTicks(5035), new TimeSpan(0, 2, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 25, 6, 2, 37, 293, DateTimeKind.Unspecified).AddTicks(1270), 9L, "neque", 57, 3L, "unde", new DateTimeOffset(new DateTime(2023, 4, 3, 20, 42, 26, 110, DateTimeKind.Unspecified).AddTicks(224), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 7, 26, 16, 41, 0, 752, DateTimeKind.Unspecified).AddTicks(6589), "esse", 37, 2L, "repellendus", new DateTimeOffset(new DateTime(2023, 5, 14, 17, 52, 15, 973, DateTimeKind.Unspecified).AddTicks(3854), new TimeSpan(0, 3, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 9, 17, 21, 52, 10, 989, DateTimeKind.Unspecified).AddTicks(4222), 9L, "Quisquam repellendus in.\nEx aliquid corrupti et no", 19, 1L, "quisquam", new DateTimeOffset(new DateTime(2023, 6, 19, 22, 40, 52, 32, DateTimeKind.Unspecified).AddTicks(5126), new TimeSpan(0, 3, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Dolores eum sit.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "debitisAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "sedAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Dolores quasi ea commodi esse aperiam vero.\nVero consequatur et qui rem.\nEos necessitatibus voluptatibus.\nIpsa dolores dignissimos magnam molestiae." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Ipsa mollitia distinctio eum. Nulla et aliquid dolores libero eaque qui vel asperiores modi. Odio architecto magni quasi cumque. Adipisci ex sapiente. Placeat tempora et ut suscipit odit fugiat." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "minimaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Text",
                value: "Autem impedit officiis impedit.AAAAAAAAAAAAAAAAAAA");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Sed excepturi consequatur perspiciatis ut aut aspernatur suscipit." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Text",
                value: "Repellat autem quaerat.\nAsperiores in et aut harum atque asperiores dignissimos.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Asperiores consequatur ut occaecati labore et eius voluptate nemo aut.\nDolorem molestiae porro deleniti.\nDistinctio illum occaecati et ipsam.\nTenetur aperiam recusandae sit sunt eaque." });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "AvailabilitySlotId", "IsDeleted", "TimeZone", "WithTeamMembers" },
                values: new object[,]
                {
                    { 1L, 1L, false, 623, true },
                    { 2L, 2L, false, 382, true },
                    { 3L, 3L, false, 401, false },
                    { 4L, 4L, false, -15, true },
                    { 5L, 5L, false, 324, true },
                    { 6L, 6L, false, 377, true },
                    { 7L, 7L, false, 438, true },
                    { 8L, 8L, false, 594, true },
                    { 9L, 9L, false, -247, true },
                    { 10L, 10L, false, -301, false }
                });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Status",
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
                keyValue: 3L,
                column: "Role",
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
                column: "Role",
                value: 2);

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "qui", "MacGyver LLC", "http://gladys.info", "Africa/Na" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "non", "Kuhlman, Rosenbaum and Metz", "https://retha.org", "Asia/Taip" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Sed vel molestias eligendi quae.\nQuas molestiae quaerat qui quia et laudantium enim ducimus ut.\nVero assumenda tenetur laboriosam dolorem eveniet non et et.\nExcepturi quis fugiat neque esse et dolores.", "Mertz, Donnelly and Hyatt", "https://jordi.com", "Asia/Kara" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Veritatis amet itaque nihil quia molestiae dolorum itaque non. Minima rem ea id. Perspiciatis soluta est cumque ex ab dolores quisquam laborum quo. Sequi et sed provident dolore. Itaque quo tempora aliquam.", "Mante - O'Hara", "https://karson.info", "Asia/Dhak" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Hic aperiam non. Iste est ut mollitia. Ut aliquam autem fugit possimus eius et. Recusandae architecto architecto maiores voluptate assumenda a.", "Schroeder, Green and Rau", "http://alize.biz", "Europe/Vi" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Ducimus asperiores voluptatum recusandae sapiente sed consequuntur eius.\nEst in repudiandae minima.\nQui at aliquid perferendis.\nSunt et et dolor possimus temporibus.", "Senger - Konopelski", "http://belle.info", "Africa/Ha" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Quia officiis neque modi.\nQuas in earum voluptates veniam qui.\nQuisquam voluptatibus aut.\nDistinctio et dolorem sunt eum.", "Macejkovic, Marquardt and Koch", "https://horacio.net", "America/M" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Voluptate et temporibus dolor dolor quos libero.", "Kovacek - Marks", "http://selena.org", "Asia/Toky" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "veniam", "Effertz Group", "http://peggie.biz", "Asia/Tash" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "ut", "Rodriguez, Kihn and Langworth", "http://levi.net", "Asia/Kras" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Jeanne24@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1155.jpg", "Jeanne Bednar", "797.967.13" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Clark_Ritchie67@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/813.jpg", "Clark Ritchie", "1-698-264-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Faith.West@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/354.jpg", "Faith West", "426-994-77", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Vicky_Grimes@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/678.jpg", "Vicky Grimes", "1-910-260-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Ellis_Larkin53@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/58.jpg", "Ellis Larkin", "756-825-86", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Harriet.Sanford@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/639.jpg", "Harriet Sanford", "775-541-14", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Patsy.Dach@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/137.jpg", "Patsy Dach", "1-897-902-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Viola40@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/655.jpg", "Viola Rodriguez", "945-976-83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Woodrow_Hammes12@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/873.jpg", "Woodrow Hammes", "1-784-879-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Evan.Howe10@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1229.jpg", "Evan Howe", "624-720-82" });

            migrationBuilder.InsertData(
                table: "ScheduleItem",
                columns: new[] { "Id", "End", "IsDeleted", "IsEnabled", "ScheduleId", "Start", "WeekDay" },
                values: new object[,]
                {
                    { 1L, new TimeSpan(0, 18, 0, 0, 0), false, false, 1L, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 2L, new TimeSpan(0, 18, 0, 0, 0), false, false, 1L, new TimeSpan(0, 11, 0, 0, 0), 1 },
                    { 3L, new TimeSpan(0, 16, 0, 0, 0), false, true, 1L, new TimeSpan(0, 12, 0, 0, 0), 2 },
                    { 4L, new TimeSpan(0, 15, 0, 0, 0), false, false, 1L, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 5L, new TimeSpan(0, 13, 0, 0, 0), false, false, 1L, new TimeSpan(0, 9, 0, 0, 0), 4 },
                    { 6L, new TimeSpan(0, 17, 0, 0, 0), false, false, 1L, new TimeSpan(0, 10, 0, 0, 0), 5 },
                    { 7L, new TimeSpan(0, 16, 0, 0, 0), false, false, 1L, new TimeSpan(0, 9, 0, 0, 0), 6 },
                    { 8L, new TimeSpan(0, 15, 0, 0, 0), false, true, 2L, new TimeSpan(0, 11, 0, 0, 0), 0 },
                    { 9L, new TimeSpan(0, 18, 0, 0, 0), false, false, 2L, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 10L, new TimeSpan(0, 18, 0, 0, 0), false, true, 2L, new TimeSpan(0, 8, 0, 0, 0), 2 },
                    { 11L, new TimeSpan(0, 18, 0, 0, 0), false, false, 2L, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 12L, new TimeSpan(0, 15, 0, 0, 0), false, false, 2L, new TimeSpan(0, 11, 0, 0, 0), 4 },
                    { 13L, new TimeSpan(0, 18, 0, 0, 0), false, false, 2L, new TimeSpan(0, 11, 0, 0, 0), 5 },
                    { 14L, new TimeSpan(0, 14, 0, 0, 0), false, false, 2L, new TimeSpan(0, 12, 0, 0, 0), 6 },
                    { 15L, new TimeSpan(0, 14, 0, 0, 0), false, false, 3L, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 16L, new TimeSpan(0, 14, 0, 0, 0), false, false, 3L, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 17L, new TimeSpan(0, 13, 0, 0, 0), false, true, 3L, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 18L, new TimeSpan(0, 13, 0, 0, 0), false, true, 3L, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 19L, new TimeSpan(0, 17, 0, 0, 0), false, false, 3L, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 20L, new TimeSpan(0, 16, 0, 0, 0), false, false, 3L, new TimeSpan(0, 10, 0, 0, 0), 5 },
                    { 21L, new TimeSpan(0, 17, 0, 0, 0), false, true, 3L, new TimeSpan(0, 8, 0, 0, 0), 6 },
                    { 22L, new TimeSpan(0, 14, 0, 0, 0), false, false, 4L, new TimeSpan(0, 12, 0, 0, 0), 0 },
                    { 23L, new TimeSpan(0, 15, 0, 0, 0), false, false, 4L, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 24L, new TimeSpan(0, 18, 0, 0, 0), false, true, 4L, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 25L, new TimeSpan(0, 13, 0, 0, 0), false, false, 4L, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 26L, new TimeSpan(0, 13, 0, 0, 0), false, false, 4L, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 27L, new TimeSpan(0, 17, 0, 0, 0), false, false, 4L, new TimeSpan(0, 10, 0, 0, 0), 5 },
                    { 28L, new TimeSpan(0, 18, 0, 0, 0), false, false, 4L, new TimeSpan(0, 9, 0, 0, 0), 6 },
                    { 29L, new TimeSpan(0, 15, 0, 0, 0), false, false, 5L, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 30L, new TimeSpan(0, 14, 0, 0, 0), false, true, 5L, new TimeSpan(0, 11, 0, 0, 0), 1 },
                    { 31L, new TimeSpan(0, 16, 0, 0, 0), false, false, 5L, new TimeSpan(0, 10, 0, 0, 0), 2 },
                    { 32L, new TimeSpan(0, 17, 0, 0, 0), false, true, 5L, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 33L, new TimeSpan(0, 13, 0, 0, 0), false, true, 5L, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 34L, new TimeSpan(0, 14, 0, 0, 0), false, true, 5L, new TimeSpan(0, 10, 0, 0, 0), 5 },
                    { 35L, new TimeSpan(0, 16, 0, 0, 0), false, true, 5L, new TimeSpan(0, 11, 0, 0, 0), 6 },
                    { 36L, new TimeSpan(0, 18, 0, 0, 0), false, false, 6L, new TimeSpan(0, 12, 0, 0, 0), 0 },
                    { 37L, new TimeSpan(0, 15, 0, 0, 0), false, true, 6L, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 38L, new TimeSpan(0, 16, 0, 0, 0), false, false, 6L, new TimeSpan(0, 10, 0, 0, 0), 2 },
                    { 39L, new TimeSpan(0, 18, 0, 0, 0), false, true, 6L, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 40L, new TimeSpan(0, 17, 0, 0, 0), false, false, 6L, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 41L, new TimeSpan(0, 16, 0, 0, 0), false, false, 6L, new TimeSpan(0, 8, 0, 0, 0), 5 },
                    { 42L, new TimeSpan(0, 18, 0, 0, 0), false, true, 6L, new TimeSpan(0, 9, 0, 0, 0), 6 }
                });

            migrationBuilder.InsertData(
                table: "ScheduleItem",
                columns: new[] { "Id", "End", "IsDeleted", "IsEnabled", "ScheduleId", "Start", "WeekDay" },
                values: new object[,]
                {
                    { 43L, new TimeSpan(0, 14, 0, 0, 0), false, false, 7L, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 44L, new TimeSpan(0, 17, 0, 0, 0), false, false, 7L, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 45L, new TimeSpan(0, 16, 0, 0, 0), false, false, 7L, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 46L, new TimeSpan(0, 17, 0, 0, 0), false, false, 7L, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 47L, new TimeSpan(0, 15, 0, 0, 0), false, true, 7L, new TimeSpan(0, 11, 0, 0, 0), 4 },
                    { 48L, new TimeSpan(0, 13, 0, 0, 0), false, true, 7L, new TimeSpan(0, 12, 0, 0, 0), 5 },
                    { 49L, new TimeSpan(0, 13, 0, 0, 0), false, false, 7L, new TimeSpan(0, 8, 0, 0, 0), 6 },
                    { 50L, new TimeSpan(0, 17, 0, 0, 0), false, true, 8L, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 51L, new TimeSpan(0, 13, 0, 0, 0), false, false, 8L, new TimeSpan(0, 10, 0, 0, 0), 1 },
                    { 52L, new TimeSpan(0, 13, 0, 0, 0), false, true, 8L, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 53L, new TimeSpan(0, 16, 0, 0, 0), false, false, 8L, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 54L, new TimeSpan(0, 14, 0, 0, 0), false, true, 8L, new TimeSpan(0, 9, 0, 0, 0), 4 },
                    { 55L, new TimeSpan(0, 16, 0, 0, 0), false, true, 8L, new TimeSpan(0, 8, 0, 0, 0), 5 },
                    { 56L, new TimeSpan(0, 14, 0, 0, 0), false, false, 8L, new TimeSpan(0, 8, 0, 0, 0), 6 },
                    { 57L, new TimeSpan(0, 15, 0, 0, 0), false, false, 9L, new TimeSpan(0, 8, 0, 0, 0), 0 },
                    { 58L, new TimeSpan(0, 18, 0, 0, 0), false, false, 9L, new TimeSpan(0, 10, 0, 0, 0), 1 },
                    { 59L, new TimeSpan(0, 18, 0, 0, 0), false, false, 9L, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 60L, new TimeSpan(0, 15, 0, 0, 0), false, true, 9L, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 61L, new TimeSpan(0, 18, 0, 0, 0), false, false, 9L, new TimeSpan(0, 9, 0, 0, 0), 4 },
                    { 62L, new TimeSpan(0, 13, 0, 0, 0), false, true, 9L, new TimeSpan(0, 10, 0, 0, 0), 5 },
                    { 63L, new TimeSpan(0, 13, 0, 0, 0), false, true, 9L, new TimeSpan(0, 12, 0, 0, 0), 6 },
                    { 64L, new TimeSpan(0, 16, 0, 0, 0), false, true, 10L, new TimeSpan(0, 12, 0, 0, 0), 0 },
                    { 65L, new TimeSpan(0, 13, 0, 0, 0), false, false, 10L, new TimeSpan(0, 11, 0, 0, 0), 1 },
                    { 66L, new TimeSpan(0, 15, 0, 0, 0), false, false, 10L, new TimeSpan(0, 12, 0, 0, 0), 2 },
                    { 67L, new TimeSpan(0, 18, 0, 0, 0), false, true, 10L, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 68L, new TimeSpan(0, 15, 0, 0, 0), false, false, 10L, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 69L, new TimeSpan(0, 14, 0, 0, 0), false, false, 10L, new TimeSpan(0, 11, 0, 0, 0), 5 },
                    { 70L, new TimeSpan(0, 13, 0, 0, 0), false, true, 10L, new TimeSpan(0, 10, 0, 0, 0), 6 }
                });

            migrationBuilder.InsertData(
                table: "SlotMembers",
                columns: new[] { "Id", "EventId", "IsDeleted", "MemberId", "Priority", "ScheduleId" },
                values: new object[,]
                {
                    { 1L, 1L, false, 1L, 2, 1L },
                    { 2L, 2L, false, 2L, 7, 2L },
                    { 3L, 3L, false, 3L, 2, 3L },
                    { 4L, 4L, false, 4L, 2, 4L },
                    { 5L, 5L, false, 5L, 4, 5L },
                    { 6L, 6L, false, 6L, 5, 6L },
                    { 7L, 7L, false, 7L, 1, 7L },
                    { 8L, 8L, false, 8L, 2, 8L },
                    { 9L, 9L, false, 9L, 9, 9L },
                    { 10L, 10L, false, 10L, 2, 10L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_AvailabilitySlotId",
                table: "Schedule",
                column: "AvailabilitySlotId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleItem_ScheduleId",
                table: "ScheduleItem",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_SlotMembers_EventId",
                table: "SlotMembers",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_SlotMembers_MemberId",
                table: "SlotMembers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_SlotMembers_ScheduleId",
                table: "SlotMembers",
                column: "ScheduleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleItem");

            migrationBuilder.DropTable(
                name: "SlotMembers");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.CreateTable(
                name: "TeamMemberMeetings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<long>(type: "bigint", nullable: false),
                    MemberId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMemberMeetings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamMemberMeetings_Meetings_EventId",
                        column: x => x.EventId,
                        principalTable: "Meetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamMemberMeetings_Users_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 7, 30, 1, 14 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActivityType", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 6, 6, 3, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 8, 30, 4, 2, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 3, 11, 8, 1, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 7, 28, 6, 2, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 5, 1, 5, 3, 14 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 3, 5, 3, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 7, 14, 8, 1, 7 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 20, 4, 2, 13 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 14, 3, 2, 14 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { new DateTime(2019, 8, 4, 22, 43, 4, 419, DateTimeKind.Unspecified).AddTicks(2216), "http://genesis.name", 4L, "iste", 41, 5L, 0, "officiis" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 5, 22, 10, 13, 20, 947, DateTimeKind.Unspecified).AddTicks(3731), 20, "https://ramona.org", 5L, "temporibus", 29, 8L, 1, "Laudantium omnis beatae aut est vel nihil occaecati voluptates. Ratione repudiandae exercitationem. Minus facilis quasi sequi consequatur blanditiis sunt omnis rerum porro." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 2, 1, 13, 53, 4, 376, DateTimeKind.Unspecified).AddTicks(2838), 17, "https://demarco.biz", "totam", 55, 5L, "nam" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2021, 1, 2, 16, 6, 47, 218, DateTimeKind.Unspecified).AddTicks(7758), 21, "http://teresa.com", 1L, "libero", 22, 1L, 1, "nemo" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 1, 19, 3, 45, 19, 905, DateTimeKind.Unspecified).AddTicks(3858), 29, "https://jayson.name", "magni", 29, 4L, "Ut sunt velit a. Iure atque nesciunt. Id molestiae ab omnis distinctio a nisi omnis recusandae. Non iste officiis illo dolores molestiae earum eos est reiciendis. Vel minus eligendi." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 11, 30, 3, 59, 38, 245, DateTimeKind.Unspecified).AddTicks(8534), 21, "http://johnny.info", 5L, "cupiditate", 36, 9L, "A nihil sapiente quis assumenda incidunt. Aut praesentium mollitia. Ratione similique minus quia." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2019, 12, 23, 11, 28, 42, 719, DateTimeKind.Unspecified).AddTicks(2607), 30, "http://lesley.info", 3L, "dolor", 47, 7L, 1, "Ducimus qui aperiam enim. Ea officiis maxime. Deleniti quia ad aut. Fugiat delectus debitis molestias aspernatur. Nostrum nesciunt quisquam ad quisquam delectus." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 10, 15, 3, 35, 58, 803, DateTimeKind.Unspecified).AddTicks(8928), 28, "https://alysha.name", 1L, "enim", 42, 10L, 1, "Porro quia ipsam nostrum quis aperiam quia reiciendis.\nEos quidem quidem.\nNostrum sit et quas voluptatem sint.\nConsequatur aut minus quos corrupti cumque maiores id.\nVoluptate vel voluptatum reiciendis vero id quibusdam quis qui pariatur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationId", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 4, 23, 20, 47, 50, 369, DateTimeKind.Unspecified).AddTicks(7770), 15, "http://calista.org", 1L, "accusamus", 27, 8L, "Alias repellendus sequi ut ut sint.\nLaborum aut explicabo rerum impedit veniam id incidunt." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 12, 19, 1, 14, 23, 555, DateTimeKind.Unspecified).AddTicks(1075), 29, "https://seth.org", "qui", 30, "A minus error ipsam. Aspernatur voluptatem aut ea pariatur quod. Aut et facere aut et dolorum repellendus. Non maxime voluptatem earum qui. Culpa optio voluptatem tempora sint eos nemo." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 11, 8, 13, 2, 15, 376, DateTimeKind.Unspecified).AddTicks(6182), 5L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 12, 3, 22, 39, 46, 879, DateTimeKind.Unspecified).AddTicks(343), 9L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2019, 9, 16, 21, 16, 27, 409, DateTimeKind.Unspecified).AddTicks(2531), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 12, 13, 0, 40, 44, 260, DateTimeKind.Unspecified).AddTicks(709), 7L, 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 5, 31, 5, 17, 54, 329, DateTimeKind.Unspecified).AddTicks(8612), 6L, 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 7, 15, 13, 5, 42, 5, DateTimeKind.Unspecified).AddTicks(6910), 7L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 2, 28, 15, 28, 34, 943, DateTimeKind.Unspecified).AddTicks(2372), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 8, 6, 17, 50, 7, 929, DateTimeKind.Unspecified).AddTicks(4079), 9L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2021, 2, 25, 23, 42, 19, 617, DateTimeKind.Unspecified).AddTicks(7407), 10L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 3L, new DateTime(2021, 7, 10, 11, 37, 7, 127, DateTimeKind.Unspecified).AddTicks(6415), 3L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(7681), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 18, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(7513), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(7937), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 18, 4, 4, 17, 449, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Hannah.Vandervort39@hotmail.c", new DateTimeOffset(new DateTime(2023, 7, 22, 17, 4, 31, 833, DateTimeKind.Unspecified).AddTicks(947), new TimeSpan(0, 3, 0, 0, 0)), "Hannah Vandervort" });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 6, 3, 11, 36, 36, 869, DateTimeKind.Unspecified).AddTicks(6739), 7L, "Et non impedit eaque repellendus.\nAutem nobis nobi", 49, "tenetur", new DateTimeOffset(new DateTime(2023, 3, 15, 7, 42, 40, 985, DateTimeKind.Unspecified).AddTicks(3680), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 4, 5, 5, 41, 12, 556, DateTimeKind.Unspecified).AddTicks(8538), "animi", 28, 4L, "eum", new DateTimeOffset(new DateTime(2023, 2, 16, 6, 45, 45, 748, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, 2, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 9, 15, 4, 39, 482, DateTimeKind.Unspecified).AddTicks(9178), "Commodi unde perferendis ducimus modi nihil rerum", 26, 4L, "inventore", new DateTimeOffset(new DateTime(2023, 4, 4, 0, 13, 51, 485, DateTimeKind.Unspecified).AddTicks(9697), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 1, 24, 16, 9, 35, 494, DateTimeKind.Unspecified).AddTicks(9409), 2L, "Sit facere expedita eaque accusamus molestias id e", 41, 4L, "sed", new DateTimeOffset(new DateTime(2023, 2, 15, 17, 42, 46, 416, DateTimeKind.Unspecified).AddTicks(7511), new TimeSpan(0, 2, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 12, 25, 16, 18, 12, 62, DateTimeKind.Unspecified).AddTicks(6991), 6L, "Dolorum dolorum architecto et voluptas nostrum qui", 34, 1L, "ipsam", new DateTimeOffset(new DateTime(2022, 11, 6, 10, 40, 23, 93, DateTimeKind.Unspecified).AddTicks(8445), new TimeSpan(0, 2, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime" },
                values: new object[] { new DateTime(2021, 1, 23, 4, 21, 3, 828, DateTimeKind.Unspecified).AddTicks(3973), 4L, "Labore est fugit quos dolorum sed quia iusto quod.", 27, 2L, "et", new DateTimeOffset(new DateTime(2022, 12, 18, 11, 12, 54, 355, DateTimeKind.Unspecified).AddTicks(8028), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 3, 18, 13, 21, 5, 676, DateTimeKind.Unspecified).AddTicks(4428), 9L, "ut", 19, 5L, "mollitia", new DateTimeOffset(new DateTime(2023, 4, 18, 2, 36, 18, 746, DateTimeKind.Unspecified).AddTicks(7211), new TimeSpan(0, 3, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 11, 12, 3, 39, 42, 658, DateTimeKind.Unspecified).AddTicks(5909), 2L, "Omnis eaque sapiente nisi alias dolore.", 39, 2L, "ex", new DateTimeOffset(new DateTime(2022, 9, 9, 13, 3, 37, 353, DateTimeKind.Unspecified).AddTicks(1458), new TimeSpan(0, 3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 10, 5, 50, 28, 861, DateTimeKind.Unspecified).AddTicks(2539), "Pariatur autem quidem quia similique amet voluptat", 47, 4L, "explicabo", new DateTimeOffset(new DateTime(2023, 7, 8, 9, 0, 17, 833, DateTimeKind.Unspecified).AddTicks(8287), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationId", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 9, 25, 14, 28, 41, 735, DateTimeKind.Unspecified).AddTicks(458), 7L, "odio", 12, 2L, "sunt", new DateTimeOffset(new DateTime(2022, 12, 11, 3, 41, 32, 352, DateTimeKind.Unspecified).AddTicks(1878), new TimeSpan(0, 2, 0, 0, 0)), 8L });

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
                column: "Text",
                value: "Occaecati rem qui modi magni quos velit hic.\nDelectus laborum totam ea quibusdam cumque iusto molestiae tenetur.\nIpsa nulla id veritatis.\nAutem sit aliquid sed et et ea autem.\nAutem temporibus consequuntur molestias sunt sunt.\nMolestiae est occaecati sed non.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Cupiditate consequuntur at aperiam fugiat. Magni dolorum eum voluptatum. Pariatur qui laborum rem vel officia non harum. Quia ut quod possimus. Quia qui delectus corrupti voluptates modi. Fugit aliquid illo debitis quis et." });

            migrationBuilder.InsertData(
                table: "TeamMemberMeetings",
                columns: new[] { "Id", "EventId", "IsDeleted", "MemberId", "Priority" },
                values: new object[,]
                {
                    { 1L, 1L, false, 1L, 9 },
                    { 2L, 2L, false, 2L, 2 },
                    { 3L, 3L, false, 3L, 10 },
                    { 4L, 4L, false, 4L, 10 },
                    { 5L, 5L, false, 5L, 8 },
                    { 6L, 6L, false, 6L, 3 },
                    { 7L, 7L, false, 7L, 8 },
                    { 8L, 8L, false, 8L, 3 },
                    { 9L, 9L, false, 9L, 5 },
                    { 10L, 10L, false, 10L, 1 }
                });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Status",
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
                keyValue: 3L,
                column: "Role",
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
                column: "Role",
                value: 1);

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

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
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Sherri_Goodwin@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/13.jpg", "Sherri Goodwin", "311-956-45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Dennis72@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/980.jpg", "Dennis Yundt", "(387) 827-", 0 });

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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Rebecca.Sanford@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/47.jpg", "Rebecca Sanford", "888.482.76", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Jacob_Labadie24@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/249.jpg", "Jacob Labadie", "1-770-707-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Allen16@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/118.jpg", "Allen Muller", "834-241-53", 0 });

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
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Lillie_Schmeler@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/669.jpg", "Lillie Schmeler", "254-356-67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Elsa.Hegmann@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/547.jpg", "Elsa Hegmann", "(348) 379-" });

            migrationBuilder.CreateIndex(
                name: "IX_TeamMemberMeetings_EventId",
                table: "TeamMemberMeetings",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMemberMeetings_MemberId",
                table: "TeamMemberMeetings",
                column: "MemberId");
        }
    }
}
