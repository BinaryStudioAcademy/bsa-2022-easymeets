using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class ChangedCalendarEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccessToken",
                table: "Calendars",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConnectedCalendar",
                table: "Calendars",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "Calendars",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AccessToken", "ConnectedCalendar", "CreatedAt", "RefreshToken" },
                values: new object[] { "Corrupti adipisci reprehenderit unde consequatur explicabo aliquid deserunt aut.AAAAAAAAAAAAAAAAAAAA", "Troy.Kuvalis49@hotmail.comAAAAAAAAAAAAAAAAAAAAAAAA", new DateTime(2019, 10, 18, 20, 48, 53, 800, DateTimeKind.Unspecified).AddTicks(6711), "Harum soluta vitae atque dolores tempore debitis explicabo.\nBeatae consequatur optio iste qui.\nRepudiandae odit quo aut quisquam et quam.\nQuia id veritatis ab aliquid beatae cumque quas.\nQuia qui qui.\nQuibusdam placeat magni et." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AccessToken", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "UserId" },
                values: new object[] { "Voluptatem quia iste. Officia doloribus exercitationem dolor repudiandae nihil alias asperiores nam quis. Sit sunt non accusamus qui ut. Ea et et rerum.", "Irving1@yahoo.comAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", new DateTime(2020, 9, 30, 6, 12, 30, 664, DateTimeKind.Unspecified).AddTicks(941), 4L, "Temporibus est sit eius dolor quia. Nobis voluptatum sunt. Rerum reprehenderit reiciendis ullam.AAAA", 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "UserId" },
                values: new object[] { "Nam hic soluta.\nSapiente commodi expedita voluptatem hic dolorem.\nAccusamus optio impedit qui nemo qui reprehenderit quod consequatur aut.", 7L, "Linda.Hermann76@hotmail.comAAAAAAAAAAAAAAAAAAAAAAA", new DateTime(2019, 8, 15, 2, 40, 44, 785, DateTimeKind.Unspecified).AddTicks(8721), 9L, "Ipsa quidem voluptatem omnis delectus recusandae. Dolorum rem vel ut enim. Omnis saepe a in necessitatibus magni perferendis quia asperiores fugiat.", 1L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken" },
                values: new object[] { "Eum cupiditate qui. Sunt ut ut nihil. Tenetur earum similique cum voluptatem non ipsa aut esse. Distinctio molestiae qui quis architecto aut et quo.", 2L, "Lisa_Jenkins31@gmail.comAAAAAAAAAAAAAAAAAAAAAAAAAA", new DateTime(2021, 5, 8, 1, 22, 51, 222, DateTimeKind.Unspecified).AddTicks(6459), 9L, "Voluptatum excepturi veritatis expedita id quae. Unde dolores pariatur voluptatem aut qui natus autem nemo voluptatem. Eaque dolores ipsa voluptatum laboriosam fugiat animi non ut. Aliquam tenetur et deserunt modi corrupti deleniti et." });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "UserId" },
                values: new object[] { "Facere assumenda repellat quisquam possimus voluptas vero et.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", 4L, "Louis_Wolf63@gmail.comAAAAAAAAAAAAAAAAAAAAAAAAAAAA", new DateTime(2020, 3, 16, 12, 18, 42, 695, DateTimeKind.Unspecified).AddTicks(8824), 5L, "Animi ullam consequuntur est occaecati veritatis maxime consequatur explicabo.\nEst cupiditate suscipit placeat vitae et non.", 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "UserId" },
                values: new object[] { "Reiciendis magni quia ad magni laboriosam doloribus ut.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", 10L, "Francis9@hotmail.comAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", new DateTime(2020, 5, 19, 12, 41, 3, 101, DateTimeKind.Unspecified).AddTicks(849), 3L, "Aut qui sed repellat tenetur occaecati tempora ea.\nAspernatur amet distinctio.\nCorrupti non id id voluptatem vero voluptas.\nNesciunt voluptatem rerum earum fugit et laborum.\nAliquam culpa autem recusandae pariatur blanditiis possimus impedit incidunt porr", 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "UserId" },
                values: new object[] { "rerumAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", 4L, "Rick56@gmail.comAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", new DateTime(2020, 8, 4, 23, 17, 19, 687, DateTimeKind.Unspecified).AddTicks(5131), 7L, "Hic iure ducimus ea quia et iste excepturi nesciunt consequatur. Placeat id officia voluptas dolor voluptate accusamus. Dignissimos consequatur sit quo quos sint officia provident dolore eius. Harum ratione earum consequatur sapiente.", 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "UserId" },
                values: new object[] { "Et et hic aut et. Omnis occaecati minus animi. Sed corporis dolores nesciunt quia quia rerum aperiam veniam.", 9L, "Joann82@hotmail.comAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", new DateTime(2019, 9, 28, 13, 16, 28, 820, DateTimeKind.Unspecified).AddTicks(7971), 5L, "Corporis rerum rem eveniet est.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "UserId" },
                values: new object[] { "Aut aliquid sed aliquam qui minus neque maiores et. Sed ut aliquid saepe mollitia tempora quos ex. Et optio similique.", 4L, "Suzanne.Brakus40@hotmail.comAAAAAAAAAAAAAAAAAAAAAA", new DateTime(2021, 3, 12, 17, 56, 35, 390, DateTimeKind.Unspecified).AddTicks(355), 6L, "Est vero molestiae.\nEos provident rerum.\nNam eos ipsam quasi.\nOmnis at et veniam eum.\nBeatae reprehenderit laudantium.", 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "UserId" },
                values: new object[] { "Et impedit est. Sequi accusantium est nam. Sit sit nulla sed dolor iste hic maxime ea a. Hic vel ipsa. Consequatur illum excepturi esse.", 1L, "Leo.Grant@hotmail.comAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", new DateTime(2020, 11, 13, 22, 11, 49, 371, DateTimeKind.Unspecified).AddTicks(3924), 9L, "Sunt dolores quo non autem ad hic maxime fuga.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", 4L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3104), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(2873), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3525), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3502), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3582), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3565), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3614), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3604), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3657), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3634), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3687), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3678), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3716), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3707), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3744), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3735), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3776), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3767), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3805), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 22, 31, 33, 922, DateTimeKind.Unspecified).AddTicks(3795), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 11, 27, 17, 32, 33, 694, DateTimeKind.Unspecified).AddTicks(9434), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 21, 15, 41, 28, 730, DateTimeKind.Unspecified).AddTicks(1885), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 13, 18, 10, 39, 548, DateTimeKind.Unspecified).AddTicks(9724), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 7, 0, 5, 35, 499, DateTimeKind.Unspecified).AddTicks(6402), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 17, 37, 50, 180, DateTimeKind.Unspecified).AddTicks(9250), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 24, 9, 55, 22, 825, DateTimeKind.Unspecified).AddTicks(38), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 10, 15, 39, 36, 248, DateTimeKind.Unspecified).AddTicks(3924), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 10, 11, 33, 19, 376, DateTimeKind.Unspecified).AddTicks(231), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 1, 6, 16, 28, 36, DateTimeKind.Unspecified).AddTicks(4990), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 10, 16, 10, 3, 993, DateTimeKind.Unspecified).AddTicks(3570), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 12, 22, 47, 50, 559, DateTimeKind.Unspecified).AddTicks(9935), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 8, 10, 38, 374, DateTimeKind.Unspecified).AddTicks(8458), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 25, 2, 50, 36, 410, DateTimeKind.Unspecified).AddTicks(513), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 5, 6, 5, 58, 52, 684, DateTimeKind.Unspecified).AddTicks(7474), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 1, 10, 6, 30, 772, DateTimeKind.Unspecified).AddTicks(6328), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 18, 19, 15, 57, 814, DateTimeKind.Unspecified).AddTicks(4499), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 11, 26, 2, 29, 2, 410, DateTimeKind.Unspecified).AddTicks(5952), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 8, 52, 44, 879, DateTimeKind.Unspecified).AddTicks(6736), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 8, 2, 13, 15, 49, 440, DateTimeKind.Unspecified).AddTicks(2292), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 11, 52, 4, 404, DateTimeKind.Unspecified).AddTicks(140), new TimeSpan(0, 2, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessToken",
                table: "Calendars");

            migrationBuilder.DropColumn(
                name: "ConnectedCalendar",
                table: "Calendars");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "Calendars");

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 23, 13, 17, 22, 296, DateTimeKind.Unspecified).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { new DateTime(2020, 10, 6, 14, 3, 14, 116, DateTimeKind.Unspecified).AddTicks(7873), 2L, 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 11, 6, 6, 4, 37, 929, DateTimeKind.Unspecified).AddTicks(5830), 1L, 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy" },
                values: new object[] { 6L, new DateTime(2019, 10, 14, 3, 44, 21, 857, DateTimeKind.Unspecified).AddTicks(6664), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 5, 22, 2, 45, 51, 178, DateTimeKind.Unspecified).AddTicks(1754), 7L, 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 5L, new DateTime(2019, 10, 17, 13, 4, 55, 428, DateTimeKind.Unspecified).AddTicks(4202), 7L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 1L, new DateTime(2021, 7, 14, 5, 31, 55, 24, DateTimeKind.Unspecified).AddTicks(9201), 1L, 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 5, 3, 1, 4, 9, 423, DateTimeKind.Unspecified).AddTicks(571), 4L, 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 10L, new DateTime(2021, 5, 7, 1, 31, 28, 26, DateTimeKind.Unspecified).AddTicks(3205), 9L, 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UserId" },
                values: new object[] { 8L, new DateTime(2020, 3, 28, 16, 30, 1, 197, DateTimeKind.Unspecified).AddTicks(8083), 5L, 5L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6144), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6017), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6325), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6315), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6344), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6338), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6361), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6356), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6379), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6373), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6396), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6391), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6413), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6408), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6430), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6425), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6448), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6442), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 24, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6464), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 23, 17, 3, 1, 788, DateTimeKind.Unspecified).AddTicks(6459), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 11, 27, 12, 4, 1, 568, DateTimeKind.Unspecified).AddTicks(9639), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 21, 10, 12, 56, 604, DateTimeKind.Unspecified).AddTicks(1164), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 13, 12, 42, 7, 422, DateTimeKind.Unspecified).AddTicks(8121), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 6, 18, 37, 3, 373, DateTimeKind.Unspecified).AddTicks(3892), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 2, 26, 12, 9, 18, 54, DateTimeKind.Unspecified).AddTicks(5980), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 24, 4, 26, 50, 698, DateTimeKind.Unspecified).AddTicks(5569), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 10, 10, 11, 4, 115, DateTimeKind.Unspecified).AddTicks(8587), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 10, 6, 4, 47, 243, DateTimeKind.Unspecified).AddTicks(2452), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 1, 0, 47, 55, 903, DateTimeKind.Unspecified).AddTicks(6827), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 10, 10, 41, 31, 860, DateTimeKind.Unspecified).AddTicks(4280), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 12, 17, 19, 18, 436, DateTimeKind.Unspecified).AddTicks(2667), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 21, 2, 42, 6, 251, DateTimeKind.Unspecified).AddTicks(887), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 24, 21, 22, 4, 286, DateTimeKind.Unspecified).AddTicks(2863), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 5, 6, 0, 30, 20, 560, DateTimeKind.Unspecified).AddTicks(9769), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 1, 4, 37, 58, 648, DateTimeKind.Unspecified).AddTicks(8618), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 18, 13, 47, 25, 690, DateTimeKind.Unspecified).AddTicks(6729), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2022, 11, 25, 21, 0, 30, 286, DateTimeKind.Unspecified).AddTicks(7985), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 3, 24, 12, 755, DateTimeKind.Unspecified).AddTicks(8715), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 8, 2, 7, 47, 17, 316, DateTimeKind.Unspecified).AddTicks(4208), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartTime",
                value: new DateTimeOffset(new DateTime(2023, 2, 12, 6, 23, 32, 280, DateTimeKind.Unspecified).AddTicks(1942), new TimeSpan(0, 2, 0, 0, 0)));
        }
    }
}
