using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class AddQuestionAnswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionAnswers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    QuestionId = table.Column<long>(type: "bigint", nullable: false),
                    MeetingId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionAnswers_Meetings_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionAnswers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 30, 7, 59, 46, 306, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 2L,
                column: "SelectedDate",
                value: new DateTime(2023, 2, 3, 2, 48, 14, 652, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 3L,
                column: "SelectedDate",
                value: new DateTime(2023, 3, 18, 3, 40, 11, 399, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 4L,
                column: "SelectedDate",
                value: new DateTime(2023, 2, 11, 14, 8, 35, 973, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 5L,
                column: "SelectedDate",
                value: new DateTime(2023, 7, 13, 22, 35, 42, 829, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 6L,
                column: "SelectedDate",
                value: new DateTime(2023, 1, 27, 6, 38, 6, 435, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 7L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 29, 13, 12, 21, 607, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 8L,
                column: "SelectedDate",
                value: new DateTime(2023, 8, 9, 13, 24, 59, 932, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 9L,
                column: "SelectedDate",
                value: new DateTime(2023, 5, 10, 8, 32, 19, 490, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 10L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 20, 23, 31, 23, 787, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 18, 3, 40, 11, 426, DateTimeKind.Unspecified).AddTicks(2342), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 9, 13, 24, 59, 959, DateTimeKind.Unspecified).AddTicks(6722), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 19, 7, 21, 44, 355, DateTimeKind.Unspecified).AddTicks(8652), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 28, 11, 53, 45, 880, DateTimeKind.Unspecified).AddTicks(9509), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 20, 7, 35, 49, 432, DateTimeKind.Unspecified).AddTicks(2473), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 8, 4, 35, 20, 658, DateTimeKind.Unspecified).AddTicks(6380), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 19, 10, 19, 16, 708, DateTimeKind.Unspecified).AddTicks(5830), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 21, 0, 23, 49, 870, DateTimeKind.Unspecified).AddTicks(2516), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 21, 17, 22, 53, 589, DateTimeKind.Unspecified).AddTicks(9787), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 17, 22, 13, 33, 334, DateTimeKind.Unspecified).AddTicks(3862), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_MeetingId",
                table: "QuestionAnswers",
                column: "MeetingId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_QuestionId",
                table: "QuestionAnswers",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionAnswers");

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 1L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 29, 11, 15, 42, 435, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 2L,
                column: "SelectedDate",
                value: new DateTime(2023, 2, 2, 6, 4, 10, 781, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 3L,
                column: "SelectedDate",
                value: new DateTime(2023, 3, 17, 6, 56, 7, 528, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 4L,
                column: "SelectedDate",
                value: new DateTime(2023, 2, 10, 17, 24, 32, 102, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 5L,
                column: "SelectedDate",
                value: new DateTime(2023, 7, 13, 1, 51, 38, 959, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 6L,
                column: "SelectedDate",
                value: new DateTime(2023, 1, 26, 9, 54, 2, 565, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 7L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 28, 16, 28, 17, 736, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 8L,
                column: "SelectedDate",
                value: new DateTime(2023, 8, 8, 16, 40, 56, 62, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 9L,
                column: "SelectedDate",
                value: new DateTime(2023, 5, 9, 11, 48, 15, 619, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "ExclusionDates",
                keyColumn: "Id",
                keyValue: 10L,
                column: "SelectedDate",
                value: new DateTime(2022, 10, 20, 2, 47, 19, 917, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 17, 6, 56, 7, 547, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 8, 16, 40, 56, 81, DateTimeKind.Unspecified).AddTicks(2795), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 18, 10, 37, 40, 477, DateTimeKind.Unspecified).AddTicks(4709), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 27, 15, 9, 42, 2, DateTimeKind.Unspecified).AddTicks(5556), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 19, 10, 51, 45, 553, DateTimeKind.Unspecified).AddTicks(8509), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 7, 7, 51, 16, 780, DateTimeKind.Unspecified).AddTicks(2408), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 18, 13, 35, 12, 830, DateTimeKind.Unspecified).AddTicks(1849), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 20, 3, 39, 45, 991, DateTimeKind.Unspecified).AddTicks(8527), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 20, 20, 38, 49, 711, DateTimeKind.Unspecified).AddTicks(5790), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 17, 1, 29, 29, 455, DateTimeKind.Unspecified).AddTicks(9858), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
