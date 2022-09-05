using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class RemovedExternalAttendeeAvailability : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExternalAttendeeAvailabilities");

            migrationBuilder.DropColumn(
                name: "EventTime",
                table: "ExternalAttendees");

            migrationBuilder.AlterColumn<string>(
                name: "TimeZoneValue",
                table: "ExternalAttendees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TimeZoneName",
                table: "ExternalAttendees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ExternalAttendees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "Name" },
                values: new object[] { 3L, "Marilyn.Effertz62@hotmail.com", "Marilyn Effertz" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "Name" },
                values: new object[] { 4L, "Connie_Stroman@yahoo.com", "Connie Stroman" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "Name" },
                values: new object[] { 1L, "Jessica61@hotmail.com", "Jessica Wunsch" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "Name" },
                values: new object[] { 2L, "Marta.Waters@yahoo.com", "Marta Waters" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "Name" },
                values: new object[] { "Billie_Parker11@hotmail.com", "Billie Parker" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "Name" },
                values: new object[] { "Justin76@gmail.com", "Justin Renner" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "Name" },
                values: new object[] { 3L, "Irvin48@gmail.com", "Irvin Schmitt" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "Name" },
                values: new object[] { "Stanley_Boyle29@hotmail.com", "Stanley Boyle" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "Name" },
                values: new object[] { 3L, "Kristie.Ondricka17@yahoo.com", "Kristie Ondricka" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 2, 5, 1, 33, 603, DateTimeKind.Unspecified).AddTicks(986), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 24, 14, 46, 22, 136, DateTimeKind.Unspecified).AddTicks(5876), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 3, 8, 43, 6, 532, DateTimeKind.Unspecified).AddTicks(7959), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 12, 13, 15, 8, 57, DateTimeKind.Unspecified).AddTicks(8929), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 4, 8, 57, 11, 609, DateTimeKind.Unspecified).AddTicks(2015), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 23, 5, 56, 42, 835, DateTimeKind.Unspecified).AddTicks(6054), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 3, 11, 40, 38, 885, DateTimeKind.Unspecified).AddTicks(5789), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 5, 1, 45, 12, 47, DateTimeKind.Unspecified).AddTicks(2674), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 5, 18, 44, 15, 767, DateTimeKind.Unspecified).AddTicks(62), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 9, 1, 23, 34, 55, 511, DateTimeKind.Unspecified).AddTicks(4243), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TimeZoneValue",
                table: "ExternalAttendees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "TimeZoneName",
                table: "ExternalAttendees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ExternalAttendees",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "EventTime",
                table: "ExternalAttendees",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateTable(
                name: "ExternalAttendeeAvailabilities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExternalAttendeeId = table.Column<long>(type: "bigint", nullable: false),
                    EndEvent = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    StartEvent = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalAttendeeAvailabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExternalAttendeeAvailabilities_ExternalAttendees_ExternalAttendeeId",
                        column: x => x.ExternalAttendeeId,
                        principalTable: "ExternalAttendees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ExternalAttendeeAvailabilities",
                columns: new[] { "Id", "EndEvent", "ExternalAttendeeId", "IsDeleted", "StartEvent" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2022, 9, 7, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9016), new TimeSpan(0, 3, 0, 0, 0)), 3L, false, new DateTimeOffset(new DateTime(2022, 9, 6, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(8935), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2L, new DateTimeOffset(new DateTime(2022, 9, 7, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9138), new TimeSpan(0, 3, 0, 0, 0)), 2L, false, new DateTimeOffset(new DateTime(2022, 9, 6, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9131), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3L, new DateTimeOffset(new DateTime(2022, 9, 7, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9153), new TimeSpan(0, 3, 0, 0, 0)), 1L, false, new DateTimeOffset(new DateTime(2022, 9, 6, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9149), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4L, new DateTimeOffset(new DateTime(2022, 9, 7, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9173), new TimeSpan(0, 3, 0, 0, 0)), 4L, false, new DateTimeOffset(new DateTime(2022, 9, 6, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9169), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5L, new DateTimeOffset(new DateTime(2022, 9, 7, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9185), new TimeSpan(0, 3, 0, 0, 0)), 9L, false, new DateTimeOffset(new DateTime(2022, 9, 6, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9181), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6L, new DateTimeOffset(new DateTime(2022, 9, 7, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 3, 0, 0, 0)), 5L, false, new DateTimeOffset(new DateTime(2022, 9, 6, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9192), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7L, new DateTimeOffset(new DateTime(2022, 9, 7, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9206), new TimeSpan(0, 3, 0, 0, 0)), 2L, false, new DateTimeOffset(new DateTime(2022, 9, 6, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9203), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8L, new DateTimeOffset(new DateTime(2022, 9, 7, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9217), new TimeSpan(0, 3, 0, 0, 0)), 4L, false, new DateTimeOffset(new DateTime(2022, 9, 6, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9213), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9L, new DateTimeOffset(new DateTime(2022, 9, 7, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9227), new TimeSpan(0, 3, 0, 0, 0)), 6L, false, new DateTimeOffset(new DateTime(2022, 9, 6, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9223), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10L, new DateTimeOffset(new DateTime(2022, 9, 7, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9238), new TimeSpan(0, 3, 0, 0, 0)), 9L, false, new DateTimeOffset(new DateTime(2022, 9, 6, 13, 14, 12, 423, DateTimeKind.Unspecified).AddTicks(9234), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 11, 8, 15, 12, 205, DateTimeKind.Unspecified).AddTicks(7226), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 7L, "Leonard62@hotmail.com", new DateTimeOffset(new DateTime(2023, 1, 4, 6, 24, 7, 240, DateTimeKind.Unspecified).AddTicks(8850), new TimeSpan(0, 2, 0, 0, 0)), "Leonard Effertz" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Dewey_Schuppe@yahoo.com", new DateTimeOffset(new DateTime(2022, 9, 27, 8, 53, 18, 59, DateTimeKind.Unspecified).AddTicks(5776), new TimeSpan(0, 3, 0, 0, 0)), "Dewey Schuppe" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 6L, "Elijah.Blanda@gmail.com", new DateTimeOffset(new DateTime(2023, 4, 20, 14, 48, 14, 10, DateTimeKind.Unspecified).AddTicks(1524), new TimeSpan(0, 3, 0, 0, 0)), "Elijah Blanda" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 5L, "Joel_Goldner@hotmail.com", new DateTimeOffset(new DateTime(2023, 3, 12, 8, 20, 28, 691, DateTimeKind.Unspecified).AddTicks(3636), new TimeSpan(0, 2, 0, 0, 0)), "Joel Goldner" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Jaime.Veum2@hotmail.com", new DateTimeOffset(new DateTime(2023, 1, 7, 0, 38, 1, 335, DateTimeKind.Unspecified).AddTicks(3135), new TimeSpan(0, 2, 0, 0, 0)), "Jaime Veum" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Patti.Feil@yahoo.com", new DateTimeOffset(new DateTime(2023, 7, 24, 6, 22, 14, 752, DateTimeKind.Unspecified).AddTicks(6064), new TimeSpan(0, 3, 0, 0, 0)), "Patti Feil" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 2L, "Jesus9@hotmail.com", new DateTimeOffset(new DateTime(2023, 1, 24, 2, 15, 57, 879, DateTimeKind.Unspecified).AddTicks(9830), new TimeSpan(0, 2, 0, 0, 0)), "Jesus Gorczany" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Email", "EventTime", "Name" },
                values: new object[] { "Jacob.Ondricka6@yahoo.com", new DateTimeOffset(new DateTime(2023, 4, 14, 20, 59, 6, 540, DateTimeKind.Unspecified).AddTicks(3462), new TimeSpan(0, 3, 0, 0, 0)), "Jacob Ondricka" });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AvailabilitySlotId", "Email", "EventTime", "Name" },
                values: new object[] { 1L, "Erma.MacGyver86@hotmail.com", new DateTimeOffset(new DateTime(2023, 4, 24, 6, 52, 42, 497, DateTimeKind.Unspecified).AddTicks(464), new TimeSpan(0, 3, 0, 0, 0)), "Erma MacGyver" });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 2, 3, 2, 4, 468, DateTimeKind.Unspecified).AddTicks(3443), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 24, 12, 46, 53, 1, DateTimeKind.Unspecified).AddTicks(7617), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 3, 6, 43, 37, 397, DateTimeKind.Unspecified).AddTicks(9564), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 12, 11, 15, 38, 923, DateTimeKind.Unspecified).AddTicks(408), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 4, 6, 57, 42, 474, DateTimeKind.Unspecified).AddTicks(3344), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 10, 23, 3, 57, 13, 700, DateTimeKind.Unspecified).AddTicks(7227), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 3, 3, 9, 41, 9, 750, DateTimeKind.Unspecified).AddTicks(6650), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 4, 23, 45, 42, 912, DateTimeKind.Unspecified).AddTicks(3311), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 5, 16, 44, 46, 632, DateTimeKind.Unspecified).AddTicks(555), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 9, 1, 21, 35, 26, 376, DateTimeKind.Unspecified).AddTicks(4603), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_ExternalAttendeeAvailabilities_ExternalAttendeeId",
                table: "ExternalAttendeeAvailabilities",
                column: "ExternalAttendeeId");
        }
    }
}
