using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class ChangeCalendarEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "AddEventsFromTeamId",
                table: "Calendars",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

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

            migrationBuilder.AddColumn<string>(
                name: "Uid",
                table: "Calendars",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AccessToken", "ConnectedCalendar", "CreatedAt", "RefreshToken", "Uid", "UpdatedAt" },
                values: new object[] { "Corrupti adipisci reprehenderit unde consequatur explicabo aliquid deserunt aut.AAAAAAAAAAAAAAAAAAAA", "Troy.Kuvalis49@hotmail.com", new DateTime(2020, 8, 6, 9, 54, 16, 144, DateTimeKind.Unspecified).AddTicks(7369), "Harum soluta vitae atque dolores tempore debitis explicabo.\nBeatae consequatur optio iste qui.\nRepudiandae odit quo aut quisquam et quam.\nQuia id veritatis ab aliquid beatae cumque quas.\nQuia qui qui.\nQuibusdam placeat magni et.", "Voluptatem rerum esse vitae. Quia iste itaque offi", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "Uid", "UpdatedAt", "UserId" },
                values: new object[] { "Ullam illo vel sapiente necessitatibus totam molestias et odit sit.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", 6L, "Rosa3@gmail.com", new DateTime(2020, 4, 28, 16, 59, 30, 530, DateTimeKind.Unspecified).AddTicks(4371), 9L, "Voluptas et architecto.\nAccusantium aliquam quis quia reiciendis qui est aut.\nEnim est aspernatur.\nDolorum recusandae voluptas dolore inventore mollitia ab voluptatibus.\nSunt ut neque.\nNeque fuga recusandae modi voluptas omnis in.", "Magni perferendis quia asperiores fugiat omnis ali", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "Uid", "UpdatedAt", "UserId" },
                values: new object[] { "Iste soluta sed similique maxime soluta nihil.\nNatus vel mollitia.\nIpsam debitis repellat repudiandae delectus dolor voluptatem.", 8L, "Lisa76@gmail.com", new DateTime(2019, 8, 29, 4, 21, 5, 517, DateTimeKind.Unspecified).AddTicks(4105), 7L, "Accusantium eum cupiditate qui dolores sunt. Ut nihil et tenetur earum. Cum voluptatem non ipsa aut esse et. Molestiae qui quis architecto aut et quo rerum. Vel voluptatum excepturi veritatis expedita id. Et unde dolores.", "vitae", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "Uid", "UpdatedAt", "UserId" },
                values: new object[] { "perferendisAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", 9L, "Kimberly.Paucek48@hotmail.com", new DateTime(2020, 12, 3, 14, 44, 12, 22, DateTimeKind.Unspecified).AddTicks(8290), 4L, "Provident consectetur veniam quia.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "Molestiae omnis exercitationem soluta et labore co", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 3L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "Uid", "UpdatedAt", "UserId" },
                values: new object[] { "Nisi dolorem tempora tempore repellat distinctio. Nostrum est reiciendis magni quia. Magni laboriosam doloribus ut est. Et aut qui sed repellat tenetur occaecati tempora ea perferendis. Amet distinctio iste.", 3L, "Irvin.Weimann57@yahoo.com", new DateTime(2020, 10, 24, 11, 24, 44, 777, DateTimeKind.Unspecified).AddTicks(7364), 6L, "Id id voluptatem vero voluptas natus nesciunt.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "Quia sed ipsum officiis qui qui molestias sint. Ea", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "Uid", "UpdatedAt", "UserId" },
                values: new object[] { "Voluptate accusamus asperiores dignissimos.\nSit quo quos.\nOfficia provident dolore eius consequatur harum ratione.", 6L, "Harriet_Morar@hotmail.com", new DateTime(2020, 7, 23, 11, 43, 18, 574, DateTimeKind.Unspecified).AddTicks(8741), 8L, "Commodi iure voluptatum et quia molestiae quis ut natus voluptatem. Pariatur facere et nihil id. Saepe sit et. Tempore a nulla et eveniet enim exercitationem. Id nihil consequatur molestiae et delectus autem recusandae et. Sint quisquam veritatis sequi te", "enim", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "Uid", "UpdatedAt", "UserId" },
                values: new object[] { "Alias voluptatem et et quidem animi voluptatum delectus adipisci.\nDolorem illo laudantium culpa sit.\nPraesentium aperiam praesentium ut quos.\nNam ad in.\nQui incidunt ut fuga porro.\nNon vel quisquam ut.", 4L, "Pete.Reynolds@gmail.com", new DateTime(2021, 5, 28, 11, 43, 49, 681, DateTimeKind.Unspecified).AddTicks(9273), 7L, "Et qui non eum aut aliquid sed.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "Vel aspernatur deleniti voluptate nobis possimus v", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "Uid", "UpdatedAt", "UserId" },
                values: new object[] { "Autem porro eius dolor doloremque qui eveniet nulla.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", 1L, "Shelia19@hotmail.com", new DateTime(2021, 6, 28, 18, 19, 1, 189, DateTimeKind.Unspecified).AddTicks(1738), 10L, "Impedit est et sequi accusantium est nam aut.\nSit nulla sed dolor iste.AAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "Beatae magnam velit architecto. Est quos officiis", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 10L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "Uid", "UpdatedAt", "UserId" },
                values: new object[] { "Molestias magni corrupti autem cumque culpa inventore omnis. Mollitia sed incidunt praesentium ullam. Commodi ad dignissimos id deserunt aut assumenda.", 7L, "Ada.Towne@yahoo.com", new DateTime(2021, 5, 18, 18, 49, 24, 553, DateTimeKind.Unspecified).AddTicks(4548), 10L, "Quos officia quaerat omnis.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "Quo voluptatem eveniet sunt tempora et ut dolor.\nA", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 8L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AccessToken", "AddEventsFromTeamId", "ConnectedCalendar", "CreatedAt", "CreatedBy", "RefreshToken", "Uid", "UpdatedAt", "UserId" },
                values: new object[] { "Qui et sed sint ea voluptatibus.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", 3L, "Patsy12@gmail.com", new DateTime(2021, 6, 22, 21, 6, 32, 752, DateTimeKind.Unspecified).AddTicks(6828), 2L, "Nulla voluptas est.\nRepudiandae ea a debitis et autem.\nQuia id quod perferendis sunt consectetur expedita autem at sit.\nHic dolores nihil.\nProvident sit dignissimos ipsa nesciunt non.", "hic", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 4L });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 25, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9363), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 24, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9207), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 25, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9753), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 24, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9728), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 25, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9788), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 24, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9778), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 25, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9818), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 24, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9809), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 25, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9861), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 24, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9839), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 25, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9894), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 24, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9884), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 25, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9923), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 24, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9914), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 25, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9952), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 24, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9943), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 25, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9981), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 24, 21, 3, 32, 536, DateTimeKind.Unspecified).AddTicks(9972), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndEvent", "StartEvent" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 8, 25, 21, 3, 32, 537, DateTimeKind.Unspecified).AddTicks(10), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 24, 21, 3, 32, 537, DateTimeKind.Unspecified).AddTicks(1), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 11, 28, 16, 4, 32, 315, DateTimeKind.Unspecified).AddTicks(9201), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 22, 14, 13, 27, 351, DateTimeKind.Unspecified).AddTicks(1944), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 9, 14, 16, 42, 38, 169, DateTimeKind.Unspecified).AddTicks(9994), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 7, 22, 37, 34, 120, DateTimeKind.Unspecified).AddTicks(6966), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 2, 27, 16, 9, 48, 802, DateTimeKind.Unspecified).AddTicks(180), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2022, 12, 25, 8, 27, 21, 446, DateTimeKind.Unspecified).AddTicks(805), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 7, 11, 14, 11, 34, 863, DateTimeKind.Unspecified).AddTicks(4871), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 1, 11, 10, 5, 17, 991, DateTimeKind.Unspecified).AddTicks(162), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 2, 4, 48, 26, 651, DateTimeKind.Unspecified).AddTicks(5104), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L,
                column: "EventTime",
                value: new DateTimeOffset(new DateTime(2023, 4, 11, 14, 42, 2, 608, DateTimeKind.Unspecified).AddTicks(3323), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 13, 21, 19, 49, 180, DateTimeKind.Unspecified).AddTicks(1013), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 22, 6, 42, 36, 995, DateTimeKind.Unspecified).AddTicks(25), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 26, 1, 22, 35, 30, DateTimeKind.Unspecified).AddTicks(2339), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 7, 4, 30, 51, 304, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 2, 8, 38, 29, 392, DateTimeKind.Unspecified).AddTicks(8352), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 19, 17, 47, 56, 434, DateTimeKind.Unspecified).AddTicks(6823), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 27, 1, 1, 1, 30, DateTimeKind.Unspecified).AddTicks(8546), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 7, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(9433), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 3, 11, 47, 48, 60, DateTimeKind.Unspecified).AddTicks(5151), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 13, 10, 24, 3, 24, DateTimeKind.Unspecified).AddTicks(3041), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });
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

            migrationBuilder.DropColumn(
                name: "Uid",
                table: "Calendars");

            migrationBuilder.AlterColumn<long>(
                name: "AddEventsFromTeamId",
                table: "Calendars",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L,
                column: "StartDate",
                value: new DateTimeOffset(new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L,
                column: "UpdatedAt",
                value: new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 10, 23, 13, 17, 22, 296, DateTimeKind.Unspecified).AddTicks(4676), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 9L, new DateTime(2020, 10, 6, 14, 3, 14, 116, DateTimeKind.Unspecified).AddTicks(7873), 2L, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 5L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2020, 11, 6, 6, 4, 37, 929, DateTimeKind.Unspecified).AddTicks(5830), 1L, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 9L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 6L, new DateTime(2019, 10, 14, 3, 44, 21, 857, DateTimeKind.Unspecified).AddTicks(6664), 8L, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2021, 5, 22, 2, 45, 51, 178, DateTimeKind.Unspecified).AddTicks(1754), 7L, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 7L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 5L, new DateTime(2019, 10, 17, 13, 4, 55, 428, DateTimeKind.Unspecified).AddTicks(4202), 7L, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 1L, new DateTime(2021, 7, 14, 5, 31, 55, 24, DateTimeKind.Unspecified).AddTicks(9201), 1L, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 4L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 7L, new DateTime(2020, 5, 3, 1, 4, 9, 423, DateTimeKind.Unspecified).AddTicks(571), 4L, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 6L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 10L, new DateTime(2021, 5, 7, 1, 31, 28, 26, DateTimeKind.Unspecified).AddTicks(3205), 9L, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 2L });

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddEventsFromTeamId", "CreatedAt", "CreatedBy", "UpdatedAt", "UserId" },
                values: new object[] { 8L, new DateTime(2020, 3, 28, 16, 30, 1, 197, DateTimeKind.Unspecified).AddTicks(8083), 5L, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 5L });

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
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 12, 17, 19, 18, 436, DateTimeKind.Unspecified).AddTicks(2667), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 21, 2, 42, 6, 251, DateTimeKind.Unspecified).AddTicks(887), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 24, 21, 22, 4, 286, DateTimeKind.Unspecified).AddTicks(2863), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 6, 0, 30, 20, 560, DateTimeKind.Unspecified).AddTicks(9769), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 1, 4, 37, 58, 648, DateTimeKind.Unspecified).AddTicks(8618), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 18, 13, 47, 25, 690, DateTimeKind.Unspecified).AddTicks(6729), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 25, 21, 0, 30, 286, DateTimeKind.Unspecified).AddTicks(7985), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 3, 3, 24, 12, 755, DateTimeKind.Unspecified).AddTicks(8715), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 2, 7, 47, 17, 316, DateTimeKind.Unspecified).AddTicks(4208), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "StartTime", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 12, 6, 23, 32, 280, DateTimeKind.Unspecified).AddTicks(1942), new TimeSpan(0, 2, 0, 0, 0)), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
