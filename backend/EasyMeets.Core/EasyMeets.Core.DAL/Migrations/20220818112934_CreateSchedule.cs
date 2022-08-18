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
                name: "Schedules",
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
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_AvailabilitySlots_AvailabilitySlotId",
                        column: x => x.AvailabilitySlotId,
                        principalTable: "AvailabilitySlots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleItems",
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
                    table.PrimaryKey("PK_ScheduleItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleItems_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
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
                        name: "FK_SlotMembers_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
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
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 8, 27, 9, 4, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 5, 8, 7, 1, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 12, 2, 4, 10 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 4, 3, 8, 3, 14 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 1, 9, 1, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 6, 13, 4, 5, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days" },
                values: new object[] { 2, 5, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 4, 20, 4, 15 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 19, 7, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 5, 12, 10, 1, 3 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 6, 13, 17, 44, 46, 746, DateTimeKind.Unspecified).AddTicks(2701), 17, "https://myles.info", "non", 54, 9L, "Nemo distinctio quo ipsa similique qui.\nDucimus est ea voluptas quos enim omnis excepturi nulla eius.\nQui cum ipsa.\nExercitationem nulla repellendus atque voluptatem omnis vel distinctio aut dolore." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 10, 23, 4, 37, 32, 611, DateTimeKind.Unspecified).AddTicks(8419), 16, "http://layla.net", "vitae", 40, 9L, "dolores" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 1, 23, 13, 41, 51, 773, DateTimeKind.Unspecified).AddTicks(7040), 20, "http://terrance.org", 0, "quos", 29, 9L, 1, "Optio laudantium aliquid ex voluptas fugiat autem et aut minus. Sed nostrum tempore aut ipsa quo et ea quos. Ut ut nam deserunt quia autem culpa. Quia et ut et ut aliquam autem. Et ut id debitis saepe omnis et. Quos repellat quod rerum vitae rerum ut culpa et." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2019, 10, 10, 13, 5, 53, 511, DateTimeKind.Unspecified).AddTicks(5943), 21, "http://mario.com", 1, "qui", 37, 9L, 0, "error" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 8, 15, 8, 36, 30, 837, DateTimeKind.Unspecified).AddTicks(471), 25, "http://darion.org", "ipsa", 29, "aut" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2019, 11, 9, 23, 22, 41, 12, DateTimeKind.Unspecified).AddTicks(1269), 15, "https://jayne.biz", 1, "vel", 33, 5L, "Ut qui vero et sed qui facere quaerat. Blanditiis delectus necessitatibus molestias sunt odit vitae. Voluptates eum iste velit quia rerum. Illum labore amet voluptate eaque." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 7, 21, 10, 21, 42, 108, DateTimeKind.Unspecified).AddTicks(7603), 28, "https://ferne.com", 2, "aut", 36, 1L, 0, "illo" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 8, 14, 9, 0, 32, 904, DateTimeKind.Unspecified).AddTicks(9022), 26, "http://sherwood.com", "accusantium", 24, 8L, 1, "Blanditiis repellat ea nam porro possimus at quidem possimus.\nNon accusamus qui et ut et eius qui." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 3, 11, 21, 53, 52, 278, DateTimeKind.Unspecified).AddTicks(8397), 23, "https://celia.name", "sapiente", 50, 9L, "Voluptate rerum consequatur omnis ullam accusamus. Excepturi cumque nam in aliquid tempora quibusdam recusandae eius. Ut ut quod quo ea nam dolorem ullam ipsa corporis. Similique est iusto. Doloribus ad quas vel modi. Omnis quibusdam aut." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 5, 15, 15, 54, 28, 546, DateTimeKind.Unspecified).AddTicks(5043), 26, "http://hillard.org", 2, "quibusdam", 50, 10L, "Impedit quia dolorum.\nVero et corporis voluptate eos et nihil ea esse.\nReprehenderit rerum molestias dolores.\nIpsa delectus voluptatem optio." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 5, 29, 5, 55, 5, 438, DateTimeKind.Unspecified).AddTicks(5824), 3L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 4, 27, 1, 47, 7, 125, DateTimeKind.Unspecified).AddTicks(8318), 3L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2020, 1, 22, 3, 45, 37, 668, DateTimeKind.Unspecified).AddTicks(554), 9L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2021, 2, 6, 11, 59, 54, 244, DateTimeKind.Unspecified).AddTicks(4869), 1L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2019, 9, 21, 3, 3, 55, 465, DateTimeKind.Unspecified).AddTicks(3676), 7L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2021, 1, 20, 8, 26, 45, 0, DateTimeKind.Unspecified).AddTicks(5710), 1L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 10, 25, 18, 33, 57, 779, DateTimeKind.Unspecified).AddTicks(6091), 1L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2019, 8, 20, 0, 50, 43, 595, DateTimeKind.Unspecified).AddTicks(8909), 8L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2019, 11, 8, 18, 25, 28, 155, DateTimeKind.Unspecified).AddTicks(6617), 8L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 10, 2, 8, 27, 26, 507, DateTimeKind.Unspecified).AddTicks(3967), 2L, 2L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3105), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 19, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(2990), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3286), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 19, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3277), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3305), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 19, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3299), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3323), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 19, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3317), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3340), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3334), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3357), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 19, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3352), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3375), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 19, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3369), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3392), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 19, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3386), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3415), new TimeSpan(0, 3, 0, 0, 0)), 7L, new DateTimeOffset(new DateTime(2022, 8, 19, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3407), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3439), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 19, 14, 29, 32, 945, DateTimeKind.Unspecified).AddTicks(3431), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Eugene.King@gmail.com", new DateTimeOffset(new DateTime(2022, 11, 19, 12, 5, 49, 306, DateTimeKind.Unspecified).AddTicks(3484), new TimeSpan(0, 2, 0, 0, 0)), "Eugene King" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Andy_Schulist@gmail.com", new DateTimeOffset(new DateTime(2023, 5, 6, 10, 55, 10, 869, DateTimeKind.Unspecified).AddTicks(9261), new TimeSpan(0, 3, 0, 0, 0)), "Andy Schulist" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Julian14@hotmail.com", new DateTimeOffset(new DateTime(2022, 10, 24, 16, 34, 46, 426, DateTimeKind.Unspecified).AddTicks(2390), new TimeSpan(0, 3, 0, 0, 0)), "Julian Cummerata" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Kenny_Hermann69@yahoo.com", new DateTimeOffset(new DateTime(2023, 4, 1, 20, 59, 46, 826, DateTimeKind.Unspecified).AddTicks(1486), new TimeSpan(0, 3, 0, 0, 0)), "Kenny Hermann" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 4L, "Mabel.Bahringer@yahoo.com", new DateTimeOffset(new DateTime(2023, 2, 4, 8, 35, 21, 940, DateTimeKind.Unspecified).AddTicks(819), new TimeSpan(0, 2, 0, 0, 0)), "Mabel Bahringer" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Marshall.Shanahan@hotmail.com", new DateTimeOffset(new DateTime(2023, 2, 1, 7, 10, 48, 935, DateTimeKind.Unspecified).AddTicks(6062), new TimeSpan(0, 2, 0, 0, 0)), "Marshall Shanahan" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Alexandra88@gmail.com", new DateTimeOffset(new DateTime(2023, 1, 14, 5, 36, 28, 340, DateTimeKind.Unspecified).AddTicks(2176), new TimeSpan(0, 2, 0, 0, 0)), "Alexandra Wolff" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Kelvin35@gmail.com", new DateTimeOffset(new DateTime(2023, 3, 14, 1, 29, 31, 721, DateTimeKind.Unspecified).AddTicks(8759), new TimeSpan(0, 2, 0, 0, 0)), "Kelvin Torphy" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Penny30@yahoo.com", new DateTimeOffset(new DateTime(2022, 9, 26, 11, 56, 17, 844, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 3, 0, 0, 0)), "Penny Purdy" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Claire.Torp@gmail.com", new DateTimeOffset(new DateTime(2022, 11, 24, 5, 21, 9, 548, DateTimeKind.Unspecified).AddTicks(5606), new TimeSpan(0, 2, 0, 0, 0)), "Claire Torp" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 9, 8, 3, 45, 2, 849, DateTimeKind.Unspecified).AddTicks(7979), 2L, "earum", 15, 2, "vel", new DateTimeOffset(new DateTime(2023, 4, 29, 4, 12, 25, 148, DateTimeKind.Unspecified).AddTicks(1705), new TimeSpan(0, 3, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationType", "Name", "StartTime" },
                values: new object[] { new DateTime(2021, 1, 25, 13, 56, 2, 770, DateTimeKind.Unspecified).AddTicks(69), "enim", 17, 1, "nihil", new DateTimeOffset(new DateTime(2023, 6, 27, 4, 27, 36, 99, DateTimeKind.Unspecified).AddTicks(5078), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 25, 11, 58, 20, 817, DateTimeKind.Unspecified).AddTicks(4374), 4L, "Sit facere recusandae praesentium laborum minima n", 47, "numquam", new DateTimeOffset(new DateTime(2022, 10, 17, 6, 59, 44, 747, DateTimeKind.Unspecified).AddTicks(9726), new TimeSpan(0, 3, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 5, 27, 21, 28, 37, 725, DateTimeKind.Unspecified).AddTicks(4411), 3L, "Voluptatem officiis nam delectus est iste odio seq", 2, "totam", new DateTimeOffset(new DateTime(2022, 10, 15, 14, 11, 55, 723, DateTimeKind.Unspecified).AddTicks(1539), new TimeSpan(0, 3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 3, 12, 5, 39, 31, 145, DateTimeKind.Unspecified).AddTicks(1720), 9L, "voluptas", 28, 0, "autem", new DateTimeOffset(new DateTime(2022, 10, 28, 6, 14, 40, 508, DateTimeKind.Unspecified).AddTicks(251), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 11, 14, 19, 9, 8, 629, DateTimeKind.Unspecified).AddTicks(6621), 5L, "Asperiores commodi reprehenderit quod mollitia deb", 45, 1, "eaque", new DateTimeOffset(new DateTime(2022, 11, 8, 9, 44, 5, 434, DateTimeKind.Unspecified).AddTicks(4035), new TimeSpan(0, 2, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 6, 14, 6, 9, 34, 215, DateTimeKind.Unspecified).AddTicks(9567), 7L, "Voluptate molestiae qui rerum recusandae quasi sin", 37, 0, "id", new DateTimeOffset(new DateTime(2023, 4, 10, 19, 57, 10, 939, DateTimeKind.Unspecified).AddTicks(7956), new TimeSpan(0, 3, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 28, 8, 51, 16, 890, DateTimeKind.Unspecified).AddTicks(6985), 4L, "Ut perferendis enim.\nNemo totam quidem quod est su", 46, 0, "temporibus", new DateTimeOffset(new DateTime(2022, 9, 30, 10, 36, 10, 756, DateTimeKind.Unspecified).AddTicks(7441), new TimeSpan(0, 3, 0, 0, 0)), 6L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 25, 12, 38, 21, 145, DateTimeKind.Unspecified).AddTicks(1754), 4L, "Dolore rem commodi a assumenda eos temporibus. Rem", 41, 1, "reiciendis", new DateTimeOffset(new DateTime(2022, 12, 19, 11, 1, 8, 123, DateTimeKind.Unspecified).AddTicks(9836), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 16, 20, 26, 56, 330, DateTimeKind.Unspecified).AddTicks(6767), 6L, "Rerum a ratione.", 30, "officia", new DateTimeOffset(new DateTime(2022, 8, 30, 0, 46, 56, 805, DateTimeKind.Unspecified).AddTicks(8199), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "Aut quo laborum rerum modi. Explicabo et expedita totam optio voluptas ut reiciendis aut expedita. Sit aut deleniti beatae cumque omnis. Quibusdam nulla consequatur necessitatibus. Laudantium exercitationem recusandae possimus enim nostrum." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Necessitatibus rem et. Cupiditate sequi fugit veritatis non. Nesciunt tempora odio vel quaerat odit. Voluptas voluptatum voluptas vitae quia. Porro sunt explicabo velit." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "quibusdamAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Sit eos et sunt deserunt eveniet incidunt eos id cupiditate.\nReprehenderit tenetur quia ullam inventore qui velit non.\nUllam nisi eveniet id ipsam est saepe esse.\nQuibusdam aut deleniti." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "inventoreAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Voluptas numquam aut accusamus quidem maiores alias.\nSoluta quia sed esse voluptatem occaecati ea quia.\nBeatae voluptas quos ut aperiam odio." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Text",
                value: "Id soluta culpa.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Architecto sint occaecati.AAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Text",
                value: "Nam aperiam iste deserunt sed. Id et qui distinctio vero veritatis itaque dolores nesciunt. Vel non qui laborum error exercitationem voluptatem nam doloribus quod. Saepe aliquam corporis id harum minus ea molestiae voluptatum. Nihil aperiam omnis.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Iste quaerat id doloremque rerum optio et.\nExplicabo ipsa repellendus sint unde.\nAccusantium sapiente consequuntur.\nUllam non asperiores quibusdam voluptatum.\nAliquam velit voluptatibus veniam et maiores et odio." });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "AvailabilitySlotId", "IsDeleted", "TimeZone", "WithTeamMembers" },
                values: new object[,]
                {
                    { 1L, 1L, false, -120, true },
                    { 2L, 2L, false, -120, true },
                    { 3L, 3L, false, -600, true },
                    { 4L, 4L, false, 0, false },
                    { 5L, 5L, false, -300, true },
                    { 6L, 6L, false, 60, false },
                    { 7L, 7L, false, 660, false },
                    { 8L, 8L, false, -600, true },
                    { 9L, 9L, false, -540, false },
                    { 10L, 10L, false, 240, false }
                });

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 2 });

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
                column: "Role",
                value: 1);

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
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Dolores magnam saepe eligendi quo et ducimus iusto tempora.\nNemo non aspernatur.\nEligendi aliquam corrupti qui rerum qui et quos ducimus.", "Bergstrom Inc", "http://brooks.name" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Iusto doloribus provident expedita voluptatum sapiente neque officia.", "Beatty - Hane", "http://shyanne.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Unde quas velit eos maxime ut.\nVoluptas qui voluptas rerum saepe consectetur esse ut ea.\nLabore est ut porro.\nEligendi omnis libero illo qui qui soluta deserunt praesentium.\nFacere illo dolorum quaerat animi enim quia velit id reiciendis.", "Ortiz Inc", "https://willis.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Vitae ut voluptas quos distinctio sint.\nEt et saepe ut earum aut sunt enim impedit.\nUt nihil aut facilis debitis architecto aut dolores qui.\nIusto molestias repellendus ut et sed qui quae voluptas.", "Marvin, Langworth and Hickle", "http://stanford.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "dolores", "Howe Inc", "https://mariane.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Ut repellendus quia facilis nisi.\nUt quis eum.\nBeatae aperiam dolor alias.\nQuis sint molestiae laborum voluptatem.\nDebitis totam ex sed rerum molestiae quasi ut.\nIllo quia consequuntur culpa.", "Langworth Group", "http://jamir.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Perspiciatis neque excepturi.", "Nitzsche, Langworth and Mueller", "https://jada.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Dolores eligendi ut nulla rerum voluptate autem aspernatur.", "Little, Schmitt and Bode", "http://josue.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "nostrum", "Mitchell, Friesen and Batz", "https://jaqueline.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Ut nesciunt nobis sequi cum dolores ea est eius.\nEt laboriosam natus atque cumque aspernatur cum.\nQuia dicta odio et earum eum molestiae ullam enim.\nCupiditate est corporis id tempore expedita rem perferendis alias.\nNam eos non iusto illo veritatis.", "Cremin and Sons", "http://ardella.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Jose95@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/777.jpg", "Jose Pfannerstill", "977.703.80", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Lewis.McLaughlin51@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/803.jpg", "Lewis McLaughlin", "233.764.76", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Christine46@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1185.jpg", "Christine Runte", "(617) 964-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Irvin_Predovic@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1238.jpg", "Irvin Predovic", "324.768.92", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Norma16@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/947.jpg", "Norma Sipes", "(574) 200-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Brittany_Langworth@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/214.jpg", "Brittany Langworth", "(642) 801-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Nathaniel.Bernier3@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/359.jpg", "Nathaniel Bernier", "407.512.45", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Rosemary_Lakin51@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/80.jpg", "Rosemary Lakin", "(786) 837-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Lance_Trantow@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/343.jpg", "Lance Trantow", "(821) 567-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Jenna_Bashirian23@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/505.jpg", "Jenna Bashirian", "1-472-974-", 0 });

            migrationBuilder.InsertData(
                table: "ScheduleItems",
                columns: new[] { "Id", "End", "IsDeleted", "IsEnabled", "ScheduleId", "Start", "WeekDay" },
                values: new object[,]
                {
                    { 1L, new TimeSpan(0, 15, 0, 0, 0), false, true, 1L, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 2L, new TimeSpan(0, 18, 0, 0, 0), false, true, 1L, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 3L, new TimeSpan(0, 15, 0, 0, 0), false, true, 1L, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 4L, new TimeSpan(0, 13, 0, 0, 0), false, true, 1L, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 5L, new TimeSpan(0, 14, 0, 0, 0), false, false, 1L, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 6L, new TimeSpan(0, 16, 0, 0, 0), false, false, 1L, new TimeSpan(0, 10, 0, 0, 0), 5 },
                    { 7L, new TimeSpan(0, 13, 0, 0, 0), false, false, 1L, new TimeSpan(0, 10, 0, 0, 0), 6 },
                    { 8L, new TimeSpan(0, 13, 0, 0, 0), false, true, 2L, new TimeSpan(0, 11, 0, 0, 0), 0 },
                    { 9L, new TimeSpan(0, 15, 0, 0, 0), false, true, 2L, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 10L, new TimeSpan(0, 18, 0, 0, 0), false, true, 2L, new TimeSpan(0, 8, 0, 0, 0), 2 },
                    { 11L, new TimeSpan(0, 18, 0, 0, 0), false, true, 2L, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 12L, new TimeSpan(0, 14, 0, 0, 0), false, true, 2L, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 13L, new TimeSpan(0, 15, 0, 0, 0), false, true, 2L, new TimeSpan(0, 9, 0, 0, 0), 5 },
                    { 14L, new TimeSpan(0, 13, 0, 0, 0), false, true, 2L, new TimeSpan(0, 9, 0, 0, 0), 6 },
                    { 15L, new TimeSpan(0, 13, 0, 0, 0), false, false, 3L, new TimeSpan(0, 8, 0, 0, 0), 0 },
                    { 16L, new TimeSpan(0, 16, 0, 0, 0), false, true, 3L, new TimeSpan(0, 10, 0, 0, 0), 1 },
                    { 17L, new TimeSpan(0, 14, 0, 0, 0), false, false, 3L, new TimeSpan(0, 10, 0, 0, 0), 2 },
                    { 18L, new TimeSpan(0, 15, 0, 0, 0), false, false, 3L, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 19L, new TimeSpan(0, 14, 0, 0, 0), false, false, 3L, new TimeSpan(0, 9, 0, 0, 0), 4 },
                    { 20L, new TimeSpan(0, 16, 0, 0, 0), false, false, 3L, new TimeSpan(0, 9, 0, 0, 0), 5 },
                    { 21L, new TimeSpan(0, 14, 0, 0, 0), false, true, 3L, new TimeSpan(0, 12, 0, 0, 0), 6 },
                    { 22L, new TimeSpan(0, 13, 0, 0, 0), false, false, 4L, new TimeSpan(0, 12, 0, 0, 0), 0 },
                    { 23L, new TimeSpan(0, 16, 0, 0, 0), false, true, 4L, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 24L, new TimeSpan(0, 18, 0, 0, 0), false, false, 4L, new TimeSpan(0, 10, 0, 0, 0), 2 },
                    { 25L, new TimeSpan(0, 15, 0, 0, 0), false, false, 4L, new TimeSpan(0, 12, 0, 0, 0), 3 },
                    { 26L, new TimeSpan(0, 18, 0, 0, 0), false, false, 4L, new TimeSpan(0, 9, 0, 0, 0), 4 },
                    { 27L, new TimeSpan(0, 16, 0, 0, 0), false, true, 4L, new TimeSpan(0, 12, 0, 0, 0), 5 },
                    { 28L, new TimeSpan(0, 13, 0, 0, 0), false, false, 4L, new TimeSpan(0, 9, 0, 0, 0), 6 },
                    { 29L, new TimeSpan(0, 15, 0, 0, 0), false, false, 5L, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 30L, new TimeSpan(0, 16, 0, 0, 0), false, false, 5L, new TimeSpan(0, 11, 0, 0, 0), 1 },
                    { 31L, new TimeSpan(0, 16, 0, 0, 0), false, true, 5L, new TimeSpan(0, 10, 0, 0, 0), 2 },
                    { 32L, new TimeSpan(0, 18, 0, 0, 0), false, true, 5L, new TimeSpan(0, 12, 0, 0, 0), 3 },
                    { 33L, new TimeSpan(0, 17, 0, 0, 0), false, true, 5L, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 34L, new TimeSpan(0, 13, 0, 0, 0), false, true, 5L, new TimeSpan(0, 8, 0, 0, 0), 5 },
                    { 35L, new TimeSpan(0, 16, 0, 0, 0), false, true, 5L, new TimeSpan(0, 8, 0, 0, 0), 6 },
                    { 36L, new TimeSpan(0, 18, 0, 0, 0), false, true, 6L, new TimeSpan(0, 12, 0, 0, 0), 0 },
                    { 37L, new TimeSpan(0, 13, 0, 0, 0), false, true, 6L, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 38L, new TimeSpan(0, 18, 0, 0, 0), false, false, 6L, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 39L, new TimeSpan(0, 18, 0, 0, 0), false, true, 6L, new TimeSpan(0, 12, 0, 0, 0), 3 },
                    { 40L, new TimeSpan(0, 18, 0, 0, 0), false, true, 6L, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 41L, new TimeSpan(0, 15, 0, 0, 0), false, true, 6L, new TimeSpan(0, 10, 0, 0, 0), 5 },
                    { 42L, new TimeSpan(0, 18, 0, 0, 0), false, false, 6L, new TimeSpan(0, 9, 0, 0, 0), 6 }
                });

            migrationBuilder.InsertData(
                table: "ScheduleItems",
                columns: new[] { "Id", "End", "IsDeleted", "IsEnabled", "ScheduleId", "Start", "WeekDay" },
                values: new object[,]
                {
                    { 43L, new TimeSpan(0, 15, 0, 0, 0), false, false, 7L, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 44L, new TimeSpan(0, 13, 0, 0, 0), false, true, 7L, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 45L, new TimeSpan(0, 14, 0, 0, 0), false, true, 7L, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 46L, new TimeSpan(0, 16, 0, 0, 0), false, false, 7L, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 47L, new TimeSpan(0, 18, 0, 0, 0), false, true, 7L, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 48L, new TimeSpan(0, 16, 0, 0, 0), false, true, 7L, new TimeSpan(0, 12, 0, 0, 0), 5 },
                    { 49L, new TimeSpan(0, 17, 0, 0, 0), false, true, 7L, new TimeSpan(0, 10, 0, 0, 0), 6 },
                    { 50L, new TimeSpan(0, 14, 0, 0, 0), false, false, 8L, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 51L, new TimeSpan(0, 15, 0, 0, 0), false, true, 8L, new TimeSpan(0, 10, 0, 0, 0), 1 },
                    { 52L, new TimeSpan(0, 13, 0, 0, 0), false, false, 8L, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 53L, new TimeSpan(0, 17, 0, 0, 0), false, false, 8L, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 54L, new TimeSpan(0, 16, 0, 0, 0), false, true, 8L, new TimeSpan(0, 11, 0, 0, 0), 4 },
                    { 55L, new TimeSpan(0, 18, 0, 0, 0), false, true, 8L, new TimeSpan(0, 12, 0, 0, 0), 5 },
                    { 56L, new TimeSpan(0, 15, 0, 0, 0), false, true, 8L, new TimeSpan(0, 8, 0, 0, 0), 6 },
                    { 57L, new TimeSpan(0, 16, 0, 0, 0), false, false, 9L, new TimeSpan(0, 12, 0, 0, 0), 0 },
                    { 58L, new TimeSpan(0, 16, 0, 0, 0), false, true, 9L, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 59L, new TimeSpan(0, 14, 0, 0, 0), false, true, 9L, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 60L, new TimeSpan(0, 14, 0, 0, 0), false, true, 9L, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 61L, new TimeSpan(0, 18, 0, 0, 0), false, true, 9L, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 62L, new TimeSpan(0, 16, 0, 0, 0), false, true, 9L, new TimeSpan(0, 12, 0, 0, 0), 5 },
                    { 63L, new TimeSpan(0, 18, 0, 0, 0), false, false, 9L, new TimeSpan(0, 12, 0, 0, 0), 6 },
                    { 64L, new TimeSpan(0, 16, 0, 0, 0), false, true, 10L, new TimeSpan(0, 8, 0, 0, 0), 0 },
                    { 65L, new TimeSpan(0, 14, 0, 0, 0), false, false, 10L, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 66L, new TimeSpan(0, 13, 0, 0, 0), false, false, 10L, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 67L, new TimeSpan(0, 14, 0, 0, 0), false, true, 10L, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 68L, new TimeSpan(0, 14, 0, 0, 0), false, true, 10L, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 69L, new TimeSpan(0, 18, 0, 0, 0), false, false, 10L, new TimeSpan(0, 10, 0, 0, 0), 5 },
                    { 70L, new TimeSpan(0, 18, 0, 0, 0), false, true, 10L, new TimeSpan(0, 10, 0, 0, 0), 6 }
                });

            migrationBuilder.InsertData(
                table: "SlotMembers",
                columns: new[] { "Id", "EventId", "IsDeleted", "MemberId", "Priority", "ScheduleId" },
                values: new object[,]
                {
                    { 1L, 1L, false, 1L, 3, 1L },
                    { 2L, 2L, false, 2L, 6, 2L },
                    { 3L, 3L, false, 3L, 8, 3L },
                    { 4L, 4L, false, 4L, 6, 4L },
                    { 5L, 5L, false, 5L, 8, 5L },
                    { 6L, 6L, false, 6L, 10, 6L },
                    { 7L, 7L, false, 7L, 10, 7L },
                    { 8L, 8L, false, 8L, 3, 8L },
                    { 9L, 9L, false, 9L, 1, 9L },
                    { 10L, 10L, false, 10L, 9, 10L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleItems_ScheduleId",
                table: "ScheduleItems",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_AvailabilitySlotId",
                table: "Schedules",
                column: "AvailabilitySlotId",
                unique: true);

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
                name: "ScheduleItems");

            migrationBuilder.DropTable(
                name: "SlotMembers");

            migrationBuilder.DropTable(
                name: "Schedules");

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
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 2, 13, 10, 1, 10 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 26, 8, 2, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 7, 25, 10, 2, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 7, 4, 1, 5, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ActivityType", "Color", "Days", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 3, 26, 4, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 11, 8, 4, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days" },
                values: new object[] { 1, 7, 27 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 8, 25, 1, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 29, 8, 13 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 19, 5, 4, 9 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 10, 25, 3, 34, 5, 290, DateTimeKind.Unspecified).AddTicks(972), 15, "https://caroline.name", "animi", 44, 4L, "Quia delectus facere non.\nHarum facilis assumenda accusamus qui sed et repellat vero dolores.\nLibero et qui facilis sed nobis ut.\nQuaerat iure perferendis placeat aliquam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 7, 22, 23, 58, 11, 273, DateTimeKind.Unspecified).AddTicks(6525), 17, "http://antonia.org", "illo", 22, 7L, "Ut voluptatibus dolore necessitatibus dolores soluta nihil. Et omnis nobis rem qui accusamus rerum aut a vero. Voluptatum quos voluptatem tenetur officiis non sint sit quia." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2019, 8, 10, 15, 10, 12, 718, DateTimeKind.Unspecified).AddTicks(4011), 17, "http://lindsey.org", 1, "officia", 33, 5L, 0, "Veritatis sed saepe." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 10, 11, 18, 43, 57, 540, DateTimeKind.Unspecified).AddTicks(532), 30, "https://madalyn.org", 0, "esse", 48, 4L, 1, "Architecto suscipit ratione voluptatem aut ut iusto aut voluptates.\nSit ea et non omnis consectetur." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 7, 6, 20, 0, 0, 590, DateTimeKind.Unspecified).AddTicks(2067), 28, "http://jeff.com", "voluptates", 30, "Laborum necessitatibus molestiae voluptate libero." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2021, 6, 5, 17, 56, 55, 88, DateTimeKind.Unspecified).AddTicks(4080), 23, "https://cielo.biz", 0, "eligendi", 50, 4L, "Dolorem provident aut rerum non.\nRatione explicabo doloribus omnis autem deleniti.\nQuo iste deleniti omnis minus voluptatem eaque.\nMinus non labore aut et ea.\nCorporis molestiae facilis et ut ut rerum dolorem aut provident.\nEaque omnis quos dolore aliquid magnam culpa." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2021, 6, 19, 10, 43, 21, 298, DateTimeKind.Unspecified).AddTicks(8672), 17, "https://jermaine.biz", 0, "numquam", 31, 7L, 1, "exercitationem" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 1, 22, 6, 42, 43, 754, DateTimeKind.Unspecified).AddTicks(6794), 16, "http://petra.net", "et", 53, 5L, 0, "Minima consequatur est eos." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 1, 2, 15, 49, 41, 765, DateTimeKind.Unspecified).AddTicks(3875), 15, "https://ronny.name", "error", 31, 10L, "Non aut et et. Architecto molestiae ut dolor veritatis velit. Eos qui hic omnis velit velit consequatur suscipit totam quo. Omnis facilis sunt et iusto omnis deserunt. Repudiandae qui ipsam facere est vero aspernatur amet." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 2, 7, 11, 54, 54, 533, DateTimeKind.Unspecified).AddTicks(601), 28, "https://antoinette.biz", 1, "ab", 38, 2L, "Corporis laboriosam maiores. Voluptatem necessitatibus vel atque eum quia voluptatem soluta iusto. Aut perspiciatis dolores dignissimos voluptates provident. Quia ea corporis dignissimos." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 3L, new DateTime(2021, 3, 31, 19, 51, 14, 149, DateTimeKind.Unspecified).AddTicks(2398), 8L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2020, 1, 6, 4, 22, 54, 746, DateTimeKind.Unspecified).AddTicks(9275), 4L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2021, 6, 15, 20, 41, 27, 659, DateTimeKind.Unspecified).AddTicks(2725), 6L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 9, 21, 1, 52, 34, 269, DateTimeKind.Unspecified).AddTicks(170), 9L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2020, 7, 15, 13, 15, 42, 875, DateTimeKind.Unspecified).AddTicks(2959), 5L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2021, 4, 22, 2, 58, 9, 460, DateTimeKind.Unspecified).AddTicks(2220), 2L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2021, 6, 30, 16, 0, 22, 673, DateTimeKind.Unspecified).AddTicks(6553), 9L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2019, 8, 28, 22, 2, 22, 90, DateTimeKind.Unspecified).AddTicks(2472), 6L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 12, 20, 7, 37, 42, 161, DateTimeKind.Unspecified).AddTicks(4263), 10L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2021, 6, 2, 11, 31, 7, 389, DateTimeKind.Unspecified).AddTicks(8093), 5L, 7L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4148), new TimeSpan(0, 3, 0, 0, 0)), 3L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(3918), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4506), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4488), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4553), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4542), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4591), new TimeSpan(0, 3, 0, 0, 0)), 6L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4577), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4652), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4626), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4728), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4716), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4769), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4758), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4805), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4793), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4842), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4830), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4898), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 19, 13, 18, 16, 998, DateTimeKind.Unspecified).AddTicks(4878), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Henrietta18@hotmail.com", new DateTimeOffset(new DateTime(2022, 10, 18, 5, 37, 13, 517, DateTimeKind.Unspecified).AddTicks(876), new TimeSpan(0, 3, 0, 0, 0)), "Henrietta Lindgren" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Jimmy56@hotmail.com", new DateTimeOffset(new DateTime(2023, 4, 30, 14, 59, 48, 207, DateTimeKind.Unspecified).AddTicks(9891), new TimeSpan(0, 3, 0, 0, 0)), "Jimmy Jerde" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Lila_Heathcote62@gmail.com", new DateTimeOffset(new DateTime(2023, 4, 21, 18, 55, 19, 681, DateTimeKind.Unspecified).AddTicks(2057), new TimeSpan(0, 3, 0, 0, 0)), "Lila Heathcote" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 8L, "Fannie34@hotmail.com", new DateTimeOffset(new DateTime(2023, 7, 19, 8, 9, 15, 419, DateTimeKind.Unspecified).AddTicks(8089), new TimeSpan(0, 3, 0, 0, 0)), "Fannie Kozey" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Carole_Homenick75@gmail.com", new DateTimeOffset(new DateTime(2022, 11, 7, 11, 10, 48, 638, DateTimeKind.Unspecified).AddTicks(8373), new TimeSpan(0, 2, 0, 0, 0)), "Carole Homenick" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Josephine11@gmail.com", new DateTimeOffset(new DateTime(2023, 3, 17, 11, 55, 40, 14, DateTimeKind.Unspecified).AddTicks(6358), new TimeSpan(0, 2, 0, 0, 0)), "Josephine Spencer" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Eduardo_Feest@hotmail.com", new DateTimeOffset(new DateTime(2022, 10, 4, 23, 47, 33, 491, DateTimeKind.Unspecified).AddTicks(7329), new TimeSpan(0, 3, 0, 0, 0)), "Eduardo Feest" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Kathryn12@hotmail.com", new DateTimeOffset(new DateTime(2023, 5, 9, 7, 42, 3, 689, DateTimeKind.Unspecified).AddTicks(521), new TimeSpan(0, 3, 0, 0, 0)), "Kathryn Will" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Jon1@gmail.com", new DateTimeOffset(new DateTime(2023, 5, 19, 23, 25, 31, 980, DateTimeKind.Unspecified).AddTicks(9724), new TimeSpan(0, 3, 0, 0, 0)), "Jon Johnson" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Lora_Miller86@hotmail.com", new DateTimeOffset(new DateTime(2023, 4, 25, 12, 35, 45, 170, DateTimeKind.Unspecified).AddTicks(6065), new TimeSpan(0, 3, 0, 0, 0)), "Lora Miller" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 27, 1, 10, 3, 194, DateTimeKind.Unspecified).AddTicks(6623), 8L, "Enim voluptate illo numquam officia molestiae ut.", 50, 1, "rem", new DateTimeOffset(new DateTime(2022, 8, 18, 13, 52, 42, 457, DateTimeKind.Unspecified).AddTicks(9679), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationType", "Name", "StartTime" },
                values: new object[] { new DateTime(2021, 3, 20, 12, 36, 58, 733, DateTimeKind.Unspecified).AddTicks(6517), "Non eligendi distinctio occaecati sed illum vel ei", 28, 2, "deserunt", new DateTimeOffset(new DateTime(2022, 11, 28, 18, 37, 35, 235, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 9, 9, 8, 3, 23, 135, DateTimeKind.Unspecified).AddTicks(964), 7L, "Quibusdam nostrum officia doloribus inventore.", 16, "ut", new DateTimeOffset(new DateTime(2023, 7, 29, 11, 34, 36, 201, DateTimeKind.Unspecified).AddTicks(9616), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 21, 0, 53, 24, 640, DateTimeKind.Unspecified).AddTicks(7709), 5L, "Reprehenderit commodi iure laborum similique. Adip", 1, "dolorem", new DateTimeOffset(new DateTime(2022, 11, 3, 7, 31, 22, 983, DateTimeKind.Unspecified).AddTicks(5282), new TimeSpan(0, 2, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 10, 8, 20, 36, 29, 361, DateTimeKind.Unspecified).AddTicks(9716), 5L, "Est qui officia cupiditate nihil ut nam aperiam do", 49, 2, "corrupti", new DateTimeOffset(new DateTime(2022, 8, 19, 4, 48, 34, 628, DateTimeKind.Unspecified).AddTicks(6571), new TimeSpan(0, 3, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 6, 4, 50, 6, 354, DateTimeKind.Unspecified).AddTicks(8662), 3L, "Aliquid soluta laborum voluptatem velit autem et v", 56, 0, "sint", new DateTimeOffset(new DateTime(2023, 2, 13, 9, 25, 32, 223, DateTimeKind.Unspecified).AddTicks(5637), new TimeSpan(0, 2, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 19, 8, 15, 50, 976, DateTimeKind.Unspecified).AddTicks(3511), 4L, "Aut eum nisi ut inventore voluptates.", 17, 1, "sit", new DateTimeOffset(new DateTime(2023, 6, 25, 18, 55, 8, 316, DateTimeKind.Unspecified).AddTicks(9309), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 11, 8, 17, 58, 11, 532, DateTimeKind.Unspecified).AddTicks(458), 6L, "Quaerat itaque nobis optio maxime qui.", 13, 1, "exercitationem", new DateTimeOffset(new DateTime(2023, 3, 30, 6, 20, 48, 114, DateTimeKind.Unspecified).AddTicks(4715), new TimeSpan(0, 3, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 7, 3, 9, 49, 26, 115, DateTimeKind.Unspecified).AddTicks(7176), 8L, "Sint beatae ut incidunt exercitationem nihil et.\nM", 56, 2, "tenetur", new DateTimeOffset(new DateTime(2022, 11, 23, 10, 50, 14, 41, DateTimeKind.Unspecified).AddTicks(5250), new TimeSpan(0, 2, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 4, 18, 16, 3, 38, 99, DateTimeKind.Unspecified).AddTicks(7311), 2L, "Doloremque blanditiis illum est iste incidunt volu", 54, "corporis", new DateTimeOffset(new DateTime(2023, 5, 25, 2, 39, 35, 753, DateTimeKind.Unspecified).AddTicks(3874), new TimeSpan(0, 3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "nostrumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Corporis voluptatem cumque rem ut aut omnis. Debitis qui architecto occaecati rerum et. Doloribus at suscipit. Similique non illo aliquid natus eum molestias." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "Debitis mollitia reprehenderit exercitationem voluptate sint qui.\nQuas aut enim architecto quo qui est et recusandae.\nVoluptas blanditiis ipsa quae exercitationem voluptates facilis voluptatem.\nVitae voluptas aliquid perferendis autem est nostrum maiores reiciendis." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Vitae impedit id possimus placeat corporis minus vero. Similique amet aliquam labore ducimus labore minima et. Possimus libero voluptates. Illo et ea delectus nam. Quam molestias debitis illo enim dignissimos enim." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 9L, "Sunt voluptatem eveniet quia rerum maxime repellat enim sit et. Occaecati consequuntur voluptas doloremque dignissimos non libero corrupti nostrum. Ut consequatur perspiciatis reiciendis exercitationem aspernatur. Quo qui ea tempora." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 5L, "quisAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Text",
                value: "Velit quidem temporibus. Porro expedita consectetur est itaque voluptatibus numquam porro. Ipsam est harum ut quaerat culpa consequatur qui nam excepturi. Neque quis voluptate.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Animi nesciunt laboriosam.AAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Text",
                value: "Amet deleniti corrupti alias corrupti dicta aut corporis sint.\nQuisquam et quibusdam quia dolorem eos velit.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "providentAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.InsertData(
                table: "TeamMemberMeetings",
                columns: new[] { "Id", "EventId", "IsDeleted", "MemberId", "Priority" },
                values: new object[,]
                {
                    { 1L, 1L, false, 1L, 6 },
                    { 2L, 2L, false, 2L, 6 },
                    { 3L, 3L, false, 3L, 9 },
                    { 4L, 4L, false, 4L, 9 },
                    { 5L, 5L, false, 5L, 6 },
                    { 6L, 6L, false, 6L, 1 },
                    { 7L, 7L, false, 7L, 5 },
                    { 8L, 8L, false, 8L, 9 },
                    { 9L, 9L, false, 9L, 7 },
                    { 10L, 10L, false, 10L, 7 }
                });

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
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 1 });

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
                column: "Role",
                value: 2);

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
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "similique", "Kshlerin - Hickle", "https://seth.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "ipsam", "Kohler - Halvorson", "http://barney.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Nisi ratione quis fugiat.", "Lindgren LLC", "https://rowan.net" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Rerum non provident ipsum dolor vero. Non at explicabo est doloribus tenetur doloremque magni necessitatibus dolor. Quia laudantium in necessitatibus ut incidunt voluptatibus molestiae eaque. Quo quod iure laboriosam assumenda sunt hic fuga iste ad. Doloribus consequatur temporibus aperiam impedit", "Jakubowski, Erdman and Herzog", "https://millie.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Perferendis autem est. Quasi dolorem rerum illo deleniti et. Quis rem molestias delectus. Similique nemo ut in.", "DuBuque, Shanahan and Luettgen", "http://adele.info" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Sed aut ab nostrum ut.", "Paucek and Sons", "http://shanie.name" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "omnis", "Cartwright - Bosco", "http://karine.org" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Et qui quam. Sed fuga distinctio id rerum. Nulla sit pariatur dolorem iste in dolor impedit similique. Sed et odit placeat voluptatibus necessitatibus esse.", "Rath, Schamberger and Prohaska", "http://adah.biz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Dicta est voluptatem dolores non.\nDolore magnam nemo distinctio voluptatum aliquam qui molestiae hic.\nUt non minus aut id consectetur non omnis soluta.\nMagnam sint rerum est doloremque animi corporis saepe quasi.\nAutem delectus eveniet aliquam autem quae ipsam.", "Hermiston and Sons", "https://sandra.com" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink" },
                values: new object[] { "Quia quaerat et ut iste pariatur fugiat voluptatem accusamus doloremque.\nUllam quis similique rerum non.\nQui corrupti assumenda magnam ex id.\nRerum sapiente voluptatem qui quos maiores.\nDolores cumque expedita quisquam est sunt quod incidunt laborum a.", "Hickle - Predovic", "https://myrtis.name" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Joann.Waters91@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/156.jpg", "Joann Waters", "758-647-50", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Jimmy.Strosin38@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1003.jpg", "Jimmy Strosin", "792-733-78", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Jane.Hand@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/969.jpg", "Jane Hand", "1-360-471-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Faith_Bergstrom@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/449.jpg", "Faith Bergstrom", "1-767-387-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Jerome_Schamberger@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/447.jpg", "Jerome Schamberger", "253-807-20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Vincent_Gorczany90@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/840.jpg", "Vincent Gorczany", "832-797-95", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Genevieve0@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/348.jpg", "Genevieve Pfannerstill", "(406) 715-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Horace_Rempel@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/609.jpg", "Horace Rempel", "1-378-467-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Carrie27@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/506.jpg", "Carrie Rohan", "1-761-958-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Robert56@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/672.jpg", "Robert Witting", "804-371-92", 1 });

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
