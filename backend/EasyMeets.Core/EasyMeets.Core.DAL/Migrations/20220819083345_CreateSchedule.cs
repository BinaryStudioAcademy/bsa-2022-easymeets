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
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 21, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1132), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 20, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1001), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 21, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1435), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 20, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 21, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1465), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 20, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1458), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 21, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1497), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 20, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1490), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 21, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1528), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 20, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1520), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 21, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1551), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 20, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1544), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 21, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1579), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 20, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1569), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 21, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1604), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 20, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1596), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 21, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1634), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 20, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1621), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 21, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1657), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 20, 11, 33, 44, 114, DateTimeKind.Unspecified).AddTicks(1650), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 11, 24, 6, 34, 43, 892, DateTimeKind.Unspecified).AddTicks(3921), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 18, 4, 43, 38, 927, DateTimeKind.Unspecified).AddTicks(5994), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 10, 7, 12, 49, 746, DateTimeKind.Unspecified).AddTicks(3365), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 3, 13, 7, 45, 696, DateTimeKind.Unspecified).AddTicks(9453), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 2, 23, 6, 40, 0, 378, DateTimeKind.Unspecified).AddTicks(2077), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 20, 22, 57, 33, 22, DateTimeKind.Unspecified).AddTicks(2134), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 7, 4, 41, 46, 439, DateTimeKind.Unspecified).AddTicks(5684), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 7, 0, 35, 29, 567, DateTimeKind.Unspecified).AddTicks(51), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 28, 19, 18, 38, 227, DateTimeKind.Unspecified).AddTicks(4155), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 7, 5, 12, 14, 184, DateTimeKind.Unspecified).AddTicks(1447), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 9, 11, 50, 0, 752, DateTimeKind.Unspecified).AddTicks(1350), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 6, 6, 20, 58, 531, DateTimeKind.Unspecified).AddTicks(2137), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 17, 5, 3, 9, 108, DateTimeKind.Unspecified).AddTicks(1457), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 26, 7, 5, 58, 349, DateTimeKind.Unspecified).AddTicks(48), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 15, 8, 18, 8, 6, DateTimeKind.Unspecified).AddTicks(5706), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 15, 4, 18, 342, DateTimeKind.Unspecified).AddTicks(2761), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 15, 8, 25, 53, 431, DateTimeKind.Unspecified).AddTicks(4619), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 9, 12, 28, 10, 980, DateTimeKind.Unspecified).AddTicks(7856), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 10, 3, 1, 1, 170, DateTimeKind.Unspecified).AddTicks(309), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 5, 3, 54, 2, 482, DateTimeKind.Unspecified).AddTicks(8990), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "AvailabilitySlotId", "IsDeleted", "TimeZone", "WithTeamMembers" },
                values: new object[,]
                {
                    { 1L, 1L, false, -300, true },
                    { 2L, 2L, false, -660, true },
                    { 3L, 3L, false, 480, true },
                    { 4L, 4L, false, -420, true },
                    { 5L, 5L, false, 60, false },
                    { 6L, 6L, false, -540, true },
                    { 7L, 7L, false, 120, true },
                    { 8L, 8L, false, 300, false },
                    { 9L, 9L, false, 300, false },
                    { 10L, 10L, false, 240, true }
                });

            migrationBuilder.InsertData(
                table: "ScheduleItems",
                columns: new[] { "Id", "End", "IsDeleted", "IsEnabled", "ScheduleId", "Start", "WeekDay" },
                values: new object[,]
                {
                    { 1L, new TimeSpan(0, 13, 0, 0, 0), false, true, 1L, new TimeSpan(0, 8, 0, 0, 0), 0 },
                    { 2L, new TimeSpan(0, 15, 0, 0, 0), false, true, 1L, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 3L, new TimeSpan(0, 16, 0, 0, 0), false, true, 1L, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 4L, new TimeSpan(0, 15, 0, 0, 0), false, false, 1L, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 5L, new TimeSpan(0, 17, 0, 0, 0), false, false, 1L, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 6L, new TimeSpan(0, 16, 0, 0, 0), false, false, 1L, new TimeSpan(0, 11, 0, 0, 0), 5 },
                    { 7L, new TimeSpan(0, 15, 0, 0, 0), false, false, 1L, new TimeSpan(0, 8, 0, 0, 0), 6 },
                    { 8L, new TimeSpan(0, 18, 0, 0, 0), false, true, 2L, new TimeSpan(0, 11, 0, 0, 0), 0 },
                    { 9L, new TimeSpan(0, 13, 0, 0, 0), false, true, 2L, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 10L, new TimeSpan(0, 16, 0, 0, 0), false, true, 2L, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 11L, new TimeSpan(0, 18, 0, 0, 0), false, true, 2L, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 12L, new TimeSpan(0, 13, 0, 0, 0), false, true, 2L, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 13L, new TimeSpan(0, 15, 0, 0, 0), false, false, 2L, new TimeSpan(0, 10, 0, 0, 0), 5 },
                    { 14L, new TimeSpan(0, 17, 0, 0, 0), false, false, 2L, new TimeSpan(0, 8, 0, 0, 0), 6 },
                    { 15L, new TimeSpan(0, 15, 0, 0, 0), false, true, 3L, new TimeSpan(0, 8, 0, 0, 0), 0 },
                    { 16L, new TimeSpan(0, 16, 0, 0, 0), false, true, 3L, new TimeSpan(0, 11, 0, 0, 0), 1 },
                    { 17L, new TimeSpan(0, 15, 0, 0, 0), false, true, 3L, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 18L, new TimeSpan(0, 17, 0, 0, 0), false, true, 3L, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 19L, new TimeSpan(0, 15, 0, 0, 0), false, false, 3L, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 20L, new TimeSpan(0, 16, 0, 0, 0), false, true, 3L, new TimeSpan(0, 9, 0, 0, 0), 5 },
                    { 21L, new TimeSpan(0, 17, 0, 0, 0), false, true, 3L, new TimeSpan(0, 8, 0, 0, 0), 6 },
                    { 22L, new TimeSpan(0, 15, 0, 0, 0), false, false, 4L, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 23L, new TimeSpan(0, 14, 0, 0, 0), false, true, 4L, new TimeSpan(0, 10, 0, 0, 0), 1 },
                    { 24L, new TimeSpan(0, 14, 0, 0, 0), false, false, 4L, new TimeSpan(0, 8, 0, 0, 0), 2 },
                    { 25L, new TimeSpan(0, 18, 0, 0, 0), false, true, 4L, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 26L, new TimeSpan(0, 16, 0, 0, 0), false, false, 4L, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 27L, new TimeSpan(0, 16, 0, 0, 0), false, false, 4L, new TimeSpan(0, 8, 0, 0, 0), 5 },
                    { 28L, new TimeSpan(0, 15, 0, 0, 0), false, false, 4L, new TimeSpan(0, 12, 0, 0, 0), 6 },
                    { 29L, new TimeSpan(0, 15, 0, 0, 0), false, true, 5L, new TimeSpan(0, 8, 0, 0, 0), 0 },
                    { 30L, new TimeSpan(0, 17, 0, 0, 0), false, true, 5L, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 31L, new TimeSpan(0, 14, 0, 0, 0), false, false, 5L, new TimeSpan(0, 10, 0, 0, 0), 2 },
                    { 32L, new TimeSpan(0, 18, 0, 0, 0), false, false, 5L, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 33L, new TimeSpan(0, 16, 0, 0, 0), false, true, 5L, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 34L, new TimeSpan(0, 14, 0, 0, 0), false, false, 5L, new TimeSpan(0, 11, 0, 0, 0), 5 },
                    { 35L, new TimeSpan(0, 13, 0, 0, 0), false, true, 5L, new TimeSpan(0, 10, 0, 0, 0), 6 },
                    { 36L, new TimeSpan(0, 14, 0, 0, 0), false, true, 6L, new TimeSpan(0, 8, 0, 0, 0), 0 },
                    { 37L, new TimeSpan(0, 13, 0, 0, 0), false, false, 6L, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 38L, new TimeSpan(0, 14, 0, 0, 0), false, false, 6L, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 39L, new TimeSpan(0, 14, 0, 0, 0), false, false, 6L, new TimeSpan(0, 12, 0, 0, 0), 3 },
                    { 40L, new TimeSpan(0, 15, 0, 0, 0), false, true, 6L, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 41L, new TimeSpan(0, 13, 0, 0, 0), false, true, 6L, new TimeSpan(0, 9, 0, 0, 0), 5 },
                    { 42L, new TimeSpan(0, 16, 0, 0, 0), false, false, 6L, new TimeSpan(0, 12, 0, 0, 0), 6 }
                });

            migrationBuilder.InsertData(
                table: "ScheduleItems",
                columns: new[] { "Id", "End", "IsDeleted", "IsEnabled", "ScheduleId", "Start", "WeekDay" },
                values: new object[,]
                {
                    { 43L, new TimeSpan(0, 17, 0, 0, 0), false, false, 7L, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 44L, new TimeSpan(0, 13, 0, 0, 0), false, false, 7L, new TimeSpan(0, 11, 0, 0, 0), 1 },
                    { 45L, new TimeSpan(0, 15, 0, 0, 0), false, false, 7L, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 46L, new TimeSpan(0, 16, 0, 0, 0), false, true, 7L, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 47L, new TimeSpan(0, 17, 0, 0, 0), false, true, 7L, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 48L, new TimeSpan(0, 15, 0, 0, 0), false, true, 7L, new TimeSpan(0, 9, 0, 0, 0), 5 },
                    { 49L, new TimeSpan(0, 18, 0, 0, 0), false, false, 7L, new TimeSpan(0, 12, 0, 0, 0), 6 },
                    { 50L, new TimeSpan(0, 15, 0, 0, 0), false, false, 8L, new TimeSpan(0, 8, 0, 0, 0), 0 },
                    { 51L, new TimeSpan(0, 14, 0, 0, 0), false, false, 8L, new TimeSpan(0, 11, 0, 0, 0), 1 },
                    { 52L, new TimeSpan(0, 14, 0, 0, 0), false, true, 8L, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 53L, new TimeSpan(0, 15, 0, 0, 0), false, true, 8L, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 54L, new TimeSpan(0, 18, 0, 0, 0), false, false, 8L, new TimeSpan(0, 9, 0, 0, 0), 4 },
                    { 55L, new TimeSpan(0, 14, 0, 0, 0), false, true, 8L, new TimeSpan(0, 12, 0, 0, 0), 5 },
                    { 56L, new TimeSpan(0, 18, 0, 0, 0), false, true, 8L, new TimeSpan(0, 12, 0, 0, 0), 6 },
                    { 57L, new TimeSpan(0, 16, 0, 0, 0), false, false, 9L, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 58L, new TimeSpan(0, 13, 0, 0, 0), false, false, 9L, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 59L, new TimeSpan(0, 13, 0, 0, 0), false, false, 9L, new TimeSpan(0, 12, 0, 0, 0), 2 },
                    { 60L, new TimeSpan(0, 13, 0, 0, 0), false, false, 9L, new TimeSpan(0, 12, 0, 0, 0), 3 },
                    { 61L, new TimeSpan(0, 14, 0, 0, 0), false, false, 9L, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 62L, new TimeSpan(0, 18, 0, 0, 0), false, true, 9L, new TimeSpan(0, 8, 0, 0, 0), 5 },
                    { 63L, new TimeSpan(0, 18, 0, 0, 0), false, false, 9L, new TimeSpan(0, 11, 0, 0, 0), 6 },
                    { 64L, new TimeSpan(0, 16, 0, 0, 0), false, true, 10L, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 65L, new TimeSpan(0, 16, 0, 0, 0), false, true, 10L, new TimeSpan(0, 11, 0, 0, 0), 1 },
                    { 66L, new TimeSpan(0, 14, 0, 0, 0), false, false, 10L, new TimeSpan(0, 12, 0, 0, 0), 2 },
                    { 67L, new TimeSpan(0, 13, 0, 0, 0), false, true, 10L, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 68L, new TimeSpan(0, 16, 0, 0, 0), false, false, 10L, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 69L, new TimeSpan(0, 16, 0, 0, 0), false, false, 10L, new TimeSpan(0, 8, 0, 0, 0), 5 },
                    { 70L, new TimeSpan(0, 18, 0, 0, 0), false, true, 10L, new TimeSpan(0, 11, 0, 0, 0), 6 }
                });

            migrationBuilder.InsertData(
                table: "SlotMembers",
                columns: new[] { "Id", "EventId", "IsDeleted", "MemberId", "Priority", "ScheduleId" },
                values: new object[,]
                {
                    { 1L, 1L, false, 1L, 3, 1L },
                    { 2L, 2L, false, 2L, 2, 2L },
                    { 3L, 3L, false, 3L, 1, 3L },
                    { 4L, 4L, false, 4L, 4, 4L },
                    { 5L, 5L, false, 5L, 9, 5L },
                    { 6L, 6L, false, 6L, 5, 6L },
                    { 7L, 7L, false, 7L, 2, 7L },
                    { 8L, 8L, false, 8L, 4, 8L },
                    { 9L, 9L, false, 9L, 6, 9L },
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
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(8089), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(7679), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(8964), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(8898), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9104), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9063), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9223), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9197), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9555), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9517), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9676), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9650), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9809), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9776), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9932), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9866), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 532, DateTimeKind.Unspecified).AddTicks(19), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 531, DateTimeKind.Unspecified).AddTicks(9993), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 20, 21, 13, 33, 532, DateTimeKind.Unspecified).AddTicks(91), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 19, 21, 13, 33, 532, DateTimeKind.Unspecified).AddTicks(68), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 11, 23, 16, 14, 33, 297, DateTimeKind.Unspecified).AddTicks(2027), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 17, 14, 23, 28, 332, DateTimeKind.Unspecified).AddTicks(6148), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 9, 16, 52, 39, 151, DateTimeKind.Unspecified).AddTicks(5428), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 2, 22, 47, 35, 102, DateTimeKind.Unspecified).AddTicks(3409), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 2, 22, 16, 19, 49, 783, DateTimeKind.Unspecified).AddTicks(7722), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 20, 8, 37, 22, 427, DateTimeKind.Unspecified).AddTicks(9219), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 6, 14, 21, 35, 845, DateTimeKind.Unspecified).AddTicks(4506), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 6, 10, 15, 18, 973, DateTimeKind.Unspecified).AddTicks(499), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 28, 4, 58, 27, 633, DateTimeKind.Unspecified).AddTicks(6130), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 6, 14, 52, 3, 590, DateTimeKind.Unspecified).AddTicks(5247), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 8, 21, 29, 50, 143, DateTimeKind.Unspecified).AddTicks(4347), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 5, 16, 0, 47, 922, DateTimeKind.Unspecified).AddTicks(5745), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 16, 14, 42, 58, 499, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 25, 16, 45, 47, 740, DateTimeKind.Unspecified).AddTicks(4378), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 14, 17, 57, 57, 398, DateTimeKind.Unspecified).AddTicks(932), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 19, 0, 44, 7, 733, DateTimeKind.Unspecified).AddTicks(8294), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 14, 18, 5, 42, 823, DateTimeKind.Unspecified).AddTicks(1035), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 8, 22, 8, 0, 372, DateTimeKind.Unspecified).AddTicks(4596), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 9, 12, 40, 50, 561, DateTimeKind.Unspecified).AddTicks(8630), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 4, 13, 33, 51, 874, DateTimeKind.Unspecified).AddTicks(7614), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "TeamMemberMeetings",
                columns: new[] { "Id", "EventId", "IsDeleted", "MemberId", "Priority" },
                values: new object[,]
                {
                    { 1L, 1L, false, 1L, 3 },
                    { 2L, 2L, false, 2L, 2 },
                    { 3L, 3L, false, 3L, 1 },
                    { 4L, 4L, false, 4L, 4 },
                    { 5L, 5L, false, 5L, 9 },
                    { 6L, 6L, false, 6L, 5 },
                    { 7L, 7L, false, 7L, 2 },
                    { 8L, 8L, false, 8L, 4 },
                    { 9L, 9L, false, 9L, 6 },
                    { 10L, 10L, false, 10L, 9 }
                });

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
