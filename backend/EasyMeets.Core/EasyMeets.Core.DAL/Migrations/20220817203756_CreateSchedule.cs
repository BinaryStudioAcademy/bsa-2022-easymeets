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
                columns: new[] { "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 19, 1, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 22, 7, 4, 9 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 5, 5, 2, 3, 5 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 5, 23, 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 6, 30, 7, 3, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 2, 1, 26, 7, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 3, 3, 22, 5, 1 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 8, 5, 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 4, 21, 2, 4, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 1, 19, 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 11, 27, 10, 17, 9, 924, DateTimeKind.Unspecified).AddTicks(1), 20, "http://sydnee.org", "quia", 39, 9L, 0, "Voluptatem alias molestiae ipsam saepe quidem id quia saepe sequi." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2020, 3, 13, 1, 24, 47, 743, DateTimeKind.Unspecified).AddTicks(3643), 22, "http://antonietta.name", 0, "voluptates", 48, 5L, 0, "Dolorum iure omnis exercitationem numquam aliquid nam in mollitia veniam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 6, 14, 22, 23, 59, 281, DateTimeKind.Unspecified).AddTicks(9970), 30, "https://brain.info", 0, "quia", 27, 1L, 0, "Tenetur sint ipsum ut." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 10, 2, 3, 58, 13, 359, DateTimeKind.Unspecified).AddTicks(4265), 26, "https://sadie.info", 1, "harum", 16, 4L, "Modi eligendi doloremque qui laudantium neque nihil." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 9, 13, 14, 10, 47, 838, DateTimeKind.Unspecified).AddTicks(6357), "http://estel.net", 2, "molestiae", 20, 7L, 1, "qui" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 7, 9, 19, 20, 43, 548, DateTimeKind.Unspecified).AddTicks(8216), 24, "https://henry.name", 1, "ad", 48, 6L, "Natus inventore perspiciatis a.\nSint iure ex ea ipsam alias tempora sunt alias vero.\nNostrum omnis ad in.\nOmnis odio nisi ex consequatur.\nVeniam sit est sunt voluptatibus ratione et temporibus eveniet eum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 7, 29, 18, 22, 39, 7, DateTimeKind.Unspecified).AddTicks(5719), "https://beaulah.name", 1, "aut", 60, 10L, "voluptas" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2020, 7, 30, 23, 51, 54, 469, DateTimeKind.Unspecified).AddTicks(2706), 28, "http://saul.org", 2, "dolorum", 37, "Esse reprehenderit et. Quas ad voluptas. Quaerat nesciunt ut eum illo. Laborum totam et qui." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2020, 5, 3, 7, 26, 31, 561, DateTimeKind.Unspecified).AddTicks(9933), 19, "http://phoebe.name", "voluptatum", 34, 6L, 1, "Magnam quam est eum deleniti deserunt harum. Est rem atque vel velit distinctio dolorum quaerat aut suscipit. Inventore in adipisci unde architecto amet autem perferendis et quo." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2019, 9, 17, 11, 42, 56, 64, DateTimeKind.Unspecified).AddTicks(2501), 18, "https://antwan.net", 1, "totam", 21, "Eaque est nulla quasi sit necessitatibus quo dolor. Autem nesciunt minus odio porro et non eos qui distinctio. Suscipit sed tempore non consequatur autem. Iure qui vitae neque et optio cupiditate modi sapiente. Sunt harum nisi sunt rerum." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2021, 2, 5, 15, 59, 0, 905, DateTimeKind.Unspecified).AddTicks(3866), 9L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2020, 3, 13, 9, 24, 32, 504, DateTimeKind.Unspecified).AddTicks(3943), 10L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 4, 25, 14, 3, 50, 311, DateTimeKind.Unspecified).AddTicks(3516), 9L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 2, 3, 6, 46, 30, 819, DateTimeKind.Unspecified).AddTicks(6868), 7L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2020, 10, 21, 3, 1, 51, 699, DateTimeKind.Unspecified).AddTicks(6612), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 8L, new DateTime(2020, 6, 17, 19, 12, 38, 878, DateTimeKind.Unspecified).AddTicks(7117), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2019, 10, 4, 3, 20, 5, 229, DateTimeKind.Unspecified).AddTicks(6046), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2020, 4, 19, 19, 1, 15, 611, DateTimeKind.Unspecified).AddTicks(871), 5L, 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 3, 6, 2, 29, 9, 257, DateTimeKind.Unspecified).AddTicks(9280), 3L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 10, 2, 16, 20, 42, 507, DateTimeKind.Unspecified).AddTicks(2174), 9L, 2L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8510), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 18, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8325), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8726), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 18, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8709), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8759), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTimeOffset(new DateTime(2022, 8, 18, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8749), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8795), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 18, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8784), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8828), new TimeSpan(0, 3, 0, 0, 0)), 5L, new DateTimeOffset(new DateTime(2022, 8, 18, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8817), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8861), new TimeSpan(0, 3, 0, 0, 0)), 8L, new DateTimeOffset(new DateTime(2022, 8, 18, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8850), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8895), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTimeOffset(new DateTime(2022, 8, 18, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8884), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8926), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 18, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8916), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "ExternalAttendeeId", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8958), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTimeOffset(new DateTime(2022, 8, 18, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8948), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8990), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 18, 23, 37, 54, 433, DateTimeKind.Unspecified).AddTicks(8980), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Ramona_Oberbrunner5@gmail.com", new DateTimeOffset(new DateTime(2023, 1, 20, 0, 51, 32, 135, DateTimeKind.Unspecified).AddTicks(1529), new TimeSpan(0, 2, 0, 0, 0)), "Ramona Oberbrunner" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Hugo.Windler@yahoo.com", new DateTimeOffset(new DateTime(2023, 6, 19, 22, 51, 28, 368, DateTimeKind.Unspecified).AddTicks(6043), new TimeSpan(0, 3, 0, 0, 0)), "Hugo Windler" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Spencer_Bergnaum@yahoo.com", new DateTimeOffset(new DateTime(2023, 2, 4, 10, 38, 34, 631, DateTimeKind.Unspecified).AddTicks(4757), new TimeSpan(0, 2, 0, 0, 0)), "Spencer Bergnaum" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Matthew.Barrows54@gmail.com", new DateTimeOffset(new DateTime(2023, 7, 25, 19, 35, 24, 216, DateTimeKind.Unspecified).AddTicks(985), new TimeSpan(0, 3, 0, 0, 0)), "Matthew Barrows" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Harold_Kshlerin@yahoo.com", new DateTimeOffset(new DateTime(2023, 1, 18, 2, 43, 19, 959, DateTimeKind.Unspecified).AddTicks(8934), new TimeSpan(0, 2, 0, 0, 0)), "Harold Kshlerin" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Alma.Okuneva2@yahoo.com", new DateTimeOffset(new DateTime(2023, 8, 15, 12, 21, 51, 607, DateTimeKind.Unspecified).AddTicks(6545), new TimeSpan(0, 3, 0, 0, 0)), "Alma Okuneva" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Wilfred.Stokes@gmail.com", new DateTimeOffset(new DateTime(2023, 3, 1, 9, 10, 12, 814, DateTimeKind.Unspecified).AddTicks(8245), new TimeSpan(0, 2, 0, 0, 0)), "Wilfred Stokes" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Lloyd41@gmail.com", new DateTimeOffset(new DateTime(2023, 3, 18, 21, 35, 14, 438, DateTimeKind.Unspecified).AddTicks(9652), new TimeSpan(0, 2, 0, 0, 0)), "Lloyd Morissette" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 3L, "Joann14@gmail.com", new DateTimeOffset(new DateTime(2022, 8, 22, 22, 43, 6, 892, DateTimeKind.Unspecified).AddTicks(279), new TimeSpan(0, 3, 0, 0, 0)), "Joann Homenick" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 9L, "Jamie45@gmail.com", new DateTimeOffset(new DateTime(2022, 10, 27, 16, 23, 45, 240, DateTimeKind.Unspecified).AddTicks(787), new TimeSpan(0, 3, 0, 0, 0)), "Jamie Monahan" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 9, 27, 20, 54, 30, 974, DateTimeKind.Unspecified).AddTicks(6646), 8L, "Rerum recusandae voluptatem est dolores nemo non.", 30, "cum", new DateTimeOffset(new DateTime(2023, 8, 16, 9, 43, 2, 55, DateTimeKind.Unspecified).AddTicks(1069), new TimeSpan(0, 3, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 7, 7, 9, 34, 20, 673, DateTimeKind.Unspecified).AddTicks(9025), "Velit non totam natus asperiores accusamus nemo.\nQ", 21, 0, "suscipit", new DateTimeOffset(new DateTime(2022, 12, 18, 15, 47, 6, 642, DateTimeKind.Unspecified).AddTicks(7972), new TimeSpan(0, 2, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 9, 6, 19, 55, 827, DateTimeKind.Unspecified).AddTicks(9583), 8L, "Iste magnam quod natus sit voluptatum.\nEt sunt rec", 19, "accusamus", new DateTimeOffset(new DateTime(2022, 11, 8, 5, 47, 46, 659, DateTimeKind.Unspecified).AddTicks(6982), new TimeSpan(0, 2, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 7, 7, 19, 25, 52, 722, DateTimeKind.Unspecified).AddTicks(2110), 8L, "aspernatur", 57, 0, "aspernatur", new DateTimeOffset(new DateTime(2023, 3, 17, 13, 31, 27, 225, DateTimeKind.Unspecified).AddTicks(5807), new TimeSpan(0, 2, 0, 0, 0)), 7L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 7, 15, 7, 30, 11, 303, DateTimeKind.Unspecified).AddTicks(9129), 8L, "explicabo", 44, 1, "reiciendis", new DateTimeOffset(new DateTime(2022, 10, 12, 2, 52, 15, 701, DateTimeKind.Unspecified).AddTicks(8001), new TimeSpan(0, 3, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 2, 3, 23, 30, 52, 885, DateTimeKind.Unspecified).AddTicks(4888), "Placeat aliquam sit debitis beatae qui voluptate a", 58, 1, "beatae", new DateTimeOffset(new DateTime(2022, 12, 17, 1, 33, 38, 511, DateTimeKind.Unspecified).AddTicks(9750), new TimeSpan(0, 2, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 4, 3, 3, 21, 5, 138, DateTimeKind.Unspecified).AddTicks(7679), 8L, "provident", 43, "aperiam", new DateTimeOffset(new DateTime(2022, 12, 26, 9, 4, 47, 433, DateTimeKind.Unspecified).AddTicks(2090), new TimeSpan(0, 2, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 7, 15, 18, 6, 8, 44, DateTimeKind.Unspecified).AddTicks(7446), 3L, "Vitae dolorum eum nesciunt corrupti ab non aut rec", 39, "officia", new DateTimeOffset(new DateTime(2023, 5, 12, 17, 30, 53, 109, DateTimeKind.Unspecified).AddTicks(8527), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 1, 24, 9, 53, 56, 834, DateTimeKind.Unspecified).AddTicks(1331), 3L, "Iste consequatur architecto.", 24, 1, "et", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 39, 13, 950, DateTimeKind.Unspecified).AddTicks(964), new TimeSpan(0, 3, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 26, 23, 42, 44, 196, DateTimeKind.Unspecified).AddTicks(1071), 3L, "Blanditiis facilis libero et magnam.\nAut sunt est", 19, "fugiat", new DateTimeOffset(new DateTime(2022, 11, 30, 2, 40, 11, 521, DateTimeKind.Unspecified).AddTicks(2698), new TimeSpan(0, 2, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 2L, "asperioresAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Ullam quos expedita facilis. Officia ducimus dolore nisi totam sunt repudiandae. Nisi numquam explicabo aut totam. Quam quas voluptates inventore quia molestiae. Quam libero nobis atque rerum voluptatem eum." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "ipsaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 8L, "Ab dolore aut.\nIn expedita delectus perferendis voluptatem assumenda possimus beatae minus.\nCum sed exercitationem molestiae." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "Expedita hic et quaerat nemo ab.\nOccaecati exercitationem necessitatibus corporis dolorem.\nCommodi rem et a laborum id et assumenda vel." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 10L, "Velit iusto quia dignissimos eligendi quisquam.AAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 4L, "delectusAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 7L, "Eligendi qui voluptatem officia expedita.AAAAAAAAA" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Text",
                value: "Maiores nobis veniam. Ullam quidem repellendus sint dolor. Tempore delectus unde. Qui cumque iusto dignissimos.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 1L, "Qui quos velit sint.\nVel rerum dicta ea illum minus.\nVoluptas asperiores exercitationem quae eligendi eaque.\nRecusandae delectus cupiditate alias dolor alias iste odio dolor autem.\nExplicabo minus est nobis asperiores veniam neque ipsam eaque ipsa.\nQuae debitis enim voluptatum." });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "AvailabilitySlotId", "IsDeleted", "TimeZone", "WithTeamMembers" },
                values: new object[,]
                {
                    { 1L, 1L, false, 127, true },
                    { 2L, 2L, false, -183, false },
                    { 3L, 3L, false, 250, true },
                    { 4L, 4L, false, -518, true },
                    { 5L, 5L, false, -447, false },
                    { 6L, 6L, false, -556, true },
                    { 7L, 7L, false, -268, false },
                    { 8L, 8L, false, -525, false },
                    { 9L, 9L, false, -605, true },
                    { 10L, 10L, false, -476, false }
                });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 2, 1 });

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
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "molestiae", "Lubowitz and Sons", "https://lyla.com", "America/R" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Voluptate laudantium numquam ut dolorem.", "Volkman, Halvorson and Schmitt", "http://claudine.biz", "Africa/Jo" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "vitae", "Cummerata - Kohler", "http://marvin.info", "America/L" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Et velit ea. Omnis delectus debitis asperiores. Impedit atque vel cum quis tempore. Repudiandae sit explicabo est autem et. Ipsum consequatur nesciunt sed quidem architecto nihil sint explicabo.", "Kshlerin Inc", "http://mercedes.org", "Asia/Rang" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Non ullam qui.", "Stehr, Ward and Pfannerstill", "https://zelda.com", "Europe/At" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "dignissimos", "Schultz - Kozey", "https://patrick.org", "America/L" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Officiis ipsum quas doloribus ipsa expedita nihil incidunt vel.\nNihil quo nisi eius ea dolore provident molestiae saepe sed.\nOfficia et neque consequatur.\nMaiores culpa est est.", "Gleason, Jacobs and Cartwright", "http://hertha.net", "Europe/Za" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "magni", "Shanahan, Waters and Waters", "https://bertha.com", "Australia" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Voluptas porro ut itaque sunt provident repellat repudiandae qui est.\nFugiat est dicta harum.\nUt cumque ipsum et.\nRecusandae sapiente alias illum sit doloribus id provident id fuga.", "Jacobson - Weber", "https://toby.com", "Asia/Kras" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name", "PageLink", "TimeZone" },
                values: new object[] { "Et voluptatem sit qui doloribus dolorum laborum est sint. Laudantium a aut ut autem porro est commodi quos nihil. Hic dicta illo. Vel voluptas consequatur aperiam nihil eius explicabo sit ipsam nisi. Dolorem aut unde.", "Tromp, Daugherty and Kilback", "https://jane.net", "America/S" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Jennie_Stracke27@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/863.jpg", "Jennie Stracke", "276-743-01", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Neil.Mosciski@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/972.jpg", "Neil Mosciski", "(391) 899-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Kelley_McLaughlin@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/192.jpg", "Kelley McLaughlin", "1-738-210-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Charlotte.Franecki@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/306.jpg", "Charlotte Franecki", "(478) 657-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Leroy3@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/677.jpg", "Leroy Harvey", "1-328-225-", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Alan.Oberbrunner71@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/279.jpg", "Alan Oberbrunner", "609-882-52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Johnny.Marquardt@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1198.jpg", "Johnny Marquardt", "837-788-80", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 1, "Pearl3@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/135.jpg", "Pearl Schaden", "1-430-303-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Peter.Stokes@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/287.jpg", "Peter Stokes", "1-763-560-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Melanie97@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/949.jpg", "Melanie Bogan", "1-677-281-", 0 });

            migrationBuilder.InsertData(
                table: "ScheduleItem",
                columns: new[] { "Id", "End", "IsDeleted", "IsEnabled", "ScheduleId", "Start", "WeekDay" },
                values: new object[,]
                {
                    { 1L, new TimeSpan(0, 16, 0, 0, 0), false, false, 1L, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 2L, new TimeSpan(0, 16, 0, 0, 0), false, false, 1L, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 3L, new TimeSpan(0, 16, 0, 0, 0), false, false, 1L, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 4L, new TimeSpan(0, 14, 0, 0, 0), false, true, 1L, new TimeSpan(0, 12, 0, 0, 0), 3 },
                    { 5L, new TimeSpan(0, 16, 0, 0, 0), false, true, 1L, new TimeSpan(0, 11, 0, 0, 0), 4 },
                    { 6L, new TimeSpan(0, 17, 0, 0, 0), false, false, 1L, new TimeSpan(0, 11, 0, 0, 0), 5 },
                    { 7L, new TimeSpan(0, 18, 0, 0, 0), false, true, 1L, new TimeSpan(0, 11, 0, 0, 0), 6 },
                    { 8L, new TimeSpan(0, 15, 0, 0, 0), false, true, 2L, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 9L, new TimeSpan(0, 16, 0, 0, 0), false, true, 2L, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 10L, new TimeSpan(0, 14, 0, 0, 0), false, true, 2L, new TimeSpan(0, 8, 0, 0, 0), 2 },
                    { 11L, new TimeSpan(0, 16, 0, 0, 0), false, true, 2L, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 12L, new TimeSpan(0, 16, 0, 0, 0), false, false, 2L, new TimeSpan(0, 9, 0, 0, 0), 4 },
                    { 13L, new TimeSpan(0, 18, 0, 0, 0), false, false, 2L, new TimeSpan(0, 12, 0, 0, 0), 5 },
                    { 14L, new TimeSpan(0, 13, 0, 0, 0), false, true, 2L, new TimeSpan(0, 12, 0, 0, 0), 6 },
                    { 15L, new TimeSpan(0, 18, 0, 0, 0), false, false, 3L, new TimeSpan(0, 11, 0, 0, 0), 0 },
                    { 16L, new TimeSpan(0, 15, 0, 0, 0), false, true, 3L, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 17L, new TimeSpan(0, 15, 0, 0, 0), false, false, 3L, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 18L, new TimeSpan(0, 17, 0, 0, 0), false, false, 3L, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 19L, new TimeSpan(0, 14, 0, 0, 0), false, true, 3L, new TimeSpan(0, 11, 0, 0, 0), 4 },
                    { 20L, new TimeSpan(0, 14, 0, 0, 0), false, true, 3L, new TimeSpan(0, 10, 0, 0, 0), 5 },
                    { 21L, new TimeSpan(0, 17, 0, 0, 0), false, false, 3L, new TimeSpan(0, 9, 0, 0, 0), 6 },
                    { 22L, new TimeSpan(0, 13, 0, 0, 0), false, false, 4L, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 23L, new TimeSpan(0, 16, 0, 0, 0), false, true, 4L, new TimeSpan(0, 11, 0, 0, 0), 1 },
                    { 24L, new TimeSpan(0, 15, 0, 0, 0), false, false, 4L, new TimeSpan(0, 8, 0, 0, 0), 2 },
                    { 25L, new TimeSpan(0, 15, 0, 0, 0), false, true, 4L, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 26L, new TimeSpan(0, 16, 0, 0, 0), false, false, 4L, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 27L, new TimeSpan(0, 13, 0, 0, 0), false, false, 4L, new TimeSpan(0, 10, 0, 0, 0), 5 },
                    { 28L, new TimeSpan(0, 16, 0, 0, 0), false, false, 4L, new TimeSpan(0, 10, 0, 0, 0), 6 },
                    { 29L, new TimeSpan(0, 17, 0, 0, 0), false, false, 5L, new TimeSpan(0, 8, 0, 0, 0), 0 },
                    { 30L, new TimeSpan(0, 14, 0, 0, 0), false, false, 5L, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 31L, new TimeSpan(0, 14, 0, 0, 0), false, true, 5L, new TimeSpan(0, 12, 0, 0, 0), 2 },
                    { 32L, new TimeSpan(0, 16, 0, 0, 0), false, false, 5L, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 33L, new TimeSpan(0, 13, 0, 0, 0), false, false, 5L, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 34L, new TimeSpan(0, 17, 0, 0, 0), false, true, 5L, new TimeSpan(0, 8, 0, 0, 0), 5 },
                    { 35L, new TimeSpan(0, 14, 0, 0, 0), false, true, 5L, new TimeSpan(0, 8, 0, 0, 0), 6 },
                    { 36L, new TimeSpan(0, 17, 0, 0, 0), false, false, 6L, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 37L, new TimeSpan(0, 16, 0, 0, 0), false, true, 6L, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 38L, new TimeSpan(0, 13, 0, 0, 0), false, false, 6L, new TimeSpan(0, 8, 0, 0, 0), 2 },
                    { 39L, new TimeSpan(0, 14, 0, 0, 0), false, false, 6L, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 40L, new TimeSpan(0, 13, 0, 0, 0), false, true, 6L, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 41L, new TimeSpan(0, 14, 0, 0, 0), false, false, 6L, new TimeSpan(0, 12, 0, 0, 0), 5 },
                    { 42L, new TimeSpan(0, 16, 0, 0, 0), false, false, 6L, new TimeSpan(0, 11, 0, 0, 0), 6 }
                });

            migrationBuilder.InsertData(
                table: "ScheduleItem",
                columns: new[] { "Id", "End", "IsDeleted", "IsEnabled", "ScheduleId", "Start", "WeekDay" },
                values: new object[,]
                {
                    { 43L, new TimeSpan(0, 14, 0, 0, 0), false, true, 7L, new TimeSpan(0, 11, 0, 0, 0), 0 },
                    { 44L, new TimeSpan(0, 16, 0, 0, 0), false, true, 7L, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 45L, new TimeSpan(0, 14, 0, 0, 0), false, false, 7L, new TimeSpan(0, 10, 0, 0, 0), 2 },
                    { 46L, new TimeSpan(0, 17, 0, 0, 0), false, false, 7L, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 47L, new TimeSpan(0, 18, 0, 0, 0), false, true, 7L, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 48L, new TimeSpan(0, 17, 0, 0, 0), false, true, 7L, new TimeSpan(0, 9, 0, 0, 0), 5 },
                    { 49L, new TimeSpan(0, 18, 0, 0, 0), false, false, 7L, new TimeSpan(0, 10, 0, 0, 0), 6 },
                    { 50L, new TimeSpan(0, 18, 0, 0, 0), false, true, 8L, new TimeSpan(0, 12, 0, 0, 0), 0 },
                    { 51L, new TimeSpan(0, 14, 0, 0, 0), false, false, 8L, new TimeSpan(0, 10, 0, 0, 0), 1 },
                    { 52L, new TimeSpan(0, 18, 0, 0, 0), false, true, 8L, new TimeSpan(0, 8, 0, 0, 0), 2 },
                    { 53L, new TimeSpan(0, 13, 0, 0, 0), false, true, 8L, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 54L, new TimeSpan(0, 16, 0, 0, 0), false, false, 8L, new TimeSpan(0, 11, 0, 0, 0), 4 },
                    { 55L, new TimeSpan(0, 18, 0, 0, 0), false, true, 8L, new TimeSpan(0, 9, 0, 0, 0), 5 },
                    { 56L, new TimeSpan(0, 13, 0, 0, 0), false, true, 8L, new TimeSpan(0, 9, 0, 0, 0), 6 },
                    { 57L, new TimeSpan(0, 15, 0, 0, 0), false, false, 9L, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 58L, new TimeSpan(0, 18, 0, 0, 0), false, false, 9L, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 59L, new TimeSpan(0, 13, 0, 0, 0), false, false, 9L, new TimeSpan(0, 8, 0, 0, 0), 2 },
                    { 60L, new TimeSpan(0, 16, 0, 0, 0), false, false, 9L, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 61L, new TimeSpan(0, 15, 0, 0, 0), false, true, 9L, new TimeSpan(0, 9, 0, 0, 0), 4 },
                    { 62L, new TimeSpan(0, 15, 0, 0, 0), false, true, 9L, new TimeSpan(0, 12, 0, 0, 0), 5 },
                    { 63L, new TimeSpan(0, 13, 0, 0, 0), false, true, 9L, new TimeSpan(0, 11, 0, 0, 0), 6 },
                    { 64L, new TimeSpan(0, 16, 0, 0, 0), false, false, 10L, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 65L, new TimeSpan(0, 15, 0, 0, 0), false, false, 10L, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 66L, new TimeSpan(0, 18, 0, 0, 0), false, false, 10L, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 67L, new TimeSpan(0, 16, 0, 0, 0), false, false, 10L, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 68L, new TimeSpan(0, 18, 0, 0, 0), false, true, 10L, new TimeSpan(0, 9, 0, 0, 0), 4 },
                    { 69L, new TimeSpan(0, 14, 0, 0, 0), false, false, 10L, new TimeSpan(0, 12, 0, 0, 0), 5 },
                    { 70L, new TimeSpan(0, 16, 0, 0, 0), false, false, 10L, new TimeSpan(0, 12, 0, 0, 0), 6 }
                });

            migrationBuilder.InsertData(
                table: "SlotMembers",
                columns: new[] { "Id", "EventId", "IsDeleted", "MemberId", "Priority", "ScheduleId" },
                values: new object[,]
                {
                    { 1L, 1L, false, 1L, 4, 1L },
                    { 2L, 2L, false, 2L, 2, 2L },
                    { 3L, 3L, false, 3L, 7, 3L },
                    { 4L, 4L, false, 4L, 3, 4L },
                    { 5L, 5L, false, 5L, 1, 5L },
                    { 6L, 6L, false, 6L, 1, 6L },
                    { 7L, 7L, false, 7L, 1, 7L },
                    { 8L, 8L, false, 8L, 5, 8L },
                    { 9L, 9L, false, 9L, 4, 9L },
                    { 10L, 10L, false, 10L, 9, 10L }
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
                columns: new[] { "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 17, 8, 15 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 23, 4, 1, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 2, 2, 10, 8, 2, 14 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 13, 7, 2, 11 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 5, 19, 4, 1, 6 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "PaddingMeeting" },
                values: new object[] { 3, 4, 30, 5, 8 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference" },
                values: new object[] { 1, 8, 3, 1, 4 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 3, 6, 17, 5, 5, 3 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 6, 8, 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "ActivityType", "Color", "Days", "MaxNumberOfBookings", "MinBookingMeetingDifference", "PaddingMeeting" },
                values: new object[] { 1, 2, 7, 6, 2, 8 });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 5, 7, 10, 33, 37, 632, DateTimeKind.Unspecified).AddTicks(3181), 19, "http://lesly.name", "ut", 22, 5L, 1, "Enim aliquid cumque ea officia quod earum." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 7, 15, 22, 9, 34, 135, DateTimeKind.Unspecified).AddTicks(7262), 28, "http://reese.com", 2, "temporibus", 28, 1L, 1, "Officiis omnis autem illum repellat iusto.\nUnde totam reiciendis in et.\nTemporibus vel ut numquam sit consequuntur molestiae." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2019, 11, 30, 1, 16, 44, 428, DateTimeKind.Unspecified).AddTicks(7930), 29, "https://kamron.name", 1, "tempore", 44, 10L, 1, "Magnam et voluptates perspiciatis." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { new DateTime(2020, 11, 11, 12, 15, 5, 822, DateTimeKind.Unspecified).AddTicks(4565), 19, "http://kaleigh.info", 0, "cumque", 50, 2L, "Reprehenderit voluptatibus sequi id cupiditate. Est aut consequatur voluptates omnis sed itaque. Et qui sapiente consequuntur provident recusandae iste sint dolor non." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 3, new DateTime(2021, 3, 27, 21, 20, 54, 618, DateTimeKind.Unspecified).AddTicks(8806), "https://charley.info", 1, "ut", 40, 6L, 0, "In animi et ipsum alias dolorem quisquam placeat esse." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2021, 1, 21, 1, 2, 45, 618, DateTimeKind.Unspecified).AddTicks(1869), 28, "https://jalon.name", 0, "error", 31, 5L, "Et dolores qui rem consequatur est sapiente. Cupiditate porro eligendi perferendis consequatur. Aut commodi eligendi omnis repellat molestiae non." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Link", "LocationType", "Name", "Size", "TeamId", "WelcomeMessage" },
                values: new object[] { 1, new DateTime(2020, 11, 18, 18, 32, 16, 33, DateTimeKind.Unspecified).AddTicks(4539), "https://maiya.biz", 0, "consequatur", 21, 5L, "Et adipisci esse eos perspiciatis et minus voluptatem eveniet eaque. Id consequuntur sit beatae. Aperiam tenetur asperiores et in qui quis nisi voluptatum. In eveniet sed adipisci corporis dolores tempora laboriosam." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "WelcomeMessage" },
                values: new object[] { 2, new DateTime(2021, 7, 18, 16, 49, 47, 788, DateTimeKind.Unspecified).AddTicks(4069), 16, "https://cristal.com", 1, "vel", 54, "Voluptatibus vero minus amet.\nEsse amet qui fugiat numquam.\nNemo atque deleniti.\nPlaceat voluptas eveniet." });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "Name", "Size", "TeamId", "Type", "WelcomeMessage" },
                values: new object[] { 5, new DateTime(2019, 11, 21, 17, 44, 39, 392, DateTimeKind.Unspecified).AddTicks(8171), 25, "https://vicente.info", "dolorem", 53, 4L, 0, "id" });

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BookingsPerDay", "CreatedAt", "Frequency", "Link", "LocationType", "Name", "Size", "WelcomeMessage" },
                values: new object[] { 4, new DateTime(2020, 12, 3, 7, 5, 8, 608, DateTimeKind.Unspecified).AddTicks(5589), 28, "https://andrew.name", 0, "nihil", 22, "Odit ut porro corrupti optio est." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2019, 10, 14, 1, 52, 41, 862, DateTimeKind.Unspecified).AddTicks(5318), 2L, 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 4L, new DateTime(2020, 11, 2, 11, 47, 7, 524, DateTimeKind.Unspecified).AddTicks(895), 6L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2019, 8, 5, 22, 15, 39, 940, DateTimeKind.Unspecified).AddTicks(7274), 4L, 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 2L, new DateTime(2021, 2, 24, 14, 13, 53, 567, DateTimeKind.Unspecified).AddTicks(9834), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 1, 17, 10, 14, 29, 620, DateTimeKind.Unspecified).AddTicks(1650), 6L, 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 2L, new DateTime(2020, 5, 17, 8, 9, 46, 481, DateTimeKind.Unspecified).AddTicks(8859), 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 4, 8, 1, 58, 19, 233, DateTimeKind.Unspecified).AddTicks(6606), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2021, 6, 29, 17, 34, 22, 312, DateTimeKind.Unspecified).AddTicks(2276), 8L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2020, 6, 8, 3, 47, 14, 272, DateTimeKind.Unspecified).AddTicks(2834), 7L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2021, 7, 10, 3, 20, 53, 662, DateTimeKind.Unspecified).AddTicks(8549), 6L, 1L });

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
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1497), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1492), new TimeSpan(0, 3, 0, 0, 0)) });

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
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1527), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 18, 20, 53, 13, 402, DateTimeKind.Unspecified).AddTicks(1522), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Thomas.Mayert@gmail.com", new DateTimeOffset(new DateTime(2022, 10, 2, 21, 41, 48, 730, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, 3, 0, 0, 0)), "Thomas Mayert" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 10L, "Julia2@hotmail.com", new DateTimeOffset(new DateTime(2022, 9, 12, 19, 51, 32, 571, DateTimeKind.Unspecified).AddTicks(4496), new TimeSpan(0, 3, 0, 0, 0)), "Julia Schowalter" });

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
                values: new object[] { 9L, "Carolyn76@gmail.com", new DateTimeOffset(new DateTime(2023, 5, 3, 2, 17, 59, 777, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 3, 0, 0, 0)), "Carolyn Konopelski" });

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
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 7, 19, 52, 54, 651, DateTimeKind.Unspecified).AddTicks(9375), 3L, "Quod temporibus odio autem beatae voluptatem quisq", 40, "ab", new DateTimeOffset(new DateTime(2022, 12, 27, 0, 50, 27, 181, DateTimeKind.Unspecified).AddTicks(6641), new TimeSpan(0, 2, 0, 0, 0)), 3L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 8, 29, 12, 2, 11, 435, DateTimeKind.Unspecified).AddTicks(927), "eveniet", 60, 2, "placeat", new DateTimeOffset(new DateTime(2023, 7, 28, 16, 30, 44, 331, DateTimeKind.Unspecified).AddTicks(4276), new TimeSpan(0, 3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 6, 3, 3, 41, 25, 723, DateTimeKind.Unspecified).AddTicks(2516), 7L, "corporis", 23, "rerum", new DateTimeOffset(new DateTime(2023, 7, 29, 22, 37, 4, 220, DateTimeKind.Unspecified).AddTicks(178), new TimeSpan(0, 3, 0, 0, 0)), 10L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 3, 9, 16, 40, 40, 146, DateTimeKind.Unspecified).AddTicks(445), 9L, "Atque reiciendis et voluptates expedita eaque illu", 42, 2, "et", new DateTimeOffset(new DateTime(2023, 6, 22, 0, 54, 48, 429, DateTimeKind.Unspecified).AddTicks(3094), new TimeSpan(0, 3, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 9, 9, 7, 8, 10, 894, DateTimeKind.Unspecified).AddTicks(5926), 1L, "Expedita nihil culpa officia in similique ipsam at", 12, 0, "dolore", new DateTimeOffset(new DateTime(2022, 10, 9, 3, 39, 27, 215, DateTimeKind.Unspecified).AddTicks(9007), new TimeSpan(0, 3, 0, 0, 0)), 5L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 4, 2, 17, 37, 637, DateTimeKind.Unspecified).AddTicks(5032), "Itaque totam ea earum.\nArchitecto qui earum nemo p", 54, 2, "voluptatem", new DateTimeOffset(new DateTime(2022, 9, 1, 12, 2, 27, 372, DateTimeKind.Unspecified).AddTicks(7517), new TimeSpan(0, 3, 0, 0, 0)), 1L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2019, 12, 9, 18, 58, 48, 445, DateTimeKind.Unspecified).AddTicks(3549), 3L, "et", 59, "et", new DateTimeOffset(new DateTime(2023, 3, 6, 18, 16, 57, 709, DateTimeKind.Unspecified).AddTicks(215), new TimeSpan(0, 2, 0, 0, 0)), 9L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 1, 0, 49, 49, 323, DateTimeKind.Unspecified).AddTicks(4111), 8L, "Deleniti quo nobis et dignissimos cupiditate disti", 13, "et", new DateTimeOffset(new DateTime(2023, 2, 25, 13, 28, 48, 71, DateTimeKind.Unspecified).AddTicks(8981), new TimeSpan(0, 2, 0, 0, 0)), 2L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "LocationType", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2020, 12, 13, 10, 20, 26, 336, DateTimeKind.Unspecified).AddTicks(6472), 4L, "Occaecati iusto id adipisci consequatur possimus o", 29, 2, "autem", new DateTimeOffset(new DateTime(2022, 9, 16, 0, 43, 32, 848, DateTimeKind.Unspecified).AddTicks(3971), new TimeSpan(0, 3, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "CreatedBy", "Description", "Duration", "Name", "StartTime", "TeamId" },
                values: new object[] { new DateTime(2021, 7, 4, 18, 25, 17, 166, DateTimeKind.Unspecified).AddTicks(888), 7L, "Enim et vitae minus. Nemo natus nobis commodi. Dol", 16, "perferendis", new DateTimeOffset(new DateTime(2023, 7, 29, 9, 58, 36, 801, DateTimeKind.Unspecified).AddTicks(5983), new TimeSpan(0, 3, 0, 0, 0)), 1L });

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
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 3L, "abAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" });

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
                column: "Text",
                value: "Velit fugiat sint sint.AAAAAAAAAAAAAAAAAAAAAAAAAAA");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Text" },
                values: new object[] { 6L, "Et qui aliquid asperiores. Quia optio sed itaque qui. In excepturi amet. Assumenda provident sit tempora numquam iure." });

            migrationBuilder.InsertData(
                table: "TeamMemberMeetings",
                columns: new[] { "Id", "EventId", "IsDeleted", "MemberId", "Priority" },
                values: new object[,]
                {
                    { 1L, 1L, false, 1L, 3 },
                    { 2L, 2L, false, 2L, 5 },
                    { 3L, 3L, false, 3L, 3 },
                    { 4L, 4L, false, 4L, 4 },
                    { 5L, 5L, false, 5L, 10 },
                    { 6L, 6L, false, 6L, 9 },
                    { 7L, 7L, false, 7L, 10 },
                    { 8L, 8L, false, 8L, 6 },
                    { 9L, 9L, false, 9L, 3 },
                    { 10L, 10L, false, 10L, 1 }
                });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Role", "Status" },
                values: new object[] { 1, 2 });

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
                column: "Status",
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
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Hattie29@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/801.jpg", "Hattie Hane", "1-775-291-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "James38@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/282.jpg", "James Prohaska", "639.599.49", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 1, "Salvatore.Champlin40@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/706.jpg", "Salvatore Champlin", "561-981-13", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Toni25@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/433.jpg", "Toni Carroll", "714-216-42", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Lance_Ebert68@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/859.jpg", "Lance Ebert", "1-687-614-", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { "Clark_Moore@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/839.jpg", "Clark Moore", "741-251-70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Rose90@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/337.jpg", "Rose Stracke", "797-876-66", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber" },
                values: new object[] { 0, "Henrietta85@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/197.jpg", "Henrietta Powlowski", "(447) 233-" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "DateFormat", "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { 0, "Carl77@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/188.jpg", "Carl Beahan", "853-403-53", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Email", "ImagePath", "Name", "PhoneNumber", "TimeFormat" },
                values: new object[] { "Alfred48@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/420.jpg", "Alfred Dietrich", "448-988-20", 1 });

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
