using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMeets.Core.DAL.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1L, false, "Zoom" },
                    { 2L, false, "GoogleMeet" },
                    { 3L, false, "Discord" },
                    { 4L, false, "Skype" },
                    { 5L, false, "Slack" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Description", "IsDeleted", "LogoPath", "Name", "PageLink", "TimeZone" },
                values: new object[,]
                {
                    { 1L, "Modi a culpa nisi non molestias voluptas eveniet aspernatur. Iure dolorem ut sapiente. Culpa velit dolor quia reiciendis. Quam sed illum.", false, "", "Cummerata - Pouros", "http://marilyne.biz", "Asia/Colo" },
                    { 2L, "Maiores est numquam voluptates et ex voluptatum numquam distinctio.", false, "", "Grimes Group", "http://nathanial.info", "Asia/Bang" },
                    { 3L, "Nisi in praesentium.", false, "", "Will LLC", "http://luz.org", "Asia/Dhak" },
                    { 4L, "Consequatur omnis in.\nProvident aut quos ab.\nFugit et unde odio commodi.", false, "", "Herman - Brown", "http://penelope.net", "America/R" },
                    { 5L, "voluptas", false, "", "Corwin Inc", "http://luther.net", "Asia/Kara" },
                    { 6L, "Itaque laudantium maiores et consequatur.\nDoloremque vel maxime hic quia excepturi.\nExpedita ex qui unde ut laudantium nostrum nisi est.\nDucimus sed ut qui omnis aspernatur beatae voluptas.\nCorporis aut optio necessitatibus fugit et alias.\nAtque error in aut.", false, "", "Boyer - Mayer", "https://elias.name", "America/L" },
                    { 7L, "Et quasi iusto at qui accusamus.\nVoluptate natus nemo officia molestiae hic possimus.", false, "", "Weber - Tillman", "http://emiliano.biz", "Europe/So" },
                    { 8L, "Quibusdam necessitatibus officia incidunt molestiae ad voluptatem ut debitis.\nMagnam illum perferendis sed quibusdam enim.\nUt aut distinctio fugit error repudiandae.", false, "", "Block, Hansen and Gulgowski", "http://consuelo.net", "Asia/Yere" },
                    { 9L, "Laborum et omnis sequi.\nNumquam nihil aspernatur voluptatibus quia non corrupti odio.\nVoluptatum nostrum consequuntur voluptatem illum.\nQui necessitatibus quis sit fugit similique.\nRerum dolore eum quasi cupiditate omnis magnam architecto aliquam quidem.", false, "", "Johnson, Doyle and Wolf", "http://roxanne.biz", "Africa/Ca" },
                    { 10L, "Odit necessitatibus vel qui impedit rerum commodi.\nNon velit ipsa dolores quo omnis possimus.", false, "", "Macejkovic and Sons", "http://ward.biz", "Asia/Kamc" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Country", "DateFormat", "Email", "ImagePath", "IsBanned", "IsDeleted", "Language", "Name", "PhoneNumber", "TimeFormat", "TimeZone" },
                values: new object[,]
                {
                    { 1L, 1, 2, "Delbert.Altenwerth78@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/170.jpg", false, false, 2, "Delbert Altenwerth", "(285) 531-", 2, 5 },
                    { 2L, 1, 2, "Jeanne16@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/296.jpg", false, false, 2, "Jeanne Ruecker", "1-741-465-", 2, 5 },
                    { 3L, 1, 2, "Ted10@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/758.jpg", false, false, 2, "Ted Mohr", "(810) 638-", 2, 5 },
                    { 4L, 1, 2, "Amber76@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1202.jpg", false, false, 2, "Amber Ziemann", "1-204-814-", 2, 5 },
                    { 5L, 1, 2, "Kelley.OKeefe@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1085.jpg", false, false, 2, "Kelley O'Keefe", "(667) 996-", 2, 5 },
                    { 6L, 1, 2, "Bradford_Miller@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/161.jpg", false, false, 2, "Bradford Miller", "360-685-99", 2, 5 },
                    { 7L, 1, 2, "Clayton67@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1092.jpg", false, false, 2, "Clayton Grady", "(671) 649-", 2, 5 },
                    { 8L, 1, 2, "Holly87@yahoo.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/320.jpg", false, false, 2, "Holly Brakus", "365.702.99", 2, 5 },
                    { 9L, 1, 2, "Dexter.Torp@gmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1247.jpg", false, false, 2, "Dexter Torp", "546-618-14", 2, 5 },
                    { 10L, 1, 2, "Kathy32@hotmail.com", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/780.jpg", false, false, 2, "Kathy Hauck", "337-730-04", 2, 5 }
                });

            migrationBuilder.InsertData(
                table: "AvailabilitySlots",
                columns: new[] { "Id", "AdvancedSlotSettingsId", "CreatedAt", "CreatedBy", "Description", "Frequency", "IsDeleted", "IsEnabled", "IsVisible", "Link", "LocationId", "Name", "Size", "TeamId", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2019, 10, 11, 19, 24, 52, 990, DateTimeKind.Unspecified).AddTicks(787), 1L, "Voluptatibus possimus recusandae est non ut dolor porro nulla iure.", 15, false, true, true, "https://maggie.org", 5L, "rerum", 33, 10L, 1, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2L, 2L, new DateTime(2020, 3, 17, 11, 5, 35, 774, DateTimeKind.Unspecified).AddTicks(4272), 2L, "enim", 23, false, true, true, "https://johnpaul.name", 5L, "occaecati", 37, 6L, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3L, 3L, new DateTime(2020, 6, 13, 8, 41, 27, 437, DateTimeKind.Unspecified).AddTicks(9984), 3L, "Dolor quae minus. A vel dolores eos veritatis distinctio veniam aut dolores quas. Distinctio at ut quibusdam velit. Libero accusantium et similique dolorem odit. Qui aut ab eos et delectus provident. Tenetur recusandae quo dolorem unde.", 20, false, true, true, "http://quinton.com", 5L, "sint", 22, 8L, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4L, 4L, new DateTime(2020, 10, 10, 15, 22, 1, 163, DateTimeKind.Unspecified).AddTicks(193), 4L, "asperiores", 19, false, true, true, "http://olin.info", 1L, "consequatur", 33, 10L, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5L, 5L, new DateTime(2019, 9, 30, 3, 53, 36, 554, DateTimeKind.Unspecified).AddTicks(8313), 5L, "Eligendi enim aperiam inventore. Ipsam iure et minus quas dolores cupiditate expedita esse quasi. Expedita corrupti laboriosam nulla laudantium maiores. Ut aut vel error quos harum fugit ab quibusdam. Consequuntur amet et dolorum est rem.", 23, false, true, true, "http://johann.biz", 5L, "suscipit", 23, 9L, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6L, 6L, new DateTime(2019, 9, 27, 3, 38, 26, 472, DateTimeKind.Unspecified).AddTicks(8369), 6L, "temporibus", 22, false, true, true, "https://gonzalo.org", 3L, "et", 24, 10L, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7L, 7L, new DateTime(2019, 9, 22, 3, 33, 51, 988, DateTimeKind.Unspecified).AddTicks(5490), 7L, "dolor", 16, false, true, true, "https://clemmie.com", 2L, "reprehenderit", 47, 10L, 1, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8L, 8L, new DateTime(2021, 6, 7, 22, 15, 50, 860, DateTimeKind.Unspecified).AddTicks(7135), 8L, "Nulla eligendi eum voluptas cum quia sunt fuga. Illo quo aperiam voluptatem tenetur ab. Ullam iure velit doloribus labore distinctio amet doloremque beatae quis.", 24, false, true, true, "https://buster.biz", 1L, "laudantium", 48, 2L, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9L, 9L, new DateTime(2020, 11, 16, 22, 12, 33, 737, DateTimeKind.Unspecified).AddTicks(7701), 9L, "reprehenderit", 16, false, true, true, "https://guadalupe.org", 4L, "qui", 38, 7L, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10L, 10L, new DateTime(2020, 6, 27, 20, 26, 28, 22, DateTimeKind.Unspecified).AddTicks(3493), 10L, "Officia et aut dolorem omnis et quia sint. Odio et excepturi necessitatibus et nihil. Voluptatem ipsam unde modi qui. Ad illum nostrum et dignissimos ut magnam rem amet omnis. Voluptatibus minus doloremque enim corrupti eum blanditiis.", 28, false, true, true, "http://aileen.name", 4L, "eveniet", 59, 8L, 2, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Calendars",
                columns: new[] { "Id", "AddEventsFromTeamId", "CheckForConflicts", "CreatedAt", "CreatedBy", "IsDeleted", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, 1L, false, new DateTime(2019, 9, 29, 21, 17, 30, 360, DateTimeKind.Unspecified).AddTicks(4950), 2L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 4L },
                    { 2L, 5L, false, new DateTime(2021, 1, 20, 1, 30, 5, 200, DateTimeKind.Unspecified).AddTicks(5691), 8L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 4L },
                    { 3L, 10L, false, new DateTime(2020, 3, 2, 8, 2, 47, 723, DateTimeKind.Unspecified).AddTicks(2695), 9L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 4L },
                    { 4L, 8L, false, new DateTime(2020, 1, 19, 12, 18, 4, 520, DateTimeKind.Unspecified).AddTicks(8303), 9L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 8L },
                    { 5L, 9L, false, new DateTime(2019, 9, 23, 0, 47, 26, 569, DateTimeKind.Unspecified).AddTicks(1104), 3L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 9L },
                    { 6L, 10L, false, new DateTime(2020, 7, 18, 20, 37, 47, 38, DateTimeKind.Unspecified).AddTicks(532), 1L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 7L },
                    { 7L, 9L, false, new DateTime(2020, 11, 5, 5, 40, 30, 118, DateTimeKind.Unspecified).AddTicks(5045), 5L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 10L },
                    { 8L, 5L, false, new DateTime(2021, 6, 21, 7, 36, 7, 882, DateTimeKind.Unspecified).AddTicks(2068), 3L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 1L },
                    { 9L, 6L, false, new DateTime(2020, 2, 23, 2, 34, 35, 734, DateTimeKind.Unspecified).AddTicks(5037), 7L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 6L },
                    { 10L, 9L, false, new DateTime(2020, 12, 1, 1, 7, 7, 70, DateTimeKind.Unspecified).AddTicks(6775), 7L, false, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 3L }
                });

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Duration", "IsDeleted", "LocationId", "Name", "StartTime", "TeamId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 11, 10, 17, 23, 31, 752, DateTimeKind.Unspecified).AddTicks(7984), 5L, "Mollitia blanditiis sint magni et.", 18, false, 1L, "fugiat", new DateTimeOffset(new DateTime(2022, 9, 7, 15, 58, 2, 974, DateTimeKind.Unspecified).AddTicks(9191), new TimeSpan(0, 3, 0, 0, 0)), 1L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2L, new DateTime(2019, 10, 29, 7, 10, 52, 760, DateTimeKind.Unspecified).AddTicks(921), 7L, "sit", 34, false, 4L, "maxime", new DateTimeOffset(new DateTime(2023, 4, 5, 12, 13, 16, 52, DateTimeKind.Unspecified).AddTicks(180), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3L, new DateTime(2020, 9, 10, 17, 48, 5, 563, DateTimeKind.Unspecified).AddTicks(5178), 1L, "Soluta deleniti et ut dolore vel occaecati reprehe", 43, false, 5L, "ipsam", new DateTimeOffset(new DateTime(2023, 2, 23, 7, 33, 52, 261, DateTimeKind.Unspecified).AddTicks(5533), new TimeSpan(0, 2, 0, 0, 0)), 10L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4L, new DateTime(2019, 9, 18, 22, 36, 10, 432, DateTimeKind.Unspecified).AddTicks(3802), 4L, "non", 18, false, 1L, "laboriosam", new DateTimeOffset(new DateTime(2023, 7, 16, 23, 36, 57, 149, DateTimeKind.Unspecified).AddTicks(4320), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5L, new DateTime(2021, 2, 20, 16, 44, 38, 752, DateTimeKind.Unspecified).AddTicks(4531), 1L, "eos", 37, false, 5L, "repellat", new DateTimeOffset(new DateTime(2023, 2, 23, 16, 36, 51, 510, DateTimeKind.Unspecified).AddTicks(8135), new TimeSpan(0, 2, 0, 0, 0)), 9L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6L, new DateTime(2020, 11, 11, 19, 48, 50, 909, DateTimeKind.Unspecified).AddTicks(8773), 1L, "Vitae reiciendis velit illo eaque.", 26, false, 1L, "veritatis", new DateTimeOffset(new DateTime(2022, 9, 14, 8, 34, 5, 722, DateTimeKind.Unspecified).AddTicks(1448), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7L, new DateTime(2020, 2, 14, 2, 20, 13, 721, DateTimeKind.Unspecified).AddTicks(5674), 2L, "Voluptatem aliquid ut adipisci optio rerum eum pla", 12, false, 1L, "nisi", new DateTimeOffset(new DateTime(2023, 6, 6, 8, 42, 38, 9, DateTimeKind.Unspecified).AddTicks(6306), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8L, new DateTime(2021, 1, 23, 14, 38, 49, 249, DateTimeKind.Unspecified).AddTicks(4856), 10L, "Vero rerum recusandae totam et. Distinctio quia en", 29, false, 2L, "ut", new DateTimeOffset(new DateTime(2022, 10, 21, 23, 25, 37, 944, DateTimeKind.Unspecified).AddTicks(4229), new TimeSpan(0, 3, 0, 0, 0)), 10L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9L, new DateTime(2019, 11, 26, 16, 26, 5, 789, DateTimeKind.Unspecified).AddTicks(2413), 6L, "Consequuntur ut earum.", 54, false, 4L, "sit", new DateTimeOffset(new DateTime(2023, 4, 9, 0, 4, 18, 954, DateTimeKind.Unspecified).AddTicks(7694), new TimeSpan(0, 3, 0, 0, 0)), 2L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10L, new DateTime(2019, 10, 21, 9, 35, 57, 231, DateTimeKind.Unspecified).AddTicks(1140), 3L, "Dolore ut tempore dignissimos accusamus et rerum i", 13, false, 3L, "voluptas", new DateTimeOffset(new DateTime(2022, 8, 18, 2, 39, 2, 180, DateTimeKind.Unspecified).AddTicks(1703), new TimeSpan(0, 3, 0, 0, 0)), 4L, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "IsDeleted", "Role", "Status", "TeamId", "UserId" },
                values: new object[,]
                {
                    { 1L, false, 2, 2, 1L, 1L },
                    { 2L, false, 1, 2, 2L, 2L },
                    { 3L, false, 2, 2, 3L, 3L },
                    { 4L, false, 1, 2, 4L, 4L },
                    { 5L, false, 2, 2, 5L, 5L },
                    { 6L, false, 1, 1, 6L, 6L },
                    { 7L, false, 2, 2, 7L, 7L },
                    { 8L, false, 1, 1, 8L, 8L },
                    { 9L, false, 2, 1, 9L, 9L },
                    { 10L, false, 1, 1, 10L, 10L }
                });

            migrationBuilder.InsertData(
                table: "AdvancedSlotSettings",
                columns: new[] { "Id", "ActivityType", "AvailabilitySlotId", "BookingScheduleBlockingTimeMeetingInHours", "Color", "Days", "EndDate", "IsDeleted", "MaxNumberOfBookings", "PaddingBeforeMeeting", "StartDate" },
                values: new object[,]
                {
                    { 1L, 3, 1L, 5, 1, 9, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 8, 12, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2L, 3, 2L, 4, 4, 12, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 1, 13, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3L, 1, 3L, 4, 1, 3, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 10, 10, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4L, 2, 4L, 5, 3, 14, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 3, 13, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5L, 1, 5L, 5, 7, 30, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 8, 14, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6L, 1, 6L, 1, 4, 30, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 6, 15, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7L, 3, 7L, 1, 7, 14, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 9, 11, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8L, 2, 8L, 4, 4, 15, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 9, 5, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9L, 1, 9L, 4, 4, 26, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 9, 10, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10L, 3, 10L, 1, 5, 29, new DateTimeOffset(new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, 10, 3, new DateTimeOffset(new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "CalendarVisibleForTeams",
                columns: new[] { "Id", "CalendarId", "IsDeleted", "TeamId" },
                values: new object[,]
                {
                    { 1L, 1L, false, 1L },
                    { 2L, 2L, false, 2L },
                    { 3L, 3L, false, 3L },
                    { 4L, 4L, false, 4L },
                    { 5L, 5L, false, 5L },
                    { 6L, 6L, false, 6L },
                    { 7L, 7L, false, 7L },
                    { 8L, 8L, false, 8L },
                    { 9L, 9L, false, 9L },
                    { 10L, 10L, false, 10L }
                });

            migrationBuilder.InsertData(
                table: "ExternalAttendees",
                columns: new[] { "Id", "AvailabilitySlotId", "Email", "EventTime", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1L, 9L, "Pablo49@yahoo.com", new DateTimeOffset(new DateTime(2022, 9, 17, 18, 24, 45, 931, DateTimeKind.Unspecified).AddTicks(3926), new TimeSpan(0, 3, 0, 0, 0)), false, "Pablo Runolfsdottir" },
                    { 2L, 8L, "Leon_Purdy@yahoo.com", new DateTimeOffset(new DateTime(2022, 11, 11, 19, 8, 11, 474, DateTimeKind.Unspecified).AddTicks(6298), new TimeSpan(0, 2, 0, 0, 0)), false, "Leon Purdy" },
                    { 3L, 4L, "Lucia_Hirthe64@gmail.com", new DateTimeOffset(new DateTime(2023, 1, 12, 14, 47, 24, 193, DateTimeKind.Unspecified).AddTicks(5126), new TimeSpan(0, 2, 0, 0, 0)), false, "Lucia Hirthe" },
                    { 4L, 5L, "Rochelle_Dibbert71@yahoo.com", new DateTimeOffset(new DateTime(2023, 6, 13, 6, 18, 37, 448, DateTimeKind.Unspecified).AddTicks(6189), new TimeSpan(0, 3, 0, 0, 0)), false, "Rochelle Dibbert" },
                    { 5L, 9L, "Jimmy74@hotmail.com", new DateTimeOffset(new DateTime(2023, 6, 26, 21, 39, 0, 230, DateTimeKind.Unspecified).AddTicks(8573), new TimeSpan(0, 3, 0, 0, 0)), false, "Jimmy Dickens" },
                    { 6L, 7L, "Mattie.Leannon17@yahoo.com", new DateTimeOffset(new DateTime(2023, 6, 11, 11, 6, 31, 575, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 3, 0, 0, 0)), false, "Mattie Leannon" },
                    { 7L, 2L, "Leonard_Kutch@hotmail.com", new DateTimeOffset(new DateTime(2022, 11, 19, 13, 42, 9, 67, DateTimeKind.Unspecified).AddTicks(4341), new TimeSpan(0, 2, 0, 0, 0)), false, "Leonard Kutch" },
                    { 8L, 10L, "Pearl90@gmail.com", new DateTimeOffset(new DateTime(2023, 6, 4, 12, 40, 28, 731, DateTimeKind.Unspecified).AddTicks(7203), new TimeSpan(0, 3, 0, 0, 0)), false, "Pearl Koepp" },
                    { 9L, 3L, "Ira52@yahoo.com", new DateTimeOffset(new DateTime(2023, 2, 28, 0, 42, 33, 416, DateTimeKind.Unspecified).AddTicks(6088), new TimeSpan(0, 2, 0, 0, 0)), false, "Ira Cruickshank" },
                    { 10L, 6L, "Shirley.Medhurst23@gmail.com", new DateTimeOffset(new DateTime(2023, 7, 2, 15, 46, 27, 20, DateTimeKind.Unspecified).AddTicks(5973), new TimeSpan(0, 3, 0, 0, 0)), false, "Shirley Medhurst" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AvailabilitySlotId", "IsDeleted", "Text" },
                values: new object[,]
                {
                    { 1L, 9L, false, "doloremqueAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" },
                    { 2L, 1L, false, "Enim doloribus est quasi.AAAAAAAAAAAAAAAAAAAAAAAAA" },
                    { 3L, 7L, false, "Delectus dolore quasi aut alias delectus dignissimos ut est." },
                    { 4L, 8L, false, "eosAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" },
                    { 5L, 4L, false, "At temporibus sit nostrum vel est accusantium sit reiciendis accusamus.\nQuo dolorem quod est tempore numquam tempora.\nBlanditiis molestiae tempore tenetur aut quo voluptate assumenda voluptates consequatur.\nA ut consequatur veniam totam at ex aspernatur doloribus.\nQuia fugiat facilis." },
                    { 6L, 7L, false, "Est quos enim rem nemo commodi nulla dicta delectus esse. Qui est qui dolorum voluptas excepturi delectus excepturi. Voluptatum repellat eos eos eos dignissimos sunt vitae veritatis maiores. Sit omnis libero minus excepturi. Adipisci nihil commodi eveniet quos perspiciatis laborum et veniam temporib" },
                    { 7L, 7L, false, "etAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" },
                    { 8L, 5L, false, "liberoAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" },
                    { 9L, 5L, false, "Cum qui vitae.AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" },
                    { 10L, 6L, false, "Quia aut nihil voluptas odit iure. Quasi accusamus consequatur. Sapiente ab reprehenderit qui quasi. Maiores voluptas aut. Aut maxime placeat debitis illo harum natus quia enim a. Recusandae eius enim." }
                });

            migrationBuilder.InsertData(
                table: "TeamMemberMeetings",
                columns: new[] { "Id", "EventId", "IsDeleted", "MemberId", "Priority" },
                values: new object[,]
                {
                    { 1L, 1L, false, 1L, 5 },
                    { 2L, 2L, false, 2L, 7 }
                });

            migrationBuilder.InsertData(
                table: "TeamMemberMeetings",
                columns: new[] { "Id", "EventId", "IsDeleted", "MemberId", "Priority" },
                values: new object[,]
                {
                    { 3L, 3L, false, 3L, 3 },
                    { 4L, 4L, false, 4L, 4 },
                    { 5L, 5L, false, 5L, 10 },
                    { 6L, 6L, false, 6L, 5 },
                    { 7L, 7L, false, 7L, 5 },
                    { 8L, 8L, false, 8L, 3 },
                    { 9L, 9L, false, 9L, 9 },
                    { 10L, 10L, false, 10L, 2 }
                });

            migrationBuilder.InsertData(
                table: "UserSlot",
                columns: new[] { "Id", "AvailabilitySlotId", "IsDeleted", "UserId" },
                values: new object[,]
                {
                    { 1L, 1L, false, 1L },
                    { 2L, 2L, false, 2L },
                    { 3L, 3L, false, 3L },
                    { 4L, 4L, false, 4L },
                    { 5L, 5L, false, 5L },
                    { 6L, 6L, false, 6L },
                    { 7L, 7L, false, 7L },
                    { 8L, 8L, false, 8L },
                    { 9L, 9L, false, 9L },
                    { 10L, 10L, false, 10L }
                });

            migrationBuilder.InsertData(
                table: "ExternalAttendeeAvailabilities",
                columns: new[] { "Id", "EndEvent", "ExternalAttendeeId", "IsDeleted", "StartEvent" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2022, 8, 13, 23, 40, 7, 952, DateTimeKind.Unspecified).AddTicks(9939), new TimeSpan(0, 3, 0, 0, 0)), 10L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 23, 40, 7, 952, DateTimeKind.Unspecified).AddTicks(9839), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2L, new DateTimeOffset(new DateTime(2022, 8, 13, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(51), new TimeSpan(0, 3, 0, 0, 0)), 2L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(43), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3L, new DateTimeOffset(new DateTime(2022, 8, 13, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(66), new TimeSpan(0, 3, 0, 0, 0)), 7L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(62), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4L, new DateTimeOffset(new DateTime(2022, 8, 13, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(78), new TimeSpan(0, 3, 0, 0, 0)), 6L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(74), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5L, new DateTimeOffset(new DateTime(2022, 8, 13, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(89), new TimeSpan(0, 3, 0, 0, 0)), 3L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(85), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6L, new DateTimeOffset(new DateTime(2022, 8, 13, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(100), new TimeSpan(0, 3, 0, 0, 0)), 9L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(96), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7L, new DateTimeOffset(new DateTime(2022, 8, 13, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(112), new TimeSpan(0, 3, 0, 0, 0)), 3L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(108), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8L, new DateTimeOffset(new DateTime(2022, 8, 13, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(123), new TimeSpan(0, 3, 0, 0, 0)), 7L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(119), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9L, new DateTimeOffset(new DateTime(2022, 8, 13, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(134), new TimeSpan(0, 3, 0, 0, 0)), 3L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(130), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10L, new DateTimeOffset(new DateTime(2022, 8, 13, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(144), new TimeSpan(0, 3, 0, 0, 0)), 10L, false, new DateTimeOffset(new DateTime(2022, 8, 12, 23, 40, 7, 953, DateTimeKind.Unspecified).AddTicks(141), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "AdvancedSlotSettings",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "CalendarVisibleForTeams",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendeeAvailabilities",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "TeamMemberMeetings",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "UserSlot",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "ExternalAttendees",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "AvailabilitySlots",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L);
        }
    }
}
