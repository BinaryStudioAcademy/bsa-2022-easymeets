using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class Addexclusiondates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExclusionDates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleId = table.Column<long>(type: "bigint", nullable: false),
                    SelectedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExclusionDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExclusionDates_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DayTimeRanges",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExclusionDateId = table.Column<long>(type: "bigint", nullable: false),
                    Start = table.Column<TimeSpan>(type: "time", nullable: false),
                    End = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayTimeRanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DayTimeRanges_ExclusionDates_ExclusionDateId",
                        column: x => x.ExclusionDateId,
                        principalTable: "ExclusionDates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ExclusionDates",
                columns: new[] { "Id", "IsDeleted", "ScheduleId", "SelectedDate" },
                values: new object[,]
                {
                    { 1L, false, 3L, new DateTime(2022, 10, 17, 9, 54, 44, 727, DateTimeKind.Local).AddTicks(7873) },
                    { 2L, false, 1L, new DateTime(2023, 1, 21, 4, 43, 13, 73, DateTimeKind.Local).AddTicks(5457) },
                    { 3L, false, 9L, new DateTime(2023, 3, 5, 5, 35, 9, 820, DateTimeKind.Local).AddTicks(8404) },
                    { 4L, false, 2L, new DateTime(2023, 1, 29, 16, 3, 34, 394, DateTimeKind.Local).AddTicks(4633) },
                    { 5L, false, 6L, new DateTime(2023, 7, 1, 0, 30, 41, 251, DateTimeKind.Local).AddTicks(4138) },
                    { 6L, false, 1L, new DateTime(2023, 1, 14, 8, 33, 4, 857, DateTimeKind.Local).AddTicks(3104) },
                    { 7L, false, 6L, new DateTime(2022, 10, 16, 15, 7, 20, 28, DateTimeKind.Local).AddTicks(7570) },
                    { 8L, false, 8L, new DateTime(2023, 7, 27, 15, 19, 58, 354, DateTimeKind.Local).AddTicks(2412) },
                    { 9L, false, 8L, new DateTime(2023, 4, 27, 10, 27, 17, 911, DateTimeKind.Local).AddTicks(6470) },
                    { 10L, false, 7L, new DateTime(2022, 10, 8, 1, 26, 22, 209, DateTimeKind.Local).AddTicks(2748) }
                });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 5, 5, 35, 9, 838, DateTimeKind.Unspecified).AddTicks(636), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 27, 15, 19, 58, 371, DateTimeKind.Unspecified).AddTicks(5272), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 6, 9, 16, 42, 767, DateTimeKind.Unspecified).AddTicks(7258), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 15, 13, 48, 44, 292, DateTimeKind.Unspecified).AddTicks(8310), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 7, 9, 30, 47, 844, DateTimeKind.Unspecified).AddTicks(1358), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 26, 6, 30, 19, 70, DateTimeKind.Unspecified).AddTicks(5309), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 6, 12, 14, 15, 120, DateTimeKind.Unspecified).AddTicks(4782), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 8, 2, 18, 48, 282, DateTimeKind.Unspecified).AddTicks(1499), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 8, 19, 17, 52, 1, DateTimeKind.Unspecified).AddTicks(8794), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 9, 5, 0, 8, 31, 746, DateTimeKind.Unspecified).AddTicks(3063), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "DayTimeRanges",
                columns: new[] { "Id", "End", "ExclusionDateId", "IsDeleted", "Start" },
                values: new object[,]
                {
                    { 1L, new TimeSpan(0, 15, 0, 0, 0), 3L, false, new TimeSpan(0, 8, 0, 0, 0) },
                    { 2L, new TimeSpan(0, 16, 0, 0, 0), 4L, false, new TimeSpan(0, 12, 0, 0, 0) },
                    { 3L, new TimeSpan(0, 17, 0, 0, 0), 2L, false, new TimeSpan(0, 9, 0, 0, 0) },
                    { 4L, new TimeSpan(0, 16, 0, 0, 0), 9L, false, new TimeSpan(0, 8, 0, 0, 0) },
                    { 5L, new TimeSpan(0, 17, 0, 0, 0), 6L, false, new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DayTimeRanges_ExclusionDateId",
                table: "DayTimeRanges",
                column: "ExclusionDateId");

            migrationBuilder.CreateIndex(
                name: "IX_ExclusionDates_ScheduleId",
                table: "ExclusionDates",
                column: "ScheduleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DayTimeRanges");

            migrationBuilder.DropTable(
                name: "ExclusionDates");

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 5, 1, 19, 28, 986, DateTimeKind.Unspecified).AddTicks(74), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 27, 11, 4, 17, 519, DateTimeKind.Unspecified).AddTicks(4752), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 6, 5, 1, 1, 915, DateTimeKind.Unspecified).AddTicks(6827), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 15, 9, 33, 3, 440, DateTimeKind.Unspecified).AddTicks(7752), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 7, 5, 15, 6, 992, DateTimeKind.Unspecified).AddTicks(772), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 26, 2, 14, 38, 218, DateTimeKind.Unspecified).AddTicks(4741), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 6, 7, 58, 34, 268, DateTimeKind.Unspecified).AddTicks(4253), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 7, 22, 3, 7, 430, DateTimeKind.Unspecified).AddTicks(1004), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 8, 15, 2, 11, 149, DateTimeKind.Unspecified).AddTicks(8340), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 9, 4, 19, 52, 50, 894, DateTimeKind.Unspecified).AddTicks(2479), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
