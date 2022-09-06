using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class AddCalendarEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalendarEvents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeZone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalendarEvents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 3, 10, 51, 35, 797, DateTimeKind.Unspecified).AddTicks(4867), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 25, 20, 36, 24, 330, DateTimeKind.Unspecified).AddTicks(9129), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 4, 14, 33, 8, 727, DateTimeKind.Unspecified).AddTicks(1048), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 13, 19, 5, 10, 252, DateTimeKind.Unspecified).AddTicks(1909), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 5, 14, 47, 13, 803, DateTimeKind.Unspecified).AddTicks(4869), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 24, 11, 46, 45, 29, DateTimeKind.Unspecified).AddTicks(8773), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 4, 17, 30, 41, 79, DateTimeKind.Unspecified).AddTicks(8219), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 6, 7, 35, 14, 241, DateTimeKind.Unspecified).AddTicks(4901), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 7, 0, 34, 17, 961, DateTimeKind.Unspecified).AddTicks(2166), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 9, 3, 5, 24, 57, 705, DateTimeKind.Unspecified).AddTicks(6237), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_CalendarEvents_UserId",
                table: "CalendarEvents",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalendarEvents");

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 3, 1, 9, 38, 366, DateTimeKind.Unspecified).AddTicks(3749), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 25, 10, 54, 26, 899, DateTimeKind.Unspecified).AddTicks(8014), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 4, 4, 51, 11, 295, DateTimeKind.Unspecified).AddTicks(9926), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 13, 9, 23, 12, 821, DateTimeKind.Unspecified).AddTicks(775), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 5, 5, 5, 16, 372, DateTimeKind.Unspecified).AddTicks(3732), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 24, 2, 4, 47, 598, DateTimeKind.Unspecified).AddTicks(7643), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 4, 7, 48, 43, 648, DateTimeKind.Unspecified).AddTicks(7089), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 5, 21, 53, 16, 810, DateTimeKind.Unspecified).AddTicks(3769), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 6, 14, 52, 20, 530, DateTimeKind.Unspecified).AddTicks(1033), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 9, 2, 19, 43, 0, 274, DateTimeKind.Unspecified).AddTicks(5102), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
